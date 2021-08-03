Public Class FrmGastos
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub RbnPartida_CheckedChanged(sender As Object, e As EventArgs) Handles RbnPartida.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub
End Class