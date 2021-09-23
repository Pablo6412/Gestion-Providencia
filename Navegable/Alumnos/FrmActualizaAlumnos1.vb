Imports System.Data.SqlClient


'Este formulario lee de las siguientes tablas:
'alumnos
'cursos
'cursos, aranceles 

'actualiza: alumnos
'           pago_familia




Public Class FrmActualizaAlumnos

    Dim datos As DataSet
    Dim datos2 As DataSet
    'Dim datos3 As DataSet
    Dim adaptador As SqlDataAdapter
    Dim FechaNacimiento As Date
    Dim FechaActual As Date
    'Dim codigo As Integer
    Dim cuota As Decimal
    Dim arancel As Decimal

    Private Sub FrmActualizaAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        Cargar()
        BuscaCurso()
    End Sub

    Private Sub Cargar()
        Dim cuenta As Integer
        TxtFecha.Text = DtpFechaActual.Value
        Dim cuentaAlumnos As String = "Select COUNT(codigo_alumno) FROM alumnos"
        Dim comando As New SqlCommand(cuentaAlumnos, conexion)
        cuenta = comando.ExecuteScalar
        If cuenta <> 0 Then

            'Carga combobox con alumnos 
            Try
                Dim alumno As String = "SELECT codigo_alumno, nombre_apellido_alumno, familias.codigo_familia, familias.codigo_beca FROM alumnos JOIN familias ON alumnos.codigo_familia = familias.codigo_familia WHERE alumnos.estado = 'activo' ORDER BY nombre_apellido_alumno
