Imports System.Data.SqlClient


Public Class FrmBecas

    Dim adaptador As New SqlDataAdapter
    Dim datos As DataSet
    Dim codigo As Integer
    'Dim codigo2 As Integer
    Dim contador As Integer
    Dim codigoBeca As String

    Private Sub FrmBecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        conectar()
        abrir()
        BuscaBeca()
        cerrar()
        abrir()
        BuscaSinAsignar()
    End Sub

    Private Sub BuscaBeca()
        Dim beca As String = "SELECT codigo_beca, tipo_beca FROM descuento_beca"
        adaptador = New SqlDataAdapter(beca, conexion)
        datos = New DataSet
        datos.Tables.Add("descuento_beca")
        adaptador.Fill(datos.Tables("descuento_beca"))
        LbxBeca.DataSource = datos.Tables("descuento_beca")
        LbxBeca.DisplayMember = "tipo_beca"
        LbxEliminaBeca.DataSource = datos.Tables("descuento_beca")
        LbxEliminaBeca.DisplayMember = "tipo_beca"
    End Sub

    Private Sub BuscaSinAsignar()
        codigo = 0
        Dim consulta As String = "SELECT  TOP 1 codigo_beca FROM descuento_beca WHERE tipo_beca = 'Sin asignar' ORDER BY codigo_beca"
        Dim comando As New SqlCommand(consulta, conexion)
        codigo = comando.ExecuteScalar
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BuscaSinAsignar()
        If codigo = 0 Then
            MsgBox("No se pueden agregar nuevas Becas. Elimine primero becas en desuso")
        Else
            Dim porcentaje As Integer
            Dim indice As Decimal

            If TxtTipoBeca.Text = "" Then
                MsgBox("Debe asignar un tipo de Beca")
            Else
                porcentaje = TxtPorcentaje.Text

                indice = (100 - porcentaje) / 100

                'indice = Format(indice, "##,##0.00")
                'indice = String.Format("{0:N2}", indice)
                'TxtIndice.Text = indice
                'TxtIndice.Text = Format(TxtIndice.Text, "##,##00.00")
                'Dim RepresentacionNumerica = indice.ToString("N2", New Globalization.CultureInfo("es-ES"))
                'MsgBox("El índice es '" & indice & "'")
                Dim NuevaBeca As String = "UPDATE descuento_beca SET tipo_beca = '" & TxtTipoBeca.Text & "', descuento_beca = '" & indice & "' WHERE codigo_beca = '" & codigo & "'"
                Dim comando As New SqlCommand(NuevaBeca, conexion)
                comando.ExecuteNonQuery()

                If comando.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("" & TxtTipoBeca.Text & " se incorporó correctamente")

                Else
                    MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                End If

            End If
        End If
        BuscaBeca()
    End Sub


    Private Sub LbxEliminaBeca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbxEliminaBeca.SelectedIndexChanged
        If contador <> 0 Then

            Dim lista As Byte
            Dim beca As String = "SELECT * FROM descuento_beca WHERE tipo_beca = '" & LbxBeca.Text & "'"
            adaptador = New SqlDataAdapter(beca, conexion)
            Dim comando As New SqlCommand
            datos = New DataSet

            adaptador.Fill(datos, "descuento_beca")
            lista = datos.Tables("descuento_beca").Rows.Count
            'codigo2 = datos.Tables("descuento_beca").Rows(0).Item("codigo_beca")
            TxtEliminaBeca.Text = datos.Tables("descuento_beca").Rows(0).Item("tipo_beca")
            TxtEliminaPorcentaje.Text = datos.Tables("descuento_beca").Rows(0).Item("descuento_beca")
            codigoBeca = datos.Tables("descuento_beca").Rows(0).Item("codigo_beca")

        End If
        contador += 1
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim SinAsignar As String = "Sin asignar"
        Dim DescuentoBeca As Integer = 1
        Dim elimina As String = "UPDATE descuento_beca SET tipo_beca = '" & SinAsignar & "', descuento_beca = '" & DescuentoBeca & "' WHERE codigo_beca = '" & codigoBeca & "'"
        Dim comando1 As New SqlCommand(elimina, conexion)
        comando1.ExecuteNonQuery()

        If comando1.ExecuteNonQuery() = 1 Then
            MessageBox.Show("" & TxtTipoBeca.Text & " se eliminó correctamente")

        Else
            MsgBox("¡Error! Beca no eliminada. Reinicie el programa e intente nuevamente")
        End If
        BuscaBeca()

    End Sub

    Private Sub TxtPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPorcentaje.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir2_Click(sender As Object, e As EventArgs) Handles BtnSalir2.Click
        Me.Close()
    End Sub


End Class