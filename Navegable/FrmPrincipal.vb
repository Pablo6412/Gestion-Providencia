'Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class FrmPrincipal
    'Dim conexion As New MySqlConnection
    Dim comando As SqlCommand
    Dim comando2 As SqlCommand
    Dim adaptador As New SqlDataAdapter
    Dim fechaActual As Date = Date.Today
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        abrir()
        Dim fechaActual As Date = Date.Today

        Dim dia As Integer


        dia = CStr(fechaActual.Day)
        'MsgBox("" & Weekday(fechaActual) & "")
        If dia = 2 Then
            grabaVencimientos()
        End If
        If dia = 28 Or dia = 29 Or dia = 30 Then
            If Weekday(fechaActual) = 6 Then
                grabaVencimientos()
            End If

        End If
    End Sub
    Private Sub grabaVencimientos()
        Dim filas As Integer

        Dim CantFam As String = "SELECT COUNT (*) FROM gestion_providencia.familias"
        Dim comando1 As New SqlCommand(CantFam, conexion)
        filas = comando1.ExecuteScalar

        'MsgBox("" & filas & "")
        Dim codFam As Integer = 1028
        Dim TotalCuota As Decimal
        Dim totalCampamento As Decimal
        Dim totalTaller As Decimal
        Dim totalMateriales As Decimal
        Dim totalAdicional As Decimal
        Dim totalComedor As Decimal

        'Try
        While codFam <= 1033
            Dim consulta As String = "SELECT nombre_apellido_alumno, curso, valor_cuota, campamento_importe, taller_importe, materiales_importe, adicional_importe,comedor_importe from gestion_providencia.alumnos JOIN cursos on cursos.codigo_curso = gestion_providencia.alumnos.codigo_curso JOIN cuotas ON cuotas.codigo_alumno = gestion_providencia.alumnos.codigo_alumno JOIN taller ON taller.codigo_taller = gestion_providencia.alumnos.codigo_taller1  WHERE gestion_providencia.alumnos.codigo_familia = '" & codFam & "' "
            'Dim consulta As String = "SELECT nombre_apellido_alumno, curso, valor_cuota, campamento_importe, taller_importe, material_importe from gestion_providencia.alumnos JOIN cursos on cursos.codigo_curso = gestion_providencia.alumnos.codigo_curso JOIN cuotas ON cuotas.codigo_alumno = gestion_providencia.alumnos.codigo_alumno JOIN taller ON taller.codigo_taller = gestion_providencia.alumnos.codigo_taller1 JOIN material ON material.codigo_material = gestion_providencia.alumnos.codigo_material WHERE gestion_providencia.alumnos.codigo_familia = '" & Val(CbxCodigo.Text) & "' "
            'Dim consulta As String = "Select nombre_apellido_alumno, dni, curso, arancel_importe, valor_cuota, hermano_numero, fecha_ingreso from gestion_providencia.alumnos JOIN cursos On cursos.codigo_curso = gestion_providencia.alumnos.codigo_curso JOIN cuotas On cuotas.codigo_alumno = gestion_providencia.alumnos.codigo_alumno join Aranceles On aranceles.codigo_arancel = gestion_providencia.alumnos.codigo_arancel where gestion_providencia.alumnos.codigo_familia= '" & Val(CbxCodigo.Text) & "' "


            comando = New SqlCommand()
        comando.CommandText = consulta
        comando.CommandType = CommandType.Text
        comando.Connection = conexion
        adaptador = New SqlDataAdapter(comando)
        Dim dataSet As DataSet = New DataSet()
        adaptador.Fill(dataSet)


        For Each fila As DataRow In dataSet.Tables(0).Rows()
            TotalCuota += Val(fila(2))
        Next
            MsgBox("" & TotalCuota & "")
            For Each fila As DataRow In dataSet.Tables(0).Rows()
                totalCampamento += Val(fila(3))
            Next

            For Each fila As DataRow In dataSet.Tables(0).Rows()
                totalTaller += Val(fila(4))
            Next
            For Each fila As DataRow In dataSet.Tables(0).Rows()
                totalMateriales += Val(fila(5))
            Next

            For Each fila As DataRow In dataSet.Tables(0).Rows()
                totalAdicional += Val(fila(6))
            Next

            For Each fila As DataRow In dataSet.Tables(0).Rows()
                totalComedor += Val(fila(7))
            Next

            Dim vencimiento As String = "INSERT INTO detalle_vencimientos_escolares(codigo_familia, aranceles, materiales, talleres, campamento, adicional_jardin, comedor, fecha_vencimiento) VALUES(@codFam, @totalCuota, @totalMateriales, @totalTaller, @totalCampamento, @totalAdicional, @totalComedor, @fechaVencimiento)"

            comando2 = New SqlCommand(vencimiento, conexion)

            comando2.Parameters.AddWithValue("@codFam", codFam)
            comando2.Parameters.AddWithValue("@totalCuota", TotalCuota)
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

            codFam += 1

        End While ' 

        'DgvHijos.DataSource = dataSet.Tables(0).DefaultView

        'Catch ex As Exception
        '    MsgBox("Error comprobando BD" & ex.ToString)        'Si hay fayos se presentan detalles del mismo
        'End Try

        ''TxtMatricula.Focus()



        'Dim col As Integer = 2

        ''Dim Col As Integer = Me.DgvHijos.CurrentCell.ColumnIndex
        'For Each row TotalCuota += Val(row.Cells(col).Value)

        'Next


        'TxtArancel.PlaceholderText = TotalCuota
        '' TxtArancel.PlaceholderText = TotalCuota

        'Dim colCamp As Integer = 3

        ''Dim Col As Integer = Me.DgvHijos.CurrentCell.ColumnIndex
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalCampamento += Val(row.Cells(colCamp).Value)

        'Next

        'TxtCampamento.PlaceholderText = TotalCampamento


        'Dim colTaller As Integer = 4

        ''Dim Col As Integer = Me.DgvHijos.CurrentCell.ColumnIndex
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalTalleres += Val(row.Cells(colTaller).Value)

        'Next

        'TxtTalleres.PlaceholderText = TotalTalleres

        'Dim colMaterial As Integer = 5


        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalMaterial += Val(row.Cells(colMaterial).Value)

        'Next

        'TxtMateriales.PlaceholderText = TotalMaterial


        'Dim colAdicional As Integer = 6


        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalAdicional += Val(row.Cells(colAdicional).Value)

        'Next

        'TxtAdicionalJardin.PlaceholderText = TotalAdicional


        'Dim colComedor As Integer = 7


        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalComedor += Val(row.Cells(colComedor).Value)

        'Next

        'TxtComedor.PlaceholderText = TotalComedor
        'End If
        'contador += 1
        'TxtMatricula.Enabled = False
    End Sub


    'End Sub
    'MsgBox("" & fechaActual & "")


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked
    End Sub

    Private Sub TlsAltas_Click(sender As Object, e As EventArgs) Handles TlsAltasFamilias.Click
        FrmAltaFamilia.Show()
    End Sub

    Private Sub TlsModifFamilias_Click(sender As Object, e As EventArgs) Handles TlsModifFamilias.Click
        FrmActualizaFamilias.ShowDialog()
    End Sub

    Private Sub TlsBajasDeFamilias_Click(sender As Object, e As EventArgs) Handles TlsBajasDeFamilias.Click
        FrmBajasFamilias.ShowDialog()
    End Sub

    Private Sub TlsAltaAlumnos_Click(sender As Object, e As EventArgs) Handles TlsAltaAlumnos.Click
        FrmAltaAlumnos.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        End
    End Sub

    Public Sub BtnACercaDe_Click(sender As Object, e As EventArgs) Handles BtnACercaDe.Click

        BtnACercaDe.BackColor = System.Drawing.SystemColors.HotTrack
        MessageBox.Show("Versión del sistema: 2021. Realizado por Padres del colegio", "Gestión Providencia", MessageBoxButtons.OK, MessageBoxIcon.None)
        BtnACercaDe.BackColor = System.Drawing.SystemColors.MenuHighlight
    End Sub

    Private Sub TlsActualizacionAlumnos_Click(sender As Object, e As EventArgs) Handles TlsActualizacionAlumnos.Click
        FrmActualizaAlumnos.Show()
    End Sub

    Private Sub TlsBajaAlumnos_Click(sender As Object, e As EventArgs) Handles TlsBajaAlumnos.Click
        FrmBajaAlumnos.Show()
    End Sub

    Private Sub TlsIngresoDePagos_Click(sender As Object, e As EventArgs) Handles TlsIngresoDePagos.Click
        Pagos.Show()
    End Sub

    Private Sub TlsEnviaCorreo_Click(sender As Object, e As EventArgs) Handles TlsEnviaCorreo.Click
        FrmEnviaMail.Show()
    End Sub

    Private Sub TlsGastos_Click(sender As Object, e As EventArgs) Handles TlsGastos.Click
        FrmGastos.Show()
    End Sub

    Private Sub OtrosPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrosPagosToolStripMenuItem.Click
        FrmIngresoDePagos.Show()
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        'BtnConfiguracion.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Hide()

        FrmConfiguracion.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        FrmPruebaCbx.Show()

    End Sub

    Private Sub InscripciónATalleresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripciónATalleresToolStripMenuItem.Click
        FrmInscripcionTalleres.Show()
    End Sub

    Private Sub DescuentosYBecasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescuentosYBecasToolStripMenuItem.Click
        FrmDescuentosBecas.Show()
    End Sub


End Class