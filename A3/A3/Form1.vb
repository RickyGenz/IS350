Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hello World"
        lblName.ForeColor = Color.Red
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        MsgBox("This displays after button is focused and the Enter key is pressed.")
    End Sub
End Class
