<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoDePagos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIngresoDePagos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxFamilia = New System.Windows.Forms.ComboBox()
        Me.CbxCodigo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TxtCredito = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTransferencia = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.TxtCheque = New System.Windows.Forms.TextBox()
        Me.TxtEfectivo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtComedor = New System.Windows.Forms.TextBox()
        Me.TxtAdicionalJardin = New System.Windows.Forms.TextBox()
        Me.TxtTalleres = New System.Windows.Forms.TextBox()
        Me.TxtMateriales = New System.Windows.Forms.TextBox()
        Me.TxtArancel = New System.Windows.Forms.TextBox()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(974, 77)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(670, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(442, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(230, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 5)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbxFamilia)
        Me.GroupBox1.Controls.Add(Me.CbxCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(921, 81)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elección de familia"
        '
        'CbxFamilia
        '
        Me.CbxFamilia.FormattingEnabled = True
        Me.CbxFamilia.Location = New System.Drawing.Point(463, 28)
        Me.CbxFamilia.Name = "CbxFamilia"
        Me.CbxFamilia.Size = New System.Drawing.Size(395, 29)
        Me.CbxFamilia.TabIndex = 3
        '
        'CbxCodigo
        '
        Me.CbxCodigo.FormattingEnabled = True
        Me.CbxCodigo.Location = New System.Drawing.Point(235, 28)
        Me.CbxCodigo.Name = "CbxCodigo"
        Me.CbxCodigo.Size = New System.Drawing.Size(121, 29)
        Me.CbxCodigo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(396, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Familia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(94, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de familia:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TxtCredito)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtTransferencia)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DtpFechaPago)
        Me.GroupBox2.Controls.Add(Me.TxtCheque)
        Me.GroupBox2.Controls.Add(Me.TxtEfectivo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 203)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 323)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "forma de pago"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(54, 222)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 21)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Dévito:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(115, 214)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(80, 29)
        Me.TextBox1.TabIndex = 14
        '
        'TxtCredito
        '
        Me.TxtCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCredito.Location = New System.Drawing.Point(115, 74)
        Me.TxtCredito.Name = "TxtCredito"
        Me.TxtCredito.Size = New System.Drawing.Size(80, 29)
        Me.TxtCredito.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(48, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 21)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Crédito:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Transferencia:"
        '
        'TxtTransferencia
        '
        Me.TxtTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTransferencia.Location = New System.Drawing.Point(115, 179)
        Me.TxtTransferencia.Name = "TxtTransferencia"
        Me.TxtTransferencia.Size = New System.Drawing.Size(80, 29)
        Me.TxtTransferencia.TabIndex = 10
        '
        'TxtTotal
        '
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Location = New System.Drawing.Point(115, 249)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 29)
        Me.TxtTotal.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(247, 144)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(135, 29)
        Me.TextBox3.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(115, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Fecha:"
        '
        'DtpFechaPago
        '
        Me.DtpFechaPago.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaPago.Location = New System.Drawing.Point(174, 25)
        Me.DtpFechaPago.Name = "DtpFechaPago"
        Me.DtpFechaPago.Size = New System.Drawing.Size(165, 29)
        Me.DtpFechaPago.TabIndex = 0
        '
        'TxtCheque
        '
        Me.TxtCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCheque.Location = New System.Drawing.Point(115, 144)
        Me.TxtCheque.Name = "TxtCheque"
        Me.TxtCheque.Size = New System.Drawing.Size(80, 29)
        Me.TxtCheque.TabIndex = 7
        '
        'TxtEfectivo
        '
        Me.TxtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEfectivo.Location = New System.Drawing.Point(115, 109)
        Me.TxtEfectivo.Name = "TxtEfectivo"
        Me.TxtEfectivo.Size = New System.Drawing.Size(80, 29)
        Me.TxtEfectivo.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label7.Location = New System.Drawing.Point(19, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Pago total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(205, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 21)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nº :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Cheque:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Efectivo:"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.White
        Me.BtnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnNuevo.Location = New System.Drawing.Point(810, 292)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(96, 36)
        Me.BtnNuevo.TabIndex = 4
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalir.Location = New System.Drawing.Point(811, 490)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(95, 36)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TxtComedor)
        Me.GroupBox3.Controls.Add(Me.TxtAdicionalJardin)
        Me.GroupBox3.Controls.Add(Me.TxtTalleres)
        Me.GroupBox3.Controls.Add(Me.TxtMateriales)
        Me.GroupBox3.Controls.Add(Me.TxtArancel)
        Me.GroupBox3.Controls.Add(Me.TxtMatricula)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(472, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 323)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Concepto"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(88, 169)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 21)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Campamento:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(198, 163)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 29)
        Me.TextBox2.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(111, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(84, 21)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Comerdor:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(70, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 21)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Adicional jardín :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 21)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Talleres:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(110, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 21)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Materiales:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(115, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 21)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Aranceles:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(117, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Matrícula:"
        '
        'TxtComedor
        '
        Me.TxtComedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtComedor.Location = New System.Drawing.Point(198, 234)
        Me.TxtComedor.Name = "TxtComedor"
        Me.TxtComedor.Size = New System.Drawing.Size(100, 29)
        Me.TxtComedor.TabIndex = 5
        '
        'TxtAdicionalJardin
        '
        Me.TxtAdicionalJardin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAdicionalJardin.Location = New System.Drawing.Point(198, 198)
        Me.TxtAdicionalJardin.Name = "TxtAdicionalJardin"
        Me.TxtAdicionalJardin.Size = New System.Drawing.Size(100, 29)
        Me.TxtAdicionalJardin.TabIndex = 4
        '
        'TxtTalleres
        '
        Me.TxtTalleres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTalleres.Location = New System.Drawing.Point(198, 128)
        Me.TxtTalleres.Name = "TxtTalleres"
        Me.TxtTalleres.Size = New System.Drawing.Size(100, 29)
        Me.TxtTalleres.TabIndex = 3
        '
        'TxtMateriales
        '
        Me.TxtMateriales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMateriales.Location = New System.Drawing.Point(198, 93)
        Me.TxtMateriales.Name = "TxtMateriales"
        Me.TxtMateriales.Size = New System.Drawing.Size(100, 29)
        Me.TxtMateriales.TabIndex = 2
        '
        'TxtArancel
        '
        Me.TxtArancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtArancel.Location = New System.Drawing.Point(198, 58)
        Me.TxtArancel.Name = "TxtArancel"
        Me.TxtArancel.Size = New System.Drawing.Size(100, 29)
        Me.TxtArancel.TabIndex = 1
        '
        'TxtMatricula
        '
        Me.TxtMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMatricula.Location = New System.Drawing.Point(198, 23)
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.Size = New System.Drawing.Size(100, 29)
        Me.TxtMatricula.TabIndex = 0
        '
        'FrmIngresoDePagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(974, 571)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FrmIngresoDePagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INGRESO DE PAGOS"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbxFamilia As ComboBox
    Friend WithEvents CbxCodigo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TxtCheque As TextBox
    Friend WithEvents TxtEfectivo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFechaPago As DateTimePicker
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTransferencia As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtComedor As TextBox
    Friend WithEvents TxtAdicionalJardin As TextBox
    Friend WithEvents TxtTalleres As TextBox
    Friend WithEvents TxtMateriales As TextBox
    Friend WithEvents TxtArancel As TextBox
    Friend WithEvents TxtMatricula As TextBox
    Friend WithEvents TxtCredito As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
