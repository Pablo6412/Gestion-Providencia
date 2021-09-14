Imports System.Data.SqlClient


'Este formulario lee las siguientes tablas:
'niveles

'Insert: niveles

'Update: niveles

Public Class FrmCargaNiveles
    Dim dr As SqlDataReader
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim adaptador2 As New SqlDataAdapter
    Dim datos As DataSet
    Private Sub FrmCargaNiveles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        conectar()
        BuscaNivel()
    End Sub


    Private Sub BuscaNivel()
        Dim nivel As String = "SELECT codigo_nivel, nivel FROM niveles"
        adaptador = New SqlDataAdapter(nivel, conexion)

        datos = New DataSet
        datos.Tables.Add("niveles")
        adaptador.Fill(datos.Tables("niveles"))
        LbxNivel.DataSource = datos.Tables("niveles")
        LbxNivel.DisplayMember = "nivel"
        LbxNiveles2.DataSource = datos.Tables("niveles")
        LbxNiveles2.DisplayMember = "nivel"
        LbxNivelActualiza.DataSource = datos.Tables("niveles")
        LbxNivelActualiza.DisplayMember = "nivel"
        CbxCodigoBaja.DataSource = datos.Tables("niveles")
        CbxCodigoBaja.DisplayMember = "codigo_nivel"
        CbxNivelBaja.DataSource = datos.Tables("niveles")
        CbxNivelBaja.DisplayMember = "nivel"
        CbxNivel.DataSource = datos.Tables("niveles")
        CbxNivel.DisplayMember = "nivel"
        CbxCodigoNivel.DataSource = datos.Tables("niveles")
        CbxCodigoNivel.DisplayMember = "codigo_nivel"

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If NivelExiste(LCase(TxtNivel.Text)) = False Then
            If TxtNivel.Text = "" Then
                MsgBox("debe ingresar un nivel")
            Else
                Dim InsertaNivel As String = "INSERT INTO niveles(nivel) values(@nivel)"
                comando = New SqlCommand(InsertaNivel, conexion)
                comando.Parameters.AddWithValue("@nivel", TxtNivel.Text)
                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Nivel anexado")
                Else
                    MsgBox("Error en la grabación")

                End If

            End If
        Else
            MsgBox("el nivel " & TxtNivel.Text & " ya está registrado")
        End If
        BuscaNivel()
        TxtNivel.Clear()
        TxtNivel.Focus()
    End Sub


    Private Sub CbxCodigoNivel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCodigoNivel.SelectedIndexChanged
        Dim CodigoNivel As String = CbxCodigoNivel.Text
        Dim consulta As String = "SELECT nivel FROM niveles WHERE codigo_nivel = " & Val(CodigoNivel) & ""
        adaptador2 = New SqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador2.Fill(datos, "niveles")
        TxtNivelActualizado.DataBindings.Clear()
        TxtNivelActualizado.DataBindings.Add(New Binding("text", datos, "niveles.nivel"))
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim actualiza As String = "UPDATE niveles SET nivel = '" & Me.TxtNivelActualizado.Text & "' WHERE codigo_nivel = " & Me.CbxCodigoNivel.Text & ""

        Dim comando As New SqlCommand(actualiza, conexion)
        comando.ExecuteNonQuery()

        If comando.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Niveles actualizados")
        Else
            MsgBox("Error de grabación")
        End If
        BuscaNivel()
    End Sub


    Private Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        Dim opcion As DialogResult = MessageBox.Show("¿Realmente quiere dar de baja el nivel " & CbxNivelBaja.Text & "?", "¡Nivel a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

        If (opcion = Windows.Forms.DialogResult.Yes) Then

            Try
                Dim baja As String = "Delete  from niveles where codigo_nivel ='" & CbxCodigoBaja.Text & "' "
                Dim comando As New SqlCommand(baja, conexion)

                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Nivel dado de baja exitosamente")
                Else
                    MessageBox.Show("¡Error! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Show()
                End If

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try
        End If
        BuscaNivel()
    End Sub
    Private Function NivelExiste(ByVal apellido_padre As String) As Boolean
        Dim resultado As Boolean
        Try
            comando = New SqlCommand("SELECT nivel FROM niveles WHERE nivel ='" & TxtNivel.Text & "'", conexion)
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


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        TxtNivelActualizado.Text = CbxNivel.Text
    End Sub


    Private Sub BtnGuardar2_Click(sender As Object, e As EventArgs) Handles BtnGuardar2.Click
        Me.Close()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub BtnSalirBaja_Click(sender As Object, e As EventArgs) Handles BtnSalirBaja.Click
        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class