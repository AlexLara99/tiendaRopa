Public Class usuarios
    Dim codigoUsuario As Integer
    Dim nombreUsuario As String
    Dim nombre As String
    Dim apellidos As String
    Dim password As String
    Dim activo As Boolean
    Dim database As New database


    Sub crearUsuarios(nombreUsuario As String, nombre As String, apellidos As String, password As String)

        'aqui codigo de base de datos de crear usuario
        Me.nombreUsuario = nombreUsuario
        Me.nombre = nombre
        Me.apellidos = apellidos
        Me.password = password
        database.crearUsuarios(nombreUsuario, nombre, apellidos, password)

    End Sub

    Function ponerCodigoUsuario()

        Dim codigo As Integer
        ' aqui hacer select de todos los usuarios y poner el ultimo numero
        Return codigo

    End Function

    Sub actualizarUsuario()
        ' aqui codigo de actualizasion de usuario
    End Sub
End Class
