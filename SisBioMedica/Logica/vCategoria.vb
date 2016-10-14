Public Class vCategoria
    Dim id_categoria As String
    Dim nombre_categoria As String
    Dim codigo_categoria As String

    Public Property gid_categoria
        Get
            Return id_categoria
        End Get
        Set(value)
            id_categoria = value
        End Set
    End Property

    Public Property gnombre_categoria
        Get
            Return nombre_categoria
        End Get
        Set(value)
            nombre_categoria = value
        End Set
    End Property

    Public Property gcodigo_categoria
        Get
            Return codigo_categoria
        End Get
        Set(value)
            codigo_categoria = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_categoria As String, ByVal nombre_categoria As String)
        gid_categoria = id_categoria
        gnombre_categoria = nombre_categoria
        gcodigo_categoria = codigo_categoria

    End Sub
End Class
