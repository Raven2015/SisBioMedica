<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.btnEstudios = New System.Windows.Forms.Button()
        Me.btnCategorias = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnAtencion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEstudios
        '
        Me.btnEstudios.Location = New System.Drawing.Point(12, 11)
        Me.btnEstudios.Name = "btnEstudios"
        Me.btnEstudios.Size = New System.Drawing.Size(75, 23)
        Me.btnEstudios.TabIndex = 0
        Me.btnEstudios.Text = "Estudios"
        Me.btnEstudios.UseVisualStyleBackColor = True
        '
        'btnCategorias
        '
        Me.btnCategorias.Location = New System.Drawing.Point(93, 11)
        Me.btnCategorias.Name = "btnCategorias"
        Me.btnCategorias.Size = New System.Drawing.Size(75, 23)
        Me.btnCategorias.TabIndex = 1
        Me.btnCategorias.Text = "Categorias"
        Me.btnCategorias.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(174, 11)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(75, 23)
        Me.btnClientes.TabIndex = 2
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnAtencion
        '
        Me.btnAtencion.Location = New System.Drawing.Point(255, 11)
        Me.btnAtencion.Name = "btnAtencion"
        Me.btnAtencion.Size = New System.Drawing.Size(75, 23)
        Me.btnAtencion.TabIndex = 3
        Me.btnAtencion.Text = "Atención"
        Me.btnAtencion.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(343, 46)
        Me.Controls.Add(Me.btnAtencion)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnCategorias)
        Me.Controls.Add(Me.btnEstudios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEstudios As Button
    Friend WithEvents btnCategorias As Button
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnAtencion As Button
End Class
