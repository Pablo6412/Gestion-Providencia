Imports System.Data.SqlClient


Public Class FrmCampamentos

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

    End Sub


    Private Sub CbxCodigonivel_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigonivel.SelectedValueChanged

        Dim año As String = "SELECT  codigo_año,  año FROM cursos WHERE codigo_nivel = '" & Val(CbxCodigonivel.Text) & "' GROUP BY año, codigo_año "
        Dim adaptadorAño As New SqlDataAdapter(año, conexion)
        Dim tabla As New DataTable
        adaptadorAño.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            TxtCodigoAño.Text = tabla.Rows(0)("codigo_año")
        End If

        Dim datosCurso As New DataSet
        datosCurso.Tables.Add("cursos")
        adaptadorAño.Fill(datosCurso.Tables("cursos"))
        CbxCurso.DataSource = datosCurso.Tables("cursos")
        CbxCurso.DisplayMember = "año"

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

    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim campamento As String = "INSERT INTO campamento ( codigo_año,  valor, lugar, fecha) VALUES(@codigo_año,  @valor, @lugar, @fecha)"
        Dim comandoCampamento As New SqlCommand(campamento, conexion)

        comandoCampamento.Parameters.AddWithValue("@codigo_año", Val(TxtCodigoAño.Text))
        comandoCampamento.Parameters.AddWithValue("@valor", Val(TxtValor.Text))
        comandoCampamento.Parameters.AddWithValue("@lugar", TxtLugar.Text)
        comandoCampamento.Parameters.AddWithValue("@fecha", DtpFecha.Value)

        If comandoCampamento.ExecuteNonQuery() = 0 Then
            MsgBox("Error en la grabación")
        End If

        Dim actualizaCurso As String = "UPDATE cursos SET campamento_importe = '" & Val(TxtValor.Text) & "' WHERE codigo_año ='" & TxtCodigoAño.Text & "'"
        Dim comando As New SqlCommand(actualizaCurso, conexion)
        comando.ExecuteNonQuery()
        If comando.ExecuteNonQuery() = 0 Then
            MsgBox("Error en la actualización")
        Else
            MsgBox("Datos actualizados")
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class