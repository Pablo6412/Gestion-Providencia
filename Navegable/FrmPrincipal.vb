'Imports MySql.Data.MySqlClient

Public Class FrmPrincipal
    'Dim conexion As New MySqlConnection



    'End Sub
    'MsgBox("" & fechaActual & "")


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub

    Private Sub TlsAltas_Click(sender As Object, e As EventArgs) Handles TlsAltasFamilias.Click
        FrmAltaFamilia.Show()
    End Sub

    Private Sub TlsModifFamilias_Click(sender As Object, e As EventArgs) Handles TlsModifFamilias.Click
        FrmActualizaFamilias.ShowDialog()
    End Sub

    Private Sub TlsBajasDeFamilias_Click(sender As Object, e As EventArgs) Handles TlsBajasDeFamilias.Click
        FrmBajasFamilias.ShowDialog()
    End Sub

    Private Sub TlsAltaAlumnos_Click(sender As Object, e As EventArgs) Handles TlsAltaAlumnos.Click
        FrmAltaAlumnos.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        End
    End Sub

    Public Sub BtnACercaDe_Click(sender As Object, e As EventArgs) Handles BtnACercaDe.Click

        BtnACercaDe.BackColor = System.Drawing.SystemColors.HotTrack
        MessageBox.Show("Versión del sistema: 2021. Realizado por Padres del colegio", "Gestión Providencia", MessageBoxButtons.OK, MessageBoxIcon.None)
        BtnACercaDe.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub TlsActualizacionAlumnos_Click(sender As Object, e As EventArgs) Handles TlsActualizacionAlumnos.Click
        FrmActualizaAlumnos.Show()
    End Sub

    Private Sub TlsBajaAlumnos_Click(sender As Object, e As EventArgs) Handles TlsBajaAlumnos.Click
        FrmBajaAlumnos.Show()
    End Sub

    Private Sub TlsIngresoDePagos_Click(sender As Object, e As EventArgs) Handles TlsIngresoDePagos.Click
        Pagos.Show()
    End Sub

    Private Sub TlsEnviaCorreo_Click(sender As Object, e As EventArgs) Handles TlsEnviaCorreo.Click
        FrmEnviaMail.Show()
    End Sub

    Private Sub TlsGastos_Click(sender As Object, e As EventArgs) Handles TlsGastos.Click
        FrmGastos.Show()
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        'BtnConfiguracion.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Hide()

        FrmConfiguracion.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        FrmPruebaCbx.Show()

    End Sub

    Private Sub InscripciónATalleresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripciónATalleresToolStripMenuItem.Click
        FrmInscripcionTalleres.Show()
    End Sub

    Private Sub DescuentosYBecasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentosYBecasToolStripMenuItem.Click
        FrmDescuentosBecas.Show()
    End Sub

    Private Sub EmisiónDeVencimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmisiónDeVencimientosToolStripMenuItem.Click
        FrmEmisiónDeVencimientos.Show()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        FrmPagosDeudaAño.Show()
    End Sub

    Private Sub OtrosPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrosPagosToolStripMenuItem.Click
        FrmPagoDeudaAñosAnteriores.Show()
    End Sub

    Private Sub PagosDeudaCampamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosDeudaCampamentoToolStripMenuItem.Click
        FrmPagoDeudaCampamento.Show()
    End Sub

    Private Sub PagosAdelantadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosAdelantadosToolStripMenuItem.Click
        FrmPagoAdelantado.Show()
    End Sub
End Class