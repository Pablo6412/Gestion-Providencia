Imports System.Data.SqlClient

Public Class FrmPagoDeudaCampamento

    Dim totalCampamento As Decimal
    Private Sub FrmPagoDeudaCampamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()

        Try
            Dim familia As String = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, CONCAT(apellido_padre,' - ', apellido_madre) AS familia, estado FROM familias WHERE estado = 'activo' ORDER BY familia"

            Dim adaptador As New SqlDataAdapter(familia, conexion)
            Dim datos As New DataSet
            datos.Tables.Add("familias")
            adaptador.Fill(datos.Tables("familias"))

            CbxFamilia.DataSource = datos.Tables("familias")
            CbxFamilia.DisplayMember = "familia"
            CbxCodigo.DataSource = datos.Tables("familias")
            CbxCodigo.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged
        DataGrid()
    End Sub

    Public Sub DataGrid()

        'Dim restrictionValues() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}
        'Dim dt As DataTable = conexion.GetSchema("TABLES", restrictionValues)
        'Dim rows() As DataRow = dt.Select("TABLE_NAME = 'pago_familia'")
        Try
            Dim campamento As String = "SELECT fecha, SUM(campamento) AS campamento FROM pago_familia WHERE codigo_familia= '" & Val(CbxCodigo.Text) & "'  GROUP BY fecha ORDER BY fecha"

            Dim comandoCampamento As New SqlCommand(campamento, conexion)

            Dim adaptadorCampamento As New SqlDataAdapter(comandoCampamento)
            Dim dataSet As DataSet = New DataSet()
            adaptadorCampamento.Fill(dataSet)
            DgvCampamento.DataSource = dataSet.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try
        'For Each row As DataGridViewRow In Me.DgvCampamento.Rows
        '    totalCampamento = Val(row.Cells(2).Value)
        'Next
        'TxtSubtotal.Text = totalCampamento

        'Dim Total As Single
        'Dim Col As Integer = 2
        'For Each row As DataGridViewRow In Me.DgvCampamento.Rows
        '    Total += Val(row.Cells(Col).Value)
        'Next
        'Me.TxtSubtotal.Text = Total.ToString

    End Sub

    Private Sub DgvCampamento_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvCampamento.CellMouseUp
        Dim total As Decimal
        If e.ColumnIndex = 0 Then

            If DgvCampamento.Rows(e.RowIndex).Cells("Cargar").Value = False Then
                DgvCampamento.Rows(e.RowIndex).Cells("Cargar").Value = True
            Else
                DgvCampamento.Rows(e.RowIndex).Cells("Cargar").Value = False
            End If

            total = 0

            For Each dgvrow As DataGridViewRow In DgvCampamento.Rows
                If dgvrow.Cells("Cargar").Value = True Then
                    total = total + CInt(dgvrow.Cells(2).Value)
                End If
            Next
            TxtTotal.Text = total

        End If
    End Sub
End Class