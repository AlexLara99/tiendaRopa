Public Class actualizarUsuario
    Dim codigoUsuario As Integer
    Private Sub actualizarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim database As New database

        'database.cargarUsuarioAct(menuUsuarios.codigo) ' funcion para devolver un array con los elementos de la base de datos
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    'buscar el usuario que se quiere actualizar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim database As New database
        Dim datos As DataTable


        datos = database.cargarUsuarioAct(nombreUsuario.Text)

        Try
            Dim row As DataRow = datos.Rows(0)

            txtNombre.Text = row(0).ToString
            txtNombre.Enabled = True

            txtApellido.Text = row(1).ToString
            txtApellido.Enabled = True

            txtPass.Text = row(2).ToString
            txtPass.Enabled = True

            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            If row(3) = True Then
                RadioButton1.Checked = True
            Else
                RadioButton2.Checked = True
            End If
            btnUpdate.Enabled = True
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Error: El usuario que has buscado no se encuentra en la base de datos, prueba de nuevo")
        End Try



    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub
End Class