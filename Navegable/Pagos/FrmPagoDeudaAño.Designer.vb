<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagoDeudaAño
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagoDeudaAño))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvHijos = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matricula_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cuota_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.campamento_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.talleres_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.materiales_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.adicional_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comedor_alumno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtIndice = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClbMeses = New System.Windows.Forms.CheckedListBox()
        Me.BtnPago = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxFamilia = New System.Windows.Forms.ComboBox()
        Me.CbxCodigo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.DgvHijos)
        Me.GroupBox2.Controls.Add(Me.TxtIndice)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ClbMeses)
        Me.GroupBox2.Controls.Add(Me.BtnPago)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(129, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(712, 374)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'DgvHijos
        '
        Me.DgvHijos.AllowUserToAddRows = False
        Me.DgvHijos.AllowUserToDeleteRows = False
        Me.DgvHijos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DgvHijos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvHijos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvHijos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvHijos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.DgvHijos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvHijos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvHijos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHijos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvHijos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvHijos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.matricula_alumno, Me.curso, Me.cuota_alumno, Me.campamento_alumno, Me.talleres_alumno, Me.materiales_alumno, Me.adicional_alumno, Me.comedor_alumno})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvHijos.DefaultCellStyle = DataGridViewCellStyle12
        Me.DgvHijos.GridColor = System.Drawing.Color.SteelBlue
        Me.DgvHijos.Location = New System.Drawing.Point(365, 278)
        Me.DgvHijos.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvHijos.Name = "DgvHijos"
        Me.DgvHijos.ReadOnly = True
        Me.DgvHijos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvHijos.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvHijos.RowHeadersWidth = 62
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.NullValue = Nothing
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DgvHijos.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.DgvHijos.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DgvHijos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvHijos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DgvHijos.RowTemplate.Height = 25
        Me.DgvHijos.RowTemplate.ReadOnly = True
        Me.DgvHijos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvHijos.Size = New System.Drawing.Size(141, 64)
        Me.DgvHijos.TabIndex = 17
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre_apellido_alumno"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nombre.FillWeight = 110.0!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MaxInputLength = 30
        Me.Nombre.MinimumWidth = 8
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 180
        '
        'matricula_alumno
        '
        Me.matricula_alumno.DataPropertyName = "matricula_alumno"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.matricula_alumno.DefaultCellStyle = DataGridViewCellStyle4
        Me.matricula_alumno.HeaderText = "Matrícula"
        Me.matricula_alumno.Name = "matricula_alumno"
        Me.matricula_alumno.ReadOnly = True
        Me.matricula_alumno.Width = 80
        '
        'curso
        '
        Me.curso.DataPropertyName = "curso"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.curso.DefaultCellStyle = DataGridViewCellStyle5
        Me.curso.HeaderText = "  Curso"
        Me.curso.MaxInputLength = 50
        Me.curso.Name = "curso"
        Me.curso.ReadOnly = True
        Me.curso.Width = 170
        '
        'cuota_alumno
        '
        Me.cuota_alumno.DataPropertyName = "cuota_alumno"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "$#,##0.00"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.cuota_alumno.DefaultCellStyle = DataGridViewCellStyle6
        Me.cuota_alumno.HeaderText = "  Cuota"
        Me.cuota_alumno.Name = "cuota_alumno"
        Me.cuota_alumno.ReadOnly = True
        Me.cuota_alumno.Width = 80
        '
        'campamento_alumno
        '
        Me.campamento_alumno.DataPropertyName = "campamento_alumno"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "$#,##0.00"
        Me.campamento_alumno.DefaultCellStyle = DataGridViewCellStyle7
        Me.campamento_alumno.HeaderText = "Campamento"
        Me.campamento_alumno.Name = "campamento_alumno"
        Me.campamento_alumno.ReadOnly = True
        Me.campamento_alumno.Width = 90
        '
        'talleres_alumno
        '
        Me.talleres_alumno.DataPropertyName = "talleres_alumno"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "$#,##0.00"
        Me.talleres_alumno.DefaultCellStyle = DataGridViewCellStyle8
        Me.talleres_alumno.HeaderText = " Talleres"
        Me.talleres_alumno.Name = "talleres_alumno"
        Me.talleres_alumno.ReadOnly = True
        Me.talleres_alumno.Width = 80
        '
        'materiales_alumno
        '
        Me.materiales_alumno.DataPropertyName = "materiales_alumno"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "$#,##0.00"
        Me.materiales_alumno.DefaultCellStyle = DataGridViewCellStyle9
        Me.materiales_alumno.HeaderText = "Materiales"
        Me.materiales_alumno.Name = "materiales_alumno"
        Me.materiales_alumno.ReadOnly = True
        Me.materiales_alumno.Width = 80
        '
        'adicional_alumno
        '
        Me.adicional_alumno.DataPropertyName = "adicional_alumno"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.adicional_alumno.DefaultCellStyle = DataGridViewCellStyle10
        Me.adicional_alumno.HeaderText = "Adicional"
        Me.adicional_alumno.Name = "adicional_alumno"
        Me.adicional_alumno.ReadOnly = True
        Me.adicional_alumno.Width = 80
        '
        'comedor_alumno
        '
        Me.comedor_alumno.DataPropertyName = "comedor_alumno"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.comedor_alumno.DefaultCellStyle = DataGridViewCellStyle11
        Me.comedor_alumno.HeaderText = "Comedor"
        Me.comedor_alumno.Name = "comedor_alumno"
        Me.comedor_alumno.ReadOnly = True
        Me.comedor_alumno.Width = 80
        '
        'TxtIndice
        '
        Me.TxtIndice.Location = New System.Drawing.Point(386, 224)
        Me.TxtIndice.Name = "TxtIndice"
        Me.TxtIndice.Size = New System.Drawing.Size(100, 27)
        Me.TxtIndice.TabIndex = 13
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(165, 56)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(109, 222)
        Me.ListBox1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(182, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Deuda:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(82, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mes:"
        '
        'ClbMeses
        '
        Me.ClbMeses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClbMeses.CheckOnClick = True
        Me.ClbMeses.FormattingEnabled = True
        Me.ClbMeses.Location = New System.Drawing.Point(45, 56)
        Me.ClbMeses.Name = "ClbMeses"
        Me.ClbMeses.Size = New System.Drawing.Size(109, 222)
        Me.ClbMeses.TabIndex = 4
        '
        'BtnPago
        '
        Me.BtnPago.BackColor = System.Drawing.Color.White
        Me.BtnPago.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPago.Location = New System.Drawing.Point(557, 152)
        Me.BtnPago.Name = "BtnPago"
        Me.BtnPago.Size = New System.Drawing.Size(115, 30)
        Me.BtnPago.TabIndex = 3
        Me.BtnPago.Text = "Realizar pago"
        Me.BtnPago.UseVisualStyleBackColor = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(572, 53)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 27)
        Me.TxtTotal.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(507, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total:  $"
        '
        'DtpFechaPago
        '
        Me.DtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaPago.Location = New System.Drawing.Point(819, 12)
        Me.DtpFechaPago.Name = "DtpFechaPago"
        Me.DtpFechaPago.Size = New System.Drawing.Size(128, 23)
        Me.DtpFechaPago.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CbxFamilia)
        Me.GroupBox1.Controls.Add(Me.CbxCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(90, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 110)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Familia"
        '
        'CbxFamilia
        '
        Me.CbxFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxFamilia.FormattingEnabled = True
        Me.CbxFamilia.Location = New System.Drawing.Point(398, 48)
        Me.CbxFamilia.Name = "CbxFamilia"
        Me.CbxFamilia.Size = New System.Drawing.Size(395, 29)
        Me.CbxFamilia.TabIndex = 3
        '
        'CbxCodigo
        '
        Me.CbxCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigo.FormattingEnabled = True
        Me.CbxCodigo.Location = New System.Drawing.Point(170, 48)
        Me.CbxCodigo.Name = "CbxCodigo"
        Me.CbxCodigo.Size = New System.Drawing.Size(121, 29)
        Me.CbxCodigo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(331, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Familia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(29, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Código de familia:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(262, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 21)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Año de pago:"
        '
        'BtnSalir
        '
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(878, 524)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(84, 41)
        Me.BtnSalir.TabIndex = 35
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(349, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 141)
        Me.Panel1.TabIndex = 18
        '
        'FrmPagoDeudaAño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtpFechaPago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label16)
        Me.MaximizeBox = False
        Me.Name = "FrmPagoDeudaAño"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago de deuda del año en curso"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnPago As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DtpFechaPago As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbxFamilia As ComboBox
    Friend WithEvents CbxCodigo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents ClbMeses As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TxtIndice As TextBox
    Friend WithEvents DgvHijos As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents matricula_alumno As DataGridViewTextBoxColumn
    Friend WithEvents curso As DataGridViewTextBoxColumn
    Friend WithEvents cuota_alumno As DataGridViewTextBoxColumn
    Friend WithEvents campamento_alumno As DataGridViewTextBoxColumn
    Friend WithEvents talleres_alumno As DataGridViewTextBoxColumn
    Friend WithEvents materiales_alumno As DataGridViewTextBoxColumn
    Friend WithEvents adicional_alumno As DataGridViewTextBoxColumn
    Friend WithEvents comedor_alumno As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
End Class
