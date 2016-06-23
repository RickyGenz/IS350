Public Class frmAnalyzeNumbers

    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim n As Integer
        n = txtPhone.Text.IndexOf(".")
        txtLeft.Text = txtPhone.Text.Substring(0, n).Length()
        txtRight.Text = txtPhone.Text.Substring(n + 1).Length()
    End Sub

End Class