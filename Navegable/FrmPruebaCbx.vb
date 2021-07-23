Imports System.Data.SqlClient

Public Class FrmPruebaCbx
    Dim adaptador As SqlDataAdapter
    Dim datos As DataSet
    Dim comando As New SqlCommand

    Private Sub FrmPruebaCbx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        Try
            Dim nivel As String = "SELECT codigo_nivel, nivel FROM niveles"
            adaptador = New SqlDataAdapter(nivel, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet
            datos.Tables.Add("niveles")
            adaptador.Fill(datos.Tables("niveles"))
            CbxNivel.DataSource = datos.Tables("niveles")
            CbxNivel.DisplayMember = "nivel"
            CbxCodigoNivel.DataSource = datos.Tables("niveles")
            CbxCodigoNivel.DisplayMember = "codigo_nivel"
            TextBox1.Text = CbxCodigoNivel.Text

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub
End Class