"
                adaptador = New SqlDataAdapter(alumno, conexion)

                datos = New DataSet
                adaptador.Fill(datos)
                datos.Tables.Add("alumnos")
                adaptador.Fill(datos.Tables("alumnos"))
                CbxCodigoBeca.DataSource = datos.Tables(0)
                CbxCodigoBeca.DisplayMember = "codigo_beca"
                CbxCodigoFamilia.DataSource = datos.Tables(0)
                CbxCodigoFamilia.DisplayMember = "codigo_familia"
                CbxAlumno.DataSource = datos.Tables(0)
                CbxAlumno.DisplayMember = "nombre_apellido_alumno"
                CbxCodigoAlumno.DataSource = datos.Tables(0)
                CbxCodigoAlumno.DisplayMember = "codigo_alumno"

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
            End Try
        Else
            MsgBox("No hay alumnos ingresados en la base de datos")
            TxtNombreApellido.Enabled = False
            TxtDni.Enabled = False
            TxtCurso.Enabled = False
            TxtObservaciones.Enabled = False
            TxtEdad.Enabled = False
            BtnActualiza.Enabled = False
        End If
    End Sub

    Private Sub CbxCodigoAlumno_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoAlumno.SelectedValueChanged

        Dim lista As Integer
        Dim Codigo As Integer = Val(CbxCodigoAlumno.Text)

        Try
            Dim concatena As String = "SELECT nombre_apellido_alumno, edad, fecha_nacimiento, dni, curso, fecha_ingreso, hermano_numero, arancel_importe, cuota, observaciones FROM alumnos JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso JOIN aranceles ON aranceles.codigo_arancel = alumnos.codigo_arancel WHERE alumnos.codigo_alumno= " & Codigo & " "
            adaptador = New SqlDataAdapter(concatena, conexion)
            Dim comando As New SqlCommand
            datos2 = New DataSet
            adaptador.Fill(datos2, "alumnos")
            lista = datos2.Tables("alumnos").Rows.Count

            If lista > 0 Then

                TxtNombreApellido.Text = datos2.Tables("alumnos").Rows(0).Item("nombre_apellido_alumno")
                TxtEdad.Text = datos2.Tables("alumnos").Rows(0).Item("edad")
                DtpFechaNacimiento.Text = datos2.Tables("alumnos").Rows(0).Item("fecha_nacimiento")
                TxtDni.Text = datos2.Tables("alumnos").Rows(0).Item("dni")
                CbxCurso.Text = datos2.Tables("alumnos").Rows(0).Item("curso")

                DtpFechaIngreso.Text = datos2.Tables("alumnos").Rows(0).Item("fecha_ingreso")
                TxtHermanoNumero.Text = datos2.Tables("alumnos").Rows(0).Item("hermano_numero")
                TxtArancel.Text = datos2.Tables("alumnos").Rows(0).Item("arancel_importe")
                TxtCuota.Text = Replace(datos2.Tables("alumnos").Rows(0).Item("cuota"), ".", ",")
                TxtObservaciones.Text = datos2.Tables("alumnos").Rows(0).Item("observaciones")
            End If
        Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
            End Try
        'End If

    End Sub


    Private Sub CodigoCurso()
        Dim lista As Integer
        If CbxCurso.Text <> "" Then
            Try
                Dim codigoCurso As String = "SELECT codigo_curso, codigo_arancel FROM cursos JOIN aranceles ON cursos.codigo_nivel = aranceles.codigo_nivel WHERE curso = '" & CbxCurso.Text & "'"
                adaptador = New SqlDataAdapter(codigoCurso, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "cursos")
                lista = datos.Tables("cursos").Rows.Count
                If lista > 0 Then
                    TxtCodigoCurso.Text = datos.Tables("cursos").Rows(0).Item("codigo_curso")
                    TxtCodigoArancel.Text = datos.Tables("cursos").Rows(0).Item("codigo_arancel")
                End If
            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try
        End If
    End Sub

    Private Sub BtnActualiza_Click(sender As Object, e As EventArgs) Handles BtnActualiza.Click

        abrir()

        Dim actualizaAlumno As String = "UPDATE alumnos SET  nombre_apellido_alumno ='" & Me.TxtNombreApellido.Text & "', fecha_nacimiento ='" & Me.DtpFechaNacimiento.Text & "', edad =" & Me.TxtEdad.Text & ", dni ='" & Me.TxtDni.Text & "', codigo_arancel = '" & Me.TxtCodigoArancel.Text & "', codigo_curso = '" & Me.TxtCodigoCurso.Text & "', fecha_ingreso= '" & Me.DtpFechaIngreso.Text & "', hermano_numero = " & Me.TxtHermanoNumero.Text & ", observaciones = '" & Me.TxtObservaciones.Text & "'  WHERE codigo_alumno ='" & Me.CbxCodigoAlumno.Text & "' "

        Dim comando As New SqlCommand(actualizaAlumno, conexion)
        comando.ExecuteNonQuery()

        If comando.ExecuteNonQuery() = 1 Then
            CalculaCuota(cuota)
            Dim actualizaCuota As String = "UPDATE cuotas SET  valor_cuota =" & Val(TxtCuota.Text) & "  WHERE codigo_alumno =" & Val(CbxCodigoAlumno.Text) & " "
            Dim comandoCuota As New SqlCommand(actualizaCuota, conexion)

            If comandoCuota.ExecuteNonQuery() = 1 Then

                MessageBox.Show("Datos actualizados")
                CbxCodigoAlumno.SelectedText = TxtNombreApellido.Text

                CbxAlumno.Focus()
            Else
                MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
            End If

        Else
                MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
        End If

        'Dim actualizaPagoFamilia As String = "UPDATE pago_familia SET alumno = '" & Me.TxtNombreApellido.Text & "' WHERE codigo_alumno = '" & Val(CbxCodigoAlumno.Text) & "' "
        'Dim comandoPagoFamilia As New SqlCommand(actualizaPagoFamilia, conexion)
        'comandoPagoFamilia.ExecuteNonQuery()

        Cargar()
    End Sub

    Public Sub Txtcuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCuota.KeyPress
        Dim ch As Char = e.KeyChar
        Dim tb As TextBox = sender

        If ch = Chr(46) And tb.Text.IndexOf(".") <> -1 Then
            e.Handled = True
        End If

        If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(46)) Then
            e.Handled = True
        End If

        If Char.IsDigit(ch) Or ch = "." Then

            'Insertar en una variable el caracter presionado, siempre y cuando sea un digito númerico.
            Dim result As String = tb.Text.Substring(0, tb.SelectionStart) _
                                   + e.KeyChar _
                                   + tb.Text.Substring(tb.SelectionStart + tb.SelectionLength)

            Dim parts() As String = result.Split(".") 'Declarar un arreglo y llenar
            'El primer elemento tendra la parte entera.
            'El segundo elemento contendra la parte decimal.   

            If parts.Length > 1 Then  'Verificar que el arreglo tenga mas de un elemento.
                If parts(1).Length > 2 Then 'Validar Cantidad de Decimales.
                    e.Handled = True
                End If
            End If

        End If

    End Sub

    Private Sub BuscaCurso()
        Dim CodigoCurso As Integer
        Try
            Dim curso As String = "SELECT codigo_curso, codigo_nivel, curso FROM cursos"
            adaptador = New SqlDataAdapter(curso, conexion)
            datos = New DataSet
            datos.Tables.Add("cursos")
            adaptador.Fill(datos.Tables("cursos"))

            Dim adapter As SqlDataAdapter = New SqlDataAdapter(curso, conexion)
            Dim dtDatos As DataTable = New DataTable
            adapter.Fill(dtDatos)
            CodigoCurso = dtDatos.Rows(0)("codigo_curso")

            'TxtCodigoCurso.Text = codigoCurso
            CbxCurso.DataSource = datos.Tables("cursos")
            CbxCurso.DisplayMember = "curso"
            Txtcurso.text = CbxCurso.Text
        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub

    Private Sub CalculaCuota(cuota)   'A partir del arancel se aplican los descuentos por hermano, beca, ayuda, etc y se calcula la cuota
        Dim tipoDescuento As Integer
        Dim descuentoHermano As Double
        Dim descuentoBeca As Decimal
        Dim descuento As Decimal
        Dim descuentoMonto As Decimal
        Dim cuotaSinDescuento As Decimal
        arancel = Val(TxtArancel.Text)
        'Descuento por hermano
        If TxtHermanoNumero.Text <> "" Then
            Dim descuentoPorHermano As String = "SELECT descuento_hermano FROM descuento_hermano where hermano_numero = '" & Val(TxtHermanoNumero.Text) & "' "
            adaptador = New SqlDataAdapter(descuentoPorHermano, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_hermano")
            adaptador.Fill(datos.Tables("descuento_hermano"))
            If Val(TxtHermanoNumero.Text) > 6 Then
                descuentoHermano = 0.5
            Else
                descuentoHermano = datos.Tables("descuento_hermano").Rows(0).Item("descuento_hermano")
            End If
        Else
        End If

        'Descuento beca
        'If Val(CbxCodigoBeca.Text) <> 0 Then
        Dim tipoBeca As String = "SELECT descuento_beca FROM descuento_beca WHERE codigo_beca = '" & Val(CbxCodigoBeca.Text) & "' "
        adaptador = New SqlDataAdapter(tipoBeca, conexion)

        Dim DatosBeca As DataTable = New DataTable
        adaptador.Fill(DatosBeca)


        If DatosBeca.Rows.Count > 0 Then
            descuentoBeca = DatosBeca.Rows(0)("descuento_beca")

        End If



        'datos = New DataSet
        'datos.Tables.Add("descuento_beca")
        'adaptador.Fill(datos.Tables("descuento_beca"))
        'descuentoBeca = datos.Tables("descuento_beca").Rows(0).Item("descuento_beca")
        'Else
        'End If

        'Descuento especial
        abrir()

        'MsgBox("" & Val(CbxCodigoFamilia.Text) & "")
        Dim descEspecial As String = "SELECT tipo_descuento, descuento, monto FROM descuento_especial WHERE codigo_familia = '" & Val(CbxCodigoFamilia.Text) & "' "
        adaptador = New SqlDataAdapter(descEspecial, conexion)

        Dim dtDatos As DataTable = New DataTable
        adaptador.Fill(dtDatos)

        If dtDatos.Rows.Count > 0 Then

            tipoDescuento = dtDatos.Rows(0)("tipo_descuento")
            descuento = dtDatos.Rows(0)("descuento")
            descuentoMonto = dtDatos.Rows(0)("monto")
            'TxtPrueba.Text = descuento


            If tipoDescuento = 1 Then
                cuota = arancel * descuentoHermano * descuento * descuentoBeca
                cuotaSinDescuento = arancel * descuentoHermano * descuentoBeca
                TxtCuota.Text = cuota
            Else
                cuota = descuentoMonto
                cuotaSinDescuento = arancel * descuentoHermano * descuentoBeca
            End If

            cuota = arancel * descuentoHermano * descuento * descuentoBeca
            TxtCuota.Text = cuota

            'MsgBox("descuento hermano: " & descuentoHermano & " descuento especial: " & descuentoEspecial & " descuento beca: " & descuentoBeca & "")
        End If
    End Sub

    Private Sub DtpFechaNacimiento_CloseUp(sender As Object, e As EventArgs) Handles DtpFechaNacimiento.CloseUp
        FechaNacimiento = DtpFechaNacimiento.Value
        FechaActual = DtpFechaActual.Value
        TxtEdad.Text = CalculaEdad(FechaNacimiento, FechaActual) - 1
    End Sub

    Private Sub TxtNombreApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreApellido.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDni.KeyPress
        SoloNumeros(e)
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxCurso_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCurso.SelectedValueChanged
        CodigoCurso()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnExtrasAlumno_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmInscripcionTalleres.Show()
    End Sub

    Private Sub RdbDatosAlumno_CheckedChanged(sender As Object, e As EventArgs) Handles RdbDatosAlumno.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RdbExtras_CheckedChanged(sender As Object, e As EventArgs) Handles RdbExtras.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub BtnSalirExtras_Click(sender As Object, e As EventArgs) Handles BtnSalirExtras.Click
        Me.Close()
    End Sub

End Class


