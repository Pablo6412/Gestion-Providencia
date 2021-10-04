Imports System.Data.SqlClient

Public Class FrmPagoDeudaAño
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmPagoDeudaAño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim meses
        Dim nombreMes
        conectar()
        Try
            Dim familia As String = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, 
                                       CONCAT(apellido_padre,' - ', apellido_madre) AS familia, estado 
                                       FROM familias WHERE estado = 'activo' 
                                       ORDER BY familia"

            Dim adaptadorFamilia = New SqlDataAdapter(familia, conexion)
            Dim datosFamilia = New DataSet
            datosFamilia.Tables.Add("familias")
            adaptadorFamilia.Fill(datosFamilia.Tables("familias"))

            CbxFamilia.DataSource = datosFamilia.Tables("familias")
            CbxFamilia.DisplayMember = "familia"
            CbxCodigo.DataSource = datosFamilia.Tables("familias")
            CbxCodigo.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try

        Dim consulta As String = "SELECT codigo_familia, fecha_de_pago, pago_cumplido FROM detalle_pago_escolar WHERE codigo_familia = " & Val(CbxCodigo.Text) & " and pago_cumplido <> 'completo' "
        Dim adaptador As SqlDataAdapter = New SqlDataAdapter(consulta, conexion)
        Dim dtDatos As DataTable = New DataTable
        adaptador.Fill(dtDatos)

        Dim dataSet As New DataSet()
        adaptador.Fill(dataSet)

        'ClbMeses.DataSource = dtDatos
        'ClbMeses.DisplayMember = "fecha_de_pago"

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            meses = (fila(1))
            nombreMes = meses.Month
            ClbMeses.Items.Add(nombreMes)

        Next






        'ClbMeses.Items.AddRange(
        '    (
        '       From month In CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
        '       Where Not String.IsNullOrEmpty(month)).ToArray
        '    )

        'ClbMeses.SelectedIndex = Now.Month - 3

    End Sub
End Class