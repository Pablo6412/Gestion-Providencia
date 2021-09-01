Imports System.Data.SqlClient
Public Class FrmBajasFamilias
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Dim concatena As String
    Dim opcion

    Private Sub FrmBajasFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        'Carga lista de familias

        CargarFamilias()
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If CbxCodigo.Text = "" Then
            opcion = MessageBox.Show("Debe seleccionar una familia ", "¡Campos vacios!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            opcion = MessageBox.Show("¿Realmente quiere dar de baja a ésta familia? ", "¡Registro a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        End If
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            abrir()
            Dim baja As String = "update familias set  estado = 'Inactivo'
                                                                              
                                         where codigo_familia='" & Me.CbxCodigo.Text & "' "

            Dim comando As New SqlCommand(baja, conexion)
            comando.ExecuteNonQuery()

            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Familia dada de baja exitosamente")
                CbxCodigo.Text = ("")
                CbxFamilia.Text = ("")
                CargarFamilias()
                CbxCodigo.Focus()

            Else
                MessageBox.Show("¡Error! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        cerrar()
    End Sub
    Private Sub BtnReincorporar_Click(sender As Object, e As EventArgs) Handles BtnReincorporar.Click

        If CbxReincorporaCodigo.Text = "" Then
            opcion = MessageBox.Show("Debe seleccionar una familia ", "¡Campos vacios!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            opcion = MessageBox.Show("¿Realmente quiere reincorporar a ésta familia? ", "¡Está a punto de reincorporar ésta familia!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        End If
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            abrir()
            Dim actualiza As String = "update familias set  estado = 'Activo'
                                                                              
                                         where codigo_familia='" & Me.CbxReincorporaCodigo.Text & "' "

            Dim comando As New SqlCommand(actualiza, conexion)
            comando.ExecuteNonQuery()
            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Familia reincorporada exitosamente")
                CbxReincorporaCodigo.Text = ("")
                CbxReincorporaFamilia.Text = ("")
                CargarFamilias()
                CbxCodigo.Focus()

            Else
                MessageBox.Show("¡Error! Reincorporación fallida. Reinicie el programa e intente nuevamente", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        cerrar()
    End Sub

    Sub CargarFamilias()
        abrir()

        Try
            concatena = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, CONCAT (apellido_padre,' - ', apellido_madre) AS familia, estado FROM familias WHERE estado = 'activo' ORDER BY familia"
            adaptador = New SqlDataAdapter(concatena, conexion)
            datos = New DataSet
            datos.Tables.Add("familias")
            adaptador.Fill(datos.Tables("familias"))

            CbxFamilia.DataSource = datos.Tables("familias")
            CbxFamilia.DisplayMember = "familia"
            CbxCodigo.DataSource = datos.Tables("familias")
            CbxCodigo.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try

        'Carga familias dadas de baja
        Try
            concatena = "select codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, concat (apellido_padre,' - ', apellido_madre) as familia, estado from familias where estado = 'inactivo'"
            adaptador = New SqlDataAdapter(concatena, conexion)
            datos = New DataSet
            datos.Tables.Add("familias")
            adaptador.Fill(datos.Tables("familias"))
            CbxReincorporaFamilia.DataSource = datos.Tables("familias")
            CbxReincorporaFamilia.DisplayMember = "familia"
            CbxReincorporaCodigo.DataSource = datos.Tables("familias")
            CbxReincorporaCodigo.DisplayMember = "codigo_familia"
        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try
        cerrar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class