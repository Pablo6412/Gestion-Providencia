Imports System.Data.SqlClient


Public Class FrmCampamentos
    Dim codigoCampamento As Integer
    Dim codigoAño As Integer
    Private Sub FrmCampamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()
        abrir()

        Dim nivel As String = "SELECT codigo_nivel, nivel FROM niveles"
        Dim adaptadorNivel As New SqlDataAdapter(nivel, conexion)
        Dim datosNivel As New DataSet
        datosNivel.Tables.Add("niveles")
        adaptadorNivel.Fill(datosNivel.Tables("niveles"))

        CbxNivel.DataSource = datosNivel.Tables("niveles")
        CbxNivel.DisplayMember = "nivel"
        CbxCodigonivel.DataSource = datosNivel.Tables("niveles")
        CbxCodigonivel.DisplayMember = "codigo_nivel"


        Dim año As String = "SELECT codigo_año, año  FROM cursos group by año, codigo_año order by codigo_año"
        Dim adaptadorAño As New SqlDataAdapter(año, conexion)
        Dim datosAño As New DataSet
        datosAño.Tables.Add("cursos")
        adaptadorAño.Fill(datosAño.Tables("cursos"))


        CbxAño.DataSource = datosAño.Tables("cursos")
        CbxAño.DisplayMember = "año"
        CbxCodigoAño.DataSource = datosAño.Tables("cursos")
        CbxCodigoAño.DisplayMember = "codigo_año"

        BtnGuardar.Enabled = False


    End Sub


    Private Sub CbxCodigonivel_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigonivel.SelectedValueChanged

        Dim año As String = "SELECT  codigo_año,  año FROM cursos WHERE codigo_nivel = '" & Val(CbxCodigonivel.Text) & "' GROUP BY año, codigo_año "
        Dim adaptadorAño As New SqlDataAdapter(año, conexion)
        Dim tabla As New DataTable
        adaptadorAño.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            TxtCodigoAño.Text = tabla.Rows(0)("codigo_año")

            Dim datosCurso As New DataSet
            datosCurso.Tables.Add("cursos")
            adaptadorAño.Fill(datosCurso.Tables("cursos"))
            CbxCurso.DataSource = datosCurso.Tables("cursos")
            CbxCurso.DisplayMember = "año"

        End If



    End Sub

    Private Sub CbxCurso_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCurso.SelectedValueChanged

        Dim codAño As String

        Dim año As String = "SELECT   codigo_año FROM cursos WHERE año = '" & (CbxCurso.Text) & "' GROUP BY codigo_año"
        Dim adaptadorAño As New SqlDataAdapter(año, conexion)
        Dim tabla As New DataTable
        adaptadorAño.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            codAño = tabla.Rows(0)("codigo_año")
            TxtCodigoAño.Text = codAño
        End If

        Dim campamentosExistentes As String = "SELECT lugar, valor, duracion, fecha FROM campamento WHERE codigo_año = '" & Val(TxtCodigoAño.Text) & "' "
        Dim adaptadorExiste As New SqlDataAdapter(campamentosExistentes, conexion)
        Dim tablaExiste As New DataTable
        adaptadorExiste.Fill(tablaExiste)

        If tablaExiste.Rows.Count > 0 Then
            TxtLugar.Text = tablaExiste.Rows(0)("lugar")
            TxtValor.Text = tablaExiste.Rows(0)("valor")
            TxtDuracion.Text = tablaExiste.Rows(0)("duracion")
            DtpFecha.Value = tablaExiste.Rows(0)("fecha")

            TxtLugar.Enabled = False
            TxtValor.Enabled = False
            TxtDuracion.Enabled = False
            DtpFecha.Enabled = False
            BtnGuardar.Enabled = False
        Else
            TxtLugar.Text = ""
            TxtValor.Text = ""
            TxtDuracion.Text = ""
            TxtLugar.Enabled = Enabled
            TxtValor.Enabled = Enabled
            TxtDuracion.Enabled = Enabled
            DtpFecha.Enabled = Enabled
            BtnGuardar.Enabled = True
        End If


    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If TxtLugar.Text <> "" And TxtValor.Text <> "" Then
            Dim campamento As String = "INSERT INTO campamento ( codigo_año,  valor, lugar, fecha) VALUES(@codigo_año,  @valor, @lugar, @fecha)"
            Dim comandoCampamento As New SqlCommand(campamento, conexion)

            comandoCampamento.Parameters.AddWithValue("@codigo_año", Val(TxtCodigoAño.Text))
            comandoCampamento.Parameters.AddWithValue("@valor", Val(TxtValor.Text))
            comandoCampamento.Parameters.AddWithValue("@lugar", TxtLugar.Text)
            comandoCampamento.Parameters.AddWithValue("@fecha", DtpFecha.Value)

            If comandoCampamento.ExecuteNonQuery() = 0 Then
                MsgBox("Error en la grabación")
            End If

            Dim actualizaCurso As String = "UPDATE cursos SET campamento_importe = '" & Val(TxtValor.Text) / 10 & "' WHERE codigo_año ='" & TxtCodigoAño.Text & "'"
            Dim comando As New SqlCommand(actualizaCurso, conexion)
            comando.ExecuteNonQuery()
            If comando.ExecuteNonQuery() = 0 Then
                MsgBox("Error en la actualización")
            Else
                MsgBox("Datos actualizados")
            End If
            BtnGuardar.Enabled = False
            TxtLugar.Text = ""
            TxtValor.Text = ""
            TxtDuracion.Text = ""
        Else
            MsgBox("Los campos lugar y valor son obligatorios")
        End If


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        TxtLugarActual.Enabled = False
        TxtValorActual.Enabled = False
        TxtDuracionActual.Enabled = False
        TxtFechaActual.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub BtnSalirActualiza_Click(sender As Object, e As EventArgs) Handles BtnSalirActualiza.Click
        Me.Close()
    End Sub



    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim actualiza As String = "UPDATE campamento SET lugar = '" & TxtLugarNuevo.Text & "', valor = '" & Val(TxtValorNuevo.Text) & "', duracion = '" & TxtDuracionNueva.Text & "', fecha = '" & DtpFechaNueva.Value & "' where codigo_año = '" & CbxCodigoAño.Text & "' "
        Dim comando As New SqlCommand(actualiza, conexion)

        If comando.ExecuteNonQuery Then


        Else
            MsgBox("Error en la actualización")
        End If

        Dim actualizaCuota As String = "UPDATE cursos SET campamento_importe = '" & Val(TxtValorNuevo.Text) / 10 & "' WHERE codigo_año = '" & CbxCodigoAño.Text & "' "
        Dim comandoCuota As New SqlCommand(actualizaCuota, conexion)
        If comandoCuota.ExecuteNonQuery() > 0 Then
            MsgBox("DatosActualizados")
            TxtLugarNuevo.Text = ""
            TxtValorNuevo.Text = ""
            TxtDuracionNueva.Text = ""
        Else
            MsgBox("Error al actualizar los datos")
        End If


    End Sub

    Private Sub CbxCodigoAño_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoAño.SelectedValueChanged

        Dim campamento As String = "SELECT codigo_campamento, lugar, valor, duracion, fecha FROM campamento WHERE codigo_año = " & Val(CbxCodigoAño.Text) & " "
            Dim adaptadorCampamento As New SqlDataAdapter(campamento, conexion)
            Dim tabla As New DataTable
            adaptadorCampamento.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            codigoCampamento = tabla.Rows(0)("codigo_campamento")
            TxtLugarActual.Text = tabla.Rows(0)("lugar")
            TxtValorActual.Text = tabla.Rows(0)("valor")
            TxtDuracionActual.Text = tabla.Rows(0)("duracion")
            TxtFechaActual.Text = tabla.Rows(0)("fecha")

            TxtLugarNuevo.Text = TxtLugarActual.Text
            TxtValorNuevo.Text = TxtValorActual.Text
            TxtDuracionNueva.Text = TxtDuracionActual.Text
            DtpFechaNueva.Text = (TxtFechaActual.Text)

        Else

            TxtLugarActual.Text = ""
            TxtValorActual.Text = ""
            TxtDuracionActual.Text = ""
            TxtFechaActual.Text = ""

            TxtLugarNuevo.Text = TxtLugarActual.Text
            TxtValorNuevo.Text = TxtValorActual.Text
            TxtDuracionNueva.Text = TxtDuracionActual.Text
            DtpFechaNueva.Text = (TxtFechaActual.Text)
            BtnGuardar.Enabled = True
            'BtnActualizar.Enabled = False
        End If



        'Dim adaptadorCampamento As New SqlDataAdapter(campamento, conexion)
        'Dim datosCampamento As New DataSet
        'adaptadorCampamento.Fill(datosCampamento, "campamento")

        'If datosCampamento.rows.count > 0 Then
        '    codigoCampamento = datosCampamento.Tables("campamento").Rows(0).Item("codigo_campamento")
        '    TxtLugarActual.Text = datosCampamento.Tables("campamento").Rows(0).Item("lugar")
        '    TxtValorActual.Text = datosCampamento.Tables("campamento").Rows(0).Item("valor")
        '    TxtDuracionActual.Text = datosCampamento.Tables("campamento").Rows(0).Item("duracion")
        '    TxtFechaActual.Text = datosCampamento.Tables("campamento").Rows(0).Item("fecha")

        '    End If
        'Catch ex As Exception
        '    MsgBox("Error comprobando BD" & ex.ToString)
        'End Try

    End Sub

    Private Sub TxtValorNuevo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorNuevo.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtValor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValor.KeyPress
        SoloNumeros(e)
    End Sub
End Class