

'En éste programa hay que resolver si hace falta abrir y cerrar la conexión cada vez que se hace una consulta a la bd
Imports System.Data.SqlClient


Public Class FrmBajaAlumnos

    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Dim numeroOrden As String
    Dim consulta As String

    Private Sub FrmBajaAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga de alumnos en ComboBox y DataGridView
        conectar()
        Cargar()
        cerrar()
    End Sub

    Private Sub BtnBajaAlumno_Click(sender As Object, e As EventArgs) Handles BtnBajaAlumno.Click
        abrir()
        Dim opcion As DialogResult = MessageBox.Show("¿Realmente quiere dar de baja al alumno " & CbxAlumno.Text & "?", "¡Registro a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

        If (opcion = Windows.Forms.DialogResult.Yes) Then

            Try
                Dim baja As String = "Delete  from alumnos where codigo_alumno ='" & CbxCodigoAlumno.Text & "' "
                Dim comando As New SqlCommand(baja, conexion)

                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Alumno dado de baja exitosamente")

                    'En la variable numeroOrden se guarda el número de hermano eliminado 
                    numeroOrden = CbxNumeroOrden.Text
                    Cargar()
                Else
                    MessageBox.Show("¡Error! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Show()
                End If

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try

        End If

        'Se cuenta la cantidad de hermanos del eliminado y se almacena en la variable: totalHermanos

        Dim hermanos As String
        Dim parcial As Integer
        Dim totalHermanos As Integer
        abrir()
        hermanos = "select count(hermano_numero) from alumnos where codigo_familia = '" & CbxCodigoFamilia.Text & "'"

        Dim comando1 As New SqlCommand(hermanos, conexion)
        parcial = comando1.ExecuteScalar
        totalHermanos = parcial
        If parcial <> 0 Then
            'Se busca el codigo_alumno mas grande de la familia del alumno eliminado y se almacena en 
            'la variable: mayor
            Dim mayor As Integer
            Dim maximo As String
            maximo = "select max(codigo_alumno) from alumnos where codigo_familia= '" & CbxCodigoFamilia.Text & "'"
            Dim comando2 As New SqlCommand(maximo, conexion)
            mayor = comando2.ExecuteScalar

            'Con el numero de orden y el número de hermanos se ejecuta un condicional, si el eliminado
            'era el último hermano se deja todo como está y si no se ingresa a un bucle que baja una unidad
            'a todos los hermanos que estaban con número_hermano mayor al eliminado. 
            Dim CodigoFam As Integer
            CodigoFam = Val(CbxCodigoFamilia.Text)
            Dim codigoDeleted As Integer
            codigoDeleted = CbxCodigoAlumno.Text
            Dim dif As Integer = totalHermanos - numeroOrden
            If codigoDeleted < mayor Then


                While mayor > codigoDeleted
                    Dim actualiza As String = "update alumnos Set  hermano_numero = '" & totalHermanos & "'  where  codigo_alumno = '" & mayor & "'  and codigo_familia= '" & CodigoFam & "'"
                    Dim comando3 As New SqlCommand(actualiza, conexion)
                    comando3.ExecuteNonQuery()

                    'El siguiente condicional asegura que solo se baje la unidad solo si hubo un update
                    If comando3.ExecuteNonQuery() = 1 Then
                        totalHermanos -= 1
                    End If
                    mayor -= 1
                End While
            End If
        Else
        End If
    End Sub


    Sub Cargar()
        Dim adaptador2 As New SqlDataAdapter
        Dim filasTabla As Integer
        Dim consulta2 As String = "SELECT COUNT(codigo_alumno) FROM alumnos"
        Dim comando4 As New SqlCommand(consulta2, conexion)
        filasTabla = comando4.ExecuteScalar

        If filasTabla <> 0 Then
            Try
                consulta = "SELECT codigo_familia, codigo_alumno, nombre_apellido_alumno, hermano_numero FROM alumnos ORDER BY nombre_apellido_alumno"
                adaptador = New SqlDataAdapter(consulta, conexion)
                datos = New DataSet

                datos.Tables.Add("alumnos")
                adaptador.Fill(datos.Tables("alumnos"))

                CbxCodigoFamilia.DataSource = datos.Tables("alumnos")
                CbxCodigoFamilia.DisplayMember = "codigo_familia"

                CbxNumeroOrden.DataSource = datos.Tables("alumnos")
                CbxNumeroOrden.DisplayMember = "hermano_numero"


                CbxAlumno.DataSource = datos.Tables("alumnos")
                CbxAlumno.DisplayMember = "nombre_apellido_alumno"
                CbxCodigoAlumno.DataSource = datos.Tables("alumnos")
                CbxCodigoAlumno.DisplayMember = "codigo_alumno"
            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
            End Try

            DataGrid()
        Else
            MsgBox("No hay alumnos para dar de baja")
        End If
    End Sub

    Private Sub DataGrid()
        Try
            consulta = "Select dni, edad, curso from alumnos JOIN cursos On cursos.codigo_curso = alumnos.codigo_curso where codigo_alumno= '" & Val(CbxCodigoAlumno.Text) & "' "
            'consulta = "select dni, edad, curso from alumnos where codigo_alumno= '" & Val(CbxCodigoAlumno.Text) & "' "
            Dim comando5 As New SqlCommand(consulta, conexion)
            adaptador = New SqlDataAdapter(comando5)
            Dim dataSet As DataSet = New DataSet()
            adaptador.Fill(dataSet)
            DgvAlumnos.DataSource = dataSet.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try

        'CbxAlumno.DataSource = Nothing
        'CbxAlumno.DisplayMember = Nothing
        'CbxAlumno.ValueMember = Nothing
        'DgvAlumnos.DataSource = ""
        'DgvAlumnos.Columns.Clear()

    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        cerrar()
        Me.Close()
    End Sub



    Private Sub CbxCodigoAlumno_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoAlumno.SelectedValueChanged
        DataGrid()
    End Sub
End Class