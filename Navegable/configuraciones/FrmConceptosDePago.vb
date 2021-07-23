Imports System.Data.SqlClient
Public Class FrmConceptosDePago

    Dim datos As DataSet
    Dim dataRider As SqlDataReader
    Dim comando As New SqlCommand
    Dim adaptador As New SqlDataAdapter
    Private Sub FrmConceptosDePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        conectar()
        ListBox()
    End Sub

    'Private Sub ListBox()
    '    Dim adaptador As New SqlDataAdapter
    '    Dim lista As String = "SELECT codigo_concepto, concepto FROM conceptos_de_pago"
    '    adaptador = New SqlDataAdapter(lista, conexion)

    '    datos = New DataSet
    '    datos.Tables.Add("conceptos_de_pago")
    '    adaptador.Fill(datos.Tables("conceptos_de_pago"))
    '    LbxConcepto.DataSource = datos.Tables("conceptos_de_pago")
    '    LbxConcepto.DisplayMember = "concepto"
    '    LbxActualizaConcepto.DataSource = datos.Tables("conceptos_de_pago")
    '    LbxActualizaConcepto.DisplayMember = "concepto"
    '    LbxBajaConcepto.DataSource = datos.Tables("conceptos_de_pago")
    '    LbxBajaConcepto.DisplayMember = "concepto"
    '    CbxConcepto.DataSource = datos.Tables("conceptos_de_pago")
    '    CbxConcepto.DisplayMember = "concepto"
    '    CbxCodigoConcepto.DataSource = datos.Tables("conceptos_de_pago")
    '    CbxCodigoConcepto.DisplayMember = "codigo_concepto"

    'End Sub


    Private Sub ListBox()
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter

        With LsvConcepto

            .Columns.Clear()
            .Items.Clear()
            .View = View.Details
            .GridLines = False
            .FullRowSelect = True
            .Scrollable = True
            .HideSelection = False
            ''agregando nombres y ancho correcto a las columnas
            .Columns.Add("Concepto", 200, HorizontalAlignment.Left)
            .Columns.Add("Monto", 80, HorizontalAlignment.Left)

        End With


        Dim adaptador As New SqlDataAdapter
        Dim lista As String = "SELECT codigo_concepto, concepto, monto FROM conceptos_de_pago"
        adaptador = New SqlDataAdapter(lista, conexion)

        cmd = New SqlCommand(lista, conexion)
        Dim lector As SqlDataReader = cmd.ExecuteReader
        da = New SqlDataAdapter(cmd)

        While lector.Read

            With LsvConcepto.Items.Add(lector.Item("concepto").ToString)

                .SubItems.Add(lector.Item("monto").ToString)

            End With

        End While


    End Sub
    Private Sub BtnGuardarConcepto_Click(sender As Object, e As EventArgs) Handles BtnGuardarConcepto.Click
        If ConceptoExiste(LCase(TxtNuevoConcepto.Text)) = False Then
            If TxtNuevoConcepto.Text = "" Then
                MsgBox("debe ingresar un concepto")
            Else
                Dim InsertaConcepto As String = "INSERT INTO conceptos_de_pago(concepto) values(@concepto)"
                comando = New SqlCommand(InsertaConcepto, conexion)
                comando.Parameters.AddWithValue("@concepto", TxtNuevoConcepto.Text)
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
            comando = New SqlCommand("select concepto from conceptos_de_pago where concepto ='" & TxtNuevoConcepto.Text & "'", conexion)
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
        Dim consulta As String = "SELECT concepto from conceptos_de_pago where codigo_concepto = " & Val(CodigoConcepto) & ""
        adaptador = New SqlDataAdapter(consulta, conexion)
        datos = New DataSet
        adaptador.Fill(datos, "conceptos_de_pago")
        TxtActualizaConcepto.DataBindings.Clear()
        TxtActualizaConcepto.DataBindings.Add(New Binding("text", datos, "conceptos_de_pago.concepto"))
    End Sub

    Private Sub BtnActualizaConcepto_Click(sender As Object, e As EventArgs) Handles BtnActualizaConcepto.Click
        Dim actualiza As String = "UPDATE conceptos_de_pago SET concepto = '" & Me.TxtActualizaConcepto.Text & "' where codigo_concepto = " & Me.CbxCodigoConcepto.Text & ""

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
                Dim baja As String = "Delete  from conceptos_de_pago where codigo_concepto ='" & CbxCodigoConcepto.Text & "' "
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