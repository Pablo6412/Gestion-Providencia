Imports System.Data.SqlClient


'Este formulario lee las siguientes tablas: familias

'Delete: cuotas,
'        taller_alumno
'        pagos_escolares
'        detalle_vencimientos_escolares
'        detalle_pago_escolar

'Update: familias, alumnos, pago_familia, vencimiento_detallado

Public Class FrmBajasFamilias
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Dim concatena As String
    Dim opcion

    Private Sub FrmBajasFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        CargarFamilias() 'Carga lista de familias
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If CbxCodigo.Text = "" Then
            opcion = MessageBox.Show("Debe seleccionar una familia ", "¡Campos vacios!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            opcion = MessageBox.Show("¿Realmente quiere dar de baja a la familia " & CbxFamilia.Text & "? ", "¡Registro a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        End If
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            abrir()
            Dim baja As String = "UPDATE familias SET  estado = 'Inactivo'
                                                                              
                                         WHERE codigo_familia='" & Me.CbxCodigo.Text & "' "

            Dim comando As New SqlCommand(baja, conexion)
            If comando.ExecuteNonQuery() = 1 Then

                Dim bajaHijos As String = "UPDATE alumnos SET  estado = 'Inactivo'
                                                                              
                                         WHERE codigo_familia='" & Me.CbxCodigo.Text & "' "

                Dim comandoHijos As New SqlCommand(bajaHijos, conexion)
                If comandoHijos.ExecuteNonQuery() <> 0 Then

                    Dim bajaPagoFamilia As String = "UPDATE pago_familia SET  estado = 'Inactivo'
                                                     WHERE codigo_familia= " & Val(CbxCodigo.Text) & " "

                    Dim comandoPagoFamilia As New SqlCommand(bajaPagoFamilia, conexion)
                    If comandoPagoFamilia.ExecuteNonQuery() <> 0 Then

                        Dim BajaDetallePagoEscolar As String = "DELETE detalle_pago_escolar WHERE codigo_familia = " & Val(CbxCodigo.Text) & " "

                        Dim comandoDetallePago As New SqlCommand(BajaDetallePagoEscolar, conexion)
                        If comandoDetallePago.ExecuteNonQuery() <> 0 Then

                            Dim bajaPagosEscolares As String = "DELETE pagos_escolares WHERE codigo_familia = " & Val(CbxCodigo.Text) & " "
                            Dim comandoPagosEscolares As New SqlCommand(bajaPagosEscolares, conexion)
                            If comandoPagosEscolares.ExecuteNonQuery() <> 0 Then

                                Dim bajaDetalleVencimientos As String = "DELETE detalle_vencimientos_escolares WHERE codigo_familia = " & CbxCodigo.Text & " "
                                Dim comandoDetalle As New SqlCommand(bajaDetalleVencimientos, conexion)
                                If comandoDetalle.ExecuteNonQuery() <> 0 Then

                                    Dim bajaVencimientoDetallado As String = "UPDATE vencimiento_detallado SET estado = 'inactivo'
                                                                              WHERE codigo_familia = " & CbxCodigo.Text & " "
                                    Dim comandoVencimiento As New SqlCommand(bajaVencimientoDetallado, conexion)
                                    If comandoVencimiento.ExecuteNonQuery <> 0 Then

                                        Dim bajaCuota As String = "DELETE cuotas WHERE codigo_familia = " & Val(CbxCodigo.Text) & " "
                                        Dim comandoCuota As New SqlCommand(bajaCuota, conexion)
                                        If comandoCuota.ExecuteNonQuery() <> 0 Then

                                            Dim bajaTaller As String = "DELETE taller_alumno WHERE codigo_familia = " & Val(CbxCodigo.Text) & " "
                                            Dim comandoTaller As New SqlCommand(bajaTaller, conexion)
                                            If comandoTaller.ExecuteNonQuery() Then

                                                MessageBox.Show("La familia " & CbxFamilia.Text & " fue dada de baja exitosamente")
                                                CbxCodigo.Text = ("")
                                                CbxFamilia.Text = ("")
                                                CargarFamilias()
                                                CbxCodigo.Focus()
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If

                    Else
                        MessageBox.Show("¡Error1! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            Else
                MessageBox.Show("¡Error2! Baja fallida. Reinicie el programa e intente nuevamente. De persistir el inconveniente contacte a los programadores", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        cerrar()
    End Sub
    Private Sub BtnReincorporar_Click(sender As Object, e As EventArgs) Handles BtnReincorporar.Click

        If CbxReincorporaCodigo.Text = "" Then
            opcion = MessageBox.Show("Debe seleccionar una familia ", "¡Campos vacios!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            opcion = MessageBox.Show("¿Realmente quiere reincorporar a la familia " & CbxReincorporaFamilia.Text & "? " + vbCr + "Verifique datos a actualizar en los formularios de actualización de familias y actualización de alumnos", "¡Está a punto de reincorporar ésta familia!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        End If
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            abrir()
            Dim reincorpora As String = "UPDATE familias SET  estado = 'Activo'

                                         WHERE codigo_familia='" & Me.CbxReincorporaCodigo.Text & "' "

            Dim comando As New SqlCommand(reincorpora, conexion)
            If comando.ExecuteNonQuery() = 1 Then

                Dim reincorporaPagoFamilia As String = "UPDATE pago_familia SET estado = 'activo' WHERE codigo_familia = " & Val(CbxReincorporaCodigo.Text) & " "
                Dim comandoPagoF As New SqlCommand(reincorporaPagoFamilia, conexion)

                If comandoPagoF.ExecuteNonQuery <> 0 Then

                    Dim reincorporaVencimientos As String = "UPDATE detalle_vencimientos_escolares SET estado = 'activo' "
                    Dim comandoVencimientos As New SqlCommand(reincorporaVencimientos, conexion)
                    If comandoVencimientos.ExecuteNonQuery Then

                        MessageBox.Show("La familia " & CbxReincorporaFamilia.Text & " fue reincorporada exitosamente")
                        CbxReincorporaCodigo.Text = ("")
                        CbxReincorporaFamilia.Text = ("")
                        CargarFamilias()
                        CbxCodigo.Focus()

                    Else
                        MessageBox.Show("¡Error! Reincorporación fallida. Reinicie el programa e intente nuevamente", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("¡Error! Reincorporación fallida. Reinicie el programa e intente nuevamente", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("¡Error! Reincorporación fallida. Reinicie el programa e intente nuevamente", "¡Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        cerrar()
    End Sub

    Sub CargarFamilias()
        abrir()

        Try
            concatena = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, CONCAT (apellido_padre,' - ', apellido_madre) AS familia, estado FROM familias WHERE estado = 'activo' ORDER BY familia"
            adaptador = New SqlDataAdapter(concatena, conexion)
            datos = New DataSet
            datos.Tables.Add("familias")
            adaptador.Fill(datos.Tables("familias"))

            CbxFamilia.DataSource = datos.Tables("familias")
            CbxFamilia.DisplayMember = "familia"
            CbxCodigo.DataSource = datos.Tables("familias")
            CbxCodigo.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try

        'Carga familias dadas de baja
        Try
            concatena = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, CONCAT(apellido_padre,' - ', apellido_madre) AS familia, estado FROM familias WHERE estado = 'inactivo'"
            adaptador = New SqlDataAdapter(concatena, conexion)
            datos = New DataSet
            datos.Tables.Add("familias")
            adaptador.Fill(datos.Tables("familias"))
            CbxReincorporaFamilia.DataSource = datos.Tables("familias")
            CbxReincorporaFamilia.DisplayMember = "familia"
            CbxReincorporaCodigo.DataSource = datos.Tables("familias")
            CbxReincorporaCodigo.DisplayMember = "codigo_familia"
        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        End Try
        cerrar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class