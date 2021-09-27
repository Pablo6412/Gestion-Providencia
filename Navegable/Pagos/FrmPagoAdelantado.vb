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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged
        Dim ultimoVencimiento
        Dim totalMatricula
        Dim maxFecha As String = "SELECT MAX(fecha_vencimiento) AS fecha FROM vencimiento_detallado"
        Dim comandoFecha As New SqlCommand(maxFecha, conexion)
        ultimoVencimiento = comandoFecha.ExecuteScalar



        Dim consulta As String = "SELECT nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, talleres_alumno,
                                          materiales_alumno, adicional_alumno, comedor_alumno
                                          FROM alumnos 
                                          JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
                                          JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno  
                                          WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_vencimiento = '" & ultimoVencimiento & "' And alumnos.estado = 'activo' "

            Dim comando As New SqlCommand()
            comando.CommandText = consulta
            comando.CommandType = CommandType.Text
            comando.Connection = conexion
            Dim adaptador As New SqlDataAdapter(comando)
            Dim dataSet As DataSet = New DataSet()
            adaptador.Fill(dataSet)

            'DgvHijos.DataSource = dataSet.Tables(0).DefaultView



            Dim colMatricula As Integer = 2
        For Each fila As DataRow In dataSet.Tables(0).Rows()
            totalMatricula += Val(fila(3))
            TxtCuotaMensual.Text = totalMatricula
            'totalMatricula += Val(row.Cells(colMatricula).Value)
        Next
        'TxtMatricula.PlaceholderText = totalMatricula
        'matricula = totalMatricula

        'Dim col As Integer = 3
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalCuota += Val(row.Cells(col).Value)
        'Next
        'TxtArancel.PlaceholderText = TotalCuota
        'arancel = TotalCuota

        'Dim colCamp As Integer = 4
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalCampamento += (Val(row.Cells(colCamp).Value))
        'Next
        'TxtCampamento.PlaceholderText = TotalCampamento
        'campamento = TotalCampamento

        'Dim colTaller As Integer = 5
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalTalleres += Val(row.Cells(colTaller).Value)
        'Next
        'TxtTalleres.PlaceholderText = TotalTalleres
        'talleres = TotalTalleres

        'Dim colMaterial As Integer = 6
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalMaterial += Val(row.Cells(colMaterial).Value)
        'Next
        'TxtMateriales.PlaceholderText = TotalMaterial
        'materiales = TotalMaterial

        'Dim colAdicional As Integer = 7
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalAdicional += Val(row.Cells(colAdicional).Value)
        'Next
        'TxtAdicional.PlaceholderText = TotalAdicional
        'adicional = TotalAdicional

        'Dim colComedor As Integer = 8
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalComedor += Val(row.Cells(colComedor).Value)
        'Next
        'mes = fechaActual.Month
        'parImpar = mes Mod 2
        'If parImpar <> 0 Then
        '    TxtComedor.PlaceholderText = TotalComedor
        '    comedor = TotalComedor
        'Else
        '    TxtComedor.PlaceholderText = 0
        '    comedor = 0
        '    TotalComedor = comedor
        'End If
        'End If
        'contador += 1
        'TxtMatricula.Enabled = False

        'Dim tablaExiste() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}
        'Dim datat As DataTable = conexion.GetSchema("TABLES", restrictionValues)
        'Dim rowss() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")

        'If rowss.Length > 0 Then
        '    'MessageBox.Show("Existe la tabla.")
        '    Dim destruyeTabla As String = "DROP TABLE taller_temporal"
        '    Dim comandoDestruye As New SqlCommand(destruyeTabla, conexion)
        '    'MsgBox("Tabla destruida")

        '    If comandoDestruye.ExecuteNonQuery() = 0 Then
        '        MsgBox("No pasa nada")
        '    End If
        'End If
    End Sub
End Class