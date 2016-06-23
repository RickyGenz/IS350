Public Class frm24
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim Rate As Decimal = 1.005
        Dim Balance As Decimal = txtDeposit.Text
        lstBalance.Items.Add("Month 1: " & FormatCurrency(Balance))
        Balance = Rate * Balance + CDec(txtDeposit.Text)
        lstBalance.Items.Add("Month 2: " & FormatCurrency(Balance))
        Balance = Rate * Balance + CDec(txtDeposit.Text)
        lstBalance.Items.Add("Month 3: " & FormatCurrency(Balance))
        Balance = Rate * Balance + CDec(txtDeposit.Text)
        lstBalance.Items.Add("Month 4: " & FormatCurrency(Balance))
    End Sub
End Class