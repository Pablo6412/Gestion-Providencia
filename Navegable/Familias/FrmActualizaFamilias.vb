Imports System.Data.SqlClient

Public Class FrmActualizaFamilias

    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Private Sub FrmActualizaFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar()

        Try
            Dim concatena As String = "select codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, concat (apellido_padre,' - ', apellido_madre) as familia from familias where estado = 'activo'"
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
                Dim consulta As String = "select codigo_familia, domicilio, cantidad_de_hijos, telefono_celular, telefono_fijo, email, observaciones from familias where codigo_familia='" & Codigo & "' "
                adaptador = New SqlDataAdapter(consulta, conexion)
                datos = New DataSet
                adaptador.Fill(datos, "familias")
                lista = datos.Tables("familias").Rows.Count

                TxtDomicilio.Text = datos.Tables("familias").Rows(0).Item("domicilio")
                TxtNumeroHijos.Text = datos.Tables("familias").Rows(0).Item("cantidad_de_hijos")
                TxtTelCelular.Text = datos.Tables("familias").Rows(0).Item("telefono_celular")
                TxtTelFijo.Text = datos.Tables("familias").Rows(0).Item("telefono_fijo")
                TxtEmail.Text = datos.Tables("familias").Rows(0).Item("email")
                TxtObservaciones.Text = datos.Tables("familias").Rows(0).Item("observaciones")
            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
            End Try

        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validar_Mail(LCase(TxtEmail.Text)) = False Then
            MessageBox.Show("Dirección de correo electrónico no valida, por favor seleccione un correo valido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtEmail.Focus()                 'Si hay error el foco queda en casilla de mail
            TxtEmail.SelectAll()             'Y Queda todo seleccionado lo que esté en la casilla
        Else
            Dim actualiza As String = "update familias set  domicilio ='" & Me.TxtDomicilio.Text & "'," &
                                         "cantidad_de_hijos =" & Me.TxtNumeroHijos.Text & "," &
                                         "telefono_celular='" & Me.TxtTelCelular.Text & "'," &
                                         "telefono_fijo= '" & Me.TxtTelFijo.Text & "'," &
                                         "email= '" & Me.TxtEmail.Text & "'," &
                                         "fecha_modificacion= '" & Me.DtpModificacion.Text & "'," &
                                         "observaciones= '" & Me.TxtObservaciones.Text & "' " &
                                         "where codigo_familia='" & Me.CbxCodigo.Text & "' "

            Dim comando As SqlCommand = New SqlCommand(actualiza, conexion)
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

    Private Sub TxtTelCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelCelular.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTelFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelFijo.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class