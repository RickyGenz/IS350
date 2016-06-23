Public Class frmAdd
    Private Sub btnMonogram_Click(sender As Object, e As EventArgs) Handles btnMonogram.Click
        'Show monogram form.
        frmMono.ShowDialog()
        txtBoxMono.Text = FormatCurrency(monogrammingsum)
    End Sub
    Private Sub btnTelegram_Click(sender As Object, e As EventArgs) Handles btnTelegram.Click
        'Show telegram form.
        frmTele.ShowDialog()
        txtBoxTele.Text = FormatCurrency(telegramssum)
    End Sub
    Private Sub btnWrapping_Click(sender As Object, e As EventArgs) Handles btnWrapping.Click
        'Show wrapping form.
        frmWrap.ShowDialog()
        txtBoxWrap.Text = FormatCurrency(wrappingsum)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all fields.
        txtBoxMono.Clear()
        txtBoxTele.Clear()
        txtBoxWrap.Clear()
        txtBoxTotalCost.Clear()
    End Sub
    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        'Compute the total shipping costs and format as currency.
        TotalAdditionalCharges = monogrammingsum + telegramssum + wrappingsum
        txtBoxTotalCost.Text = FormatCurrency(TotalAdditionalCharges)
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Save additional charges as a global variable and then close.
        TotalAdditionalCharges = Math.Round(TotalAdditionalCharges, 2)
        Me.Close()
    End Sub
End Class