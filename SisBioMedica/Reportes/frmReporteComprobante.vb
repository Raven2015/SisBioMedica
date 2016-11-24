Public Class frmReporteComprobante
    Private Sub frmReporteComprobante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbBioDataSet.generar_comprobante' table. You can move, or remove it, as needed.
        Me.generar_comprobanteTableAdapter.Fill(Me.dbBioDataSet.generar_comprobante, id_atencion:=tbIdAtencion.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class