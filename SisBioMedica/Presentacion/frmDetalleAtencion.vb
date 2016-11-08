Public Class frmDetalleAtencion
    Dim px, py As Integer
    Dim mover As Boolean

    Dim dt As New DataTable 'Se crea una variable para almacenar el resultado de la BD




    Private Sub dgvListadoAtenciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoAtenciones.CellContentClick

    End Sub

    Private Sub frmDetalleAtencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    '   &&&&&&&&&&&&&&&&&&&&    METODOS INTERNOS     &&&&&&&&&&&&&&&&&&&&

    '-----------ORDEN DE METODOS
    'LIMPIAR
    'MOSTRAR
    'BUSCAR
    'OCULTAR COLUMNAS

    '   --------------------    METODO LIMPIAR     --------------------
    Public Sub limpiar()
        'Limpia lo svalores de las cajas de texto.
        btnGuardarEstudio.Visible = True
        tbIdEstudio.Text = ""
        tbNombreEstudio.Text = ""
    End Sub

    '   --------------------    METODO MOSTRAR     --------------------
    Private Sub mostrar()

        Try

            Dim func As New fDetalle 'Se crea una instancia de la clase fCategoria.
            dt = func.mostrar 'Se llama al procedimiento mostrar de la clase fCategoria
            dgvListadoAtenciones.Columns.Item("Eliminar").Visible = False 'Ocultamos la columna eliminar que se acaba de crear

            If dt.Rows.Count <> 0 Then 'Se comprueba que el numero de filas sea diferente de 0
                dgvListadoAtenciones.DataSource = dt 'Se transfieren los datos de la variable dt al Data Grid View
                dgvListadoAtenciones.ColumnHeadersVisible = True 'Se hacen visibles las cabeceras del DataGridView
                lbInexistente.Visible = False 'Se oculta el linkLabel.
            Else
                dgvListadoAtenciones.DataSource = Nothing 'Como no hay datos no se muestra nada
                dgvListadoAtenciones.ColumnHeadersVisible = False 'Se ocultan las cabeceras del DataGridView
                lbInexistente.Visible = True 'Se muestra el linkLabel.

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnNuevo.Visible = True 'Se muestra el boton Nuevo
        tbid_atencion.Visible = False

        buscar()
    End Sub

    '   --------------------    METODO BUSCAR     --------------------
    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "id_estudio='" & tbIdEstudio.Text & "'"
            If dv.Count <> 0 Then
                lbInexistente.Visible = False
                dgvListadoAtenciones.DataSource = dv
                ocultar_columnas()
            Else
                lbInexistente.Visible = True
                dgvListadoAtenciones.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '   --------------------    METODO OCULTAR COLUMNAS     --------------------
    Private Sub ocultar_columnas()
        dgvListadoAtenciones.Columns(1).Visible = False
        dgvListadoAtenciones.Columns(2).Visible = False
        dgvListadoAtenciones.Columns(3).Visible = False
    End Sub
    '   &&&&&&&&&&&&&&&&&&&&    FIN METODOS INTERNOS     &&&&&&&&&&&&&&&&&&&&




    '   &&&&&&&&&&&&&&&&&&&&    BOTONES DE INTERFAZ     &&&&&&&&&&&&&&&&&&&&

    '--------- ORDEN DE BOTONES
    'NUEVO
    'GUARDAR
    'EDITAR
    'CANCELAR
    'ELIMINAR
    'CERRAR



    '   --------------------    BOTON NUEVO     --------------------
    Private Sub btnNuevo_Click_1(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'Al presionar el boton nuevo, se limpian los datos y se muestran los valores por defecto.
        limpiar()
        mostrar()
    End Sub

    '   --------------------    BOTON GUARDAR     --------------------
    Private Sub btnGuardarEstudio_Click(sender As Object, e As EventArgs) Handles btnGuardarEstudio.Click
        'Al presionar el boton guardar se ejecutan una serie de acciones que permiten crear un nuevo registro en la base de datos.
        'PRIMERO: Se verifica que las cajas de texto imprescindibles no esten vacias, que la fecha no sea la actual y otros.
        If Me.ValidateChildren = True And tbNombreCliente.Text <> "" And tbCodigoCliente.Text <> "" And tbNumComprobante.Text <> "" Then
            Try
                'Se crea una nueva instancia de la clase VCategoria
                Dim dts As New vAtencion
                'Se crea una nueva instancia de la clase fCategoria
                Dim func As New fAtencion

                'Se pasan los datos existentes en las cajas de texto a la variable dts a traves de sus getters
                dts.gid_cliente = tbCodigoCliente.Text
                'dts.gcodigo_categoria = tbCodigoCategoria.Text
                dts.gfecha = dtpFechaAtencion.Text
                dts.gtipo_documento = "Orden de Atencion"
                dts.gnumero_documento = tbid_atencion.Text
                dts.gdoctor_remitente = tbMedicoRemitente.Text

                'Se verifica que la funcion insertar devuelva Verdadero, lo cual significa que se registro correctamente.
                If func.insertar(dts) Then
                    'Se muestra un dialogo de informacion, de registro existoso
                    MessageBox.Show("Reporte Registrado Correctamente. Seleccion los Estudios requeridos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                    cargar_detalle()

                Else
                    'Se muestra un dialogo de alerta, de registro incorrecto
                    MessageBox.Show("Reporte no Registrado, Intente de Nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    '   --------------------    BOTON EDITAR     --------------------
    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs)
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del Reporte?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            'Al presionar el boton editar se ejecutan una serie de acciones que permiten crear un nuevo registro en la base de datos.
            'PRIMERO: Se verifica que las cajas de texto imprescindibles no esten vacias, que la fecha no sea la actual y otros.
            If Me.ValidateChildren = True And tbCodigoCliente.Text <> "" And tbCodigoCliente.Text <> "" And tbid_atencion.Text <> "" Then
                Try
                    'Se crea una nueva instancia de la clase VCategoria
                    Dim dts As New vAtencion
                    'Se crea una nueva instancia de la clase fCategoria
                    Dim func As New fAtencion

                    'Se pasan los datos existentes en las cajas de texto a la variable dts a traves de sus getters
                    'dts.gid_estudio = tbid_atencion.Text
                    'dts.gnombre_estudio = tbNombreEstudio.Text
                    'dts.gid_categoria = tbid_categoria.Text
                    'dts.gprecio = tbNumComprobante.Text
                    'dts.gcodigo_estudio = tbCodigoCliente.Text
                    'dts.gdescuento = tbDescuento.Text

                    'Se verifica que la funcion insertar devuelva Verdadero, lo cual significa que se registro correctamente.
                    If func.editar(dts) Then
                        'Se muestra un dialogo de informacion, de registro existoso
                        MessageBox.Show("Estudio Modificado Correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    '   --------------------    BOTON CANCELAR     --------------------
    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Al presionar el boton cancelar, se limpia la pantalla de datos y se muestran los valores por defecto.
        mostrar()
        limpiar()
    End Sub


    '   --------------------    BOTON ELIMINAR     --------------------

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs)
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los datos de los estudios seleccionadas?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListadoAtenciones.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_categoria").Value)
                        Dim vdb As New vEstudio
                        Dim func As New fEstudio
                        vdb.gid_estudio = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("No se pudo eliminar los estudios seleccionados?", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    '   --------------------    BOTON BUSCAR CATEGORIA     --------------------
    Private Sub btnBuscarCategoria_Click(sender As Object, e As EventArgs)
        frmCategoria.tbFlag.Text = "1"
        frmCategoria.ShowDialog()
    End Sub


    '   --------------------    BOTON CERRAR     --------------------
    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    '   --------------------    BOTON BUSCAR     --------------------
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        mostrar()
    End Sub

    '   &&&&&&&&&&&&&&&&&&&&    FIN BOTONES INTERFAZ     &&&&&&&&&&&&&&&&&&&&





    '   &&&&&&&&&&&&&&&&&&&&    METODOS PARA EL LISTADO     &&&&&&&&&&&&&&&&&&&&

    '--------- ORDEN DE METODOS
    'CHECKBOX ELIMINAR
    'CLICK EN CONTENIDO DE CELDA
    'CLICK EN CELDA


    '   --------------------    CHECKBOX ELIMINAR     --------------------
    Private Sub chbEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chbEliminar.CheckedChanged
        If chbEliminar.CheckState = CheckState.Checked Then
            dgvListadoAtenciones.Columns.Item("Eliminar").Visible = True
        Else
            dgvListadoAtenciones.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    '   --------------------    CLICK EN CONTENIDO DE CELDA DEL LISTADO     --------------------
    Private Sub dgvListadoEstudios_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoAtenciones.CellContentClick
        If e.ColumnIndex = Me.dgvListadoAtenciones.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dgvListadoAtenciones.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub



    '   --------------------    CLICK EN CELDA DEL LISTADO     --------------------
    Private Sub dgvListadoEstudios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoAtenciones.CellClick
        tbid_atencion.Text = dgvListadoAtenciones.SelectedCells.Item(1).Value
        tbCodigoCliente.Text = dgvListadoAtenciones.SelectedCells.Item(2).Value
        tbCICliente.Text = dgvListadoAtenciones.SelectedCells.Item(5).Value
        tbNombreCliente.Text = dgvListadoAtenciones.SelectedCells.Item(3).Value
        tbApellidoCliente.Text = dgvListadoAtenciones.SelectedCells.Item(4).Value
        tbSexoCliente.Text = dgvListadoAtenciones.SelectedCells.Item(10).Value
        tbDireccion = dgvListadoAtenciones.SelectedCells.Item(7).Value
        tbCelular.Text = dgvListadoAtenciones.SelectedCells.Item(9).Value
        tbMedicoRemitente.Text = dgvListadoAtenciones.SelectedCells.Item(3).Value
        tbNumComprobante.Text = dgvListadoAtenciones.SelectedCells.Item(7).Value
        dtpFechaAtencion.Text = dgvListadoAtenciones.SelectedCells.Item(18).Value


        btnGuardarEstudio.Visible = False
        btnEditar.Visible = True
    End Sub

    '   --------------------    DOBLE CLICK EN CELDA DEL LISTADO     --------------------
    Private Sub dgvListadoAtenciones_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoAtenciones.CellDoubleClick
        cargar_detalle()
    End Sub


    '   &&&&&&&&&&&&&&&&&&&&    FIN METODOS LISTADO     &&&&&&&&&&&&&&&&&&&&




    '   &&&&&&&&&&&&&&&&&&&&    METODOS DE VALIDACION     &&&&&&&&&&&&&&&&&&&&

    '--------- ORDEN DE VALIDACION
    'CODIGO_ESTUDIO
    'NOMBRE_ESTUDIO
    'PRECIO
    '


    '   &&&&&&&&&&&&&&&&&&&&    FIN METODOS DE VALIDACION     &&&&&&&&&&&&&&&&&&&&






    '   &&&&&&&&&&&&&&&&&&&&    METODOS PARA CARGAR LOS ESTUDIOS     &&&&&&&&&&&&&&&&&&&&

    Private Sub cargar_detalle()
        frmDetalleAtencion.tbid_atencion.Text = dgvListadoAtenciones.SelectedCells.Item(1).Value
        frmDetalleAtencion.tbCodigoCliente.Text = dgvListadoAtenciones.SelectedCells.Item(2).Value
        frmDetalleAtencion.tbCICliente.Text = dgvListadoAtenciones.SelectedCells.Item(5).Value
        frmDetalleAtencion.tbNombreCliente.Text = dgvListadoAtenciones.SelectedCells.Item(3).Value
        frmDetalleAtencion.tbApellidoCliente.Text = dgvListadoAtenciones.SelectedCells.Item(4).Value
        frmDetalleAtencion.tbSexoCliente.Text = dgvListadoAtenciones.SelectedCells.Item(10).Value
        frmDetalleAtencion.tbDireccion.Text = dgvListadoAtenciones.SelectedCells.Item(7).Value
        frmDetalleAtencion.tbCelular.Text = dgvListadoAtenciones.SelectedCells.Item(9).Value
        frmDetalleAtencion.tbMedicoRemitente.Text = dgvListadoAtenciones.SelectedCells.Item(15).Value
        frmDetalleAtencion.tbNumComprobante.Text = dgvListadoAtenciones.SelectedCells.Item(16).Value
        frmDetalleAtencion.dtpFechaAtencion.Text = dgvListadoAtenciones.SelectedCells.Item(18).Value

        frmDetalleAtencion.ShowDialog()
    End Sub

    '   &&&&&&&&&&&&&&&&&&&&    FIN METODO CARGAR     &&&&&&&&&&&&&&&&&&&&




    '   &&&&&&&&&&&&&&&&&&&&    CODIGO QUE PERMITE MOVER LA VENTANA A CUALQUIER PUNTO DE LA PANTALLA     &&&&&&&&&&&&&&&&&&&&
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        mover = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub tbBusca_TextChanged(sender As Object, e As EventArgs)
        buscar()
    End Sub

    Private Sub tbCodigoEstudio_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles tbCodigoCliente.Validating

    End Sub

    Private Sub tbNombres_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If mover Then
            'Permite mover la ventana a cualquier punto
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))
        End If
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmCliente.tbFlag.Text = "1"
        frmCliente.ShowDialog()
    End Sub


    '   &&&&&&&&&&&&&&&&&&&&    FIN CODIGO MOVER VENTANA     &&&&&&&&&&&&&&&&&&&&
End Class