﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteComprobante
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.generar_comprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbBioDataSet = New SisBioMedica.dbBioDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.generar_comprobanteTableAdapter = New SisBioMedica.dbBioDataSetTableAdapters.generar_comprobanteTableAdapter()
        Me.tbIdAtencion = New System.Windows.Forms.TextBox()
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbBioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'generar_comprobanteBindingSource
        '
        Me.generar_comprobanteBindingSource.DataMember = "generar_comprobante"
        Me.generar_comprobanteBindingSource.DataSource = Me.dbBioDataSet
        '
        'dbBioDataSet
        '
        Me.dbBioDataSet.DataSetName = "dbBioDataSet"
        Me.dbBioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.generar_comprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SisBioMedica.Comprobante.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(954, 496)
        Me.ReportViewer1.TabIndex = 0
        '
        'generar_comprobanteTableAdapter
        '
        Me.generar_comprobanteTableAdapter.ClearBeforeFill = True
        '
        'tbIdAtencion
        '
        Me.tbIdAtencion.Location = New System.Drawing.Point(825, 30)
        Me.tbIdAtencion.Name = "tbIdAtencion"
        Me.tbIdAtencion.Size = New System.Drawing.Size(100, 20)
        Me.tbIdAtencion.TabIndex = 1
        Me.tbIdAtencion.Visible = False
        '
        'frmReporteComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 496)
        Me.Controls.Add(Me.tbIdAtencion)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteComprobante"
        Me.Text = "frmReporteComprobante"
        CType(Me.generar_comprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbBioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents generar_comprobanteBindingSource As BindingSource
    Friend WithEvents dbBioDataSet As dbBioDataSet
    Friend WithEvents generar_comprobanteTableAdapter As dbBioDataSetTableAdapters.generar_comprobanteTableAdapter
    Friend WithEvents tbIdAtencion As TextBox
End Class
