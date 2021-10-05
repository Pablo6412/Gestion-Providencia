Imports System.Data.SqlClient

Public Class FrmPagoDeudaAño
    Dim fecha As Date
    Dim fecha1 As Date
    Dim fecha2 As Date
    Dim fecha3 As Date
    Dim fecha4 As Date
    Dim fecha5 As Date
    Dim fecha6 As Date
    Dim fecha7 As Date
    Dim fecha8 As Date
    Dim fecha9 As Date
    Dim fecha10 As Date
    Dim fecha11 As Date
    Dim fecha12 As Date
    Dim deuda As Decimal

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmPagoDeudaAño_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    End Sub

    Private Sub Checked()
        'Dim meses As Date
        Dim numeroMes
        Dim nombreMes




        Dim consulta As String = "SELECT codigo_familia, fecha_de_pago, pago_cumplido FROM detalle_pago_escolar WHERE codigo_familia = " & Val(CbxCodigo.Text) & " and pago_cumplido <> 'completo' "
        Dim adaptador As SqlDataAdapter = New SqlDataAdapter(consulta, conexion)
        Dim dtDatos As DataTable = New DataTable
        adaptador.Fill(dtDatos)

        Dim dataSet As New DataSet()
        adaptador.Fill(dataSet)

        'ClbMeses.DataSource = dtDatos
        'ClbMeses.DisplayMember = "fecha_de_pago"

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            fecha = (fila(1))
            numeroMes = fecha.Month
            Select Case numeroMes
                Case 1
                    nombreMes = "Enero"
                    fecha1 = fecha
                Case 2
                    nombreMes = "Febrero"
                    fecha2 = fecha
                Case 3
                    nombreMes = "Marzo"
                    fecha3 = fecha
                Case 4
                    nombreMes = "Abril"
                    fecha4 = fecha
                Case 5
                    nombreMes = "Mayo"
                Case 6
                    nombreMes = "Junio"
                Case 7
                    nombreMes = "Julio"
                    fecha7 = fecha

                Case 8
                    nombreMes = "Agosto"
                    fecha8 = fecha
                    'MsgBox("" & fecha8 & "")
                Case 9
                    nombreMes = "Septiembre"
                    fecha9 = fecha
                    'MsgBox("" & fecha9 & "")
                Case 10
                    nombreMes = "Octubre"
                    fecha10 = fecha
                    'MsgBox("" & fecha10 & "")
                Case 11
                    nombreMes = "Noviembre"
                Case 12
                    nombreMes = "Diciembre"
            End Select

            ClbMeses.Items.Add(nombreMes)
            ClbMeses.SelectedValue = fecha

        Next
    End Sub

    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged
        ClbMeses.Items.Clear()
        Checked()
    End Sub

    'Private Sub ClbMeses_SelectedValueChanged(sender As Object, e As EventArgs) Handles ClbMeses.SelectedValueChanged
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim Valor As String


    '    For i = 0 To Me.ClbMeses.CheckedItems.Count - 1
    '        Valor = ClbMeses.CheckedItems(i)
    '        MsgBox("La casilla chekeada es " & Valor & "") ''Valor contiene el contenido del item chequeado

    '        'If ClbMeses.GetItemChecked(i) = True Then
    '        For j = 0 To i
    '                ClbMeses.SetItemChecked(0, True)
    '            Next
    '        'End If
    '    Next




    'End Sub

    Private Sub ClbMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClbMeses.SelectedIndexChanged
        Dim i As Integer
        Dim j As Integer
        Dim Valor As String
        Dim indice As Integer
        indice = ClbMeses.SelectedIndex


        'If ClbMeses.GetItemChecked(i) = True Then
        For j = 0 To indice - 1
                ClbMeses.SetItemChecked(j, True)


        Next
        For i = 0 To Me.ClbMeses.CheckedItems.Count - 1
            Valor = ClbMeses.CheckedItems(i)
            MsgBox("La casilla chekeada es " & Valor & "") ''Valor contiene el contenido del item chequeado
            If Valor = "Julio" Then
                fecha = fecha7
                MsgBox("la fecha es " & fecha & "")
                CalculaDeuda(fecha)
            ElseIf Valor = "Agosto" Then
                fecha = fecha8
                MsgBox("la fecha es " & fecha & "")
            ElseIf Valor = "Septiembre" Then
                fecha = fecha9
                MsgBox("la fecha es " & fecha & "")
            ElseIf Valor = "Octubre" Then
                fecha = fecha10
                MsgBox("la fecha es " & fecha & "")
            End If
            'End If
        Next


    End Sub

    Private Sub CalculaDeuda(fecha)
        Dim consultaDeuda As String = "SELECT * FROM detalle_pago_escolar WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_de_pago = '" & fecha & "' "
    End Sub




End Class