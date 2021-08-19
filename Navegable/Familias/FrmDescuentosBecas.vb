Imports System.Data.SqlClient
Public Class FrmDescuentosBecas
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Dim beca As Integer

    Private Sub FrmDescuentosBecas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        conectar()
        NombreBoton()
        Familias()

        Dim lista As Byte
        Dim becas As String = "SELECT tipo_beca FROM descuento_beca"
        adaptador = New SqlDataAdapter(becas, conexion)
        Dim comando As New SqlCommand
        datos = New DataSet

        adaptador.Fill(datos, "descuento_beca")
        lista = datos.Tables("descuento_beca").Rows.Count

        RdbBecaEntera.Text = datos.Tables("descuento_beca").Rows(0).Item("tipo_beca")
        RdbMediaBeca.Text = datos.Tables("descuento_beca").Rows(1).Item("tipo_beca")
        RdbNinguna.Text = datos.Tables("descuento_beca").Rows(2).Item("tipo_beca")
        RdbSinAsignar1.Text = datos.Tables("descuento_beca").Rows(3).Item("tipo_beca")
        RdbSinAsignar2.Text = datos.Tables("descuento_beca").Rows(4).Item("tipo_beca")
        RdbSinAsignar3.Text = datos.Tables("descuento_beca").Rows(5).Item("tipo_beca")

        If RdbSinAsignar1.Text = "Sin asignar" Then
            RdbSinAsignar1.Hide()
        End If

        If RdbSinAsignar2.Text = "Sin asignar" Then
            RdbSinAsignar2.Hide()
        End If

        If RdbSinAsignar3.Text = "Sin asignar" Then
            RdbSinAsignar3.Hide()
        End If

    End Sub

    Private Sub NombreBoton()
        Dim nombre As String = "SELECT tipo_beca FROM descuento_beca"
        adaptador = New SqlDataAdapter(nombre, conexion)
        Dim dtDatos As DataTable = New DataTable
        adaptador.Fill(dtDatos)

        Dim beca As String = dtDatos.Rows(0)("tipo_beca")
        RdbNinguna.Text = beca
        Dim beca1 As String = dtDatos.Rows(1)("tipo_beca")
        RdbMediaBeca.Text = beca1
        Dim beca2 As String = dtDatos.Rows(2)("tipo_beca")
        RdbBecaEntera.Text = beca2
        Dim beca3 As String = dtDatos.Rows(3)("tipo_beca")
        RdbSinAsignar1.Text = beca3
        Dim beca4 As String = dtDatos.Rows(4)("tipo_beca")
        RdbSinAsignar2.Text = beca4
        Dim beca5 As String = dtDatos.Rows(5)("tipo_beca")
        RdbSinAsignar3.Text = beca5

        'MsgBox("beca: " & beca & " beca1: " & beca1 & " beca2: " & beca2 & " beca3: " & beca3 & " beca4: " & beca4 & " beca5: " & beca5 & "")
    End Sub

    Private Sub Familias()

        Try
            Dim concatena As String = "Select codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, concat (apellido_padre,' - ', apellido_madre) as familia from familias where estado = 'activo'"
            adaptador = New SqlDataAdapter(concatena, conexion)

            datos = New DataSet
            adaptador.Fill(datos)
            datos.Tables.Add("familias")
            adaptador.Fill(datos.Tables("familias"))

            Me.CbxFamilia.DataSource = datos.Tables(0)
            Me.CbxFamilia.DisplayMember = "familia"
            Me.CbxFamiliaDescuento.DataSource = datos.Tables(0)
            Me.CbxFamiliaDescuento.DisplayMember = "familia"
            Me.CbxCodFamDescuento.DataSource = datos.Tables(0)
            Me.CbxCodFamDescuento.DisplayMember = "codigo_familia"
            Me.CbxCodigo.DataSource = datos.Tables(0)
            Me.CbxCodigo.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If RdbBecaEntera.Checked = True Then
            beca = 3
            Aplicar()
        ElseIf RdbMediaBeca.Checked = True Then
            beca = 2
            Aplicar()

        ElseIf RdbNinguna.Checked = True Then
            beca = 1
            Aplicar()
        ElseIf RdbSinAsignar1.Checked = True Then
            beca = 4
            Aplicar()
        ElseIf RdbSinAsignar2.Checked = True Then
            beca = 5
            Aplicar()
        ElseIf RdbSinAsignar3.Checked = True Then
            beca = 6
            Aplicar()
        Else
            MessageBox.Show("Debe elegir una opción")
        End If
        RdbBecaEntera.Checked = False
        RdbMediaBeca.Checked = False
        RdbNinguna.Checked = False
        RdbSinAsignar1.Checked = False
        RdbSinAsignar2.Checked = False
        RdbSinAsignar3.Checked = False

    End Sub
    Private Sub Aplicar()
        Dim actualizaFamilia As String = "UPDATE familias SET  codigo_beca ='" & beca & "' WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"
        Dim comandoFamilia As New SqlCommand(actualizaFamilia, conexion)
        comandoFamilia.ExecuteNonQuery()

        If comandoFamilia.ExecuteNonQuery() = 1 Then

            Dim actualizaAlumno As String = "UPDATE alumnos SET codigo_beca ='" & beca & "' WHERE codigo_familia = '" & Val(CbxCodigo.Text) & "'"
            Dim comandoAlumno As New SqlCommand(actualizaAlumno, conexion)
            comandoAlumno.ExecuteNonQuery()

            MessageBox.Show("Las modificaciones se realizaron correctamente")

            CbxCodigo.Focus()
        Else
            MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
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
    End Sub

    Private Sub BtnSalirDescuentos_Click(sender As Object, e As EventArgs) Handles BtnSalirDescuentos.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardarPorcentaje_Click(sender As Object, e As EventArgs) Handles BtnGuardarPorcentaje.Click
        Dim porcentaje As Integer
        porcentaje = Val(TxtDescuentoPorcentaje.Text)
        Dim descuentoPorcentaje As Decimal
        descuentoPorcentaje = (100 - porcentaje) / 100

        Dim descuento As String = "UPDATE descuento_especial  SET tipo_descuento = '" & 1 & "', codigo_familia = '" & CbxCodFamDescuento.Text & "', descuento = '" & descuentoPorcentaje & "', monto = '" & 0 & "' WHERE codigo_familia = '" & CbxCodFamDescuento.Text & "'"
        Dim comando As New SqlCommand(descuento, conexion)

        If comando.ExecuteNonQuery Then
            MsgBox("Descuento aplicado")
        Else
            MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
        End If
        TxtDescuentoPorcentaje.Clear()
        TxtDescuentoMonto.Clear()
    End Sub

    Private Sub BtnGuardarMonto_Click(sender As Object, e As EventArgs) Handles BtnGuardarMonto.Click
        Dim descuento As String = "UPDATE descuento_especial  SET tipo_descuento = '" & 2 & "', codigo_familia = '" & CbxCodFamDescuento.Text & "', descuento = '" & 1 & "', monto = '" & TxtDescuentoMonto.Text & "' WHERE codigo_familia = '" & CbxCodFamDescuento.Text & "'"
        Dim comando As New SqlCommand(descuento, conexion)

        If comando.ExecuteNonQuery Then
            MsgBox("Descuento aplicado")
        Else
            MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
        End If
        TxtDescuentoPorcentaje.Clear()
        TxtDescuentoMonto.Clear()
    End Sub




    Private Sub TxtDescuentoPorcentaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescuentoPorcentaje.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtDescuentoMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescuentoMonto.KeyPress
        SoloNumeros(e)
    End Sub
End Class