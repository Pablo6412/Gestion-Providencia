<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCampamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCampamentos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxCurso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.TxtCodigoNivel = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.CbxCodigonivel = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtLugar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCodigoAño = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DtpFechaNueva = New System.Windows.Forms.DateTimePicker()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtDuracionNueva = New System.Windows.Forms.TextBox()
        Me.TxtValorNuevo = New System.Windows.Forms.TextBox()
        Me.TxtLugarNuevo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnSalirActualiza = New System.Windows.Forms.Button()
        Me.CbxCodigoAño = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TxtFechaActual = New System.Windows.Forms.TextBox()
        Me.TxtDuracionActual = New System.Windows.Forms.TextBox()
        Me.TxtValorActual = New System.Windows.Forms.TextBox()
        Me.TxtLugarActual = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CbxAño = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CbxCurso)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbxNivel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'CbxCurso
        '
        Me.CbxCurso.FormattingEnabled = True
        Me.CbxCurso.Location = New System.Drawing.Point(203, 115)
        Me.CbxCurso.Name = "CbxCurso"
        Me.CbxCurso.Size = New System.Drawing.Size(168, 28)
        Me.CbxCurso.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(55, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccione un curso:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(55, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione un nivel:"
        '
        'CbxNivel
        '
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Location = New System.Drawing.Point(203, 45)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(168, 28)
        Me.CbxNivel.TabIndex = 0
        '
        'TxtCodigoNivel
        '
        Me.TxtCodigoNivel.Location = New System.Drawing.Point(35, 146)
        Me.TxtCodigoNivel.Name = "TxtCodigoNivel"
        Me.TxtCodigoNivel.Size = New System.Drawing.Size(100, 23)
        Me.TxtCodigoNivel.TabIndex = 4
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(857, 520)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(83, 30)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'CbxCodigonivel
        '
        Me.CbxCodigonivel.FormattingEnabled = True
        Me.CbxCodigonivel.Location = New System.Drawing.Point(42, 13)
        Me.CbxCodigonivel.Name = "CbxCodigonivel"
        Me.CbxCodigonivel.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigonivel.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnGuardar)
        Me.GroupBox2.Controls.Add(Me.DtpFecha)
        Me.GroupBox2.Controls.Add(Me.TxtValor)
        Me.GroupBox2.Controls.Add(Me.TxtLugar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(84, 329)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 161)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.White
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(359, 107)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(85, 34)
        Me.BtnGuardar.TabIndex = 5
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(624, 50)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(112, 23)
        Me.DtpFecha.TabIndex = 6
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(453, 50)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(100, 23)
        Me.TxtValor.TabIndex = 5
        '
        'TxtLugar
        '
        Me.TxtLugar.Location = New System.Drawing.Point(79, 50)
        Me.TxtLugar.Name = "TxtLugar"
        Me.TxtLugar.Size = New System.Drawing.Size(278, 23)
        Me.TxtLugar.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(577, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(399, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Valor:  $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lugar:"
        '
        'TxtCodigoAño
        '
        Me.TxtCodigoAño.Location = New System.Drawing.Point(41, 52)
        Me.TxtCodigoAño.Name = "TxtCodigoAño"
        Me.TxtCodigoAño.Size = New System.Drawing.Size(100, 23)
        Me.TxtCodigoAño.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(35, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 73)
        Me.Panel1.TabIndex = 6
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
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.BtnSalir)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.TxtCodigoNivel)
        Me.TabPage1.Controls.Add(Me.CbxCodigonivel)
        Me.TabPage1.Controls.Add(Me.TxtCodigoAño)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(966, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.BtnSalirActualiza)
        Me.TabPage2.Controls.Add(Me.CbxCodigoAño)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(966, 583)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(768, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(190, 36)
        Me.Panel3.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DtpFechaNueva)
        Me.GroupBox4.Controls.Add(Me.BtnActualizar)
        Me.GroupBox4.Controls.Add(Me.TxtDuracionNueva)
        Me.GroupBox4.Controls.Add(Me.TxtValorNuevo)
        Me.GroupBox4.Controls.Add(Me.TxtLugarNuevo)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox4.Location = New System.Drawing.Point(77, 373)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(800, 132)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Valores a actualizar"
        '
        'DtpFechaNueva
        '
        Me.DtpFechaNueva.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNueva.Location = New System.Drawing.Point(682, 43)
        Me.DtpFechaNueva.Name = "DtpFechaNueva"
        Me.DtpFechaNueva.Size = New System.Drawing.Size(94, 23)
        Me.DtpFechaNueva.TabIndex = 17
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.White
        Me.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Location = New System.Drawing.Point(354, 86)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(94, 31)
        Me.BtnActualizar.TabIndex = 16
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtDuracionNueva
        '
        Me.TxtDuracionNueva.Location = New System.Drawing.Point(511, 43)
        Me.TxtDuracionNueva.Name = "TxtDuracionNueva"
        Me.TxtDuracionNueva.Size = New System.Drawing.Size(116, 23)
        Me.TxtDuracionNueva.TabIndex = 14
        '
        'TxtValorNuevo
        '
        Me.TxtValorNuevo.Location = New System.Drawing.Point(360, 43)
        Me.TxtValorNuevo.Name = "TxtValorNuevo"
        Me.TxtValorNuevo.Size = New System.Drawing.Size(80, 23)
        Me.TxtValorNuevo.TabIndex = 13
        '
        'TxtLugarNuevo
        '
        Me.TxtLugarNuevo.Location = New System.Drawing.Point(77, 43)
        Me.TxtLugarNuevo.Name = "TxtLugarNuevo"
        Me.TxtLugarNuevo.Size = New System.Drawing.Size(215, 23)
        Me.TxtLugarNuevo.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(640, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Fecha:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(456, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Duración:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(309, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Valor:  $"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 15)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Lugar:"
        '
        'BtnSalirActualiza
        '
        Me.BtnSalirActualiza.BackColor = System.Drawing.Color.White
        Me.BtnSalirActualiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.BtnSalirActualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirActualiza.Location = New System.Drawing.Point(859, 520)
        Me.BtnSalirActualiza.Name = "BtnSalirActualiza"
        Me.BtnSalirActualiza.Size = New System.Drawing.Size(82, 32)
        Me.BtnSalirActualiza.TabIndex = 2
        Me.BtnSalirActualiza.Text = "Salir"
        Me.BtnSalirActualiza.UseVisualStyleBackColor = False
        '
        'CbxCodigoAño
        '
        Me.CbxCodigoAño.FormattingEnabled = True
        Me.CbxCodigoAño.Location = New System.Drawing.Point(820, 52)
        Me.CbxCodigoAño.Name = "CbxCodigoAño"
        Me.CbxCodigoAño.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoAño.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.CbxAño)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(77, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(800, 257)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccione año"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtFechaActual)
        Me.GroupBox5.Controls.Add(Me.TxtDuracionActual)
        Me.GroupBox5.Controls.Add(Me.TxtValorActual)
        Me.GroupBox5.Controls.Add(Me.TxtLugarActual)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Location = New System.Drawing.Point(39, 133)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(709, 100)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Valores actuales"
        '
        'TxtFechaActual
        '
        Me.TxtFechaActual.Location = New System.Drawing.Point(608, 41)
        Me.TxtFechaActual.Name = "TxtFechaActual"
        Me.TxtFechaActual.Size = New System.Drawing.Size(86, 23)
        Me.TxtFechaActual.TabIndex = 7
        '
        'TxtDuracionActual
        '
        Me.TxtDuracionActual.Location = New System.Drawing.Point(446, 41)
        Me.TxtDuracionActual.Name = "TxtDuracionActual"
        Me.TxtDuracionActual.Size = New System.Drawing.Size(114, 23)
        Me.TxtDuracionActual.TabIndex = 6
        '
        'TxtValorActual
        '
        Me.TxtValorActual.Location = New System.Drawing.Point(303, 41)
        Me.TxtValorActual.Name = "TxtValorActual"
        Me.TxtValorActual.Size = New System.Drawing.Size(80, 23)
        Me.TxtValorActual.TabIndex = 5
        '
        'TxtLugarActual
        '
        Me.TxtLugarActual.Location = New System.Drawing.Point(72, 41)
        Me.TxtLugarActual.Name = "TxtLugarActual"
        Me.TxtLugarActual.Size = New System.Drawing.Size(171, 23)
        Me.TxtLugarActual.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(566, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 15)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Fecha:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(389, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Duración:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(252, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Valor:  $"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Lugar:"
        '
        'CbxAño
        '
        Me.CbxAño.FormattingEnabled = True
        Me.CbxAño.Location = New System.Drawing.Point(244, 72)
        Me.CbxAño.Name = "CbxAño"
        Me.CbxAño.Size = New System.Drawing.Size(186, 23)
        Me.CbxAño.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Año:"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(966, 583)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.RadioButton3)
        Me.Panel2.Controls.Add(Me.RadioButton2)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 63)
        Me.Panel2.TabIndex = 9
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.FlatAppearance.BorderSize = 0
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(207, 0)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(97, 60)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Baja de campamentos"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(110, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(97, 60)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Modificación de campamentos"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(4, 0)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 65)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Ata de campamentos"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'FrmCampamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmCampamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbxCurso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents TxtCodigoNivel As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents CbxCodigonivel As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents TxtLugar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtCodigoAño As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CbxAño As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CbxCodigoAño As ComboBox
    Friend WithEvents BtnSalirActualiza As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtDuracionNueva As TextBox
    Friend WithEvents TxtValorNuevo As TextBox
    Friend WithEvents TxtLugarNuevo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TxtFechaActual As TextBox
    Friend WithEvents TxtDuracionActual As TextBox
    Friend WithEvents TxtValorActual As TextBox
    Friend WithEvents TxtLugarActual As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents DtpFechaNueva As DateTimePicker
    Friend WithEvents Panel3 As Panel
End Class
