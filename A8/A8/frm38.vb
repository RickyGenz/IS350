Public Class frm38
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Income, Tax As Single
        Income = txtIncome.Text
        If Income <= 20000 Then
            Tax = Income * 0.02
        ElseIf Income <= 50000 Then
            Tax = 400 + ((Income - 20000) * 0.025)
        Else
            Tax = 1150 + ((Income - 50000) * 0.035)
        End If
        txtTax.Text = FormatCurrency(Tax)
    End Sub
End Class