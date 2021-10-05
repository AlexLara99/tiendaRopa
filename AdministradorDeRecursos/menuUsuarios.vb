
Public Class menuUsuarios
    Public codigo As Integer
    Private Sub menuUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim database As New database
        listaUsuarios.DataSource = database.verUsuarios()


    End Sub

    Private Sub menuUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Me.Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        crearUsuario.Visible = True
    End Sub
    'proceso de hacer
    Private Sub btnDesactivar_Click(sender As Object, e As EventArgs) Handles btnDesactivar.Click

        Dim database As database
        Dim answer As Integer

        answer = MsgBox("¿Deseas activar/desactivar a este usuario?", vbQuestion + vbYesNo + vbDefaultButton2, "Aviso")
        If answer = vbYes Then
            'MsgBox(listaUsuarios.sele)
            'database.desactivarUsuario(listaUsuarios.SelectedCells.ToString)
        Else

        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        actualizarUsuario.Visible = True

    End Sub
End Class