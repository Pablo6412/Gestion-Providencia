<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBajaAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBajaAlumnos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.ColDNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnBajaAlumno = New System.Windows.Forms.Button()
        Me.CbxAlumno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxCodigoAlumno = New System.Windows.Forms.ComboBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.CbxNumeroOrden = New System.Windows.Forms.ComboBox()
        Me.TxtCuenta = New System.Windows.Forms.TextBox()
        Me.CbxCodigoFamilia = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMayor = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 77)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(974, 77)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(461, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(660, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(244, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 5)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DgvAlumnos)
        Me.GroupBox1.Controls.Add(Me.BtnBajaAlumno)
        Me.GroupBox1.Controls.Add(Me.CbxAlumno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(44, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 184)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'DgvAlumnos
        '
        Me.DgvAlumnos.BackgroundColor = System.Drawing.Color.OrangeRed
        Me.DgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColDNI, Me.ColEdad, Me.ColCurso})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvAlumnos.DefaultCellStyle = DataGridViewCellStyle1
        Me.DgvAlumnos.Location = New System.Drawing.Point(263, 71)
        Me.DgvAlumnos.Name = "DgvAlumnos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvAlumnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvAlumnos.RowTemplate.Height = 25
        Me.DgvAlumnos.Size = New System.Drawing.Size(383, 76)
        Me.DgvAlumnos.TabIndex = 4
        '
        'ColDNI
        '
        Me.ColDNI.DataPropertyName = "dni"
        Me.ColDNI.HeaderText = "DNI"
        Me.ColDNI.Name = "ColDNI"
        Me.ColDNI.ReadOnly = True
        '
        'ColEdad
        '
        Me.ColEdad.DataPropertyName = "Edad"
        Me.ColEdad.HeaderText = "Edad"
        Me.ColEdad.Name = "ColEdad"
        Me.ColEdad.ReadOnly = True
        '
        'ColCurso
        '
        Me.ColCurso.DataPropertyName = "curso"
        Me.ColCurso.HeaderText = "Curso"
        Me.ColCurso.Name = "ColCurso"
        Me.ColCurso.ReadOnly = True
        Me.ColCurso.Width = 140
        '
        'BtnBajaAlumno
        '
        Me.BtnBajaAlumno.BackColor = System.Drawing.Color.White
        Me.BtnBajaAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnBajaAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnBajaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBajaAlumno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBajaAlumno.Location = New System.Drawing.Point(703, 138)
        Me.BtnBajaAlumno.Name = "BtnBajaAlumno"
        Me.BtnBajaAlumno.Size = New System.Drawing.Size(75, 30)
        Me.BtnBajaAlumno.TabIndex = 2
        Me.BtnBajaAlumno.Text = "Baja"
        Me.BtnBajaAlumno.UseVisualStyleBackColor = False
        '
        'CbxAlumno
        '
        Me.CbxAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxAlumno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxAlumno.FormattingEnabled = True
        Me.CbxAlumno.Location = New System.Drawing.Point(231, 36)
        Me.CbxAlumno.Name = "CbxAlumno"
        Me.CbxAlumno.Size = New System.Drawing.Size(443, 29)
        Me.CbxAlumno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(157, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alumno:"
        '
        'CbxCodigoAlumno
        '
        Me.CbxCodigoAlumno.FormattingEnabled = True
        Me.CbxCodigoAlumno.Location = New System.Drawing.Point(165, 488)
        Me.CbxCodigoAlumno.Name = "CbxCodigoAlumno"
        Me.CbxCodigoAlumno.Size = New System.Drawing.Size(117, 23)
        Me.CbxCodigoAlumno.TabIndex = 3
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalir.Location = New System.Drawing.Point(747, 538)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 30)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(355, 318)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(254, 291)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'CbxNumeroOrden
        '
        Me.CbxNumeroOrden.FormattingEnabled = True
        Me.CbxNumeroOrden.Location = New System.Drawing.Point(162, 358)
        Me.CbxNumeroOrden.Name = "CbxNumeroOrden"
        Me.CbxNumeroOrden.Size = New System.Drawing.Size(121, 23)
        Me.CbxNumeroOrden.TabIndex = 7
        '
        'TxtCuenta
        '
        Me.TxtCuenta.Location = New System.Drawing.Point(161, 387)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(100, 23)
        Me.TxtCuenta.TabIndex = 8
        '
        'CbxCodigoFamilia
        '
        Me.CbxCodigoFamilia.FormattingEnabled = True
        Me.CbxCodigoFamilia.Location = New System.Drawing.Point(161, 416)
        Me.CbxCodigoFamilia.Name = "CbxCodigoFamilia"
        Me.CbxCodigoFamilia.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoFamilia.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 361)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Numero orden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 394)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cuenta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Codigo familia"
        '
        'TxtMayor
        '
        Me.TxtMayor.Location = New System.Drawing.Point(161, 446)
        Me.TxtMayor.Name = "TxtMayor"
        Me.TxtMayor.Size = New System.Drawing.Size(100, 23)
        Me.TxtMayor.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Location = New System.Drawing.Point(72, 340)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(230, 178)
        Me.Panel4.TabIndex = 14
        '
        'FrmBajaAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.TxtMayor)
        Me.Controls.Add(Me.CbxCodigoAlumno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbxCodigoFamilia)
        Me.Controls.Add(Me.TxtCuenta)
        Me.Controls.Add(Me.CbxNumeroOrden)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmBajaAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BAJA DE ALUMNOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnBajaAlumno As Button
    Friend WithEvents CbxAlumno As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CbxCodigoAlumno As ComboBox
    Friend WithEvents CbxNumeroOrden As ComboBox
    Friend WithEvents TxtCuenta As TextBox
    Friend WithEvents CbxCodigoFamilia As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtMayor As TextBox
    Friend WithEvents DgvAlumnos As DataGridView
    Friend WithEvents ColDNI As DataGridViewTextBoxColumn
    Friend WithEvents ColEdad As DataGridViewTextBoxColumn
    Friend WithEvents ColCurso As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
End Class
