Imports System.Data.SqlClient

'Este formulario lee las siguientes tablas: detalle_vencimientos_escolares
'                                           familias
'                                           detalle_pago_escolar
'                                           descuento_hermano
'                                           alumnos
'                                           descuento_beca
'                                           descuento_especial
'SELECT JOIN: alumnos, curso, aranceles, taller, descuento_beca, descuento_especial

'UPDATE: cuotas, detalle_vencimientos_escolares

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
    Dim descuentoHermano As Decimal
    Dim descuentoBeca As Decimal
    Dim descuentoEspecial As Decimal
    Dim cantFam As Integer
    Dim maxcod As Integer



    Private Sub FrmEmisiónDeVencimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ultimaFecha As Date
        conectar()
        abrir()
        Dim fecha As String = "SELECT fecha_vencimiento FROM detalle_vencimientos_escolares WHERE codigo_pago_v = (SELECT MAX(codigo_pago_v) FROM detalle_vencimientos_escolares)"
        Dim comando As New SqlCommand(fecha, conexion)
        ultimaFecha = comando.ExecuteScalar

        If (fechaActual.Month <> ultimaFecha.Month) Then
            BtnVencimientos.Enabled = False
            MsgBox("Los vencimientos del presente mes ya fueron realizados.")
        End If
    End Sub

    Private Sub BtnVencimientos_Click(sender As Object, e As EventArgs) Handles BtnVencimientos.Click
        conectar()
        abrir()
        grabaVencimientos()
        grabaPagoNulo()
    End Sub

    Private Sub grabaVencimientos()
        Dim campamento As Decimal
        Dim taller As Decimal
        Dim materiales As Decimal
        Dim adicional As Decimal
        Dim comedor As Decimal
        Dim vencimentoAlumno As String
        Dim comandoVencimientoAlumnos As New SqlCommand
        Dim cantidadFamilias As String = "SELECT COUNT(codigo_familia) FROM familias WHERE estado = 'activo' "
        Dim comandoCantidad As New SqlCommand(cantidadFamilias, conexion)
        cantFam = comandoCantidad.ExecuteScalar

        Pbuno.Minimum = 0
        Pbuno.Maximum = cantFam
        Pbuno.Value = 0

        Dim maximocod As String = "SELECT MAX(codigo_familia) FROM familias WHERE estado = 'activo' "
        Dim comando1 As New SqlCommand(maximocod, conexion)
        maxcod = comando1.ExecuteScalar
        'MsgBox("Maximo código" & maxcod & "")
        'MsgBox("Codigo de familia" & codFam & "")

        While codFam <= maxcod

            'Dim porcentaje As Double = Pbuno.Value / 1000
            'LblPbuno.Text = "Vencimientos generados al: " & Math.Round(Pbuno.Value / 0.03, 2) & "%"
            'LblPbuno.Refresh()

            Dim consulta As String = " SELECT codigo_alumno, nombre_apellido_alumno, curso, arancel_importe, hermano_numero, campamento_importe, taller_importe, materiales_importe, adicional_importe, comedor_importe, descuento_beca, descuento FROM alumnos JOIN cursos On cursos.codigo_curso = alumnos.codigo_curso JOIN aranceles On aranceles.codigo_arancel = alumnos.codigo_arancel JOIN taller On taller.codigo_taller = alumnos.codigo_taller1 JOIN descuento_beca On descuento_beca.codigo_beca = alumnos.codigo_beca JOIN descuento_especial On descuento_especial.codigo_descuento_especial = alumnos.codigo_descuento WHERE alumnos.codigo_familia = '" & codFam & "' AND alumnos.estado = 'activo' ORDER BY alumnos.codigo_alumno"

            comando = New SqlCommand()
            comando.CommandText = consulta
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            adaptador = New SqlDataAdapter(comando)
            Dim dataSet As DataSet = New DataSet()
            adaptador.Fill(dataSet)

            For Each fila As DataRow In dataSet.Tables(0).Rows()

                codigoAlumno = Val(fila(0))
                arancel = Val(fila(3))
                totalArancel += Val(fila(3))
                hermanoNumero = fila(4)
                campamento = Val(fila(5))
                totalCampamento += Val(fila(5))
                taller = Val(fila(6))
                totalTaller += Val(fila(6))
                materiales = Val(fila(7))
                totalMateriales += Val(fila(7))
                adicional = Val(fila(8))
                totalAdicional += Val(fila(8))
                comedor = Val(fila(9))
                totalComedor += Val(fila(9))
                CalculaCuota()
                vencimentoAlumno = "INSERT INTO vencimiento_detallado (codigo_familia, codigo_alumno, cuota_alumno, materiales_alumno, talleres_alumno, campamento_alumno, adicional_alumno, comedor_alumno, fecha_vencimiento) VALUES(@codigo_familia, @codigo_alumno, @cuota_alumno, @materiales_alumno, @talleres_alumno, @campamento_alumno, @adicional_alumno, @comedor_alumno, @fecha_vencimiento) "
                comandoVencimientoAlumnos = New SqlCommand(vencimentoAlumno, conexion)

                comandoVencimientoAlumnos.Parameters.AddWithValue("@codigo_familia", codFam)
                comandoVencimientoAlumnos.Parameters.AddWithValue("@codigo_alumno", codigoAlumno)
                comandoVencimientoAlumnos.Parameters.AddWithValue("@cuota_alumno", cuota)
                comandoVencimientoAlumnos.Parameters.AddWithValue("@materiales_alumno", materiales)
                comandoVencimientoAlumnos.Parameters.AddWithValue("@talleres_alumno", taller)
                comandoVencimientoAlumnos.Parameters.AddWithValue("@Campamento_alumno", campamento)
                comandoVencimientoAlumnos.Parameters.AddWithValue("@Adicional_alumno", materiales)
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
                Dim vencimiento As String = "INSERT INTO detalle_vencimientos_escolares(codigo_familia, aranceles_v, materiales_v, talleres_v, campamento_v, adicional_jardin_v, comedor_v, fecha_vencimiento) VALUES(@codFam, @totalCuota, @totalMateriales, @totalTaller, @totalCampamento, @totalAdicional, @totalComedor, @fechaVencimiento)"

                comando2 = New SqlCommand(vencimiento, conexion)

                comando2.Parameters.AddWithValue("@codFam", codFam)
                comando2.Parameters.AddWithValue("@totalCuota", arancel)
                comando2.Parameters.AddWithValue("@totalMateriales", totalMateriales)
                comando2.Parameters.AddWithValue("@totalTaller", totalTaller)
                comando2.Parameters.AddWithValue("@totalCampamento", totalCampamento)
                comando2.Parameters.AddWithValue("@totalAdicional", totalMateriales)
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
            codFam += 1


            'Pbuno.Value = codFam - 1
        End While
        'MsgBox("Datos guardados")
    End Sub

    Private Sub ActualizaCredito(codFam)

        Dim credito As Decimal
        Dim codigo


        Dim maxCod As String = "SELECT MAX(codigo_detalle_pago) as codigo FROM detalle_pago_escolar WHERE codigo_familia = '" & codFam & "' "
        adaptador = New SqlDataAdapter(maxCod, conexion)
        Dim comandoMaxCod As New SqlCommand(maxCod, conexion)

        codigo = comandoMaxCod.ExecuteScalar()
        If comandoMaxCod.ExecuteNonQuery = 0 Then
            MsgBox("Error consultando código")
        End If

        If codigo Is Nothing Then

        Else
            Try
                Dim consultaCredito As String = "SELECT  credito FROM detalle_pago_escolar WHERE codigo_detalle_pago = '" & codigo & "' "
                Dim comando As New SqlCommand(consultaCredito, conexion)
                credito = comando.ExecuteScalar

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
            End Try

            Dim buscaCodigo As String = "SELECT MAX(codigo_pago_v) from detalle_vencimientos_escolares WHERE codigo_familia = '" & codFam & "' "
            Dim comandoBuscaCodigo As New SqlCommand(buscaCodigo, conexion)
            codigo = comandoBuscaCodigo.ExecuteScalar
            If comandoBuscaCodigo.ExecuteNonQuery = 0 Then
                MsgBox("Error buscando codigo")
            End If

            Dim actualizaCredito As String = "UPDATE detalle_vencimientos_escolares SET credito_v = " & credito & " WHERE codigo_familia = " & codFam & " AND codigo_pago_v = " & codigo & ""
            Dim comandoActualizaCredito As New SqlCommand(actualizaCredito, conexion)
            If comandoActualizaCredito.ExecuteNonQuery = 0 Then
                MsgBox("Error actualizando crédito")
            End If

        End If



    End Sub

    Private Sub CalculaCuota()

        'Descuento que corresponde según número de hermano

        If hermanoNumero <> 0 Then
            Dim descuentoPorHermano As String = "SELECT descuento_hermano FROM descuento_hermano where hermano_numero = '" & hermanoNumero & "' "
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

                Dim pagoNulo As String = "INSERT INTO detalle_pago_escolar (codigo_familia, aranceles, materiales, talleres, campamento, adicional_jardin, comedor, fecha_de_pago, pago_cumplido) VALUES(@codFam, @totalCuota, @totalMateriales, @totalTaller, @totalCampamento, @totalAdicional, @totalComedor, @fechaDePago, @pago_cumplido)"
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
End Class