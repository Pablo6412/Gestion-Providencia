Imports System.Data.SqlClient

'Concepto_de_pago
'Este formulario lee las siguientes tablas:
'Concepto_de_pago
'familias
'detalle_de_pago_escolar
'pagos_escolares
'alumnos,
'taller_alumno 
'cursos, cuotas, taller_temporal 

'Inserta en: pagos_escolares, pago_familia 

'Actualiza: pagos_escolares

'Crea: taller_temporal



Public Class Pagos

    '-------------------------------------------------------------------------
    'Deshabilita botón cerrar del formulario
    Dim _enabledCerrar As Boolean = False
    Dim fechaActual As Date = Date.Today

    <System.ComponentModel.DefaultValue(False), System.ComponentModel.Description("Define si se habilita el botón cerrar en el formulario")>
    Public Property enabledCerrar() As Boolean
        Get
            Return _enabledCerrar
        End Get

        Set(ByVal value As Boolean)
            If _enabledCerrar <> value Then
                _enabledCerrar = value
            End If
        End Set
    End Property

    Protected Overrides ReadOnly Property createparams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            If _enabledCerrar = False Then
                Const CS_NOCLOSE As Integer = &H200
                cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            End If
            Return cp
        End Get
    End Property

    '------------------------------------------------------------------------------
    Dim pagoCumplido As String
    Dim matricula As Decimal
    Dim arancel As Decimal
    Dim materiales As Decimal
    Dim talleres As Decimal
    Dim campamento As Decimal
    Dim adicional As Decimal
    Dim comedor As Decimal
    Dim sinAsignar1 As Decimal
    Dim sinAsignar2 As Decimal
    Dim sinAsignar3 As Decimal
    Dim total As Decimal
    Dim diferencia As Decimal
    Dim pagoCompleto As Boolean
    'Dim decision As Boolean
    Dim pagoACuenta As Boolean
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Dim comando As New SqlCommand
    Dim contador As Integer = 0
    Dim contador2 As Integer = 0
    Dim totalMatricula As Decimal
    Dim TotalCuota As Decimal

    Dim TotalCampamento As Decimal
    'Dim CuotaCampamento As Decimal
    Dim TotalTalleres As Decimal
    Dim TotalMaterial As Decimal
    Dim TotalAdicional As Decimal
    Dim TotalComedor As Decimal
    Dim totalConceptos As Decimal
    Dim opcion
    Dim opcion1



    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sinAsignar1 As String
        Dim sinAsignar2 As String
        Dim sinAsignar3 As String


        LblFecha.Text = Date.Now.ToLongDateString
        TxtMatricula.Enabled = False
        TxtArancel.Enabled = False
        TxtMateriales.Enabled = False
        TxtTalleres.Enabled = False
        TxtCampamento.Enabled = False
        TxtAdicional.Enabled = False
        TxtComedor.Enabled = False
        BtnGuardar2.Enabled = False

        conectar()
        'abrir()

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
        TxtSubTotal.Enabled = False
        TxtDisponible.Enabled = False

        'Carga combobox con familias activas
        Try
            Dim concatena As String = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, 
                                       CONCAT(apellido_padre,' - ', apellido_madre) AS familia, estado 
                                       FROM familias WHERE estado = 'activo' 
                                       ORDER BY familia"

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

    Private Sub CbxCodigo_TextChanged(sender As Object, e As EventArgs) Handles CbxCodigo.TextChanged
        LblFamilia.Text = CbxFamilia.Text
        UltimoPago()      'Fecha de último pago
        UltimoVencimiento()
        DataGrid()
        totalConceptos = 0
        CalculoTotal()

    End Sub

    Private Sub UltimoPago()

        'Fecha de último pago
        Dim ultimoPago As String = "SELECT ISNULL(MAX(fecha_de_pago), '' ) 
                                   FROM detalle_pago_escolar WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND pago_cumplido <> 'Nulo' "

        Dim comandoUltimo As New SqlCommand(ultimoPago, conexion)
        LblUltimoPago.Text = comandoUltimo.ExecuteScalar
        If LblUltimoPago.Text = "01/01/1900" Then
            LblUltimoPago.Text = "Sin pagos registrados para ésta familia"
        End If
    End Sub

    Private Sub UltimoVencimiento()
        Dim ultimoVencimiento As String = "SELECT MAX(fecha_vencimiento) FROM vencimiento_detallado"  'WHERE codigo_familia = " & Val(CbxCodigo.Text) & "  "
        Dim comandoUltimoVencimiento As New SqlCommand(ultimoVencimiento, conexion)
        If comandoUltimoVencimiento.ExecuteNonQuery <> 0 Then
            LblPeriodoPago.Text = comandoUltimoVencimiento.ExecuteScalar
        End If
    End Sub

    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        Dim vuelto As Decimal = (Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text))
        Dim efectivo As Decimal = Val(TxtEfectivo.Text)
        Dim decision As Decimal
        decision = vuelto - efectivo
        If TxtEfectivo.Text <> "" Or TxtDebito.Text <> "" Or TxtCheque.Text <> "" Or TxtTransferencia.Text <> "" Or TxtMercadopago.Text <> "" Or TxtOtros.Text <> "" Then

            abrir()
            TxtDisponible.Text = TxtTotal.Text
            RdbDetallesPago.Checked = True

            If Val(TxtMontoAPagar.Text) <= Val(TxtTotal.Text) Then
                If Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text) = 0 Then
                    BtnGuardar2.Enabled = True
                    MessageBox.Show("El monto es suficiente para afrontar el total del vencimiento del mes." + vbCr + "Al cerrar esta ventana, haga click en 'Guardar'", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If decision < 0 Then
                        opcion1 = MessageBox.Show("El monto es suficiente para afrontar el total del vencimiento del mes." + vbCr + "En este pago hay un excedente de: $" & Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text) & " del que se le pueden reintegrar $" & (Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text)) & " que pagó en efectivo." + vbCr + "" + vbCr + "SÍ: Para usarlo a cuenta del próximo vencimiento." + vbCr + "" + vbCr + "NO: para que se le devuelva en este instante." + vbCr + "" + vbCr + "Al cerrar esta ventana, haga click en 'Guardar'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    Else
                        opcion1 = MessageBox.Show("El monto es suficiente para afrontar el total del vencimiento del mes." + vbCr + "En este pago hay un excedente de: $" & Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text) & " del que se le pueden reintegrar $" & Val(TxtEfectivo.Text) & " que pagó en efectivo." + vbCr + "" + vbCr + "SÍ: Para usarlo a cuenta del próximo vencimiento." + vbCr + "" + vbCr + "NO: para que se le devuelva en este instante." + vbCr + "" + vbCr + "Al cerrar esta ventana, haga click en 'Guardar'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    End If

                    If (opcion1 = Windows.Forms.DialogResult.No) Then
                        pagoACuenta = False
                    Else
                        pagoACuenta = True
                    End If
                End If

                pagoCompleto = True
                pagoCumplido = "completo"
                BtnGuardar2.Enabled = True
                PagoTotal()
                TabControl1.SelectedTab = TabControl1.TabPages.Item(1)

            Else
                opcion = MessageBox.Show("El monto es insuficiente para afrontar el total de los conceptos del mes." + vbCr + "En este pago hay un faltante de: $" & Val(TxtMontoAPagar.Text) - Val(TxtTotal.Text) & vbCr + vbCr + "SI: para realizar el pago parcial." + vbCr + "" + vbCr + "NO: para rectificar el monto a pagar." + vbCr + "" + vbCr + "", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If (opcion = Windows.Forms.DialogResult.No) Then

                    TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
                    RadioButton1.Checked = True
                Else
                    pagoCompleto = False
                    TxtMatricula.Enabled = True
                    TxtArancel.Enabled = True
                    TxtMateriales.Enabled = True
                    TxtTalleres.Enabled = True
                    TxtCampamento.Enabled = True
                    TxtAdicional.Enabled = True
                    TxtComedor.Enabled = True
                    BtnGuardar2.Enabled = True
                    pagoCumplido = "incompleto"
                    'PagoParcial()
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

        Dim vuelto As Decimal = (Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text))
        Dim efectivo As Decimal = Val(TxtEfectivo.Text)
        Dim disponible As Decimal = Val(TxtDisponible.Text)
        Dim pagoEfectivo As Decimal = Val(TxtEfectivo.Text)
        Dim credito As Decimal = Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text)
        Dim efectivoDef As Decimal
        Dim montoDeuda As Decimal
        If TxtMatricula.Text <> "" Or TxtArancel.Text <> "" Or TxtComedor.Text <> "" Or TxtMateriales.Text <> "" Or TxtTalleres.Text <> "" Or TxtCampamento.Text <> "" Or TxtAdicional.Text <> "" Or TxtSinAsignar1.Text <> "" Or TxtSinasignar2.Text <> "" Or TxtSinAsignar3.Text <> "" Then
            If pagoACuenta = False Then
                If efectivo <= vuelto Then
                    efectivoDef = 0
                Else
                    efectivoDef = efectivo - vuelto
                End If
            Else
                efectivoDef = efectivo
            End If
            FormaPago(efectivoDef) 'Hace el INSERT en la tabla pagos_escolares

            'Ahora se averigua el codigo_pago de dicho pago y se presenta en cuadro de texto para que quede disponible el valor.
            Dim maximo As String = "select max(codigo_pago) as codigo_pago FROM pagos_escolares WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"
            Dim comando3 As New SqlCommand(maximo, conexion)
            TxtCodigoPago.Text = comando3.ExecuteScalar

            If pagoACuenta = False Then  'Si elije devolución ...
                If efectivo >= vuelto Then
                    credito = 0      'Cuando el efectivo alcanzó para devolver todo
                Else
                    credito = Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text) - Val(TxtEfectivo.Text) 'Cuando el efectivo no alcanzó para devolver todo
                End If
            Else                     'Si elije no devolución la suma se carga como crédito del próximo vencimiento
                credito = Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text)
            End If

            montoDeuda = Val(TxtMontoAPagar.Text) - Val(TxtTotal.Text)
            'Try
            Dim cadena As String = "UPDATE detalle_pago_escolar 
                                    SET  matricula = " & Val(TxtMatricula.Text) & ", aranceles = " & Val(TxtArancel.Text) & ", 
                                    materiales = " & Val(TxtMateriales.Text) & ", talleres = " & Val(TxtTalleres.Text) & ", 
                                    campamento = " & Val(TxtCampamento.Text) & ", adicional = " & Val(TxtAdicional.Text) & ", 
                                    comedor = " & Val(TxtComedor.Text) & ", credito = " & credito & ", 
                                    fecha_de_pago = '" & DtpFechaDePago.Value & "', pago_cumplido = '" & pagoCumplido & "', 
                                    monto_deuda = " & montoDeuda & " 
                                    WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND periodo_de_pago = '" & LblPeriodoPago.Text & "' "

            comando = New SqlCommand(cadena, conexion)

            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Pago guardado")
                BtnGuardar2.Enabled = False

            Else
                MsgBox("Error de grabación. Reinicie el programa e intente nuevamente, de persistir el error contacte al soporte informático")
            End If

            'Cuando el pago no cubre el vencimiento
            If pagoCompleto = False Then
                'Se hacen los calculos de efectivo disponible para devolución y presentan las distintas opciones para devolución
                If Val(TxtDisponible.Text) > 0 Then

                    'Si lo que se pagó en efectivo es menor al disponible la devolución es parcial y corresponde al efectivo
                    If pagoEfectivo < TxtDisponible.Text Then
                        MsgBox("Solo se pueden reintegrar $" & pagoEfectivo & " que pagó en efectivo. El resto de $" & disponible - pagoEfectivo & " queda como saldo a favor de próximos vencimientos")

                        Dim modificaPago As String = "UPDATE pagos_escolares SET efectivo = 0 WHERE codigo_pago = '" & TxtCodigoPago.Text & "' "
                        Dim comando5 As New SqlCommand(modificaPago, conexion)
                        comando5.ExecuteNonQuery()

                        If comando5.ExecuteNonQuery() = 1 Then
                            MessageBox.Show("Se reintegran $" & pagoEfectivo & " que pagó en efectivo")
                        Else
                            MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                        End If

                        'Con esta condición la devolución es total
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

                        'Luego de la devolución se resta dicho monto de lo ingresado en la tabla pagos_escolares
                        Dim modificaPago As String = "UPDATE pagos_escolares SET efectivo = '" & diferencia & "' 
                                                      WHERE codigo_pago = '" & TxtCodigoPago.Text & "' "
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

                TxtMatricula.Clear()
                TxtArancel.Clear()
                TxtMateriales.Clear()
                TxtTalleres.Clear()
                TxtCampamento.Clear()
                TxtAdicional.Clear()
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
                BtnGuardar2.Enabled = False
                'MsgBox("¿Pasa o no pasa por acá?")
            End If
            GrabaPagoFamilia()
        Else
            MsgBox("Debe cargar monto en algún concepto")

        End If

    End Sub

    Sub GrabaPagoFamilia()
        Dim codigo As Integer
        Dim ultimoVencimiento As Date
        Dim minCod As String = "SELECT MIN(codigo_alumno) FROM alumnos WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "' AND estado = 'activo'"
        Dim comandomin As New SqlCommand(minCod, conexion)
        Dim minimoCodigo As Decimal = comandomin.ExecuteScalar
        codigo = minimoCodigo

        Dim maxCod As String = "SELECT MAX(codigo_alumno) FROM alumnos WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "' AND estado = 'activo'"
        Dim comandomax As New SqlCommand(maxCod, conexion)
        Dim maximoCodigo As Decimal = comandomax.ExecuteScalar

        Dim maxFecha As String = "SELECT MAX(fecha_vencimiento) AS fecha FROM vencimiento_detallado"
        Dim comandoFecha As New SqlCommand(maxFecha, conexion)
        ultimoVencimiento = comandoFecha.ExecuteScalar

        'Dim restrictionValues() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}
        'Dim dt As DataTable = conexion.GetSchema("TABLES", restrictionValues)
        'Dim rows() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")
        'CreaTablaTemporal(rows)

        While codigo <= maximoCodigo

            Dim consulta As String = "SELECT alumnos.codigo_alumno, nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, 
                                      talleres_alumno, materiales_alumno, adicional_alumno,comedor_alumno
                                      FROM alumnos 
                                      JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                                      JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno  
                                      WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & "  
                                      AND fecha_vencimiento = '" & ultimoVencimiento & "' AND alumnos.estado = 'activo'"

            adaptador = New SqlDataAdapter(consulta, conexion)
            Dim dtDatos As DataTable = New DataTable
            adaptador.Fill(dtDatos)

            If dtDatos.Rows.Count > 0 Then
                Dim codigoAlumno As Integer = dtDatos.Rows(0)("codigo_alumno")
                Dim alumno As String = dtDatos.Rows(0)("nombre_apellido_alumno")
                Dim matricula As Decimal = dtDatos.Rows(0)("matricula_alumno")
                Dim arancel As Decimal = dtDatos.Rows(0)("cuota_alumno")
                Dim materiales As String = dtDatos.Rows(0)("materiales_alumno")
                Dim talleres As Decimal = dtDatos.Rows(0)("talleres_alumno")
                Dim campamento As Decimal = dtDatos.Rows(0)("campamento_alumno")
                Dim adicional As Decimal = dtDatos.Rows(0)("adicional_alumno")
                Dim comedor As Decimal = dtDatos.Rows(0)("comedor_alumno")

                MsgBox("" & codigoAlumno & ", " & alumno & ", " & matricula & "")

                Try
                    Dim pagoFamilia As String = "INSERT INTO pago_familia (codigo_familia, codigo_alumno, arancel, matricula, 
                                                 materiales, taller, campamento, adicional, comedor, fecha_pago, periodo_pago ) 
                                                 VALUES(@codigo_familia, @codigo_alumno, @arancel, @matricula, @materiales, 
                                                 @taller, @campamento, @adicional, @comedor, @fecha_pago, @periodo_pago)"
                    Dim comando As New SqlCommand(pagoFamilia, conexion)

                    comando.Parameters.AddWithValue("@codigo_familia", Val(CbxCodigo.Text))
                    comando.Parameters.AddWithValue("@codigo_alumno", codigoAlumno)
                    comando.Parameters.AddWithValue("@arancel", arancel)
                    comando.Parameters.AddWithValue("@matricula", matricula)
                    comando.Parameters.AddWithValue("@materiales", materiales)
                    comando.Parameters.AddWithValue("@taller", talleres)
                    comando.Parameters.AddWithValue("@campamento", campamento)
                    comando.Parameters.AddWithValue("@adicional", adicional)
                    comando.Parameters.AddWithValue("@comedor", comedor)
                    comando.Parameters.AddWithValue("@fecha_pago", DtpFechaDePago.Value)
                    comando.Parameters.AddWithValue("@periodo_pago", DtpFechaDePago.Value)
                    comando.ExecuteNonQuery()

                    MsgBox("Holis")
                Catch ex As Exception
                    MsgBox("Error comprobando BD" & ex.ToString)
                End Try
            End If

            codigo += 1

        End While
        'Dim tablaExiste() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}
        'Dim datat As DataTable = conexion.GetSchema("TABLES", restrictionValues)
        'Dim rowss() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")

        'If rowss.Length > 0 Then
        '    'MessageBox.Show("Existe la tabla.")
        '    Dim destruyeTabla As String = "DROP TABLE taller_temporal"
        '    Dim comandoDestruye As New SqlCommand(destruyeTabla, conexion)
        '    'MsgBox("Tabla destruida")

        '    If comandoDestruye.ExecuteNonQuery() = 0 Then
        '        MsgBox("No pasa nada")
        '    End If
        'End If
    End Sub

    Sub Siexiste()
        Dim Siesta As String = "SELECT codigo_alumno FROM alumnos WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"

    End Sub

    Private Sub FormaPago(efectivoDef)
        abrir()

        Dim cadenas As String = "INSERT INTO dbo.pagos_escolares(codigo_familia,periodo_de_pago, fecha_pago, efectivo, cheque, cheque_numero,
                                 transferencia, transferencia_numero, debito, debito_numero, mercadopago, otros, otros_comprobante, 
                                 observaciones ) 
                                 VALUES(@codigo_familia, @periodo_de_pago, @fecha_pago, @efectivo, @cheque, @cheque_numero, @transferencia, 
                                 @transferencia_numero, @debito, @debito_numero, @mercadopago, @otros, @otros_comprobante, 
                                 @observaciones)"
        comando = New SqlCommand(cadenas, conexion)

        comando.Parameters.AddWithValue("@codigo_familia", CbxCodigo.Text)
        comando.Parameters.AddWithValue("@periodo_de_pago", LblPeriodoPago.Text)
        comando.Parameters.AddWithValue("@fecha_pago", DtpFechaDePago.Value)
        comando.Parameters.AddWithValue("@efectivo", efectivoDef)
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

        TxtMatricula.Text = TxtMatricula.PlaceholderText
        matricula = TxtMatricula.Text
        TxtArancel.Text = TxtArancel.PlaceholderText
        arancel = TxtArancel.Text
        TxtMateriales.Text = TxtMateriales.PlaceholderText
        materiales = TxtMateriales.Text
        TxtTalleres.Text = TxtTalleres.PlaceholderText
        talleres = TxtTalleres.Text
        TxtCampamento.Text = TxtCampamento.PlaceholderText
        TxtAdicional.Text = TxtAdicional.PlaceholderText
        adicional = TxtAdicional.Text
        TxtComedor.Text = TxtComedor.PlaceholderText
        comedor = TxtComedor.Text
        sinAsignar1 = TxtSinAsignar1.Text = TxtSinAsignar1.PlaceholderText
        sinAsignar2 = TxtSinasignar2.Text = TxtSinasignar2.PlaceholderText
        sinAsignar3 = TxtSinAsignar3.Text = TxtSinAsignar3.PlaceholderText
        TxtMatricula.Enabled = False
        TxtArancel.Enabled = False
        TxtMateriales.Enabled = False
        TxtTalleres.Enabled = False
        TxtCampamento.Enabled = False
        TxtAdicional.Enabled = False
        TxtComedor.Enabled = False
        TxtTotal.Enabled = False
        TxtSinAsignar1.Enabled = False
        TxtSinasignar2.Enabled = False
        TxtSinAsignar3.Enabled = False
    End Sub



    Sub Suma()
        Dim total As Decimal
        total = Val(TxtEfectivo.Text) + Val(TxtCheque.Text) + Val(TxtTransferencia.Text) + Val(TxtDebito.Text) + Val(TxtMercadopago.Text) + Val(TxtOtros.Text)
        TxtTotal.Text = total
    End Sub

    Sub Resta()

        Dim total2 As Decimal = Val(TxtMatricula.Text) + Val(TxtArancel.Text) + Val(TxtMateriales.Text) + Val(TxtTalleres.Text) + Val(TxtCampamento.Text) + Val(TxtAdicional.Text) + Val(TxtComedor.Text)
        total = Val(TxtTotal.Text)
        diferencia = total - total2
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
            ElseIf TxtAdicional.Focused Then
                TxtAdicional.Clear()
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
                ElseIf TxtAdicional.Focused Then
                    TxtAdicional.Text = diferencia
                    Resta()
                ElseIf TxtComedor.Focused Then
                    TxtComedor.Text = diferencia
                    Resta()
                End If

                'MsgBox("dinero insuficiente, solo dispone de " & diferencia & " ¿Decea realizar el pago parcial?")
            End If
        End If
    End Sub

    Sub DataGrid()
        Dim mes As Integer
        Dim parImpar As Integer
        Dim ultimoVencimiento As Date

        Dim restrictionValues() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}
        Dim dt As DataTable = conexion.GetSchema("TABLES", restrictionValues)
        Dim rows() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")
        CreaTablaTemporal(rows)

        Dim maxFecha As String = "SELECT MAX(fecha_vencimiento) AS fecha FROM vencimiento_detallado"
        Dim comandoFecha As New SqlCommand(maxFecha, conexion)
        ultimoVencimiento = comandoFecha.ExecuteScalar

        If contador <> 0 Then
            totalMatricula = 0
            TotalCuota = 0
            TotalCampamento = 0
            TotalTalleres = 0
            TotalMaterial = 0
            TotalAdicional = 0
            TotalComedor = 0
            totalConceptos = 0

            Try

                Dim consulta As String = "SELECT nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, talleres_alumno,
                                          materiales_alumno, adicional_alumno, comedor_alumno
                                          FROM alumnos 
                                          JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                                          JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno  
                                          WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_vencimiento = '" & ultimoVencimiento & "' And alumnos.estado = 'activo' "

                comando = New SqlCommand()
                comando.CommandText = consulta
                comando.CommandType = CommandType.Text
                comando.Connection = conexion
                adaptador = New SqlDataAdapter(comando)
                Dim dataSet As DataSet = New DataSet()
                adaptador.Fill(dataSet)

                DgvHijos.DataSource = dataSet.Tables(0).DefaultView

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try

            Dim colMatricula As Integer = 2
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                totalMatricula += Val(row.Cells(colMatricula).Value)
            Next
            TxtMatricula.PlaceholderText = totalMatricula
            matricula = totalMatricula

            Dim col As Integer = 3
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalCuota += Val(row.Cells(col).Value)
            Next
            TxtArancel.PlaceholderText = TotalCuota
            arancel = TotalCuota

            Dim colCamp As Integer = 4
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalCampamento += (Val(row.Cells(colCamp).Value))
            Next
            TxtCampamento.PlaceholderText = TotalCampamento
            campamento = TotalCampamento

            Dim colTaller As Integer = 5
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalTalleres += Val(row.Cells(colTaller).Value)
            Next
            TxtTalleres.PlaceholderText = TotalTalleres
            talleres = TotalTalleres

            Dim colMaterial As Integer = 6
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalMaterial += Val(row.Cells(colMaterial).Value)
            Next
            TxtMateriales.PlaceholderText = TotalMaterial
            materiales = TotalMaterial

            Dim colAdicional As Integer = 7
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalAdicional += Val(row.Cells(colAdicional).Value)
            Next
            TxtAdicional.PlaceholderText = TotalAdicional
            adicional = TotalAdicional

            Dim colComedor As Integer = 8
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalComedor += Val(row.Cells(colComedor).Value)
            Next
            mes = fechaActual.Month
            parImpar = mes Mod 2
            If parImpar <> 0 Then
                TxtComedor.PlaceholderText = TotalComedor
                comedor = TotalComedor
            Else
                TxtComedor.PlaceholderText = 0
                comedor = 0
                TotalComedor = comedor
            End If
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
            'MsgBox("Tabla destruida")

            If comandoDestruye.ExecuteNonQuery() = 0 Then
                MsgBox("No pasa nada")
            End If
        End If
    End Sub

    Private Sub CreaTablaTemporal(rows)


        If rows.Length > 0 Then
            'MessageBox.Show("Existe la tabla.")
        Else
            Dim tallerTemp As String = "SELECT codigo_alumno, SUM(importe_taller) as importe_taller INTO taller_temporal 
                                        FROM taller_alumno  GROUP BY codigo_alumno"
            Dim comandoTaller As New SqlCommand(tallerTemp, conexion)
            comandoTaller.ExecuteNonQuery()

            'MsgBox("Tabla creada")
            'MessageBox.Show("No existe la tabla.")
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
    Private Sub TxtCampamento_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtTalleres.KeyUp, TxtMatricula.KeyUp, TxtMateriales.KeyUp, TxtComedor.KeyUp, TxtCampamento.KeyUp, TxtArancel.KeyUp, TxtAdicional.KeyUp
        Resta()
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

    Private Sub TxtAdicionalJardin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAdicional.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtComedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtComedor.KeyPress

        SoloNumeros(e)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RdbDetallesPago.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        DataGrid()
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

    Private Sub CalculoTotal()
        Dim fechaCredito As Integer
        Dim fechaActual As Date = Date.Today
        fechaCredito = fechaActual.Month - 1

        Dim codigo As String = "SELECT MAX(codigo_detalle_pago) 
                                FROM detalle_pago_escolar 
                                WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "' AND month(fecha_de_pago) = '" & fechaCredito & "' "
        Dim comandoCodigo As New SqlCommand(codigo, conexion)
        Dim codigoDetalle = comandoCodigo.ExecuteScalar

        Dim creditoAfavor As String = "SELECT credito FROM detalle_pago_escolar WHERE codigo_detalle_pago = '" & codigoDetalle & "' "
        Dim comandoCredito As New SqlCommand(creditoAfavor, conexion)
        Dim credito As Decimal = comandoCredito.ExecuteScalar

        If comandoCredito.ExecuteNonQuery = 0 Then
            MsgBox("Error en la consulta del crédito")
        End If
        TxtCredito.Text = credito
        TxtCredDisp.Text = credito
        totalConceptos = (TotalCuota + TotalMaterial + TotalTalleres + TotalCampamento + TotalAdicional + TotalComedor)
        TxtSubTotal.Text = totalConceptos
        TxtMontoAPagar.Text = totalConceptos - credito
        TxtTotalAPagar.Text = totalConceptos - credito

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir2_Click(sender As Object, e As EventArgs) Handles BtnSalir2.Click
        If BtnGuardar2.Enabled = True Then
            opcion = MessageBox.Show("El pago que acaba de ingresar no fue guardado, ¿Desea salir sin guardar? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (opcion = Windows.Forms.DialogResult.Yes) Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub



    Private Sub TxtCampamento_Leave(sender As Object, e As EventArgs) Handles TxtCampamento.Leave
        If Val(TxtCampamento.Text) > campamento Then
            MsgBox("El monto ingresado en campamento debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtMatricula_Leave(sender As Object, e As EventArgs) Handles TxtMatricula.Leave
        If Val(TxtMatricula.Text) > matricula Then
            MsgBox("El monto ingresado en matricula debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtArancel_Leave(sender As Object, e As EventArgs) Handles TxtArancel.Leave
        If Val(TxtArancel.Text) > arancel Then
            MsgBox("El monto ingresado en arancel debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtComedor_Leave(sender As Object, e As EventArgs) Handles TxtComedor.Leave
        If Val(TxtComedor.Text) > comedor Then
            MsgBox("El monto ingresado en comedor debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtMateriales_Leave(sender As Object, e As EventArgs) Handles TxtMateriales.Leave
        If Val(TxtMateriales.Text) > materiales Then
            MsgBox("El monto ingresado en materiales debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtTalleres_Leave(sender As Object, e As EventArgs) Handles TxtTalleres.Leave
        If Val(TxtTalleres.Text) > talleres Then
            MsgBox("El monto ingresado en talleres debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtAdicionalJardin_Leave(sender As Object, e As EventArgs) Handles TxtAdicional.Leave
        If Val(TxtAdicional.Text) > adicional Then
            MsgBox("El monto ingresado en Adicional jardín debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtSinAsignar1_Leave(sender As Object, e As EventArgs) Handles TxtSinAsignar1.Leave
        If Val(TxtSinAsignar1.Text) > sinAsignar1 Then
            MsgBox("El monto ingresado en ... debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtSinasignar2_Leave(sender As Object, e As EventArgs) Handles TxtSinasignar2.Leave
        If Val(TxtSinasignar2.Text) > sinAsignar2 Then
            MsgBox("El monto ingresado en ... debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub TxtSinAsignar3_Leave(sender As Object, e As EventArgs) Handles TxtSinAsignar3.Leave
        If Val(TxtSinAsignar3.Text) > sinAsignar3 Then
            MsgBox("El monto ingresado en ... debe ser igual o menor al exibido")
        End If
    End Sub

    Private Sub BtnCerrarDeuda_Click(sender As Object, e As EventArgs) Handles BtnCerrarDeuda.Click
        Me.Close()
    End Sub

End Class