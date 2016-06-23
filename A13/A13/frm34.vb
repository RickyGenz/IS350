Public Class frm34
    Sub Tip(Occupation As String, Amount As Decimal, Percentage As Decimal)
        Dim Tip As Decimal = Amount * Percentage / 100
        txtOutput.Text = "Tip the " & Occupation & " " & FormatCurrency(Tip)
    End Sub
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Call Tip(txtOccupation.Text, txtAmount.Text, txtPercentage.Text)
    End Sub
End Class