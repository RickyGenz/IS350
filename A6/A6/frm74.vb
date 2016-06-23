Public Class frm74
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        txtOutput.Text = CDate(mtxtDate.Text).ToString("dddd")
    End Sub
End Class