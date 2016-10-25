Public Class vAtencion
    Dim id_atencion, id_cliente As Integer
    Dim fecha As Date
    Dim doctor_remitente, tipo_documento, num_documento, descripcion As String
    Public Property gid_atencion
        Get
            Return id_atencion
        End Get
        Set(value)
            id_atencion = value
        End Set
    End Property

    Public Property gid_cliente
        Get
            Return id_cliente
        End Get
        Set(value)
            id_cliente = value
        End Set
    End Property

    Public Property gfecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property

    Public Property gtipo_documento
        Get
            Return tipo_documento
        End Get
        Set(value)
            tipo_documento = value
        End Set
    End Property

    Public Property gnumero_documento
        Get
            Return num_documento
        End Get
        Set(value)
            num_documento = value
        End Set
    End Property

    Public Property gdoctor_remitente
        Get
            Return doctor_remitente
        End Get
        Set(value)
            doctor_remitente = value
        End Set
    End Property

    Public Property gdescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property


    '------------------ CONSTRUCTORES DE LA CLASE
    Public Sub New()

    End Sub

    Public Sub New(
                  ByVal id_atencion As Integer,
                  ByVal id_cliente As Integer,
                  ByVal fecha As Date,
                  ByVal doctor_remitente As String,
                  ByVal tipo_documento As String,
                  ByVal numero_documento As String,
                  ByVal descripcion As String)
        gid_atencion = id_atencion
        gid_cliente = id_cliente
        gfecha = fecha
        gdoctor_remitente = doctor_remitente
        gtipo_documento = tipo_documento
        gnumero_documento = numero_documento
        gdescripcion = descripcion
    End Sub

End Class
