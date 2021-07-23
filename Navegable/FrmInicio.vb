Public Class FrmInicio
    Private Sub SplitContainer2_Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value = ProgressBar1.Value + 5
            LblTimer.Text = "Cargando sistema al " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Me.Hide()
            FrmPrincipal.Show()
        End If
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class