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

    Private Sub BtnConcepto_Click(sender As Object, e As EventArgs) Handles BtnConcepto.Click
        FrmConceptosDePago.Show()
    End Sub

    Private Sub BtnCampamentos_Click(sender As Object, e As EventArgs) Handles BtnCampamentos.Click
        FrmCampamentos.Show()
    End Sub

    Private Sub BtnTalleres_Click(sender As Object, e As EventArgs) Handles BtnTalleres.Click
        FrmConfiguraTalleres.Show()
    End Sub

    Private Sub BtnBecas_Click(sender As Object, e As EventArgs) Handles BtnBecas.Click
        FrmBecas.Show()
    End Sub

    Private Sub BtnMateriales_Click(sender As Object, e As EventArgs) Handles BtnMateriales.Click
        FrmMateriales.Show()
    End Sub
End Class