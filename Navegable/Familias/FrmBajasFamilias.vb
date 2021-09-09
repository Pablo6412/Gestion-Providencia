Imports System.Data.SqlClient
Public Class FrmBajasFamilias
    Dim datos As DataSet
    Dim adaptador As SqlDataAdapter
    Dim concatena As String
    Dim opcion

    Private Sub FrmBajasFamilias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        'Carga lista de familias

        CargarFamilias()
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If CbxCodigo.Text = "" Then
            opcion = MessageBox.Show("Debe seleccionar una familia ", "¡Campos vacios!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            opcion = MessageBox.Show("¿Realmente quiere dar de baja a ésta familia? ", "¡Registro a eliminar!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        End If
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            abrir()
            Dim baja As String = "UPDATE familias SET  estado = 'Inactivo'
                                                                              
                                         WHERE codigo_familia='" & Me.CbxCodigo.Text & "' "

            Dim comando As New SqlCommand(baja, conexion)
            'comando.ExecuteNonQuery()

            If comando.ExecuteNonQuery() = 1 Then

                Dim bajaHijos As String = "UPDATE alumnos SET  estado = 'Inactivo'
                                                                              
                                         WHERE codigo_familia='" & Me.CbxCodigo.Text & "' "

                Dim comandoHijos As New SqlCommand(bajaHijos, conexion)
                'comandoHijos.ExecuteNonQuery()

                If comandoHijos.ExecuteNonQuery() <> 0 Then

                    Dim bajaPagoFamilia As String = "UPDATE pago_familia SET  estado = 'Inactivo'
                                                                              
                                         WHERE codigo_familia='" & Val(CbxCodigo.Text) & "' "

                    Dim comandoPagoFamilia As New SqlCommand(bajaPagoFamilia, conexion)

                    'comandoPagoFamilia.ExecuteNonQuery()

                    If comandoPagoFamilia.ExecuteNonQuery() <> 0 Then

                        MessageBox.Show("Familia dada de baja exitosamente")
                        CbxCodigo.Text = ("")
                        CbxFamilia.Text = ("")
                        CargarFamilias()
                        CbxCodigo.Focus()

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
            opcion = MessageBox.Show("¿Realmente quiere reincorporar a ésta familia? " + vbCr + "Verifique datos a actualizar en los formularios de actualización de familias y actualización de alumnos", "¡Está a punto de reincorporar ésta familia!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        End If
        If (opcion = Windows.Forms.DialogResult.Yes) Then
            abrir()
            Dim reincorpora As String = "UPDATE familias SET  estado = 'Activo'
                                                                              
                                         WHERE codigo_familia='" & Me.CbxReincorporaCodigo.Text & "' "

            Dim comando As New SqlCommand(reincorpora, conexion)
            comando.ExecuteNonQuery()
            If comando.ExecuteNonQuery() = 1 Then

                Dim reincorporaHijos As String = "UPDATE alumnos SET  estado = 'Activo'
                                                                              
                                         WHERE codigo_familia='" & Me.CbxReincorporaCodigo.Text & "' "

                Dim comandoReincorpora As New SqlCommand(reincorporaHijos, conexion)
                comandoReincorpora.ExecuteNonQuery()


                MessageBox.Show("Familia reincorporada exitosamente")
                CbxReincorporaCodigo.Text = ("")
                CbxReincorporaFamilia.Text = ("")
                CargarFamilias()
                CbxCodigo.Focus()

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