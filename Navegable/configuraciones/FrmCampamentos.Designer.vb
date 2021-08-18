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
        Me.TxtCodigoNivel = New System.Windows.Forms.TextBox()
        Me.CbxCurso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CbxCodigonivel = New System.Windows.Forms.ComboBox()
        Me.CbxCodigoCurso = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtLugar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtCodigoNivel)
        Me.GroupBox1.Controls.Add(Me.CbxCurso)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CbxNivel)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtCodigoNivel
        '
        Me.TxtCodigoNivel.Location = New System.Drawing.Point(408, 165)
        Me.TxtCodigoNivel.Name = "TxtCodigoNivel"
        Me.TxtCodigoNivel.Size = New System.Drawing.Size(100, 27)
        Me.TxtCodigoNivel.TabIndex = 4
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(838, 536)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CbxCodigonivel
        '
        Me.CbxCodigonivel.FormattingEnabled = True
        Me.CbxCodigonivel.Location = New System.Drawing.Point(13, 89)
        Me.CbxCodigonivel.Name = "CbxCodigonivel"
        Me.CbxCodigonivel.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigonivel.TabIndex = 2
        '
        'CbxCodigoCurso
        '
        Me.CbxCodigoCurso.FormattingEnabled = True
        Me.CbxCodigoCurso.Location = New System.Drawing.Point(12, 133)
        Me.CbxCodigoCurso.Name = "CbxCodigoCurso"
        Me.CbxCodigoCurso.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoCurso.TabIndex = 3
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
        Me.GroupBox2.Location = New System.Drawing.Point(86, 353)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(651, 102)
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
        'FrmCampamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CbxCodigoCurso)
        Me.Controls.Add(Me.CbxCodigonivel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "FrmCampamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCampamentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbxCurso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents TxtCodigoNivel As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CbxCodigonivel As ComboBox
    Friend WithEvents CbxCodigoCurso As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents TxtLugar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnGuardar As Button
End Class
