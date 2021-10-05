Public Class login
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        inicioSesion()
    End Sub

    Private Sub inicioSesion()
        'para trabajar con la clase de base de datos
        Dim database As New database


        If (database.consultaLogin(txtNombre.Text, txtPass.Text)) Then
            menuPrincipal.Visible = True
        Else
            lblError.Visible = True
        End If


    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress

        If (e.KeyChar = ChrW(Keys.Return)) Then
            inicioSesion()
        End If

    End Sub
End Class