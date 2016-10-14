Imports System.Data.SqlClient
Public Class conexion

    Protected cnn As New SqlConnection 'Variable que recibe la conexion mediante @SqlConnection

    Public id_usuario As Integer 'Id_usuario que se envia a la BD para realizar la conexion

    Protected Function conectado()
        Try
            'Se crea la conexion a la base de datos dando una direccion inicial y los parametros.
            cnn = New SqlConnection("data source=RAVEN\SQLEXPRESS; initial catalog=dbBio;integrated security=true")
            'Se abre la conexion
            cnn.Open()
            'Se devuelve verdadero, se realizo la conexion
            Return True
        Catch ex As Exception
            'En caso de errror se muestra un mensaje con la informacion del error ocurrido
            MsgBox(ex.Message)
            'Se devuelve falso pues no se realizo la conexion
            Return False
        End Try
    End Function


    Protected Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                'Verificamos si la conexion esta abierta y si esta la cerramos.
                cnn.Close()
                Return True
            Else
                'Devuelve falso porque la conexion ya esta cerrada
                Return False
            End If
        Catch ex As Exception
            'En caso de errror se muestra un mensaje con la informacion del error ocurrido
            MsgBox(ex.Message)
            'Se devuelve falso pues no se realizo la conexion
            Return False
        End Try
    End Function
End Class
