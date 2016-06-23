Public Class frmProfitFromStock
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim PurchasePrice, SellingPrice, PercentProfit As Double
        PurchasePrice = 10
        SellingPrice = 15
        PercentProfit = (SellingPrice - PurchasePrice) / PurchasePrice
        lstResult.Items.Add(FormatPercent(PercentProfit))
    End Sub
End Class