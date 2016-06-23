Public Class frmLight

    Private Sub txtGreen_GotFocus(sender As Object, e As EventArgs) Handles txtGreen.GotFocus
        txtRed.BackColor = Color.DarkGray
        txtGreen.BackColor = Color.Green
    End Sub

    Private Sub txtYellow_GotFocus(sender As Object, e As EventArgs) Handles txtYellow.GotFocus
        txtGreen.BackColor = Color.DarkGray
        txtYellow.BackColor = Color.Yellow
    End Sub

    Private Sub txtRed_GotFocus(sender As Object, e As EventArgs) Handles txtRed.GotFocus
        txtYellow.BackColor = Color.DarkGray
        txtRed.BackColor = Color.Red
    End Sub
End Class