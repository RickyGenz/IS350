Public Class frmSavingsAccount

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Balance As Double
        Balance = 100
        Balance = Balance * 1.05 + 100
        Balance = Balance * 1.05 + 100
        Balance = Balance * 1.05
        lstResult.Items.Add(FormatCurrency(Balance))
    End Sub
End Class