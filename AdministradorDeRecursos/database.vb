Imports MySql.Data.MySqlClient

Public Class database
    Dim cs As String = "server=localhost;Database=tienda;user id=root;" 'tengo que poner los datos de la base de datos
    Dim conn As New MySqlConnection(cs)


    'consulta si el admin del se logea o no
    Function consultaLogin(nombre As String, password As String)

        Dim sql As String = "SELECT nombreUsuario, password FROM usuarios WHERE nombreUsuario = 'admin' "

        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            reader.Read()
            If (nombre = reader("nombreUsuario").ToString() And password = reader("password").ToString()) Then
                Return True
            Else
                Return False
            End If

            conn.Close()

        Catch ex As Exception

            MsgBox(ex.ToString())
            Return False

        End Try


    End Function
    ' ////////////////////////// CONSULTAS USUARIOS //////////////////////////////////////

    Function verUsuarios()
        Dim sql As String = "SELECT idUsuarios, nombreUsuario, nombre, apellido, activo FROM usuarios WHERE idUsuarios > 1"
        Dim myData As New DataTable
        Dim myAdapter As New MySqlDataAdapter
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            myAdapter.SelectCommand = cmd
            myAdapter.Fill(myData)
            conn.Close()
            Return myData

            'Dim reader As MySqlDataReader = cmd.ExecuteReader()

        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
            Return False
        End Try


    End Function

    Function crearIdUsuario()

        Dim sql As String = "SELECT * FROM usuarios"
        Dim count As Integer = 1
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(Sql, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()


            While reader.Read()
                count = count + 1

            End While
            conn.Close()
            Return count
        Catch ex As Exception
            'si devuelve 0 esque ha habido un error
            MsgBox(ex.ToString())
            Return 0
        End Try



    End Function

    Function noRepetirNombre(nombreUsuario As String)
        Dim sql As String = "SELECT nombreUsuario FROM usuarios WHERE nombreUsuario = '" + nombreUsuario + "'"
        Dim noRepetido As Boolean = True
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            'si entra en el while esque hay un nombre repetido
            While reader.Read()
                noRepetido = False

            End While
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Return noRepetido

    End Function

    Sub crearUsuarios(nombreUsuario As String, nombre As String, apellidos As String, password As String)

        'para que no se repita el nombre de logeo
        If (noRepetirNombre(nombreUsuario)) Then
            'aqui se genera el id del usuario
            Dim codigo As Integer = crearIdUsuario()

            Dim sql As String = "INSERT INTO usuarios (idUsuarios,nombreUsuario,nombre,apellido,password,activo) VALUES (@idUsuarios,@nombreUsuario,@nombre,@apellido,@password,@activo)"
            Try
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                'se colocan los valores del formulario
                cmd.Parameters.AddWithValue("@idUsuarios", codigo)
                cmd.Parameters.AddWithValue("@nombreUsuario", nombreUsuario)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@apellido", apellidos)
                cmd.Parameters.AddWithValue("@password", password)
                cmd.Parameters.AddWithValue("@activo", 1)
                'se ejecuta el query
                cmd.ExecuteNonQuery()

                conn.Close()

                MsgBox("Se ha creado el usuario")
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            ' si el nombre esta repetido
            MsgBox("Usuario repetido, cambie de nombre porfavor")
        End If



    End Sub
    ' devolvera un arraylist con los datos del usuario seleccioando
    Function cargarUsuarioAct(codigo As Integer)


    End Function

    Sub desactivarUsuario(idUsuario As Integer)

    End Sub
End Class
