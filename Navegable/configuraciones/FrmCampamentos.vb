Imports System.Data.SqlClient


Public Class FrmCampamentos
    Dim codigoNivel As Integer
    Dim codigoCurso As Integer
    Dim codigoAño As Integer
    Dim año As String


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
        codigoNivel = TxtCodigoNivel.Text = CbxCodigonivel.Text

        Dim año As String = "SELECT  codigo_año,  año FROM cursos WHERE codigo_nivel = '" & Val(CbxCodigonivel.Text) & "' GROUP BY año, codigo_año "
        Dim adaptadorAño As New SqlDataAdapter(año, conexion)
        Dim tabla As New DataTable
        adaptadorAño.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            codigoAño = tabla.Rows(0)("codigo_año")
            año = tabla.Rows(0)("año")
            'codigoCurso = tabla.Rows(0)("codigo_curso")

            MsgBox("codigo año: " & codigoAño & " año: " & año & "")
        End If
        Dim datosCurso As New DataSet
        datosCurso.Tables.Add("cursos")
        adaptadorAño.Fill(datosCurso.Tables("cursos"))
        CbxCurso.DataSource = datosCurso.Tables("cursos")
        CbxCurso.DisplayMember = "año"


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim campamento As String = "INSERT INTO campamento (codigo_curso, codigo_año,  valor, lugar, fecha) VALUES(@codigo_curso, @codigo_año,  @valor, @lugar, @fecha)"
        Dim comandoCampamento As New SqlCommand(campamento, conexion)

        comandoCampamento.Parameters.AddWithValue("@codigo_curso", CbxCodigoCurso.Text)
        comandoCampamento.Parameters.AddWithValue("@codigo_año", codigoAño)
        comandoCampamento.Parameters.AddWithValue("@valor", Val(TxtValor.Text))
        comandoCampamento.Parameters.AddWithValue("@lugar", TxtLugar.Text)
        comandoCampamento.Parameters.AddWithValue("@fecha", DtpFecha.Value)

        comandoCampamento.ExecuteNonQuery()
        If comandoCampamento.ExecuteNonQuery() = 0 Then
            MsgBox("Error en la grabación")
        Else
            MsgBox("Datos guardados")
        End If


        Dim actualizaCurso As String = "UPDATE cursos SET campamento_importe = '" & Val(TxtValor.Text) & "' WHERE codigo_año ='" & codigoAño & "'"
        Dim comando As New SqlCommand(actualizaCurso, conexion)
        comando.ExecuteNonQuery()
        If comando.ExecuteNonQuery() = 0 Then
            MsgBox("Error en la actualización")
        Else
            MsgBox("Datos actualizados")
        End If
    End Sub



    Private Sub CbxCurso_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCurso.SelectedValueChanged


        Dim año As String = "SELECT  codigo_año,  año FROM cursos WHERE codigo_nivel = '" & Val(CbxCodigoCurso.Text) & "' GROUP BY año, codigo_año "
        Dim adaptadorAño As New SqlDataAdapter(año, conexion)
        Dim tabla As New DataTable
        adaptadorAño.Fill(tabla)

        If tabla.Rows.Count > 0 Then
            codigoAño = tabla.Rows(0)("codigo_año")
            año = tabla.Rows(0)("año")
            'codigoCurso = tabla.Rows(0)("codigo_curso")

            MsgBox("codigo año: " & codigoAño & " año: " & año & "")
        End If

    End Sub
End Class