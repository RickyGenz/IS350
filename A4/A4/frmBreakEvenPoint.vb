Public Class frmBreakEvenPoint
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim BreakEvenPoint, FixedCosts, PricePerUnit, CostPerUnit As Double
        FixedCosts = 5000
        PricePerUnit = 8
        CostPerUnit = 6
        BreakEvenPoint = FixedCosts / (PricePerUnit - CostPerUnit)
        lstResult.Items.Add(BreakEvenPoint)
    End Sub
End Class