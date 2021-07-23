Imports System.Data.SqlClient


Public Class FrmBecas

    Dim adaptador As New SqlDataAdapter
    Dim datos As DataSet
    Dim codigo As Integer
    Dim contador As Integer
    Dim codigo2 As Integer
    Private Sub FrmBecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        abrir()
        BuscaBeca()
        ListBox()
        cerrar()
        abrir()
        BuscaSinAsignar()
    End Sub

    Private Sub BuscaBeca()
        Dim beca As String = "SELECT codigo_beca, tipo_beca FROM descuento_beca"
        'Dim nivel As String = "SELECT codigo_taller, taller_nombre FROM taller"
        adaptador = New SqlDataAdapter(beca, conexion)

        datos = New DataSet
        datos.Tables.Add("descuento_beca")
        adaptador.Fill(datos.Tables("descuento_beca"))
        LbxBeca.DataSource = datos.Tables("descuento_beca")
        LbxBeca.DisplayMember = "tipo_beca"
    End Sub

    Private Sub ListBox()
        Dim cmd As New SqlCommand
        Dim da As SqlDataAdapter

        With LsvBeca

            .Columns.Clear()
            .Items.Clear()
            .View = View.Details
            .GridLines = False
            .FullRowSelect = True
            .Scrollable = True
            .HideSelection = False
            ''agregando nombres y ancho correcto a las columnas
            .Columns.Add("Tipo de beca", 150, HorizontalAlignment.Left)
            .Columns.Add("Monto", 80, HorizontalAlignment.Left)

        End With


        Dim adaptador As New SqlDataAdapter
        Dim lista As String = "SELECT codigo_beca, tipo_beca, descuento_beca FROM descuento_beca"
        adaptador = New SqlDataAdapter(lista, conexion)

        cmd = New SqlCommand(lista, conexion)
        Dim lector As SqlDataReader = cmd.ExecuteReader
        da = New SqlDataAdapter(cmd)

        While lector.Read

            With LsvBeca.Items.Add(lector.Item("tipo_beca").ToString)

                .SubItems.Add(lector.Item("descuento_beca").ToString)

            End With

        End While
    End Sub

    Private Sub BuscaSinAsignar()
        Dim consulta As String = "SELECT TOP 1 codigo_beca FROM descuento_beca WHERE tipo_beca = 'Sin asignar' ORDER BY codigo_beca"
        Dim comando As New SqlCommand(consulta, conexion)
        codigo = comando.ExecuteScalar
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim porcentaje As Integer
        Dim indice As Decimal



        If TxtTipoBeca.Text = "" Then
            MsgBox("Debe asignar un tipo de Beca")
        Else
            porcentaje = Val(TxtPorcentaje.Text)

            indice = (100 - porcentaje) / 100
            TxtIndice.Text = indice
            MsgBox("El índice es '" & Val(TxtIndice.Text) & "'")
            Dim NuevaBeca As String = "UPDATE descuento_beca SET tipo_beca = '" & TxtTipoBeca.Text & "', descuento_beca = '" & indice & "' WHERE codigo_beca = '" & codigo & "'"
            Dim comando As New SqlCommand(NuevaBeca, conexion)
            comando.ExecuteNonQuery()

            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("" & TxtTipoBeca.Text & " se incorporó correctamente")

            Else
                MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
            End If

        End If

        BuscaBeca()
    End Sub

    Public Sub TxttIndice_LostFocus()

        Dim val As Decimal = 0

        If Decimal.TryParse(TxtIndice.Text, val) Then

            TxtIndice.Text = val.ToString("N2")

        Else

            TxtIndice.Text = ""

        End If

    End Sub


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub



    Private Sub LbxBeca_SelectedValueChanged(sender As Object, e As EventArgs) Handles LbxBeca.SelectedValueChanged
        If contador <> 0 Then

            Dim lista As Byte
            Dim beca As String = "SELECT * FROM descuento_beca WHERE tipo_beca = '" & LbxBeca.Text & "'"
            adaptador = New SqlDataAdapter(beca, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet

            adaptador.Fill(datos, "descuento_beca")
            lista = datos.Tables("descuento_beca").Rows.Count
            codigo2 = datos.Tables("descuento_beca").Rows(0).Item("codigo_beca")
            TxtTipoBeca.Text = datos.Tables("descuento_beca").Rows(0).Item("tipo_beca")
            TxtPorcentaje.Text = datos.Tables("descuento_beca").Rows(0).Item("descuento_beca")
        End If
        contador += 1
    End Sub
End Class