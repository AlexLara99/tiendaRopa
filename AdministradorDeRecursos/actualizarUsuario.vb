Public Class actualizarUsuario
    Dim codigoUsuario As Integer
    Private Sub actualizarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim database As New database

        database.cargarUsuarioAct(menuUsuarios.codigo) ' funcion para devolver un array con los elementos de la base de datos
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class