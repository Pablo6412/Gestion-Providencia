Imports System.Data.SqlClient



'Este formulario lee las siguientes tablas: taller, alumnos, taller_alumno, 

'Update:  Alumnos, taller_alumnos



Public Class FrmInscripcionTalleres

    Dim datos As DataSet
    Dim datosValor As DataSet
    Dim adaptador As SqlDataAdapter
    Dim adaptadorValor As SqlDataAdapter
    Dim taller1 As Integer
    Dim taller2 As Integer
    Dim taller3 As Integer
    Dim cualquierTaller As Integer
    'Dim codigoFamilia As Integer
    Private Sub FrmInscripcionTalleres_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()
        CargaAlumnos()

        Dim listaV As Byte
        Dim ValorTaller As String = "SELECT taller_importe FROM taller"
        adaptadorValor = New SqlDataAdapter(ValorTaller, conexion)
        datosValor = New DataSet
        adaptadorValor.Fill(datosValor, "taller")
        listaV = datosValor.Tables("taller").Rows.Count
        LblFutbol.Text = "$ " & datosValor.Tables("taller").Rows(1).Item("taller_importe")
        LblMusica.Text = "$ " & datosValor.Tables("taller").Rows(2).Item("taller_importe")
        LblRugby.Text = "$ " & datosValor.Tables("taller").Rows(3).Item("taller_importe")
        LblHockey.Text = "$ " & datosValor.Tables("taller").Rows(4).Item("taller_importe")
        LblSinAsignarIVT.Text = "$ " & datosValor.Tables("taller").Rows(5).Item("taller_importe")
        LblSinAsignarIIVT.Text = "$ " & datosValor.Tables("taller").Rows(6).Item("taller_importe")
        LblSinAsignarIIIVT.Text = "$ " & datosValor.Tables("taller").Rows(7).Item("taller_importe")
        LblSinAsignarIVVT.Text = "$ " & datosValor.Tables("taller").Rows(8).Item("taller_importe")

        Dim lista As Byte
        Dim listaTalleres As String = "SELECT taller_nombre FROM taller"
        adaptador = New SqlDataAdapter(listaTalleres, conexion)

        datos = New DataSet

        adaptador.Fill(datos, "taller")
        lista = datos.Tables("taller").Rows.Count

        RdbFutbol1.Text = datos.Tables("taller").Rows(1).Item("taller_nombre")
        RdbFutbol2.Text = datos.Tables("taller").Rows(1).Item("taller_nombre")
        RdbFutbol3.Text = datos.Tables("taller").Rows(1).Item("taller_nombre")
        Label1.Text = datos.Tables("taller").Rows(1).Item("taller_nombre")

        RdbMusica1.Text = datos.Tables("taller").Rows(2).Item("taller_nombre")
        RdbMusica2.Text = datos.Tables("taller").Rows(2).Item("taller_nombre")
        RdbMusica3.Text = datos.Tables("taller").Rows(2).Item("taller_nombre")
        Label2.Text = datos.Tables("taller").Rows(2).Item("taller_nombre")

        RdbRugby1.Text = datos.Tables("taller").Rows(3).Item("taller_nombre")
        RdbRugby2.Text = datos.Tables("taller").Rows(3).Item("taller_nombre")
        RdbRugby3.Text = datos.Tables("taller").Rows(3).Item("taller_nombre")
        Label3.Text = datos.Tables("taller").Rows(3).Item("taller_nombre")

        RdbHockey1.Text = datos.Tables("taller").Rows(4).Item("taller_nombre")
        RdbHockey2.Text = datos.Tables("taller").Rows(4).Item("taller_nombre")
        RdbHockey3.Text = datos.Tables("taller").Rows(4).Item("taller_nombre")
        Label4.Text = datos.Tables("taller").Rows(4).Item("taller_nombre")

        RdbSinAsignar1.Text = datos.Tables("taller").Rows(5).Item("taller_nombre")
        RdbSinAsignar11.Text = datos.Tables("taller").Rows(5).Item("taller_nombre")
        RdbSinAsignar111.Text = datos.Tables("taller").Rows(5).Item("taller_nombre")
        Label5.Text = datos.Tables("taller").Rows(5).Item("taller_nombre")

        RdbSinAsignar2.Text = datos.Tables("taller").Rows(6).Item("taller_nombre")
        RdbSinAsignar22.Text = datos.Tables("taller").Rows(6).Item("taller_nombre")
        RdbSinAsignar222.Text = datos.Tables("taller").Rows(6).Item("taller_nombre")
        Label6.Text = datos.Tables("taller").Rows(6).Item("taller_nombre")

        RdbSinAsignar3.Text = datos.Tables("taller").Rows(7).Item("taller_nombre")
        RdbSinAsignar33.Text = datos.Tables("taller").Rows(7).Item("taller_nombre")
        RdbSinAsignar333.Text = datos.Tables("taller").Rows(7).Item("taller_nombre")
        Label7.Text = datos.Tables("taller").Rows(7).Item("taller_nombre")

        RdbSinAsignar4.Text = datos.Tables("taller").Rows(8).Item("taller_nombre")
        RdbSinAsignar44.Text = datos.Tables("taller").Rows(8).Item("taller_nombre")
        RdbSinAsignar444.Text = datos.Tables("taller").Rows(8).Item("taller_nombre")
        Label8.Text = datos.Tables("taller").Rows(8).Item("taller_nombre")

        If RdbSinAsignar1.Text = "Sin asignar" Then
            RdbSinAsignar1.Hide()
        End If
        If RdbSinAsignar11.Text = "Sin asignar" Then
            RdbSinAsignar11.Hide()
        End If
        If RdbSinAsignar111.Text = "Sin asignar" Then
            RdbSinAsignar111.Hide()
        End If
        If RdbSinAsignar2.Text = "Sin asignar" Then
            RdbSinAsignar2.Hide()
        End If
        If RdbSinAsignar22.Text = "Sin asignar" Then
            RdbSinAsignar22.Hide()
        End If
        If RdbSinAsignar222.Text = "Sin asignar" Then
            RdbSinAsignar222.Hide()
        End If
        If RdbSinAsignar3.Text = "Sin asignar" Then
            RdbSinAsignar3.Hide()
        End If
        If RdbSinAsignar33.Text = "Sin asignar" Then
            RdbSinAsignar33.Hide()
        End If
        If RdbSinAsignar333.Text = "Sin asignar" Then
            RdbSinAsignar333.Hide()
        End If
        If RdbSinAsignar4.Text = "Sin asignar" Then
            RdbSinAsignar4.Hide()
        End If
        If RdbSinAsignar44.Text = "Sin asignar" Then
            RdbSinAsignar44.Hide()
        End If
        If RdbSinAsignar444.Text = "Sin asignar" Then
            RdbSinAsignar444.Hide()
        End If

        If Label5.Text = "Sin asignar" Then
            Label5.Hide()
            LblSinAsignarIVT.Hide()
        End If
        If Label6.Text = "Sin asignar" Then
            Label6.Hide()
            LblSinAsignarIIVT.Hide()
        End If
        If Label7.Text = "Sin asignar" Then
            Label7.Hide()
            LblSinAsignarIIIVT.Hide()
        End If
        If Label8.Text = "Sin asignar" Then
            Label8.Hide()
            LblSinAsignarIVVT.Hide()
        End If

    End Sub

    Private Sub MuestraTalleres()
        'Dim recorreTaller As Integer

        Dim listaT As Byte
        Dim tallerAlumno As String = "SELECT codigo_taller1, codigo_taller2, codigo_taller3 FROM alumnos WHERE codigo_alumno = '" & Val(CbxCodigoAlumno.Text) & "' AND estado = 'activo'"
        Dim adaptadorTallerAlumno As New SqlDataAdapter(tallerAlumno, conexion)
        Dim datosTaller As New DataSet
        adaptadorTallerAlumno.Fill(datosTaller, "alumnos")
        listaT = datosTaller.Tables("alumnos").Rows.Count


        If listaT > 0 Then
            taller1 = datosTaller.Tables("alumnos").Rows(0).Item("codigo_taller1")
            taller2 = datosTaller.Tables("alumnos").Rows(0).Item("codigo_taller2")
            taller3 = datosTaller.Tables("alumnos").Rows(0).Item("codigo_taller3")

            If taller1 = 1 Then
                RdbNinguno1.Checked = True
            ElseIf taller1 = 2 Then
                RdbFutbol1.Checked = True
            ElseIf taller1 = 3 Then
                RdbMusica1.Checked = True
            ElseIf taller1 = 4 Then
                RdbRugby1.Checked = True
            ElseIf taller1 = 5 Then
                RdbHockey1.Checked = True
            ElseIf taller1 = 6 Then
                RdbSinAsignar1.Checked = True
            ElseIf taller1 = 7 Then
                RdbSinAsignar2.Checked = True
            ElseIf taller1 = 8 Then
                RdbSinAsignar3.Checked = True
            ElseIf taller1 = 9 Then
                RdbSinAsignar4.Checked = True
            End If

            If taller2 = 1 Then
                RdbNinguno2.Checked = True
            ElseIf taller2 = 2 Then
                RdbFutbol2.Checked = True
            ElseIf taller2 = 3 Then
                RdbMusica2.Checked = True
            ElseIf taller2 = 4 Then
                RdbRugby2.Checked = True
            ElseIf taller2 = 5 Then
                RdbHockey2.Checked = True
            ElseIf taller2 = 6 Then
                RdbSinAsignar11.Checked = True
            ElseIf taller2 = 7 Then
                RdbSinAsignar22.Checked = True
            ElseIf taller2 = 8 Then
                RdbSinAsignar33.Checked = True
            ElseIf taller2 = 9 Then
                RdbSinAsignar44.Checked = True
            End If

            If taller3 = 1 Then
                RdbNinguno3.Checked = True
            ElseIf taller3 = 2 Then
                RdbFutbol3.Checked = True
            ElseIf taller3 = 3 Then
                RdbMusica3.Checked = True
            ElseIf taller3 = 4 Then
                RdbRugby3.Checked = True
            ElseIf taller3 = 5 Then
                RdbHockey3.Checked = True
            ElseIf taller3 = 6 Then
                RdbSinAsignar111.Checked = True
            ElseIf taller3 = 7 Then
                RdbSinAsignar222.Checked = True
            ElseIf taller3 = 8 Then
                RdbSinAsignar333.Checked = True
            ElseIf taller3 = 9 Then
                RdbSinAsignar444.Checked = True
            End If
        End If
    End Sub


    Private Sub CargaAlumnos()
        'Si no hay alumnos registrados sale por el else
        Dim cuenta As Integer
        Dim consulta As String = "SELECT COUNT(codigo_alumno) FROM alumnos"
        Dim comando As New SqlCommand(consulta, conexion)
        cuenta = comando.ExecuteScalar

        If cuenta <> 0 Then
            Try
                Dim alumno As String = "SELECT codigo_alumno, codigo_familia, nombre_apellido_alumno FROM alumnos WHERE estado = 'activo' ORDER BY nombre_apellido_alumno"
                adaptador = New SqlDataAdapter(alumno, conexion)
                datos = New DataSet
                adaptador.Fill(datos)
                datos.Tables.Add("alumnos")
                adaptador.Fill(datos.Tables("alumnos"))

                Me.CbxAlumno.DataSource = datos.Tables(0)
                Me.CbxAlumno.DisplayMember = "nombre_apellido_alumno"

                Me.CbxCodigoAlumno.DataSource = datos.Tables(0)
                Me.CbxCodigoAlumno.DisplayMember = "codigo_alumno"

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try
        Else
            MsgBox("No hay alumnos ingresados en la base de datos")
        End If
        MuestraTalleres()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim codigoGrupoTaller As Integer
        Dim taller As Integer = 0
        Dim importeTaller1, importeTaller2, importeTaller3 As Decimal

        Dim alumno As String = "SELECT MIN(codigo_grupo_taller) FROM taller_alumno WHERE codigo_alumno = '" & Val(CbxCodigoAlumno.Text) & "' "
        Dim comandoAlumno As New SqlCommand(alumno, conexion)
        codigoGrupoTaller = comandoAlumno.ExecuteScalar

        'taller = 0
        If RdbNinguno1.Checked Then
            taller = 1
        ElseIf RdbFutbol1.Checked Then
            taller = 2
        ElseIf RdbHockey1.Checked Then
            taller = 5
        ElseIf RdbMusica1.Checked Then
            taller = 3
        ElseIf RdbRugby1.Checked Then
            taller = 4
        ElseIf RdbSinAsignar1.Checked Then
            taller = 6
        ElseIf RdbSinAsignar2.Checked Then
            taller = 7
        ElseIf RdbSinAsignar3.Checked Then
            taller = 8
        ElseIf RdbSinAsignar4.Checked Then
            taller = 9
        End If

        If taller = 0 Then
            MsgBox("Debe seleccionar una opción para taller1")
        Else

            If (RdbFutbol1.Checked And RdbFutbol2.Checked) Or (RdbFutbol2.Checked And RdbFutbol3.Checked) Or (RdbFutbol1.Checked And RdbFutbol3.Checked) Or
                (RdbHockey1.Checked And RdbHockey2.Checked) Or (RdbHockey2.Checked And RdbHockey3.Checked) Or (RdbHockey1.Checked And RdbHockey3.Checked) Or
                (RdbMusica1.Checked And RdbMusica2.Checked) Or (RdbMusica2.Checked And RdbMusica3.Checked) Or (RdbMusica1.Checked And RdbMusica3.Checked) Or
                (RdbRugby1.Checked And RdbRugby2.Checked) Or (RdbRugby2.Checked And RdbRugby3.Checked) Or (RdbRugby1.Checked And RdbRugby3.Checked) Then
                MsgBox("No se puede elegir dos o mas talleres igules, elija otras opciones")
            Else


                Dim importe1 As String = "SELECT taller_importe FROM taller WHERE codigo_taller = " & taller & " "
                Dim comandoImporte1 As New SqlCommand(importe1, conexion)
                importeTaller1 = comandoImporte1.ExecuteScalar

                Dim tallerA As String = "UPDATE alumnos SET codigo_taller1 = " & taller & " WHERE codigo_alumno = " & Val(CbxCodigoAlumno.Text) & " "
                Dim comando As New SqlCommand(tallerA, conexion)
                comando.ExecuteNonQuery()
                If comando.ExecuteNonQuery() = 0 Then
                    MsgBox("¡Error! Datos no actualizados para taller1. Reinicie el programa e intente nuevamente")
                End If


                tallerA = "UPDATE taller_alumno SET codigo_taller = " & taller & ", importe_taller = " & Val(importeTaller1) & " WHERE codigo_grupo_taller = " & codigoGrupoTaller & " "
                Dim comandoTaller1 As New SqlCommand(tallerA, conexion)
                comandoTaller1.ExecuteNonQuery()
                If comandoTaller1.ExecuteNonQuery() = 0 Then
                    MsgBox("¡Error! Datos no actualizados para taller1. Reinicie el programa e intente nuevamente")
                End If
                cualquierTaller = taller1
                AltaBajaTaller(taller, cualquierTaller)

                taller = 0
                If RdbNinguno2.Checked Then
                    taller = 1
                ElseIf RdbFutbol2.Checked Then
                    taller = 2
                ElseIf RdbHockey2.Checked Then
                    taller = 5
                ElseIf RdbMusica2.Checked Then
                    taller = 3
                ElseIf RdbRugby2.Checked Then
                    taller = 4
                ElseIf RdbSinAsignar11.Checked Then
                    taller = 6
                ElseIf RdbSinAsignar22.Checked Then
                    taller = 7
                ElseIf RdbSinAsignar33.Checked Then
                    taller = 8
                ElseIf RdbSinAsignar44.Checked Then
                    taller = 9
                End If

                If taller = 0 Then
                    MsgBox("Debe seleccionar una opción para taller2")
                Else

                    Dim importe2 As String = "SELECT taller_importe FROM taller WHERE codigo_taller = " & taller & " "
                    Dim comandoImporte2 As New SqlCommand(importe2, conexion)
                    importeTaller2 = comandoImporte2.ExecuteScalar

                    Dim tallerB As String = "UPDATE alumnos SET codigo_taller2 = " & taller & " WHERE codigo_alumno = " & Val(CbxCodigoAlumno.Text) & " "
                    Dim comando1 As New SqlCommand(tallerB, conexion)
                    comando1.ExecuteNonQuery()

                    If comando1.ExecuteNonQuery() = 0 Then
                        MsgBox("¡Error! Datos no actualizados para taller2. Reinicie el programa e intente nuevamente")
                    End If

                    tallerB = "UPDATE taller_alumno SET codigo_taller = " & taller & ", importe_taller = " & Val(importeTaller2) & " WHERE codigo_grupo_taller = " & (codigoGrupoTaller + 1) & " "
                    Dim comandoTaller2 As New SqlCommand(tallerB, conexion)
                    comandoTaller2.ExecuteNonQuery()
                    If comandoTaller2.ExecuteNonQuery() = 0 Then
                        MsgBox("¡Error! Datos no actualizados para taller1. Reinicie el programa e intente nuevamente")
                    End If
                    cualquierTaller = taller2
                    AltaBajaTaller(taller, cualquierTaller)

                    taller = 0
                    If RdbNinguno3.Checked Then
                        taller = 1
                    ElseIf RdbFutbol3.Checked Then
                        taller = 2
                    ElseIf RdbHockey3.Checked Then
                        taller = 5
                    ElseIf RdbMusica3.Checked Then
                        taller = 3
                    ElseIf RdbRugby3.Checked Then
                        taller = 4
                    ElseIf RdbSinAsignar111.Checked Then
                        taller = 6
                    ElseIf RdbSinAsignar222.Checked Then
                        taller = 7
                    ElseIf RdbSinAsignar333.Checked Then
                        taller = 8
                    ElseIf RdbSinAsignar444.Checked Then
                        taller = 9
                    End If

                    If taller = 0 Then
                        MsgBox("Debe elejir una opción para taller3")
                    Else

                        Dim importe3 As String = "SELECT taller_importe FROM taller WHERE codigo_taller = " & taller & " "
                        Dim comandoImporte3 As New SqlCommand(importe3, conexion)
                        importeTaller3 = comandoImporte3.ExecuteScalar

                        Dim tallerC As String = "UPDATE alumnos SET codigo_taller3 = " & taller & " WHERE codigo_alumno = " & Val(CbxCodigoAlumno.Text) & ""
                        Dim comando3 As New SqlCommand(tallerC, conexion)
                        comando3.ExecuteNonQuery()

                        If comando3.ExecuteNonQuery() = 1 Then

                            tallerC = "UPDATE taller_alumno SET codigo_taller = " & taller & ", importe_taller = " & Val(importeTaller3) & " WHERE codigo_grupo_taller = " & (codigoGrupoTaller + 2) & " "
                            Dim comandoTaller3 As New SqlCommand(tallerC, conexion)
                            comandoTaller3.ExecuteNonQuery()
                            If comandoTaller3.ExecuteNonQuery() = 0 Then
                                MsgBox("¡Error! Datos no actualizados para taller1. Reinicie el programa e intente nuevamente")
                            End If
                            cualquierTaller = taller3
                            AltaBajaTaller(taller, cualquierTaller)
                            MessageBox.Show("Datos actualizados")
                            BtnGuardar.Enabled = False
                        Else
                            MsgBox("¡Error! Datos no actualizados para taller3. Reinicie el programa e intente nuevamente")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CbxCodigoAlumno_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoAlumno.SelectedValueChanged
        'RdbNinguno1.Checked = False
        'RdbFutbol1.Checked = False
        'RdbHockey1.Checked = False
        'RdbMusica1.Checked = False
        'RdbRugby1.Checked = False
        'RdbSinAsignar1.Checked = False
        'RdbSinAsignar2.Checked = False
        'RdbSinAsignar3.Checked = False
        'RdbSinAsignar4.Checked = False
        'RdbNinguno2.Checked = False
        'RdbFutbol2.Checked = False
        'RdbHockey2.Checked = False
        'RdbMusica2.Checked = False
        'RdbRugby2.Checked = False
        'RdbSinAsignar11.Checked = False
        'RdbSinAsignar22.Checked = False
        'RdbSinAsignar33.Checked = False
        'RdbSinAsignar44.Checked = False
        'RdbNinguno3.Checked = False
        'RdbFutbol3.Checked = False
        'RdbHockey3.Checked = False
        'RdbMusica3.Checked = False
        'RdbRugby3.Checked = False
        'RdbSinAsignar111.Checked = False
        'RdbSinAsignar222.Checked = False
        'RdbSinAsignar333.Checked = False

        'RdbSinAsignar444.Checked = False
        MuestraTalleres()
    End Sub

    Public Sub AltaBajaTaller(taller, cualquierTaller)


        If taller <> cualquierTaller Then
            If cualquierTaller <> 1 Then
                Dim fechaBaja As String = "INSERT INTO alta_baja_taller(codigo_familia, codigo_alumno, codigo_taller, fecha_baja) VALUES(@codigo_familia, @codigo_alumno, @codigo_taller, @fecha_baja)"
                Dim comandoFechaB As New SqlCommand(fechaBaja, conexion)

                comandoFechaB.Parameters.AddWithValue("@codigo_familia", CbxCodigoFamilia.Text)
                comandoFechaB.Parameters.AddWithValue("@codigo_alumno", CbxCodigoAlumno.Text)
                comandoFechaB.Parameters.AddWithValue("@codigo_taller", cualquierTaller)
                comandoFechaB.Parameters.AddWithValue("@fecha_baja", DtpBaja.Value)

                comandoFechaB.ExecuteNonQuery()
            End If
            Dim fechaAlta As String = "INSERT INTO alta_baja_taller(codigo_familia, codigo_alumno, codigo_taller, fecha_alta) VALUES(@codigo_familia, @codigo_alumno, @codigo_taller, @fecha_alta)"
            Dim comandoFechaA As New SqlCommand(fechaAlta, conexion)

            comandoFechaA.Parameters.AddWithValue("@codigo_familia", CbxCodigoFamilia.Text)
            comandoFechaA.Parameters.AddWithValue("@codigo_alumno", CbxCodigoAlumno.Text)
            comandoFechaA.Parameters.AddWithValue("@codigo_taller", taller)
            comandoFechaA.Parameters.AddWithValue("@fecha_alta", DtpAlta.Value)

            comandoFechaA.ExecuteNonQuery()

        End If
    End Sub
    Private Sub BtnSalirExtras_Click(sender As Object, e As EventArgs) Handles BtnSalirExtras.Click
        Me.Close()
    End Sub
End Class