Imports System.Data.SqlClient



'Este formulario lee las siguientes tablas:
'concepto_de_pago

'Update: concepto_de_pago
Public Class FrmConceptosDePago

    Dim datos As DataSet
    Dim dataRider As SqlDataReader
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim codigo As Integer
    Private Sub FrmConceptosDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        conectar()
        ListBox()
        BuscaSinAsignar()
    End Sub

    Private Sub ListBox()
        Dim adaptador As New SqlDataAdapter
        Dim lista As String = "SELECT codigo_concepto, concepto_nombre FROM concepto_de_pago"
        adaptador = New SqlDataAdapter(lista, conexion)

        datos = New DataSet
        datos.Tables.Add("concepto_de_pago")
        adaptador.Fill(datos.Tables("concepto_de_pago"))
        LbxConcepto.DataSource = datos.Tables("concepto_de_pago")
        LbxConcepto.DisplayMember = "concepto_nombre"
        LbxActualizaConcepto.DataSource = datos.Tables("concepto_de_pago")
        LbxActualizaConcepto.DisplayMember = "concepto_nombre"
        LbxBajaConcepto.DataSource = datos.Tables("concepto_de_pago")
        LbxBajaConcepto.DisplayMember = "concepto_nombre"
        CbxConcepto.DataSource = datos.Tables("concepto_de_pago")
        CbxConcepto.DisplayMember = "concepto_nombre"
        CbxCodigoConcepto.DataSource = datos.Tables("concepto_de_pago")
        CbxCodigoConcepto.DisplayMember = "codigo_concepto"

    End Sub

    Private Sub BuscaSinAsignar()
        Dim consulta As String = "SELECT TOP 1 codigo_concepto FROM concepto_de_pago WHERE concepto_nombre = 'Sin asignar' ORDER BY codigo_concepto"
        Dim comando As New SqlCommand(consulta, conexion)
        codigo = comando.ExecuteScalar

    End Sub


    'Private Sub ListBox()
    '    Dim cmd As New SqlCommand
    '    Dim da As SqlDataAdapter

    '    With LsvConcepto

    '        .Columns.Clear()
    '        .Items.Clear()
    '        .View = View.Details
    '        .GridLines = False
    '        .FullRowSelect = True
    '        .Scrollable = True
    '        .HideSelection = False
    '        ''agregando nombres y ancho correcto a las columnas
    '        .Columns.Add("Concepto", 200, HorizontalAlignment.Left)
    '        .Columns.Add("Monto", 80, HorizontalAlignment.Left)

    '    End With


    '    Dim adaptador As New SqlDataAdapter
    '    Dim lista As String = "SELECT codigo_concepto, concepto_nombre FROM concepto_de_pago"
    '    adaptador = New SqlDataAdapter(lista, conexion)

    '    cmd = New SqlCommand(lista, conexion)
    '    Dim lector As SqlDataReader = cmd.ExecuteReader
    '    da = New SqlDataAdapter(cmd)

    '    While lector.Read

    '        With LsvConcepto.Items.Add(lector.Item("concepto_nombre").ToString)

    '            '.SubItems.Add(lector.Item("monto").ToString)

    '        End With

    '    End While


    'End Sub

    'If TxtTaller.Text = "" Or TxtImporte.Text = "" Then
    '        MsgBox("Debe asignarle un nombre y un importe al taller")
    '    Else
    'Dim NuevoTaller As String = "UPDATE taller SET taller_nombre = '" & TxtTaller.Text & "', taller_importe = '" & TxtImporte.Text & "' WHERE codigo_taller = '" & codigo & "'"
    'Dim comando As New SqlCommand(NuevoTaller, conexion)
    '        comando.ExecuteNonQuery()

    '        If comando.ExecuteNonQuery() = 1 Then
    '            MessageBox.Show("El taller " & TxtTaller.Text & " se incorporó correctamente")

    '        Else
    '            MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
    '        End If
    ''AgregaTaller(TxtTaller)
    'End If
    '    'End If
    '    BuscaTaller()





    Private Sub BtnGuardarConcepto_Click(sender As Object, e As EventArgs) Handles BtnGuardarConcepto.Click
        If ConceptoExiste(LCase(TxtNuevoConcepto.Text)) = False Then
            If TxtNuevoConcepto.Text = "" Then
                MsgBox("debe ingresar un concepto")
            Else
                Dim InsertaConcepto As String = "UPDATE concepto_de_pago SET concepto_nombre = '" & TxtNuevoConcepto.Text & "' where codigo_concepto = '" & codigo & "'"
                comando = New SqlCommand(InsertaConcepto, conexion)
                'comando.Parameters.AddWithValue("@concepto_nombre", TxtNuevoConcepto.Text)
                comando.ExecuteNonQuery()

                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("El nuevo concepto fue añadido")
                Else
                    MsgBox("Error en la grabación")
                End If
            End If
        Else
            MsgBox("el concepto " & TxtNuevoConcepto.Text & " ya está registrado")
        End If
        ListBox()
        TxtNuevoConcepto.Clear()
        TxtNuevoConcepto.Focus()
    End Sub


    Private Function ConceptoExiste(ByVal concepto As String) As Boolean
        Dim resultado As Boolean
        Try
            comando = New SqlCommand("SELECT concepto_nombre FROM concepto_de_pago WHERE concepto_nombre ='" & TxtNuevoConcepto.Text & "'", conexion)
            dataRider = comando.ExecuteReader
            If dataRider.Read Then
                resultado = True
            End If
            dataRider.Close()
        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try
        Return resultado
    End Function

    Private Sub CbxCodigoConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCodigoConcepto.SelectedIndexChanged
        Dim CodigoConcepto As String = CbxCodigoConcepto.Text
        Dim consulta As String = "SELECT concepto_nombre FROM concepto_de_pago WHERE codigo_concepto = " & Val(CodigoConcepto) & ""
        adaptador = New SqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "concepto_de_pago")
        TxtActualizaConcepto.DataBindings.Clear()
        TxtActualizaConcepto.DataBindings.Add(New Binding("text", datos, "concepto_de_pago.concepto_nombre"))
    End Sub

    Private Sub BtnActualizaConcepto_Click(sender As Object, e As EventArgs) Handles BtnActualizaConcepto.Click
        Dim actualiza As String = "UPDATE concepto_de_pago SET concepto_nombre = '" & Me.TxtActualizaConcepto.Text & "' where codigo_concepto = " & Me.CbxCodigoConcepto.Text & ""

        Dim comando As New SqlCommand(actualiza, conexion)
        comando.ExecuteNonQuery()

        If comando.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Datos actualizados")
        Else
            MsgBox("Error de grabación")
        End If
        ListBox()
    End Sub

    Private Sub BtnConceptoBaja_Click(sender As Object, e As EventArgs) Handles BtnConceptoBaja.Click
        Dim opcion As DialogResult = MessageBox.Show("¿Realmente quiere dar de baja el concepto " & CbxConcepto.Text & "?", "¡Concepto a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)

        If (opcion = Windows.Forms.DialogResult.Yes) Then
            Try
                Dim baja As String = "Delete  from concepto_de_pago where codigo_concepto ='" & CbxCodigoConcepto.Text & "' "
                Dim comando As New SqlCommand(baja, conexion)
                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Concepto dado de baja exitosamente")
                Else
                    MessageBox.Show("¡Error! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Show()
                End If
            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try
        End If
        ListBox()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
        TxtActualizaConcepto.Text = CbxConcepto.Text
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSalirNuevoConcepto.Click
        Me.Close()
    End Sub

    Private Sub BtnSalirActualiza_Click(sender As Object, e As EventArgs) Handles BtnSalirActualiza.Click
        Me.Close()
    End Sub

    Private Sub BtnSalirBaja_Click(sender As Object, e As EventArgs) Handles BtnSalirBaja.Click
        Me.Close()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class