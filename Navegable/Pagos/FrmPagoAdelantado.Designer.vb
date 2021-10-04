<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagoAdelantado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPagoAdelantado))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbxFamilia = New System.Windows.Forms.ComboBox()
        Me.CbxCodigo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CkbCampamento = New System.Windows.Forms.CheckBox()
        Me.CkbCuota = New System.Windows.Forms.CheckBox()
        Me.TxtCampamento = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtMontolAdelanto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbxCuotas = New System.Windows.Forms.ComboBox()
        Me.TxtCuota = New System.Windows.Forms.TextBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 5)
        Me.Panel2.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 77)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(203, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(633, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(412, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(77, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CbxFamilia)
        Me.GroupBox1.Controls.Add(Me.CbxCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(821, 110)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Familia"
        '
        'CbxFamilia
        '
        Me.CbxFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxFamilia.FormattingEnabled = True
        Me.CbxFamilia.Location = New System.Drawing.Point(398, 48)
        Me.CbxFamilia.Name = "CbxFamilia"
        Me.CbxFamilia.Size = New System.Drawing.Size(395, 29)
        Me.CbxFamilia.TabIndex = 3
        '
        'CbxCodigo
        '
        Me.CbxCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbxCodigo.FormattingEnabled = True
        Me.CbxCodigo.Location = New System.Drawing.Point(170, 48)
        Me.CbxCodigo.Name = "CbxCodigo"
        Me.CbxCodigo.Size = New System.Drawing.Size(121, 29)
        Me.CbxCodigo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(331, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Familia:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(29, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Código de familia:"
        '
        'DtpFechaPago
        '
        Me.DtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaPago.Location = New System.Drawing.Point(436, 106)
        Me.DtpFechaPago.Name = "DtpFechaPago"
        Me.DtpFechaPago.Size = New System.Drawing.Size(128, 23)
        Me.DtpFechaPago.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 21)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Cuota mensual:  $"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CkbCampamento)
        Me.GroupBox2.Controls.Add(Me.CkbCuota)
        Me.GroupBox2.Controls.Add(Me.TxtCampamento)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.BtnGuardar)
        Me.GroupBox2.Controls.Add(Me.TxtMontolAdelanto)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CbxCuotas)
        Me.GroupBox2.Controls.Add(Me.TxtCuota)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(52, 257)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(821, 266)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Adelantos"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(198, 176)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(115, 29)
        Me.TxtTotal.TabIndex = 46
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(135, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 21)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Total:  $"
        '
        'CkbCampamento
        '
        Me.CkbCampamento.AutoSize = True
        Me.CkbCampamento.Location = New System.Drawing.Point(328, 89)
        Me.CkbCampamento.Name = "CkbCampamento"
        Me.CkbCampamento.Size = New System.Drawing.Size(15, 14)
        Me.CkbCampamento.TabIndex = 44
        Me.CkbCampamento.UseVisualStyleBackColor = True
        '
        'CkbCuota
        '
        Me.CkbCuota.AutoSize = True
        Me.CkbCuota.Location = New System.Drawing.Point(328, 55)
        Me.CkbCuota.Name = "CkbCuota"
        Me.CkbCuota.Size = New System.Drawing.Size(15, 14)
        Me.CkbCuota.TabIndex = 43
        Me.CkbCuota.UseVisualStyleBackColor = True
        '
        'TxtCampamento
        '
        Me.TxtCampamento.Location = New System.Drawing.Point(200, 79)
        Me.TxtCampamento.Name = "TxtCampamento"
        Me.TxtCampamento.Size = New System.Drawing.Size(102, 29)
        Me.TxtCampamento.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 21)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Campamento:  $"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.White
        Me.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.Location = New System.Drawing.Point(708, 218)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(85, 32)
        Me.BtnGuardar.TabIndex = 37
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TxtMontolAdelanto
        '
        Me.TxtMontolAdelanto.Location = New System.Drawing.Point(619, 113)
        Me.TxtMontolAdelanto.Name = "TxtMontolAdelanto"
        Me.TxtMontolAdelanto.Size = New System.Drawing.Size(115, 29)
        Me.TxtMontolAdelanto.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(470, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Total a adelantar:  $"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 21)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Cantidad de meses a adelantar:"
        '
        'CbxCuotas
        '
        Me.CbxCuotas.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CbxCuotas.FormattingEnabled = True
        Me.CbxCuotas.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CbxCuotas.Location = New System.Drawing.Point(690, 46)
        Me.CbxCuotas.Name = "CbxCuotas"
        Me.CbxCuotas.Size = New System.Drawing.Size(43, 28)
        Me.CbxCuotas.TabIndex = 33
        '
        'TxtCuota
        '
        Me.TxtCuota.Location = New System.Drawing.Point(201, 45)
        Me.TxtCuota.Name = "TxtCuota"
        Me.TxtCuota.Size = New System.Drawing.Size(101, 29)
        Me.TxtCuota.TabIndex = 32
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.White
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSalir.Location = New System.Drawing.Point(798, 553)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(75, 32)
        Me.BtnSalir.TabIndex = 38
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmPagoAdelantado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DtpFechaPago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FrmPagoAdelantado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos adelantados con cuota congelada"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CbxFamilia As ComboBox
    Friend WithEvents CbxCodigo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpFechaPago As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtMontolAdelanto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxCuotas As ComboBox
    Friend WithEvents TxtCuota As TextBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CkbCampamento As CheckBox
    Friend WithEvents CkbCuota As CheckBox
    Friend WithEvents TxtCampamento As TextBox
    Friend WithEvents Label7 As Label
End Class
