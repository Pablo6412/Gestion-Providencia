Imports System.Data.SqlClient

Public Class FrmMateriales


    Private Sub FrmMateriales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()
        abrir()
        Dim año As String = "SELECT codigo_año, año FROM cursos GROUP BY codigo_año, año"
        Dim adaptadorAño As New SqlDataAdapter(año, conexion)
        Dim datosAño As New DataSet
        datosAño.Tables.Add("cursos")
        adaptadorAño.Fill(datosAño.Tables("cursos"))


        CbxAño.DataSource = datosAño.Tables("cursos")
        CbxAño.DisplayMember = "año"
        CbxCodigoAño.DataSource = datosAño.Tables("cursos")
        CbxCodigoAño.DisplayMember = "codigo_año"



    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim material As String = "INSERT INTO material (codigo_año, material_nombre, valor) VALUES(@codigo_año, @material_nombre, @valor)"
        Dim comando As New SqlCommand(material, conexion)

        comando.Parameters.AddWithValue("@codigo_año", Val(CbxCodigoAño.Text))
        comando.Parameters.AddWithValue("@material_nombre", TxtMaterial.Text)
        comando.Parameters.AddWithValue("@valor", TxtValor.Text)

        If comando.ExecuteNonQuery() = 0 Then
            MsgBox("Error en la grabación")
        Else
            Dim valorMaterial As String = "UPDATE cursos SET materiales_importe = '" & TxtValor.Text & "' WHERE codigo_año = '" & Val(CbxCodigoAño.Text) & "' "
            Dim comandoValor As New SqlCommand(valorMaterial, conexion)

            If comandoValor.ExecuteNonQuery() > 0 Then
                MsgBox("Nuevo materal guardado")
            Else
                MsgBox("Error en la grabación")
            End If
        End If

    End Sub

    Private Sub TxtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValor.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
        cerrar()
    End Sub


End Class