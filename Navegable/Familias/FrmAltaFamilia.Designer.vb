<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAltaFamilia))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblFechaIngreso = New System.Windows.Forms.Label()
        Me.DtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtDniMadre = New System.Windows.Forms.TextBox()
        Me.TxtDniPadre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.LblObservacines = New System.Windows.Forms.Label()
        Me.TxtCantidadDeHijos = New System.Windows.Forms.TextBox()
        Me.LblCantidadDeHijos = New System.Windows.Forms.Label()
        Me.LblDomicilio = New System.Windows.Forms.Label()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtNombreMadre = New System.Windows.Forms.TextBox()
        Me.TxtNombrePadre = New System.Windows.Forms.TextBox()
        Me.TxtApellidoMadre = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPadre = New System.Windows.Forms.TextBox()
        Me.LblNombreMadre = New System.Windows.Forms.Label()
        Me.LLblNombrePadre = New System.Windows.Forms.Label()
        Me.LblApellidoMadre = New System.Windows.Forms.Label()
        Me.LblApellidoPadre = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtEmailPadre = New System.Windows.Forms.TextBox()
        Me.TxtTelFijo = New System.Windows.Forms.TextBox()
        Me.TxtTelCel = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblTelefonoFijo = New System.Windows.Forms.Label()
        Me.LblTelefonoCelular = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtEmailMadre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1041, 77)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(270, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(482, 0)
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
        Me.PictureBox1.Location = New System.Drawing.Point(685, 0)
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
        Me.Panel2.Size = New System.Drawing.Size(1041, 5)
        Me.Panel2.TabIndex = 1
        '
        'LblFechaIngreso
        '
        Me.LblFechaIngreso.AutoSize = True
        Me.LblFechaIngreso.BackColor = System.Drawing.Color.Transparent
        Me.LblFechaIngreso.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblFechaIngreso.Location = New System.Drawing.Point(413, 104)
        Me.LblFechaIngreso.Name = "LblFechaIngreso"
        Me.LblFechaIngreso.Size = New System.Drawing.Size(142, 21)
        Me.LblFechaIngreso.TabIndex = 2
        Me.LblFechaIngreso.Text = "Fecha de Ingreso:"
        '
        'DtpFechaIngreso
        '
        Me.DtpFechaIngreso.CalendarFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaIngreso.Location = New System.Drawing.Point(561, 103)
        Me.DtpFechaIngreso.Name = "DtpFechaIngreso"
        Me.DtpFechaIngreso.Size = New System.Drawing.Size(143, 23)
        Me.DtpFechaIngreso.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtDniMadre)
        Me.GroupBox1.Controls.Add(Me.TxtDniPadre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox1.Controls.Add(Me.LblObservacines)
        Me.GroupBox1.Controls.Add(Me.TxtCantidadDeHijos)
        Me.GroupBox1.Controls.Add(Me.LblCantidadDeHijos)
        Me.GroupBox1.Controls.Add(Me.LblDomicilio)
        Me.GroupBox1.Controls.Add(Me.TxtDomicilio)
        Me.GroupBox1.Controls.Add(Me.TxtNombreMadre)
        Me.GroupBox1.Controls.Add(Me.TxtNombrePadre)
        Me.GroupBox1.Controls.Add(Me.TxtApellidoMadre)
        Me.GroupBox1.Controls.Add(Me.TxtApellidoPadre)
        Me.GroupBox1.Controls.Add(Me.LblNombreMadre)
        Me.GroupBox1.Controls.Add(Me.LLblNombrePadre)
        Me.GroupBox1.Controls.Add(Me.LblApellidoMadre)
        Me.GroupBox1.Controls.Add(Me.LblApellidoPadre)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(977, 298)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos familiares:"
        '
        'TxtDniMadre
        '
        Me.TxtDniMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDniMadre.Location = New System.Drawing.Point(222, 138)
        Me.TxtDniMadre.MaxLength = 10
        Me.TxtDniMadre.Name = "TxtDniMadre"
        Me.TxtDniMadre.Size = New System.Drawing.Size(130, 29)
        Me.TxtDniMadre.TabIndex = 6
        '
        'TxtDniPadre
        '
        Me.TxtDniPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDniPadre.Location = New System.Drawing.Point(222, 63)
        Me.TxtDniPadre.MaxLength = 10
        Me.TxtDniPadre.Name = "TxtDniPadre"
        Me.TxtDniPadre.Size = New System.Drawing.Size(130, 29)
        Me.TxtDniPadre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "DNI:"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservaciones.Location = New System.Drawing.Point(428, 222)
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(517, 60)
        Me.TxtObservaciones.TabIndex = 9
        '
        'LblObservacines
        '
        Me.LblObservacines.AutoSize = True
        Me.LblObservacines.Location = New System.Drawing.Point(296, 222)
        Me.LblObservacines.Name = "LblObservacines"
        Me.LblObservacines.Size = New System.Drawing.Size(126, 21)
        Me.LblObservacines.TabIndex = 12
        Me.LblObservacines.Text = "Observaciones:"
        '
        'TxtCantidadDeHijos
        '
        Me.TxtCantidadDeHijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCantidadDeHijos.Location = New System.Drawing.Point(222, 222)
        Me.TxtCantidadDeHijos.MaxLength = 2
        Me.TxtCantidadDeHijos.Name = "TxtCantidadDeHijos"
        Me.TxtCantidadDeHijos.Size = New System.Drawing.Size(43, 29)
        Me.TxtCantidadDeHijos.TabIndex = 8
        '
        'LblCantidadDeHijos
        '
        Me.LblCantidadDeHijos.AutoSize = True
        Me.LblCantidadDeHijos.Location = New System.Drawing.Point(64, 230)
        Me.LblCantidadDeHijos.Name = "LblCantidadDeHijos"
        Me.LblCantidadDeHijos.Size = New System.Drawing.Size(149, 21)
        Me.LblCantidadDeHijos.TabIndex = 10
        Me.LblCantidadDeHijos.Text = "Cantidad de Hijos:"
        '
        'LblDomicilio
        '
        Me.LblDomicilio.AutoSize = True
        Me.LblDomicilio.Location = New System.Drawing.Point(124, 182)
        Me.LblDomicilio.Name = "LblDomicilio"
        Me.LblDomicilio.Size = New System.Drawing.Size(89, 21)
        Me.LblDomicilio.TabIndex = 9
        Me.LblDomicilio.Text = "Domicilio:"
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDomicilio.Location = New System.Drawing.Point(222, 174)
        Me.TxtDomicilio.MaxLength = 100
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.Size = New System.Drawing.Size(723, 29)
        Me.TxtDomicilio.TabIndex = 7
        '
        'TxtNombreMadre
        '
        Me.TxtNombreMadre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreMadre.Location = New System.Drawing.Point(654, 103)
        Me.TxtNombreMadre.MaxLength = 50
        Me.TxtNombreMadre.Name = "TxtNombreMadre"
        Me.TxtNombreMadre.Size = New System.Drawing.Size(291, 29)
        Me.TxtNombreMadre.TabIndex = 5
        '
        'TxtNombrePadre
        '
        Me.TxtNombrePadre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombrePadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombrePadre.Location = New System.Drawing.Point(654, 28)
        Me.TxtNombrePadre.MaxLength = 50
        Me.TxtNombrePadre.Name = "TxtNombrePadre"
        Me.TxtNombrePadre.Size = New System.Drawing.Size(291, 29)
        Me.TxtNombrePadre.TabIndex = 2
        '
        'TxtApellidoMadre
        '
        Me.TxtApellidoMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellidoMadre.Location = New System.Drawing.Point(222, 103)
        Me.TxtApellidoMadre.MaxLength = 50
        Me.TxtApellidoMadre.Name = "TxtApellidoMadre"
        Me.TxtApellidoMadre.Size = New System.Drawing.Size(242, 29)
        Me.TxtApellidoMadre.TabIndex = 4
        '
        'TxtApellidoPadre
        '
        Me.TxtApellidoPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtApellidoPadre.Location = New System.Drawing.Point(222, 28)
        Me.TxtApellidoPadre.MaxLength = 50
        Me.TxtApellidoPadre.Name = "TxtApellidoPadre"
        Me.TxtApellidoPadre.Size = New System.Drawing.Size(242, 29)
        Me.TxtApellidoPadre.TabIndex = 1
        '
        'LblNombreMadre
        '
        Me.LblNombreMadre.AutoSize = True
        Me.LblNombreMadre.Location = New System.Drawing.Point(477, 111)
        Me.LblNombreMadre.Name = "LblNombreMadre"
        Me.LblNombreMadre.Size = New System.Drawing.Size(171, 21)
        Me.LblNombreMadre.TabIndex = 3
        Me.LblNombreMadre.Text = "Nombre de la Madre:"
        '
        'LLblNombrePadre
        '
        Me.LLblNombrePadre.AutoSize = True
        Me.LLblNombrePadre.Location = New System.Drawing.Point(495, 36)
        Me.LLblNombrePadre.Name = "LLblNombrePadre"
        Me.LLblNombrePadre.Size = New System.Drawing.Size(153, 21)
        Me.LLblNombrePadre.TabIndex = 2
        Me.LLblNombrePadre.Text = "Nombre del Padre:"
        '
        'LblApellidoMadre
        '
        Me.LblApellidoMadre.AutoSize = True
        Me.LblApellidoMadre.Location = New System.Drawing.Point(40, 111)
        Me.LblApellidoMadre.Name = "LblApellidoMadre"
        Me.LblApellidoMadre.Size = New System.Drawing.Size(173, 21)
        Me.LblApellidoMadre.TabIndex = 1
        Me.LblApellidoMadre.Text = "Apellido de la Madre:"
        '
        'LblApellidoPadre
        '
        Me.LblApellidoPadre.AutoSize = True
        Me.LblApellidoPadre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblApellidoPadre.Location = New System.Drawing.Point(58, 36)
        Me.LblApellidoPadre.Name = "LblApellidoPadre"
        Me.LblApellidoPadre.Size = New System.Drawing.Size(155, 21)
        Me.LblApellidoPadre.TabIndex = 0
        Me.LblApellidoPadre.Text = "Apellido del Padre:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtEmailMadre)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtEmailPadre)
        Me.GroupBox2.Controls.Add(Me.TxtTelFijo)
        Me.GroupBox2.Controls.Add(Me.TxtTelCel)
        Me.GroupBox2.Controls.Add(Me.LblEmail)
        Me.GroupBox2.Controls.Add(Me.LblTelefonoFijo)
        Me.GroupBox2.Controls.Add(Me.LblTelefonoCelular)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 460)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(796, 150)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Contacto"
        '
        'TxtEmailPadre
        '
        Me.TxtEmailPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmailPadre.Location = New System.Drawing.Point(296, 66)
        Me.TxtEmailPadre.MaxLength = 50
        Me.TxtEmailPadre.Name = "TxtEmailPadre"
        Me.TxtEmailPadre.Size = New System.Drawing.Size(345, 29)
        Me.TxtEmailPadre.TabIndex = 12
        '
        'TxtTelFijo
        '
        Me.TxtTelFijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelFijo.Location = New System.Drawing.Point(541, 23)
        Me.TxtTelFijo.MaxLength = 20
        Me.TxtTelFijo.Name = "TxtTelFijo"
        Me.TxtTelFijo.Size = New System.Drawing.Size(179, 29)
        Me.TxtTelFijo.TabIndex = 11
        '
        'TxtTelCel
        '
        Me.TxtTelCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTelCel.Location = New System.Drawing.Point(197, 23)
        Me.TxtTelCel.MaxLength = 20
        Me.TxtTelCel.Name = "TxtTelCel"
        Me.TxtTelCel.Size = New System.Drawing.Size(189, 29)
        Me.TxtTelCel.TabIndex = 10
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(67, 73)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(225, 21)
        Me.LblEmail.TabIndex = 2
        Me.LblEmail.Text = "Correo electónico del padre:"
        '
        'LblTelefonoFijo
        '
        Me.LblTelefonoFijo.AutoSize = True
        Me.LblTelefonoFijo.Location = New System.Drawing.Point(422, 31)
        Me.LblTelefonoFijo.Name = "LblTelefonoFijo"
        Me.LblTelefonoFijo.Size = New System.Drawing.Size(113, 21)
        Me.LblTelefonoFijo.TabIndex = 1
        Me.LblTelefonoFijo.Text = "Teléfono Fijo:"
        '
        'LblTelefonoCelular
        '
        Me.LblTelefonoCelular.AutoSize = True
        Me.LblTelefonoCelular.Location = New System.Drawing.Point(58, 31)
        Me.LblTelefonoCelular.Name = "LblTelefonoCelular"
        Me.LblTelefonoCelular.Size = New System.Drawing.Size(140, 21)
        Me.LblTelefonoCelular.TabIndex = 0
        Me.LblTelefonoCelular.Text = "Teléfono Celular:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnGuardar.BackColor = System.Drawing.Color.White
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Location = New System.Drawing.Point(906, 489)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(81, 59)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalir.Location = New System.Drawing.Point(906, 560)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(81, 59)
        Me.BtnSalir.TabIndex = 14
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'TxtEmailMadre
        '
        Me.TxtEmailMadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEmailMadre.Location = New System.Drawing.Point(296, 101)
        Me.TxtEmailMadre.MaxLength = 50
        Me.TxtEmailMadre.Name = "TxtEmailMadre"
        Me.TxtEmailMadre.Size = New System.Drawing.Size(345, 29)
        Me.TxtEmailMadre.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 21)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Correo electónico de la madre:"
        '
        'FrmAltaFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1041, 645)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DtpFechaIngreso)
        Me.Controls.Add(Me.LblFechaIngreso)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmAltaFamilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de familias"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LblFechaIngreso As Label
    Friend WithEvents DtpFechaIngreso As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblDomicilio As Label
    Friend WithEvents TxtDomicilio As TextBox
    Friend WithEvents TxtNombreMadre As TextBox
    Friend WithEvents TxtNombrePadre As TextBox
    Friend WithEvents TxtApellidoMadre As TextBox
    Friend WithEvents TxtApellidoPadre As TextBox
    Friend WithEvents LblNombreMadre As Label
    Friend WithEvents LLblNombrePadre As Label
    Friend WithEvents LblApellidoMadre As Label
    Friend WithEvents LblApellidoPadre As Label
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents LblObservacines As Label
    Friend WithEvents TxtCantidadDeHijos As TextBox
    Friend WithEvents LblCantidadDeHijos As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtEmailPadre As TextBox
    Friend WithEvents TxtTelFijo As TextBox
    Friend WithEvents TxtTelCel As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblTelefonoFijo As Label
    Friend WithEvents LblTelefonoCelular As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtDniMadre As TextBox
    Friend WithEvents TxtDniPadre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEmailMadre As TextBox
    Friend WithEvents Label3 As Label
End Class
