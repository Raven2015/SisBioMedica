Imports System.ComponentModel

Public Class frmCategoria
    Dim px, py As Integer
    Dim mover As Boolean
    Dim fecha_nac As Integer

    Dim dt As New DataTable 'Se crea una variable para almacenar el resultado de la BD
    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    ' ---------------------------- REUTILIZANDO CODIGO ----------------------------

    Private Sub mostrar()
        Try
            Dim func As New fCategoria 'Se crea una instancia de la clase fCategoria.
            dt = func.mostrar 'Se llama al procedimiento mostrar de la clase fCategoria
            dgvListadoCategorias.Columns.Item("Eliminar").Visible = False 'Ocultamos la columna eliminar que se acaba de crear

            If dt.Rows.Count <> 0 Then 'Se comprueba que el numero de filas sea diferente de 0
                dgvListadoCategorias.DataSource = dt 'Se transfieren los datos de la variable dt al Data Grid View
                tbBuscar.Enabled = True 'Se habilita el TextBox Buscar ya que existen datos
                dgvListadoCategorias.ColumnHeadersVisible = True 'Se hacen visibles las cabeceras del DataGridView
                lkInexistente.Visible = False 'Se oculta el linkLabel.
            Else
                dgvListadoCategorias.DataSource = Nothing 'Como no hay datos no se muestra nada
                tbBuscar.Enabled = False 'Se deshabilita el TextBox Buscar ya que no existen datos
                dgvListadoCategorias.ColumnHeadersVisible = False 'Se ocultan las cabeceras del DataGridView
                lkInexistente.Visible = True 'Se muestra el linkLabel.
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True 'Se muestra el boton Nuevo
        btnEditar.Visible = False 'Se oculta el boton editar

        buscar()
    End Sub


    'Private Sub buscar()
    '    Try
    '        Dim ds As New DataSet 'Se crea una variable que se encarga de copiar todos los registros del DataTable
    '        ds.Tables.Add(dt.Copy) 'Copia todos los datos del DataTable a la variable ds
    '        Dim dv As New DataView(ds.Tables(0)) 'Se crea un DataView y se le envia como parametros los  datos de ds

    '        dv.RowFilter = cbCampo.Text & "like '" & tbBuscar.Text & "%'"

    '        If dv.Count <> 0 Then
    '            lkInexistente.Visible = False
    '            dgvListadoClientes.DataSource = dv
    '            ocultar_columnas()
    '        Else
    '            lkInexistente.Visible = True
    '            dgvListadoClientes.DataSource = Nothing
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbCampo.Text & " like '" & tbBuscar.Text & "%'"
            If dv.Count <> 0 Then
                lkInexistente.Visible = False
                dgvListadoCategorias.DataSource = dv
                ocultar_columnas()
            Else
                lkInexistente.Visible = True
                dgvListadoCategorias.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ocultar_columnas()
        dgvListadoCategorias.Columns(1).Visible = False
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        mover = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrar()
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If mover Then
            'Permite mover la ventana a cualquier punto
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))
        End If
    End Sub


    Private Sub tbNombres_Validating(sender As Object, e As CancelEventArgs) 
        'Permite validar que el campo nombres no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el nombre de la categoria por favor, Este dato es obligatorio")
        End If
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Al presionar el boton nuevo, se limpian los datos y se muestran los valores por defecto.
        limpiar()
        mostrar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Al presionar el boton guardar se ejecutan una serie de acciones que permiten crear un nuevo registro en la base de datos.
        'PRIMERO: Se verifica que las cajas de texto imprescindibles no esten vacias, que la fecha no sea la actual y otros.
        If Me.ValidateChildren = True And tbCodigoCategoria.Text <> "" And tbCodigoCategoria.Text <> "" Then
            Try
                'Se crea una nueva instancia de la clase VCategoria
                Dim dts As New vCategoria
                'Se crea una nueva instancia de la clase fCategoria
                Dim func As New fCategoria

                'Se pasan los datos existentes en las cajas de texto a la variable dts a traves de sus getters
                dts.gnombre_categoria = tbCodigoCategoria.Text
                dts.gcodigo_categoria = tbCodigoCategoria.Text

                'Se verifica que la funcion insertar devuelva Verdadero, lo cual significa que se registro correctamente.
                If func.insertar(dts) Then
                    'Se muestra un dialogo de informacion, de registro existoso
                    MessageBox.Show("Categoria Registrada Correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    'Se muestra un dialogo de alerta, de registro incorrecto
                    MessageBox.Show("Categoria no Registrada, Intente de Nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'En caso de que alguna de las cajas te texto esten vacias, se muestra un dialogo de informacion.
            MessageBox.Show("Datos faltantes, por favor rellene todos los campos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Public Sub limpiar()
        'Limpia lo svalores de las cajas de texto.
        btnGuardar.Visible = True
        btnEditar.Visible = False
        tbCodigoCategoria.Text = ""
        tbid_categoria.Text = ""
        tbCodigoCategoria.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Al presionar el boton cancelar, se limpia la pantalla de datos y se muestran los valores por defecto.
        mostrar()
        limpiar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos de la categoria?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            'Al presionar el boton editar se ejecutan una serie de acciones que permiten crear un nuevo registro en la base de datos.
            'PRIMERO: Se verifica que las cajas de texto imprescindibles no esten vacias, que la fecha no sea la actual y otros.
            If Me.ValidateChildren = True And tbCodigoCategoria.Text <> "" And tbCodigoCategoria.Text <> "" Then
                Try
                    'Se crea una nueva instancia de la clase VCategoria
                    Dim dts As New vCategoria
                    'Se crea una nueva instancia de la clase fCategoria
                    Dim func As New fCategoria

                    'Se pasan los datos existentes en las cajas de texto a la variable dts a traves de sus getters
                    dts.gid_categoria = tbid_categoria.Text
                    dts.gnombre_categoria = tbCodigoCategoria.Text
                    dts.gcodigo_categoria = tbCodigoCategoria.Text

                    'Se verifica que la funcion insertar devuelva Verdadero, lo cual significa que se registro correctamente.
                    If func.editar(dts) Then
                        'Se muestra un dialogo de informacion, de registro existoso
                        MessageBox.Show("Categoria Modificada Correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        'Se muestra un dialogo de alerta, de registro incorrecto
                        MessageBox.Show("No se pudo modificar los datos, Intente de Nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                'En caso de que alguna de las cajas te texto esten vacias, se muestra un dialogo de informacion.
                MessageBox.Show("Datos faltantes, por favor rellene todos los campos", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub chbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chbEliminar.CheckedChanged
        If chbEliminar.CheckState = CheckState.Checked Then
            dgvListadoCategorias.Columns.Item("Eliminar").Visible = True
        Else
            dgvListadoCategorias.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dgvListadoClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoCategorias.CellContentClick
        If e.ColumnIndex = Me.dgvListadoCategorias.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dgvListadoCategorias.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los datos de las categorias seleccionadas?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListadoCategorias.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_categoria").Value)
                        Dim vdb As New vCategoria
                        Dim func As New fCategoria
                        vdb.gid_categoria = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("No se pudo eliminar las categoria seleccionadas?", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                Next
                Call mostrar()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros?", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call mostrar()
        End If
        Call limpiar()
    End Sub


    Private Sub dgvListadoClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoCategorias.CellClick
        tbid_categoria.Text = dgvListadoCategorias.SelectedCells.Item(1).Value
        tbCodigoCategoria.Text = dgvListadoCategorias.SelectedCells.Item(2).Value
        tbCodigoCategoria.Text = dgvListadoCategorias.SelectedCells.Item(3).Value
        btnGuardar.Visible = False
        btnEditar.Visible = True
    End Sub

    Private Sub tbCodigoCategoria_Validating(sender As Object, e As CancelEventArgs) Handles tbCodigoCategoria.Validating
        'Permite validar que el campo Codigo de categoria no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el codigo de categoria por favor, Este dato es obligatorio")
        End If
    End Sub
End Class