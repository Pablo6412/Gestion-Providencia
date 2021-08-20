
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

        TxtMatricula.Enabled = False
        TxtArancel.Enabled = False
        TxtMateriales.Enabled = False
        TxtTalleres.Enabled = False
        TxtCampamento.Enabled = False
        TxtAdicionalJardin.Enabled = False
        TxtComedor.Enabled = False
        BtnGuardar2.Enabled = False

        conectar()
        abrir()




        'Establece nombre para los conceptos de pago y deja invisibles a los "Sin asignar"
        Dim adaptador1 As SqlDataAdapter
        Dim datos1 As DataSet
        Dim conceptos As String = "SELECT * FROM concepto_de_pago"
        adaptador1 = New SqlDataAdapter(conceptos, conexion)
        datos1 = New DataSet
        adaptador1.Fill(datos1, "concepto_de_pago")

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

        ''Fecha de último pago
        'Dim ultimoPago As String = "SELECT fecha_de_pago FROM detalle_pago_escolar WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "' "
        'Dim comandoUltimoPago As New SqlCommand(ultimoPago, conexion)
        'DtpUltimoPago.Text = comandoUltimoPago.ExecuteScalar
    End Sub

    Private Sub UltimoPago()

        'Fecha de último pago
        Dim ultimoPago As String = "SELECT fecha_de_pago FROM detalle_pago_escolar WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "' "
        Dim comandoUltimoPago As New SqlCommand(ultimoPago, conexion)
        DtpUltimoPago.Text = comandoUltimoPago.ExecuteScalar
    End Sub

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        If TxtEfectivo.Text <> "" Or TxtDebito.Text <> "" Or TxtCheque.Text <> "" Or TxtTransferencia.Text <> "" Or TxtMercadopago.Text <> "" Or TxtOtros.Text <> "" Then

            abrir()
            TxtDisponible.Text = TxtTotal.Text
            RdbDetallesPago.Checked = True

            If Val(TxtMontoAPagar.Text) <= Val(TxtTotal.Text) Then
                opcion = MessageBox.Show("El monto es suficiente para afrontar el total del vencimiento del mes. Puede Guardar sin nesecidad de cargar los montos de cada concepto", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnGuardar2.Enabled = True
                PagoTotal()
                TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
            Else

                opcion = MessageBox.Show("El monto es insuficiente para afrontar el total de los conceptos del mes." + vbCr + "SI para realizar el pago parcial" + vbCr + "NO para rectificar el monto a pagar", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If (opcion = Windows.Forms.DialogResult.No) Then

                    TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
                    'RdbDetallesPago.Enabled = False
                Else
                    TxtMatricula.Enabled = True
                    TxtArancel.Enabled = True
                    TxtMateriales.Enabled = True
                    TxtTalleres.Enabled = True
                    TxtCampamento.Enabled = True
                    TxtAdicionalJardin.Enabled = True
                    TxtComedor.Enabled = True
                    BtnGuardar2.Enabled = True
                    PagoParcial()
                    TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
                End If
            End If
        Else
            MsgBox("Debe ingresar un monto de pago")
        End If
        DataGrid()
        CalculoTotal()
    End Sub


    Private Sub BtnGuardar2_Click(sender As Object, e As EventArgs) Handles BtnGuardar2.Click

        If TxtMatricula.Text <> "" Or TxtArancel.Text <> "" Or TxtComedor.Text <> "" Or TxtMateriales.Text <> "" Or TxtTalleres.Text <> "" Or TxtCampamento.Text <> "" Or TxtAdicionalJardin.Text <> "" Or TxtSinAsignar1.Text <> "" Or TxtSinasignar2.Text <> "" Or TxtSinAsignar3.Text <> "" Then
            FormaPago()

            Dim maximo As String = "select max(codigo_pago) as codigo_pago FROM pagos_escolares WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"
            Dim comando3 As New SqlCommand(maximo, conexion)
            TxtCodigoPago.Text = comando3.ExecuteScalar


            Dim cadena As String = "INSERT INTO dbo.detalle_pago_escolar(codigo_familia, matricula, aranceles, materiales, talleres, campamento, adicional_jardin, comedor, fecha_de_pago) 
                                       VALUES(@codigo_familia, @matricula, @aranceles, @materiales, @talleres, @campamento, @adicional_jardin, @comedor, @fecha_de_pago)"
            comando = New SqlCommand(cadena, conexion)


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
            'SaldosDeudores()

            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Pago guardado")
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

            Else
                MsgBox("Error de grabación. Reinicie el programa e intente nuevamente, de persistir el error contacte al soporte informático")
            End If

            If Val(TxtDisponible.Text) > 0 Then

                Dim disponible As Decimal

                Dim efectivo As String = " SELECT efectivo FROM pagos_escolares where codigo_pago = '" & Val(TxtCodigoPago.Text) & "'  "
                Dim comando2 As New SqlCommand(efectivo, conexion)
                Dim pagoEfectivo As Decimal = comando2.ExecuteScalar
                disponible = Val(TxtDisponible.Text)

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



                    Dim modificaPago As String = "UPDATE pagos_escolares SET efectivo = '" & diferencia & "' WHERE codigo_pago = '" & TxtCodigoPago.Text & "' "
                    Dim comando5 As New SqlCommand(modificaPago, conexion)
                    comando5.ExecuteNonQuery()
                    If comando5.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Se reintegran $" & Val(TxtDisponible.Text) & "")
                    Else
                        MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                    End If
                End If
            Else
                MsgBox("Pago realizado correctamente")
            End If

            GrabaPagoFamilia()
            BtnGuardar2.Enabled = False
        Else
            MsgBox("Debe cargar monto en algún concepto")
        End If
    End Sub

    Sub GrabaPagoFamilia()
        Dim codigo As Integer

        Dim minCod As String = "SELECT MIN(codigo_alumno) FROM alumnos WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "' "
        Dim comandomin As New SqlCommand(minCod, conexion)
        Dim minimoCodigo As Decimal = comandomin.ExecuteScalar
        codigo = minimoCodigo
        Dim maxCod As String = "SELECT MAX(codigo_alumno) FROM alumnos WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "' "
        Dim comandomax As New SqlCommand(maxCod, conexion)
        Dim maximoCodigo As Decimal = comandomax.ExecuteScalar



        While codigo <= maximoCodigo
            Dim hijos As String = "SELECT codigo_alumno, nombre_apellido_alumno, arancel_matricula FROM alumnos JOIN aranceles ON alumnos.codigo_arancel = aranceles.codigo_arancel WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "' AND codigo_alumno = '" & codigo & "' "
            adaptador = New SqlDataAdapter(hijos, conexion)
            Dim dtDatos As DataTable = New DataTable
            adaptador.Fill(dtDatos)

            If dtDatos.Rows.Count > 0 Then
                Dim codigoAlumno As Integer = dtDatos.Rows(0)("codigo_alumno")
                Dim alumno As String = dtDatos.Rows(0)("nombre_apellido_alumno")
                Dim matricula As Integer = dtDatos.Rows(0)("arancel_matricula")

                MsgBox("" & codigoAlumno & ", " & alumno & ", " & matricula & "")

                Try
                    Dim pagoFamilia As String = "INSERT INTO pago_familia (codigo_familia, familia, codigo_alumno, alumno, arancel, matricula, materiales, taller, campamento, adicional_jardin, comedor, fecha ) 
                                                               VALUES(@codigo_familia, @familia, @codigo_alumno, @alumno, @arancel, @matricula, @materiales, @taller, @campamento, @adicional_jardin, @comedor, @fecha)"
                    Dim comando As New SqlCommand(pagoFamilia, conexion)

                    comando.Parameters.AddWithValue("@codigo_familia", Val(CbxCodigo.Text))
                    comando.Parameters.AddWithValue("@familia", CbxFamilia.Text)
                    comando.Parameters.AddWithValue("@codigo_alumno", codigoAlumno)
                    comando.Parameters.AddWithValue("alumno", alumno)
                    comando.Parameters.AddWithValue("@arancel", Val(TxtArancel.Text))
                    comando.Parameters.AddWithValue("@matricula", matricula)
                    comando.Parameters.AddWithValue("@materiales", Val(TxtMateriales.Text))
                    comando.Parameters.AddWithValue("@taller", Val(TxtTalleres.Text))
                    comando.Parameters.AddWithValue("@campamento", Val(TxtCampamento.Text))
                    comando.Parameters.AddWithValue("@adicional_jardin", Val(TxtAdicionalJardin.Text))
                    comando.Parameters.AddWithValue("@comedor", Val(TxtComedor.Text))
                    comando.Parameters.AddWithValue("@fecha", DtpFechaDePago.Value)

                    comando.ExecuteNonQuery()

                    MsgBox("Holis")
                Catch ex As Exception
                    MsgBox("Error comprobando BD" & ex.ToString)
                End Try
            End If

            codigo += 1

        End While

    End Sub

    Sub Siexiste()
        Dim Siesta As String = "SELECT codigo_alumno FROM alumnos WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"

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

        Dim restrictionValues() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}

        Dim dt As DataTable = conexion.GetSchema("TABLES", restrictionValues)

        Dim rows() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")

        If rows.Length > 0 Then
            'MessageBox.Show("Existe la tabla.")
        Else

            Dim tallerTemp As String = "select codigo_alumno, sum(importe_taller) as importe_taller INTO taller_temporal FROM taller_alumno  GROUP BY codigo_alumno"
            Dim comandoTaller As New SqlCommand(tallerTemp, conexion)
            comandoTaller.ExecuteNonQuery()

            MsgBox("Tabla creada")
            'MessageBox.Show("No existe la tabla.")
        End If



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
                'Dim consulta As String = "Select DISTINCT nombre_apellido_alumno, curso, valor_cuota, campamento_importe, (Select SUM (importe_taller) As taller_importe FROM taller_alumno where codigo_alumno = 19) , materiales_importe, adicional_importe,comedor_importe from alumnos JOIN cursos On cursos.codigo_curso = alumnos.codigo_curso JOIN cuotas On cuotas.codigo_alumno = alumnos.codigo_alumno JOIN taller_alumno On taller_alumno.codigo_alumno = alumnos.codigo_alumno WHERE alumnos.codigo_familia = '" & Val(CbxCodigo.Text) & "'"

                Dim consulta As String = "SELECT nombre_apellido_alumno, curso, valor_cuota, campamento_importe, importe_taller, materiales_importe, adicional_importe,comedor_importe from alumnos JOIN cursos on cursos.codigo_curso = alumnos.codigo_curso JOIN cuotas ON cuotas.codigo_alumno = alumnos.codigo_alumno JOIN taller_temporal ON taller_temporal.codigo_alumno = alumnos.codigo_alumno  WHERE alumnos.codigo_familia = '" & CbxCodigo.Text & "' "
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


        Dim tablaExiste() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}

        Dim datat As DataTable = conexion.GetSchema("TABLES", restrictionValues)

        Dim rowss() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")

        If rowss.Length > 0 Then
            'MessageBox.Show("Existe la tabla.")

            Dim destruyeTabla As String = "DROP TABLE taller_temporal"
            Dim comandoDestruye As New SqlCommand(destruyeTabla, conexion)
            MsgBox("Tabla destruida")

            If comandoDestruye.ExecuteNonQuery() = 0 Then
                MsgBox("No pasa nada")
            End If

        End If
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
        'RdbDetallesPago.Enabled = False
        'BtnGuardar2.Enabled = True
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
        'LblFamilia.Text = CbxFamilia.Text
        'UltimoPago()
        'DataGrid()
        'totalConceptos = 0
        'CalculoTotal()
    End Sub



    Private Sub CalculoTotal()

        totalConceptos = (TotalCuota + TotalMaterial + TotalTalleres + TotalCampamento + TotalAdicional + TotalComedor)
        TxtSuma.Text = totalConceptos
        TxtMontoAPagar.Text = totalConceptos

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxCodigo_TextChanged(sender As Object, e As EventArgs) Handles CbxCodigo.TextChanged
        LblFamilia.Text = CbxFamilia.Text
        UltimoPago()
        DataGrid()
        totalConceptos = 0
        CalculoTotal()
    End Sub
End Class