Imports System.Data.SqlClient

Public Class FrmPagoAdelantado
    Dim totalCuota As Decimal
    Dim totalCampamento As Decimal
    Dim cuotaMensual As Decimal
    Dim numeroCuotas As Integer
    Private Sub FrmPagoAdelantado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()

        Try
            Dim familia As String = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, 
                                       CONCAT(apellido_padre,' - ', apellido_madre) AS familia, estado 
                                       FROM familias WHERE estado = 'activo' 
                                       ORDER BY familia"

            Dim adaptadorFamilia = New SqlDataAdapter(familia, conexion)
            Dim datosFamilia = New DataSet
            datosFamilia.Tables.Add("familias")
            adaptadorFamilia.Fill(datosFamilia.Tables("familias"))

            CbxFamilia.DataSource = datosFamilia.Tables("familias")
            CbxFamilia.DisplayMember = "familia"
            CbxCodigo.DataSource = datosFamilia.Tables("familias")
            CbxCodigo.DisplayMember = "codigo_familia"

        Catch ex As Exception
            MsgBox("Error comprobando BD" & ex.ToString)
        End Try
    End Sub

    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged

        totalCuota = 0
        totalCampamento = 0
        Dim ultimoVencimiento
        'TxtCuota.Text = "0"
        'TxtCampamento.Text = "0"
        'MsgBox("¿Pasa por acá?")
        Dim maxFecha As String = "SELECT MAX(fecha_vencimiento) AS fecha FROM vencimiento_detallado"
        Dim comandoFecha As New SqlCommand(maxFecha, conexion)
        ultimoVencimiento = comandoFecha.ExecuteScalar

        Dim consulta As String = "SELECT nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, talleres_alumno,
                                          materiales_alumno, adicional_alumno, comedor_alumno
                                          FROM alumnos 
                                          JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                                          JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno  
                                          WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_vencimiento = '" & ultimoVencimiento & "' AND alumnos.estado = 'activo' "

        Dim comando As New SqlCommand(consulta, conexion)
        Dim adaptador As New SqlDataAdapter(comando)
        Dim dataSet As New DataSet()
        adaptador.Fill(dataSet)

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalCuota += Val(fila(3))
            TxtCuota.Text = totalCuota
        Next

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalCampamento += Val(fila(4)) '
            TxtCampamento.Text = totalCampamento
        Next

        CkbCuota.Checked = False
        CkbCampamento.Checked = False
    End Sub

    Private Sub CbxCuotas_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCuotas.SelectedValueChanged
        cuotaMensual = Val(TxtTotal.Text)
        numeroCuotas = Val(CbxCuotas.Text)
        TxtMontolAdelanto.Text = cuotaMensual * numeroCuotas
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If CkbCuota.Checked = False And CkbCampamento.Checked = False Then
            MsgBox("Debe elegir al menos una opción")
        ElseIf CbxCuotas.Text = "" Then
            MsgBox("Debe elegir una cantidad de meses a adelantar")
        ElseIf Val(TxtMontolAdelanto.Text) = 0 Then
            MsgBox("No hay monto para adelantar")
        Else
            Dim guardaAdelanto As String = "INSERT INTO pago_adelantado(codigo_familia, cantidad_cuotas, monto, cuotas_restantes ) 
                                        VALUES(@codigo_familia, @cantidad_cuotas, @monto, @cuotas_restantes) "
            Dim comandoAdelanto As New SqlCommand(guardaAdelanto, conexion)

            comandoAdelanto.Parameters.AddWithValue("@codigo_familia", Val(CbxCodigo.Text))
            comandoAdelanto.Parameters.AddWithValue("@cantidad_cuotas", Val(CbxCuotas.Text))
            comandoAdelanto.Parameters.AddWithValue("@monto", Val(TxtMontolAdelanto.Text))
            comandoAdelanto.Parameters.AddWithValue("@cuotas_restantes", Val(CbxCuotas.Text))

            If comandoAdelanto.ExecuteNonQuery() = 1 Then

                Dim si As String = "UPDATE familias SET pago_adelantado = 'si' WHERE codigo_familia = " & Val(CbxCodigo.Text) & " "
                Dim comandoSi As New SqlCommand(si, conexion)
                If comandoSi.ExecuteNonQuery() = 1 Then
                    MsgBox("Datos guardados")

                Else
                    MsgBox("Error guardando los datos")
                End If
            Else
                MsgBox("Error guardando los datos")
            End If
        End If
    End Sub

    Private Sub CkbCuota_CheckedChanged(sender As Object, e As EventArgs) Handles CkbCuota.CheckedChanged
        If CkbCuota.Checked = True And CkbCampamento.Checked = True Then
            TxtTotal.Text = (totalCuota + totalCampamento)

        ElseIf CkbCuota.Checked = True And CkbCampamento.Checked = False Then
            TxtTotal.Text = (totalCuota)

        ElseIf CkbCuota.Checked = False And CkbCampamento.Checked = True Then
            TxtTotal.Text = (totalCampamento)

        Else
            TxtTotal.Text = 0
        End If
        TxtMontolAdelanto.Text = Val(TxtTotal.Text) * numeroCuotas
    End Sub

    Private Sub CkbCampamento_CheckStateChanged(sender As Object, e As EventArgs) Handles CkbCampamento.CheckStateChanged
        If CkbCuota.Checked = True And CkbCampamento.Checked = True Then
            TxtTotal.Text = (totalCuota + totalCampamento)

        ElseIf CkbCuota.Checked = True And CkbCampamento.Checked = False Then
            TxtTotal.Text = (totalCuota)

        ElseIf CkbCuota.Checked = False And CkbCampamento.Checked = True Then
            TxtTotal.Text = (totalCampamento)

        Else
            TxtTotal.Text = 0
        End If
        TxtMontolAdelanto.Text = Val(TxtTotal.Text) * numeroCuotas
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class