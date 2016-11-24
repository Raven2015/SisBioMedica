<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReporteClientes
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dbBioDataSet = New SisBioMedica.dbBioDataSet()
        Me.mostrar_clienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mostrar_clienteTableAdapter = New SisBioMedica.dbBioDataSetTableAdapters.mostrar_clienteTableAdapter()
        CType(Me.dbBioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mostrar_clienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.mostrar_clienteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SisBioMedica.RClientes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(815, 479)
        Me.ReportViewer1.TabIndex = 0
        '
        'dbBioDataSet
        '
        Me.dbBioDataSet.DataSetName = "dbBioDataSet"
        Me.dbBioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'mostrar_clienteBindingSource
        '
        Me.mostrar_clienteBindingSource.DataMember = "mostrar_cliente"
        Me.mostrar_clienteBindingSource.DataSource = Me.dbBioDataSet
        '
        'mostrar_clienteTableAdapter
        '
        Me.mostrar_clienteTableAdapter.ClearBeforeFill = True
        '
        'frmReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 479)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteClientes"
        Me.Text = "frmReporteClientes"
        CType(Me.dbBioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mostrar_clienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mostrar_clienteBindingSource As BindingSource
    Friend WithEvents dbBioDataSet As dbBioDataSet
    Friend WithEvents mostrar_clienteTableAdapter As dbBioDataSetTableAdapters.mostrar_clienteTableAdapter
End Class
