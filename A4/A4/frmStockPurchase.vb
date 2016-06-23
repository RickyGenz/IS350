Public Class frmStockPurchase
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Amount, CostPerShare, NumberOfShares As Double
        CostPerShare = 25.625
        NumberOfShares = 400
        Amount = CostPerShare * NumberOfShares
        lstResult.Items.Add(Amount)
    End Sub
End Class