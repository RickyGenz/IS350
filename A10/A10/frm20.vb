Public Class frm20
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim dob As Date = txtDate.Text
        Dim id As Date = "1/20/2017"
        Dim d As Date = CDate(id.AddYears(-35))
        If rdoCYes.Checked And rdoRYes.Checked And d > dob Then
            txtResult.Text = "You are eligible to run for president in 2016."
        Else
            txtResult.Text = "You are not eligible to run for president in 2016."
        End If
    End Sub
End Class