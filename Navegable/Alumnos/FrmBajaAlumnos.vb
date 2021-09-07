
'En éste programa hay que resolver si hace falta abrir y cerrar la conexión cada vez que se hace una consulta a la bd
Imports System.Data.SqlClient


Public Class FrmBajaAlumnos


    Dim numeroOrden As Integer


    Private Sub FrmBajaAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga de alumnos en ComboBox y DataGridView
        conectar()
        Cargar()
        cerrar()
    End Sub

    Private Sub Cargar()

        Dim hayAlumnos As String = "SELECT * FROM alumnos WHERE estado = 'activo'"
        Dim comandoHayAlumnos As New SqlCommand(hayAlumnos, conexion)

        If comandoHayAlumnos.ExecuteNonQuery() <> 0 Then
            Try
                Dim consultaAlumnos As String = "SELECT codigo_familia, codigo_alumno, nombre_apellido_alumno, hermano_numero FROM alumnos  WHERE estado = 'activo' ORDER BY nombre_apellido_alumno"
                Dim adaptadorAlumnos As New SqlDataAdapter(consultaAlumnos, conexion)
                Dim datosAlumnos As New DataSet

                datosAlumnos.Tables.Add("alumnos")
                adaptadorAlumnos.Fill(datosAlumnos.Tables("alumnos"))

                CbxCodigoFamilia.DataSource = datosAlumnos.Tables("alumnos")
                CbxCodigoFamilia.DisplayMember = "codigo_familia"
                CbxNumeroOrden.DataSource = datosAlumnos.Tables("alumnos")
                CbxNumeroOrden.DisplayMember = "hermano_numero"
                CbxAlumno.DataSource = datosAlumnos.Tables("alumnos")
                CbxAlumno.DisplayMember = "nombre_apellido_alumno"
                CbxCodigoAlumno.DataSource = datosAlumnos.Tables("alumnos")
                CbxCodigoAlumno.DisplayMember = "codigo_alumno"
            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try

            DataGrid()
        Else
            MsgBox("No hay alumnos para dar de baja")
        End If

    End Sub


    Private Sub DataGrid()
        Try
            Dim AlumnosDatos = "SELECT dni, edad, curso FROM alumnos JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso WHERE codigo_alumno = '" & Val(CbxCodigoAlumno.Text) & "' AND alumnos.estado = 'activo'"
            'consulta = "select dni, edad, curso from alumnos where codigo_alumno= '" & Val(CbxCodigoAlumno.Text) & "' "
            'Dim comandoDatos As New SqlCommand(AlumnosDatos, conexion)
            Dim adaptador As New SqlDataAdapter(AlumnosDatos, conexion)
            Dim dataSet As New DataSet()
            adaptador.Fill(dataSet)
            DgvAlumnos.DataSource = dataSet.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try

        'CbxAlumno.DataSource = Nothing
        'CbxAlumno.DisplayMember = Nothing
        'CbxAlumno.ValueMember = Nothing
        'DgvAlumnos.DataSource = ""
        'DgvAlumnos.Columns.Clear()

    End Sub

    Private Sub BtnBajaAlumno_Click(sender As Object, e As EventArgs) Handles BtnBajaAlumno.Click
        Dim hermanos As String
        Dim parcial As Integer
        Dim totalHermanos As Integer
        Dim maximo As Integer
        abrir()
        Dim opcion As DialogResult = MessageBox.Show("¿Realmente quiere dar de baja al alumno " & CbxAlumno.Text & "?", "¡Registro a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

        If (opcion = Windows.Forms.DialogResult.Yes) Then

            Try
                Dim baja As String = "UPDATE alumnos SET estado = 'inactivo' WHERE codigo_alumno ='" & CbxCodigoAlumno.Text & "' "
                Dim comando As New SqlCommand(baja, conexion)

                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Alumno dado de baja exitosamente")


                    numeroOrden = Val(CbxNumeroOrden.Text)    'En la variable numeroOrden se guarda el número de hermano eliminado


                Else
                    MessageBox.Show("¡Error! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Show()
                End If

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try

        End If

        'Se cuenta la cantidad de hermanos del eliminado y se almacena en la variable: totalHermanos
        'abrir()
        hermanos = "SELECT COUNT(codigo_alumno) FROM alumnos WHERE codigo_familia = '" & CbxCodigoFamilia.Text & "' AND estado = 'activo'"

        Dim comando1 As New SqlCommand(hermanos, conexion)
        parcial = comando1.ExecuteScalar
        totalHermanos = parcial
        If parcial <> 0 Then
            'Se busca la edad del más chico de la familia del alumno eliminado y se almacena en 
            'la variable: menor

            Dim maximoHermanoNumero As String = "SELECT MAX(hermano_numero) FROM alumnos WHERE codigo_familia= " & Val(CbxCodigoFamilia.Text) & " AND estado = 'activo'"
            Dim comando2 As New SqlCommand(maximoHermanoNumero, conexion)
            maximo = comando2.ExecuteScalar

            'Con el numero de orden y el número de hermanos se ejecuta un condicional, si el eliminado
            'era el último hermano se deja todo como está y si no se ingresa a un bucle que baja una unidad
            'a todos los hermanos que estaban con número_hermano mayor al eliminado. 
            Dim CodigoFam As Integer
            CodigoFam = Val(CbxCodigoFamilia.Text)
            Dim codigoDeleted As Integer
            codigoDeleted = CbxCodigoAlumno.Text
            Dim dif As Integer = totalHermanos - numeroOrden


            While numeroOrden < maximo
                Dim actualiza As String = "UPDATE alumnos SET  hermano_numero = '" & numeroOrden & "'  WHERE  hermano_numero = '" & numeroOrden + 1 & "'  AND codigo_familia= '" & CodigoFam & "' AND estado = 'activo'"
                Dim comandoActualiza As New SqlCommand(actualiza, conexion)
                'comando3.ExecuteNonQuery()

                'El siguiente condicional asegura que solo se baje la unidad solo si hubo un update
                If comandoActualiza.ExecuteNonQuery() = 1 Then
                    numeroOrden += 1
                End If

            End While

        Else
        End If
        Cargar()
    End Sub





    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        cerrar()
        Me.Close()
    End Sub



    Private Sub CbxCodigoAlumno_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoAlumno.SelectedValueChanged
        DataGrid()
        Dim familia As Integer
        familia = Val(CbxCodigoFamilia.Text)
        MsgBox("" & familia & "")
    End Sub



End Class