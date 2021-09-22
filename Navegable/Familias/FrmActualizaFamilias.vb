Imports System.Data.SqlClient



'Este formulario lee las siguientes tablas: familias

'Update: familias

Public Class FrmActualizaFamilias

    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Private Sub FrmActualizaFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar()

        Try
            Dim concatena As String = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, CONCAT (apellido_padre,' - ', apellido_madre) AS familia FROM familias WHERE estado = 'activo' ORDER BY familia"
            adaptador = New SqlDataAdapter(concatena, conexion)

            datos = New DataSet
            adaptador.Fill(datos)
            datos.Tables.Add("familias")
            adaptador.Fill(datos.Tables("familias"))

            Me.CbxFamilia.DataSource = datos.Tables(0)
            Me.CbxFamilia.DisplayMember = "familia"
            Me.CbxCodigo.DataSource = datos.Tables(0)
            Me.CbxCodigo.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try
    End Sub

    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged
        Dim Codigo As String = CbxCodigo.Text
        Dim lista As Byte
        If Val(Codigo) <> 0 Then
            Try
                Dim consulta As String = "SELECT * FROM familias WHERE codigo_familia='" & Codigo & "' AND estado = 'activo' "
                adaptador = New SqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "familias")
                lista = datos.Tables("familias").Rows.Count

                TxtApellidoMadre.Text = datos.Tables("familias").Rows(0).Item("apellido_madre")
                TxtNombreMadre.Text = datos.Tables("familias").Rows(0).Item("nombre_madre")
                TxtDniMadre.Text = datos.Tables("familias").Rows(0).Item("dni_madre")
                TxtApellidoPadre.Text = datos.Tables("familias").Rows(0).Item("apellido_padre")
                TxtNombrePadre.Text = datos.Tables("familias").Rows(0).Item("nombre_padre")
                TxtDniPadre.Text = datos.Tables("familias").Rows(0).Item("dni_padre")
                TxtDomicilio.Text = datos.Tables("familias").Rows(0).Item("domicilio")
                TxtNumeroHijos.Text = datos.Tables("familias").Rows(0).Item("cantidad_de_hijos")
                TxtMovilMadre.Text = datos.Tables("familias").Rows(0).Item("movil_madre")
                TxtMovilPadre.Text = datos.Tables("familias").Rows(0).Item("movil_padre")
                TxtTelFijo.Text = datos.Tables("familias").Rows(0).Item("telefono_fijo")
                TxtEmailPadre.Text = datos.Tables("familias").Rows(0).Item("email_padre")
                TxtEmailMadre.Text = datos.Tables("familias").Rows(0).Item("email_madre")
                TxtObservaciones.Text = datos.Tables("familias").Rows(0).Item("observaciones")
            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
            End Try

        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validar_Mail(LCase(TxtEmailPadre.Text)) = False Then
            MessageBox.Show("Dirección de correo electrónico no valida, por favor seleccione un correo valido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtEmailPadre.Focus()                 'Si hay error el foco queda en casilla de mail
            TxtEmailPadre.SelectAll()             'Y Queda todo seleccionado lo que esté en la casilla
        Else
            Dim actualiza As String = "UPDATE familias SET apellido_madre ='" & Me.TxtApellidoMadre.Text & "'," &
                                         "nombre_madre ='" & Me.TxtNombreMadre.Text & "'," &
                                         "dni_madre =" & Me.TxtDniMadre.Text & "," &
                                         "apellido_padre ='" & Me.TxtApellidoPadre.Text & "'," &
                                         "nombre_padre ='" & Me.TxtNombrePadre.Text & "'," &
                                         "dni_padre =" & Me.TxtDniPadre.Text & "," &
                                         "domicilio ='" & Me.TxtDomicilio.Text & "'," &
                                         "cantidad_de_hijos =" & Me.TxtNumeroHijos.Text & "," &
                                         "email_madre= '" & Me.TxtEmailMadre.Text & "'," &
                                         "email_padre= '" & Me.TxtEmailPadre.Text & "'," &
                                         "movil_madre='" & Me.TxtMovilMadre.Text & "'," &
                                         "movil_padre='" & Me.TxtMovilPadre.Text & "'," &
                                         "telefono_fijo= '" & Me.TxtTelFijo.Text & "'," &
                                         "fecha_modificacion= '" & Me.DtpModificacion.Text & "'," &
                                         "observaciones= '" & Me.TxtObservaciones.Text & "' " &
                                         "where codigo_familia='" & Me.CbxCodigo.Text & "' "

            Dim comando As New SqlCommand(actualiza, conexion)
            comando.ExecuteNonQuery()

            If comando.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Las modificaciones se realizaron correctamente")

                CbxCodigo.Focus()
            Else
                MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
            End If
        End If

    End Sub

    Private Sub TxtNumeroHijos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumeroHijos.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTelCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMovilMadre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTelFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelFijo.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtMovilPadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMovilPadre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtApellidoMadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellidoMadre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtApellidoPadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellidoPadre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtNombreMadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombreMadre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtNombrePadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombrePadre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtDniMadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDniMadre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtDniPadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDniPadre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class