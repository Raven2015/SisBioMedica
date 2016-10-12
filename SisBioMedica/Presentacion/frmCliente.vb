Imports System.ComponentModel

Public Class frmCliente

    Dim px, py As Integer
    Dim mover As Boolean
    Dim fecha_nac As Integer

    Dim dt As New DataTable 'Se crea una variable para almacenar el resultado de la BD
    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar() 'Se llama al procedimiento mostrar() definido abajo
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fcliente 'Se crea una instancia de la clase fcliente.
            dt = func.mostrar 'Se llama al procedimiento mostrar de la clase fcliente
            dgvListadoClientes.Columns.Item("Eliminar").Visible = False 'Ocultamos la columna eliminar que se acaba de crear

            If dt.Rows.Count <> 0 Then 'Se comprueba que el numero de filas sea diferente de 0
                dgvListadoClientes.DataSource = dt 'Se transfieren los datos de la variable dt al Data Grid View
                tbBuscar.Enabled = True 'Se habilita el TextBox Buscar ya que existen datos
                dgvListadoClientes.ColumnHeadersVisible = True 'Se hacen visibles las cabeceras del DataGridView
                lkInexistente.Visible = False 'Se oculta el linkLabel.
            Else
                dgvListadoClientes.DataSource = Nothing 'Como no hay datos no se muestra nada
                tbBuscar.Enabled = False 'Se deshabilita el TextBox Buscar ya que no existen datos
                dgvListadoClientes.ColumnHeadersVisible = False 'Se ocultan las cabeceras del DataGridView
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
                dgvListadoClientes.DataSource = dv
                ocultar_columnas()
            Else
                lkInexistente.Visible = True
                dgvListadoClientes.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ocultar_columnas()
        dgvListadoClientes.Columns(1).Visible = False
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


    Private Sub tbNombres_Validating(sender As Object, e As CancelEventArgs) Handles tbNombres.Validating
        'Permite validar que el campo nombres no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el nombre del cliente por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbApellidos_Validating(sender As Object, e As CancelEventArgs) Handles tbApellidos.Validating
        'Permite validar que el campo apellidos no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el apellido del cliente por favor, Este dato es obligatorio")
        End If
    End Sub


    Private Sub tbDireccion_Validating(sender As Object, e As CancelEventArgs) Handles tbDireccion.Validating
        'Permite validar que el campo direccion no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese la dirección del cliente por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub tbCelular_Validating(sender As Object, e As CancelEventArgs) Handles tbCelular.Validating
        'Permite validar que el campo celular no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese un numero Celular de referencia por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub cbSexo_Validating(sender As Object, e As CancelEventArgs) Handles cbSexo.Validating
        'Permite validar que se seleccione por lo menos uno de los valores del checkBox Sexo para evitar datos nulos.
        If cbSexo.Text <> "" Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Seleccione el sexo del paciente por favor, Este dato es obligatorio")
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
        If Me.ValidateChildren = True And tbNombres.Text <> "" And tbApellidos.Text <> "" And tbEdad.Text <> "0" And tbCelular.Text <> "" Then
            Try
                'Se crea una nueva instancia de la clase Vcliente
                Dim dts As New vCliente
                'Se crea una nueva instancia de la clase fCliente
                Dim func As New fcliente

                'Se pasan los datos existentes en las cajas de texto a la variable dts a traves de sus getters
                dts.gnombres = tbNombres.Text
                dts.gapellidos = tbApellidos.Text
                dts.gfecha_nacimiento = dtpFechaNacimiento.Value
                dts.gdireccion = tbDireccion.Text
                dts.gcodigo_asegurado = tbCodigoAsegurado.Text
                dts.ginstitucion = tbInstitucion.Text
                dts.grazon_social = tbRazonSocial.Text
                dts.gnit = tbNIT.Text
                dts.gtelefono = tbTelefono.Text
                dts.gcelular = tbCelular.Text
                dts.gsexo = cbSexo.Text
                dts.gci = tbci.Text

                'Se verifica que la funcion insertar devuelva Verdadero, lo cual significa que se registro correctamente.
                If func.insertar(dts) Then
                    'Se muestra un dialogo de informacion, de registro existoso
                    MessageBox.Show("Cliente Registrado Correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    'Se muestra un dialogo de alerta, de registro incorrecto
                    MessageBox.Show("Cliente no Registrado, Intente de Nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Public Function fecha_nacimiento(ByVal fecha As Date) As Integer
        'Calcula la edad restando la fecha actual menos el valor pasado como parametro.
        fecha_nac = DateTime.Now.Date.Year - fecha.Year
        Return fecha_nac
    End Function



    Public Sub limpiar()
        'Limpia lo svalores de las cajas de texto.
        btnGuardar.Visible = True
        btnEditar.Visible = False
        tbNombres.Text = ""
        tbApellidos.Text = ""
        tbEdad.Text = ""
        tbDireccion.Text = ""
        tbTelefono.Text = ""
        tbCelular.Text = ""
        tbCodigoAsegurado.Text = ""
        tbRazonSocial.Text = ""
        tbInstitucion.Text = ""
        tbci.Text = ""
        tbNIT.Text = ""
        cbSexo.Text = ""
        dtpFechaNacimiento.Text = DateTime.Today
    End Sub

    Private Sub tbci_Validating(sender As Object, e As CancelEventArgs) Handles tbci.Validating
        'Permite validar que el campo CI no este vacio
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorIcono.SetError(sender, "")
        Else
            Me.errorIcono.SetError(sender, "Ingrese el numero de carnet del cliente por favor, Este dato es obligatorio")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        'Al presionar el boton cancelar, se limpia la pantalla de datos y se muestran los valores por defecto.
        mostrar()
        limpiar()
    End Sub


    Private Sub dtpFechaNacimiento_Validating(sender As Object, e As CancelEventArgs) Handles dtpFechaNacimiento.Validating
        'Metodo que permite validar que la fecha seleccionada en el selector de fechas sea distinta a la actual.
        'Se crea una variable que almacenara el valor de la edad
        Dim nacimiento As Integer
        'Se verifica que la fecha seleccionada sea diferente a la actual
        If dtpFechaNacimiento.Value.Date <> DateTime.Now.Date Then
            Me.errorIcono.SetError(sender, "")
            'En caso de que sea diferente se asigna la diferencia entre la fecha actual y la fecha seleccionada a la variable nacimiento
            nacimiento = fecha_nacimiento(dtpFechaNacimiento.Value)
            'Se coloca el valor de nacimiento en el campo EDAD
            tbEdad.Text = nacimiento
        Else
            'En caso de que sea igual se muestra el icono de error
            Me.errorIcono.SetError(sender, "Debe seleccionar una fecha distinta a la actual por favor")
            'Se rellena el campo EDAD con el valor 0
            tbEdad.Text = 0
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea editar los datos del cliente?", "Modificando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then

            'Al presionar el boton editar se ejecutan una serie de acciones que permiten crear un nuevo registro en la base de datos.
            'PRIMERO: Se verifica que las cajas de texto imprescindibles no esten vacias, que la fecha no sea la actual y otros.
            If Me.ValidateChildren = True And tbCodigo_Cliente.Text <> "" And tbNombres.Text <> "" And tbApellidos.Text <> "" And tbEdad.Text <> "0" And tbCelular.Text <> "" Then
                Try
                    'Se crea una nueva instancia de la clase Vcliente
                    Dim dts As New vCliente
                    'Se crea una nueva instancia de la clase fCliente
                    Dim func As New fcliente

                    'Se pasan los datos existentes en las cajas de texto a la variable dts a traves de sus getters
                    dts.gid_cliente = tbCodigo_Cliente.Text
                    dts.gnombres = tbNombres.Text
                    dts.gapellidos = tbApellidos.Text
                    dts.gfecha_nacimiento = dtpFechaNacimiento.Value
                    dts.gdireccion = tbDireccion.Text
                    dts.gcodigo_asegurado = tbCodigoAsegurado.Text
                    dts.ginstitucion = tbInstitucion.Text
                    dts.grazon_social = tbRazonSocial.Text
                    dts.gnit = tbNIT.Text
                    dts.gtelefono = tbTelefono.Text
                    dts.gcelular = tbCelular.Text
                    dts.gsexo = cbSexo.Text
                    dts.gci = tbci.Text

                    'Se verifica que la funcion insertar devuelva Verdadero, lo cual significa que se registro correctamente.
                    If func.editar(dts) Then
                        'Se muestra un dialogo de informacion, de registro existoso
                        MessageBox.Show("Cliente Modificado Correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            dgvListadoClientes.Columns.Item("Eliminar").Visible = True
        Else
            dgvListadoClientes.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub dgvListadoClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoClientes.CellContentClick
        If e.ColumnIndex = Me.dgvListadoClientes.Columns.Item("Eliminar").Index Then
            Dim chkcell As DataGridViewCheckBoxCell = Me.dgvListadoClientes.Rows(e.RowIndex).Cells("Eliminar")
            chkcell.Value = Not chkcell.Value
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("Realmente desea eliminar los datos del cliente?", "Eliminando Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dgvListadoClientes.Rows
                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If marcado Then
                        Dim onekey As Integer = Convert.ToInt32(row.Cells("id_cliente").Value)
                        Dim vdb As New vCliente
                        Dim func As New fcliente
                        vdb.gid_cliente = onekey

                        If func.eliminar(vdb) Then
                        Else
                            MessageBox.Show("No se pudo eliminar los datos del cliente?", "Eliminando Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub dgvListadoClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListadoClientes.CellClick
        tbCodigo_Cliente.Text = dgvListadoClientes.SelectedCells.Item(1).Value
        tbNombres.Text = dgvListadoClientes.SelectedCells.Item(2).Value
        tbApellidos.Text = dgvListadoClientes.SelectedCells.Item(3).Value
        tbDireccion.Text = dgvListadoClientes.SelectedCells.Item(5).Value
        tbCelular.Text = dgvListadoClientes.SelectedCells.Item(11).Value
        tbTelefono.Text = dgvListadoClientes.SelectedCells.Item(10).Value
        cbSexo.Text = dgvListadoClientes.SelectedCells.Item(12).Value
        dtpFechaNacimiento.Text = dgvListadoClientes.SelectedCells.Item(4).Value
        tbCodigoAsegurado.Text = dgvListadoClientes.SelectedCells.Item(6).Value
        tbInstitucion.Text = dgvListadoClientes.SelectedCells.Item(7).Value
        tbRazonSocial.Text = dgvListadoClientes.SelectedCells.Item(8).Value
        tbNIT.Text = dgvListadoClientes.SelectedCells.Item(9).Value
        tbci.Text = dgvListadoClientes.SelectedCells.Item(13).Value
        tbEdad.Text = DateTime.Now.Date.Year - Convert.ToDateTime(dgvListadoClientes.SelectedCells.Item(4).Value).Year
        btnGuardar.Visible = False
        btnEditar.Visible = True
    End Sub
End Class