<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalleAtencion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleAtencion))
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.tbCelular = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbSexoCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbApellidoCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tbNombreCliente = New System.Windows.Forms.TextBox()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.tbCICliente = New System.Windows.Forms.TextBox()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.tbNumComprobante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbMedicoRemitente = New System.Windows.Forms.TextBox()
        Me.tbCodigoCliente = New System.Windows.Forms.TextBox()
        Me.imgbxLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardarEstudio = New System.Windows.Forms.Button()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.chbEliminar = New System.Windows.Forms.CheckBox()
        Me.lbInexistente = New System.Windows.Forms.LinkLabel()
        Me.tbBusca = New System.Windows.Forms.TextBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvListadoAtenciones = New System.Windows.Forms.DataGridView()
        Me.tbid_atencion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.White
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = Global.SisBioMedica.My.Resources.Resources.edit2
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(270, 508)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(70, 70)
        Me.btnEditar.TabIndex = 67
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'tbCelular
        '
        Me.tbCelular.Enabled = False
        Me.tbCelular.Location = New System.Drawing.Point(164, 186)
        Me.tbCelular.MaxLength = 50
        Me.tbCelular.Name = "tbCelular"
        Me.tbCelular.Size = New System.Drawing.Size(287, 27)
        Me.tbCelular.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 192)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 19)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 19)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Direccion"
        '
        'tbDireccion
        '
        Me.tbDireccion.Enabled = False
        Me.tbDireccion.Location = New System.Drawing.Point(164, 153)
        Me.tbDireccion.MaxLength = 50
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(287, 27)
        Me.tbDireccion.TabIndex = 41
        '
        'tbSexoCliente
        '
        Me.tbSexoCliente.Enabled = False
        Me.tbSexoCliente.Location = New System.Drawing.Point(164, 120)
        Me.tbSexoCliente.MaxLength = 50
        Me.tbSexoCliente.Name = "tbSexoCliente"
        Me.tbSexoCliente.Size = New System.Drawing.Size(145, 27)
        Me.tbSexoCliente.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Sexo"
        '
        'tbApellidoCliente
        '
        Me.tbApellidoCliente.Enabled = False
        Me.tbApellidoCliente.Location = New System.Drawing.Point(315, 87)
        Me.tbApellidoCliente.MaxLength = 50
        Me.tbApellidoCliente.Name = "tbApellidoCliente"
        Me.tbApellidoCliente.Size = New System.Drawing.Size(136, 27)
        Me.tbApellidoCliente.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nombres y Apellidos"
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.White
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SisBioMedica.My.Resources.Resources.new_24
        Me.btnNuevo.Location = New System.Drawing.Point(42, 508)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(70, 70)
        Me.btnNuevo.TabIndex = 65
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(906, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrar.TabIndex = 70
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(943, 35)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'tbNombreCliente
        '
        Me.tbNombreCliente.Enabled = False
        Me.tbNombreCliente.Location = New System.Drawing.Point(164, 87)
        Me.tbNombreCliente.MaxLength = 50
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.Size = New System.Drawing.Size(145, 27)
        Me.tbNombreCliente.TabIndex = 36
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(163, 285)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(136, 27)
        Me.dtpFechaAtencion.TabIndex = 35
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCliente.Location = New System.Drawing.Point(411, 54)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(39, 27)
        Me.btnBuscarCliente.TabIndex = 34
        Me.btnBuscarCliente.Text = "..."
        Me.btnBuscarCliente.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SisBioMedica.My.Resources.Resources.close
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(384, 508)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 70)
        Me.btnCancelar.TabIndex = 68
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'tbCICliente
        '
        Me.tbCICliente.Location = New System.Drawing.Point(234, 55)
        Me.tbCICliente.MaxLength = 50
        Me.tbCICliente.Name = "tbCICliente"
        Me.tbCICliente.Size = New System.Drawing.Size(171, 27)
        Me.tbCICliente.TabIndex = 33
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbPrecio.Location = New System.Drawing.Point(5, 260)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(118, 19)
        Me.lbPrecio.TabIndex = 27
        Me.lbPrecio.Text = "# Comprobante"
        '
        'tbNumComprobante
        '
        Me.tbNumComprobante.Location = New System.Drawing.Point(163, 252)
        Me.tbNumComprobante.MaxLength = 50
        Me.tbNumComprobante.Name = "tbNumComprobante"
        Me.tbNumComprobante.Size = New System.Drawing.Size(287, 27)
        Me.tbNumComprobante.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Medico Remitente"
        '
        'tbMedicoRemitente
        '
        Me.tbMedicoRemitente.Enabled = False
        Me.tbMedicoRemitente.Location = New System.Drawing.Point(164, 219)
        Me.tbMedicoRemitente.MaxLength = 50
        Me.tbMedicoRemitente.Name = "tbMedicoRemitente"
        Me.tbMedicoRemitente.Size = New System.Drawing.Size(287, 27)
        Me.tbMedicoRemitente.TabIndex = 24
        '
        'tbCodigoCliente
        '
        Me.tbCodigoCliente.Enabled = False
        Me.tbCodigoCliente.Location = New System.Drawing.Point(164, 55)
        Me.tbCodigoCliente.MaxLength = 50
        Me.tbCodigoCliente.Name = "tbCodigoCliente"
        Me.tbCodigoCliente.Size = New System.Drawing.Size(64, 27)
        Me.tbCodigoCliente.TabIndex = 23
        '
        'imgbxLogo
        '
        Me.imgbxLogo.Image = Global.SisBioMedica.My.Resources.Resources.logobiom
        Me.imgbxLogo.Location = New System.Drawing.Point(778, 40)
        Me.imgbxLogo.Name = "imgbxLogo"
        Me.imgbxLogo.Size = New System.Drawing.Size(150, 40)
        Me.imgbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgbxLogo.TabIndex = 64
        Me.imgbxLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 28)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "AÑADIR ESTUDIOS"
        '
        'btnGuardarEstudio
        '
        Me.btnGuardarEstudio.BackColor = System.Drawing.Color.White
        Me.btnGuardarEstudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardarEstudio.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardarEstudio.FlatAppearance.BorderSize = 0
        Me.btnGuardarEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEstudio.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEstudio.Image = CType(resources.GetObject("btnGuardarEstudio.Image"), System.Drawing.Image)
        Me.btnGuardarEstudio.Location = New System.Drawing.Point(156, 508)
        Me.btnGuardarEstudio.Name = "btnGuardarEstudio"
        Me.btnGuardarEstudio.Size = New System.Drawing.Size(70, 70)
        Me.btnGuardarEstudio.TabIndex = 66
        Me.btnGuardarEstudio.Text = "Guardar"
        Me.btnGuardarEstudio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarEstudio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnGuardarEstudio.UseVisualStyleBackColor = False
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Fecha.Location = New System.Drawing.Point(6, 293)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(107, 19)
        Me.Fecha.TabIndex = 22
        Me.Fecha.Text = "Fecha Estudio"
        '
        'chbEliminar
        '
        Me.chbEliminar.AutoSize = True
        Me.chbEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEliminar.Location = New System.Drawing.Point(331, 67)
        Me.chbEliminar.Name = "chbEliminar"
        Me.chbEliminar.Size = New System.Drawing.Size(82, 23)
        Me.chbEliminar.TabIndex = 21
        Me.chbEliminar.Text = "Eliminar"
        Me.chbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.chbEliminar.UseVisualStyleBackColor = True
        '
        'lbInexistente
        '
        Me.lbInexistente.AutoSize = True
        Me.lbInexistente.Location = New System.Drawing.Point(144, 229)
        Me.lbInexistente.Name = "lbInexistente"
        Me.lbInexistente.Size = New System.Drawing.Size(138, 19)
        Me.lbInexistente.TabIndex = 19
        Me.lbInexistente.TabStop = True
        Me.lbInexistente.Text = "Datos Inexistentes"
        '
        'tbBusca
        '
        Me.tbBusca.Location = New System.Drawing.Point(3, 68)
        Me.tbBusca.MaxLength = 100
        Me.tbBusca.Name = "tbBusca"
        Me.tbBusca.Size = New System.Drawing.Size(248, 27)
        Me.tbBusca.TabIndex = 18
        '
        'cbCampo
        '
        Me.cbCampo.AutoCompleteCustomSource.AddRange(New String() {"numero_documento", "ci"})
        Me.cbCampo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbCampo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"numero_documento", "ci"})
        Me.cbCampo.Location = New System.Drawing.Point(3, 34)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(168, 27)
        Me.cbCampo.TabIndex = 18
        Me.cbCampo.Text = "numero_documento"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbEliminar)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.lbInexistente)
        Me.GroupBox3.Controls.Add(Me.tbBusca)
        Me.GroupBox3.Controls.Add(Me.cbCampo)
        Me.GroupBox3.Controls.Add(Me.dgvListadoAtenciones)
        Me.GroupBox3.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(506, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(422, 380)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Categorias"
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.SisBioMedica.My.Resources.Resources.search1
        Me.btnBuscar.Location = New System.Drawing.Point(257, 68)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 24)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvListadoAtenciones
        '
        Me.dgvListadoAtenciones.AllowUserToAddRows = False
        Me.dgvListadoAtenciones.AllowUserToDeleteRows = False
        Me.dgvListadoAtenciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAtenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgvListadoAtenciones.Location = New System.Drawing.Point(3, 100)
        Me.dgvListadoAtenciones.Name = "dgvListadoAtenciones"
        Me.dgvListadoAtenciones.ReadOnly = True
        Me.dgvListadoAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoAtenciones.Size = New System.Drawing.Size(410, 272)
        Me.dgvListadoAtenciones.TabIndex = 0
        '
        'tbid_atencion
        '
        Me.tbid_atencion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbid_atencion.Enabled = False
        Me.tbid_atencion.Location = New System.Drawing.Point(392, 1)
        Me.tbid_atencion.MaxLength = 50
        Me.tbid_atencion.Name = "tbid_atencion"
        Me.tbid_atencion.Size = New System.Drawing.Size(77, 20)
        Me.tbid_atencion.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbCelular)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbDireccion)
        Me.GroupBox1.Controls.Add(Me.tbSexoCliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbApellidoCliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbNombreCliente)
        Me.GroupBox1.Controls.Add(Me.dtpFechaAtencion)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.tbCICliente)
        Me.GroupBox1.Controls.Add(Me.lbPrecio)
        Me.GroupBox1.Controls.Add(Me.tbNumComprobante)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbMedicoRemitente)
        Me.GroupBox1.Controls.Add(Me.tbCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.Fecha)
        Me.GroupBox1.Controls.Add(Me.tbid_atencion)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 380)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reporte de Atencion"
        '
        'frmDetalleAtencion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(940, 585)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.imgbxLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardarEstudio)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDetalleAtencion"
        Me.Text = "frmDetalleVenta"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEditar As Button
    Friend WithEvents tbCelular As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbSexoCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbApellidoCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents btnCancelar As Button
    Friend WithEvents imgbxLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGuardarEstudio As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chbEliminar As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lbInexistente As LinkLabel
    Friend WithEvents tbBusca As TextBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents dgvListadoAtenciones As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbNombreCliente As TextBox
    Friend WithEvents dtpFechaAtencion As DateTimePicker
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents tbCICliente As TextBox
    Friend WithEvents lbPrecio As Label
    Friend WithEvents tbNumComprobante As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbMedicoRemitente As TextBox
    Friend WithEvents tbCodigoCliente As TextBox
    Friend WithEvents Fecha As Label
    Friend WithEvents tbid_atencion As TextBox
    Friend WithEvents Label2 As Label
End Class
