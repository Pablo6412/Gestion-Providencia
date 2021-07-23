Imports System.Data.SqlClient
Public Class FrmCargaAranceles

    Dim adaptador As SqlDataAdapter
    Dim datos As DataSet
    Dim comando As New SqlCommand
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmCargaAranceles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        conectar()
        Cargar()
        Dgv()
        TxtArancel.Focus()
    End Sub

    Private Sub Cargar()
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
            TextBox1.Text = CbxCodigoNivel.Text

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub

    Private Sub CbxCodigoNivel_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoNivel.SelectedValueChanged
        TextBox1.Text = CbxCodigoNivel.Text
        Llenar()
        Dgv()
        TxtArancel.Clear()
        TxtMatricula.Clear()
    End Sub
    Private Sub Dgv()
        Try
            Dim consulta As String = "SELECT nivel, arancel_importe, arancel_matricula, fecha_de_vigencia FROM niveles JOIN aranceles ON niveles.codigo_nivel = Aranceles.codigo_nivel WHERE Aranceles.codigo_nivel= " & Val(TextBox1.Text) & " "

            comando = New SqlCommand()
            comando.CommandText = consulta
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            adaptador = New SqlDataAdapter(comando)
            Dim dataSet As DataSet = New DataSet()
            adaptador.Fill(dataSet)
            DgvArancel.DataSource = dataSet.Tables(0).DefaultView

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try
    End Sub

    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If TxtArancel.Text = "" Or TxtMatricula.Text = "" Then
            MessageBox.Show("Debe llenar los campos arancel y matrícula en el grupo de nuevos aranceles", "Campos sin completar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtArancel.Focus()
        Else
            Dim existe As String = "Select COUNT(*) from aranceles where codigo_nivel = '" & Val(CbxCodigoNivel.Text) & "'"
            Dim command As New SqlCommand(existe, conexion)
            Dim count As Integer
            count = command.ExecuteScalar()

            If count = 0 Then
                Dim cadena As String = "INSERT INTO aranceles(codigo_nivel, arancel_importe, arancel_matricula, fecha_de_vigencia) 
                                       VALUES(@codigo_nivel, @arancel_importe, @arancel_matricula, @fecha_de_vigencia)"
                comando = New SqlCommand(cadena, conexion)

                comando.Parameters.AddWithValue("@codigo_nivel", CbxCodigoNivel.Text)
                comando.Parameters.AddWithValue("@arancel_importe", TxtArancel.Text)
                comando.Parameters.AddWithValue("@arancel_matricula", TxtMatricula.Text)
                comando.Parameters.AddWithValue("@fecha_de_vigencia", DtpFechaVigencia.Value)

                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Datos guardados")
                    TxtArancel.Clear()
                    TxtMatricula.Clear()
                    TxtArancel.Focus()
                    CbxCodigoNivel.Select()
                Else
                    MsgBox("No grabó nada")
                End If
            Else
                MsgBox("Ya existe arancel para " & CbxNivel.Text & ". Para actualizar su valor vaya a la pestaña ""Actualización de aranceles""")
            End If
        End If
        Dgv()
    End Sub
    Private Sub CargaActualiza()
        Try
            Dim nivel As String = "select codigo_nivel, nivel from niveles"
            adaptador = New SqlDataAdapter(nivel, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet
            datos.Tables.Add("niveles")
            adaptador.Fill(datos.Tables("niveles"))
            CbxNivelActualizacion.DataSource = datos.Tables("niveles")
            CbxNivelActualizacion.DisplayMember = "nivel"
            CbxCodigoNivelActualizacion.DataSource = datos.Tables("niveles")
            CbxCodigoNivelActualizacion.DisplayMember = "codigo_nivel"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub

    Private Sub CbxCodigoNivelActualizacion_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoNivelActualizacion.SelectedValueChanged
        TxtCodigoActualizacion.Text = CbxCodigoNivelActualizacion.Text
        Llenar()
    End Sub

    Private Sub Llenar()
        TxtArancelActual.Clear()
        TxtMatriculaActual.Clear()
        Try
            Dim arancel As String = "select codigo_nivel, arancel_importe, arancel_matricula from aranceles where codigo_nivel = '" & Val(TxtCodigoActualizacion.Text) & "' "
            adaptador = New SqlDataAdapter(arancel, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "aranceles")

            TxtArancelActual.DataBindings.Clear()
            TxtArancelActual.DataBindings.Add(New Binding("text", datos, "aranceles.arancel_importe"))
            TxtMatriculaActual.DataBindings.Clear()
            TxtMatriculaActual.DataBindings.Add(New Binding("text", datos, "aranceles.arancel_matricula"))

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub

    Private Sub BtnActualizar_Click_1(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtArancelModificado.Text = "" Or TxtMatriculaModificada.Text = "" Then
            MessageBox.Show("Debe llenar todos los campos", "Campos sin completar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

            Dim opcion As DialogResult = MessageBox.Show("¿Realmente quiere mofificar este arancel?", "¡Registro a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

            If (opcion = Windows.Forms.DialogResult.Yes) Then

                Try
                    Dim actualiza As String = "UPDATE aranceles SET  arancel_importe ='" & Me.TxtArancelModificado.Text & "'," &
                                          "arancel_matricula= '" & Me.TxtMatriculaModificada.Text & "'," &
                                          "fecha_de_vigencia= '" & Me.DtpFechaModificacion.Text & "'" &
                                          "where codigo_nivel= '" & Me.CbxCodigoNivel.Text & "' "

                    Dim comando As SqlCommand = New SqlCommand(actualiza, conexion)
                    comando.ExecuteNonQuery()
                    If comando.ExecuteNonQuery() = 1 Then
                        MessageBox.Show("Datos actualizados")
                        TxtArancelModificado.Clear()
                        TxtMatriculaModificada.Clear()
                        CbxCodigoNivel.Focus()
                    Else
                        MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                    End If
                Catch ex As Exception
                    MsgBox("Error comprobando BD" & ex.ToString)
                End Try

            End If
            Llenar()
            CargaActualiza()
            Dgv()
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        CargaActualiza()
        Llenar()
        TxtArancelModificado.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)

        Try
            Dim nivel As String = "select codigo_nivel, nivel from niveles"
            adaptador = New SqlDataAdapter(nivel, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet
            datos.Tables.Add("niveles")
            adaptador.Fill(datos.Tables("niveles"))
            CbxNivelBaja.DataSource = datos.Tables("niveles")
            CbxNivelBaja.DisplayMember = "nivel"
            CbxCodigoBaja.DataSource = datos.Tables("niveles")
            CbxCodigoBaja.DisplayMember = "codigo_nivel"
            TextBox1.Text = CbxCodigoNivel.Text

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
        Baja()
    End Sub

    Private Sub Baja()
        TxtArancelBaja.Clear()
        TxtMatriculaBaja.Clear()
        Dim arancel As String = "select codigo_nivel, arancel_importe, arancel_matricula from aranceles where codigo_nivel = '" & Val(CbxCodigoBaja.Text) & "' "
        adaptador = New SqlDataAdapter(arancel, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "aranceles")

        TxtArancelBaja.DataBindings.Clear()
        TxtArancelBaja.DataBindings.Add(New Binding("text", datos, "aranceles.arancel_importe"))
        TxtMatriculaBaja.DataBindings.Clear()
        TxtMatriculaBaja.DataBindings.Add(New Binding("text", datos, "aranceles.arancel_matricula"))
    End Sub


    Private Sub BtnBajaArancel_Click(sender As Object, e As EventArgs) Handles BtnBajaArancel.Click
        Dim opcion As DialogResult = MessageBox.Show("¿Realmente quiere dar de baja este arancel?", "¡Registro a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Try
                Dim baja As String = "Delete  from aranceles  where codigo_nivel ='" & Val(CbxCodigoBaja.Text) & "' "
                Dim comando As New SqlCommand(baja, conexion)

                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Arancel dado de baja exitosamente")
                Else
                    If TxtArancelBaja.Text = "" Then
                        MsgBox("No hay arancel para dar de baja")
                    Else
                        MessageBox.Show("¡Error! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Show()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try
        End If
        Baja()
    End Sub
    Private Sub TxtMatriculaModificada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMatriculaModificada.KeyPress, TxtArancelModificado.KeyPress
        SoloNumeros(e)
    End Sub
    Private Sub TxtMatricula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMatricula.KeyPress, TxtArancel.KeyPress
        SoloNumeros(e)
    End Sub
    Private Sub CbxCodigoBaja_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigoBaja.SelectedValueChanged
        Txtbaja.Text = CbxCodigoBaja.Text
        Baja()
    End Sub
    Private Sub BtnSalirActualizaciones_Click(sender As Object, e As EventArgs) Handles BtnSalirActualizaciones.Click
        Me.Close()
    End Sub
    Private Sub BtnSalirBajas_Click(sender As Object, e As EventArgs) Handles BtnSalirBajas.Click
        Me.Close()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class