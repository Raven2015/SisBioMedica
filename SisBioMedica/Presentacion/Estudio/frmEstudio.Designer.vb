<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstudio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstudio))
        Me.btnBuscarCategoria = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNombreCategoria = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbDescuento = New System.Windows.Forms.TextBox()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbCodigoCategoria = New System.Windows.Forms.TextBox()
        Me.tbCodigoEstudio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbid_estudio = New System.Windows.Forms.TextBox()
        Me.tbNombreEstudio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.chbEliminar = New System.Windows.Forms.CheckBox()
        Me.lbInexistente = New System.Windows.Forms.LinkLabel()
        Me.tbBusca = New System.Windows.Forms.TextBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.dgvListadoEstudios = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbid_categoria = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardarEstudio = New System.Windows.Forms.Button()
        Me.imgbxLogo = New System.Windows.Forms.PictureBox()
        Me.tbFlag = New System.Windows.Forms.TextBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarCategoria
        '
        Me.btnBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnBuscarCategoria.FlatAppearance.BorderSize = 0
        Me.btnBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCategoria.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCategoria.Location = New System.Drawing.Point(414, 212)
        Me.btnBuscarCategoria.Name = "btnBuscarCategoria"
        Me.btnBuscarCategoria.Size = New System.Drawing.Size(39, 27)
        Me.btnBuscarCategoria.TabIndex = 31
        Me.btnBuscarCategoria.Text = "..."
        Me.btnBuscarCategoria.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 28)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "CATEGORIAS DE ESTUDIOS"
        '
        'tbNombreCategoria
        '
        Me.tbNombreCategoria.Enabled = False
        Me.tbNombreCategoria.Location = New System.Drawing.Point(271, 213)
        Me.tbNombreCategoria.MaxLength = 50
        Me.tbNombreCategoria.Name = "tbNombreCategoria"
        Me.tbNombreCategoria.Size = New System.Drawing.Size(136, 27)
        Me.tbNombreCategoria.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 19)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Descuento"
        '
        'tbDescuento
        '
        Me.tbDescuento.Location = New System.Drawing.Point(166, 319)
        Me.tbDescuento.MaxLength = 50
        Me.tbDescuento.Name = "tbDescuento"
        Me.tbDescuento.Size = New System.Drawing.Size(287, 27)
        Me.tbDescuento.TabIndex = 28
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbPrecio.Location = New System.Drawing.Point(8, 274)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(53, 19)
        Me.lbPrecio.TabIndex = 27
        Me.lbPrecio.Text = "Precio"
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(166, 266)
        Me.tbPrecio.MaxLength = 50
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(287, 27)
        Me.tbPrecio.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Categoria"
        '
        'tbCodigoCategoria
        '
        Me.tbCodigoCategoria.Enabled = False
        Me.tbCodigoCategoria.Location = New System.Drawing.Point(166, 213)
        Me.tbCodigoCategoria.MaxLength = 50
        Me.tbCodigoCategoria.Name = "tbCodigoCategoria"
        Me.tbCodigoCategoria.Size = New System.Drawing.Size(99, 27)
        Me.tbCodigoCategoria.TabIndex = 24
        '
        'tbCodigoEstudio
        '
        Me.tbCodigoEstudio.Location = New System.Drawing.Point(166, 107)
        Me.tbCodigoEstudio.MaxLength = 50
        Me.tbCodigoEstudio.Name = "tbCodigoEstudio"
        Me.tbCodigoEstudio.Size = New System.Drawing.Size(287, 27)
        Me.tbCodigoEstudio.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre de Estudio"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ID Estudio"
        '
        'tbid_estudio
        '
        Me.tbid_estudio.Enabled = False
        Me.tbid_estudio.Location = New System.Drawing.Point(166, 58)
        Me.tbid_estudio.MaxLength = 50
        Me.tbid_estudio.Name = "tbid_estudio"
        Me.tbid_estudio.Size = New System.Drawing.Size(287, 27)
        Me.tbid_estudio.TabIndex = 20
        '
        'tbNombreEstudio
        '
        Me.tbNombreEstudio.Location = New System.Drawing.Point(166, 160)
        Me.tbNombreEstudio.MaxLength = 50
        Me.tbNombreEstudio.Name = "tbNombreEstudio"
        Me.tbNombreEstudio.Size = New System.Drawing.Size(287, 27)
        Me.tbNombreEstudio.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Código de Estudio"
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'chbEliminar
        '
        Me.chbEliminar.AutoSize = True
        Me.chbEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEliminar.Location = New System.Drawing.Point(333, 57)
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
        Me.lbInexistente.Location = New System.Drawing.Point(146, 235)
        Me.lbInexistente.Name = "lbInexistente"
        Me.lbInexistente.Size = New System.Drawing.Size(138, 19)
        Me.lbInexistente.TabIndex = 19
        Me.lbInexistente.TabStop = True
        Me.lbInexistente.Text = "Datos Inexistentes"
        '
        'tbBusca
        '
        Me.tbBusca.Location = New System.Drawing.Point(5, 58)
        Me.tbBusca.MaxLength = 100
        Me.tbBusca.Name = "tbBusca"
        Me.tbBusca.Size = New System.Drawing.Size(248, 27)
        Me.tbBusca.TabIndex = 18
        '
        'cbCampo
        '
        Me.cbCampo.AutoCompleteCustomSource.AddRange(New String() {"codigo_estudio", "codigo_categoria", "nombre_estudio", "nombre_categoria"})
        Me.cbCampo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbCampo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"codigo_estudio", "codigo_categoria", "nombre_estudio", "nombre_categoria"})
        Me.cbCampo.Location = New System.Drawing.Point(5, 24)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(168, 27)
        Me.cbCampo.TabIndex = 18
        Me.cbCampo.Text = "nombre_categoria"
        '
        'dgvListadoEstudios
        '
        Me.dgvListadoEstudios.AllowUserToAddRows = False
        Me.dgvListadoEstudios.AllowUserToDeleteRows = False
        Me.dgvListadoEstudios.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoEstudios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgvListadoEstudios.Location = New System.Drawing.Point(5, 90)
        Me.dgvListadoEstudios.Name = "dgvListadoEstudios"
        Me.dgvListadoEstudios.ReadOnly = True
        Me.dgvListadoEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoEstudios.Size = New System.Drawing.Size(410, 272)
        Me.dgvListadoEstudios.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbEliminar)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.lbInexistente)
        Me.GroupBox3.Controls.Add(Me.tbBusca)
        Me.GroupBox3.Controls.Add(Me.cbCampo)
        Me.GroupBox3.Controls.Add(Me.dgvListadoEstudios)
        Me.GroupBox3.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(506, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(422, 380)
        Me.GroupBox3.TabIndex = 42
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
        Me.btnBuscar.Location = New System.Drawing.Point(259, 58)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 24)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbid_categoria)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCategoria)
        Me.GroupBox1.Controls.Add(Me.tbNombreCategoria)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbDescuento)
        Me.GroupBox1.Controls.Add(Me.lbPrecio)
        Me.GroupBox1.Controls.Add(Me.tbPrecio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbCodigoCategoria)
        Me.GroupBox1.Controls.Add(Me.tbCodigoEstudio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbid_estudio)
        Me.GroupBox1.Controls.Add(Me.tbNombreEstudio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 380)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Categoria"
        '
        'tbid_categoria
        '
        Me.tbid_categoria.Location = New System.Drawing.Point(425, 353)
        Me.tbid_categoria.MaxLength = 50
        Me.tbid_categoria.Name = "tbid_categoria"
        Me.tbid_categoria.Size = New System.Drawing.Size(45, 27)
        Me.tbid_categoria.TabIndex = 32
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
        Me.btnNuevo.TabIndex = 44
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.White
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.SisBioMedica.My.Resources.Resources.garbage1
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(853, 508)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 70)
        Me.btnEliminar.TabIndex = 50
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEliminar.UseVisualStyleBackColor = False
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
        Me.btnCerrar.TabIndex = 49
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(943, 35)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
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
        Me.btnCancelar.TabIndex = 47
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCancelar.UseVisualStyleBackColor = False
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
        Me.btnEditar.TabIndex = 46
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEditar.UseVisualStyleBackColor = False
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
        Me.btnGuardarEstudio.TabIndex = 45
        Me.btnGuardarEstudio.Text = "Guardar"
        Me.btnGuardarEstudio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarEstudio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnGuardarEstudio.UseVisualStyleBackColor = False
        '
        'imgbxLogo
        '
        Me.imgbxLogo.Image = Global.SisBioMedica.My.Resources.Resources.logobiom
        Me.imgbxLogo.Location = New System.Drawing.Point(778, 40)
        Me.imgbxLogo.Name = "imgbxLogo"
        Me.imgbxLogo.Size = New System.Drawing.Size(150, 40)
        Me.imgbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgbxLogo.TabIndex = 43
        Me.imgbxLogo.TabStop = False
        '
        'tbFlag
        '
        Me.tbFlag.Enabled = False
        Me.tbFlag.Location = New System.Drawing.Point(473, 40)
        Me.tbFlag.MaxLength = 50
        Me.tbFlag.Name = "tbFlag"
        Me.tbFlag.Size = New System.Drawing.Size(45, 20)
        Me.tbFlag.TabIndex = 33
        Me.tbFlag.Text = "0"
        Me.tbFlag.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = Global.SisBioMedica.My.Resources.Resources.close
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(506, 508)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 70)
        Me.btnImprimir.TabIndex = 51
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'frmEstudio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(940, 590)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.tbFlag)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardarEstudio)
        Me.Controls.Add(Me.imgbxLogo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEstudio"
        Me.Text = "frmEstudio"
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscarCategoria As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnGuardarEstudio As Button
    Friend WithEvents imgbxLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNombreCategoria As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDescuento As TextBox
    Friend WithEvents lbPrecio As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCodigoCategoria As TextBox
    Friend WithEvents tbCodigoEstudio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbid_estudio As TextBox
    Friend WithEvents tbNombreEstudio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chbEliminar As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lbInexistente As LinkLabel
    Friend WithEvents tbBusca As TextBox
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents dgvListadoEstudios As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbid_categoria As TextBox
    Friend WithEvents tbFlag As TextBox
    Friend WithEvents btnImprimir As Button
End Class
