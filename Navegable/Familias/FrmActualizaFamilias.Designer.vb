<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmActualizaFamilias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActualizaFamilias))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxCodigo = New System.Windows.Forms.ComboBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.CbxFamilia = New System.Windows.Forms.ComboBox()
        Me.LblFamilia = New System.Windows.Forms.Label()
        Me.DtpModificacion = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtMovilPadre = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEmailMadre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDniPadre = New System.Windows.Forms.TextBox()
        Me.TxtDniMadre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNombrePadre = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPadre = New System.Windows.Forms.TextBox()
        Me.TxtNombreMadre = New System.Windows.Forms.TextBox()
        Me.TxtApellidoMadre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtEmailPadre = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtTelFijo = New System.Windows.Forms.TextBox()
        Me.TxtMovilMadre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.TxtNumeroHijos = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.LblObservaciones = New System.Windows.Forms.Label()
        Me.LblNumeroHijos = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(1034, 77)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(282, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(475, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(667, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1034, 5)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CbxCodigo)
        Me.GroupBox1.Controls.Add(Me.LblCodigo)
        Me.GroupBox1.Controls.Add(Me.CbxFamilia)
        Me.GroupBox1.Controls.Add(Me.LblFamilia)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(974, 70)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar familia"
        '
        'CbxCodigo
        '
        Me.CbxCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxCodigo.BackColor = System.Drawing.Color.White
        Me.CbxCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigo.FormattingEnabled = True
        Me.CbxCodigo.Location = New System.Drawing.Point(90, 25)
        Me.CbxCodigo.Name = "CbxCodigo"
        Me.CbxCodigo.Size = New System.Drawing.Size(121, 29)
        Me.CbxCodigo.TabIndex = 2
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblCodigo.Location = New System.Drawing.Point(15, 33)
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
        Me.CbxFamilia.Location = New System.Drawing.Point(363, 25)
        Me.CbxFamilia.Name = "CbxFamilia"
        Me.CbxFamilia.Size = New System.Drawing.Size(374, 29)
        Me.CbxFamilia.TabIndex = 3
        '
        'LblFamilia
        '
        Me.LblFamilia.AutoSize = True
        Me.LblFamilia.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblFamilia.Location = New System.Drawing.Point(287, 33)
        Me.LblFamilia.Name = "LblFamilia"
        Me.LblFamilia.Size = New System.Drawing.Size(70, 21)
        Me.LblFamilia.TabIndex = 0
        Me.LblFamilia.Text = "Familia:"
        '
        'DtpModificacion
        '
        Me.DtpModificacion.Enabled = False
        Me.DtpModificacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpModificacion.Location = New System.Drawing.Point(408, 85)
        Me.DtpModificacion.Name = "DtpModificacion"
        Me.DtpModificacion.Size = New System.Drawing.Size(200, 29)
        Me.DtpModificacion.TabIndex = 1
        Me.DtpModificacion.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtMovilPadre)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TxtEmailMadre)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtDniPadre)
        Me.GroupBox2.Controls.Add(Me.TxtDniMadre)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtNombrePadre)
        Me.GroupBox2.Controls.Add(Me.TxtApellidoPadre)
        Me.GroupBox2.Controls.Add(Me.TxtNombreMadre)
        Me.GroupBox2.Controls.Add(Me.TxtApellidoMadre)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtEmailPadre)
        Me.GroupBox2.Controls.Add(Me.BtnGuardar)
        Me.GroupBox2.Controls.Add(Me.TxtTelFijo)
        Me.GroupBox2.Controls.Add(Me.TxtMovilMadre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox2.Controls.Add(Me.TxtNumeroHijos)
        Me.GroupBox2.Controls.Add(Me.TxtDomicilio)
        Me.GroupBox2.Controls.Add(Me.LblObservaciones)
        Me.GroupBox2.Controls.Add(Me.LblNumeroHijos)
        Me.GroupBox2.Controls.Add(Me.LblDomicilio)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(28, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(974, 342)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Panel de actualización "
        '
        'TxtMovilPadre
        '
        Me.TxtMovilPadre.BackColor = System.Drawing.Color.White
        Me.TxtMovilPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMovilPadre.Location = New System.Drawing.Point(507, 218)
        Me.TxtMovilPadre.MaxLength = 20
        Me.TxtMovilPadre.Name = "TxtMovilPadre"
        Me.TxtMovilPadre.Size = New System.Drawing.Size(176, 29)
        Me.TxtMovilPadre.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(397, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 21)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Movil padre:"
        '
        'TxtEmailMadre
        '
        Me.TxtEmailMadre.BackColor = System.Drawing.Color.White
        Me.TxtEmailMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmailMadre.Location = New System.Drawing.Point(184, 168)
        Me.TxtEmailMadre.MaxLength = 50
        Me.TxtEmailMadre.Name = "TxtEmailMadre"
        Me.TxtEmailMadre.Size = New System.Drawing.Size(308, 29)
        Me.TxtEmailMadre.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(22, 173)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(157, 21)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "e-mail de la madre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtDniPadre
        '
        Me.TxtDniPadre.Location = New System.Drawing.Point(847, 81)
        Me.TxtDniPadre.Name = "TxtDniPadre"
        Me.TxtDniPadre.Size = New System.Drawing.Size(108, 29)
        Me.TxtDniPadre.TabIndex = 22
        '
        'TxtDniMadre
        '
        Me.TxtDniMadre.Location = New System.Drawing.Point(847, 38)
        Me.TxtDniMadre.Name = "TxtDniMadre"
        Me.TxtDniMadre.Size = New System.Drawing.Size(108, 29)
        Me.TxtDniMadre.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(797, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "DNI:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(797, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 21)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "DNI:"
        '
        'TxtNombrePadre
        '
        Me.TxtNombrePadre.Location = New System.Drawing.Point(621, 78)
        Me.TxtNombrePadre.MaxLength = 50
        Me.TxtNombrePadre.Name = "TxtNombrePadre"
        Me.TxtNombrePadre.Size = New System.Drawing.Size(170, 29)
        Me.TxtNombrePadre.TabIndex = 18
        '
        'TxtApellidoPadre
        '
        Me.TxtApellidoPadre.Location = New System.Drawing.Point(186, 78)
        Me.TxtApellidoPadre.MaxLength = 50
        Me.TxtApellidoPadre.Name = "TxtApellidoPadre"
        Me.TxtApellidoPadre.Size = New System.Drawing.Size(243, 29)
        Me.TxtApellidoPadre.TabIndex = 17
        '
        'TxtNombreMadre
        '
        Me.TxtNombreMadre.Location = New System.Drawing.Point(621, 33)
        Me.TxtNombreMadre.MaxLength = 50
        Me.TxtNombreMadre.Name = "TxtNombreMadre"
        Me.TxtNombreMadre.Size = New System.Drawing.Size(170, 29)
        Me.TxtNombreMadre.TabIndex = 16
        '
        'TxtApellidoMadre
        '
        Me.TxtApellidoMadre.Location = New System.Drawing.Point(187, 30)
        Me.TxtApellidoMadre.MaxLength = 50
        Me.TxtApellidoMadre.Name = "TxtApellidoMadre"
        Me.TxtApellidoMadre.Size = New System.Drawing.Size(243, 29)
        Me.TxtApellidoMadre.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nombre del padre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Apellido de padre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(444, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Nombre de la madre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 21)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Apellido de la madre:"
        '
        'TxtEmailPadre
        '
        Me.TxtEmailPadre.BackColor = System.Drawing.Color.White
        Me.TxtEmailPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmailPadre.Location = New System.Drawing.Point(641, 166)
        Me.TxtEmailPadre.MaxLength = 50
        Me.TxtEmailPadre.Name = "TxtEmailPadre"
        Me.TxtEmailPadre.Size = New System.Drawing.Size(314, 29)
        Me.TxtEmailPadre.TabIndex = 8
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.White
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(827, 288)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(98, 32)
        Me.BtnGuardar.TabIndex = 10
        Me.BtnGuardar.Text = "Actualizar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtTelFijo
        '
        Me.TxtTelFijo.BackColor = System.Drawing.Color.White
        Me.TxtTelFijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelFijo.Location = New System.Drawing.Point(774, 216)
        Me.TxtTelFijo.MaxLength = 20
        Me.TxtTelFijo.Name = "TxtTelFijo"
        Me.TxtTelFijo.Size = New System.Drawing.Size(181, 29)
        Me.TxtTelFijo.TabIndex = 7
        '
        'TxtMovilMadre
        '
        Me.TxtMovilMadre.BackColor = System.Drawing.Color.White
        Me.TxtMovilMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMovilMadre.Location = New System.Drawing.Point(183, 218)
        Me.TxtMovilMadre.MaxLength = 20
        Me.TxtMovilMadre.Name = "TxtMovilMadre"
        Me.TxtMovilMadre.Size = New System.Drawing.Size(176, 29)
        Me.TxtMovilMadre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(496, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "e-mail del padre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(727, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fijo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(67, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Movil madre:"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BackColor = System.Drawing.Color.White
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservaciones.Location = New System.Drawing.Point(180, 271)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(503, 49)
        Me.TxtObservaciones.TabIndex = 9
        '
        'TxtNumeroHijos
        '
        Me.TxtNumeroHijos.BackColor = System.Drawing.Color.White
        Me.TxtNumeroHijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNumeroHijos.Location = New System.Drawing.Point(847, 122)
        Me.TxtNumeroHijos.MaxLength = 2
        Me.TxtNumeroHijos.Name = "TxtNumeroHijos"
        Me.TxtNumeroHijos.Size = New System.Drawing.Size(35, 29)
        Me.TxtNumeroHijos.TabIndex = 5
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.BackColor = System.Drawing.Color.White
        Me.TxtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDomicilio.Location = New System.Drawing.Point(185, 123)
        Me.TxtDomicilio.MaxLength = 100
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(503, 29)
        Me.TxtDomicilio.TabIndex = 4
        '
        'LblObservaciones
        '
        Me.LblObservaciones.AutoSize = True
        Me.LblObservaciones.ForeColor = System.Drawing.Color.Black
        Me.LblObservaciones.Location = New System.Drawing.Point(48, 273)
        Me.LblObservaciones.Name = "LblObservaciones"
        Me.LblObservaciones.Size = New System.Drawing.Size(126, 21)
        Me.LblObservaciones.TabIndex = 2
        Me.LblObservaciones.Text = "Observaciones:"
        '
        'LblNumeroHijos
        '
        Me.LblNumeroHijos.AutoSize = True
        Me.LblNumeroHijos.ForeColor = System.Drawing.Color.Black
        Me.LblNumeroHijos.Location = New System.Drawing.Point(700, 128)
        Me.LblNumeroHijos.Name = "LblNumeroHijos"
        Me.LblNumeroHijos.Size = New System.Drawing.Size(141, 21)
        Me.LblNumeroHijos.TabIndex = 1
        Me.LblNumeroHijos.Text = "Número de hijos:"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.ForeColor = System.Drawing.Color.Black
        Me.LblDomicilio.Location = New System.Drawing.Point(91, 128)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(89, 21)
        Me.LblDomicilio.TabIndex = 0
        Me.LblDomicilio.Text = "Domicilio:"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(872, 563)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(98, 32)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmActualizaFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1034, 611)
        Me.Controls.Add(Me.DtpModificacion)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmActualizaFamilias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario de actualización de datos de familia"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbxFamilia As ComboBox
    Friend WithEvents LblFamilia As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents TxtNumeroHijos As TextBox
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents LblObservaciones As Label
    Friend WithEvents LblNumeroHijos As Label
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents TxtEmailPadre As TextBox
    Friend WithEvents TxtTelFijo As TextBox
    Friend WithEvents TxtMovilMadre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxCodigo As ComboBox
    Friend WithEvents LblCodigo As Label
    Friend WithEvents DtpModificacion As DateTimePicker
    Friend WithEvents TxtApellidoMadre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtEmailMadre As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDniPadre As TextBox
    Friend WithEvents TxtDniMadre As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNombrePadre As TextBox
    Friend WithEvents TxtApellidoPadre As TextBox
    Friend WithEvents TxtNombreMadre As TextBox
    Friend WithEvents TxtMovilPadre As TextBox
    Friend WithEvents Label11 As Label
End Class
