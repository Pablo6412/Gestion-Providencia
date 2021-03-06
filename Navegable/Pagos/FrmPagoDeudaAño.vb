Imports System.Data.SqlClient

Public Class FrmPagoDeudaAño
    Dim fechaActualPP As Date = Date.Today
    Dim fecha As Date
    Dim fecha1 As Date
    Dim fecha2 As Date
    Dim fecha3 As Date
    Dim fecha4 As Date
    Dim fecha5 As Date
    Dim fecha6 As Date
    Dim fecha7 As Date
    Dim fecha8 As Date
    Dim fecha9 As Date
    Dim fecha10 As Date
    Dim fecha11 As Date
    Dim fecha12 As Date
    Dim deuda As Decimal
    Dim resultado As Decimal
    Dim mesesDeuda() As Date
    Dim indiceArrayMeses As Integer
    Dim contador As Integer = 0


    Private Sub FrmPagoDeudaAño_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conectar()
        BuscaFamilia()
        Datagrid()
        LblFecha.Text = Date.Now.ToLongDateString
    End Sub

    Private Sub BuscaFamilia()
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
        PagoMes(fecha)
    End Sub

    Public Sub Datagrid()
        Dim mes
        Dim matricula As Decimal
        Dim arancel As Decimal
        Dim materiales As Decimal
        Dim talleres As Decimal
        Dim campamento As Decimal
        Dim adicional As Decimal
        Dim comedor As Decimal
        Dim totalMatricula As Decimal
        Dim TotalCuota As Decimal
        Dim TotalCampamento As Decimal
        Dim TotalTalleres As Decimal
        Dim TotalMaterial As Decimal
        Dim TotalAdicional As Decimal
        Dim TotalComedor As Decimal
        Dim totalConceptos As Decimal
        Dim mesPago As Integer
        Dim parImpar As Integer



        Dim ultimoVencimiento As Date

        Dim restrictionValues() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}
        Dim dt As DataTable = conexion.GetSchema("TABLES", restrictionValues)
        Dim rows() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")
        CreaTablaTemporal(rows)

        Dim maxFecha As String = "SELECT MAX(fecha_vencimiento) AS fecha FROM vencimiento_detallado"
        Dim comandoFecha As New SqlCommand(maxFecha, conexion)
        ultimoVencimiento = comandoFecha.ExecuteScalar

        If contador <> 0 Then
            totalMatricula = 0
            TotalCuota = 0
            TotalCampamento = 0
            TotalTalleres = 0
            TotalMaterial = 0
            TotalAdicional = 0
            TotalComedor = 0
            totalConceptos = 0

            Try

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

                DgvHijos.DataSource = dataSet.Tables(0).DefaultView

            Catch ex As Exception
                MsgBox("Error comprobando BD" & ex.ToString)
            End Try

            Dim colMatricula As Integer = 3
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                totalMatricula += Val(row.Cells(colMatricula).Value)
            Next
            'TxtMatricula.PlaceholderText = totalMatricula
            matricula = totalMatricula

            Dim col As Integer = 4
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalCuota += Val(row.Cells(col).Value)
            Next
            'TxtArancel.PlaceholderText = TotalCuota
            arancel = TotalCuota

            Dim colCamp As Integer = 5
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalCampamento += (Val(row.Cells(colCamp).Value))
            Next
            'TxtCampamento.PlaceholderText = TotalCampamento
            campamento = TotalCampamento

            Dim colTaller As Integer = 6
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalTalleres += Val(row.Cells(colTaller).Value)
            Next
            'TxtTalleres.PlaceholderText = TotalTalleres
            talleres = TotalTalleres

            Dim colMaterial As Integer = 7
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalMaterial += Val(row.Cells(colMaterial).Value)
            Next
            'TxtMateriales.PlaceholderText = TotalMaterial
            materiales = TotalMaterial

            Dim colAdicional As Integer = 8
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalAdicional += Val(row.Cells(colAdicional).Value)
            Next
            'TxtAdicional.PlaceholderText = TotalAdicional
            adicional = TotalAdicional

            Dim colComedor As Integer = 9
            For Each row As DataGridViewRow In Me.DgvHijos.Rows
                TotalComedor += Val(row.Cells(colComedor).Value)
            Next
            mes = fechaActualPP.Month
            parImpar = mes Mod 2
            If parImpar <> 0 Then
                'TxtComedor.PlaceholderText = TotalComedor
                comedor = TotalComedor
            Else
                'TxtComedor.PlaceholderText = 0
                comedor = 0
                TotalComedor = comedor
            End If
        End If
        contador += 1
        'TxtMatricula.Enabled = False

        Dim tablaExiste() As String = {Nothing, Nothing, Nothing, "BASE TABLE"}
        Dim datat As DataTable = conexion.GetSchema("TABLES", restrictionValues)
        Dim rowss() As DataRow = dt.Select("TABLE_NAME = 'Taller_temporal'")

        If rowss.Length > 0 Then
            'MessageBox.Show("Existe la tabla.")
            Dim destruyeTabla As String = "DROP TABLE taller_temporal"
            Dim comandoDestruye As New SqlCommand(destruyeTabla, conexion)
            'MsgBox("Tabla destruida")

            If comandoDestruye.ExecuteNonQuery() = 0 Then
                MsgBox("No pasa nada")
            End If
        End If
    End Sub

    Private Sub CreaTablaTemporal(rows)

        If rows.Length > 0 Then
            'MessageBox.Show("Existe la tabla.")
        Else
            Dim tallerTemp As String = "SELECT codigo_alumno, SUM(importe_taller) as importe_taller INTO taller_temporal 
                                        FROM taller_alumno  GROUP BY codigo_alumno"
            Dim comandoTaller As New SqlCommand(tallerTemp, conexion)
            comandoTaller.ExecuteNonQuery()

            'MsgBox("Tabla creada")
            'MessageBox.Show("No existe la tabla.")
        End If

        'Try

        '    Dim pago As String = "SELECT nombre_apellido_alumno, curso, matricula_alumno, cuota_alumno, campamento_alumno, talleres_alumno,
        '                                  materiales_alumno, adicional_alumno, comedor_alumno
        '                                  FROM alumnos 
        '                                  JOIN cursos ON cursos.codigo_curso = alumnos.codigo_curso 
        '                                  JOIN vencimiento_detallado ON alumnos.codigo_alumno = vencimiento_detallado.codigo_alumno  
        '                                  WHERE alumnos.codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_vencimiento = '" & mes & "' And alumnos.estado = 'activo' "

        '    Dim comandoPago As New SqlCommand(pago, conexion)

        '    comandoPago.CommandType = CommandType.Text

        '    Dim adaptador As New SqlDataAdapter(comandoPago)
        '    Dim dataSet As DataSet = New DataSet()
        '    adaptador.Fill(dataSet)

        '    DgvHijos.DataSource = dataSet.Tables(0).DefaultView

        'Catch ex As Exception
        '    MsgBox("Error comprobando BD" & ex.ToString)
        'End Try

        'Dim colMatricula As Integer = 3
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    totalMatricula += Val(row.Cells(colMatricula).Value)
        'Next
        'matricula = totalMatricula

        'Dim col As Integer = 4
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalCuota += Val(row.Cells(col).Value)
        'Next
        'arancel = TotalCuota

        'Dim colCamp As Integer = 5
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalCampamento += (Val(row.Cells(colCamp).Value))
        'Next
        'campamento = TotalCampamento

        'Dim colTaller As Integer = 6
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalTalleres += Val(row.Cells(colTaller).Value)
        'Next
        'talleres = TotalTalleres

        'Dim colMaterial As Integer = 7
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalMaterial += Val(row.Cells(colMaterial).Value)
        'Next
        'materiales = TotalMaterial

        'Dim colAdicional As Integer = 8
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalAdicional += Val(row.Cells(colAdicional).Value)
        'Next
        'adicional = TotalAdicional

        'Dim colComedor As Integer = 9
        'For Each row As DataGridViewRow In Me.DgvHijos.Rows
        '    TotalComedor += Val(row.Cells(colComedor).Value)
        'Next
        'mesPago = mes.Month
        'parImpar = mesPago Mod 2
        'If parImpar <> 0 Then
        '    comedor = TotalComedor
        'Else
        '    comedor = 0
        '    TotalComedor = comedor
        'End If
    End Sub

    Private Sub DgvHijos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHijos.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 0 Then
            Dim grid = CType(sender, DataGridView)
            If grid(e.ColumnIndex, e.RowIndex).Value Then
                grid.CancelEdit()
            Else
                For Each row In grid.Rows.Cast(Of DataGridViewRow).Where(Function(r) r.Cells(e.ColumnIndex).Value)
                    row.Cells(e.ColumnIndex).Value = False
                Next
            End If
            If grid.IsCurrentCellInEditMode Then
                grid.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        End If
    End Sub
    Private Sub Checked()
        'Dim meses As Date
        Dim numeroMes
        Dim nombreMes
        Dim nombreMesAnt

        Dim consulta As String = "SELECT codigo_familia, isnull(periodo_de_pago, '') As fechaPago, pago_cumplido FROM pago_detallado WHERE codigo_familia = " & Val(CbxCodigo.Text) & " and pago_cumplido <> 'completo' "
        Dim adaptador As SqlDataAdapter = New SqlDataAdapter(consulta, conexion)
        Dim dtDatos As DataTable = New DataTable
        adaptador.Fill(dtDatos)

        Dim dataSet As New DataSet()
        adaptador.Fill(dataSet)
        If dtDatos.Rows.Count <> 0 Then

            'ClbMeses.DataSource = dtDatos
            'ClbMeses.DisplayMember = "fecha_de_pago"

            For Each fila As DataRow In dataSet.Tables(0).Rows()
                fecha = (fila(1))
                numeroMes = fecha.Month
                Select Case numeroMes
                    Case 1
                        nombreMes = "Enero"
                        fecha1 = fecha
                    Case 2
                        nombreMes = "Febrero"
                        fecha2 = fecha
                    Case 3
                        nombreMes = "Marzo"
                        fecha3 = fecha
                    Case 4
                        nombreMes = "Abril"
                        fecha4 = fecha
                    Case 5
                        nombreMes = "Mayo"
                        fecha5 = fecha
                    Case 6
                        nombreMes = "Junio"
                        fecha6 = fecha
                    Case 7
                        nombreMes = "Julio"
                        fecha7 = fecha
                    Case 8
                        nombreMes = "Agosto"
                        fecha8 = fecha
                    Case 9
                        nombreMes = "Septiembre"
                        fecha9 = fecha
                    Case 10
                        nombreMes = "Octubre"
                        fecha10 = fecha
                    Case 11
                        nombreMes = "Noviembre"

                        fecha11 = fecha
                    Case 12
                        nombreMes = "Diciembre"
                        fecha12 = fecha
                End Select

                If nombreMes <> nombreMesAnt Then
                    ClbMeses.Items.Add(nombreMes)
                    ClbMeses.SelectedValue = fecha
                    MontoDeuda(fecha)
                End If
                nombreMesAnt = nombreMes
            Next
        End If
        CompruebaDeuda()
    End Sub
    Private Sub CbxCodigo_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxCodigo.SelectedValueChanged
        TxtTotal.Clear()
        BtnPago.Enabled = True
        ClbMeses.Items.Clear()
        ListBox1.Items.Clear()
        Checked()
        Datagrid()
        LblTotalAlumno.Text = 0
    End Sub

    Public Sub CompruebaDeuda()

        'Try
        '    Dim familia As String = "SELECT codigo_familia, apellido_padre, nombre_padre, apellido_madre, nombre_madre, 
        '                                   CONCAT(apellido_padre,' - ', apellido_madre) AS familia, estado 
        '                                   FROM familias WHERE estado = 'activo' 
        '                                   ORDER BY familia"

        '    Dim adaptadorFamilia = New SqlDataAdapter(familia, conexion)
        '    Dim datosFamilia = New DataSet
        '    datosFamilia.Tables.Add("familias")
        '    adaptadorFamilia.Fill(datosFamilia.Tables("familias"))





        '    CbxFamilia.DataSource = datosFamilia.Tables("familias")
        '    CbxFamilia.DisplayMember = "familia"
        '    CbxCodigo.DataSource = datosFamilia.Tables("familias")
        '    CbxCodigo.DisplayMember = "codigo_familia"

        'Catch ex As Exception
        '    MsgBox("Error comprobando BD" & ex.ToString)
        'End Try
        Dim deudaNo As Integer

        Dim deudaSioNo As String = "SELECT COUNT(pago_cumplido) AS pago_cumplido 
                                        FROM pago_detallado 
                                        WHERE pago_cumplido <> 'completo'  AND codigo_familia = " & Val(CbxCodigo.Text) & ""


        Dim adaptadorDeuda As New SqlDataAdapter(deudaSioNo, conexion)
        Dim dtDatos As New DataTable
        adaptadorDeuda.Fill(dtDatos)

        If dtDatos.Rows.Count > 0 Then
            deudaNo = dtDatos.Rows(0)("pago_cumplido")

            If contador <> 0 Then
                If deudaNo = 0 Then
                    MsgBox("La familia " & CbxFamilia.Text & " No presenta deudas del año en curso")
                End If
            Else
                contador += 1
            End If
        End If
    End Sub

    Private Sub ClbMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClbMeses.SelectedIndexChanged
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim Valor As String
        Dim indice As Integer
        Dim indice2 As Integer
        Dim suma As Integer

        indice = ClbMeses.SelectedIndex
        indice2 = ClbMeses.Items.Count

        'ListBox1.Items.Clear()


        For k = indice + 1 To indice2 - 1
            ClbMeses.SetItemChecked(k, False)
        Next

        For j = 0 To indice - 1
            ClbMeses.SetItemChecked(j, True)

        Next

        indiceArrayMeses = 0
        ReDim mesesDeuda(ClbMeses.Items.Count - 1)
        For i = 0 To Me.ClbMeses.CheckedItems.Count - 1
            Valor = ClbMeses.CheckedItems(i)
            'MsgBox("La casilla chekeada es " & Valor & "") ''Valor contiene el contenido del item chequeado
            If Valor = "Enero" Then
                fecha = fecha1
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha1
                indiceArrayMeses += 1
            ElseIf Valor = "Febrero" Then
                fecha = fecha2
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha2
                indiceArrayMeses += 1
            ElseIf Valor = "Marzo" Then
                fecha = fecha3
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha3
                indiceArrayMeses += 1
            ElseIf Valor = "Abril" Then
                fecha = fecha4
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha4
                indiceArrayMeses += 1
            ElseIf Valor = "Mayo" Then
                fecha = fecha5
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha5
                indiceArrayMeses += 1
            ElseIf Valor = "Junio" Then
                fecha = fecha6
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha6
                indiceArrayMeses += 1
            ElseIf Valor = "Julio" Then
                fecha = fecha7
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha7
                indiceArrayMeses += 1
            ElseIf Valor = "Agosto" Then
                fecha = fecha8
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha8
                indiceArrayMeses += 1
            ElseIf Valor = "Septiembre" Then
                fecha = fecha9
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha9
                indiceArrayMeses += 1
            ElseIf Valor = "Octubre" Then
                fecha = fecha10
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha10
                indiceArrayMeses += 1
            ElseIf Valor = "Octubre" Then
                fecha = fecha11
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha11
                indiceArrayMeses += 1
            ElseIf Valor = "Octubre" Then
                fecha = fecha12
                DeudaMes(fecha)
                'ListBox1.Items.Add(resultado)
                mesesDeuda(indiceArrayMeses) = fecha12
            End If
            'End If

            If (ClbMeses.GetItemChecked(indiceArrayMeses - 1)) Then
                'For Each elemento In ListBox1.Items

                suma += resultado
            End If
        Next
        TxtIndice.Text = indiceArrayMeses

        'For Each elemento In ListBox1.Items

        '    suma += elemento.ToString
        'Next

        'For k = indice + 1 To indice2 - 1
        '    ClbMeses.SetItemChecked(k, False)
        '    'For Each elemento In ListBox1.Items

        '    '    suma -= elemento.ToString
        '    'Next

        'Next

        'For j = 0 To indice - 1
        '    ClbMeses.SetItemChecked(j, True)
        '    For Each elemento In ListBox1.Items

        '        suma += elemento.ToString
        '    Next
        'Next


        TxtTotal.Text = suma
    End Sub

    Private Sub MontoDeuda(fecha)

        DeudaMes(fecha)
        ListBox1.Items.Add(resultado)

        'Dim i As Integer
        'Dim j As Integer
        'Dim k As Integer
        'Dim Valor As String
        'Dim indice As Integer
        'Dim indice2 As Integer
        'Dim suma As Integer

        ''indice = ClbMeses.SelectedIndex
        'indice2 = ClbMeses.Items.Count

        'ListBox1.Items.Clear()

        'For k = indice + 1 To indice2 - 1
        '    ClbMeses.SetItemChecked(k, False)
        'Next

        'For j = 0 To indice - 1
        '    ClbMeses.SetItemChecked(j, True)
        'Next

        'indiceArrayMeses = 0
        'ReDim mesesDeuda(ClbMeses.Items.Count - 1)
        'For i = 0 To Me.ClbMeses.CheckedItems.Count - 1
        '    Valor = ClbMeses.CheckedItems(i)
        '    'MsgBox("La casilla chekeada es " & Valor & "") ''Valor contiene el contenido del item chequeado
        '    If Valor = "Enero" Then
        '        fecha = fecha1
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha1
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Febrero" Then
        '        fecha = fecha2
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha2
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Marzo" Then
        '        fecha = fecha3
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha3
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Abril" Then
        '        fecha = fecha4
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha4
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Mayo" Then
        '        fecha = fecha5
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha5
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Junio" Then
        '        fecha = fecha6
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha6
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Julio" Then
        '        fecha = fecha7
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha7
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Agosto" Then
        '        fecha = fecha8
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha8
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Septiembre" Then
        '        fecha = fecha9
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha9
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Octubre" Then
        '        fecha = fecha10
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha10
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Octubre" Then
        '        fecha = fecha11
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha11
        '        indiceArrayMeses += 1
        '    ElseIf Valor = "Octubre" Then
        '        fecha = fecha12
        '        DeudaMes(fecha)
        '        ListBox1.Items.Add(resultado)
        '        mesesDeuda(indiceArrayMeses) = fecha12
        '    End If
        '    'End If
        'Next
        'TxtIndice.Text = indiceArrayMeses

        'For Each elemento In ListBox1.Items
        '    suma += elemento.ToString
        'Next

        'TxtTotal.Text = suma

    End Sub

    Private Sub DeudaMes(fecha)
        Dim consultaDeuda As String = "SELECT sum(monto_atraso) as monto FROM pago_detallado WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND periodo_de_pago = '" & fecha & "' "
        Dim comandoDeuda As New SqlCommand(consultaDeuda, conexion)
        resultado = comandoDeuda.ExecuteScalar
        'MsgBox("" & resultado & "")
    End Sub

    'Private Sub BtnPago_Click(sender As Object, e As EventArgs) Handles BtnPago.Click

    '    Dim mes As Date

    '    ListBox1.Items.Clear()


    '    For indice = 0 To indiceArrayMeses - 1
    '        mes = mesesDeuda(indice)
    '        PagoMes(mes)
    '        MsgBox("meses deuda: " & mesesDeuda(indice) & "")
    '    Next

    '    'Dim i As Integer
    '    'For i = 0 To ClbMeses.CheckedItems.Count - 1
    '    '    ListBox1.Items.Add(ClbMeses.CheckedItems(i))
    '    'Next i
    'End Sub

    Private Sub PagoMes(mes)



        'Dim cadena As String = "UPDATE detalle_pago_escolar SET  matricula = " & totalMatricula & ",
        '                            aranceles = " & TotalCuota & ", materiales = " & TotalMaterial & ", talleres = " & TotalTalleres & ", 
        '                            campamento = " & TotalCampamento & ", adicional = " & TotalAdicional & ", comedor = " & TotalComedor & ", 
        '                            credito = " & 0 & ", fecha_de_pago = '" & mes & "', pago_cumplido = 'completo', monto_deuda = " & 0 & " 
        '                            WHERE codigo_familia = " & Val(CbxCodigo.Text) & " AND fecha_de_pago = '" & mes & "' "

        'Dim comandoCadena As New SqlCommand(cadena, conexion)
        'If comandoCadena.ExecuteNonQuery() = 1 Then
        '    MessageBox.Show("Pago guardado")
        '    BtnPago.Enabled = False

        'Else
        '    MsgBox("Error de grabación. Reinicie el programa e intente nuevamente, de persistir el error contacte al soporte informático")
        'End If
        'contador += 1


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

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub DgvHijos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvHijos.CellValueChanged
        Dim mes As Integer
        Dim parImpar As Integer
        Dim alumno As String
        Dim matricula As Decimal
        Dim totalMatricula As Decimal
        Dim arancel As Decimal
        Dim totalCuota As Decimal
        Dim campamento As Decimal
        Dim totalCampamento As Decimal
        Dim talleres As Decimal
        Dim totalTalleres As Decimal
        Dim materiales As Decimal
        Dim totalMaterial As Decimal
        Dim adicional As Decimal
        Dim totalAdicional As Decimal
        Dim comedor As Decimal
        Dim totalComedor As Decimal


        Dim colAlumno As Integer = 1
        For Each row As DataGridViewRow In Me.DgvHijos.Rows

            If row.Cells(0).Value = True Then
                alumno = (row.Cells(colAlumno).Value)
            Else
                totalMatricula -= Val(row.Cells(colAlumno).Value)
            End If

        Next


        Dim colMatricula As Integer = 3
        For Each row As DataGridViewRow In Me.DgvHijos.Rows

            If row.Cells(0).Value = True Then
                totalMatricula = Val(row.Cells(colMatricula).Value)
            Else
                totalMatricula -= Val(row.Cells(colMatricula).Value)
            End If

        Next
        'TxtMatricula.PlaceholderText = totalMatricula
        matricula = totalMatricula


        Dim col As Integer = 4
        For Each row As DataGridViewRow In Me.DgvHijos.Rows
            If row.Selected Then
                totalCuota += Val(row.Cells(col).Value)
            End If
        Next
        'TxtArancel.PlaceholderText = TotalCuota
        arancel = totalCuota

        Dim colCamp As Integer = 5
        For Each row As DataGridViewRow In Me.DgvHijos.Rows
            If row.Selected Then
                totalCampamento += (Val(row.Cells(colCamp).Value))
            End If
        Next
        'TxtCampamento.PlaceholderText = TotalCampamento
        campamento = totalCampamento

        Dim colTaller As Integer = 6
        For Each row As DataGridViewRow In Me.DgvHijos.Rows
            If row.Selected Then
                totalTalleres += Val(row.Cells(colTaller).Value)
            End If
        Next
        'TxtTalleres.PlaceholderText = TotalTalleres
        talleres = totalTalleres

        Dim colMaterial As Integer = 7
        For Each row As DataGridViewRow In Me.DgvHijos.Rows
            If row.Selected Then
                totalMaterial += Val(row.Cells(colMaterial).Value)
            End If
        Next
        'TxtMateriales.PlaceholderText = TotalMaterial
        materiales = totalMaterial

        Dim colAdicional As Integer = 8
        For Each row As DataGridViewRow In Me.DgvHijos.Rows
            If row.Selected Then
                totalAdicional += Val(row.Cells(colAdicional).Value)
            End If
        Next
        'TxtAdicional.PlaceholderText = TotalAdicional
        adicional = totalAdicional

        Dim colComedor As Integer = 9
        For Each row As DataGridViewRow In Me.DgvHijos.Rows
            If row.Cells("Check").Value = True Then
                totalComedor += Val(row.Cells(colComedor).Value)
            End If
        Next
        mes = fechaActualPP.Month
        parImpar = mes Mod 2
        If parImpar <> 0 Then
            'TxtComedor.PlaceholderText = TotalComedor
            comedor = TotalComedor
        Else
            'TxtComedor.PlaceholderText = 0
            comedor = 0
            totalComedor = comedor
        End If

        Dim TotalAlumno As Decimal = totalMatricula + totalCuota + totalCampamento + totalTalleres + totalMaterial + totalAdicional + totalComedor
        LblTotalAlumno.Text = TotalAlumno
        LblAlumno.Text = alumno
    End Sub
End Class