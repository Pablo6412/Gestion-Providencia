Imports System.Data.SqlClient

Public Class FrmEmisiónDeVencimientos
    Dim comando As SqlCommand
    Dim comando2 As SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim fechaActual As Date = Date.Today
    Dim codFam As Integer = 1
    Dim datos As DataSet
    Dim codigoAlumno As Integer
    Dim arancel As Decimal
    Dim totalCampamento As Decimal
    Dim totalTaller As Decimal
    Dim totalMateriales As Decimal
    Dim totalAdicional As Decimal
    Dim totalComedor As Decimal
    Dim totalArancel As Decimal
    'Dim fechaActual As Date
    Dim hermanoNumero As Integer
    Dim cuota As Decimal

    Dim descuentoHermano As Decimal
    Dim descuentoBeca As Decimal
    Dim descuentoEspecial As Decimal

    Private Sub BtnVencimientos_Click(sender As Object, e As EventArgs) Handles BtnVencimientos.Click
        conectar()
        abrir()
        grabaVencimientos()

    End Sub
    Private Sub grabaVencimientos()
        'Dim codFam As Integer
        Dim maxcod As Integer = 1

        'Dim CantFam As String = "SELECT COUNT (*) FROM familias"
        'Dim comando1 As New SqlCommand(CantFam, conexion)
        'filas = comando1.ExecuteScalar

        Dim maximocod As String = "SELECT MAX(codigo_familia) FROM familias"
        Dim comando1 As New SqlCommand(maximocod, conexion)
        maxcod = comando1.ExecuteScalar
        MsgBox("Maximo código" & maxcod & "")
        MsgBox("Codigo de familia" & codFam & "")

        'Try
        While codFam <= maxcod
            Dim consulta As String = " SELECT codigo_alumno, nombre_apellido_alumno, curso, arancel_importe, hermano_numero, campamento_importe, taller_importe, materiales_importe, adicional_importe, comedor_importe, descuento_beca, descuento from alumnos JOIN cursos On cursos.codigo_curso = alumnos.codigo_curso JOIN aranceles On aranceles.codigo_arancel = alumnos.codigo_arancel JOIN taller On taller.codigo_taller = alumnos.codigo_taller1 JOIN descuento_beca On descuento_beca.codigo_beca = alumnos.codigo_beca JOIN descuento_especial On descuento_especial.codigo_descuento_especial = alumnos.codigo_descuento WHERE alumnos.codigo_familia = '" & codFam & "' ORDER BY alumnos.codigo_alumno"

            '"SELECT nombre_apellido_alumno, curso, arancel_importe, hermano_numero, campamento_importe, taller_importe, materiales_importe, adicional_importe,comedor_importe, descuento, descuento_beca from alumnos JOIN cursos on cursos.codigo_curso = alumnos.codigo_curso JOIN aranceles ON aranceles.codigo_arancel = alumnos.codigo_arancel JOIN taller ON taller.codigo_taller = alumnos.codigo_taller1  JOIN descuento_especial  ON descuento_especial.codigo_familia = familias.codigo_familia JOIN descuento_beca ON descuento_beca.codigo_beca = familias.codigo_beca WHERE alumnos.codigo_familia = '" & codFam & "' ORDER BY alumnos.codigo_alumno"


            comando = New SqlCommand()
            comando.CommandText = consulta
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            adaptador = New SqlDataAdapter(comando)
            Dim dataSet As DataSet = New DataSet()
            adaptador.Fill(dataSet)


            For Each fila As DataRow In dataSet.Tables(0).Rows()

                codigoAlumno = Val(fila(0))
                arancel = Val(fila(3))
                totalArancel += Val(fila(3))
                hermanoNumero = fila(4)
                totalCampamento += Val(fila(5))
                totalTaller += Val(fila(6))
                totalMateriales += Val(fila(7))
                totalAdicional += Val(fila(8))
                totalComedor += Val(fila(9))
                CalculaCuota()

                MsgBox("Codigo Familia: " & codFam & " Codigo alumno: " & codigoAlumno & " descuento Herman0: " & descuentoHermano & " descuento beca: " & descuentoBeca & " descuento especial: " & descuentoEspecial & " arancel: " & arancel & " cuota: " & cuota & "")

                Dim valorCuota As String = " UPDATE cuotas SET valor_cuota = '" & cuota & "' WHERE codigo_alumno = '" & codigoAlumno & "' "
                Dim comando As New SqlCommand(valorCuota, conexion)
                comando.ExecuteNonQuery()

                If comando.ExecuteNonQuery() = 1 Then
                    'MessageBox.Show("Datos de cuota actualizados")

                Else
                    MsgBox("¡Error! Datos no guardados. Reinicie el programa e intente nuevamente")
                End If


                'MsgBox("código de familia:  " & codFam & "Hermano Número: " & hermanoNumero & " Arancel: " & arancel & " Campamento: " & totalCampamento & "")
                'MsgBox("" & Arancel & "")
                'MsgBox("" & totalCampamento & "")
            Next

            If hermanoNumero <> 0 Then
                Dim vencimiento As String = "INSERT INTO detalle_vencimientos_escolares(codigo_familia, aranceles, materiales, talleres, campamento, adicional_jardin, comedor, fecha_vencimiento) VALUES(@codFam, @totalCuota, @totalMateriales, @totalTaller, @totalCampamento, @totalAdicional, @totalComedor, @fechaVencimiento)"

                comando2 = New SqlCommand(vencimiento, conexion)

                comando2.Parameters.AddWithValue("@codFam", codFam)
                comando2.Parameters.AddWithValue("@totalCuota", arancel)
                comando2.Parameters.AddWithValue("@totalMateriales", totalMateriales)
                comando2.Parameters.AddWithValue("@totalTaller", totalTaller)
                comando2.Parameters.AddWithValue("@totalCampamento", totalCampamento)
                comando2.Parameters.AddWithValue("@totalAdicional", totalMateriales)
                comando2.Parameters.AddWithValue("@totalComedor", totalComedor)
                comando2.Parameters.AddWithValue("@fechaVencimiento", fechaActual)

                If comando2.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Datos guardados")

                Else
                    MsgBox("No grabó nada")
                End If




                arancel = 0
                hermanoNumero = 0
                totalCampamento = 0
                totalTaller = 0
                totalMateriales = 0
                totalAdicional = 0
                totalComedor = 0
            End If
            codFam += 1

        End While


    End Sub

    Private Sub CalculaCuota()

        'Descuento que corresponde según número de hermano

        If hermanoNumero <> 0 Then
            Dim descuentoPorHermano As String = "SELECT descuento_hermano FROM descuento_hermano where hermano_numero = '" & hermanoNumero & "' "
            adaptador = New SqlDataAdapter(descuentoPorHermano, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_hermano")
            adaptador.Fill(datos.Tables("descuento_hermano"))
            If hermanoNumero > 6 Then
                descuentoHermano = 0.5
                'MsgBox("descuento hermano: " & descuentoHermano & "")
            Else
                descuentoHermano = datos.Tables("descuento_hermano").Rows(0).Item("descuento_hermano")
                'MsgBox("descuento Hermano: " & descuentoHermano & "")
            End If

        End If
        'MsgBox("codigoAl: " & codigoAlumno & "")
        'Descuento por beca que corresponde a la familia.
        Dim codigoBeca As Integer
        Dim codBeca As String = "SELECT codigo_beca FROM alumnos where codigo_alumno = '" & codigoAlumno & "'"
        Dim comando As New SqlCommand(codBeca, conexion)
        codigoBeca = comando.ExecuteScalar
        'MsgBox("codigo beca: " & codigoBeca & "")

        If codigoBeca <> 0 Then
            Dim tipoBeca As String = "SELECT descuento_beca FROM descuento_beca where codigo_beca = '" & codigoBeca & "' "
            adaptador = New SqlDataAdapter(tipoBeca, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_beca")
            adaptador.Fill(datos.Tables("descuento_beca"))
            descuentoBeca = datos.Tables("descuento_beca").Rows(0).Item("descuento_beca")
            'MsgBox("descuento beca: " & descuentoBeca & "")

        Else
            descuentoBeca = 1
        End If

        Dim filasTabla As Integer

        abrir()
        'Se busca en la tabla descuento_especial si la familia seleccionada tiene algún descuento de amigo
        Dim sql As String = "SELECT COUNT(*) " &
                           "FROM descuento_especial " &
                           "WHERE codigo_familia ='" & codFam & "'"

        Dim comando4 As New SqlCommand(sql, conexion)
        filasTabla = comando4.ExecuteScalar

        'Si encuentra descuento para la familia
        If filasTabla <> 0 Then

            Dim descEspecial As String = "SELECT descuento FROM descuento_especial WHERE codigo_familia = '" & codFam & "' "
            adaptador = New SqlDataAdapter(descEspecial, conexion)
            datos = New DataSet
            datos.Tables.Add("descuento_especial")
            adaptador.Fill(datos.Tables("descuento_especial"))

            descuentoEspecial = datos.Tables("descuento_especial").Rows(0).Item("descuento")
            'TxtPrueba.Text = descuentoEspecial
            'MsgBox("descuento especial: " & descuentoEspecial & "")
        Else
            descuentoEspecial = 1
            'TxtPrueba.Text = descuentoEspecial
            'MsgBox("descuento especial: " & descuentoEspecial & "")
        End If
        'MsgBox("Arancel: " & arancel & "")
        cuota = arancel * descuentoHermano * descuentoEspecial * descuentoBeca
        'TxtCuota.Text = cuota
        'MsgBox("cuota: " & cuota & "")

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmEmisiónDeVencimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class