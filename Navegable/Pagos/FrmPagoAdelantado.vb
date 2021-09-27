Imports System.Data.SqlClient



Public Class FrmPagoAdelantado

    Private Sub FrmPagoAdelantado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        abrir()
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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged
        Dim ultimoVencimiento
        Dim totalMatricula As Decimal
        Dim totalCuota As Decimal
        Dim totalCampamento As Decimal
        Dim totalTalleres As Decimal
        Dim totalMateriales As Decimal
        Dim totalAdicional As Decimal
        Dim totalComedor As Decimal
        Dim maxFecha As String = "SELECT MAX(fecha_vencimiento) AS fecha FROM vencimiento_detallado"
        Dim comandoFecha As New SqlCommand(maxFecha, conexion)
        ultimoVencimiento = comandoFecha.ExecuteScalar



        Dim consulta As String = "SELECT nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, talleres_alumno,
                                          materiales_alumno, adicional_alumno, comedor_alumno
                                          FROM alumnos 
                                          JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                                          JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno  
                                          WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_vencimiento = '" & ultimoVencimiento & "' And alumnos.estado = 'activo' "

        Dim comando As New SqlCommand(consulta, conexion)
        Dim adaptador As New SqlDataAdapter(comando)
        Dim dataSet As New DataSet()
        adaptador.Fill(dataSet)

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalMatricula += Val(fila(2))
        Next

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalCuota += Val(fila(3))
        Next

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalCampamento += Val(fila(4))
        Next

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalTalleres += Val(fila(5))
        Next

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalMateriales += Val(fila(6))
        Next

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalAdicional += Val(fila(7))
        Next

        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalComedor += Val(fila(8))
        Next

        TxtCuotaMensual.Text = (totalMatricula + totalCuota + totalCampamento + totalTalleres + totalMateriales + totalAdicional + totalComedor)

    End Sub

    Private Sub CbxCuotas_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCuotas.SelectedValueChanged
        Dim cuotaMensual As Decimal = Val(TxtCuotaMensual.Text)
        Dim numeroCuotas As Integer = Val(CbxCuotas.Text)
        TxtTotal.Text = cuotaMensual * numeroCuotas
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim guardaAdelanto As String = "INSERT INTO pago_adelantado(codigo_familia, cantidad_cuotas, monto) 
                                        VALUES(@codigo_familia, @cantidad_cuotas, @monto) "
        Dim comandoAdelanto As New SqlCommand(guardaAdelanto, conexion)

        comandoAdelanto.Parameters.AddWithValue("@codigo_familia", Val(CbxCodigo.Text))
        comandoAdelanto.Parameters.AddWithValue("@cantidad_cuotas", Val(CbxCuotas.Text))
        comandoAdelanto.Parameters.AddWithValue("@monto", Val(TxtTotal.Text))

        If comandoAdelanto.ExecuteNonQuery() = 1 Then
            MsgBox("Datos guardados")
        Else
            MsgBox("Error guardando los datos")
        End If
    End Sub
End Class