<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDescuentosBecas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDescuentosBecas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DtpModificacion = New System.Windows.Forms.DateTimePicker()
        Me.CbxCodigo = New System.Windows.Forms.ComboBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.CbxFamilia = New System.Windows.Forms.ComboBox()
        Me.LblFamilia = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.RdbSinAsignar1 = New System.Windows.Forms.RadioButton()
        Me.RdbSinAsignar3 = New System.Windows.Forms.RadioButton()
        Me.RdbMediaBeca = New System.Windows.Forms.RadioButton()
        Me.RdbSinAsignar2 = New System.Windows.Forms.RadioButton()
        Me.RdbNinguna = New System.Windows.Forms.RadioButton()
        Me.RdbBecaEntera = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnSalirDescuentos = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtDescuentoMonto = New System.Windows.Forms.TextBox()
        Me.BtnGuardarMonto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardarPorcentaje = New System.Windows.Forms.Button()
        Me.TxtDescuentoPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CbxCodFamDescuento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxFamiliaDescuento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 65)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(236, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(470, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(691, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 5)
        Me.Panel2.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DtpModificacion)
        Me.GroupBox1.Controls.Add(Me.CbxCodigo)
        Me.GroupBox1.Controls.Add(Me.LblCodigo)
        Me.GroupBox1.Controls.Add(Me.CbxFamilia)
        Me.GroupBox1.Controls.Add(Me.LblFamilia)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(926, 117)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar familia"
        '
        'DtpModificacion
        '
        Me.DtpModificacion.Enabled = False
        Me.DtpModificacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpModificacion.Location = New System.Drawing.Point(363, 14)
        Me.DtpModificacion.Name = "DtpModificacion"
        Me.DtpModificacion.Size = New System.Drawing.Size(200, 29)
        Me.DtpModificacion.TabIndex = 1
        '
        'CbxCodigo
        '
        Me.CbxCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxCodigo.BackColor = System.Drawing.Color.White
        Me.CbxCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigo.FormattingEnabled = True
        Me.CbxCodigo.Location = New System.Drawing.Point(90, 49)
        Me.CbxCodigo.Name = "CbxCodigo"
        Me.CbxCodigo.Size = New System.Drawing.Size(121, 29)
        Me.CbxCodigo.TabIndex = 2
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblCodigo.Location = New System.Drawing.Point(15, 57)
        Me.LblCodigo.Name = "LblCodigo"
        Me.LblCodigo.Size = New System.Drawing.Size(69, 21)
        Me.LblCodigo.TabIndex = 2
        Me.LblCodigo.Text = "Código:"
        '
        'CbxFamilia
        '
        Me.CbxFamilia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxFamilia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxFamilia.BackColor = System.Drawing.Color.White
        Me.CbxFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxFamilia.FormattingEnabled = True
        Me.CbxFamilia.Location = New System.Drawing.Point(363, 49)
        Me.CbxFamilia.Name = "CbxFamilia"
        Me.CbxFamilia.Size = New System.Drawing.Size(374, 29)
        Me.CbxFamilia.TabIndex = 3
        '
        'LblFamilia
        '
        Me.LblFamilia.AutoSize = True
        Me.LblFamilia.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblFamilia.Location = New System.Drawing.Point(287, 57)
        Me.LblFamilia.Name = "LblFamilia"
        Me.LblFamilia.Size = New System.Drawing.Size(70, 21)
        Me.LblFamilia.TabIndex = 0
        Me.LblFamilia.Text = "Familia:"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalir.Location = New System.Drawing.Point(840, 431)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 48)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnGuardar)
        Me.GroupBox2.Controls.Add(Me.RdbSinAsignar1)
        Me.GroupBox2.Controls.Add(Me.RdbSinAsignar3)
        Me.GroupBox2.Controls.Add(Me.RdbMediaBeca)
        Me.GroupBox2.Controls.Add(Me.RdbSinAsignar2)
        Me.GroupBox2.Controls.Add(Me.RdbNinguna)
        Me.GroupBox2.Controls.Add(Me.RdbBecaEntera)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(305, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 318)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de beca"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.White
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnGuardar.Location = New System.Drawing.Point(70, 256)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(102, 45)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'RdbSinAsignar1
        '
        Me.RdbSinAsignar1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RdbSinAsignar1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbSinAsignar1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdbSinAsignar1.Location = New System.Drawing.Point(68, 142)
        Me.RdbSinAsignar1.Name = "RdbSinAsignar1"
        Me.RdbSinAsignar1.Size = New System.Drawing.Size(104, 19)
        Me.RdbSinAsignar1.TabIndex = 12
        Me.RdbSinAsignar1.TabStop = True
        Me.RdbSinAsignar1.Text = "Sin asignar"
        Me.RdbSinAsignar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbSinAsignar1.UseVisualStyleBackColor = True
        '
        'RdbSinAsignar3
        '
        Me.RdbSinAsignar3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RdbSinAsignar3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbSinAsignar3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdbSinAsignar3.Location = New System.Drawing.Point(68, 218)
        Me.RdbSinAsignar3.Name = "RdbSinAsignar3"
        Me.RdbSinAsignar3.Size = New System.Drawing.Size(104, 19)
        Me.RdbSinAsignar3.TabIndex = 11
        Me.RdbSinAsignar3.TabStop = True
        Me.RdbSinAsignar3.Text = "Sin asignar"
        Me.RdbSinAsignar3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbSinAsignar3.UseVisualStyleBackColor = True
        '
        'RdbMediaBeca
        '
        Me.RdbMediaBeca.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RdbMediaBeca.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbMediaBeca.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdbMediaBeca.Location = New System.Drawing.Point(68, 71)
        Me.RdbMediaBeca.Name = "RdbMediaBeca"
        Me.RdbMediaBeca.Size = New System.Drawing.Size(104, 19)
        Me.RdbMediaBeca.TabIndex = 10
        Me.RdbMediaBeca.TabStop = True
        Me.RdbMediaBeca.Text = "1/2 Beca"
        Me.RdbMediaBeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbMediaBeca.UseVisualStyleBackColor = True
        '
        'RdbSinAsignar2
        '
        Me.RdbSinAsignar2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RdbSinAsignar2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbSinAsignar2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdbSinAsignar2.Location = New System.Drawing.Point(68, 179)
        Me.RdbSinAsignar2.Name = "RdbSinAsignar2"
        Me.RdbSinAsignar2.Size = New System.Drawing.Size(104, 19)
        Me.RdbSinAsignar2.TabIndex = 9
        Me.RdbSinAsignar2.TabStop = True
        Me.RdbSinAsignar2.Text = "Sin asignar"
        Me.RdbSinAsignar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbSinAsignar2.UseVisualStyleBackColor = True
        '
        'RdbNinguna
        '
        Me.RdbNinguna.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RdbNinguna.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbNinguna.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdbNinguna.Location = New System.Drawing.Point(68, 105)
        Me.RdbNinguna.Name = "RdbNinguna"
        Me.RdbNinguna.Size = New System.Drawing.Size(104, 19)
        Me.RdbNinguna.TabIndex = 7
        Me.RdbNinguna.TabStop = True
        Me.RdbNinguna.Text = "Ninguna"
        Me.RdbNinguna.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbNinguna.UseVisualStyleBackColor = True
        '
        'RdbBecaEntera
        '
        Me.RdbBecaEntera.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RdbBecaEntera.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbBecaEntera.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RdbBecaEntera.Location = New System.Drawing.Point(68, 34)
        Me.RdbBecaEntera.Name = "RdbBecaEntera"
        Me.RdbBecaEntera.Size = New System.Drawing.Size(104, 24)
        Me.RdbBecaEntera.TabIndex = 6
        Me.RdbBecaEntera.TabStop = True
        Me.RdbBecaEntera.Text = "Beca entera"
        Me.RdbBecaEntera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbBecaEntera.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 541)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BtnSalir)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(966, 513)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.BtnSalirDescuentos)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(966, 513)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnSalirDescuentos
        '
        Me.BtnSalirDescuentos.BackColor = System.Drawing.Color.White
        Me.BtnSalirDescuentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSalirDescuentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirDescuentos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalirDescuentos.Location = New System.Drawing.Point(860, 407)
        Me.BtnSalirDescuentos.Name = "BtnSalirDescuentos"
        Me.BtnSalirDescuentos.Size = New System.Drawing.Size(75, 36)
        Me.BtnSalirDescuentos.TabIndex = 4
        Me.BtnSalirDescuentos.Text = "Salir"
        Me.BtnSalirDescuentos.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TxtDescuentoMonto)
        Me.GroupBox5.Controls.Add(Me.BtnGuardarMonto)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox5.Location = New System.Drawing.Point(533, 232)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(286, 211)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Descuento por monto fijo"
        '
        'TxtDescuentoMonto
        '
        Me.TxtDescuentoMonto.Location = New System.Drawing.Point(98, 70)
        Me.TxtDescuentoMonto.MaxLength = 8
        Me.TxtDescuentoMonto.Name = "TxtDescuentoMonto"
        Me.TxtDescuentoMonto.Size = New System.Drawing.Size(100, 27)
        Me.TxtDescuentoMonto.TabIndex = 2
        '
        'BtnGuardarMonto
        '
        Me.BtnGuardarMonto.BackColor = System.Drawing.Color.White
        Me.BtnGuardarMonto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGuardarMonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarMonto.Location = New System.Drawing.Point(111, 129)
        Me.BtnGuardarMonto.Name = "BtnGuardarMonto"
        Me.BtnGuardarMonto.Size = New System.Drawing.Size(75, 35)
        Me.BtnGuardarMonto.TabIndex = 3
        Me.BtnGuardarMonto.Text = "Guardar"
        Me.BtnGuardarMonto.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Monto:  $"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.BtnGuardarPorcentaje)
        Me.GroupBox4.Controls.Add(Me.TxtDescuentoPorcentaje)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.Location = New System.Drawing.Point(99, 232)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(298, 211)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Descuento por porcentaje"
        '
        'BtnGuardarPorcentaje
        '
        Me.BtnGuardarPorcentaje.BackColor = System.Drawing.Color.White
        Me.BtnGuardarPorcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGuardarPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarPorcentaje.Location = New System.Drawing.Point(129, 122)
        Me.BtnGuardarPorcentaje.Name = "BtnGuardarPorcentaje"
        Me.BtnGuardarPorcentaje.Size = New System.Drawing.Size(75, 36)
        Me.BtnGuardarPorcentaje.TabIndex = 2
        Me.BtnGuardarPorcentaje.Text = "Guardar"
        Me.BtnGuardarPorcentaje.UseVisualStyleBackColor = False
        '
        'TxtDescuentoPorcentaje
        '
        Me.TxtDescuentoPorcentaje.Location = New System.Drawing.Point(118, 63)
        Me.TxtDescuentoPorcentaje.MaxLength = 2
        Me.TxtDescuentoPorcentaje.Name = "TxtDescuentoPorcentaje"
        Me.TxtDescuentoPorcentaje.Size = New System.Drawing.Size(100, 27)
        Me.TxtDescuentoPorcentaje.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Porcentaje:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.CbxCodFamDescuento)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CbxFamiliaDescuento)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 52)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(926, 135)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccionar familia"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(346, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 29)
        Me.DateTimePicker1.TabIndex = 1
        '
        'CbxCodFamDescuento
        '
        Me.CbxCodFamDescuento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxCodFamDescuento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxCodFamDescuento.BackColor = System.Drawing.Color.White
        Me.CbxCodFamDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodFamDescuento.FormattingEnabled = True
        Me.CbxCodFamDescuento.Location = New System.Drawing.Point(195, 83)
        Me.CbxCodFamDescuento.Name = "CbxCodFamDescuento"
        Me.CbxCodFamDescuento.Size = New System.Drawing.Size(121, 29)
        Me.CbxCodFamDescuento.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(120, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código:"
        '
        'CbxFamiliaDescuento
        '
        Me.CbxFamiliaDescuento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxFamiliaDescuento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxFamiliaDescuento.BackColor = System.Drawing.Color.White
        Me.CbxFamiliaDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxFamiliaDescuento.FormattingEnabled = True
        Me.CbxFamiliaDescuento.Location = New System.Drawing.Point(468, 83)
        Me.CbxFamiliaDescuento.Name = "CbxFamiliaDescuento"
        Me.CbxFamiliaDescuento.Size = New System.Drawing.Size(374, 29)
        Me.CbxFamiliaDescuento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(392, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Familia:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(974, 70)
        Me.Panel3.TabIndex = 10
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.ForeColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(103, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(97, 67)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Descuento especial"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.ForeColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(2, 1)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 66)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Beca"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'FrmDescuentosBecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDescuentosBecas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Becas y descuentos"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DtpModificacion As DateTimePicker
    Friend WithEvents CbxCodigo As ComboBox
    Friend WithEvents LblCodigo As Label
    Friend WithEvents CbxFamilia As ComboBox
    Friend WithEvents LblFamilia As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RdbSinAsignar3 As RadioButton
    Friend WithEvents RdbMediaBeca As RadioButton
    Friend WithEvents RdbSinAsignar2 As RadioButton
    Friend WithEvents RdbNinguna As RadioButton
    Friend WithEvents RdbBecaEntera As RadioButton
    Friend WithEvents RdbSinAsignar1 As RadioButton
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CbxCodFamDescuento As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxFamiliaDescuento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnSalirDescuentos As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxtDescuentoMonto As TextBox
    Friend WithEvents BtnGuardarMonto As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnGuardarPorcentaje As Button
    Friend WithEvents TxtDescuentoPorcentaje As TextBox
    Friend WithEvents Label3 As Label
End Class
