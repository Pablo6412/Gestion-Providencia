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
    Dim resultado As Decimal

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
                    fecha5 = fecha
                Case 6
                    nombreMes = "Junio"
                    fecha6 = fecha
                Case 7
                    nombreMes = "Julio"
                    fecha7 = fecha
                Case 8
                    nombreMes = "Agosto"
                    fecha8 = fecha
                Case 9
                    nombreMes = "Septiembre"
                    fecha9 = fecha
                Case 10
                    nombreMes = "Octubre"
                    fecha10 = fecha
                Case 11
                    nombreMes = "Noviembre"
                    fecha11 = fecha
                Case 12
                    nombreMes = "Diciembre"
                    fecha12 = fecha
            End Select

            ClbMeses.Items.Add(nombreMes)
            ClbMeses.SelectedValue = fecha

        Next
    End Sub

    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged
        ClbMeses.Items.Clear()
        ListBox1.Items.Clear()
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

        ListBox1.Items.Clear()
        'If ClbMeses.GetItemChecked(i) = True Then
        For j = 0 To indice - 1
                ClbMeses.SetItemChecked(j, True)


        Next
        For i = 0 To Me.ClbMeses.CheckedItems.Count - 1
            Valor = ClbMeses.CheckedItems(i)
            'MsgBox("La casilla chekeada es " & Valor & "") ''Valor contiene el contenido del item chequeado
            If Valor = "Enero" Then
                fecha = fecha1
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Febrero" Then
                fecha = fecha2
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Marzo" Then
                fecha = fecha3
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Abril" Then
                fecha = fecha4
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Mayo" Then
                fecha = fecha5
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Junio" Then
                fecha = fecha6
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Julio" Then
                fecha = fecha7
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Agosto" Then
                fecha = fecha8
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Septiembre" Then
                fecha = fecha9
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Octubre" Then
                fecha = fecha10
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Octubre" Then
                fecha = fecha11
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)

            ElseIf Valor = "Octubre" Then
                fecha = fecha12
                CalculaDeuda(fecha)
                ListBox1.Items.Add(resultado)
            End If
            'End If
        Next
        Dim suma As Integer

        For Each elemento In ListBox1.Items

            suma += elemento.ToString

        Next

        TxtTotal.Text = suma

    End Sub

    Private Sub CalculaDeuda(fecha)
        Dim consultaDeuda As String = "SELECT monto_deuda FROM detalle_pago_escolar WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_de_pago = '" & fecha & "' "
        Dim comandoDeuda As New SqlCommand(consultaDeuda, conexion)
        resultado = comandoDeuda.ExecuteScalar

        'MsgBox("" & resultado & "")
    End Sub

    Private Sub BtnPago_Click(sender As Object, e As EventArgs) Handles BtnPago.Click
        ListBox1.Items.Clear()
        Dim i As Integer
        For i = 0 To ClbMeses.CheckedItems.Count - 1
            ListBox1.Items.Add(ClbMeses.CheckedItems(i))
        Next i
    End Sub
End Class