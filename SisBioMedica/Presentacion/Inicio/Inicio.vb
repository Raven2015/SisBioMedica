Public Class Inicio
    Private Sub btnEstudios_Click(sender As Object, e As EventArgs) Handles btnEstudios.Click
        frmEstudio.ShowDialog()
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        frmCategoria.ShowDialog()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmCliente.ShowDialog()
    End Sub

    Private Sub btnAtencion_Click(sender As Object, e As EventArgs) Handles btnAtencion.Click
        frmAtencion.ShowDialog()
    End Sub
End Class