
Imports System.Data.SqlClient
Public Class Pagos
    Dim total As Decimal
    Dim diferencia As Decimal
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Dim comando As New SqlCommand
    Dim contador As Integer = 0
    Dim TotalCuota As Decimal
    Dim TotalCampamento As Decimal
    Dim TotalTalleres As Decimal
    Dim TotalMaterial As Decimal
    Dim TotalAdicional As Decimal
    Dim TotalComedor As Decimal
    Dim totalConceptos As Decimal
    Dim opcion

    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sinAsignar1 As String
        Dim sinAsignar2 As String
        Dim sinAsignar3 As String

        conectar()                           'Conección a base de datos
        abrir()
        Dim adaptador1 As SqlDataAdapter
        Dim datos1 As DataSet
        Dim conceptos As String = "SELECT * FROM concepto_de_pago"
        adaptador1 = New SqlDataAdapter(conceptos, conexion)
        'Dim comando As New SqlCommand
        datos1 = New DataSet
        adaptador1.Fill(datos1, "concepto_de_pago")

        'LblMatricula.Text = datos1.Tables("concepto_de_pago").Rows(0).Item("concepto_nombre")
        'LblCampamento.Text = datos1.Tables("concepto_de_pago").Rows(1).Item("concepto_nombre")
        'LblCuota.Text = datos1.Tables("concepto_de_pago").Rows(2).Item("concepto_nombre")

        'LblAdicional.Text = datos1.Tables("concepto_de_pago").Rows(3).Item("concepto_nombre")
        'LblMateriales.Text = datos1.Tables("concepto_de_pago").Rows(4).Item("concepto_nombre")
        'LblComedor.Text = datos1.Tables("concepto_de_pago").Rows(5).Item("concepto_nombre")

        'LblTalleres.Text = datos1.Tables("concepto_de_pago").Rows(6).Item("concepto_nombre")

        'LblSinAsignar1.Text = datos1.Tables("concepto_de_pago").Rows(7).Item("concepto_nombre")
        'LblSinAsignar3.Text = datos1.Tables("concepto_de_pago").Rows(8).Item("concepto_nombre")
        'LblSinAsignar2.Text = datos1.Tables("concepto_de_pago").Rows(9).Item("concepto_nombre")

        sinAsignar1 = datos1.Tables("concepto_de_pago").Rows(7).Item("concepto_nombre")
        sinAsignar2 = datos1.Tables("concepto_de_pago").Rows(8).Item("concepto_nombre")
        sinAsignar3 = datos1.Tables("concepto_de_pago").Rows(9).Item("concepto_nombre")
        LblSinAsignar1.Text = "" & sinAsignar1 & ":"
        LblSinAsignar2.Text = "" & sinAsignar2 & ":"
        LblSinAsignar3.Text = "" & sinAsignar3 & ":"

        If LblSinAsignar1.Text = "Sin asignar:" Then
            TxtSinAsignar1.Hide()
            LblSinAsignar1.Hide()
        End If

        If LblSinAsignar3.Text = "Sin asignar:" Then
            TxtSinAsignar3.Hide()
            LblSinAsignar3.Hide()
        End If

        If LblSinAsignar2.Text = "Sin asignar:" Then
            TxtSinasignar2.Hide()
            LblSinAsignar2.Hide()
        End If



        RadioButton1.Checked = True
        'Abre la conección
        RdbDetallesPago.Enabled = True
        TxtMontoAPagar.Enabled = False
        TxtTotal.Enabled = False
        TxtSuma.Enabled = False
        TxtDisponible.Enabled = False

        'Carga combobox con familias activas
        Try
            Dim concatena As String = "select codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, concat (apellido_padre,' - ', apellido_madre) as familia, estado from familias where estado = 'activo'"

            adaptador = New SqlDataAdapter(concatena, conexion)
            datos = New DataSet
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

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        abrir()
        TxtDisponible.Text = TxtTotal.Text
        RdbDetallesPago.Checked = True

        If Val(TxtMontoAPagar.Text) <= Val(TxtTotal.Text) Then
            opcion = MessageBox.Show("El monto es suficiente para afrontar el total del vencimiento del mes. Puede Guardar sin nesecidad de cargar los montos de cada concepto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PagoTotal()
            TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        Else
            opcion = MessageBox.Show("El monto es insuficiente para afrontar el total de los conceptos del mes." + vbCr + "SI para realizar el pago parcial" + vbCr + "NO para rectificar el monto a pagar", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (opcion = Windows.Forms.DialogResult.No) Then

                TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
                RdbDetallesPago.Enabled = False
            Else
                PagoParcial()
                TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
            End If
        End If

        DataGrid()
        CalculoTotal()
        RdbDetallesPago.Enabled = True
    End Sub


    Private Sub BtnGuardar2_Click(sender As Object, e As EventArgs) Handles BtnGuardar2.Click
        FormaPago()

        Dim maximo As String = "select max(codigo_pago) as codigo_pago FROM pagos_escolares WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"
        Dim comando3 As New SqlCommand(maximo, conexion)
        TxtCodigoPago.Text = comando3.ExecuteScalar

        'Dim cadena1 As String = "SELECT codigo_pago FROM dbo.pagos_escolares WHERE codigo_familia = " & Val(CbxCodigo.Text) & ""

        Dim cadena As String = "INSERT INTO dbo.detalle_pago_escolar(codigo_familia, matricula, aranceles, materiales, talleres, campamento, adicional_jardin, comedor, fecha_de_pago) 
                                       VALUES(@codigo_familia, @matricula, @aranceles, @materiales, @talleres, @campamento, @adicional_jardin, @comedor, @fecha_de_pago)"
        comando = New SqlCommand(cadena, conexion)

        'comando.Parameters.AddWithValue("@codigo_detalle_pago", Val(TxtCodigoPago.Text))
        comando.Parameters.AddWithValue("@codigo_familia", Val(CbxCodigo.Text))
        comando.Parameters.AddWithValue("@matricula", Val(TxtMatricula.Text))
        comando.Parameters.AddWithValue("@aranceles", Val(TxtArancel.Text))
        comando.Parameters.AddWithValue("@materiales", Val(TxtMateriales.Text))
        comando.Parameters.AddWithValue("@talleres", Val(TxtTalleres.Text))
        comando.Parameters.AddWithValue("@campamento", Val(TxtCampamento.Text))
        comando.Parameters.AddWithValue("@adicional_jardin", Val(TxtAdicionalJardin.Text))
        comando.Parameters.AddWithValue("@comedor", Val(TxtComedor.Text))
        comando.Parameters.AddWithValue("@fecha_de_pago", DtpFechaDePago.Value)

        'txtPrecio.Text = Format(CDec(txtPrecio.Text), "C")
        SaldosDeudores()

        If comando.ExecuteNonQuery() = 1 Then
            'MessageBox.Show("Datos guardados")
            TxtMatricula.Clear()
            TxtArancel.Clear()
            TxtMateriales.Clear()
            TxtTalleres.Clear()
            TxtCampamento.Clear()
            TxtAdicionalJardin.Clear()
            TxtComedor.Clear()


            TxtEfectivo.Clear()
            TxtCheque.Clear()
            TxtChequeNumero.Clear()
            TxtTransferencia.Clear()
            TxtTransferenciaNumero.Clear()
            TxtDebito.Clear()
            TxtDebitoNumero.Clear()
            TxtMercadopago.Clear()
            TxtOtros.Clear()
            TxtOtrosComprobante.Clear()
            'TxtEfectivo.Focus()
            'CbxCodigoFamilia.Select()
            'CbxCodigoFamilia.Select()
        Else
            MsgBox("Error de grabación. Reinicie el programa e intente nuevamente, de persistir el error contacte al soporte informático")
        End If

        If Val(TxtDisponible.Text) > 0 Then
            'MessageBox.Show("Se reintegran $" & TxtDisponible.Text & "")
            Dim disponible As Decimal

            Dim efectivo As String = " SELECT efectivo FROM pagos_escolares where codigo_pago = '" & Val(TxtCodigoPago.Text) & "'  "
            Dim comando2 As New SqlCommand(efectivo, conexion)
            Dim pagoEfectivo As Decimal = comando2.ExecuteScalar
            disponible = Val(TxtDisponible.Text)
            'MsgBox("El monto disponible es  $ " & disponible & "")
            'MsgBox("El pago efectivo fue de  $ " & pagoEfectivo & "")
            If pagoEfectivo < TxtDisponible.Text Then
                MsgBox("Solo se pueden reintegrar $" & pagoEfectivo & " que pagó en efectivo. El resto de $" & disponible - pagoEfectivo & "queda como saldo a favor de próximos vencimientos")
                Dim modificaPago As String = "UPDATE pagos_escolares SET efectivo = 0 WHERE codigo_pago = '" & TxtCodigoPago.Text & "' "
                Dim comando5 As New SqlCommand(modificaPago, conexion)
                comando5.ExecuteNonQuery()
                If comando5.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Se reintegran $" & pagoEfectivo & "que pagó en efectivo")
                Else
                    MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                End If

            ElseIf pagoEfectivo = TxtDisponible.Text Then
                'MsgBox("Se reintegran $" & pagoEfectivo & "")
                Dim modificaPago As String = "UPDATE pagos_escolares SET efectivo = 0 WHERE codigo_pago = '" & TxtCodigoPago.Text & "' "
                Dim comando5 As New SqlCommand(modificaPago, conexion)
                comando5.ExecuteNonQuery()
                If comando5.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Se reintegran $" & pagoEfectivo & "que pagó en efectivo")
                Else
                    MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                End If
            Else

                Dim diferencia As Decimal = total - disponible



                'MsgBox("La diferencia es  $ " & diferencia & "")
                'MsgBox("El pago efectivo fue de  $ " & pagoEfectivo & "")
                'MsgBox("El disponible es  $ " & disponible & "")
                'MsgBox("El pago total es de " & total & "")
                'pagoEfectivo > TxtDisponible.text then
                Dim modificaPago As String = "UPDATE pagos_escolares SET efectivo = '" & diferencia & "' WHERE codigo_pago = '" & TxtCodigoPago.Text & "' "
                Dim comando5 As New SqlCommand(modificaPago, conexion)
                comando5.ExecuteNonQuery()
                If comando5.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Se reintegran $" & Val(TxtDisponible.Text) & "")
                Else
                    MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                End If



                'MessageBox.Show("¡Estás pelado como una mandarina! decí alpiste... tu guita perdiste")
            End If
        Else
            MsgBox("Pago realizado correctamente")


        End If

        'Dim reintegroEfectivo As Decimal = pagoEfectivo - diferencia
        'If reintegroEfectivo < 0 Then
        '    reintegroEfectivo = 0
        'End If
        'If reintegroEfectivo = 0 Then
        '    MessageBox.Show("¡Solo se pueden reintegrar  $" & reintegroEfectivo & " en efectivo!")
        'Else
        '        Dim devolucion As String = "UPDATE pagos_escolares SET efectivo = '" & reintegroEfectivo & "'WHERE codigo_pago = '" & TxtCodigoPago.Text & "' "
        '        Dim comando4 As New SqlCommand(devolucion, conexion)
        '        comando4.ExecuteNonQuery()

        '        If comando4.ExecuteNonQuery() = 1 Then
        '            MessageBox.Show("Se reintegró tu guita")
        '        Else
        '            MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
        '        End If
        '        MessageBox.Show("¡Estás pelado como una mandarina! decí alpiste... tu guita perdiste")
        '    End If
        'End If

        BtnGuardar2.Enabled = False
    End Sub

    Private Sub FormaPago()
        abrir()

        Dim cadenas As String = "INSERT INTO dbo.pagos_escolares(codigo_familia,fecha_pago, efectivo, cheque, cheque_numero, transferencia, transferencia_numero, debito, debito_numero, mercadopago, otros, otros_comprobante, observaciones ) 
                                       VALUES(@codigo_familia, @fecha_pago, @efectivo, @cheque, @cheque_numero, @transferencia, @transferencia_numero, @debito, @debito_numero, @mercadopago, @otros, @otros_comprobante, @observaciones)"
        comando = New SqlCommand(cadenas, conexion)

        comando.Parameters.AddWithValue("@codigo_familia", CbxCodigo.Text)
        comando.Parameters.AddWithValue("@fecha_pago", DtpFechaPago.Value)
        comando.Parameters.AddWithValue("@efectivo", Val(TxtEfectivo.Text))
        comando.Parameters.AddWithValue("@cheque", Val(TxtCheque.Text))
        comando.Parameters.AddWithValue("@cheque_numero", TxtChequeNumero.Text)
        comando.Parameters.AddWithValue("@transferencia", Val(TxtTransferencia.Text))
        comando.Parameters.AddWithValue("@transferencia_numero", TxtTransferenciaNumero.Text)
        comando.Parameters.AddWithValue("@debito", Val(TxtDebito.Text))
        comando.Parameters.AddWithValue("@debito_numero", TxtDebitoNumero.Text)
        comando.Parameters.AddWithValue("@mercadopago", Val(TxtMercadopago.Text))
        comando.Parameters.AddWithValue("@otros", Val(TxtOtros.Text))
        comando.Parameters.AddWithValue("@otros_comprobante", TxtOtrosComprobante.Text)
        comando.Parameters.AddWithValue("@observaciones", TxtObservaciones.Text)
        'txtPrecio.Text = Format(CDec(txtPrecio.Text), "C")

        If comando.ExecuteNonQuery() = 1 Then
            ' MessageBox.Show("Datos guardados")

        Else
            MsgBox("Error de grabación. Reinicie el programa e intente nuevamente, de persistir el error contacte al soporte informático")
        End If
    End Sub

    Private Sub PagoTotal()
        'Dim maximo As String = "select max(codigo_pago) as codigo_pago FROM pagos_escolares WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"
        'Dim comando3 As New SqlCommand(maximo, conexion)
        'TxtCodigoPago.Text = comando3.ExecuteScalar
        TxtMatricula.Text = TxtMatricula.PlaceholderText
        TxtArancel.Text = TxtArancel.PlaceholderText
        TxtMateriales.Text = TxtMateriales.PlaceholderText
        TxtTalleres.Text = TxtTalleres.PlaceholderText
        TxtCampamento.Text = TxtCampamento.PlaceholderText
        TxtAdicionalJardin.Text = TxtAdicionalJardin.PlaceholderText
        TxtComedor.Text = TxtComedor.PlaceholderText
        TxtSinAsignar1.Text = TxtSinAsignar1.PlaceholderText
        TxtSinasignar2.Text = TxtSinasignar2.PlaceholderText
        TxtSinAsignar3.Text = TxtSinAsignar3.PlaceholderText
        TxtMatricula.Enabled = False
        TxtArancel.Enabled = False
        TxtMateriales.Enabled = False
        TxtTalleres.Enabled = False
        TxtCampamento.Enabled = False
        TxtAdicionalJardin.Enabled = False
        TxtComedor.Enabled = False
        TxtTotal.Enabled = False
        TxtSinAsignar1.Enabled = False
        TxtSinasignar2.Enabled = False
        TxtSinAsignar3.Enabled = False
    End Sub

    Private Sub PagoParcial()


        'TxtArancel.Text = TxtArancel.PlaceholderText
        'TxtMateriales.Text = TxtMateriales.PlaceholderText
        'TxtTalleres.Text = TxtTalleres.PlaceholderText
        'TxtCampamento.Text = TxtCampamento.PlaceholderText
        'TxtAdicionalJardin.Text = TxtAdicionalJardin.PlaceholderText
        'TxtComedor.Text = TxtComedor.PlaceholderText
    End Sub

    Private Sub SaldosDeudores()

    End Sub

    Sub Suma()
        Dim total As Decimal
        total = Val(TxtEfectivo.Text) + Val(TxtCheque.Text) + Val(TxtTransferencia.Text) + Val(TxtDebito.Text) + Val(TxtMercadopago.Text) + Val(TxtOtros.Text)
        TxtTotal.Text = total
    End Sub

    Sub Resta()
        'Dim disponible As Decimal

        Dim total2 As Decimal = Val(TxtMatricula.Text) + Val(TxtArancel.Text) + Val(TxtMateriales.Text) + Val(TxtTalleres.Text) + Val(TxtCampamento.Text) + Val(TxtAdicionalJardin.Text) + Val(TxtComedor.Text)

        total = Val(TxtTotal.Text)
        diferencia = total - total2
        'TxtTotal2.Text = total - total2
        CompruebaDisponible()
        TxtDisponible.Text = diferencia

    End Sub

    Private Sub CompruebaDisponible()
        If diferencia < 0 Then
            'MsgBox("dinero insuficiente, solo dispone de " & diferencia & " para realizar el pago")
            If TxtMatricula.Focused Then
                TxtMatricula.Clear()
                Resta()
            ElseIf TxtArancel.Focused Then
                TxtArancel.Clear()
                Resta()
            ElseIf TxtMateriales.Focused Then
                TxtMateriales.Clear()
                Resta()
            ElseIf TxtTalleres.Focused Then
                TxtTalleres.Clear()
                Resta()
            ElseIf TxtCampamento.Focused() Then
                TxtCampamento.Clear()
                Resta()
            ElseIf TxtAdicionalJardin.Focused Then
                TxtAdicionalJardin.Clear()
                Resta()
            ElseIf TxtComedor.Focused Then
                TxtComedor.Clear()
                Resta()
            End If


            Dim opcion As DialogResult = MessageBox.Show("dinero insuficiente, solo dispone de " & diferencia & " ¿Decea realizar el pago parcial?", "¡Dinero insuficiente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If (opcion = Windows.Forms.DialogResult.Yes) Then

                If TxtMatricula.Focused Then
                    TxtMatricula.Text = diferencia
                    Resta()
                ElseIf TxtArancel.Focused Then
                    TxtArancel.Text = diferencia
                    Resta()
                ElseIf TxtMateriales.Focused Then
                    TxtMateriales.Text = diferencia
                    Resta()
                ElseIf TxtTalleres.Focused Then
                    TxtTalleres.Text = diferencia
                    Resta()
                ElseIf TxtCampamento.Focused() Then
                    TxtCampamento.Text = diferencia
                    Resta()
                ElseIf TxtAdicionalJardin.Focused Then
                    TxtAdicionalJardin.Text = diferencia
                    Resta()
                ElseIf TxtComedor.Focused Then
                    TxtComedor.Text = diferencia
                    Resta()
                End If

                'MsgBox("dinero insuficiente, solo dispone de " & diferencia & " ¿Decea realizar el pago parcial?")
            End If
        End If
    End Sub
    'Private Sub TxtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs)
    'SoloNumeros(e)
    'End Sub

    Sub DataGrid()


        'Dim total As Decimal
        If contador <> 0 Then

            TotalCuota = 0
            TotalCampamento = 0
            TotalTalleres = 0
            TotalMaterial = 0
            TotalAdicional = 0
            TotalComedor = 0
            totalConceptos = 0

            Try
                Dim consulta As String = "SELECT nombre_apellido_alumno, curso, valor_cuota, campamento_importe, taller_importe, materiales_importe, adicional_importe,comedor_importe from alumnos JOIN cursos on cursos.codigo_curso = alumnos.codigo_curso JOIN cuotas ON cuotas.codigo_alumno = alumnos.codigo_alumno JOIN taller ON taller.codigo_taller = alumnos.codigo_taller1  WHERE alumnos.codigo_familia = '" & CbxCodigo.Text & "' "
                'Dim consulta As String = "SELECT nombre_apellido_alumno, curso, valor_cuota, campamento_importe, taller_importe, material_importe from alumnos JOIN cursos on cursos.codigo_curso = alumnos.codigo_curso JOIN cuotas ON cuotas.codigo_alumno = alumnos.codigo_alumno JOIN taller ON taller.codigo_taller = alumnos.codigo_taller1 JOIN material ON material.codigo_material = alumnos.codigo_material WHERE alumnos.codigo_familia = '" & Val(CbxCodigo.Text) & "' "
                'Dim consulta As String = "Select nombre_apellido_alumno, dni, curso, arancel_importe, valor_cuota, hermano_numero, fecha_ingreso from alumnos JOIN cursos On cursos.codigo_curso = alumnos.codigo_curso JOIN cuotas On cuotas.codigo_alumno = alumnos.codigo_alumno join Aranceles On aranceles.codigo_arancel = alumnos.codigo_arancel where alumnos.codigo_familia= '" & Val(CbxCodigo.Text) & "' "


                comando = New SqlCommand()
                comando.CommandText = consulta
                comando.CommandType = CommandType.Text
                comando.Connection = conexion
                adaptador = New SqlDataAdapter(comando)
                Dim dataSet As DataSet = New DataSet()
                adaptador.Fill(dataSet)

                DgvHijos.DataSource = dataSet.Tables(0).DefaultView

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
            End Try

            'TxtMatricula.Focus()



            Dim col As Integer = 2

            'Dim Col As Integer = Me.DgvHijos.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalCuota += Val(row.Cells(col).Value)

            Next


            TxtArancel.PlaceholderText = TotalCuota
            ' TxtArancel.PlaceholderText = TotalCuota

            Dim colCamp As Integer = 3

            'Dim Col As Integer = Me.DgvHijos.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalCampamento += Val(row.Cells(colCamp).Value)

            Next

            TxtCampamento.PlaceholderText = TotalCampamento


            Dim colTaller As Integer = 4

            'Dim Col As Integer = Me.DgvHijos.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalTalleres += Val(row.Cells(colTaller).Value)

            Next

            TxtTalleres.PlaceholderText = TotalTalleres

            Dim colMaterial As Integer = 5


            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalMaterial += Val(row.Cells(colMaterial).Value)

            Next

            TxtMateriales.PlaceholderText = TotalMaterial


            Dim colAdicional As Integer = 6


            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalAdicional += Val(row.Cells(colAdicional).Value)

            Next

            TxtAdicionalJardin.PlaceholderText = TotalAdicional


            Dim colComedor As Integer = 7


            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalComedor += Val(row.Cells(colComedor).Value)

            Next

            TxtComedor.PlaceholderText = TotalComedor
        End If
        contador += 1
        TxtMatricula.Enabled = False
    End Sub


    Private Sub TxtDebito_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtCheque_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtTransferencia_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtMercadopago_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtOtros_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtOtros_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtTransferencia.KeyUp, TxtOtros.KeyUp, TxtMercadopago.KeyUp, TxtEfectivo.KeyUp, TxtDebito.KeyUp, TxtCheque.KeyUp
        Suma()
    End Sub
    Private Sub TxtCampamento_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtTalleres.KeyUp, TxtMatricula.KeyUp, TxtMateriales.KeyUp, TxtComedor.KeyUp, TxtCampamento.KeyUp, TxtArancel.KeyUp, TxtAdicionalJardin.KeyUp
        Resta()
    End Sub

    Private Sub BtnSalir2_Click(sender As Object, e As EventArgs) Handles BtnSalir2.Click
        Me.Close()
    End Sub

    Private Sub TxtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEfectivo.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtDebito_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtDebito.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCheque_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtCheque.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTransferencia_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtTransferencia.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtMercadopago_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtMercadopago.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtOtros_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtOtros.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMatricula.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtArancel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArancel.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtMateriales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMateriales.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTalleres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTalleres.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCampamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCampamento.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtAdicionalJardin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAdicionalJardin.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtComedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtComedor.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
        RdbDetallesPago.Enabled = False
        BtnGuardar2.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RdbDetallesPago.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        DataGrid()
        'TxtMatricula.Focus()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(3)
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(4)
    End Sub


    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged
        LblFamilia.Text = CbxFamilia.Text
        'AdicionalYcomedor()
        DataGrid()
        totalConceptos = 0
        CalculoTotal()
    End Sub



    Private Sub CalculoTotal()

        totalConceptos = (TotalCuota + TotalMaterial + TotalTalleres + TotalCampamento + TotalAdicional + TotalComedor)
        TxtSuma.Text = totalConceptos
        TxtMontoAPagar.Text = totalConceptos

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


End Class