<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaNiveles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargaNiveles))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNivel = New System.Windows.Forms.TextBox()
        Me.LbxNivel = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbxNivelActualiza = New System.Windows.Forms.ListBox()
        Me.BtnGuardar2 = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtNivelActualizado = New System.Windows.Forms.TextBox()
        Me.CbxCodigoNivel = New System.Windows.Forms.ComboBox()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbxNiveles2 = New System.Windows.Forms.ListBox()
        Me.BtnSalirBaja = New System.Windows.Forms.Button()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.CbxCodigoBaja = New System.Windows.Forms.ComboBox()
        Me.CbxNivelBaja = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(115, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nivel:"
        '
        'TxtNivel
        '
        Me.TxtNivel.Location = New System.Drawing.Point(156, 287)
        Me.TxtNivel.MaxLength = 30
        Me.TxtNivel.Name = "TxtNivel"
        Me.TxtNivel.Size = New System.Drawing.Size(206, 23)
        Me.TxtNivel.TabIndex = 1
        '
        'LbxNivel
        '
        Me.LbxNivel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LbxNivel.FormattingEnabled = True
        Me.LbxNivel.ItemHeight = 15
        Me.LbxNivel.Location = New System.Drawing.Point(156, 54)
        Me.LbxNivel.Name = "LbxNivel"
        Me.LbxNivel.Size = New System.Drawing.Size(180, 212)
        Me.LbxNivel.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(377, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(628, 291)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
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
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Beige
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.LbxNivel)
        Me.TabPage1.Controls.Add(Me.BtnSalir)
        Me.TabPage1.Controls.Add(Me.TxtNivel)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 422)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.LbxNivelActualiza)
        Me.TabPage2.Controls.Add(Me.BtnGuardar2)
        Me.TabPage2.Controls.Add(Me.BtnActualizar)
        Me.TabPage2.Controls.Add(Me.TxtNivelActualizado)
        Me.TabPage2.Controls.Add(Me.CbxCodigoNivel)
        Me.TabPage2.Controls.Add(Me.CbxNivel)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(792, 422)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(29, 349)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 68)
        Me.Panel1.TabIndex = 14
        '
        'LbxNivelActualiza
        '
        Me.LbxNivelActualiza.FormattingEnabled = True
        Me.LbxNivelActualiza.ItemHeight = 15
        Me.LbxNivelActualiza.Location = New System.Drawing.Point(17, 66)
        Me.LbxNivelActualiza.Name = "LbxNivelActualiza"
        Me.LbxNivelActualiza.Size = New System.Drawing.Size(180, 214)
        Me.LbxNivelActualiza.TabIndex = 13
        '
        'BtnGuardar2
        '
        Me.BtnGuardar2.BackColor = System.Drawing.Color.White
        Me.BtnGuardar2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnGuardar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar2.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar2.Location = New System.Drawing.Point(249, 366)
        Me.BtnGuardar2.Name = "BtnGuardar2"
        Me.BtnGuardar2.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar2.TabIndex = 5
        Me.BtnGuardar2.Text = "Salir"
        Me.BtnGuardar2.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.White
        Me.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Location = New System.Drawing.Point(249, 116)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 4
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'TxtNivelActualizado
        '
        Me.TxtNivelActualizado.Location = New System.Drawing.Point(203, 66)
        Me.TxtNivelActualizado.MaxLength = 30
        Me.TxtNivelActualizado.Name = "TxtNivelActualizado"
        Me.TxtNivelActualizado.Size = New System.Drawing.Size(121, 23)
        Me.TxtNivelActualizado.TabIndex = 3
        '
        'CbxCodigoNivel
        '
        Me.CbxCodigoNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigoNivel.FormattingEnabled = True
        Me.CbxCodigoNivel.Location = New System.Drawing.Point(47, 349)
        Me.CbxCodigoNivel.Name = "CbxCodigoNivel"
        Me.CbxCodigoNivel.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoNivel.TabIndex = 2
        '
        'CbxNivel
        '
        Me.CbxNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Location = New System.Drawing.Point(47, 378)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(121, 23)
        Me.CbxNivel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nivel"
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.Add(Me.Panel2)
        Me.TabPage3.Controls.Add(Me.LbxNiveles2)
        Me.TabPage3.Controls.Add(Me.BtnSalirBaja)
        Me.TabPage3.Controls.Add(Me.BtnBaja)
        Me.TabPage3.Controls.Add(Me.CbxCodigoBaja)
        Me.TabPage3.Controls.Add(Me.CbxNivelBaja)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.ForeColor = System.Drawing.Color.Black
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(792, 422)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(8, 345)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(160, 69)
        Me.Panel2.TabIndex = 13
        '
        'LbxNiveles2
        '
        Me.LbxNiveles2.FormattingEnabled = True
        Me.LbxNiveles2.ItemHeight = 15
        Me.LbxNiveles2.Location = New System.Drawing.Point(58, 80)
        Me.LbxNiveles2.Name = "LbxNiveles2"
        Me.LbxNiveles2.Size = New System.Drawing.Size(180, 214)
        Me.LbxNiveles2.TabIndex = 12
        '
        'BtnSalirBaja
        '
        Me.BtnSalirBaja.BackColor = System.Drawing.Color.White
        Me.BtnSalirBaja.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalirBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirBaja.ForeColor = System.Drawing.Color.Black
        Me.BtnSalirBaja.Location = New System.Drawing.Point(355, 370)
        Me.BtnSalirBaja.Name = "BtnSalirBaja"
        Me.BtnSalirBaja.Size = New System.Drawing.Size(91, 39)
        Me.BtnSalirBaja.TabIndex = 11
        Me.BtnSalirBaja.Text = "Salir"
        Me.BtnSalirBaja.UseVisualStyleBackColor = False
        '
        'BtnBaja
        '
        Me.BtnBaja.BackColor = System.Drawing.Color.White
        Me.BtnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaja.ForeColor = System.Drawing.Color.Black
        Me.BtnBaja.Location = New System.Drawing.Point(362, 165)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaja.TabIndex = 10
        Me.BtnBaja.Text = "Eliminar"
        Me.BtnBaja.UseVisualStyleBackColor = False
        '
        'CbxCodigoBaja
        '
        Me.CbxCodigoBaja.FormattingEnabled = True
        Me.CbxCodigoBaja.Location = New System.Drawing.Point(18, 358)
        Me.CbxCodigoBaja.Name = "CbxCodigoBaja"
        Me.CbxCodigoBaja.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoBaja.TabIndex = 8
        Me.CbxCodigoBaja.Visible = False
        '
        'CbxNivelBaja
        '
        Me.CbxNivelBaja.FormattingEnabled = True
        Me.CbxNivelBaja.Location = New System.Drawing.Point(18, 387)
        Me.CbxNivelBaja.Name = "CbxNivelBaja"
        Me.CbxNivelBaja.Size = New System.Drawing.Size(121, 23)
        Me.CbxNivelBaja.TabIndex = 7
        Me.CbxNivelBaja.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nivel"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.RadioButton3)
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 50)
        Me.Panel3.TabIndex = 8
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
        Me.RadioButton3.Location = New System.Drawing.Point(256, 1)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(128, 49)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "Baja de niveles"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
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
        Me.RadioButton2.Location = New System.Drawing.Point(128, 1)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(128, 49)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Actualización de Niveles"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
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
        Me.RadioButton1.Size = New System.Drawing.Size(128, 50)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Carga de Niveles"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'FrmCargaNiveles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmCargaNiveles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCargaNiveles"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNivel As TextBox
    Friend WithEvents LbxNivel As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents BtnGuardar2 As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtNivelActualizado As TextBox
    Friend WithEvents CbxCodigoNivel As ComboBox
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents BtnSalirBaja As Button
    Friend WithEvents BtnBaja As Button
    Friend WithEvents CbxCodigoBaja As ComboBox
    Friend WithEvents CbxNivelBaja As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LbxNiveles2 As ListBox
    Friend WithEvents LbxNivelActualiza As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
