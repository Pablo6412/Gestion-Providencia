Public Class FrmConfiguracion
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

        Me.Close()
        FrmPrincipal.Show()
    End Sub



    Private Sub BtnCargaParametros_Click(sender As Object, e As EventArgs) Handles BtnCargaParametros.Click
        FrmCargaNiveles.Show()
    End Sub

    Private Sub BtnAranceles_Click(sender As Object, e As EventArgs) Handles BtnAranceles.Click
        FrmCargaAranceles.Show()
    End Sub

    Private Sub BtnCursos_Click(sender As Object, e As EventArgs) Handles BtnCursos.Click
        FrmCargaCursos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConcepto.Click
        FrmConceptosDePago.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCampamentos.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FrmConfiguraTalleres.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmBecas.Show()
    End Sub
End Class