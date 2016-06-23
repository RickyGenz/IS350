Public Class frm44
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtOutput.Text = IO.File.ReadAllLines("Names.txt").Count
    End Sub
End Class