<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfiguracion))
        Me.BtnCargaParametros = New System.Windows.Forms.Button()
        Me.BtnBecas = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnMateriales = New System.Windows.Forms.Button()
        Me.BtnTalleres = New System.Windows.Forms.Button()
        Me.BtnConcepto = New System.Windows.Forms.Button()
        Me.BtnCursos = New System.Windows.Forms.Button()
        Me.BtnAranceles = New System.Windows.Forms.Button()
        Me.BtnCampamentos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCargaParametros
        '
        Me.BtnCargaParametros.BackColor = System.Drawing.Color.Transparent
        Me.BtnCargaParametros.FlatAppearance.BorderSize = 0
        Me.BtnCargaParametros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnCargaParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCargaParametros.ForeColor = System.Drawing.Color.White
        Me.BtnCargaParametros.Location = New System.Drawing.Point(0, 0)
        Me.BtnCargaParametros.Name = "BtnCargaParametros"
        Me.BtnCargaParametros.Size = New System.Drawing.Size(115, 73)
        Me.BtnCargaParametros.TabIndex = 0
        Me.BtnCargaParametros.Text = "Niveles"
        Me.BtnCargaParametros.UseVisualStyleBackColor = False
        '
        'BtnBecas
        '
        Me.BtnBecas.BackColor = System.Drawing.Color.Transparent
        Me.BtnBecas.FlatAppearance.BorderSize = 0
        Me.BtnBecas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnBecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBecas.ForeColor = System.Drawing.Color.White
        Me.BtnBecas.Location = New System.Drawing.Point(687, 0)
        Me.BtnBecas.Name = "BtnBecas"
        Me.BtnBecas.Size = New System.Drawing.Size(115, 73)
        Me.BtnBecas.TabIndex = 1
        Me.BtnBecas.Text = "Becas"
        Me.BtnBecas.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(115, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 73)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(1156, 613)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(101, 39)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(100, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Carga de parámetros"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BtnMateriales)
        Me.Panel1.Controls.Add(Me.BtnTalleres)
        Me.Panel1.Controls.Add(Me.BtnBecas)
        Me.Panel1.Controls.Add(Me.BtnConcepto)
        Me.Panel1.Controls.Add(Me.BtnCursos)
        Me.Panel1.Controls.Add(Me.BtnAranceles)
        Me.Panel1.Controls.Add(Me.BtnCargaParametros)
        Me.Panel1.Location = New System.Drawing.Point(262, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1043, 73)
        Me.Panel1.TabIndex = 10
        '
        'BtnMateriales
        '
        Me.BtnMateriales.FlatAppearance.BorderSize = 0
        Me.BtnMateriales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMateriales.ForeColor = System.Drawing.Color.White
        Me.BtnMateriales.Location = New System.Drawing.Point(802, 0)
        Me.BtnMateriales.Name = "BtnMateriales"
        Me.BtnMateriales.Size = New System.Drawing.Size(115, 73)
        Me.BtnMateriales.TabIndex = 5
        Me.BtnMateriales.Text = "Materiales"
        Me.BtnMateriales.UseVisualStyleBackColor = True
        '
        'BtnTalleres
        '
        Me.BtnTalleres.FlatAppearance.BorderSize = 0
        Me.BtnTalleres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnTalleres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTalleres.ForeColor = System.Drawing.Color.White
        Me.BtnTalleres.Location = New System.Drawing.Point(572, 0)
        Me.BtnTalleres.Name = "BtnTalleres"
        Me.BtnTalleres.Size = New System.Drawing.Size(115, 73)
        Me.BtnTalleres.TabIndex = 4
        Me.BtnTalleres.Text = "Talleres"
        Me.BtnTalleres.UseVisualStyleBackColor = True
        '
        'BtnConcepto
        '
        Me.BtnConcepto.FlatAppearance.BorderSize = 0
        Me.BtnConcepto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConcepto.ForeColor = System.Drawing.Color.White
        Me.BtnConcepto.Location = New System.Drawing.Point(345, 0)
        Me.BtnConcepto.Name = "BtnConcepto"
        Me.BtnConcepto.Size = New System.Drawing.Size(115, 73)
        Me.BtnConcepto.TabIndex = 3
        Me.BtnConcepto.Text = "Conceptos"
        Me.BtnConcepto.UseVisualStyleBackColor = False
        '
        'BtnCursos
        '
        Me.BtnCursos.BackColor = System.Drawing.Color.Transparent
        Me.BtnCursos.FlatAppearance.BorderSize = 0
        Me.BtnCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCursos.ForeColor = System.Drawing.Color.White
        Me.BtnCursos.Location = New System.Drawing.Point(115, 0)
        Me.BtnCursos.Name = "BtnCursos"
        Me.BtnCursos.Size = New System.Drawing.Size(115, 73)
        Me.BtnCursos.TabIndex = 2
        Me.BtnCursos.Text = "Cursos"
        Me.BtnCursos.UseVisualStyleBackColor = False
        '
        'BtnAranceles
        '
        Me.BtnAranceles.BackColor = System.Drawing.Color.Transparent
        Me.BtnAranceles.FlatAppearance.BorderSize = 0
        Me.BtnAranceles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnAranceles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAranceles.ForeColor = System.Drawing.Color.White
        Me.BtnAranceles.Location = New System.Drawing.Point(230, 0)
        Me.BtnAranceles.Name = "BtnAranceles"
        Me.BtnAranceles.Size = New System.Drawing.Size(115, 73)
        Me.BtnAranceles.TabIndex = 1
        Me.BtnAranceles.Text = "Aranceles"
        Me.BtnAranceles.UseVisualStyleBackColor = False
        '
        'BtnCampamentos
        '
        Me.BtnCampamentos.BackColor = System.Drawing.Color.Transparent
        Me.BtnCampamentos.FlatAppearance.BorderSize = 0
        Me.BtnCampamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnCampamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCampamentos.ForeColor = System.Drawing.Color.White
        Me.BtnCampamentos.Location = New System.Drawing.Point(718, 106)
        Me.BtnCampamentos.Name = "BtnCampamentos"
        Me.BtnCampamentos.Size = New System.Drawing.Size(115, 73)
        Me.BtnCampamentos.TabIndex = 4
        Me.BtnCampamentos.Text = "Campamentos"
        Me.BtnCampamentos.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(259, 249)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(828, 73)
        Me.Panel2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(317, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(471, 60)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1364, 744)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnCampamentos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmConfiguracion"
        Me.Text = "CONFIGURACIÓN DEL SISTEMA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCargaParametros As Button
    Friend WithEvents BtnBecas As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnAranceles As Button
    Friend WithEvents BtnCursos As Button
    Friend WithEvents BtnConcepto As Button
    Friend WithEvents BtnMateriales As Button
    Friend WithEvents BtnTalleres As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnCampamentos As Button
End Class
