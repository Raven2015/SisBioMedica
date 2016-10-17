Public Class vEstudio
    Dim id_estudio, id_categoria As Integer
    Dim nombre_estudio, codigo_estudio As String
    Dim precio, descuento As Decimal

    Public Property gid_estudio
        Get
            Return id_estudio
        End Get
        Set(value)
            id_estudio = value
        End Set
    End Property

    Public Property gid_categoria
        Get
            Return id_categoria
        End Get
        Set(value)
            id_categoria = value
        End Set
    End Property

    Public Property gnombre_estudio
        Get
            Return nombre_estudio
        End Get
        Set(value)
            nombre_estudio = value
        End Set
    End Property

    Public Property gcodigo_estudio
        Get
            Return codigo_estudio
        End Get
        Set(value)
            codigo_estudio = value
        End Set
    End Property

    Public Property gprecio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property

    Public Property gdescuento
        Get
            Return descuento
        End Get
        Set(value)
            descuento = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_estudio As Integer, ByVal id_categoria As Integer, ByVal nombre_estudio As String, ByVal codigo_estudio As String, ByVal precio As Decimal, ByVal descuento As Decimal, ByVal codigo_categoria As String)
        gid_estudio = id_estudio
        gid_categoria = id_categoria
        gnombre_estudio = nombre_estudio
        gcodigo_estudio = codigo_estudio
        gprecio = precio
        gdescuento = descuento
    End Sub
End Class
