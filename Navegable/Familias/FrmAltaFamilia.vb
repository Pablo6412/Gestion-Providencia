
Imports System.Data.SqlClient

Public Class FrmAltaFamilia

    Dim comandos As New SqlCommand
    Dim dr As SqlDataReader
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter


    'Conección a la base de datos
    Public Sub FrmAltaFamilia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call conectar()
    End Sub

    'Función que comprueba si existe la familia que se está por cargar (comprueba apellido y nombre del padre y apellido de la madre)
    Private Function FamiliaExiste(ByVal apellido_padre As String) As Boolean
        Dim resultado As Boolean
        Try
            comandos = New SqlCommand("select * from familias where apellido_padre='" & TxtApellidoPadre.Text & "' And nombre_padre='" & TxtNombrePadre.Text & "' and apellido_madre='" & TxtApellidoMadre.Text & "'", conexion)
            dr = comandos.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try
        Return resultado
    End Function

    'validaciones de formato correo, campos vacios y familia existente con posterior grabación en tabla familias
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim codigoFamilia As Integer

        If Validar_Mail(LCase(TxtEmail.Text)) = False Then
            MessageBox.Show("Dirección de correo electrónico no valida, por favor seleccione un correo valido", "Validación de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtEmail.Focus()                 'Si hay error el foco queda en casilla de mail
            TxtEmail.SelectAll()             'Y Queda todo seleccionado lo que esté en la casilla
        Else

            'Verifica casillas vacías
            If TxtApellidoPadre.Text = "" Or TxtNombrePadre.Text = "" Or TxtNombrePadre.Text = "" Or TxtNombreMadre.Text = "" Or TxtDomicilio.Text = "" Or TxtCantidadDeHijos.Text = "" Or TxtTelCel.Text = "" Or TxtTelFijo.Text = "" Then
                MessageBox.Show("Debe llenar todos los campor, solo el campo observaciones puede quedar vacío", "Campos sin completar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If FamiliaExiste(LCase(TxtApellidoPadre.Text)) = False Then

                    'Grabación
                    Dim cadena As String = "INSERT INTO familias(apellido_padre, nombre_padre,dni_padre, apellido_madre, nombre_madre, dni_madre, domicilio, cantidad_de_hijos, telefono_celular, telefono_fijo, email, fecha_ingreso, observaciones)
                                        VALUES(@apellido_padre, @nombre_padre, @dni_padre, @apellido_madre, @nombre_madre, @dni_madre, @domicilio, @cantidad_de_hijos, @telefono_celular, @telefono_fijo, @email, @fecha_ingreso, @observaciones)"
                    'Dim comandos As SqlCommand
                    Dim comandos As New SqlCommand(cadena, conexion)

                    comandos.Parameters.AddWithValue("@apellido_padre", TxtApellidoPadre.Text)
                    comandos.Parameters.AddWithValue("@nombre_padre", TxtNombrePadre.Text)
                    comandos.Parameters.AddWithValue("@dni_padre", TxtDniPadre.Text)
                    comandos.Parameters.AddWithValue("@apellido_madre", TxtApellidoMadre.Text)
                    comandos.Parameters.AddWithValue("@nombre_madre", TxtNombreMadre.Text)
                    comandos.Parameters.AddWithValue("@dni_madre", TxtDniMadre.Text)
                    comandos.Parameters.AddWithValue("@domicilio", TxtDomicilio.Text)
                    comandos.Parameters.AddWithValue("@cantidad_de_hijos", TxtCantidadDeHijos.Text)
                    comandos.Parameters.AddWithValue("@telefono_celular", TxtTelCel.Text)
                    comandos.Parameters.AddWithValue("@telefono_fijo", TxtTelFijo.Text)
                    comandos.Parameters.AddWithValue("@email", TxtEmail.Text)
                    comandos.Parameters.AddWithValue("@fecha_ingreso", DtpFechaIngreso.Value)
                    comandos.Parameters.AddWithValue("@observaciones", TxtObservaciones.Text)


                    If comandos.ExecuteNonQuery() = 1 Then



                        'busca el codigo_familia de la familia recien incorporada
                        Dim codFam As String = "SELECT MAX(codigo_familia) FROM familias"
                        Dim comando As New SqlCommand(codFam, conexion)
                        codigoFamilia = comando.ExecuteScalar

                        Dim descuentoEspecial As String = "INSERT INTO descuento_especial(codigo_familia, tipo_descuento, descuento) VALUES(@codigo_familia, @tipo_descuento, @descuento)"
                        Dim comandoDescuento As New SqlCommand(descuentoEspecial, conexion)
                        comandoDescuento.Parameters.AddWithValue("@codigo_familia", codigoFamilia)
                        comandoDescuento.Parameters.AddWithValue("@tipo_descuento", 1)
                        comandoDescuento.Parameters.AddWithValue("@descuento", 1)

                        If comandoDescuento.ExecuteNonQuery() = 1 Then

                            MessageBox.Show("¡Bien vendia familia " & TxtApellidoPadre.Text & "-" & TxtApellidoMadre.Text & "!")

                            Blanqueo()
                        Else
                            MsgBox("Error en la grabación")
                        End If
                    Else
                        MsgBox("Error en la grabación")

                    End If
                Else
                    MsgBox("La familia " & TxtApellidoPadre.Text & "-" & TxtApellidoMadre.Text & " ya está registrada")
                    Blanqueo()
                End If
            End If
        End If

    End Sub

    Sub Blanqueo()
        TxtApellidoPadre.Clear()
        TxtNombrePadre.Clear()
        TxtDniPadre.Clear()
        TxtApellidoMadre.Clear()
        TxtNombreMadre.Clear()
        TxtDniMadre.Clear()
        TxtDomicilio.Clear()
        TxtCantidadDeHijos.Clear()
        TxtObservaciones.Clear()
        TxtTelCel.Clear()
        TxtTelFijo.Clear()
        TxtEmail.Clear()
        TxtApellidoPadre.Focus()
    End Sub

    'Código que permite solo números en la casilla cantidad de hijos, tel cel y tel fijo
    Private Sub TxtCantidadDeHijos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidadDeHijos.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTelCel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelCel.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtTelFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelFijo.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtApellidoPadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellidoPadre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtApellidoMadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellidoMadre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtNombreMadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombrePadre.KeyPress, TxtNombreMadre.KeyPress
        SoloLetras(e)
    End Sub

    Private Sub TxtDniPadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDniPadre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub TxtDniMadre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDniMadre.KeyPress
        SoloNumeros(e)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        cerrar()
        Me.Close()
    End Sub
End Class