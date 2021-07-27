<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCargaAranceles
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargaAranceles))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DgvArancel = New System.Windows.Forms.DataGridView()
        Me.Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.none = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.arancel_matricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_de_vigencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbxCodigoNivel = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtpFechaVigencia = New System.Windows.Forms.DateTimePicker()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.TxtArancel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtCodigoActualizacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMatriculaActual = New System.Windows.Forms.TextBox()
        Me.TxtArancelActual = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbxCodigoNivelActualizacion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbxNivelActualizacion = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DtpFechaModificacion = New System.Windows.Forms.DateTimePicker()
        Me.TxtMatriculaModificada = New System.Windows.Forms.TextBox()
        Me.TxtArancelModificado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnSalirActualizaciones = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BtnSalirBajas = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txtbaja = New System.Windows.Forms.TextBox()
        Me.BtnBajaArancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMatriculaBaja = New System.Windows.Forms.TextBox()
        Me.TxtArancelBaja = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CbxCodigoBaja = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CbxNivelBaja = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvArancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 611)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BtnSalir)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(966, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.DgvArancel)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CbxCodigoNivel)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CbxNivel)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(88, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(785, 280)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Aranceles existentes"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(314, 219)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 44)
        Me.Panel3.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(365, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 20)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Valores actuales"
        '
        'DgvArancel
        '
        Me.DgvArancel.AllowUserToAddRows = False
        Me.DgvArancel.AllowUserToDeleteRows = False
        Me.DgvArancel.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DgvArancel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvArancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvArancel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvArancel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.DgvArancel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvArancel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvArancel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvArancel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvArancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArancel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nivel, Me.none, Me.arancel_matricula, Me.fecha_de_vigencia})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvArancel.DefaultCellStyle = DataGridViewCellStyle7
        Me.DgvArancel.GridColor = System.Drawing.Color.SteelBlue
        Me.DgvArancel.Location = New System.Drawing.Point(87, 130)
        Me.DgvArancel.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvArancel.Name = "DgvArancel"
        Me.DgvArancel.ReadOnly = True
        Me.DgvArancel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvArancel.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgvArancel.RowHeadersWidth = 62
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.NullValue = Nothing
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DgvArancel.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DgvArancel.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DgvArancel.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.DgvArancel.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DgvArancel.RowTemplate.Height = 25
        Me.DgvArancel.RowTemplate.ReadOnly = True
        Me.DgvArancel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArancel.Size = New System.Drawing.Size(602, 82)
        Me.DgvArancel.TabIndex = 16
        '
        'Nivel
        '
        Me.Nivel.DataPropertyName = "nivel"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.Nivel.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nivel.FillWeight = 110.0!
        Me.Nivel.HeaderText = "Nivel"
        Me.Nivel.MaxInputLength = 30
        Me.Nivel.MinimumWidth = 8
        Me.Nivel.Name = "Nivel"
        Me.Nivel.ReadOnly = True
        Me.Nivel.Width = 120
        '
        'none
        '
        Me.none.DataPropertyName = "arancel_importe"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.none.DefaultCellStyle = DataGridViewCellStyle4
        Me.none.HeaderText = "Arancel"
        Me.none.Name = "none"
        Me.none.ReadOnly = True
        Me.none.Width = 140
        '
        'arancel_matricula
        '
        Me.arancel_matricula.DataPropertyName = "arancel_matricula"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.arancel_matricula.DefaultCellStyle = DataGridViewCellStyle5
        Me.arancel_matricula.HeaderText = "Matrícula"
        Me.arancel_matricula.MaxInputLength = 50
        Me.arancel_matricula.Name = "arancel_matricula"
        Me.arancel_matricula.ReadOnly = True
        Me.arancel_matricula.Width = 140
        '
        'fecha_de_vigencia
        '
        Me.fecha_de_vigencia.DataPropertyName = "fecha_de_vigencia"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.fecha_de_vigencia.DefaultCellStyle = DataGridViewCellStyle6
        Me.fecha_de_vigencia.HeaderText = "Desde fecha"
        Me.fecha_de_vigencia.Name = "fecha_de_vigencia"
        Me.fecha_de_vigencia.ReadOnly = True
        Me.fecha_de_vigencia.Width = 140
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(325, 235)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(122, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Código de nivel:"
        '
        'CbxCodigoNivel
        '
        Me.CbxCodigoNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigoNivel.FormattingEnabled = True
        Me.CbxCodigoNivel.Location = New System.Drawing.Point(245, 52)
        Me.CbxCodigoNivel.Name = "CbxCodigoNivel"
        Me.CbxCodigoNivel.Size = New System.Drawing.Size(63, 28)
        Me.CbxCodigoNivel.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(418, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nivel:"
        '
        'CbxNivel
        '
        Me.CbxNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Location = New System.Drawing.Point(470, 52)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(121, 28)
        Me.CbxNivel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DtpFechaVigencia)
        Me.GroupBox1.Controls.Add(Me.TxtMatricula)
        Me.GroupBox1.Controls.Add(Me.TxtArancel)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 356)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 152)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevos aranceles"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.White
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(625, 80)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(96, 44)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(334, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha de vigencia"
        '
        'DtpFechaVigencia
        '
        Me.DtpFechaVigencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaVigencia.Location = New System.Drawing.Point(325, 37)
        Me.DtpFechaVigencia.Name = "DtpFechaVigencia"
        Me.DtpFechaVigencia.Size = New System.Drawing.Size(144, 27)
        Me.DtpFechaVigencia.TabIndex = 6
        '
        'TxtMatricula
        '
        Me.TxtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMatricula.Location = New System.Drawing.Point(461, 89)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(119, 27)
        Me.TxtMatricula.TabIndex = 5
        '
        'TxtArancel
        '
        Me.TxtArancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtArancel.Location = New System.Drawing.Point(230, 91)
        Me.TxtArancel.Name = "TxtArancel"
        Me.TxtArancel.Size = New System.Drawing.Size(119, 27)
        Me.TxtArancel.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(381, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Matrícula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(163, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Arancel:"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(834, 525)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(96, 44)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SkyBlue
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.BtnSalirActualizaciones)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(966, 583)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Panel4)
        Me.GroupBox3.Controls.Add(Me.TxtCodigoActualizacion)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtMatriculaActual)
        Me.GroupBox3.Controls.Add(Me.TxtArancelActual)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.CbxCodigoNivelActualizacion)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.CbxNivelActualizacion)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(91, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(785, 228)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Valores actuales"
        '
        'TxtCodigoActualizacion
        '
        Me.TxtCodigoActualizacion.Location = New System.Drawing.Point(533, 151)
        Me.TxtCodigoActualizacion.Name = "TxtCodigoActualizacion"
        Me.TxtCodigoActualizacion.Size = New System.Drawing.Size(76, 27)
        Me.TxtCodigoActualizacion.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(112, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Matrícula Actual:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(125, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Arancel Actual:"
        '
        'TxtMatriculaActual
        '
        Me.TxtMatriculaActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMatriculaActual.Location = New System.Drawing.Point(238, 126)
        Me.TxtMatriculaActual.Name = "TxtMatriculaActual"
        Me.TxtMatriculaActual.ReadOnly = True
        Me.TxtMatriculaActual.Size = New System.Drawing.Size(119, 27)
        Me.TxtMatriculaActual.TabIndex = 8
        '
        'TxtArancelActual
        '
        Me.TxtArancelActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtArancelActual.Location = New System.Drawing.Point(238, 97)
        Me.TxtArancelActual.Name = "TxtArancelActual"
        Me.TxtArancelActual.ReadOnly = True
        Me.TxtArancelActual.Size = New System.Drawing.Size(119, 27)
        Me.TxtArancelActual.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(116, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 20)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Código de nivel:"
        '
        'CbxCodigoNivelActualizacion
        '
        Me.CbxCodigoNivelActualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigoNivelActualizacion.FormattingEnabled = True
        Me.CbxCodigoNivelActualizacion.Location = New System.Drawing.Point(239, 53)
        Me.CbxCodigoNivelActualizacion.Name = "CbxCodigoNivelActualizacion"
        Me.CbxCodigoNivelActualizacion.Size = New System.Drawing.Size(63, 28)
        Me.CbxCodigoNivelActualizacion.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(422, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nivel:"
        '
        'CbxNivelActualizacion
        '
        Me.CbxNivelActualizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxNivelActualizacion.FormattingEnabled = True
        Me.CbxNivelActualizacion.Location = New System.Drawing.Point(474, 51)
        Me.CbxNivelActualizacion.Name = "CbxNivelActualizacion"
        Me.CbxNivelActualizacion.Size = New System.Drawing.Size(121, 28)
        Me.CbxNivelActualizacion.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BtnActualizar)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.DtpFechaModificacion)
        Me.GroupBox4.Controls.Add(Me.TxtMatriculaModificada)
        Me.GroupBox4.Controls.Add(Me.TxtArancelModificado)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.Location = New System.Drawing.Point(91, 315)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(785, 194)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Panel de actualización de aranceles"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.White
        Me.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Location = New System.Drawing.Point(474, 125)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(103, 41)
        Me.BtnActualizar.TabIndex = 9
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(453, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Fecha de vigencia"
        '
        'DtpFechaModificacion
        '
        Me.DtpFechaModificacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaModificacion.Location = New System.Drawing.Point(451, 51)
        Me.DtpFechaModificacion.Name = "DtpFechaModificacion"
        Me.DtpFechaModificacion.Size = New System.Drawing.Size(129, 27)
        Me.DtpFechaModificacion.TabIndex = 6
        '
        'TxtMatriculaModificada
        '
        Me.TxtMatriculaModificada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMatriculaModificada.Location = New System.Drawing.Point(231, 133)
        Me.TxtMatriculaModificada.Name = "TxtMatriculaModificada"
        Me.TxtMatriculaModificada.Size = New System.Drawing.Size(119, 27)
        Me.TxtMatriculaModificada.TabIndex = 5
        '
        'TxtArancelModificado
        '
        Me.TxtArancelModificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtArancelModificado.Location = New System.Drawing.Point(231, 51)
        Me.TxtArancelModificado.Name = "TxtArancelModificado"
        Me.TxtArancelModificado.Size = New System.Drawing.Size(119, 27)
        Me.TxtArancelModificado.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(151, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Matrícula:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(163, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Arancel:"
        '
        'BtnSalirActualizaciones
        '
        Me.BtnSalirActualizaciones.BackColor = System.Drawing.Color.White
        Me.BtnSalirActualizaciones.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnSalirActualizaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirActualizaciones.Location = New System.Drawing.Point(773, 524)
        Me.BtnSalirActualizaciones.Name = "BtnSalirActualizaciones"
        Me.BtnSalirActualizaciones.Size = New System.Drawing.Size(103, 41)
        Me.BtnSalirActualizaciones.TabIndex = 4
        Me.BtnSalirActualizaciones.Text = "Salir"
        Me.BtnSalirActualizaciones.UseVisualStyleBackColor = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.BtnSalirBajas)
        Me.TabPage3.Controls.Add(Me.GroupBox5)
        Me.TabPage3.ForeColor = System.Drawing.Color.White
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(966, 583)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'BtnSalirBajas
        '
        Me.BtnSalirBajas.BackColor = System.Drawing.Color.White
        Me.BtnSalirBajas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalirBajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirBajas.ForeColor = System.Drawing.Color.Black
        Me.BtnSalirBajas.Location = New System.Drawing.Point(739, 494)
        Me.BtnSalirBajas.Name = "BtnSalirBajas"
        Me.BtnSalirBajas.Size = New System.Drawing.Size(79, 31)
        Me.BtnSalirBajas.TabIndex = 13
        Me.BtnSalirBajas.Text = "Salir"
        Me.BtnSalirBajas.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.Controls.Add(Me.Txtbaja)
        Me.GroupBox5.Controls.Add(Me.BtnBajaArancel)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.TxtMatriculaBaja)
        Me.GroupBox5.Controls.Add(Me.TxtArancelBaja)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.CbxCodigoBaja)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.CbxNivelBaja)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox5.Location = New System.Drawing.Point(123, 132)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(695, 197)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(581, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(108, 46)
        Me.Panel2.TabIndex = 13
        '
        'Txtbaja
        '
        Me.Txtbaja.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Txtbaja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtbaja.Location = New System.Drawing.Point(593, 40)
        Me.Txtbaja.Name = "Txtbaja"
        Me.Txtbaja.Size = New System.Drawing.Size(79, 20)
        Me.Txtbaja.TabIndex = 12
        '
        'BtnBajaArancel
        '
        Me.BtnBajaArancel.BackColor = System.Drawing.Color.White
        Me.BtnBajaArancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnBajaArancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBajaArancel.ForeColor = System.Drawing.Color.Black
        Me.BtnBajaArancel.Location = New System.Drawing.Point(474, 120)
        Me.BtnBajaArancel.Name = "BtnBajaArancel"
        Me.BtnBajaArancel.Size = New System.Drawing.Size(83, 34)
        Me.BtnBajaArancel.TabIndex = 11
        Me.BtnBajaArancel.Text = "Eliminar"
        Me.BtnBajaArancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(121, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Matrícula:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(132, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Arancel:"
        '
        'TxtMatriculaBaja
        '
        Me.TxtMatriculaBaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMatriculaBaja.Location = New System.Drawing.Point(201, 131)
        Me.TxtMatriculaBaja.Name = "TxtMatriculaBaja"
        Me.TxtMatriculaBaja.ReadOnly = True
        Me.TxtMatriculaBaja.Size = New System.Drawing.Size(119, 27)
        Me.TxtMatriculaBaja.TabIndex = 8
        '
        'TxtArancelBaja
        '
        Me.TxtArancelBaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtArancelBaja.Location = New System.Drawing.Point(200, 86)
        Me.TxtArancelBaja.Name = "TxtArancelBaja"
        Me.TxtArancelBaja.ReadOnly = True
        Me.TxtArancelBaja.Size = New System.Drawing.Size(119, 27)
        Me.TxtArancelBaja.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(78, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 20)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Código de nivel:"
        '
        'CbxCodigoBaja
        '
        Me.CbxCodigoBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigoBaja.FormattingEnabled = True
        Me.CbxCodigoBaja.Location = New System.Drawing.Point(201, 42)
        Me.CbxCodigoBaja.Name = "CbxCodigoBaja"
        Me.CbxCodigoBaja.Size = New System.Drawing.Size(63, 28)
        Me.CbxCodigoBaja.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(384, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Nivel:"
        '
        'CbxNivelBaja
        '
        Me.CbxNivelBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxNivelBaja.FormattingEnabled = True
        Me.CbxNivelBaja.Location = New System.Drawing.Point(436, 40)
        Me.CbxNivelBaja.Name = "CbxNivelBaja"
        Me.CbxNivelBaja.Size = New System.Drawing.Size(121, 28)
        Me.CbxNivelBaja.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 60)
        Me.Panel1.TabIndex = 11
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton3.FlatAppearance.BorderSize = 0
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(255, 1)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(128, 59)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.Text = "Baja de aranceles"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(0, 1)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(128, 59)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.Text = "Carga de Aranceles"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(127, 1)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(128, 59)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.Text = "Actualización de aranceles"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(519, 133)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(109, 53)
        Me.Panel4.TabIndex = 12
        '
        'FrmCargaAranceles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmCargaAranceles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de aranceles"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvArancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbxCodigoNivel As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DtpFechaVigencia As DateTimePicker
    Friend WithEvents TxtMatricula As TextBox
    Friend WithEvents TxtArancel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtMatriculaActual As TextBox
    Friend WithEvents TxtArancelActual As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CbxCodigoNivelActualizacion As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CbxNivelActualizacion As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents DtpFechaModificacion As DateTimePicker
    Friend WithEvents TxtMatriculaModificada As TextBox
    Friend WithEvents TxtArancelModificado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnSalirActualizaciones As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnSalirBajas As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BtnBajaArancel As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtMatriculaBaja As TextBox
    Friend WithEvents TxtArancelBaja As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CbxCodigoBaja As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CbxNivelBaja As ComboBox
    Friend WithEvents Txtbaja As TextBox
    Friend WithEvents TxtCodigoActualizacion As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents DgvArancel As DataGridView
    Friend WithEvents Nivel As DataGridViewTextBoxColumn
    Friend WithEvents none As DataGridViewTextBoxColumn
    Friend WithEvents arancel_matricula As DataGridViewTextBoxColumn
    Friend WithEvents fecha_de_vigencia As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
