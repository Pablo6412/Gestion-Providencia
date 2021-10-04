Imports System.Data.SqlClient

'Este formulario lee las siguientes tablas: detalle_vencimientos_escolares
'                                           familias
'                                           detalle_pago_escolar
'                                           descuento_hermano
'                                           alumnos
'                                           descuento_beca
'                                           descuento_especial
'                                           pago_adelantado
'SELECT JOIN: alumnos, curso, aranceles, taller, descuento_beca, descuento_especial

'UPDATE: cuotas, detalle_vencimientos_escolares, pago_adelantado

'INSERT: detalle_vencimientos_escolares
'        detalle_pago_escolar
'        vencimiento_detallado

Public Class FrmEmisiónDeVencimientos
    Dim comando As SqlCommand
    Dim comando2 As SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim fechaActual As Date = Date.Today
    Dim codFam As Integer = 1
    Dim datos As DataSet
    Dim codigoAlumno As Integer
    Dim arancel As Decimal
    Dim totalCampamento As Decimal
    Dim totalTaller As Decimal
    Dim totalMateriales As Decimal
    Dim totalAdicional As Decimal
    Dim totalComedor As Decimal
    Dim totalArancel As Decimal
    Dim hermanoNumero As Integer
    Dim cuota As Decimal
    Dim totalCuota As Decimal
    Dim descuentoHermano As Decimal
    Dim descuentoBeca As Decimal
    Dim descuentoEspecial As Decimal
    Dim cantFam As Integer
    Dim maxcod As Integer

    Private Sub FrmEmisiónDeVencimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ultimaFecha As Date
        conectar()
        abrir()
        Dim fecha As String = "SELECT fecha_vencimiento FROM detalle_vencimientos_escolares 
                               WHERE codigo_pago_v = (SELECT MAX(codigo_pago_v) 
                               FROM detalle_vencimientos_escolares)"
        Dim comando As New SqlCommand(fecha, conexion)
        ultimaFecha = comando.ExecuteScalar

        'If (fechaActual.Month = ultimaFecha.Month) Then
        '    BtnVencimientos.Enabled = False
        '    MsgBox("Los vencimientos del presente mes ya fueron realizados.")
        'End If
    End Sub

    Private Sub BtnVencimientos_Click(sender As Object, e As EventArgs) Handles BtnVencimientos.Click
        conectar()
        abrir()

        grabaVencimientos()
        grabaPagoNulo()
    End Sub

    Private Sub grabaVencimientos()
        Dim numeroHijos As Integer
        Dim campamento As Decimal
        Dim taller As Decimal
        Dim materiales As Decimal
        Dim adicional As Decimal
        Dim comedor As Decimal
        Dim vencimentoAlumno As String
        Dim adelanto As String
        Dim comandoVencimientoAlumnos As New SqlCommand
        Dim cantidadFamilias As String = "SELECT COUNT(codigo_familia) FROM familias WHERE estado = 'activo' "
        Dim comandoCantidad As New SqlCommand(cantidadFamilias, conexion)
        cantFam = comandoCantidad.ExecuteScalar

        Pbuno.Minimum = 0
        Pbuno.Maximum = cantFam
        Pbuno.Value = 0

        Dim restrictionValues() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}
        Dim dt As DataTable = conexion.GetSchema("TABLES", restrictionValues)
        Dim rows() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")
        CreaTablaTemporal(rows)

        Dim maximocod As String = "SELECT MAX(codigo_familia) FROM familias WHERE estado = 'activo' "
        Dim comando1 As New SqlCommand(maximocod, conexion)
        maxcod = comando1.ExecuteScalar

        Dim L As Integer = 1

        While codFam <= maxcod
            Dim pagoAdelantado As String = "SELECT pago_adelantado FROM familias WHERE codigo_familia = " & codFam & " "
            Dim comandoAdelantado As New SqlCommand(pagoAdelantado, conexion)
            adelanto = comandoAdelantado.ExecuteScalar()

            If adelanto = "si" Then
                VerificaPagoAdelantado(codFam)

            Else

                totalCuota = 0
                Dim cantidadHijos As String = "SELECT COUNT(codigo_alumno) FROM alumnos WHERE codigo_familia = " & codFam & ""
                Dim comandoHijos As New SqlCommand(cantidadHijos, conexion)
                numeroHijos = comandoHijos.ExecuteScalar()

                Pbuno.Increment(L)

                'Next L

                Dim porcentaje As Double = (Pbuno.Value / cantFam) * 100
                LblPbuno.Text = "Vencimientos generados al: " & porcentaje & "%"
                LblPbuno.Refresh()

                'Math.Round(Pbuno.Value / 0.03, 2)

                Dim consulta As String = " SELECT alumnos.codigo_alumno, nombre_apellido_alumno, curso, arancel_importe, hermano_numero, 
                                           valor_cuota, campamento.valor as campamento_importe, importe_taller, material.valor, 
                                           importe as adicional_importe, comedor_importe  
                                       FROM alumnos 
                                       JOIN cursos ON alumnos.codigo_curso = cursos.codigo_curso
									   JOIN aranceles ON alumnos.codigo_arancel = aranceles.codigo_arancel
									   JOIN cuotas ON alumnos.codigo_alumno = cuotas.codigo_alumno
									   JOIN campamento ON alumnos.codigo_año = campamento.codigo_año
									   JOIN taller_temporal ON alumnos.codigo_alumno = taller_temporal.codigo_alumno
									   JOIN material ON alumnos.codigo_año = material.codigo_año
									   JOIN adicional ON alumnos.codigo_año = adicional.codigo_año
                                       WHERE alumnos.codigo_familia = " & codFam & " AND alumnos.estado = 'activo'"

                'WHERE alumnos.codigo_familia =  AND alumnos.estado = 'activo' ORDER BY alumnos.codigo_alumno"

                comando = New SqlCommand()
                comando.CommandText = consulta
                comando.CommandType = CommandType.Text
                comando.Connection = conexion
                adaptador = New SqlDataAdapter(comando)
                Dim dataSet As DataSet = New DataSet()
                adaptador.Fill(dataSet)
                Dim m As Integer = 1
                Pbdos.Value = 0

                For Each fila As DataRow In dataSet.Tables(0).Rows()



                    Dim numHijos As String = "SELECT COUNT(codigo_alumno)  
                                              FROM alumnos 
                                              WHERE codigo_familia = " & codFam & " AND estado = 'activo' "
                    Dim comandoNum As New SqlCommand(numHijos, conexion)

                    'cantidad = comandoNum.ExecuteScalar
                    Dim cantidad As Integer = comandoNum.ExecuteScalar

                    Pbdos.Minimum = 0
                    Pbdos.Maximum = cantidad
                    TimerHijos.Interval = 1
                    TimerHijos.Enabled = True
                    Pbdos.Increment(m)
                    Dim porcentajeAl As Double = (Pbdos.Value / cantidad) * 100
                    LblPbdos.Text = "Progreso parcial: " & porcentajeAl & "%"
                    LblPbdos.Refresh()

                    codigoAlumno = Val(fila(0))
                    arancel = Val(fila(3))
                    totalArancel += Val(fila(3))
                    hermanoNumero = fila(4)
                    cuota = Val(fila(5))
                    totalCuota += Val(fila(5))
                    campamento = Val(fila(6))
                    totalCampamento += Val(fila(6))
                    taller = Val(fila(7))
                    totalTaller += Val(fila(7))
                    materiales = Val(fila(8))
                    totalMateriales += Val(fila(8))
                    adicional = Val(fila(9))
                    totalAdicional += Val(fila(9))
                    comedor = Val(fila(10))
                    totalComedor += Val(fila(10))
                    CalculaCuota()
                    vencimentoAlumno = "INSERT INTO vencimiento_detallado (codigo_familia, codigo_alumno, cuota_alumno, 
                                    materiales_alumno, talleres_alumno,
                                    campamento_alumno, adicional_alumno, comedor_alumno, fecha_vencimiento) 
                                    VALUES(@codigo_familia, @codigo_alumno, @cuota_alumno, @materiales_alumno, @talleres_alumno, 
                                    @campamento_alumno, 
                                    @adicional_alumno, @comedor_alumno, @fecha_vencimiento) "
                    comandoVencimientoAlumnos = New SqlCommand(vencimentoAlumno, conexion)

                    comandoVencimientoAlumnos.Parameters.AddWithValue("@codigo_familia", codFam)
                    comandoVencimientoAlumnos.Parameters.AddWithValue("@codigo_alumno", codigoAlumno)
                    comandoVencimientoAlumnos.Parameters.AddWithValue("@cuota_alumno", cuota)
                    comandoVencimientoAlumnos.Parameters.AddWithValue("@materiales_alumno", materiales)
                    comandoVencimientoAlumnos.Parameters.AddWithValue("@talleres_alumno", taller)
                    comandoVencimientoAlumnos.Parameters.AddWithValue("@Campamento_alumno", campamento)
                    comandoVencimientoAlumnos.Parameters.AddWithValue("@Adicional_alumno", adicional)
                    comandoVencimientoAlumnos.Parameters.AddWithValue("@Comedor_alumno", comedor)
                    comandoVencimientoAlumnos.Parameters.AddWithValue("@fecha_vencimiento", fechaActual)

                    comandoVencimientoAlumnos.ExecuteNonQuery()

                    'MsgBox("Codigo Familia: " & codFam & " Codigo alumno: " & codigoAlumno & " descuento Herman0: " & descuentoHermano & " descuento beca: " & descuentoBeca & " descuento especial: " & descuentoEspecial & " arancel: " & arancel & " cuota: " & cuota & "")

                    Dim valorCuota As String = " UPDATE cuotas SET valor_cuota = '" & cuota & "' 
                                                 WHERE codigo_alumno = '" & codigoAlumno & "' "
                    Dim comando As New SqlCommand(valorCuota, conexion)
                    comando.ExecuteNonQuery()

                    If comando.ExecuteNonQuery() = 1 Then
                        'MessageBox.Show("Datos de cuota actualizados")

                    Else
                        MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                    End If

                    'MsgBox("código de familia:  " & codFam & "Hermano Número: " & hermanoNumero & " Arancel: " & arancel & " Campamento: " & totalCampamento & "")
                    'MsgBox("" & Arancel & "")
                    'MsgBox("" & totalCampamento & "")
                Next

                If hermanoNumero <> 0 Then
                    Dim vencimiento As String = "INSERT INTO detalle_vencimientos_escolares(codigo_familia, aranceles_v, materiales_v, 
                                             talleres_v, campamento_v, adicional_v, comedor_v, fecha_vencimiento) 
                                             VALUES(@codFam, @totalCuota, @totalMateriales, @totalTaller, @totalCampamento, 
                                             @totalAdicional, @totalComedor, @fechaVencimiento)"

                    comando2 = New SqlCommand(vencimiento, conexion)

                    comando2.Parameters.AddWithValue("@codFam", codFam)
                    comando2.Parameters.AddWithValue("@totalCuota", totalCuota)
                    comando2.Parameters.AddWithValue("@totalMateriales", totalMateriales)
                    comando2.Parameters.AddWithValue("@totalTaller", totalTaller)
                    comando2.Parameters.AddWithValue("@totalCampamento", totalCampamento)
                    comando2.Parameters.AddWithValue("@totalAdicional", totalAdicional)
                    comando2.Parameters.AddWithValue("@totalComedor", totalComedor)
                    comando2.Parameters.AddWithValue("@fechaVencimiento", fechaActual)

                    If comando2.ExecuteNonQuery() = 1 Then
                        'MessageBox.Show("Datos guardados")

                    Else
                        MsgBox("Error de grabación")
                    End If

                    ActualizaCredito(codFam)

                    arancel = 0
                    hermanoNumero = 0
                    totalCampamento = 0
                    totalTaller = 0
                    totalMateriales = 0
                    totalAdicional = 0
                    totalComedor = 0
                End If
            End If
            codFam += 1


            'Pbuno.Value = codFam - 1

        End While
        LblPbdos.Hide()
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
        'MsgBox("Datos guardados")
    End Sub

    Private Sub VerificaPagoAdelantado(codFam)
        'MsgBox("El codigo de familia es " & codFam & "")
        Dim cuotasRestantes As Integer
        Dim materiales As Decimal
        Dim campamento As Decimal
        Dim taller As Decimal
        Dim adicional As Decimal
        Dim comedor As Decimal
        Dim cantCuotas As Integer
        Dim codigoAdelanto As Integer
        Dim AdelantoFamilia As String = "SELECT SUM(cantidad_cuotas) AS cantidad_cuotas, SUM(monto) AS monto, SUM(cuotas_restantes) AS cuotas_restantes 
                                         FROM pago_adelantado 
                                         WHERE codigo_familia = " & codFam & " 
                                         GROUP BY codigo_familia "

        Dim adaptadorAdelanto As New SqlDataAdapter(AdelantoFamilia, conexion)
        Dim DatosAdelanto As New DataTable
        adaptadorAdelanto.Fill(DatosAdelanto)

        Dim consulta As String = " SELECT alumnos.codigo_alumno, nombre_apellido_alumno, curso, arancel_importe, hermano_numero, valor_cuota, 
                                       campamento.valor as campamento_importe, importe_taller, material.valor, importe as adicional_importe, 
                                       comedor_importe  
                                       FROM alumnos 
                                       JOIN cursos ON alumnos.codigo_curso = cursos.codigo_curso
									   JOIN aranceles ON alumnos.codigo_arancel = aranceles.codigo_arancel
									   JOIN cuotas ON alumnos.codigo_alumno = cuotas.codigo_alumno
									   JOIN campamento ON alumnos.codigo_año = campamento.codigo_año
									   JOIN taller_temporal ON alumnos.codigo_alumno = taller_temporal.codigo_alumno
									   JOIN material ON alumnos.codigo_año = material.codigo_año
									   JOIN adicional ON alumnos.codigo_año = adicional.codigo_año
                                       WHERE alumnos.codigo_familia = " & codFam & " AND alumnos.estado = 'activo'"

        'WHERE alumnos.codigo_familia =  AND alumnos.estado = 'activo' ORDER BY alumnos.codigo_alumno"

        comando = New SqlCommand()
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        comando.Connection = conexion
        adaptador = New SqlDataAdapter(comando)
        Dim dataSet As DataSet = New DataSet()
        adaptador.Fill(dataSet)

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            cuotasRestantes = DatosAdelanto.Rows(0)("cuotas_restantes")
            codigoAlumno = Val(fila(0))
            totalArancel = 0
            hermanoNumero = fila(4)
            cuota = 0
            totalCuota = 0
            campamento = 0
            totalCampamento = 0
            taller = 0
            totalTaller = 0
            materiales = 0
            totalMateriales = 0
            adicional = 0
            totalAdicional = 0
            comedor = 0
            totalComedor = 0


            Dim vencimentoAlumno As String = "INSERT INTO vencimiento_detallado (codigo_familia, codigo_alumno, cuota_alumno, 
                                    materiales_alumno, talleres_alumno,
                                    campamento_alumno, adicional_alumno, comedor_alumno, fecha_vencimiento) 
                                    VALUES(@codigo_familia, @codigo_alumno, @cuota_alumno, @materiales_alumno, @talleres_alumno, 
                                    @campamento_alumno, 
                                    @adicional_alumno, @comedor_alumno, @fecha_vencimiento) "
            Dim comandoVencimientoAlumnos As New SqlCommand(vencimentoAlumno, conexion)

            comandoVencimientoAlumnos.Parameters.AddWithValue("@codigo_familia", codFam)
            comandoVencimientoAlumnos.Parameters.AddWithValue("@codigo_alumno", codigoAlumno)
            comandoVencimientoAlumnos.Parameters.AddWithValue("@cuota_alumno", cuota)
            comandoVencimientoAlumnos.Parameters.AddWithValue("@materiales_alumno", materiales)
            comandoVencimientoAlumnos.Parameters.AddWithValue("@talleres_alumno", taller)
            comandoVencimientoAlumnos.Parameters.AddWithValue("@Campamento_alumno", campamento)
            comandoVencimientoAlumnos.Parameters.AddWithValue("@Adicional_alumno", adicional)
            comandoVencimientoAlumnos.Parameters.AddWithValue("@Comedor_alumno", comedor)
            comandoVencimientoAlumnos.Parameters.AddWithValue("@fecha_vencimiento", fechaActual)

            comandoVencimientoAlumnos.ExecuteNonQuery()

            'MsgBox("Codigo Familia: " & codFam & " Codigo alumno: " & codigoAlumno & " descuento Herman0: " & descuentoHermano & " descuento beca: " & descuentoBeca & " descuento especial: " & descuentoEspecial & " arancel: " & arancel & " cuota: " & cuota & "")

            Dim valorCuota As String = " UPDATE cuotas SET valor_cuota = '" & cuota & "' WHERE codigo_alumno = '" & codigoAlumno & "' "
            Dim comando As New SqlCommand(valorCuota, conexion)
            comando.ExecuteNonQuery()

            If comando.ExecuteNonQuery() = 1 Then
                'MessageBox.Show("Datos de cuota actualizados")

            Else
                MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
            End If

            'MsgBox("código de familia:  " & codFam & "Hermano Número: " & hermanoNumero & " Arancel: " & arancel & " Campamento: " & totalCampamento & "")
            'MsgBox("" & Arancel & "")
            'MsgBox("" & totalCampamento & "")
        Next

        If hermanoNumero <> 0 Then
            Dim vencimiento As String = "INSERT INTO detalle_vencimientos_escolares(codigo_familia, aranceles_v, materiales_v, 
                                             talleres_v, campamento_v, adicional_v, comedor_v, fecha_vencimiento) 
                                             VALUES(@codFam, @totalCuota, @totalMateriales, @totalTaller, @totalCampamento, 
                                             @totalAdicional, @totalComedor, @fechaVencimiento)"

            comando2 = New SqlCommand(vencimiento, conexion)

            comando2.Parameters.AddWithValue("@codFam", codFam)
            comando2.Parameters.AddWithValue("@totalCuota", totalCuota)
            comando2.Parameters.AddWithValue("@totalMateriales", totalMateriales)
            comando2.Parameters.AddWithValue("@totalTaller", totalTaller)
            comando2.Parameters.AddWithValue("@totalCampamento", totalCampamento)
            comando2.Parameters.AddWithValue("@totalAdicional", totalAdicional)
            comando2.Parameters.AddWithValue("@totalComedor", totalComedor)
            comando2.Parameters.AddWithValue("@fechaVencimiento", fechaActual)

            If comando2.ExecuteNonQuery() = 1 Then
                'MessageBox.Show("Datos guardados")

            Else
                MsgBox("Error de grabación")
            End If

        End If
        Dim cuotasAdelanto As String = "SELECT min(codigo_pago_adelantado) AS codigo, codigo_familia, cuotas_restantes 
                                        FROM pago_adelantado  
                                        WHERE codigo_familia = " & codFam & " AND cuotas_restantes <> 0
                                        GROUP BY codigo_familia, cuotas_restantes"

        Dim adaptadorCuotas As New SqlDataAdapter(cuotasAdelanto, conexion)
        Dim DatosCuotas As New DataTable
        adaptadorCuotas.Fill(DatosCuotas)

        'Dim comandoCuotas As New SqlCommand(cuotasAdelanto, conexion)
        'cantCuotas = comandoCuotas.ExecuteScalar()
        If DatosCuotas.Rows.Count > 0 Then
            cantCuotas = DatosCuotas.Rows(0)("cuotas_restantes")
            codigoAdelanto = DatosCuotas.Rows(0)("codigo")
            cantCuotas -= 1

            Dim restaAdelanto As String = "UPDATE pago_adelantado 
                                       SET cuotas_restantes = " & cantCuotas & " 
                                       WHERE codigo_pago_adelantado = " & codigoAdelanto & ""
            Dim comandoResta As New SqlCommand(restaAdelanto, conexion)
            comandoResta.ExecuteNonQuery()
        Else
            Dim no As String = "UPDATE familias SET pago_adelantado = 'no' WHERE codigo_familia = " & codFam & " "
            Dim comandoNo As New SqlCommand(no, conexion)
            If comandoNo.ExecuteNonQuery() = 1 Then
                'MsgBox("Datos guardados")

            Else
                MsgBox("Error guardando los datos")
            End If
        End If
    End Sub


    Private Sub CreaTablaTemporal(rows)


        If rows.Length > 0 Then
            'MessageBox.Show("Existe la tabla.")
        Else
            Dim tallerTemp As String = "SELECT codigo_alumno, SUM(importe_taller) as importe_taller 
                                        INTO taller_temporal 
                                        FROM taller_alumno  
                                        GROUP BY codigo_alumno"
            Dim comandoTaller As New SqlCommand(tallerTemp, conexion)
            comandoTaller.ExecuteNonQuery()

            'MsgBox("Tabla creada")
            'MessageBox.Show("No existe la tabla.")
        End If
    End Sub

    Private Sub ActualizaCredito(codFam)

        Dim credito As Decimal
        Dim codigo


        Dim maxCod As String = "SELECT MAX(codigo_detalle_pago) as codigo 
                                FROM detalle_pago_escolar 
                                WHERE codigo_familia = '" & codFam & "' "
        adaptador = New SqlDataAdapter(maxCod, conexion)
        Dim comandoMaxCod As New SqlCommand(maxCod, conexion)

        codigo = comandoMaxCod.ExecuteScalar()
        If comandoMaxCod.ExecuteNonQuery = 0 Then
            MsgBox("Error consultando código")
        End If

        If codigo Is Nothing Then

        Else
            Try
                Dim consultaCredito As String = "SELECT  credito 
                                                 FROM detalle_pago_escolar 
                                                 WHERE codigo_detalle_pago = '" & codigo & "' "
                Dim comando As New SqlCommand(consultaCredito, conexion)
                credito = comando.ExecuteScalar

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
            End Try

            Dim buscaCodigo As String = "SELECT MAX(codigo_pago_v) 
                                         FROM detalle_vencimientos_escolares 
                                         WHERE codigo_familia = '" & codFam & "' "
            Dim comandoBuscaCodigo As New SqlCommand(buscaCodigo, conexion)
            codigo = comandoBuscaCodigo.ExecuteScalar
            If comandoBuscaCodigo.ExecuteNonQuery = 0 Then
                MsgBox("Error buscando codigo")
            End If

            Dim actualizaCredito As String = "UPDATE detalle_vencimientos_escolares 
                                              SET credito_v = " & credito & " 
                                              WHERE codigo_familia = " & codFam & " AND codigo_pago_v = " & codigo & ""
            Dim comandoActualizaCredito As New SqlCommand(actualizaCredito, conexion)
            If comandoActualizaCredito.ExecuteNonQuery = 0 Then
                MsgBox("Error actualizando crédito")
            End If

        End If



    End Sub

    Private Sub CalculaCuota()

        'Descuento que corresponde según número de hermano

        If hermanoNumero <> 0 Then
            Dim descuentoPorHermano As String = "SELECT descuento_hermano 
                                                 FROM descuento_hermano 
                                                 WHERE hermano_numero = '" & hermanoNumero & "' "
            adaptador = New SqlDataAdapter(descuentoPorHermano, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_hermano")
            adaptador.Fill(datos.Tables("descuento_hermano"))
            If hermanoNumero > 6 Then
                descuentoHermano = 0.5
                'MsgBox("descuento hermano: " & descuentoHermano & "")
            Else
                descuentoHermano = datos.Tables("descuento_hermano").Rows(0).Item("descuento_hermano")
                'MsgBox("descuento Hermano: " & descuentoHermano & "")
            End If

        End If
        'MsgBox("codigoAl: " & codigoAlumno & "")
        'Descuento por beca que corresponde a la familia.
        Dim codigoBeca As Integer
        Dim codBeca As String = "SELECT codigo_beca FROM alumnos where codigo_alumno = '" & codigoAlumno & "'"
        Dim comando As New SqlCommand(codBeca, conexion)
        codigoBeca = comando.ExecuteScalar
        'MsgBox("codigo beca: " & codigoBeca & "")

        If codigoBeca <> 0 Then
            Dim tipoBeca As String = "SELECT descuento_beca FROM descuento_beca where codigo_beca = '" & codigoBeca & "' "
            adaptador = New SqlDataAdapter(tipoBeca, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_beca")
            adaptador.Fill(datos.Tables("descuento_beca"))
            descuentoBeca = datos.Tables("descuento_beca").Rows(0).Item("descuento_beca")
            'MsgBox("descuento beca: " & descuentoBeca & "")

        Else
            descuentoBeca = 1
        End If

        Dim filasTabla As Integer

        abrir()
        'Se busca en la tabla descuento_especial si la familia seleccionada tiene algún descuento de amigo
        Dim sql As String = "SELECT COUNT(*) " &
                           "FROM descuento_especial " &
                           "WHERE codigo_familia ='" & codFam & "'"

        Dim comando4 As New SqlCommand(sql, conexion)
        filasTabla = comando4.ExecuteScalar

        'Si encuentra descuento para la familia
        If filasTabla <> 0 Then

            Dim descEspecial As String = "SELECT descuento FROM descuento_especial WHERE codigo_familia = '" & codFam & "' "
            adaptador = New SqlDataAdapter(descEspecial, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_especial")
            adaptador.Fill(datos.Tables("descuento_especial"))

            descuentoEspecial = datos.Tables("descuento_especial").Rows(0).Item("descuento")
            'TxtPrueba.Text = descuentoEspecial
            'MsgBox("descuento especial: " & descuentoEspecial & "")
        Else
            descuentoEspecial = 1
            'TxtPrueba.Text = descuentoEspecial
            'MsgBox("descuento especial: " & descuentoEspecial & "")
        End If
        'MsgBox("Arancel: " & arancel & "")
        cuota = arancel * descuentoHermano * descuentoEspecial * descuentoBeca
        'TxtCuota.Text = cuota
        'MsgBox("cuota: " & cuota & "")
    End Sub

    Private Sub grabaPagoNulo()
        Dim codigo As Integer = 1

        While codigo <= maxcod
            Dim familiaActiva As String = "SELECT codigo_familia FROM familias WHERE codigo_familia = '" & codigo & "' and estado = 'activo'"
            Dim adaptador As New SqlDataAdapter(familiaActiva, conexion)
            Dim dtDatos As DataTable = New DataTable
            adaptador.Fill(dtDatos)

            If dtDatos.Rows.Count > 0 Then

                Dim pagoNulo As String = "INSERT INTO detalle_pago_escolar (codigo_familia, aranceles, materiales, talleres, campamento, 
                                          adicional, comedor, fecha_de_pago, pago_cumplido) VALUES(@codFam, @totalCuota, @totalMateriales, 
                                          @totalTaller, @totalCampamento, @totalAdicional, @totalComedor, @fechaDePago, @pago_cumplido)"
                Dim comandoPagoNulo As New SqlCommand(pagoNulo, conexion)

                comandoPagoNulo.Parameters.AddWithValue("@codFam", codigo)
                comandoPagoNulo.Parameters.AddWithValue("@totalCuota", 0)
                comandoPagoNulo.Parameters.AddWithValue("@totalMateriales", 0)
                comandoPagoNulo.Parameters.AddWithValue("@totalTaller", 0)
                comandoPagoNulo.Parameters.AddWithValue("@totalCampamento", 0)
                comandoPagoNulo.Parameters.AddWithValue("@totalAdicional", 0)
                comandoPagoNulo.Parameters.AddWithValue("@totalComedor", 0)
                comandoPagoNulo.Parameters.AddWithValue("@fechaDePago", fechaActual)
                comandoPagoNulo.Parameters.AddWithValue("@pago_cumplido", "Nulo")

                If comandoPagoNulo.ExecuteNonQuery() = 1 Then

                Else
                    MsgBox("Error de grabación")
                End If
            End If
            codigo += 1
        End While
        MessageBox.Show("Datos guardados satisfactoriamente")
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    'Private Sub TimerHijos_Tick(sender As Object, e As EventArgs) Handles TimerHijos.Tick
    '    If Pbdos.Value < 100 Then

    '        Dim porcentajeAl As Double = (Pbdos.Value / cantidad) * 100
    '        LblPbdos.Text = "Vencimientos generados al: " & porcentajeAl & "%"
    '        LblPbdos.Refresh()
    '        'contadorTimer = contadorTimer + 5
    '        Pbdos.Value = Pbdos.Value + 0.01
    '        'LblTimer.Text = "Cargando sistema al " & ProgressBar1.Value & "%"
    '    Else
    '        TimerHijos.Enabled = False
    '        'Me.Hide()
    '        'FrmPrincipal.Show()
    '    End If
    'End Sub
End Class