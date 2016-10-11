<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbCodigo_Cliente = New System.Windows.Forms.TextBox()
        Me.lbci = New System.Windows.Forms.Label()
        Me.tbci = New System.Windows.Forms.TextBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.tbCelular = New System.Windows.Forms.TextBox()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tbEdad = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombres = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbNIT = New System.Windows.Forms.TextBox()
        Me.tbRazonSocial = New System.Windows.Forms.TextBox()
        Me.tbInstitucion = New System.Windows.Forms.TextBox()
        Me.tbCodigoAsegurado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lkInexistente = New System.Windows.Forms.LinkLabel()
        Me.tbBuscar = New System.Windows.Forms.TextBox()
        Me.cbCampo = New System.Windows.Forms.ComboBox()
        Me.dgvListadoClientes = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.imgbxLogo = New System.Windows.Forms.PictureBox()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListadoClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PACIENTES"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tbCodigo_Cliente)
        Me.GroupBox1.Controls.Add(Me.lbci)
        Me.GroupBox1.Controls.Add(Me.tbci)
        Me.GroupBox1.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.cbSexo)
        Me.GroupBox1.Controls.Add(Me.tbCelular)
        Me.GroupBox1.Controls.Add(Me.tbTelefono)
        Me.GroupBox1.Controls.Add(Me.tbEdad)
        Me.GroupBox1.Controls.Add(Me.tbDireccion)
        Me.GroupBox1.Controls.Add(Me.tbApellidos)
        Me.GroupBox1.Controls.Add(Me.tbNombres)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 311)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(9, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Codigo de Paciente"
        '
        'tbCodigo_Cliente
        '
        Me.tbCodigo_Cliente.Enabled = False
        Me.tbCodigo_Cliente.Location = New System.Drawing.Point(167, 45)
        Me.tbCodigo_Cliente.MaxLength = 50
        Me.tbCodigo_Cliente.Name = "tbCodigo_Cliente"
        Me.tbCodigo_Cliente.Size = New System.Drawing.Size(287, 27)
        Me.tbCodigo_Cliente.TabIndex = 20
        '
        'lbci
        '
        Me.lbci.AutoSize = True
        Me.lbci.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbci.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbci.Location = New System.Drawing.Point(8, 211)
        Me.lbci.Name = "lbci"
        Me.lbci.Size = New System.Drawing.Size(22, 19)
        Me.lbci.TabIndex = 19
        Me.lbci.Text = "CI"
        '
        'tbci
        '
        Me.tbci.Location = New System.Drawing.Point(119, 208)
        Me.tbci.Name = "tbci"
        Me.tbci.Size = New System.Drawing.Size(335, 27)
        Me.tbci.TabIndex = 18
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(307, 144)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(147, 27)
        Me.dtpFechaNacimiento.TabIndex = 17
        '
        'cbSexo
        '
        Me.cbSexo.AutoCompleteCustomSource.AddRange(New String() {"Femenino", "Masculino"})
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cbSexo.Location = New System.Drawing.Point(307, 241)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(147, 27)
        Me.cbSexo.TabIndex = 16
        '
        'tbCelular
        '
        Me.tbCelular.Location = New System.Drawing.Point(307, 272)
        Me.tbCelular.MaxLength = 8
        Me.tbCelular.Name = "tbCelular"
        Me.tbCelular.Size = New System.Drawing.Size(147, 27)
        Me.tbCelular.TabIndex = 15
        '
        'tbTelefono
        '
        Me.tbTelefono.Location = New System.Drawing.Point(84, 272)
        Me.tbTelefono.MaxLength = 9
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(147, 27)
        Me.tbTelefono.TabIndex = 14
        '
        'tbEdad
        '
        Me.tbEdad.Location = New System.Drawing.Point(84, 241)
        Me.tbEdad.MaxLength = 2
        Me.tbEdad.Name = "tbEdad"
        Me.tbEdad.Size = New System.Drawing.Size(147, 27)
        Me.tbEdad.TabIndex = 12
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(119, 177)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(335, 27)
        Me.tbDireccion.TabIndex = 11
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(119, 111)
        Me.tbApellidos.MaxLength = 50
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(335, 27)
        Me.tbApellidos.TabIndex = 9
        '
        'tbNombres
        '
        Me.tbNombres.Location = New System.Drawing.Point(119, 78)
        Me.tbNombres.MaxLength = 50
        Me.tbNombres.Name = "tbNombres"
        Me.tbNombres.Size = New System.Drawing.Size(335, 27)
        Me.tbNombres.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(244, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 19)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(244, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sexo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Teléfono"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 19)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Edad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(7, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(6, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 19)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha de Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombres"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbNIT)
        Me.GroupBox2.Controls.Add(Me.tbRazonSocial)
        Me.GroupBox2.Controls.Add(Me.tbInstitucion)
        Me.GroupBox2.Controls.Add(Me.tbCodigoAsegurado)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 439)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 172)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos para Factura"
        '
        'tbNIT
        '
        Me.tbNIT.Location = New System.Drawing.Point(167, 132)
        Me.tbNIT.MaxLength = 20
        Me.tbNIT.Name = "tbNIT"
        Me.tbNIT.Size = New System.Drawing.Size(287, 27)
        Me.tbNIT.TabIndex = 19
        '
        'tbRazonSocial
        '
        Me.tbRazonSocial.Location = New System.Drawing.Point(167, 96)
        Me.tbRazonSocial.MaxLength = 100
        Me.tbRazonSocial.Name = "tbRazonSocial"
        Me.tbRazonSocial.Size = New System.Drawing.Size(287, 27)
        Me.tbRazonSocial.TabIndex = 18
        '
        'tbInstitucion
        '
        Me.tbInstitucion.Location = New System.Drawing.Point(167, 61)
        Me.tbInstitucion.MaxLength = 50
        Me.tbInstitucion.Name = "tbInstitucion"
        Me.tbInstitucion.Size = New System.Drawing.Size(287, 27)
        Me.tbInstitucion.TabIndex = 17
        '
        'tbCodigoAsegurado
        '
        Me.tbCodigoAsegurado.Location = New System.Drawing.Point(167, 28)
        Me.tbCodigoAsegurado.MaxLength = 50
        Me.tbCodigoAsegurado.Name = "tbCodigoAsegurado"
        Me.tbCodigoAsegurado.Size = New System.Drawing.Size(287, 27)
        Me.tbCodigoAsegurado.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(7, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 19)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "NIT"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(7, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 19)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Razón Social"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(7, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(83, 19)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Institución"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(7, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 19)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Codigo de Asegurado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.lkInexistente)
        Me.GroupBox3.Controls.Add(Me.tbBuscar)
        Me.GroupBox3.Controls.Add(Me.cbCampo)
        Me.GroupBox3.Controls.Add(Me.dgvListadoClientes)
        Me.GroupBox3.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(506, 117)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(422, 571)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Clientes"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(334, 67)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 23)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "Eliminar"
        Me.CheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.SisBioMedica.My.Resources.Resources.search1
        Me.btnBuscar.Location = New System.Drawing.Point(260, 68)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(25, 24)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lkInexistente
        '
        Me.lkInexistente.AutoSize = True
        Me.lkInexistente.Location = New System.Drawing.Point(147, 245)
        Me.lkInexistente.Name = "lkInexistente"
        Me.lkInexistente.Size = New System.Drawing.Size(138, 19)
        Me.lkInexistente.TabIndex = 19
        Me.lkInexistente.TabStop = True
        Me.lkInexistente.Text = "Datos Inexistentes"
        '
        'tbBuscar
        '
        Me.tbBuscar.Location = New System.Drawing.Point(6, 68)
        Me.tbBuscar.MaxLength = 100
        Me.tbBuscar.Name = "tbBuscar"
        Me.tbBuscar.Size = New System.Drawing.Size(248, 27)
        Me.tbBuscar.TabIndex = 18
        '
        'cbCampo
        '
        Me.cbCampo.AutoCompleteCustomSource.AddRange(New String() {"nombre", "apellido", "ci", "nit"})
        Me.cbCampo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbCampo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCampo.FormattingEnabled = True
        Me.cbCampo.Items.AddRange(New Object() {"nombre", "apellido", "ci", "nit"})
        Me.cbCampo.Location = New System.Drawing.Point(6, 34)
        Me.cbCampo.Name = "cbCampo"
        Me.cbCampo.Size = New System.Drawing.Size(142, 27)
        Me.cbCampo.TabIndex = 18
        Me.cbCampo.Text = "ci"
        '
        'dgvListadoClientes
        '
        Me.dgvListadoClientes.AllowUserToAddRows = False
        Me.dgvListadoClientes.AllowUserToDeleteRows = False
        Me.dgvListadoClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgvListadoClientes.Location = New System.Drawing.Point(6, 100)
        Me.dgvListadoClientes.Name = "dgvListadoClientes"
        Me.dgvListadoClientes.ReadOnly = True
        Me.dgvListadoClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoClientes.Size = New System.Drawing.Size(410, 465)
        Me.dgvListadoClientes.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
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
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(943, 35)
        Me.PictureBox1.TabIndex = 24
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
        Me.btnCancelar.Location = New System.Drawing.Point(384, 619)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 70)
        Me.btnCancelar.TabIndex = 22
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
        Me.btnEditar.Location = New System.Drawing.Point(270, 619)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(70, 70)
        Me.btnEditar.TabIndex = 20
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(156, 619)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(70, 70)
        Me.btnGuardar.TabIndex = 19
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(42, 619)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(70, 70)
        Me.btnNuevo.TabIndex = 18
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'imgbxLogo
        '
        Me.imgbxLogo.Image = Global.SisBioMedica.My.Resources.Resources.logobiom
        Me.imgbxLogo.Location = New System.Drawing.Point(778, 40)
        Me.imgbxLogo.Name = "imgbxLogo"
        Me.imgbxLogo.Size = New System.Drawing.Size(150, 40)
        Me.imgbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgbxLogo.TabIndex = 17
        Me.imgbxLogo.TabStop = False
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(940, 700)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.imgbxLogo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvListadoClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbApellidos As TextBox
    Friend WithEvents tbNombres As TextBox
    Friend WithEvents tbCelular As TextBox
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents tbEdad As TextBox
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents tbNIT As TextBox
    Friend WithEvents tbRazonSocial As TextBox
    Friend WithEvents tbInstitucion As TextBox
    Friend WithEvents tbCodigoAsegurado As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents imgbxLogo As PictureBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents dgvListadoClientes As DataGridView
    Friend WithEvents cbCampo As ComboBox
    Friend WithEvents lkInexistente As LinkLabel
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents lbci As Label
    Friend WithEvents tbci As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCodigo_Cliente As TextBox
End Class
