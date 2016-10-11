Public Class vCliente
    'Se declara cada campo de la clase cliente
    Dim id_cliente As Integer
    Dim nombres As String
    Dim apellidos As String
    Dim fecha_nacimiento As Date
    Dim direccion As String
    Dim codigo_asegurado As String
    Dim institucion As String
    Dim razon_social As String
    Dim nit As String
    Dim telefono As String
    Dim celular As String
    Dim sexo As String
    Dim ci As String

    'Se crean los metodos Set y Get

    Public Property gid_cliente
        Get
            Return id_cliente
        End Get
        Set(value)
            id_cliente = value
        End Set
    End Property

    Public Property gnombres
        Get
            Return nombres
        End Get
        Set(value)
            nombres = value
        End Set
    End Property

    Public Property gapellidos
        Get
            Return apellidos
        End Get
        Set(value)
            apellidos = value
        End Set
    End Property

    Public Property gfecha_nacimiento
        Get
            Return fecha_nacimiento
        End Get
        Set(value)
            fecha_nacimiento = value
        End Set
    End Property

    Public Property gdireccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property gcodigo_asegurado
        Get
            Return codigo_asegurado
        End Get
        Set(value)
            codigo_asegurado = value
        End Set
    End Property

    Public Property ginstitucion
        Get
            Return institucion
        End Get
        Set(value)
            institucion = value
        End Set
    End Property

    Public Property grazon_social
        Get
            Return razon_social
        End Get
        Set(value)
            razon_social = value
        End Set
    End Property

    Public Property gnit
        Get
            Return nit
        End Get
        Set(value)
            nit = value
        End Set
    End Property

    Public Property gtelefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property

    Public Property gcelular
        Get
            Return celular
        End Get
        Set(value)
            celular = value
        End Set
    End Property

    Public Property gsexo
        Get
            Return sexo
        End Get
        Set(value)
            sexo = value
        End Set
    End Property

    Public Property gci
        Get
            Return ci
        End Get
        Set(value)
            ci = value
        End Set
    End Property

    'Creacion de los constructores

    Public Sub New()

    End Sub

    Public Sub New(ByVal id_cliente As Integer, ByVal nombres As String, ByVal apellidos As String, ByVal fecha_nacimento As Date, ByVal direccion As String, ByVal codigo_asegurado As String, ByVal institucion As String, ByVal razon_social As String, ByVal nit As String, ByVal telefono As String, ByVal celular As String, ByVal sexo As String, ByVal ci As String)
        gid_cliente = id_cliente
        gnombres = nombres
        gapellidos = apellidos
        gfecha_nacimiento = fecha_nacimento
        gdireccion = direccion
        gcodigo_asegurado = codigo_asegurado
        ginstitucion = institucion
        grazon_social = razon_social
        gnit = nit
        gtelefono = telefono
        gcelular = celular
        gsexo = sexo
        gci = ci
    End Sub
End Class
