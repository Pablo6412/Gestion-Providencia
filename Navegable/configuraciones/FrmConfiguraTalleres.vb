Imports System.Data.SqlClient

Public Class FrmConfiguraTalleres
    Dim adaptador As New SqlDataAdapter
    Dim datos As DataSet
    Dim codigo As Integer
    Dim codigo2 As Integer
    Dim contador As Integer = 0
    'Dim contador1 As Integer = 0


    Private Sub FrmConfiguraTalleres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        conectar()
        BuscaTaller()
        BuscaSinAsignar()
    End Sub


    Private Sub BuscaTaller()
        Dim taller As String = "SELECT codigo_taller, taller_nombre FROM taller WHERE codigo_taller Not In (Select MIN(codigo_taller) FROM taller) ORDER BY codigo_taller"
        adaptador = New SqlDataAdapter(taller, conexion)

        datos = New DataSet
        datos.Tables.Add("taller")
        adaptador.Fill(datos.Tables("taller"))
        LbxTalleres.DataSource = datos.Tables("taller")
        LbxTalleres.DisplayMember = "taller_nombre"
        LbxActualiza.DataSource = datos.Tables("taller")
        LbxActualiza.DisplayMember = "taller_nombre"

        Dim lista As List(Of String) = New List(Of String)

    End Sub

    Private Sub BuscaSinAsignar()
        Dim consulta As String = "SELECT TOP 1 codigo_taller FROM taller WHERE taller_nombre = 'Sin asignar' ORDER BY codigo_taller"
        Dim comando As New SqlCommand(consulta, conexion)
        codigo = comando.ExecuteScalar
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Dim value As Integer = LbxTalleres.Items.
        'If LbxTalleres.Text <> "Sin asignar" Then
        '    MsgBox("Debe elejir un item con el texto '" & "Sin asignar" & "' ")
        'Else
        If TxtTaller.Text = "" Or TxtImporte.Text = "" Then
            MsgBox("Debe asignarle un nombre y un importe al taller")
        Else
            Dim NuevoTaller As String = "UPDATE taller SET taller_nombre = '" & TxtTaller.Text & "', taller_importe = '" & TxtImporte.Text & "' WHERE codigo_taller = '" & codigo & "'"
            Dim comando As New SqlCommand(NuevoTaller, conexion)
            comando.ExecuteNonQuery()

            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("El taller " & TxtTaller.Text & " se incorporó correctamente")

            Else
                MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
            End If
            'AgregaTaller(TxtTaller)
        End If
        'End If
        BuscaTaller()
    End Sub

    Private Sub LbxActualiza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbxActualiza.SelectedIndexChanged

        If contador <> 0 Then

            Dim lista As Byte
            Dim taller As String = "SELECT * FROM taller WHERE taller_nombre = '" & LbxActualiza.Text & "'"
            adaptador = New SqlDataAdapter(taller, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet

            adaptador.Fill(datos, "taller")
            lista = datos.Tables("taller").Rows.Count
            codigo2 = datos.Tables("taller").Rows(0).Item("codigo_taller")
            TxtTallerActualiza.Text = datos.Tables("taller").Rows(0).Item("taller_nombre")
            TxtImporteActualiza.Text = datos.Tables("taller").Rows(0).Item("taller_importe")
        End If
        contador += 1

    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim tallerActualizado As String = "UPDATE taller SET taller_nombre = '" & TxtTallerActualiza.Text & "', taller_importe = '" & Val(TxtImporteActualiza.Text) & "' WHERE codigo_taller = '" & codigo2 & "' "
        Dim comando As New SqlCommand(tallerActualizado, conexion)
        comando.ExecuteNonQuery()

        If comando.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Datos actualizados")

        Else
            MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
        End If
        BuscaTaller()
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir2_Click(sender As Object, e As EventArgs) Handles BtnSalir2.Click
        Me.Close()
    End Sub

End Class