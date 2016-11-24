Public Class frmReporteEstudios
    Private Sub frmReporteEstudios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dbBioDataSet.mostrar_estudio' table. You can move, or remove it, as needed.
        Me.mostrar_estudioTableAdapter.Fill(Me.dbBioDataSet.mostrar_estudio)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class