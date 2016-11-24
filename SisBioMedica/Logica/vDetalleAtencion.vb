Public Class vDetalleAtencion
    Dim id_detalle, id_atencion, id_estudio, id_convenio, id_campania As Integer
    Dim precio_parcial, precio_total As Double

    Public Property gid_detalle
        Get
            Return id_detalle
        End Get
        Set(value)
            id_detalle = value
        End Set
    End Property

    Public Property gid_atencion
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value
        End Set
    End Property

    Public Property gid_estudio
        Get
            Return id_estudio
        End Get
        Set(value)
            id_estudio = value
        End Set
    End Property

    Public Property gid_campania
        Get
            Return id_campania
        End Get
        Set(value)
            id_campania = value
        End Set
    End Property

    Public Property gid_convenio
        Get
            Return id_convenio
        End Get
        Set(value)
            id_convenio = value
        End Set
    End Property

    Public Property gprecio_parcial
        Get
            Return precio_parcial
        End Get
        Set(value)
            precio_parcial = value
        End Set
    End Property

    'Public Property gprecio_total
    '    Get
    '        Return precio_total
    '    End Get
    '    Set(value)
    '        precio_total = value
    '    End Set
    'End Property
    '-----COLUMNA ELIMINADA-----


    '-------------- CONSTRUCTORES
    Public Sub New()

    End Sub

    Public Sub New(ByVal id_detalle As Integer,
                   ByVal id_atencion As Integer,
                   ByVal id_estudio As Integer,
                   ByVal id_convenio As Integer,
                   ByVal id_campania As Integer,
                   ByVal precio_parcial As Double,
                   ByVal precio_total As Double)
        gid_detalle = id_detalle
        gid_atencion = id_atencion
        gid_estudio = id_estudio
        gid_convenio = id_convenio
        gid_campania = id_campania
        gprecio_parcial = precio_parcial
        'gprecio_total = precio_total -----COLUMNA ELIMINADA-----
    End Sub

    Public Sub New(ByVal id_detalle As Integer,
                   ByVal id_atencion As Integer,
                   ByVal id_estudio As Integer,
                   ByVal precio_parcial As Double,
                   ByVal precio_total As Double)
        gid_detalle = id_detalle
        gid_atencion = id_atencion
        gid_estudio = id_estudio
        gprecio_parcial = precio_parcial
        'gprecio_total = precio_total -----COLUMNA ELIMINADA-----
    End Sub
End Class
