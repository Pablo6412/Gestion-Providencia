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
    Dim hayHijos As Integer
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
    Dim pagoACuenta As Boolean
    Dim comando As New SqlCommand
    Dim contador As Integer = 0
    Dim contador2 As Integer = 0
    Dim contador3 As Integer = 0
    Dim totalMatricula As Decimal
    Dim TotalCuota As Decimal
    Dim TotalCampamento As Decimal
    Dim TotalTalleres As Decimal
    Dim TotalMaterial As Decimal
    Dim TotalAdicional As Decimal
    Dim TotalComedor As Decimal
    Dim totalConceptos As Decimal
    Dim totalSinAsignar1 As Decimal
    Dim totalSinAsignar2 As Decimal
    Dim totalSinAsignar3 As Decimal
    Dim opcion
    Dim opcion1
    Dim efectivoAlcanza As Boolean
    Dim bandera As String
    Dim codigoArray(19) As Integer
    Dim indiceArrayCodigo As Integer


    Private Sub Pagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sinAsignar1 As String
        Dim sinAsignar2 As String
        Dim sinAsignar3 As String
        conectar()
        UltimoVencimiento()
        LblFecha.Text = Date.Now.ToLongDateString
        TxtMatricula.Enabled = False
        TxtArancel.Enabled = False
        TxtMateriales.Enabled = False
        TxtTalleres.Enabled = False
        TxtCampamento.Enabled = False
        TxtAdicional.Enabled = False
        TxtComedor.Enabled = False
        BtnGuardar.Enabled = False

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

            Dim adaptadorConcatena As New SqlDataAdapter(concatena, conexion)
            Dim datosConcatena As New DataSet
            datosConcatena.Tables.Add("familias")
            adaptadorConcatena.Fill(datosConcatena.Tables("familias"))

            CbxFamilia.DataSource = datosConcatena.Tables("familias")
            CbxFamilia.DisplayMember = "familia"
            CbxCodigo.DataSource = datosConcatena.Tables("familias")
            CbxCodigo.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
        DataGrid1()
    End Sub


    Private Sub CbxCodigo_TextChanged(sender As Object, e As EventArgs) Handles CbxCodigo.TextChanged
        LblFamilia.Text = CbxFamilia.Text
        Siexiste()
        UltimoPago()      'Fecha de último pago para la familia seleccionada
        UltimoVencimiento()
        PagoDelPeriodo()
        MontosAtrasados()
        Deuda()
        DataGrid()
        DataGrid1()
        totalConceptos = 0
        CalculoTotal()
    End Sub


    Private Sub UltimoPago()
        If Val(CbxCodigo.Text) <> 0 Then
            'Fecha de último pago
            Dim ultimoPago As String = "SELECT ISNULL(MAX(fecha_pago), '' ) 
                                   FROM pago_detallado WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND pago_cumplido <> 'Nulo' "

            Dim comandoUltimo As New SqlCommand(ultimoPago, conexion)
            LblUltimoPago.Text = comandoUltimo.ExecuteScalar
            If LblUltimoPago.Text = "01/01/1900" Then
                LblUltimoPago.Text = "Sin pagos registrados para ésta familia"
            Else


            End If
        End If
    End Sub


    Private Sub UltimoVencimiento()
        Dim ultimoVencimiento As String = "SELECT ISNULL(MAX(fecha_vencimiento), '') FROM vencimiento_detallado"  'WHERE codigo_familia = " & Val(CbxCodigo.Text) & "  "
        Dim comandoUltimoVencimiento As New SqlCommand(ultimoVencimiento, conexion)
        If comandoUltimoVencimiento.ExecuteNonQuery <> 0 Then
            LblPeriodoPago.Text = comandoUltimoVencimiento.ExecuteScalar
            If LblPeriodoPago.Text = "01/01/1900" Then
                LblPagoDelPeriodo.Hide()
                MsgBox("Aún no se han generado vencimientos")
                Me.Close()
            End If
        End If
    End Sub


    Private Sub PagoDelPeriodo()
        Dim count As Integer
        Dim cuota
        Dim materiales
        Dim taller
        Dim campamento
        Dim adicional
        Dim comedor
        Dim sinAsignar1
        Dim sinAsignar2
        Dim sinAsignar3

        If Val(CbxCodigo.Text) <> 0 Then
            Dim PagoPeriodo As String = "Select  count(pago_cumplido) As pago, sum(cuota_pago) As cuota, sum(materiales_pago) As materiales, 
                                         sum(talleres_pago) As taller, sum(campamento_pago) As campamento, sum(adicional_pago) As adicional, 
                                         sum(comedor_pago) As comedor, sum(sin_asignar1_pago) As sinAsignar1, sum(sin_asignar2_pago) As sinAsignar2, 
                                         sum(sin_asignar3_pago) As sinAsignar3  
                                     From pago_detallado
                                     Where codigo_familia = " & CbxCodigo.Text & " "
            Dim adaptadorPago As New SqlDataAdapter(PagoPeriodo, conexion)

            Dim datosPago = New DataSet
            datosPago.Tables.Add("pago_detallado")
            adaptadorPago.Fill(datosPago.Tables("pago_detallado"))
            count = datosPago.Tables("pago_detallado").Rows(0).Item("pago")
            cuota = datosPago.Tables("pago_detallado").Rows(0).Item("cuota")
            materiales = datosPago.Tables("pago_detallado").Rows(0).Item("materiales")
            taller = datosPago.Tables("pago_detallado").Rows(0).Item("taller")
            campamento = datosPago.Tables("pago_detallado").Rows(0).Item("campamento")
            adicional = datosPago.Tables("pago_detallado").Rows(0).Item("adicional")
            comedor = datosPago.Tables("pago_detallado").Rows(0).Item("comedor")
            sinAsignar1 = datosPago.Tables("pago_detallado").Rows(0).Item("sinAsignar1")
            sinAsignar2 = datosPago.Tables("pago_detallado").Rows(0).Item("sinAsignar2")
            sinAsignar3 = datosPago.Tables("pago_detallado").Rows(0).Item("sinAsignar3")

            Dim total As Decimal = cuota + materiales + taller + campamento + adicional + comedor + sinAsignar1 + sinAsignar2 + sinAsignar3
            LblPagoDelPeriodo.Text = total

            Dim estado As String

            Dim pagoCumplido As String = "SELECT count(pago_cumplido) as pago 
                                         FROM pago_detallado  
                                         WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND pago_cumplido = 'Nulo' "     'AND periodo_de_pago = '2021-09-24' AND pago_cumplido = 'Nulo' "
            Dim comandoPagoCumplido As New SqlCommand(pagoCumplido, conexion)
            estado = comandoPagoCumplido.ExecuteScalar
            If hayHijos <> 0 Then
                    If estado = 0 Then
                        MsgBox("La familia " & CbxFamilia.Text & " ya cumplió con el pago del período y no registra atrasos de pago")
                        BtnContinuar.Enabled = False
                        TxtEfectivo.Enabled = False
                        TxtCheque.Enabled = False
                        TxtDebito.Enabled = False
                        TxtTransferencia.Enabled = False
                        TxtMercadopago.Enabled = False
                        TxtOtros.Enabled = False
                    Else
                        BtnContinuar.Enabled = True
                        TxtEfectivo.Enabled = True
                        TxtCheque.Enabled = True
                        TxtDebito.Enabled = True
                        TxtTransferencia.Enabled = True
                        TxtMercadopago.Enabled = True
                        TxtOtros.Enabled = True
                    End If
                End If
                'End If
            End If

    End Sub

    Private Sub MontosAtrasados()
        If Val(CbxCodigo.Text) <> 0 Then
            Dim monto As String = "SELECT ISNULL(SUM(monto_atraso), 0.001) AS monto 
                               FROM pago_detallado
                               WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND periodo_de_pago <> '" & LblPeriodoPago.Text & "' "
            Dim comandoMonto As New SqlCommand(monto, conexion)
            Dim montoAtraso As Decimal = comandoMonto.ExecuteScalar

            If montoAtraso = 0 Or montoAtraso = 0.001 Then
                TxtMontoAtraso.ForeColor = System.Drawing.Color.Green
            Else
                TxtMontoAtraso.ForeColor = System.Drawing.Color.Red
            End If
            TxtMontoAtraso.Text = montoAtraso
        End If
    End Sub

    Private Sub Deuda()

    End Sub
    Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
        Dim vuelto As Decimal = (Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text))
        Dim efectivo As Decimal = Val(TxtEfectivo.Text)
        Dim decision As Decimal
        Dim bandera As String

        'Dim reintegro As Decimal
        decision = vuelto - efectivo
        If TxtEfectivo.Text <> "" Or TxtDebito.Text <> "" Or TxtCheque.Text <> "" Or TxtTransferencia.Text <> "" Or TxtMercadopago.Text <> "" Or TxtOtros.Text <> "" Then

            abrir()
            TxtDisponible.Text = TxtTotal.Text
            RdbDetallesPago.Checked = True

            If Val(TxtMontoAPagar.Text) <= Val(TxtTotal.Text) Then      'Cuando el monto es suficiente
                If Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text) = 0 Then 'Pago exacto
                    BtnGuardar.Enabled = True
                    MessageBox.Show("El monto es suficiente para afrontar el total del vencimiento del mes." + vbCr + "Al cerrar esta ventana, haga click en 'Guardar'", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    bandera = "pagoTotalExacto"
                Else                                                    'Pago de más
                    If decision < 0 Then                                'Se puede dar todo el vuelto en efectivo
                        opcion1 = MessageBox.Show("El monto es suficiente para afrontar el total del vencimiento del mes." + vbCr + "En este pago hay un excedente de: $" & Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text) & " del que se le pueden reintegrar $" & (Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text)) & " que pagó en efectivo." + vbCr + "" + vbCr + "SÍ: Para usarlo a cuenta del próximo vencimiento." + vbCr + "" + vbCr + "NO: para que se le devuelva en este instante." + vbCr + "" + vbCr + "Al cerrar esta ventana, haga click en 'Guardar'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        efectivoAlcanza = True
                        bandera = "pagoVueltoEntero"
                    Else                                                'El efectivo es menor y solo de puede reintegrar una parte del vuelto
                        opcion1 = MessageBox.Show("El monto es suficiente para afrontar el total del vencimiento del mes." + vbCr + "En este pago hay un excedente de: $" & Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text) & " del que se le pueden reintegrar $" & Val(TxtEfectivo.Text) & " que pagó en efectivo." + vbCr + "" + vbCr + "SÍ: Para usarlo a cuenta del próximo vencimiento." + vbCr + "" + vbCr + "NO: para que se le devuelva en este instante." + vbCr + "" + vbCr + "Al cerrar esta ventana, haga click en 'Guardar'", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                        efectivoAlcanza = False
                        bandera = "pagoVueltoParcial"
                    End If

                    If (opcion1 = Windows.Forms.DialogResult.No) Then
                        pagoACuenta = False           'eligió devolución
                        TxtDisponible.Text -= Val(TxtTotalAPagar.Text)
                    Else
                        pagoACuenta = True            'eligió que el vuelto quede a cuenta de próximo vencimiento
                        TxtDisponible.Text -= Val(TxtTotalAPagar.Text)
                    End If
                End If

                pagoCompleto = True
                pagoCumplido = "completo"
                BtnGuardar.Enabled = True
                PagoTotal()
                TabControl1.SelectedTab = TabControl1.TabPages.Item(1)

            Else                              'Cuando el monto no es suficiente
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
                    BtnGuardar.Enabled = True
                    pagoCumplido = "incompleto"
                    'PagoParcial()
                    TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
                    bandera = "pagoParcial"
                End If
            End If
        Else
            MsgBox("Debe ingresar un monto de pago")

        End If
        DataGrid()
        'DataGrid1()
        CalculoTotal()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Dim decision
        Dim credito As Decimal
        Dim efectivo As Decimal = Val(TxtEfectivo.Text)
        Dim disponible As Decimal = Val(TxtDisponible.Text)
        Dim pagoEfectivo As Decimal = Val(TxtEfectivo.Text)
        Dim efectivoDef As Decimal
        Dim montoDeuda As Decimal
        Dim sumaDePagosParciales As Decimal
        sumaDePagosParciales = Val(TxtMatricula.Text) + Val(TxtArancel.Text) + Val(TxtComedor.Text) + Val(TxtMateriales.Text) + Val(TxtTalleres.Text) + Val(TxtCampamento.Text) + Val(TxtAdicional.Text) + Val(TxtSinAsignar1.Text) + Val(TxtSinasignar2.Text) + Val(TxtSinAsignar3.Text)
        Dim faltanteDePago As Decimal = Val(TxtMontoAPagar.Text) - sumaDePagosParciales

        If pagoCompleto = True Then
            If Val(TxtDisponible.Text) = Val(TxtTotalAPagar.Text) Then        'Si el pago es justo.
                credito = 0
                montoDeuda = 0
                efectivoDef = Val(TxtEfectivo.Text)
                FormaPago(efectivoDef)                  'Hace el INSERT en la tabla pagos_escolares.
                CodigoDePago()                          'Averigua el codigo_pago de dicho pago y se presenta en cuadro de texto
                '                                        para que quede disponible el valor.
                ActualizaPagoDetallado(credito, montoDeuda)

            Else                                        'Si se pagó demás.
                If pagoACuenta = False Then             'Si elije devolución ...
                    If efectivoAlcanza = True Then
                        credito = 0                     'Cuando el efectivo alcanzó para devolver todo
                        montoDeuda = 0
                        efectivoDef = Val(TxtDisponible.Text) - Val(TxtTotalAPagar.Text)
                        FormaPago(efectivoDef)
                        CodigoDePago()
                        ActualizaPagoDetallado(credito, montoDeuda)
                        MsgBox("Se devuelven $" & Val(TxtDisponible.Text))
                        TxtDisponible.Text = "0"
                    Else
                        credito = Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text) - Val(TxtEfectivo.Text) 'Cuando el efectivo no alcanzó para devolver todo
                        montoDeuda = 0
                        efectivoDef = 0
                        FormaPago(efectivoDef)
                        CodigoDePago()
                        ActualizaPagoDetallado(credito, montoDeuda)
                        'MsgBox("Se devuelven $" & Val(TxtEfectivo.Text) & +vbCr + " Quedan $" & credito & " a cuenta de futuros vencimientos")
                        TxtDisponible.Text = "0"
                    End If

                Else                     'Si elije no devolución la suma se carga como crédito del próximo vencimiento
                    credito = Val(TxtTotal.Text) - Val(TxtMontoAPagar.Text)
                    montoDeuda = 0
                    efectivoDef = Val(TxtEfectivo.Text)
                    FormaPago(efectivoDef)
                    CodigoDePago()
                    ActualizaPagoDetallado(credito, montoDeuda)
                    MsgBox("Quedan $" & Val(TxtDisponible.Text) & " a cuenta de futuros vencimientos")
                    TxtDisponible.Text = "0"
                End If

            End If
        Else          'Pago incompleto
            If TxtMatricula.Text <> "" Or TxtArancel.Text <> "" Or TxtComedor.Text <> "" Or TxtMateriales.Text <> "" Or TxtTalleres.Text <> "" Or TxtCampamento.Text <> "" Or TxtAdicional.Text <> "" Or TxtSinAsignar1.Text <> "" Or TxtSinasignar2.Text <> "" Or TxtSinAsignar3.Text <> "" Then

                If efectivo <= faltanteDePago Then
                    If efectivo >= Val(TxtDisponible.Text) Then                  'Si alcanza el efectivo para devolver el disponible

                        efectivoDef = Val(TxtEfectivo.Text) - Val(TxtDisponible.Text)
                        credito = 0
                        montoDeuda = faltanteDePago
                        FormaPago(efectivoDef)
                        CodigoDePago()
                        ActualizaPagoDetallado(credito, montoDeuda)
                        MsgBox("Se devuelven $ " & Val(TxtDisponible.Text))
                        TxtDisponible.Text = "0"
                    Else
                        'TabControl1.SelectedTab = TabControl1.TabPages.Item(1)

                        efectivoDef = Val(TxtEfectivo.Text)
                        credito = Val(TxtDisponible.Text)
                        montoDeuda = faltanteDePago - Val(TxtDisponible.Text)
                        FormaPago(efectivoDef)
                        CodigoDePago()
                        ActualizaPagoDetallado(credito, montoDeuda)
                        MsgBox("Quedan $ " & Val(TxtDisponible.Text) & " como crédito a cuenta de futuros vencimientos")
                        TxtDisponible.Text = "0"
                    End If
                Else
                    efectivoDef = efectivo - disponible
                    credito = 0
                End If
            Else
                MsgBox("Debe completar al menos un campo de concepto de pago")
                BtnGuardar.Enabled = False

            End If
        End If       '------

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
        BtnGuardar.Enabled = False
        'MsgBox("¿Pasa o no pasa por acá?")

    End Sub

    Private Sub CodigoDePago()
        Dim maximo As String = "SELECT MAX(codigo_pago) AS codigo_pago 
                                    FROM pagos_escolares 
                                    WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"
        Dim comando3 As New SqlCommand(maximo, conexion)
        TxtCodigoPago.Text = comando3.ExecuteScalar
    End Sub
    Private Sub ActualizaPagoDetallado(credito, montodeuda)
        'If bandera = "pagoTotalExacto" Then

        'End If
        Dim actualizaDetallePago As String = "UPDATE detalle_pago_escolar 
                                    SET  matricula = " & Val(TxtMatricula.Text) & ", aranceles = " & Val(TxtArancel.Text) & ", 
                                    materiales = " & Val(TxtMateriales.Text) & ", talleres = " & Val(TxtTalleres.Text) & ", 
                                    campamento = " & Val(TxtCampamento.Text) & ", adicional = " & Val(TxtAdicional.Text) & ", 
                                    comedor = " & Val(TxtComedor.Text) & ", credito = " & credito & ", 
                                    fecha_de_pago = '" & DtpFechaDePago.Value & "', pago_cumplido = '" & pagoCumplido & "', 
                                    monto_deuda = " & montodeuda & " 
                                    WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND periodo_de_pago = '" & LblPeriodoPago.Text & "' "

        comando = New SqlCommand(actualizaDetallePago, conexion)

        If comando.ExecuteNonQuery() = 1 Then

            MessageBox.Show("Pago guardado")
            BtnGuardar.Enabled = False
        Else
            MsgBox("Error de grabación. Reinicie el programa e intente nuevamente, de persistir el error contacte al soporte informático")
        End If
    End Sub

    Sub GrabaPagoFamilia()
        Dim fechaActual As Date
        Dim codigo As Integer
        Dim ultimoVencimiento As Date
        fechaActual = LblFecha.Text

        Dim maxFecha As String = "SELECT MAX(fecha_vencimiento) AS fecha FROM vencimiento_detallado"
        Dim comandoFecha As New SqlCommand(maxFecha, conexion)
        ultimoVencimiento = comandoFecha.ExecuteScalar

        indiceArrayCodigo = 0
        For Each strName As String In codigoArray
            codigo = codigoArray(indiceArrayCodigo)
            'ListBox1.Items.Add(strName)
            If codigo <> 0 Then
                Dim consulta As String = "SELECT alumnos.codigo_alumno, nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, 
                                      talleres_alumno, materiales_alumno, adicional_alumno,comedor_alumno
                                      FROM alumnos 
                                      JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                                      JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno  
                                      WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " 
                                      AND alumnos.codigo_alumno = " & codigo & "
                                      AND fecha_vencimiento = '" & ultimoVencimiento & "' AND alumnos.estado = 'activo'"

                Dim adaptadorConsulta As New SqlDataAdapter(consulta, conexion)
                Dim dtDatos As DataTable = New DataTable
                adaptadorConsulta.Fill(dtDatos)

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


                        Dim actualizaPagos As String = "UPDATE pago_detallado SET codigo_familia = " & Val(CbxCodigo.Text) & ", 
                                                    codigo_alumno = " & codigoAlumno & ", cuota_pago = " & arancel & ", 
                                                    materiales_pago = " & materiales & ", talleres_pago = " & talleres & ",
                                                    campamento_pago = " & campamento & ", adicional_pago = " & adicional & ",
                                                    comedor_pago = " & comedor & ", fecha_pago = '" & fechaActual & "',
                                                    pago_cumplido = '" & pagoCumplido & "'
                                                    WHERE codigo_alumno = " & codigoAlumno & ""


                        Dim comandoActualizaPagos As New SqlCommand(actualizaPagos, conexion)
                        comandoActualizaPagos.ExecuteNonQuery()

                        MsgBox("Holis")
                    Catch ex As Exception
                        MsgBox("Error comprobando BD" & ex.ToString)
                    End Try
                End If
            End If
            indiceArrayCodigo += 1

        Next
        'End While
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
        If Val(CbxCodigo.Text) <> 0 Then
            Dim siEsta As String = "SELECT COUNT(codigo_alumno) AS alumno FROM alumnos WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"
            Dim comandoExiste As New SqlCommand(siEsta, conexion)
            hayHijos = comandoExiste.ExecuteScalar
            If hayHijos = 0 Then
                MsgBox("La familia  " & CbxFamilia.Text & " aún no tiene hijos dados de alta")
            End If
        End If
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
        If Val(CbxCodigo.Text) <> 0 Then

            Dim mes As Integer
            Dim parImpar As Integer
            Dim ultimoVencimiento As Date
            Dim alumno
            Dim totalSeleccion As Decimal


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

                    Dim consultaDgv As String = "SELECT nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, talleres_alumno,
                                          materiales_alumno, adicional_alumno, comedor_alumno, importe_concepto1, importe_concepto2, importe_concepto3
                                          FROM alumnos 
                                          JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                                          JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno 
                                          JOIN concepto_sin_asignar_1 ON alumnos.codigo_año = concepto_sin_asignar_1.codigo_año 
										  JOIN concepto_sin_asignar_2 ON alumnos.codigo_año = concepto_sin_asignar_2.codigo_año 
										  JOIN concepto_sin_asignar_3 ON alumnos.codigo_año = concepto_sin_asignar_3.codigo_año
                                          WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_vencimiento = '" & ultimoVencimiento & "' And alumnos.estado = 'activo' "

                    Dim comandoConsulta As New SqlCommand(consultaDgv, conexion)
                    'comandoConsulta.CommandText = consultaDgv
                    comandoConsulta.CommandType = CommandType.Text
                    'comandoConsulta.Connection = conexion
                    Dim adaptadorConsulta As New SqlDataAdapter(comandoConsulta)
                    Dim dataSet As New DataSet()
                    adaptadorConsulta.Fill(dataSet)

                    DgvHijos.DataSource = dataSet.Tables(0).DefaultView

                Catch ex As Exception
                    MsgBox("Error comprobando BD" & ex.ToString)
                End Try

                For Each row As DataGridViewRow In DgvHijos.Rows
                    'If row.Cells(Check).Value = True In DgvHijos1 Then
                    row.Cells("check").Value = True
                    'Else
                    'End If

                Next
                Dim colAlumno As Integer = 1
                'For Each row As DataGridViewRow In Me.DgvHijos.Rows
                '    alumno = row.Cells(colAlumno)
                'Next

                Dim colMatricula As Integer = 3
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    totalMatricula += Val(row.Cells(colMatricula).Value)
                Next
                TxtMatricula.PlaceholderText = totalMatricula
                matricula = totalMatricula

                Dim col As Integer = 4
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    TotalCuota += Val(row.Cells(col).Value)
                Next
                TxtArancel.PlaceholderText = TotalCuota
                arancel = TotalCuota

                Dim colCamp As Integer = 5
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    TotalCampamento += (Val(row.Cells(colCamp).Value))
                Next
                TxtCampamento.PlaceholderText = TotalCampamento
                campamento = TotalCampamento

                Dim colTaller As Integer = 6
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    TotalTalleres += Val(row.Cells(colTaller).Value)
                Next
                TxtTalleres.PlaceholderText = TotalTalleres
                talleres = TotalTalleres

                Dim colMaterial As Integer = 7
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    TotalMaterial += Val(row.Cells(colMaterial).Value)
                Next
                TxtMateriales.PlaceholderText = TotalMaterial
                materiales = TotalMaterial

                Dim colAdicional As Integer = 8
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    TotalAdicional += Val(row.Cells(colAdicional).Value)
                Next
                TxtAdicional.PlaceholderText = TotalAdicional
                adicional = TotalAdicional

                Dim colComedor As Integer = 9
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

                Dim colSinAsignar1 As Integer = 10
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    totalSinAsignar1 += Val(row.Cells(colSinAsignar1).Value)
                Next
                TxtSinAsignar1.PlaceholderText = totalSinAsignar1
                sinAsignar1 = totalSinAsignar1

                Dim colSinAsignar2 As Integer = 11
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    totalSinAsignar2 += Val(row.Cells(colSinAsignar2).Value)
                Next
                TxtSinasignar2.PlaceholderText = totalSinAsignar2
                sinAsignar2 = totalSinAsignar2

                Dim colSinAsignar3 As Integer = 12
                For Each row As DataGridViewRow In Me.DgvHijos.Rows
                    totalSinAsignar3 += Val(row.Cells(colSinAsignar3).Value)
                Next
                TxtSinAsignar3.PlaceholderText = totalSinAsignar3
                sinAsignar3 = totalSinAsignar3

            End If
            contador += 1
            TxtMatricula.Enabled = False

            totalSeleccion = totalMatricula + TotalCuota + TotalCampamento + TotalTalleres + TotalMaterial + TotalAdicional + TotalComedor + totalSinAsignar1 + totalSinAsignar2 + totalSinAsignar3
            LblTotalAlumno.Text = totalSeleccion
            'TxtMontoAPagar.Text = totalSeleccion
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
        End If


    End Sub


    Sub DataGrid1()
        If Val(CbxCodigo.Text) <> 0 Then

            Dim mes As Integer
            Dim parImpar As Integer
            Dim ultimoVencimiento As Date
            Dim alumno
            Dim totalSeleccion As Decimal


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
                    Dim consultaDgv1 As String = "SELECT  nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, 
                                             campamento_alumno, talleres_alumno, materiales_alumno, adicional_alumno, 
                                             comedor_alumno, importe_concepto1, importe_concepto2, importe_concepto3, 
                                             alumnos.codigo_alumno
                                          FROM alumnos 
                                          JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                                          JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno 
                                          JOIN concepto_sin_asignar_1 ON alumnos.codigo_año = concepto_sin_asignar_1.codigo_año 
										  JOIN concepto_sin_asignar_2 ON alumnos.codigo_año = concepto_sin_asignar_2.codigo_año 
										  JOIN concepto_sin_asignar_3 ON alumnos.codigo_año = concepto_sin_asignar_3.codigo_año
                                          WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_vencimiento = '" & ultimoVencimiento & "' And alumnos.estado = 'activo' "

                    'Dim consulta As String = "SELECT nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, talleres_alumno,
                    '                      materiales_alumno, adicional_alumno, comedor_alumno
                    '                      FROM alumnos 
                    '                      JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                    '                      JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno  
                    '                      WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_vencimiento = '" & ultimoVencimiento & "' And alumnos.estado = 'activo' "

                    Dim comandoDgv1 As New SqlCommand(consultaDgv1, conexion)

                    comandoDgv1.CommandType = CommandType.Text

                    Dim adaptadorDgv1 As New SqlDataAdapter(comandoDgv1)
                    Dim dataSet As New DataSet()
                    adaptadorDgv1.Fill(dataSet)

                    DgvHijos1.DataSource = dataSet.Tables(0).DefaultView

                Catch ex As Exception
                    MsgBox("Error comprobando BD" & ex.ToString)
                End Try

                'Dim alumnoPago As String = "SELECT pago_cumplido 
                '                            FROM pago_detallado 
                '                            WHERE codigo_alumno = " ""

                For Each row As DataGridViewRow In DgvHijos1.Rows

                    row.Cells("Check1").Value = True
                Next
                Dim colAlumno As Integer = 1
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    alumno = row.Cells(colAlumno)

                Next

                Dim colMatricula As Integer = 3
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    totalMatricula += Val(row.Cells(colMatricula).Value)
                Next
                TxtMatricula.PlaceholderText = totalMatricula
                matricula = totalMatricula

                Dim col As Integer = 4
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    TotalCuota += Val(row.Cells(col).Value)
                Next
                TxtArancel.PlaceholderText = TotalCuota
                arancel = TotalCuota

                Dim colCamp As Integer = 5
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    TotalCampamento += (Val(row.Cells(colCamp).Value))
                Next
                TxtCampamento.PlaceholderText = TotalCampamento
                campamento = TotalCampamento

                Dim colTaller As Integer = 6
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    TotalTalleres += Val(row.Cells(colTaller).Value)
                Next
                TxtTalleres.PlaceholderText = TotalTalleres
                talleres = TotalTalleres

                Dim colMaterial As Integer = 7
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    TotalMaterial += Val(row.Cells(colMaterial).Value)
                Next
                TxtMateriales.PlaceholderText = TotalMaterial
                materiales = TotalMaterial

                Dim colAdicional As Integer = 8
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    TotalAdicional += Val(row.Cells(colAdicional).Value)
                Next
                TxtAdicional.PlaceholderText = TotalAdicional
                adicional = TotalAdicional

                Dim colComedor As Integer = 9
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
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

                Dim colSinAsignar1 As Integer = 10
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    totalSinAsignar1 += Val(row.Cells(colSinAsignar1).Value)
                Next
                TxtSinAsignar1.PlaceholderText = totalSinAsignar1
                sinAsignar1 = totalSinAsignar1

                Dim colSinAsignar2 As Integer = 11
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    totalSinAsignar2 += Val(row.Cells(colSinAsignar2).Value)
                Next
                TxtSinasignar2.PlaceholderText = totalSinAsignar2
                sinAsignar2 = totalSinAsignar2

                Dim colSinAsignar3 As Integer = 12
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                    totalSinAsignar3 += Val(row.Cells(colSinAsignar3).Value)
                Next
                TxtSinAsignar3.PlaceholderText = totalSinAsignar3
                sinAsignar3 = totalSinAsignar3

                Dim colCodigoAlumno As Integer = 13
                indiceArrayCodigo = 0
                'ReDim codigoArray(DgvHijos1.Rows.Count - 1)
                For Each row As DataGridViewRow In Me.DgvHijos1.Rows

                    codigoArray(indiceArrayCodigo) = Val(row.Cells(colCodigoAlumno).Value)

                    indiceArrayCodigo += 1
                Next
                LbxCodigo.Items.Clear()

                ' Relleno listbox con los codigos del array

                For Each strName As String In codigoArray
                    LbxCodigo.Items.Add(strName)
                Next
                'TxtCodigoAlumno.PlaceholderText = codigoAlumno
                'sinAsignar3 = totalSinAsignar3

            End If
            contador += 1
            'TxtMatricula.Enabled = False

            totalSeleccion = totalMatricula + TotalCuota + TotalCampamento + TotalTalleres + TotalMaterial + TotalAdicional + TotalComedor
            'LblTotalAlumno.Text = totalSeleccion
            TxtMontoAPagar.Text = totalSeleccion
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
        End If
    End Sub

    Private Sub DgvHijos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHijos.CellValueChanged
        If Val(CbxCodigo.Text) <> 0 Then
            Dim mes As Integer
            Dim parImpar As Integer
            Dim alumno As String
            Dim matricula As Decimal
            Dim totalMatricula As Decimal
            Dim arancel As Decimal
            Dim totalCuota As Decimal
            Dim campamento As Decimal
            Dim totalCampamento As Decimal
            Dim talleres As Decimal
            Dim totalTalleres As Decimal
            Dim materiales As Decimal
            Dim totalMaterial As Decimal
            Dim adicional As Decimal
            Dim totalAdicional As Decimal
            Dim comedor As Decimal
            Dim totalComedor As Decimal

            'Dim colAlumno As Integer = 1
            'For Each row As DataGridViewRow In Me.DgvHijos.Rows
            '    If row.Cells(0).Value = True Then
            '        alumno = (row.Cells(colAlumno).Value)
            '    Else
            '        'totalMatricula -= Val(row.Cells(colAlumno).Value)
            '    End If
            'Next

            'Dim colMatricula As Integer = 3
            'For Each row As DataGridViewRow In Me.DgvHijos.Rows
            '    If row.Cells(0).Value = True Then
            '        totalMatricula = Val(row.Cells(colMatricula).Value)
            '    Else
            '        totalMatricula -= Val(row.Cells(colMatricula).Value)
            '    End If
            'Next
            ''TxtMatricula.PlaceholderText = totalMatricula
            'matricula = totalMatricula

            Dim colAlumno As Integer = 1
            'For Each row As DataGridViewRow In Me.DgvHijos.Rows
            '    If row.Cells("Check").Value = True Then

            '        alumno = row.Cells(colAlumno).Value
            '    Else
            '        alumno = ""
            '    End If
            'Next
            'TxtArancel.PlaceholderText = TotalCuota
            'arancel = totalCuota
            Dim colMatricula As Integer = 3
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                If row.Selected Then
                    totalMatricula += Val(row.Cells(colMatricula).Value)
                Else
                    'totalMatricula = Val(row.Cells(colMatricula).Value)
                End If
            Next
            TxtArancel.PlaceholderText = totalMatricula
            arancel = totalCuota

            Dim col As Integer = 4
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                If row.Cells("Check").Value = True Then
                    totalCuota += Val(row.Cells(col).Value)
                Else
                    'totalCuota = 0
                End If
            Next
            TxtArancel.PlaceholderText = totalCuota
            arancel = totalCuota

            Dim colCamp As Integer = 5
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                If row.Cells("Check").Value = True Then
                    totalCampamento += (Val(row.Cells(colCamp).Value))
                Else
                    'totalCampamento = 0
                End If
            Next
            TxtCampamento.PlaceholderText = totalCampamento
            campamento = totalCampamento

            Dim colTaller As Integer = 6
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                If row.Cells("Check").Value = True Then
                    totalTalleres += Val(row.Cells(colTaller).Value)
                Else
                    'totalTalleres = 0
                End If
            Next
            TxtTalleres.PlaceholderText = totalTalleres
            talleres = totalTalleres

            Dim colMaterial As Integer = 7
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                If row.Cells("Check").Value = True Then
                    totalMaterial += Val(row.Cells(colMaterial).Value)
                Else
                    'totalMaterial = 0
                End If
            Next
            TxtMateriales.PlaceholderText = totalMaterial
            materiales = totalMaterial

            Dim colAdicional As Integer = 8
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                If row.Cells("Check").Value = True Then
                    totalAdicional += Val(row.Cells(colAdicional).Value)
                Else
                    'totalAdicional = 0
                End If
            Next
            TxtAdicional.PlaceholderText = totalAdicional
            adicional = totalAdicional

            Dim colComedor As Integer = 9
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                If row.Cells("Check").Value = True Then
                    totalComedor += Val(row.Cells(colComedor).Value)
                Else
                    'totalComedor = 0
                End If
            Next
            mes = fechaActual.Month
            parImpar = mes Mod 2
            If parImpar <> 0 Then
                TxtComedor.PlaceholderText = totalComedor
                comedor = totalComedor

            Else
                TxtComedor.PlaceholderText = 0
                comedor = 0
                totalComedor = comedor

            End If

            Dim totalFamilia As Decimal = totalMatricula + totalCuota + totalCampamento + totalTalleres + totalMaterial + totalAdicional + totalComedor


            Dim TotalAlumno As Decimal = totalMatricula + totalCuota + totalCampamento + totalTalleres + totalMaterial + totalAdicional + totalComedor
            LblTotalAlumno.Text = TotalAlumno
            LblTotalSeleccionado.Text = TotalAlumno
            'TxtMontoAPagar.Text = TotalAlumno
            'LblAlumno.Text = alumno
        End If

    End Sub

    Private Sub DgvHijos1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHijos1.CellValueChanged
        If Val(CbxCodigo.Text) <> 0 Then
            Dim mes As Integer
            Dim parImpar As Integer
            'Dim alumno As String
            'Dim matricula As Decimal
            Dim totalMatricula As Decimal
            Dim arancel As Decimal
            Dim totalCuota As Decimal
            Dim campamento As Decimal
            Dim totalCampamento As Decimal
            Dim talleres As Decimal
            Dim totalTalleres As Decimal
            Dim materiales As Decimal
            Dim totalMaterial As Decimal
            Dim adicional As Decimal
            Dim totalAdicional As Decimal
            Dim comedor As Decimal
            Dim totalComedor As Decimal



            Dim colAlumno As Integer = 1

            Dim colMatricula As Integer = 3
            For Each row As DataGridViewRow In Me.DgvHijos1.Rows

                If row.Selected Then

                    totalMatricula += Val(row.Cells(colMatricula).Value)

                Else
                    'totalMatricula = Val(row.Cells(colMatricula).Value)
                End If
            Next
            TxtArancel.PlaceholderText = totalMatricula
            arancel = totalCuota

            Dim col As Integer = 4
            For Each row As DataGridViewRow In Me.DgvHijos1.Rows

                If row.Cells("Check1").Value = True Then

                    totalCuota += Val(row.Cells(col).Value)
                Else
                    'totalCuota = 0

                End If
            Next
            TxtArancel.PlaceholderText = totalCuota
            arancel = totalCuota

            Dim colCamp As Integer = 5
            For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                If row.Cells("Check1").Value = True Then
                    totalCampamento += (Val(row.Cells(colCamp).Value))
                Else
                    'totalCampamento = 0
                End If
            Next
            TxtCampamento.PlaceholderText = totalCampamento
            campamento = totalCampamento

            Dim colTaller As Integer = 6
            For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                If row.Cells("Check1").Value = True Then
                    totalTalleres += Val(row.Cells(colTaller).Value)
                Else
                    'totalTalleres = 0
                End If
            Next
            TxtTalleres.PlaceholderText = totalTalleres
            talleres = totalTalleres

            Dim colMaterial As Integer = 7
            For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                If row.Cells("Check1").Value = True Then
                    totalMaterial += Val(row.Cells(colMaterial).Value)
                Else
                    'totalMaterial = 0
                End If
            Next
            TxtMateriales.PlaceholderText = totalMaterial
            materiales = totalMaterial

            Dim colAdicional As Integer = 8
            For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                If row.Cells("Check1").Value = True Then
                    totalAdicional += Val(row.Cells(colAdicional).Value)
                Else
                    'totalAdicional = 0
                End If
            Next
            TxtAdicional.PlaceholderText = totalAdicional
            adicional = totalAdicional

            Dim colComedor As Integer = 9
            For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                If row.Cells("Check1").Value = True Then
                    totalComedor += Val(row.Cells(colComedor).Value)
                Else
                    'totalComedor = 0
                End If
            Next
            mes = fechaActual.Month
            parImpar = mes Mod 2
            If parImpar <> 0 Then
                TxtComedor.PlaceholderText = totalComedor
                comedor = totalComedor

            Else
                TxtComedor.PlaceholderText = 0
                comedor = 0
                totalComedor = comedor

            End If


            Dim colCodigoAlumno As Integer = 13
            indiceArrayCodigo = 0
            ReDim codigoArray(DgvHijos1.Rows.Count - 1)
            For Each row As DataGridViewRow In Me.DgvHijos1.Rows
                If row.Cells("Check1").Value = True Then

                    codigoArray(indiceArrayCodigo) = Val(row.Cells(colCodigoAlumno).Value)
                End If
                indiceArrayCodigo += 1
            Next
            LbxCodigo.Items.Clear()

            ' Relleno listbox con los codigos del array

            For Each strName As String In codigoArray

                LbxCodigo.Items.Add(strName)

            Next


            Dim totalFamilia As Decimal = totalMatricula + totalCuota + totalCampamento + totalTalleres + totalMaterial + totalAdicional + totalComedor


            Dim TotalAlumno As Decimal = totalMatricula + totalCuota + totalCampamento + totalTalleres + totalMaterial + totalAdicional + totalComedor
            LblTotalAlumno.Text = TotalAlumno
            LblTotalSeleccionado.Text = TotalAlumno
            TxtMontoAPagar.Text = TotalAlumno
            'LblAlumno.Text = alumno
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

    Private Sub TxtOtros_KeyUp(sender As Object, e As KeyEventArgs)
        Suma()
    End Sub
    Private Sub TxtCampamento_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtTalleres.KeyUp, TxtMatricula.KeyUp, TxtMateriales.KeyUp, TxtComedor.KeyUp, TxtCampamento.KeyUp, TxtArancel.KeyUp, TxtAdicional.KeyUp
        Resta()
    End Sub

    Private Sub TxtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtDebito_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtCheque_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtTransferencia_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtMercadopago_KeyPress_1(sender As Object, e As KeyPressEventArgs)
        SoloNumeros(e)
    End Sub

    Private Sub TxtOtros_KeyPress_1(sender As Object, e As KeyPressEventArgs)
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
        'DataGrid1()
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
        Dim credito As Decimal = 0
        Dim atraso As Decimal = 0
        If Val(CbxCodigo.Text) <> 0 Then
            Dim fechaCredito As Integer
            Dim fechaActual As Date = Date.Today
            fechaCredito = fechaActual.Month       '- 1

            Dim codigo As String = "SELECT codigo_pago_deuda_año, credito, monto_atraso
                                    FROM pago_detallado 
                                    WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND month(periodo_de_pago) = '" & fechaCredito & "'"
            Dim comandoCodigo As New SqlCommand(codigo, conexion)

            Dim adaptador As New SqlDataAdapter(comandoCodigo)
            Dim dtCodigo As New DataTable
            adaptador.Fill(dtCodigo)

            For Each row As DataRow In dtCodigo.Rows
                credito += Val(row(1))
                atraso += Val(row(2))
            Next

            TxtCredito.Text = credito
            TxtCredDisp.Text = credito
            TxtSubTotal.Text = atraso
            'TxtMontoAPagar.Text = atraso - credito
            TxtTotalAPagar.Text = atraso - credito
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir2_Click(sender As Object, e As EventArgs) Handles BtnSalir2.Click
        If BtnGuardar.Enabled = True Then
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

    Private Sub DgvHijos_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvHijos.CurrentCellDirtyStateChanged
        If DgvHijos.IsCurrentCellDirty Then
            DgvHijos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub

    Private Sub DgvHijos1_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles DgvHijos1.CurrentCellDirtyStateChanged
        If DgvHijos1.IsCurrentCellDirty Then
            DgvHijos1.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub TxtEfectivo_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles TxtEfectivo.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtEfectivo_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtEfectivo.KeyUp
        Suma()
    End Sub

    Private Sub TxtDebito_KeyPress_2(sender As Object, e As KeyPressEventArgs) Handles TxtDebito.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtDebito_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtDebito.KeyUp
        Suma()
    End Sub

    Private Sub TxtCheque_KeyPress_2(sender As Object, e As KeyPressEventArgs) Handles TxtCheque.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCheque_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtCheque.KeyUp
        Suma()
    End Sub

    Private Sub TxtTransferencia_KeyPress_2(sender As Object, e As KeyPressEventArgs) Handles TxtTransferencia.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTransferencia_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtTransferencia.KeyUp
        Suma()
    End Sub

    Private Sub TxtMercadopago_KeyPress_2(sender As Object, e As KeyPressEventArgs) Handles TxtMercadopago.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtMercadopago_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtMercadopago.KeyUp
        Suma()
    End Sub

    Private Sub TxtOtros_KeyPress_2(sender As Object, e As KeyPressEventArgs) Handles TxtOtros.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtOtros_KeyUp_1(sender As Object, e As KeyEventArgs) Handles TxtOtros.KeyUp
        Suma()
    End Sub
End Class