<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBajasFamilias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBajasFamilias))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.CbxCodigo = New System.Windows.Forms.ComboBox()
        Me.LblCodigo = New System.Windows.Forms.Label()
        Me.CbxFamilia = New System.Windows.Forms.ComboBox()
        Me.LblFamilia = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnReincorporar = New System.Windows.Forms.Button()
        Me.CbxReincorporaCodigo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxReincorporaFamilia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
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
        Me.Panel1.Size = New System.Drawing.Size(974, 85)
        Me.Panel1.TabIndex = 37
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(131, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(86, 85)
        Me.PictureBox3.TabIndex = 40
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(413, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 85)
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(685, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 85)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 85)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 6)
        Me.Panel2.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.CbxCodigo)
        Me.GroupBox1.Controls.Add(Me.LblCodigo)
        Me.GroupBox1.Controls.Add(Me.CbxFamilia)
        Me.GroupBox1.Controls.Add(Me.LblFamilia)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(891, 152)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bajas"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.White
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.ForeColor = System.Drawing.Color.Black
        Me.BtnEliminar.Location = New System.Drawing.Point(367, 96)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(123, 36)
        Me.BtnEliminar.TabIndex = 40
        Me.BtnEliminar.Text = "Dar de baja"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'CbxCodigo
        '
        Me.CbxCodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CbxCodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbxCodigo.BackColor = System.Drawing.Color.White
        Me.CbxCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CbxCodigo.ForeColor = System.Drawing.Color.Black
        Me.CbxCodigo.FormattingEnabled = True
        Me.CbxCodigo.Location = New System.Drawing.Point(103, 45)
        Me.CbxCodigo.Name = "CbxCodigo"
        Me.CbxCodigo.Size = New System.Drawing.Size(138, 29)
        Me.CbxCodigo.TabIndex = 3
        '
        'LblCodigo
        '
        Me.LblCodigo.AutoSize = True
        Me.LblCodigo.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblCodigo.Location = New System.Drawing.Point(28, 53)
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
        Me.CbxFamilia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CbxFamilia.ForeColor = System.Drawing.Color.Black
        Me.CbxFamilia.FormattingEnabled = True
        Me.CbxFamilia.Location = New System.Drawing.Point(367, 45)
        Me.CbxFamilia.Name = "CbxFamilia"
        Me.CbxFamilia.Size = New System.Drawing.Size(490, 29)
        Me.CbxFamilia.TabIndex = 1
        '
        'LblFamilia
        '
        Me.LblFamilia.AutoSize = True
        Me.LblFamilia.ForeColor = System.Drawing.Color.OrangeRed
        Me.LblFamilia.Location = New System.Drawing.Point(291, 53)
        Me.LblFamilia.Name = "LblFamilia"
        Me.LblFamilia.Size = New System.Drawing.Size(70, 21)
        Me.LblFamilia.TabIndex = 0
        Me.LblFamilia.Text = "Familia:"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.ForeColor = System.Drawing.Color.Black
        Me.BtnSalir.Location = New System.Drawing.Point(711, 554)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(95, 36)
        Me.BtnSalir.TabIndex = 41
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnReincorporar
        '
        Me.BtnReincorporar.BackColor = System.Drawing.Color.White
        Me.BtnReincorporar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnReincorporar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnReincorporar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReincorporar.ForeColor = System.Drawing.Color.Black
        Me.BtnReincorporar.Location = New System.Drawing.Point(367, 97)
        Me.BtnReincorporar.Name = "BtnReincorporar"
        Me.BtnReincorporar.Size = New System.Drawing.Size(123, 36)
        Me.BtnReincorporar.TabIndex = 40
        Me.BtnReincorporar.Text = "Reincorporar"
        Me.BtnReincorporar.UseVisualStyleBackColor = False
        '
        'CbxReincorporaCodigo
        '
        Me.CbxReincorporaCodigo.BackColor = System.Drawing.Color.White
        Me.CbxReincorporaCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxReincorporaCodigo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CbxReincorporaCodigo.ForeColor = System.Drawing.Color.Black
        Me.CbxReincorporaCodigo.FormattingEnabled = True
        Me.CbxReincorporaCodigo.Location = New System.Drawing.Point(103, 46)
        Me.CbxReincorporaCodigo.Name = "CbxReincorporaCodigo"
        Me.CbxReincorporaCodigo.Size = New System.Drawing.Size(138, 29)
        Me.CbxReincorporaCodigo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(28, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Código:"
        '
        'CbxReincorporaFamilia
        '
        Me.CbxReincorporaFamilia.BackColor = System.Drawing.Color.White
        Me.CbxReincorporaFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxReincorporaFamilia.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CbxReincorporaFamilia.ForeColor = System.Drawing.Color.Black
        Me.CbxReincorporaFamilia.FormattingEnabled = True
        Me.CbxReincorporaFamilia.Location = New System.Drawing.Point(367, 46)
        Me.CbxReincorporaFamilia.Name = "CbxReincorporaFamilia"
        Me.CbxReincorporaFamilia.Size = New System.Drawing.Size(490, 29)
        Me.CbxReincorporaFamilia.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(291, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Familia:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnReincorporar)
        Me.GroupBox2.Controls.Add(Me.CbxReincorporaCodigo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CbxReincorporaFamilia)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(46, 362)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(891, 160)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reincorporaciones"
        '
        'FrmBajasFamilias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.Color.OrangeRed
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBajasFamilias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bajas y reincorporaciones de familias"
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
    Friend WithEvents CbxCodigo As ComboBox
    Friend WithEvents LblCodigo As Label
    Friend WithEvents CbxFamilia As ComboBox
    Friend WithEvents LblFamilia As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnReincorporar As Button
    Friend WithEvents CbxReincorporaCodigo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxReincorporaFamilia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
