Public Class frm10
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim oldBalance, charges, credits, newBalance, minPayment As Double
        InputData(oldBalance, charges, credits)
        CalculateNewValues(oldBalance, charges, credits, newBalance, minPayment)
        DisplayData(newBalance, minPayment)
    End Sub
    Sub InputData(ByRef oldBalance As Decimal, ByRef charges As Decimal, ByRef credits As Decimal)
        oldBalance = txtOldBalance.Text
        charges = txtCharges.Text
        credits = txtCredits.Text
    End Sub
    Sub CalculateNewValues(ByVal oldBalance As Decimal, ByVal charges As Decimal, ByVal credits As Decimal, ByRef newBalance As Decimal, ByRef minPayment As Decimal)
        newBalance = oldBalance + charges - credits + (oldBalance * 0.015)
        If newBalance < 20 Then minPayment = newBalance Else minPayment = 20 + ((newBalance - 20) * 0.1)
    End Sub
    Sub DisplayData(ByVal newBalance As Decimal, ByVal minPayment As Decimal)
        txtNewBalance.Text = FormatCurrency(newBalance)
        txtMinPayment.Text = FormatCurrency(minPayment)
    End Sub
End Class