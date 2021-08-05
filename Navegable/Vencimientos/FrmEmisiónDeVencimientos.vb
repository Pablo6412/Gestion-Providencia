Imports System.Data.SqlClient

Public Class FrmEmisiónDeVencimientos
    Dim comando As SqlCommand
    Dim comando2 As SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim fechaActual As Date = Date.Today



    Private Sub BtnVencimientos_Click(sender As Object, e As EventArgs) Handles BtnVencimientos.Click
        conectar()
        abrir()
        grabaVencimientos()

    End Sub
    Private Sub grabaVencimientos()
        Dim filas As Integer

        Dim CantFam As String = "SELECT COUNT (*) FROM gestion_providencia.familias"
        Dim comando1 As New SqlCommand(CantFam, conexion)
        filas = comando1.ExecuteScalar

        'MsgBox("" & filas & "")
        Dim codFam As Integer = 1028
        Dim TotalArancel As Decimal
        Dim totalCampamento As Decimal
        Dim totalTaller As Decimal
        Dim totalMateriales As Decimal
        Dim totalAdicional As Decimal
        Dim totalComedor As Decimal

        'Try
        While codFam <= 1033
            Dim consulta As String = "SELECT nombre_apellido_alumno, curso, arancel_importe, campamento_importe, taller_importe, materiales_importe, adicional_importe,comedor_importe from gestion_providencia.alumnos JOIN cursos on cursos.codigo_curso = gestion_providencia.alumnos.codigo_curso JOIN aranceles ON aranceles.codigo_arancel = gestion_providencia.alumnos.codigo_arancel JOIN taller ON taller.codigo_taller = gestion_providencia.alumnos.codigo_taller1  WHERE gestion_providencia.alumnos.codigo_familia = '" & codFam & "' ORDER BY gestion_providencia.alumnos.codigo_alumno"


            comando = New SqlCommand()
            comando.CommandText = consulta
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            adaptador = New SqlDataAdapter(comando)
            Dim dataSet As DataSet = New DataSet()
            adaptador.Fill(dataSet)


            For Each fila As DataRow In dataSet.Tables(0).Rows()
                TotalArancel = Val(fila(2))


                MsgBox("" & TotalArancel & "")
            Next

            'For Each fila As DataRow In dataSet.Tables(0).Rows()
            '    totalCampamento += Val(fila(3))
            'Next

            'For Each fila As DataRow In dataSet.Tables(0).Rows()
            '    totalTaller += Val(fila(4))
            'Next
            'For Each fila As DataRow In dataSet.Tables(0).Rows()
            '    totalMateriales += Val(fila(5))
            'Next

            'For Each fila As DataRow In dataSet.Tables(0).Rows()
            '    totalAdicional += Val(fila(6))
            'Next

            'For Each fila As DataRow In dataSet.Tables(0).Rows()
            '    totalComedor += Val(fila(7))
            'Next







            '    Dim vencimiento As String = "INSERT INTO detalle_vencimientos_escolares(codigo_familia, aranceles, materiales, talleres, campamento, adicional_jardin, comedor, fecha_vencimiento) VALUES(@codFam, @totalCuota, @totalMateriales, @totalTaller, @totalCampamento, @totalAdicional, @totalComedor, @fechaVencimiento)"

            '    comando2 = New SqlCommand(vencimiento, conexion)

            '    comando2.Parameters.AddWithValue("@codFam", codFam)
            '    comando2.Parameters.AddWithValue("@totalCuota", TotalArancel)
            '    comando2.Parameters.AddWithValue("@totalMateriales", totalMateriales)
            '    comando2.Parameters.AddWithValue("@totalTaller", totalTaller)
            '    comando2.Parameters.AddWithValue("@totalCampamento", totalCampamento)
            '    comando2.Parameters.AddWithValue("@totalAdicional", totalMateriales)
            '    comando2.Parameters.AddWithValue("@totalComedor", totalComedor)
            '    comando2.Parameters.AddWithValue("@fechaVencimiento", fechaActual)

            '    If comando2.ExecuteNonQuery() = 1 Then
            '        MessageBox.Show("Datos guardados")

            '    Else
            '        MsgBox("No grabó nada")
            '    End If

            codFam += 1

        End While ' 


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class