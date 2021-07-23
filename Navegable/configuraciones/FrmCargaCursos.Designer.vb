<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaCursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCargaCursos))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.TxtCursoCarga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxCodigoNivel = New System.Windows.Forms.ComboBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbxCursos = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbxCodigoCurso = New System.Windows.Forms.ComboBox()
        Me.CbxCurso = New System.Windows.Forms.ComboBox()
        Me.BtnSalirModifica = New System.Windows.Forms.Button()
        Me.LbxCursoActualiza = New System.Windows.Forms.ListBox()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.TxtCursoActualizado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LbxCursosBaja = New System.Windows.Forms.ListBox()
        Me.BtnSalirBaja = New System.Windows.Forms.Button()
        Me.BtnBaja = New System.Windows.Forms.Button()
        Me.CbxCodigoBaja = New System.Windows.Forms.ComboBox()
        Me.CbxCursoBaja = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RdbBajaCurso = New System.Windows.Forms.RadioButton()
        Me.RdbModificaCurso = New System.Windows.Forms.RadioButton()
        Me.RdbCargaCurso = New System.Windows.Forms.RadioButton()
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
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(934, 571)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BtnSalir)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.LbxCursos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(926, 543)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CbxNivel)
        Me.GroupBox1.Controls.Add(Me.TxtCursoCarga)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CbxCodigoNivel)
        Me.GroupBox1.Controls.Add(Me.BtnAgregar)
        Me.GroupBox1.Location = New System.Drawing.Point(210, 245)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 194)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Panel de ingreso de cursos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nivel:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Código de nivel:"
        '
        'CbxNivel
        '
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Location = New System.Drawing.Point(291, 36)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(124, 23)
        Me.CbxNivel.TabIndex = 6
        '
        'TxtCursoCarga
        '
        Me.TxtCursoCarga.Location = New System.Drawing.Point(105, 124)
        Me.TxtCursoCarga.Name = "TxtCursoCarga"
        Me.TxtCursoCarga.Size = New System.Drawing.Size(165, 23)
        Me.TxtCursoCarga.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Curso:"
        '
        'CbxCodigoNivel
        '
        Me.CbxCodigoNivel.FormattingEnabled = True
        Me.CbxCodigoNivel.Location = New System.Drawing.Point(105, 39)
        Me.CbxCodigoNivel.Name = "CbxCodigoNivel"
        Me.CbxCodigoNivel.Size = New System.Drawing.Size(50, 23)
        Me.CbxCodigoNivel.TabIndex = 5
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.White
        Me.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Location = New System.Drawing.Point(301, 114)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 33)
        Me.BtnAgregar.TabIndex = 4
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(716, 483)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(399, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Listado de cursos"
        '
        'LbxCursos
        '
        Me.LbxCursos.FormattingEnabled = True
        Me.LbxCursos.ItemHeight = 15
        Me.LbxCursos.Location = New System.Drawing.Point(402, 92)
        Me.LbxCursos.Name = "LbxCursos"
        Me.LbxCursos.Size = New System.Drawing.Size(169, 124)
        Me.LbxCursos.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.SteelBlue
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.CbxCodigoCurso)
        Me.TabPage2.Controls.Add(Me.CbxCurso)
        Me.TabPage2.Controls.Add(Me.BtnSalirModifica)
        Me.TabPage2.Controls.Add(Me.LbxCursoActualiza)
        Me.TabPage2.Controls.Add(Me.BtnModificar)
        Me.TabPage2.Controls.Add(Me.TxtCursoActualizado)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(926, 543)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(537, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 91)
        Me.Panel2.TabIndex = 21
        '
        'CbxCodigoCurso
        '
        Me.CbxCodigoCurso.FormattingEnabled = True
        Me.CbxCodigoCurso.Location = New System.Drawing.Point(557, 63)
        Me.CbxCodigoCurso.Name = "CbxCodigoCurso"
        Me.CbxCodigoCurso.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoCurso.TabIndex = 20
        '
        'CbxCurso
        '
        Me.CbxCurso.FormattingEnabled = True
        Me.CbxCurso.Location = New System.Drawing.Point(557, 89)
        Me.CbxCurso.Name = "CbxCurso"
        Me.CbxCurso.Size = New System.Drawing.Size(121, 23)
        Me.CbxCurso.TabIndex = 19
        '
        'BtnSalirModifica
        '
        Me.BtnSalirModifica.BackColor = System.Drawing.Color.White
        Me.BtnSalirModifica.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalirModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirModifica.Location = New System.Drawing.Point(624, 370)
        Me.BtnSalirModifica.Name = "BtnSalirModifica"
        Me.BtnSalirModifica.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalirModifica.TabIndex = 18
        Me.BtnSalirModifica.Text = "Salir"
        Me.BtnSalirModifica.UseVisualStyleBackColor = False
        '
        'LbxCursoActualiza
        '
        Me.LbxCursoActualiza.FormattingEnabled = True
        Me.LbxCursoActualiza.ItemHeight = 15
        Me.LbxCursoActualiza.Location = New System.Drawing.Point(33, 81)
        Me.LbxCursoActualiza.Name = "LbxCursoActualiza"
        Me.LbxCursoActualiza.Size = New System.Drawing.Size(169, 394)
        Me.LbxCursoActualiza.TabIndex = 17
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.White
        Me.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Location = New System.Drawing.Point(267, 131)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 16
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'TxtCursoActualizado
        '
        Me.TxtCursoActualizado.Location = New System.Drawing.Point(221, 81)
        Me.TxtCursoActualizado.Name = "TxtCursoActualizado"
        Me.TxtCursoActualizado.Size = New System.Drawing.Size(121, 23)
        Me.TxtCursoActualizado.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nivel"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Controls.Add(Me.LbxCursosBaja)
        Me.TabPage3.Controls.Add(Me.BtnSalirBaja)
        Me.TabPage3.Controls.Add(Me.BtnBaja)
        Me.TabPage3.Controls.Add(Me.CbxCodigoBaja)
        Me.TabPage3.Controls.Add(Me.CbxCursoBaja)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(926, 543)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(150, 335)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(155, 59)
        Me.Panel3.TabIndex = 19
        '
        'LbxCursosBaja
        '
        Me.LbxCursosBaja.FormattingEnabled = True
        Me.LbxCursosBaja.ItemHeight = 15
        Me.LbxCursosBaja.Location = New System.Drawing.Point(330, 142)
        Me.LbxCursosBaja.Name = "LbxCursosBaja"
        Me.LbxCursosBaja.Size = New System.Drawing.Size(180, 334)
        Me.LbxCursosBaja.TabIndex = 18
        '
        'BtnSalirBaja
        '
        Me.BtnSalirBaja.BackColor = System.Drawing.Color.White
        Me.BtnSalirBaja.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalirBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalirBaja.Location = New System.Drawing.Point(593, 437)
        Me.BtnSalirBaja.Name = "BtnSalirBaja"
        Me.BtnSalirBaja.Size = New System.Drawing.Size(91, 39)
        Me.BtnSalirBaja.TabIndex = 17
        Me.BtnSalirBaja.Text = "Salir"
        Me.BtnSalirBaja.UseVisualStyleBackColor = False
        '
        'BtnBaja
        '
        Me.BtnBaja.BackColor = System.Drawing.Color.White
        Me.BtnBaja.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBaja.Location = New System.Drawing.Point(556, 142)
        Me.BtnBaja.Name = "BtnBaja"
        Me.BtnBaja.Size = New System.Drawing.Size(75, 23)
        Me.BtnBaja.TabIndex = 16
        Me.BtnBaja.Text = "Eliminar"
        Me.BtnBaja.UseVisualStyleBackColor = False
        '
        'CbxCodigoBaja
        '
        Me.CbxCodigoBaja.FormattingEnabled = True
        Me.CbxCodigoBaja.Location = New System.Drawing.Point(157, 335)
        Me.CbxCodigoBaja.Name = "CbxCodigoBaja"
        Me.CbxCodigoBaja.Size = New System.Drawing.Size(121, 23)
        Me.CbxCodigoBaja.TabIndex = 15
        '
        'CbxCursoBaja
        '
        Me.CbxCursoBaja.FormattingEnabled = True
        Me.CbxCursoBaja.Location = New System.Drawing.Point(157, 364)
        Me.CbxCursoBaja.Name = "CbxCursoBaja"
        Me.CbxCursoBaja.Size = New System.Drawing.Size(121, 23)
        Me.CbxCursoBaja.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Curso"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.RdbBajaCurso)
        Me.Panel1.Controls.Add(Me.RdbModificaCurso)
        Me.Panel1.Controls.Add(Me.RdbCargaCurso)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 56)
        Me.Panel1.TabIndex = 2
        '
        'RdbBajaCurso
        '
        Me.RdbBajaCurso.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdbBajaCurso.FlatAppearance.BorderSize = 0
        Me.RdbBajaCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RdbBajaCurso.ForeColor = System.Drawing.Color.White
        Me.RdbBajaCurso.Location = New System.Drawing.Point(205, 0)
        Me.RdbBajaCurso.Name = "RdbBajaCurso"
        Me.RdbBajaCurso.Size = New System.Drawing.Size(104, 56)
        Me.RdbBajaCurso.TabIndex = 2
        Me.RdbBajaCurso.TabStop = True
        Me.RdbBajaCurso.Text = "Baja de cursos"
        Me.RdbBajaCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RdbBajaCurso.UseVisualStyleBackColor = True
        '
        'RdbModificaCurso
        '
        Me.RdbModificaCurso.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdbModificaCurso.FlatAppearance.BorderSize = 0
        Me.RdbModificaCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RdbModificaCurso.ForeColor = System.Drawing.Color.White
        Me.RdbModificaCurso.Location = New System.Drawing.Point(102, 0)
        Me.RdbModificaCurso.Name = "RdbModificaCurso"
        Me.RdbModificaCurso.Size = New System.Drawing.Size(104, 56)
        Me.RdbModificaCurso.TabIndex = 1
        Me.RdbModificaCurso.TabStop = True
        Me.RdbModificaCurso.Text = "Modificacion de cursos"
        Me.RdbModificaCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RdbModificaCurso.UseVisualStyleBackColor = True
        '
        'RdbCargaCurso
        '
        Me.RdbCargaCurso.Appearance = System.Windows.Forms.Appearance.Button
        Me.RdbCargaCurso.FlatAppearance.BorderSize = 0
        Me.RdbCargaCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RdbCargaCurso.ForeColor = System.Drawing.Color.White
        Me.RdbCargaCurso.Location = New System.Drawing.Point(0, 0)
        Me.RdbCargaCurso.Name = "RdbCargaCurso"
        Me.RdbCargaCurso.Size = New System.Drawing.Size(104, 56)
        Me.RdbCargaCurso.TabIndex = 0
        Me.RdbCargaCurso.TabStop = True
        Me.RdbCargaCurso.Text = "Carga de cursos"
        Me.RdbCargaCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RdbCargaCurso.UseVisualStyleBackColor = True
        '
        'FrmCargaCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 571)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "FrmCargaCursos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARGA DE CURSOS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
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
    Friend WithEvents RdbBajaCurso As RadioButton
    Friend WithEvents RdbModificaCurso As RadioButton
    Friend WithEvents RdbCargaCurso As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtCursoCarga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LbxCursos As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents CbxCodigoNivel As ComboBox
    Friend WithEvents BtnSalirModifica As Button
    Friend WithEvents LbxCursoActualiza As ListBox
    Friend WithEvents BtnModificar As Button
    Friend WithEvents TxtCursoActualizado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CbxCodigoCurso As ComboBox
    Friend WithEvents CbxCurso As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LbxCursosBaja As ListBox
    Friend WithEvents BtnSalirBaja As Button
    Friend WithEvents BtnBaja As Button
    Friend WithEvents CbxCodigoBaja As ComboBox
    Friend WithEvents CbxCursoBaja As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
End Class
