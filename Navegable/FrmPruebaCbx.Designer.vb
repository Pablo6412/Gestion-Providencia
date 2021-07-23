<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPruebaCbx
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
        Me.CbxCodigoNivel = New System.Windows.Forms.ComboBox()
        Me.CbxNivel = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CbxCodigoNivel
        '
        Me.CbxCodigoNivel.FormattingEnabled = True
        Me.CbxCodigoNivel.Location = New System.Drawing.Point(226, 89)
        Me.CbxCodigoNivel.Name = "CbxCodigoNivel"
        Me.CbxCodigoNivel.Size = New System.Drawing.Size(57, 23)
        Me.CbxCodigoNivel.TabIndex = 0
        '
        'CbxNivel
        '
        Me.CbxNivel.FormattingEnabled = True
        Me.CbxNivel.Location = New System.Drawing.Point(402, 89)
        Me.CbxNivel.Name = "CbxNivel"
        Me.CbxNivel.Size = New System.Drawing.Size(163, 23)
        Me.CbxNivel.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(226, 166)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(57, 23)
        Me.TextBox1.TabIndex = 2
        '
        'FrmPruebaCbx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CbxNivel)
        Me.Controls.Add(Me.CbxCodigoNivel)
        Me.Name = "FrmPruebaCbx"
        Me.Text = "FrmPruebaCbx"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbxCodigoNivel As ComboBox
    Friend WithEvents CbxNivel As ComboBox
    Friend WithEvents TextBox1 As TextBox
End Class
