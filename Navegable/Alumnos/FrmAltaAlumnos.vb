
Imports System.Data.SqlClient
Public Class FrmAltaAlumnos
    Dim codAlumno As Integer
    Dim codigoArancel As Integer
    Dim CodigoNivel As Integer
    Dim CodigoCurso As Integer
    Dim arancel As Decimal
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Dim concatena As String
    Dim comando As New SqlCommand
    Dim consulta As String
    Dim Date1 As Date
    Dim Date2 As Date
    Dim Contador As Integer = 0
    Dim cuota As Decimal

    Public Sub FrmAltaAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()
        BuscaFamilia()
        DataGrid()
        BuscaCurso()             'Pone lista de cursos en  combobox para elegir el que corresponda
        NumeroHermanos()         'Calcula el número de hermano que se va a dar de alta
        CalculaCuota()           'Toma el arancel correspondiente al nivel y lo afecta por nº hermano, beca, etc. 
        TxtNombreAlumno.Focus()

    End Sub

    Private Sub BuscaFamilia()    'Carga combobox con familia (concatena apellidos paternos) y código_familia
        Try
            concatena = "select codigo_familia, codigo_beca, apellido_padre, nombre_padre, apellido_madre, nombre_madre, concat (apellido_padre,' - ', apellido_madre) as familia from gestion_providencia.familias where estado = 'activo'"
            adaptador = New SqlDataAdapter(concatena, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet
            datos.Tables.Add("gestion_providencia.familias")
            adaptador.Fill(datos.Tables("gestion_providencia.familias"))

            CbxCodigoBeca.DataSource = datos.Tables("gestion_providencia.familias")
            CbxCodigoBeca.DisplayMember = "codigo_beca"
            CbxFamilia.DataSource = datos.Tables("gestion_providencia.familias")
            CbxFamilia.DisplayMember = "familia"
            CbxCodigoFamilia.DataSource = datos.Tables("gestion_providencia.familias")
            CbxCodigoFamilia.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub

    Public Sub CbxCodigoFamilia_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoFamilia.SelectedValueChanged
        Dim Codigo As String = CbxCodigoFamilia.Text

        'Carga texbox con nombre y apellido de los padres
        Try
            consulta = "select codigo_familia, codigo_beca, apellido_padre, nombre_padre, apellido_madre, nombre_madre from gestion_providencia.familias where codigo_familia= '" & Val(CbxCodigoFamilia.Text) & "' "
            adaptador = New SqlDataAdapter(consulta, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "familias")

            TxtApellidoPadre.DataBindings.Clear()
            TxtApellidoPadre.DataBindings.Add(New Binding("text", datos, "familias.apellido_padre"))
            TxtApellidoMadre.DataBindings.Clear()
            TxtApellidoMadre.DataBindings.Add(New Binding("text", datos, "familias.apellido_madre"))
            TxtNombrePadre.DataBindings.Clear()
            TxtNombrePadre.DataBindings.Add(New Binding("text", datos, "familias.nombre_padre"))
            TxtNombreMadre.DataBindings.Clear()
            TxtNombreMadre.DataBindings.Add(New Binding("text", datos, "familias.nombre_madre"))
            TxtPrueba.DataBindings.Clear()
            TxtPrueba.DataBindings.Add(New Binding("text", datos, "familias.codigo_beca"))

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles 
        End Try

        DataGrid()           'Llena el dataGridView
        NumeroHermanos()     'Calcula el número de hermano y lo presenta en texbox
        CalculaCuota()       'Calcula el valor de la cuota y lo presenta en texbox
    End Sub

    Private Sub DataGrid()
        Try
            consulta = "Select nombre_apellido_alumno, dni, curso, arancel_importe, valor_cuota, hermano_numero, fecha_ingreso from gestion_providencia.alumnos JOIN cursos On cursos.codigo_curso = gestion_providencia.alumnos.codigo_curso JOIN cuotas On cuotas.codigo_alumno = gestion_providencia.alumnos.codigo_alumno join Aranceles On aranceles.codigo_arancel = gestion_providencia.alumnos.codigo_arancel where gestion_providencia.alumnos.codigo_familia= '" & Val(CbxCodigoFamilia.Text) & "' "

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
        cerrar()
    End Sub



    Private Sub BuscaCurso()   'Pone lista de cursos en  combobox para elegir el que corresponda
        Try
            Dim curso As String = "select codigo_curso, codigo_nivel, curso from cursos"
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

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub


    Public Sub NumeroHermanos()        'Calcula en número de hermano, en el colegio, del que se está por dar de alta
        Dim concatena As String
        Dim lista

        Try
            Dim codigo As String = CbxCodigoFamilia.Text
            concatena = "select count(*) as totalHermanos from gestion_providencia.alumnos  where codigo_familia like'" & codigo & "' "
            adaptador = New SqlDataAdapter(concatena, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet
            adaptador.Fill(datos, "gestion_providencia.alumnos")
            lista = datos.Tables("gestion_providencia.alumnos").Rows.Count

            Dim cantHermanos As Integer = datos.Tables("gestion_providencia.alumnos").Rows(0).Item("totalHermanos")
            Dim numeHermano As Integer = cantHermanos + 1
            TxtHermanoNumero.Text = numeHermano
        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles 
        End Try
    End Sub

    Private Sub CbxCurso_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCurso.SelectedValueChanged
        'Busca el arancel que le corresponde a un nivel y luego llama al procedimiento que calcula la cuota 

        Dim Cocurso As String = "SELECT codigo_curso, codigo_nivel, curso FROM cursos WHERE curso = '" & CbxCurso.Text & "'"
        adaptador = New SqlDataAdapter(Cocurso, conexion)
        Dim comando As New SqlCommand
        datos = New DataSet
        datos.Tables.Add("cursos")
        adaptador.Fill(datos.Tables("cursos"))
        If Contador <> 0 Then
            CodigoNivel = datos.Tables("cursos").Rows(0).Item("codigo_nivel")
            CodigoCurso = datos.Tables("cursos").Rows(0).Item("codigo_curso")


            Dim consulta As String = "SELECT codigo_arancel, arancel_importe from aranceles WHERE codigo_nivel = '" & CodigoNivel & "'"
            adaptador = New SqlDataAdapter(consulta, conexion)
            Dim comando1 As New SqlCommand
            datos = New DataSet
            datos.Tables.Add("aranceles")
            adaptador.Fill(datos.Tables("aranceles"))

            TxtArancel.Text = datos.Tables("aranceles").Rows(0).Item("arancel_importe")
            codigoArancel = datos.Tables("aranceles").Rows(0).Item("codigo_arancel")
            arancel = TxtArancel.Text
        Else
        End If
        Contador += 1
        CalculaCuota()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If CbxCodigoFamilia.Text = "" Then
            MsgBox("debe elegir un código de familia o un apellido")
            CbxCodigoFamilia.Focus()
        Else
            abrir()
            'Verifica datos sin completar
            If TxtNombreAlumno.Text = "" Or TxtDni.Text = "" Or TxtEdad.Text = "" Or DtpFechaIngreso.Text = "" Or DtpFechaNacimiento.Text = "" Then
                MessageBox.Show("Debe llenar todos los campor, solo el campo observaciones puede quedar vacío", "Campos sin completar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Dim opcion As DialogResult = MessageBox.Show("¿Realmente quiere dar de alta al alumno " & TxtNombreAlumno.Text & " en " & CbxCurso.Text & "?", "¡Registro a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

                If (opcion = Windows.Forms.DialogResult.Yes) Then

                    Dim cadena As String = "INSERT INTO gestion_providencia.alumnos(codigo_familia, codigo_curso, codigo_arancel, nombre_apellido_alumno, edad, fecha_nacimiento, dni,  fecha_ingreso, hermano_numero,  cuota, observaciones) 
                                       VALUES(@codigo_familia, @codigo_curso,  @codigo_arancel, @nombre_apellido_alumno, @edad, @fecha_nacimiento, @dni, @fecha_ingreso, @hermano_numero,  @cuota, @observaciones)"
                    comando = New SqlCommand(cadena, conexion)

                    comando.Parameters.AddWithValue("@codigo_familia", CbxCodigoFamilia.Text)
                    comando.Parameters.AddWithValue("@codigo_curso", CodigoCurso)
                    comando.Parameters.AddWithValue("@codigo_arancel", codigoArancel)
                    comando.Parameters.AddWithValue("@nombre_apellido_alumno", TxtNombreAlumno.Text)
                    comando.Parameters.AddWithValue("@edad", TxtEdad.Text)
                    comando.Parameters.AddWithValue("@fecha_nacimiento", DtpFechaNacimiento.Value)
                    comando.Parameters.AddWithValue("@dni", TxtDni.Text)
                    comando.Parameters.AddWithValue("@fecha_ingreso", DtpFechaIngreso.Value)
                    comando.Parameters.AddWithValue("@hermano_numero", TxtHermanoNumero.Text)
                    comando.Parameters.AddWithValue("@cuota", Val(TxtCuota.Text))
                    comando.Parameters.AddWithValue("@observaciones", TxtObservaciones.Text)

                    If comando.ExecuteNonQuery() = 1 Then

                    Else
                        MsgBox("Error al intentar guardar los datos")
                    End If

                    Dim codigoAlumno As String = "SELECT codigo_alumno from gestion_providencia.alumnos where nombre_apellido_alumno = '" & TxtNombreAlumno.Text & "' "
                    adaptador = New SqlDataAdapter(codigoAlumno, conexion)
                    datos = New DataSet
                    datos.Tables.Add("gestion_providencia.alumnos")
                    adaptador.Fill(datos.Tables("gestion_providencia.alumnos"))

                    codAlumno = datos.Tables("gestion_providencia.alumnos").Rows(0).Item("codigo_alumno")

                    TxtNombreAlumno.Clear()
                    TxtEdad.Clear()
                    TxtDni.Clear()
                    TxtHermanoNumero.Clear()
                    TxtArancel.Clear()
                    TxtObservaciones.Clear()
                    NumeroHermanos()
                    TxtNombreAlumno.Focus()
                    ' TxtHermanoNumero.Clear()
                    TxtCuota.Clear()
                    CbxCodigoFamilia.Select()
                    GuardaCuota()

                End If
            End If

            DataGrid()
            BuscaCurso()
            NumeroHermanos()
        End If
    End Sub

    Private Sub CalculaCuota()   'A partir del arancel se aplican los descuentos por hermano, beca, ayuda, etc y se calcula la cuota
        Dim descuentoHermano As Double
        Dim descuentoBeca As Decimal
        Dim descuentoEspecial As Decimal
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
        If CbxCodigoBeca.Text <> "" Then
            Dim tipoBeca As String = "SELECT descuento_beca FROM descuento_beca where codigo_beca = '" & CbxCodigoBeca.Text & "' "
            adaptador = New SqlDataAdapter(tipoBeca, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_beca")
            adaptador.Fill(datos.Tables("descuento_beca"))
            descuentoBeca = datos.Tables("descuento_beca").Rows(0).Item("descuento_beca")

        Else
        End If
        Dim filasTabla As Integer
        abrir()
        Dim sql As String = "SELECT COUNT(*) " &
                           "FROM descuento_especial " &
                           "WHERE codigo_familia ='" & Val(CbxCodigoFamilia.Text) & "'"

        Dim comando4 As New SqlCommand(sql, conexion)
        filasTabla = comando4.ExecuteScalar

        If filasTabla <> 0 Then

            Dim descEspecial As String = "SELECT descuento FROM descuento_especial WHERE codigo_familia = '" & CbxCodigoFamilia.Text & "' "
            adaptador = New SqlDataAdapter(descEspecial, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_especial")
            adaptador.Fill(datos.Tables("descuento_especial"))

            descuentoEspecial = datos.Tables("descuento_especial").Rows(0).Item("descuento")
            TxtPrueba.Text = descuentoEspecial

        Else
            descuentoEspecial = 1
            TxtPrueba.Text = descuentoEspecial
        End If

        cuota = arancel * descuentoHermano * descuentoEspecial * descuentoBeca
        TxtCuota.Text = cuota
    End Sub

    Private Sub GuardaCuota()        'Después de calculada la cuota guarda el valor en tabla cuotas y creo que al pedo
        'Hay que corregirlo. 
        Dim cadena As String = "INSERT INTO cuotas(codigo_alumno, codigo_familia, valor_cuota) 
                                       VALUES(@codigo_alumno, @codigo_familia, @valor_cuota)"
        comando = New SqlCommand(cadena, conexion)

        comando.Parameters.AddWithValue("@codigo_alumno", codAlumno)
        comando.Parameters.AddWithValue("@codigo_familia", Val(CbxCodigoFamilia.Text))
        comando.Parameters.AddWithValue("@valor_cuota", cuota)
        If comando.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Datos guardados")

        Else
            MsgBox("No grabó nada")
        End If
    End Sub

    Public Sub DtpFechaNacimiento_CloseUp(sender As Object, e As EventArgs) Handles DtpFechaNacimiento.CloseUp
        Date1 = DtpFechaNacimiento.Value
        Date2 = DtpFechaActual.Value
        TxtEdad.Text = CalculaEdad(Date1, Date2) - 1
    End Sub

    Private Sub BtnCargarHermano_Click(sender As Object, e As EventArgs)
        BtnGuardar.Enabled = True
        TxtNombreAlumno.Focus()
    End Sub

    Public Sub TxtNombreAlumno_Click(sender As Object, e As EventArgs) Handles TxtNombreAlumno.Click
        NumeroHermanos()
    End Sub

    Private Sub TxtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDni.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtEdad.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtArancel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtArancel.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtCuota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCuota.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtNombreAlumno_CursorChanged(sender As Object, e As EventArgs) Handles TxtNombreAlumno.CursorChanged
        NumeroHermanos()
    End Sub

    Private Sub CbxCodigoFamilia_Leave(sender As Object, e As EventArgs) Handles CbxCodigoFamilia.Leave
        NumeroHermanos()
    End Sub

    Private Sub TxtNombreAlumno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreAlumno.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


End Class