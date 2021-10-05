Public Class crearUsuario


    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim usuarios As New usuarios
        usuarios.crearUsuarios(txtUsuario.Text, txtNombre.Text, txtApellido.Text, txtPass.Text)



    End Sub
End Class