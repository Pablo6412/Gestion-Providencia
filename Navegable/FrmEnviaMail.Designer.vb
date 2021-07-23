<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEnviaMail
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
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.TxtEmisor = New System.Windows.Forms.TextBox()
        Me.TxtReceptor = New System.Windows.Forms.TextBox()
        Me.TxtAsunto = New System.Windows.Forms.TextBox()
        Me.TxtRutaArchivo = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAdjuntar = New System.Windows.Forms.Button()
        Me.RtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LblProgressBar = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'TxtEmisor
        '
        Me.TxtEmisor.Location = New System.Drawing.Point(161, 27)
        Me.TxtEmisor.Name = "TxtEmisor"
        Me.TxtEmisor.Size = New System.Drawing.Size(239, 23)
        Me.TxtEmisor.TabIndex = 0
        '
        'TxtReceptor
        '
        Me.TxtReceptor.Location = New System.Drawing.Point(161, 56)
        Me.TxtReceptor.Name = "TxtReceptor"
        Me.TxtReceptor.Size = New System.Drawing.Size(239, 23)
        Me.TxtReceptor.TabIndex = 1
        '
        'TxtAsunto
        '
        Me.TxtAsunto.Location = New System.Drawing.Point(161, 84)
        Me.TxtAsunto.Name = "TxtAsunto"
        Me.TxtAsunto.Size = New System.Drawing.Size(239, 23)
        Me.TxtAsunto.TabIndex = 2
        '
        'TxtRutaArchivo
        '
        Me.TxtRutaArchivo.Location = New System.Drawing.Point(161, 118)
        Me.TxtRutaArchivo.Name = "TxtRutaArchivo"
        Me.TxtRutaArchivo.Size = New System.Drawing.Size(362, 23)
        Me.TxtRutaArchivo.TabIndex = 3
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(600, 26)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(129, 23)
        Me.TxtPassword.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "De:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Para:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Asunto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Adjntar:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Clave:"
        '
        'BtnAdjuntar
        '
        Me.BtnAdjuntar.Location = New System.Drawing.Point(571, 118)
        Me.BtnAdjuntar.Name = "BtnAdjuntar"
        Me.BtnAdjuntar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdjuntar.TabIndex = 10
        Me.BtnAdjuntar.Text = "..."
        Me.BtnAdjuntar.UseVisualStyleBackColor = True
        '
        'RtbMensaje
        '
        Me.RtbMensaje.Location = New System.Drawing.Point(161, 158)
        Me.RtbMensaje.Name = "RtbMensaje"
        Me.RtbMensaje.Size = New System.Drawing.Size(568, 94)
        Me.RtbMensaje.TabIndex = 11
        Me.RtbMensaje.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Location = New System.Drawing.Point(161, 294)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnviar.TabIndex = 12
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(629, 294)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalir.TabIndex = 13
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.AliceBlue
        Me.ProgressBar1.Location = New System.Drawing.Point(248, 295)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(375, 22)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 14
        '
        'LblProgressBar
        '
        Me.LblProgressBar.AutoSize = True
        Me.LblProgressBar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblProgressBar.Location = New System.Drawing.Point(248, 320)
        Me.LblProgressBar.Name = "LblProgressBar"
        Me.LblProgressBar.Size = New System.Drawing.Size(17, 15)
        Me.LblProgressBar.TabIndex = 15
        Me.LblProgressBar.Text = "--"
        '
        'FrmEnviaMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblProgressBar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.RtbMensaje)
        Me.Controls.Add(Me.BtnAdjuntar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtRutaArchivo)
        Me.Controls.Add(Me.TxtAsunto)
        Me.Controls.Add(Me.TxtReceptor)
        Me.Controls.Add(Me.TxtEmisor)
        Me.Name = "FrmEnviaMail"
        Me.Text = "FrmEnviaMail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents TxtEmisor As TextBox
    Friend WithEvents TxtReceptor As TextBox
    Friend WithEvents TxtAsunto As TextBox
    Friend WithEvents TxtRutaArchivo As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnAdjuntar As Button
    Friend WithEvents RtbMensaje As RichTextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LblProgressBar As Label
End Class
