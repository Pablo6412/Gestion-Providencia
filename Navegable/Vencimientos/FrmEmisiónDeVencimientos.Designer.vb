<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmisiónDeVencimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmisiónDeVencimientos))
        Me.BtnVencimientos = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Pbuno = New System.Windows.Forms.ProgressBar()
        Me.Pbdos = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblPbdos = New System.Windows.Forms.Label()
        Me.LblPbuno = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnVencimientos
        '
        Me.BtnVencimientos.BackColor = System.Drawing.Color.White
        Me.BtnVencimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnVencimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVencimientos.Location = New System.Drawing.Point(70, 56)
        Me.BtnVencimientos.Name = "BtnVencimientos"
        Me.BtnVencimientos.Size = New System.Drawing.Size(90, 61)
        Me.BtnVencimientos.TabIndex = 0
        Me.BtnVencimientos.Text = "Generar vencimientos"
        Me.BtnVencimientos.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Location = New System.Drawing.Point(700, 368)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 41)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 75)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Pbuno
        '
        Me.Pbuno.Location = New System.Drawing.Point(291, 34)
        Me.Pbuno.Name = "Pbuno"
        Me.Pbuno.Size = New System.Drawing.Size(365, 23)
        Me.Pbuno.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Pbuno.TabIndex = 3
        '
        'Pbdos
        '
        Me.Pbdos.Location = New System.Drawing.Point(291, 115)
        Me.Pbdos.Name = "Pbdos"
        Me.Pbdos.Size = New System.Drawing.Size(365, 23)
        Me.Pbdos.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Pbdos.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LblPbdos)
        Me.GroupBox1.Controls.Add(Me.LblPbuno)
        Me.GroupBox1.Controls.Add(Me.BtnVencimientos)
        Me.GroupBox1.Controls.Add(Me.Pbdos)
        Me.GroupBox1.Controls.Add(Me.Pbuno)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 196)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'LblPbdos
        '
        Me.LblPbdos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPbdos.Location = New System.Drawing.Point(291, 141)
        Me.LblPbdos.Name = "LblPbdos"
        Me.LblPbdos.Size = New System.Drawing.Size(365, 18)
        Me.LblPbdos.TabIndex = 6
        '
        'LblPbuno
        '
        Me.LblPbuno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPbuno.Location = New System.Drawing.Point(291, 60)
        Me.LblPbuno.Name = "LblPbuno"
        Me.LblPbuno.Size = New System.Drawing.Size(365, 18)
        Me.LblPbuno.TabIndex = 5
        '
        'FrmEmisiónDeVencimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(822, 440)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmEmisiónDeVencimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisión de vencimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnVencimientos As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Pbuno As ProgressBar
    Friend WithEvents Pbdos As ProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblPbuno As Label
    Friend WithEvents LblPbdos As Label
End Class
