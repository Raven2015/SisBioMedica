Imports System.Data.SqlClient
Public Class fDetalle
    Inherits conexion 'Hereda todos los ,metodos de la Clase Conexion

    Dim cmd As New SqlCommand 'Variable que permite enviar peticiones a la BD

    Public Function mostrar() As DataTable 'Se usa DataTable ya que es el formato devuelto por SQL
        Try
            conectado() 'Llama a la funcion conectado de la clase Conexion
            cmd = New SqlCommand("mostrar_detalle_atencion") 'Llama al procedimiento almacenado en la BD.
            cmd.CommandType = CommandType.StoredProcedure 'Selecciona el tipo de comando a enviar (Procedimiento Almacenado)

            cmd.Connection = cnn 'Se establece la variable cnn para la conexion de cmd

            If cmd.ExecuteNonQuery Then 'Verifica que la consulta se realize exitosamente
                Dim dt As New DataTable 'Crea una variable que almacena el resultado obtenido de la consulta
                Dim da As New SqlDataAdapter(cmd) 'Crea una variable que permite usar el resultado dentro de la aplicacion
                da.Fill(dt) 'Llena la variable con los datos de la variable resultado (dt)
                Return dt 'Devuelve el resultado de la consulta a la BD
            Else
                Return Nothing 'En caso de que el resultado sea nulo se devuelve NADA
            End If
        Catch ex As Exception
            'En caso de errror se muestra un mensaje con la informacion del error ocurrido
            MsgBox(ex.Message)
            'Se devuelve falso pues no se realizo la conexion
            Return Nothing
        Finally 'Finaliza el proceso
            desconectado() 'Cierra la conexion a la BD
        End Try
    End Function

    Public Function insertar(ByVal dts As vDetalleAtencion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalle_atencion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_atencion", dts.gid_atencion)
            cmd.Parameters.AddWithValue("@id_estudio", dts.gid_estudio)
            'cmd.Parameters.AddWithValue("@id_convenio", dts.gid_convenio)
            'cmd.Parameters.AddWithValue("@gid_campania", dts.gid_campania)
            cmd.Parameters.AddWithValue("@precio_parcial", dts.gprecio_parcial)
            'cmd.Parameters.AddWithValue("@precio_total", dts.gprecio_total) ELIMINADO

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vDetalleAtencion) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_detalle_atencion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            cmd.Parameters.AddWithValue("@id_detalle", dts.gid_detalle)
            cmd.Parameters.AddWithValue("@id_atencion", dts.gid_atencion)
            cmd.Parameters.AddWithValue("@id_estudio", dts.gid_estudio)
            'cmd.Parameters.AddWithValue("@id_convenio", dts.gid_convenio)
            'cmd.Parameters.AddWithValue("@gid_campania", dts.gid_campania)
            cmd.Parameters.AddWithValue("@precio_parcial", dts.gprecio_parcial)
            'cmd.Parameters.AddWithValue("@precio_total", dts.gprecio_total)  ELIMINADO

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vDetalleAtencion)
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle_atencion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.Add("@id_detalle", SqlDbType.NVarChar, 50).Value = dts.gid_detalle
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
