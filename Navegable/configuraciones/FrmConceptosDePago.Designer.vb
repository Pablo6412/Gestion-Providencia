<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConceptosDePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConceptosDePago))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnGuardarConcepto = New System.Windows.Forms.Button()
        Me.TxtNuevoConcepto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalirNuevoConcepto = New System.Windows.Forms.Button()
        Me.LbxConcepto = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbxConcepto = New System.Windows.Forms.ComboBox()
        Me.CbxCodigoConcepto = New System.Windows.Forms.ComboBox()
        Me.BtnSalirActualiza = New System.Windows.Forms.Button()
        Me.BtnActualizaConcepto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtActualizaConcepto = New System.Windows.Forms.TextBox()
        Me.LbxActualizaConcepto = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbxBajaConcepto = New System.Windows.Forms.ListBox()
        Me.BtnSalirBaja = New System.Windows.Forms.Button()
        Me.BtnConceptoBaja = New System.Windows.Forms.Button()
        Me.CbxCodigoBaja = New System.Windows.Forms.ComboBox()
        Me.CbxNivelBaja = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(974, 611)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BtnSalirNuevoConcepto)
        Me.TabPage1.Controls.Add(Me.LbxConcepto)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(966, 580)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(399, 140)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnGuardarConcepto)
        Me.GroupBox1.Controls.Add(Me.TxtNuevoConcepto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(218, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carga de nuevo concepto"
        '
        'BtnGuardarConcepto
        '
        Me.BtnGuardarConcepto.BackColor = System.Drawing.Color.White
        Me.BtnGuardarConcepto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnGuardarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarConcepto.Location = New System.Drawing.Point(486, 39)
        Me.BtnGuardarConcepto.Name = "BtnGuardarConcepto"
        Me.BtnGuardarConcepto.Size = New System.Drawing.Size(83, 30)
        Me.BtnGuardarConcepto.TabIndex = 4
        Me.BtnGuardarConcepto.Text = "Guardar"
        Me.BtnGuardarConcepto.UseVisualStyleBackColor = False
        '
        'TxtNuevoConcepto
        '
        Me.TxtNuevoConcepto.Location = New System.Drawing.Point(195, 40)
        Me.TxtNuevoConcepto.MaxLength = 50
        Me.TxtNuevoConcepto.Name = "TxtNuevoConcepto"
        Me.TxtNuevoConcepto.Size = New System.Drawing.Size(202, 29)
        Me.TxtNuevoConcepto.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nuevo concepto:"
        '
        'BtnSalirNuevoConcepto
        '
        Me.BtnSalirNuevoConcepto.BackColor = System.Drawing.Color.White
        Me.BtnSalirNuevoConcepto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnSalirNuevoConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirNuevoConcepto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalirNuevoConcepto.Location = New System.Drawing.Point(824, 484)
        Me.BtnSalirNuevoConcepto.Name = "BtnSalirNuevoConcepto"
        Me.BtnSalirNuevoConcepto.Size = New System.Drawing.Size(75, 31)
        Me.BtnSalirNuevoConcepto.TabIndex = 1
        Me.BtnSalirNuevoConcepto.Text = "Salir"
        Me.BtnSalirNuevoConcepto.UseVisualStyleBackColor = False
        '
        'LbxConcepto
        '
        Me.LbxConcepto.FormattingEnabled = True
        Me.LbxConcepto.ItemHeight = 15
        Me.LbxConcepto.Location = New System.Drawing.Point(413, 73)
        Me.LbxConcepto.Name = "LbxConcepto"
        Me.LbxConcepto.Size = New System.Drawing.Size(202, 169)
        Me.LbxConcepto.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.RoyalBlue
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.CbxConcepto)
        Me.TabPage2.Controls.Add(Me.CbxCodigoConcepto)
        Me.TabPage2.Controls.Add(Me.BtnSalirActualiza)
        Me.TabPage2.Controls.Add(Me.BtnActualizaConcepto)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtActualizaConcepto)
        Me.TabPage2.Controls.Add(Me.LbxActualizaConcepto)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(966, 580)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(419, 295)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 7
        '
        'CbxConcepto
        '
        Me.CbxConcepto.FormattingEnabled = True
        Me.CbxConcepto.Location = New System.Drawing.Point(441, 355)
        Me.CbxConcepto.Name = "CbxConcepto"
        Me.CbxConcepto.Size = New System.Drawing.Size(121, 23)
        Me.CbxConcepto.TabIndex = 6
        '
        'CbxCodigoConcepto
        '
        Me.CbxCodigoConcepto.FormattingEnabled = True
        Me.CbxCodigoConcepto.Location = New System.Drawing.Point(441, 306)
        Me.CbxCodigoConcepto.Name = "CbxCodigoConcepto"
        Me.CbxCodigoConcepto.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoConcepto.TabIndex = 5
        '
        'BtnSalirActualiza
        '
        Me.BtnSalirActualiza.BackColor = System.Drawing.Color.White
        Me.BtnSalirActualiza.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnSalirActualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirActualiza.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalirActualiza.Location = New System.Drawing.Point(812, 474)
        Me.BtnSalirActualiza.Name = "BtnSalirActualiza"
        Me.BtnSalirActualiza.Size = New System.Drawing.Size(82, 36)
        Me.BtnSalirActualiza.TabIndex = 4
        Me.BtnSalirActualiza.Text = "Salir"
        Me.BtnSalirActualiza.UseVisualStyleBackColor = False
        '
        'BtnActualizaConcepto
        '
        Me.BtnActualizaConcepto.BackColor = System.Drawing.Color.White
        Me.BtnActualizaConcepto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnActualizaConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizaConcepto.Location = New System.Drawing.Point(584, 109)
        Me.BtnActualizaConcepto.Name = "BtnActualizaConcepto"
        Me.BtnActualizaConcepto.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizaConcepto.TabIndex = 3
        Me.BtnActualizaConcepto.Text = "Actualizar"
        Me.BtnActualizaConcepto.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(157, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Concepto"
        '
        'TxtActualizaConcepto
        '
        Me.TxtActualizaConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtActualizaConcepto.Location = New System.Drawing.Point(381, 109)
        Me.TxtActualizaConcepto.MaxLength = 50
        Me.TxtActualizaConcepto.Name = "TxtActualizaConcepto"
        Me.TxtActualizaConcepto.Size = New System.Drawing.Size(181, 23)
        Me.TxtActualizaConcepto.TabIndex = 1
        '
        'LbxActualizaConcepto
        '
        Me.LbxActualizaConcepto.FormattingEnabled = True
        Me.LbxActualizaConcepto.ItemHeight = 15
        Me.LbxActualizaConcepto.Location = New System.Drawing.Point(157, 109)
        Me.LbxActualizaConcepto.Name = "LbxActualizaConcepto"
        Me.LbxActualizaConcepto.Size = New System.Drawing.Size(200, 154)
        Me.LbxActualizaConcepto.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.LbxBajaConcepto)
        Me.TabPage3.Controls.Add(Me.BtnSalirBaja)
        Me.TabPage3.Controls.Add(Me.BtnConceptoBaja)
        Me.TabPage3.Controls.Add(Me.CbxCodigoBaja)
        Me.TabPage3.Controls.Add(Me.CbxNivelBaja)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(966, 580)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Location = New System.Drawing.Point(255, 392)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 19
        '
        'LbxBajaConcepto
        '
        Me.LbxBajaConcepto.FormattingEnabled = True
        Me.LbxBajaConcepto.ItemHeight = 15
        Me.LbxBajaConcepto.Location = New System.Drawing.Point(309, 134)
        Me.LbxBajaConcepto.Name = "LbxBajaConcepto"
        Me.LbxBajaConcepto.Size = New System.Drawing.Size(207, 214)
        Me.LbxBajaConcepto.TabIndex = 18
        '
        'BtnSalirBaja
        '
        Me.BtnSalirBaja.BackColor = System.Drawing.Color.White
        Me.BtnSalirBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnSalirBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirBaja.Location = New System.Drawing.Point(606, 424)
        Me.BtnSalirBaja.Name = "BtnSalirBaja"
        Me.BtnSalirBaja.Size = New System.Drawing.Size(91, 39)
        Me.BtnSalirBaja.TabIndex = 17
        Me.BtnSalirBaja.Text = "Salir"
        Me.BtnSalirBaja.UseVisualStyleBackColor = False
        '
        'BtnConceptoBaja
        '
        Me.BtnConceptoBaja.BackColor = System.Drawing.Color.White
        Me.BtnConceptoBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.BtnConceptoBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConceptoBaja.Location = New System.Drawing.Point(613, 219)
        Me.BtnConceptoBaja.Name = "BtnConceptoBaja"
        Me.BtnConceptoBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnConceptoBaja.TabIndex = 16
        Me.BtnConceptoBaja.Text = "Eliminar"
        Me.BtnConceptoBaja.UseVisualStyleBackColor = False
        '
        'CbxCodigoBaja
        '
        Me.CbxCodigoBaja.FormattingEnabled = True
        Me.CbxCodigoBaja.Location = New System.Drawing.Point(269, 412)
        Me.CbxCodigoBaja.Name = "CbxCodigoBaja"
        Me.CbxCodigoBaja.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoBaja.TabIndex = 15
        Me.CbxCodigoBaja.Visible = False
        '
        'CbxNivelBaja
        '
        Me.CbxNivelBaja.FormattingEnabled = True
        Me.CbxNivelBaja.Location = New System.Drawing.Point(269, 441)
        Me.CbxNivelBaja.Name = "CbxNivelBaja"
        Me.CbxNivelBaja.Size = New System.Drawing.Size(121, 23)
        Me.CbxNivelBaja.TabIndex = 14
        Me.CbxNivelBaja.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(309, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nivel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 58)
        Me.Panel1.TabIndex = 2
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.FlatAppearance.BorderSize = 0
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RadioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(222, -1)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(111, 59)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Baja de conceptos"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.FlatAppearance.BorderSize = 0
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RadioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(111, 0)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 58)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Modificación de conceptos"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.FlatAppearance.BorderSize = 0
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RadioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(0, -1)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(111, 59)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Nuevos conceptos"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'FrmConceptosDePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmConceptosDePago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARGA DE CONCEPTOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents LbxConcepto As ListBox
    Friend WithEvents BtnSalirNuevoConcepto As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGuardarConcepto As Button
    Friend WithEvents TxtNuevoConcepto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LbxActualizaConcepto As ListBox
    Friend WithEvents BtnSalirActualiza As Button
    Friend WithEvents BtnActualizaConcepto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtActualizaConcepto As TextBox
    Friend WithEvents CbxCodigoConcepto As ComboBox
    Friend WithEvents CbxConcepto As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LbxBajaConcepto As ListBox
    Friend WithEvents BtnSalirBaja As Button
    Friend WithEvents BtnConceptoBaja As Button
    Friend WithEvents CbxCodigoBaja As ComboBox
    Friend WithEvents CbxNivelBaja As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
End Class
