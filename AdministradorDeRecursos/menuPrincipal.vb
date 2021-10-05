Public Class menuPrincipal
    Private Sub menuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logIn.Visible = False
    End Sub

    Private Sub menuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        logIn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menuUsuarios.Visible = True
        
    End Sub
End Class
