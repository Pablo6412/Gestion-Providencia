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
        Me.GroupBox1.Location = New System.Drawing.Point(25, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 117)
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
        Me.DtpModificacion.Visible = False
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
        Me.BtnSalir.Location = New System.Drawing.Point(815, 522)
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
        Me.GroupBox2.Location = New System.Drawing.Point(169, 278)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 321)
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
        Me.RdbSinAsignar1.Location = New System.Drawing.Point(68, 143)
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
        Me.RdbSinAsignar3.Location = New System.Drawing.Point(68, 219)
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
        Me.RdbMediaBeca.Location = New System.Drawing.Point(68, 72)
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
        Me.RdbSinAsignar2.Location = New System.Drawing.Point(68, 180)
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
        Me.RdbNinguna.Location = New System.Drawing.Point(68, 106)
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
        Me.RdbBecaEntera.Location = New System.Drawing.Point(68, 35)
        Me.RdbBecaEntera.Name = "RdbBecaEntera"
        Me.RdbBecaEntera.Size = New System.Drawing.Size(104, 24)
        Me.RdbBecaEntera.TabIndex = 6
        Me.RdbBecaEntera.TabStop = True
        Me.RdbBecaEntera.Text = "Beca entera"
        Me.RdbBecaEntera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RdbBecaEntera.UseVisualStyleBackColor = True
        '
        'FrmDescuentosBecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDescuentosBecas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDescuentosBecas"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
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
End Class
