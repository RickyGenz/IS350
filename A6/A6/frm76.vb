Public Class frm76
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim dob As Date = mtxtDate.Text
        txtOutput.Text = CDate(dob.AddYears(21)).ToString("dddd")
    End Sub
End Class