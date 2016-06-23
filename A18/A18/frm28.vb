Public Class frm28
    Dim lakeAreas() As Integer = {23000, 8000, 22000, 10000, 32000}
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        txtA.Text = lakeAreas.Max
        txtB.Text = lakeAreas.Min
        txtC.Text = lakeAreas.First
        txtD.Text = lakeAreas.Last
        txtE.Text = lakeAreas.Count
        txtF.Text = lakeAreas.Sum
        txtG.Text = lakeAreas.Average
        txtH.Text = lakeAreas(2)
        txtI.Text = Array.IndexOf(lakeAreas, 8000)
    End Sub
End Class