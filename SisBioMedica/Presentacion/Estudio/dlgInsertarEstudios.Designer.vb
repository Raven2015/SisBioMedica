<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgInsertarEstudios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgInsertarEstudios))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chbEliminar = New System.Windows.Forms.CheckBox()
        Me.lbInexistente = New System.Windows.Forms.LinkLabel()
        Me.dgvListadoAtenciones = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.btBuscarEstudio = New System.Windows.Forms.Button()
        Me.tbNombreEstudio = New System.Windows.Forms.TextBox()
        Me.tbIdEstudio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbApellidoCliente = New System.Windows.Forms.TextBox()
        Me.tbNombreCliente = New System.Windows.Forms.TextBox()
        Me.dtpFechaAtencion = New System.Windows.Forms.DateTimePicker()
        Me.tbCICliente = New System.Windows.Forms.TextBox()
        Me.tbNumComprobante = New System.Windows.Forms.TextBox()
        Me.tbCodigoCliente = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.tbid_atencion = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardarEstudio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbEliminar)
        Me.GroupBox3.Controls.Add(Me.lbInexistente)
        Me.GroupBox3.Controls.Add(Me.dgvListadoAtenciones)
        Me.GroupBox3.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(434, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 320)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Categorias"
        '
        'chbEliminar
        '
        Me.chbEliminar.AutoSize = True
        Me.chbEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEliminar.Location = New System.Drawing.Point(272, 12)
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
        Me.lbInexistente.Location = New System.Drawing.Point(119, 162)
        Me.lbInexistente.Name = "lbInexistente"
        Me.lbInexistente.Size = New System.Drawing.Size(138, 19)
        Me.lbInexistente.TabIndex = 19
        Me.lbInexistente.TabStop = True
        Me.lbInexistente.Text = "Datos Inexistentes"
        '
        'dgvListadoAtenciones
        '
        Me.dgvListadoAtenciones.AllowUserToAddRows = False
        Me.dgvListadoAtenciones.AllowUserToDeleteRows = False
        Me.dgvListadoAtenciones.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoAtenciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgvListadoAtenciones.Location = New System.Drawing.Point(4, 41)
        Me.dgvListadoAtenciones.Name = "dgvListadoAtenciones"
        Me.dgvListadoAtenciones.ReadOnly = True
        Me.dgvListadoAtenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoAtenciones.Size = New System.Drawing.Size(350, 272)
        Me.dgvListadoAtenciones.TabIndex = 0
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.tbPrecio)
        Me.GroupBox1.Controls.Add(Me.btnGuardarEstudio)
        Me.GroupBox1.Controls.Add(Me.btBuscarEstudio)
        Me.GroupBox1.Controls.Add(Me.tbNombreEstudio)
        Me.GroupBox1.Controls.Add(Me.tbIdEstudio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbApellidoCliente)
        Me.GroupBox1.Controls.Add(Me.tbNombreCliente)
        Me.GroupBox1.Controls.Add(Me.dtpFechaAtencion)
        Me.GroupBox1.Controls.Add(Me.tbCICliente)
        Me.GroupBox1.Controls.Add(Me.tbNumComprobante)
        Me.GroupBox1.Controls.Add(Me.tbCodigoCliente)
        Me.GroupBox1.Controls.Add(Me.Fecha)
        Me.GroupBox1.Controls.Add(Me.tbid_atencion)
        Me.GroupBox1.Font = New System.Drawing.Font("Glober Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 320)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Actuales"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(11, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 19)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Precio"
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(81, 195)
        Me.tbPrecio.MaxLength = 50
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(145, 27)
        Me.tbPrecio.TabIndex = 50
        '
        'btBuscarEstudio
        '
        Me.btBuscarEstudio.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btBuscarEstudio.FlatAppearance.BorderSize = 0
        Me.btBuscarEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscarEstudio.ForeColor = System.Drawing.Color.White
        Me.btBuscarEstudio.Location = New System.Drawing.Point(367, 162)
        Me.btBuscarEstudio.Name = "btBuscarEstudio"
        Me.btBuscarEstudio.Size = New System.Drawing.Size(39, 27)
        Me.btBuscarEstudio.TabIndex = 49
        Me.btBuscarEstudio.Text = "..."
        Me.btBuscarEstudio.UseVisualStyleBackColor = False
        '
        'tbNombreEstudio
        '
        Me.tbNombreEstudio.Location = New System.Drawing.Point(81, 162)
        Me.tbNombreEstudio.MaxLength = 50
        Me.tbNombreEstudio.Name = "tbNombreEstudio"
        Me.tbNombreEstudio.Size = New System.Drawing.Size(280, 27)
        Me.tbNombreEstudio.TabIndex = 48
        '
        'tbIdEstudio
        '
        Me.tbIdEstudio.Location = New System.Drawing.Point(11, 162)
        Me.tbIdEstudio.MaxLength = 50
        Me.tbIdEstudio.Name = "tbIdEstudio"
        Me.tbIdEstudio.Size = New System.Drawing.Size(64, 27)
        Me.tbIdEstudio.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(11, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Estudio"
        '
        'tbApellidoCliente
        '
        Me.tbApellidoCliente.Enabled = False
        Me.tbApellidoCliente.Location = New System.Drawing.Point(190, 59)
        Me.tbApellidoCliente.MaxLength = 50
        Me.tbApellidoCliente.Name = "tbApellidoCliente"
        Me.tbApellidoCliente.Size = New System.Drawing.Size(216, 27)
        Me.tbApellidoCliente.TabIndex = 38
        '
        'tbNombreCliente
        '
        Me.tbNombreCliente.Enabled = False
        Me.tbNombreCliente.Location = New System.Drawing.Point(11, 59)
        Me.tbNombreCliente.MaxLength = 50
        Me.tbNombreCliente.Name = "tbNombreCliente"
        Me.tbNombreCliente.Size = New System.Drawing.Size(173, 27)
        Me.tbNombreCliente.TabIndex = 36
        '
        'dtpFechaAtencion
        '
        Me.dtpFechaAtencion.Enabled = False
        Me.dtpFechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAtencion.Location = New System.Drawing.Point(270, 129)
        Me.dtpFechaAtencion.Name = "dtpFechaAtencion"
        Me.dtpFechaAtencion.Size = New System.Drawing.Size(136, 27)
        Me.dtpFechaAtencion.TabIndex = 35
        '
        'tbCICliente
        '
        Me.tbCICliente.Enabled = False
        Me.tbCICliente.Location = New System.Drawing.Point(235, 26)
        Me.tbCICliente.MaxLength = 50
        Me.tbCICliente.Name = "tbCICliente"
        Me.tbCICliente.Size = New System.Drawing.Size(171, 27)
        Me.tbCICliente.TabIndex = 33
        '
        'tbNumComprobante
        '
        Me.tbNumComprobante.Enabled = False
        Me.tbNumComprobante.Location = New System.Drawing.Point(154, 26)
        Me.tbNumComprobante.MaxLength = 50
        Me.tbNumComprobante.Name = "tbNumComprobante"
        Me.tbNumComprobante.Size = New System.Drawing.Size(30, 27)
        Me.tbNumComprobante.TabIndex = 26
        Me.tbNumComprobante.Visible = False
        '
        'tbCodigoCliente
        '
        Me.tbCodigoCliente.Enabled = False
        Me.tbCodigoCliente.Location = New System.Drawing.Point(190, 26)
        Me.tbCodigoCliente.MaxLength = 50
        Me.tbCodigoCliente.Name = "tbCodigoCliente"
        Me.tbCodigoCliente.Size = New System.Drawing.Size(27, 27)
        Me.tbCodigoCliente.TabIndex = 23
        Me.tbCodigoCliente.Visible = False
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Fecha.Location = New System.Drawing.Point(11, 137)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(107, 19)
        Me.Fecha.TabIndex = 22
        Me.Fecha.Text = "Fecha Estudio"
        '
        'tbid_atencion
        '
        Me.tbid_atencion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbid_atencion.Enabled = False
        Me.tbid_atencion.Location = New System.Drawing.Point(329, 0)
        Me.tbid_atencion.MaxLength = 50
        Me.tbid_atencion.Name = "tbid_atencion"
        Me.tbid_atencion.Size = New System.Drawing.Size(77, 20)
        Me.tbid_atencion.TabIndex = 20
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.SisBioMedica.My.Resources.Resources.garbage1
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(256, 243)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 70)
        Me.btnEliminar.TabIndex = 78
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.SisBioMedica.My.Resources.Resources.new_24
        Me.btnNuevo.Location = New System.Drawing.Point(116, 243)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(70, 70)
        Me.btnNuevo.TabIndex = 75
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = Global.SisBioMedica.My.Resources.Resources.close
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(331, 243)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 70)
        Me.btnCancelar.TabIndex = 77
        Me.btnCancelar.Text = "Salir"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardarEstudio
        '
        Me.btnGuardarEstudio.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardarEstudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardarEstudio.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnGuardarEstudio.FlatAppearance.BorderSize = 0
        Me.btnGuardarEstudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEstudio.Font = New System.Drawing.Font("Glober Bold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarEstudio.Image = CType(resources.GetObject("btnGuardarEstudio.Image"), System.Drawing.Image)
        Me.btnGuardarEstudio.Location = New System.Drawing.Point(186, 243)
        Me.btnGuardarEstudio.Name = "btnGuardarEstudio"
        Me.btnGuardarEstudio.Size = New System.Drawing.Size(70, 70)
        Me.btnGuardarEstudio.TabIndex = 76
        Me.btnGuardarEstudio.Text = "Agregar"
        Me.btnGuardarEstudio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarEstudio.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnGuardarEstudio.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Glober Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Cliente"
        '
        'dlgInsertarEstudios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 338)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "dlgInsertarEstudios"
        Me.Text = "Añadir Estudios"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvListadoAtenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardarEstudio As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chbEliminar As CheckBox
    Friend WithEvents lbInexistente As LinkLabel
    Friend WithEvents dgvListadoAtenciones As DataGridView
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents btBuscarEstudio As Button
    Friend WithEvents tbNombreEstudio As TextBox
    Friend WithEvents tbIdEstudio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbApellidoCliente As TextBox
    Friend WithEvents tbNombreCliente As TextBox
    Friend WithEvents dtpFechaAtencion As DateTimePicker
    Friend WithEvents tbCICliente As TextBox
    Friend WithEvents tbNumComprobante As TextBox
    Friend WithEvents tbCodigoCliente As TextBox
    Friend WithEvents Fecha As Label
    Friend WithEvents tbid_atencion As TextBox
    Friend WithEvents Label1 As Label
End Class
