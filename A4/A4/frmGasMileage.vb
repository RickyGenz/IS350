Public Class frmGasMileage
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim OdometerBefore, OdometerAfter, Tank, MPG As Double
        OdometerBefore = 23352
        OdometerAfter = 23695
        Tank = 14
        MPG = (OdometerAfter - OdometerBefore) / Tank
        lstResult.Items.Add(MPG)
    End Sub
End Class