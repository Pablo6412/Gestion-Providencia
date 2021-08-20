Imports System.Data.SqlClient

Public Class FrmMateriales
    Dim codigoMaterial As Integer
    Dim contador As Integer = 0
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
        CbxAñoActualiza.DataSource = datosAño.Tables("cursos")
        CbxAñoActualiza.DisplayMember = "año"
        CbxCodigoAño.DataSource = datosAño.Tables("cursos")
        CbxCodigoAño.DisplayMember = "codigo_año"

    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If TxtMaterial.Text = "" Then
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

            TxtMaterial.Text = ""
            TxtValor.Text = ""
        Else
            TxtMaterial.Text = ""
            TxtValor.Text = ""
            MsgBox("Aquí Solo puede agregar materiales nuevos. Para actualizar valores click en la pestaña 'actualización de materiales'")
        End If
    End Sub

    Private Sub TxtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValor.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
        cerrar()
    End Sub

    Private Sub BtnSalirActualización_Click(sender As Object, e As EventArgs) Handles BtnSalirActualización.Click
        Me.Close()
        cerrar()
    End Sub

    Private Sub CbxCodigoAño_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoAño.SelectedValueChanged
        Dim material As String = "SELECT codigo_material, material_nombre, valor FROM material WHERE codigo_año = '" & Val(CbxCodigoAño.Text) & "' "

        Dim adaptadorMaterial As New SqlDataAdapter(material, conexion)
        Dim tabla As New DataTable
        adaptadorMaterial.Fill(tabla)
        If contador >= 1 Then
            If tabla.Rows.Count > 0 Then
                codigoMaterial = tabla.Rows(0)("codigo_material")
                TxtMaterialActual.Text = tabla.Rows(0)("material_nombre")
                TxtMaterial.Text = tabla.Rows(0)("material_nombre")
                TxtValorActual.Text = tabla.Rows(0)("valor")
                TxtValor.Text = tabla.Rows(0)("valor")
                TxtMaterialNuevo.Text = TxtMaterialActual.Text
                TxtValorNuevo.Text = TxtValorActual.Text

            Else
                TxtMaterialActual.Text = ""
                TxtMaterial.Text = ""
                TxtValorActual.Text = ""
                TxtValor.Text = ""
                TxtMaterialNuevo.Text = ""
                TxtValorNuevo.Text = ""
                MsgBox("" & CbxAño.Text & " no tiene cargados materales")
            End If
        End If
        contador += 1
    End Sub
End Class