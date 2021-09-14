Imports System.Data.SqlClient

'Este formulario lee las siguientes tablas:
'cursos,
'niveles

'Insert: cursos

'Update: cursos

Public Class FrmCargaCursos
    Dim adaptador As New SqlDataAdapter
    Dim datos As DataSet
    Dim comando As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub FrmCargaCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RdbCargaCurso.Checked = True
        conectar()
        LlenaLista()
        Nivel()

    End Sub

    Private Sub LlenaLista()
        Dim curso As String = "SELECT codigo_curso, curso FROM cursos"
        adaptador = New SqlDataAdapter(curso, conexion)

        datos = New DataSet
        datos.Tables.Add("cursos")
        adaptador.Fill(datos.Tables("cursos"))
        LbxCursos.DataSource = datos.Tables("cursos")
        LbxCursos.DisplayMember = "curso"
        LbxCursoActualiza.DataSource = datos.Tables("cursos")
        LbxCursoActualiza.DisplayMember = "curso"
        LbxCursosBaja.DataSource = datos.Tables("cursos")
        LbxCursosBaja.DisplayMember = "curso"
        CbxCodigoBaja.DataSource = datos.Tables("cursos")
        CbxCodigoBaja.DisplayMember = "codigo_curso"
        CbxCursoBaja.DataSource = datos.Tables("cursos")
        CbxCursoBaja.DisplayMember = "curso"
        CbxCurso.DataSource = datos.Tables("cursos")
        CbxCurso.DisplayMember = "curso"
        CbxCodigoCurso.DataSource = datos.Tables("cursos")
        CbxCodigoCurso.DisplayMember = "codigo_curso"
    End Sub

    Private Sub Nivel()
        Try
            Dim nivel As String = "SELECT codigo_nivel, nivel FROM niveles"
            adaptador = New SqlDataAdapter(nivel, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet
            datos.Tables.Add("niveles")
            adaptador.Fill(datos.Tables("niveles"))
            CbxNivel.DataSource = datos.Tables("niveles")
            CbxNivel.DisplayMember = "nivel"
            CbxCodigoNivel.DataSource = datos.Tables("niveles")
            CbxCodigoNivel.DisplayMember = "codigo_nivel"
            'TextBox1.Text = CbxCodigoNivel.Text

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub
    Private Sub CargaCurso()
        If CursoExiste(LCase(TxtCursoCarga.Text)) = False Then
            If TxtCursoCarga.Text = "" Then
                MsgBox("debe ingresar un curso")
            Else
                Dim InsertaCurso As String = "INSERT INTO cursos(curso, codigo_nivel) values(@curso, @codigo_nivel)"
                comando = New SqlCommand(InsertaCurso, conexion)
                comando.Parameters.AddWithValue("@curso", TxtCursoCarga.Text)
                comando.Parameters.AddWithValue("@codigo_nivel", Val(CbxCodigoNivel.Text))
                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Curso guardado")
                Else
                    MsgBox("Error en la grabación")
                End If
            End If
        Else
            MsgBox("el curso " & TxtCursoCarga.Text & " ya está registrado")
        End If
        LlenaLista()
        TxtCursoCarga.Clear()
        TxtCursoCarga.Focus()
    End Sub


    Private Sub CbxCodigoCurso_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoCurso.SelectedValueChanged
        Dim CodigoCurso As String = CbxCodigoCurso.Text
        Dim consulta As String = "SELECT curso from cursos where codigo_curso = " & Val(CodigoCurso) & ""
        adaptador = New SqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "cursos")
        TxtCursoActualizado.DataBindings.Clear()
        TxtCursoActualizado.DataBindings.Add(New Binding("text", datos, "cursos.curso"))
    End Sub
    Private Function CursoExiste(ByVal curso As String) As Boolean
        Dim resultado As Boolean
        Try
            comando = New SqlCommand("select curso from cursos where curso ='" & TxtCursoCarga.Text & "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try
        Return resultado
    End Function

    Private Sub LbxCursoActualiza_SelectedValueChanged(sender As Object, e As EventArgs) Handles LbxCursoActualiza.SelectedValueChanged

    End Sub
    Private Sub RdbCargaCurso_CheckedChanged(sender As Object, e As EventArgs) Handles RdbCargaCurso.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RdbModificaCurso_CheckedChanged(sender As Object, e As EventArgs) Handles RdbModificaCurso.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        TxtCursoActualizado.Text = CbxCurso.Text
    End Sub

    Private Sub RdbBajaCurso_CheckedChanged(sender As Object, e As EventArgs) Handles RdbBajaCurso.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        CargaCurso()
    End Sub


    Private Sub BtnSalirModifica_Click(sender As Object, e As EventArgs) Handles BtnSalirModifica.Click
        Me.Close()
    End Sub

    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        Dim opcion As DialogResult = MessageBox.Show("¿Realmente quiere dar de baja el curso " & CbxCursoBaja.Text & "?", "¡Curso a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

        If (opcion = Windows.Forms.DialogResult.Yes) Then

            Try
                Dim baja As String = "Delete  from cursos where codigo_curso ='" & CbxCodigoBaja.Text & "' "
                Dim comando As New SqlCommand(baja, conexion)

                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Curso dado de baja exitosamente")
                Else
                    MessageBox.Show("¡Error! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Show()
                End If

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try
        End If
        LlenaLista()
    End Sub

    Private Sub BtnSalirBaja_Click(sender As Object, e As EventArgs) Handles BtnSalirBaja.Click
        Me.Close()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Dim actualiza As String = "UPDATE cursos SET curso = '" & Me.TxtCursoActualizado.Text & "' where codigo_curso = " & Me.CbxCodigoCurso.Text & ""

        Dim comando As New SqlCommand(actualiza, conexion)
        comando.ExecuteNonQuery()

        If comando.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Datos actualizados")
        Else
            MsgBox("Error de grabación")
        End If
        LlenaLista()
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    'Private Sub TxtCursoCarga_Click(sender As Object, e As EventArgs) Handles TxtCursoCarga.Click
    '    MessageBox.Show("¡No olvide seleccionar primero el nivel!")
    'End Sub
End Class