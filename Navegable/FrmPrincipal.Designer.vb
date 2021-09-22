<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MstFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsAltasFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsModifFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsBajasDeFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsConsultasDeFamilias = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DescuentosYBecasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MstAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsAltaAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsActualizacionAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsBajaAlumnos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.InscripciónATalleresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MstPagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsIngresoDePagos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtrosPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosDeudaCampamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MstEmisionDeVencimientos = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmisiónDeVencimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsEnviaCorreo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MstContabilidadInstitucional = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsEgresos = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlsGastos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MstListados = New System.Windows.Forms.ToolStripMenuItem()
        Me.MstCancelaciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.MstEstadoDeudas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MstCierreAnual = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnACercaDe = New System.Windows.Forms.Button()
        Me.BtnAyuda = New System.Windows.Forms.Button()
        Me.BtnConfiguracion = New System.Windows.Forms.Button()
        Me.BtnConsultas = New System.Windows.Forms.Button()
        Me.PanelEscudos = New System.Windows.Forms.Panel()
        Me.PbxEscudoTesoros = New System.Windows.Forms.PictureBox()
        Me.PbxEscudoDoniaLuna = New System.Windows.Forms.PictureBox()
        Me.PbxEscudoProvi = New System.Windows.Forms.PictureBox()
        Me.PanelAzul = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelEscudos.SuspendLayout()
        CType(Me.PbxEscudoTesoros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxEscudoDoniaLuna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxEscudoProvi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MstFamilias, Me.MstAlumnos, Me.MstPagos, Me.MstEmisionDeVencimientos, Me.MstContabilidadInstitucional, Me.MstListados, Me.MstCancelaciones, Me.MstEstadoDeudas, Me.MstCierreAnual})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "Familias"
        '
        'MstFamilias
        '
        Me.MstFamilias.AutoToolTip = True
        Me.MstFamilias.CheckOnClick = True
        Me.MstFamilias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsAltasFamilias, Me.TlsModifFamilias, Me.TlsBajasDeFamilias, Me.TlsConsultasDeFamilias, Me.ToolStripSeparator2, Me.DescuentosYBecasToolStripMenuItem})
        Me.MstFamilias.Name = "MstFamilias"
        Me.MstFamilias.Size = New System.Drawing.Size(69, 23)
        Me.MstFamilias.Text = "Familias"
        '
        'TlsAltasFamilias
        '
        Me.TlsAltasFamilias.Name = "TlsAltasFamilias"
        Me.TlsAltasFamilias.Size = New System.Drawing.Size(300, 24)
        Me.TlsAltasFamilias.Text = "Altas"
        '
        'TlsModifFamilias
        '
        Me.TlsModifFamilias.Name = "TlsModifFamilias"
        Me.TlsModifFamilias.Size = New System.Drawing.Size(300, 24)
        Me.TlsModifFamilias.Text = "Modificaciones"
        '
        'TlsBajasDeFamilias
        '
        Me.TlsBajasDeFamilias.Name = "TlsBajasDeFamilias"
        Me.TlsBajasDeFamilias.Size = New System.Drawing.Size(300, 24)
        Me.TlsBajasDeFamilias.Text = "Bajas y reincorporaciones de familias"
        '
        'TlsConsultasDeFamilias
        '
        Me.TlsConsultasDeFamilias.Name = "TlsConsultasDeFamilias"
        Me.TlsConsultasDeFamilias.Size = New System.Drawing.Size(300, 24)
        Me.TlsConsultasDeFamilias.Text = "Busqueda de familias"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(297, 6)
        '
        'DescuentosYBecasToolStripMenuItem
        '
        Me.DescuentosYBecasToolStripMenuItem.Name = "DescuentosYBecasToolStripMenuItem"
        Me.DescuentosYBecasToolStripMenuItem.Size = New System.Drawing.Size(300, 24)
        Me.DescuentosYBecasToolStripMenuItem.Text = "Descuentos y becas"
        '
        'MstAlumnos
        '
        Me.MstAlumnos.BackColor = System.Drawing.Color.AliceBlue
        Me.MstAlumnos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsAltaAlumnos, Me.TlsActualizacionAlumnos, Me.TlsBajaAlumnos, Me.ToolStripSeparator1, Me.InscripciónATalleresToolStripMenuItem})
        Me.MstAlumnos.Name = "MstAlumnos"
        Me.MstAlumnos.Size = New System.Drawing.Size(75, 23)
        Me.MstAlumnos.Text = "Alumnos"
        '
        'TlsAltaAlumnos
        '
        Me.TlsAltaAlumnos.Name = "TlsAltaAlumnos"
        Me.TlsAltaAlumnos.Size = New System.Drawing.Size(214, 24)
        Me.TlsAltaAlumnos.Text = "Alta de alumnos"
        '
        'TlsActualizacionAlumnos
        '
        Me.TlsActualizacionAlumnos.Name = "TlsActualizacionAlumnos"
        Me.TlsActualizacionAlumnos.Size = New System.Drawing.Size(214, 24)
        Me.TlsActualizacionAlumnos.Text = "Actualización de datos"
        '
        'TlsBajaAlumnos
        '
        Me.TlsBajaAlumnos.Name = "TlsBajaAlumnos"
        Me.TlsBajaAlumnos.Size = New System.Drawing.Size(214, 24)
        Me.TlsBajaAlumnos.Text = "Baja de alumnos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.SystemColors.Highlight
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(211, 6)
        '
        'InscripciónATalleresToolStripMenuItem
        '
        Me.InscripciónATalleresToolStripMenuItem.Name = "InscripciónATalleresToolStripMenuItem"
        Me.InscripciónATalleresToolStripMenuItem.Size = New System.Drawing.Size(214, 24)
        Me.InscripciónATalleresToolStripMenuItem.Text = "Inscripción a talleres"
        '
        'MstPagos
        '
        Me.MstPagos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsIngresoDePagos, Me.ToolStripMenuItem9, Me.OtrosPagosToolStripMenuItem, Me.PagosDeudaCampamentoToolStripMenuItem})
        Me.MstPagos.Name = "MstPagos"
        Me.MstPagos.Size = New System.Drawing.Size(58, 23)
        Me.MstPagos.Text = "Pagos"
        '
        'TlsIngresoDePagos
        '
        Me.TlsIngresoDePagos.Name = "TlsIngresoDePagos"
        Me.TlsIngresoDePagos.Size = New System.Drawing.Size(261, 24)
        Me.TlsIngresoDePagos.Text = "Pagos período actual"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(261, 24)
        Me.ToolStripMenuItem9.Text = "Pagos deuda año en curso"
        '
        'OtrosPagosToolStripMenuItem
        '
        Me.OtrosPagosToolStripMenuItem.Name = "OtrosPagosToolStripMenuItem"
        Me.OtrosPagosToolStripMenuItem.Size = New System.Drawing.Size(261, 24)
        Me.OtrosPagosToolStripMenuItem.Text = "Pagos deudas años anteriores"
        '
        'PagosDeudaCampamentoToolStripMenuItem
        '
        Me.PagosDeudaCampamentoToolStripMenuItem.Name = "PagosDeudaCampamentoToolStripMenuItem"
        Me.PagosDeudaCampamentoToolStripMenuItem.Size = New System.Drawing.Size(261, 24)
        Me.PagosDeudaCampamentoToolStripMenuItem.Text = "Pagos deuda campamento"
        '
        'MstEmisionDeVencimientos
        '
        Me.MstEmisionDeVencimientos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmisiónDeVencimientosToolStripMenuItem, Me.TlsEnviaCorreo})
        Me.MstEmisionDeVencimientos.Name = "MstEmisionDeVencimientos"
        Me.MstEmisionDeVencimientos.Size = New System.Drawing.Size(102, 23)
        Me.MstEmisionDeVencimientos.Text = "Vencimientos"
        '
        'EmisiónDeVencimientosToolStripMenuItem
        '
        Me.EmisiónDeVencimientosToolStripMenuItem.Name = "EmisiónDeVencimientosToolStripMenuItem"
        Me.EmisiónDeVencimientosToolStripMenuItem.Size = New System.Drawing.Size(228, 24)
        Me.EmisiónDeVencimientosToolStripMenuItem.Text = "Emisión de vencimientos"
        '
        'TlsEnviaCorreo
        '
        Me.TlsEnviaCorreo.Name = "TlsEnviaCorreo"
        Me.TlsEnviaCorreo.Size = New System.Drawing.Size(228, 24)
        Me.TlsEnviaCorreo.Text = "Enviar correo"
        '
        'MstContabilidadInstitucional
        '
        Me.MstContabilidadInstitucional.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsEgresos, Me.ToolStripMenuItem2})
        Me.MstContabilidadInstitucional.Name = "MstContabilidadInstitucional"
        Me.MstContabilidadInstitucional.Size = New System.Drawing.Size(175, 23)
        Me.MstContabilidadInstitucional.Text = "Contabilidad institucional"
        '
        'TlsEgresos
        '
        Me.TlsEgresos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlsGastos})
        Me.TlsEgresos.Name = "TlsEgresos"
        Me.TlsEgresos.Size = New System.Drawing.Size(203, 24)
        Me.TlsEgresos.Text = "Egresos"
        '
        'TlsGastos
        '
        Me.TlsGastos.Name = "TlsGastos"
        Me.TlsGastos.Size = New System.Drawing.Size(120, 24)
        Me.TlsGastos.Text = "Gastos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(203, 24)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'MstListados
        '
        Me.MstListados.Name = "MstListados"
        Me.MstListados.Size = New System.Drawing.Size(71, 23)
        Me.MstListados.Text = "Listados"
        '
        'MstCancelaciones
        '
        Me.MstCancelaciones.Name = "MstCancelaciones"
        Me.MstCancelaciones.Size = New System.Drawing.Size(106, 23)
        Me.MstCancelaciones.Text = "Cancelaciones"
        '
        'MstEstadoDeudas
        '
        Me.MstEstadoDeudas.Name = "MstEstadoDeudas"
        Me.MstEstadoDeudas.Size = New System.Drawing.Size(129, 23)
        Me.MstEstadoDeudas.Text = "Estado de deudas"
        '
        'MstCierreAnual
        '
        Me.MstCierreAnual.Name = "MstCierreAnual"
        Me.MstCierreAnual.Size = New System.Drawing.Size(94, 23)
        Me.MstCierreAnual.Text = "Cierre anual"
        '
        'PanelMenu
        '
        Me.PanelMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelMenu.AutoSize = True
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PanelMenu.BackgroundImage = CType(resources.GetObject("PanelMenu.BackgroundImage"), System.Drawing.Image)
        Me.PanelMenu.Controls.Add(Me.BtnCerrar)
        Me.PanelMenu.Controls.Add(Me.BtnACercaDe)
        Me.PanelMenu.Controls.Add(Me.BtnAyuda)
        Me.PanelMenu.Controls.Add(Me.BtnConfiguracion)
        Me.PanelMenu.Controls.Add(Me.BtnConsultas)
        Me.PanelMenu.Location = New System.Drawing.Point(0, 209)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(137, 562)
        Me.PanelMenu.TabIndex = 1
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BtnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCerrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCerrar.ForeColor = System.Drawing.Color.White
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 461)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(134, 77)
        Me.BtnCerrar.TabIndex = 9
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'BtnACercaDe
        '
        Me.BtnACercaDe.BackColor = System.Drawing.Color.Transparent
        Me.BtnACercaDe.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnACercaDe.FlatAppearance.BorderSize = 0
        Me.BtnACercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnACercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnACercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnACercaDe.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnACercaDe.ForeColor = System.Drawing.Color.White
        Me.BtnACercaDe.Location = New System.Drawing.Point(0, 357)
        Me.BtnACercaDe.Name = "BtnACercaDe"
        Me.BtnACercaDe.Size = New System.Drawing.Size(134, 77)
        Me.BtnACercaDe.TabIndex = 8
        Me.BtnACercaDe.Text = "A cerca de"
        Me.BtnACercaDe.UseVisualStyleBackColor = False
        '
        'BtnAyuda
        '
        Me.BtnAyuda.BackColor = System.Drawing.Color.Transparent
        Me.BtnAyuda.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnAyuda.FlatAppearance.BorderSize = 0
        Me.BtnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAyuda.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnAyuda.ForeColor = System.Drawing.Color.White
        Me.BtnAyuda.Location = New System.Drawing.Point(0, 244)
        Me.BtnAyuda.Name = "BtnAyuda"
        Me.BtnAyuda.Size = New System.Drawing.Size(134, 77)
        Me.BtnAyuda.TabIndex = 7
        Me.BtnAyuda.Text = "Ayuda"
        Me.BtnAyuda.UseVisualStyleBackColor = False
        '
        'BtnConfiguracion
        '
        Me.BtnConfiguracion.BackColor = System.Drawing.Color.Transparent
        Me.BtnConfiguracion.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnConfiguracion.FlatAppearance.BorderSize = 0
        Me.BtnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfiguracion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnConfiguracion.ForeColor = System.Drawing.Color.White
        Me.BtnConfiguracion.Location = New System.Drawing.Point(0, 137)
        Me.BtnConfiguracion.Name = "BtnConfiguracion"
        Me.BtnConfiguracion.Size = New System.Drawing.Size(134, 77)
        Me.BtnConfiguracion.TabIndex = 6
        Me.BtnConfiguracion.Text = "Configuración"
        Me.BtnConfiguracion.UseVisualStyleBackColor = False
        '
        'BtnConsultas
        '
        Me.BtnConsultas.BackColor = System.Drawing.Color.Transparent
        Me.BtnConsultas.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnConsultas.FlatAppearance.BorderSize = 0
        Me.BtnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack
        Me.BtnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConsultas.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnConsultas.ForeColor = System.Drawing.Color.White
        Me.BtnConsultas.Location = New System.Drawing.Point(0, 32)
        Me.BtnConsultas.Name = "BtnConsultas"
        Me.BtnConsultas.Size = New System.Drawing.Size(134, 77)
        Me.BtnConsultas.TabIndex = 5
        Me.BtnConsultas.Text = "Consultas"
        Me.BtnConsultas.UseVisualStyleBackColor = False
        '
        'PanelEscudos
        '
        Me.PanelEscudos.BackColor = System.Drawing.Color.White
        Me.PanelEscudos.Controls.Add(Me.PbxEscudoTesoros)
        Me.PanelEscudos.Controls.Add(Me.PbxEscudoDoniaLuna)
        Me.PanelEscudos.Controls.Add(Me.PbxEscudoProvi)
        Me.PanelEscudos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEscudos.Location = New System.Drawing.Point(0, 25)
        Me.PanelEscudos.Name = "PanelEscudos"
        Me.PanelEscudos.Size = New System.Drawing.Size(809, 81)
        Me.PanelEscudos.TabIndex = 2
        '
        'PbxEscudoTesoros
        '
        Me.PbxEscudoTesoros.BackColor = System.Drawing.Color.Transparent
        Me.PbxEscudoTesoros.BackgroundImage = CType(resources.GetObject("PbxEscudoTesoros.BackgroundImage"), System.Drawing.Image)
        Me.PbxEscudoTesoros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxEscudoTesoros.Location = New System.Drawing.Point(193, 0)
        Me.PbxEscudoTesoros.Name = "PbxEscudoTesoros"
        Me.PbxEscudoTesoros.Size = New System.Drawing.Size(74, 81)
        Me.PbxEscudoTesoros.TabIndex = 2
        Me.PbxEscudoTesoros.TabStop = False
        '
        'PbxEscudoDoniaLuna
        '
        Me.PbxEscudoDoniaLuna.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PbxEscudoDoniaLuna.BackColor = System.Drawing.Color.Transparent
        Me.PbxEscudoDoniaLuna.BackgroundImage = CType(resources.GetObject("PbxEscudoDoniaLuna.BackgroundImage"), System.Drawing.Image)
        Me.PbxEscudoDoniaLuna.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxEscudoDoniaLuna.Location = New System.Drawing.Point(374, 0)
        Me.PbxEscudoDoniaLuna.Name = "PbxEscudoDoniaLuna"
        Me.PbxEscudoDoniaLuna.Size = New System.Drawing.Size(82, 81)
        Me.PbxEscudoDoniaLuna.TabIndex = 1
        Me.PbxEscudoDoniaLuna.TabStop = False
        '
        'PbxEscudoProvi
        '
        Me.PbxEscudoProvi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PbxEscudoProvi.BackColor = System.Drawing.Color.Transparent
        Me.PbxEscudoProvi.BackgroundImage = CType(resources.GetObject("PbxEscudoProvi.BackgroundImage"), System.Drawing.Image)
        Me.PbxEscudoProvi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxEscudoProvi.Location = New System.Drawing.Point(564, 0)
        Me.PbxEscudoProvi.Name = "PbxEscudoProvi"
        Me.PbxEscudoProvi.Size = New System.Drawing.Size(82, 81)
        Me.PbxEscudoProvi.TabIndex = 0
        Me.PbxEscudoProvi.TabStop = False
        '
        'PanelAzul
        '
        Me.PanelAzul.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PanelAzul.Location = New System.Drawing.Point(0, 106)
        Me.PanelAzul.Name = "PanelAzul"
        Me.PanelAzul.Size = New System.Drawing.Size(137, 104)
        Me.PanelAzul.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OrangeRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 5)
        Me.Panel1.TabIndex = 4
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(809, 749)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAzul)
        Me.Controls.Add(Me.PanelEscudos)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmPrincipal"
        Me.Text = "Sistema de gestión - Colegio de la Providencia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelEscudos.ResumeLayout(False)
        CType(Me.PbxEscudoTesoros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxEscudoDoniaLuna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxEscudoProvi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TlsAlumnos As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Bajas As ToolStripMenuItem
    Friend WithEvents Tls As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents TlsPagos As ToolStripMenuItem
    Friend WithEvents TlsEmisionDeVencimientos As ToolStripMenuItem
    Friend WithEvents TlsTablas As ToolStripMenuItem
    Friend WithEvents TlsListados As ToolStripMenuItem
    Friend WithEvents TlsCancelaciones As ToolStripMenuItem
    Friend WithEvents TlsCierreAnual As ToolStripMenuItem
    Friend WithEvents TlsAltas As ToolStripMenuItem
    Friend WithEvents TlsModiFamilias As ToolStripMenuItem
    Friend WithEvents TlsBajasDeFamilias As ToolStripMenuItem
    Friend WithEvents TlsConsultasDeFamilias As ToolStripMenuItem
    Friend WithEvents MstFamilias As ToolStripMenuItem
    Friend WithEvents TlsAltasFamilias As ToolStripMenuItem
    Friend WithEvents TlsModifFamilias As ToolStripMenuItem
    Friend WithEvents MstAlumnos As ToolStripMenuItem
    Friend WithEvents MstPagos As ToolStripMenuItem
    Friend WithEvents MstEmisionDeVencimientos As ToolStripMenuItem
    Friend WithEvents MstContabilidadInstitucional As ToolStripMenuItem
    Friend WithEvents MstListados As ToolStripMenuItem
    Friend WithEvents MstCancelaciones As ToolStripMenuItem
    Friend WithEvents MstCierreAnual As ToolStripMenuItem
    Friend WithEvents MstEstadoDeudas As ToolStripMenuItem
    Friend WithEvents TlsAltaAlumnos As ToolStripMenuItem
    Friend WithEvents TlsActualizacionAlumnos As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelEscudos As Panel
    Friend WithEvents PanelAzul As Panel
    Friend WithEvents PbxEscudoTesoros As PictureBox
    Friend WithEvents PbxEscudoDoniaLuna As PictureBox
    Friend WithEvents PbxEscudoProvi As PictureBox
    Friend WithEvents BtnConsultas As Button
    Friend WithEvents BtnConfiguracion As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnACercaDe As Button
    Friend WithEvents BtnAyuda As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TlsBajaAlumnos As ToolStripMenuItem
    Friend WithEvents TlsIngresoDePagos As ToolStripMenuItem
    Friend WithEvents TlsEnviaCorreo As ToolStripMenuItem
    Friend WithEvents TlsEgresos As ToolStripMenuItem
    Friend WithEvents TlsGastos As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents OtrosPagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents InscripciónATalleresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DescuentosYBecasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmisiónDeVencimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents PagosDeudaCampamentoToolStripMenuItem As ToolStripMenuItem
End Class
