Public Class frmTER
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintTER.Print()
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        PreviewTER.Document = PrintTER
        PreviewTER.ShowDialog()
    End Sub

    Private Sub PrintTER_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintTER.PrintPage
        'Declaring and setting operational variables
        Dim meals As Single = txtMeals.Text
        Dim airplane As Single = txtAirplane.Text
        Dim lodging As Single = txtLodging.Text
        Dim taxi As Single = txtTaxi.Text
        Dim otherTotal As Single = airplane + lodging + taxi
        Dim percentTotal As Single = txtMeals.Text * 0.5
        Dim total As Single = otherTotal + percentTotal
        'Declaring and setting printing variables
        Dim g As Graphics = e.Graphics
        Dim x0 As Single = 50
        Dim x1 As Single = 250
        Dim x2 As Single = 350
        Dim y0 As Single = 50
        Dim y1 As Single = 25
        Dim y2 As Single = 50
        Dim y3 As Single = 5
        Dim h As New Font("Arial Black", 12, FontStyle.Underline)
        Dim b As New Font("Arial", 10, FontStyle.Bold)
        'Drawing the heading
        g.DrawString("Business Travel Expenses", h, Brushes.Black, x0, y0)
        y0 += y2
        'Drawing the trip details
        g.DrawString("Trip to attend meeting of", b, Brushes.Black, x0, y0)
        y0 += y1
        g.DrawString(txtOrganization.Text, b, Brushes.Black, x0, y0)
        y0 += y1
        g.DrawString(txtDates.Text & " in " & txtLocation.Text, b, Brushes.Black, x0, y0)
        y0 += y2
        'Drawing the expenses
        g.DrawString(lblMeals.Text, b, Brushes.Black, x0, y0)
        g.DrawString(FormatCurrency(meals), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblAirplane.Text, b, Brushes.Black, x0, y0)
        g.DrawString(FormatCurrency(airplane), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblLodging.Text, b, Brushes.Black, x0, y0)
        g.DrawString(FormatCurrency(lodging), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblTaxi.Text, b, Brushes.Black, x0, y0)
        g.DrawString(FormatCurrency(taxi), b, Brushes.Black, x1, y0)
        y0 += y2
        'Drawing the calculations
        g.DrawString("Total other than meals and entertainment:", b, Brushes.Black, x0, y0)
        g.DrawString(FormatCurrency(otherTotal), b, Brushes.Black, x2, y0)
        y0 += y1
        g.DrawString("50% of meals and entertainment:", b, Brushes.Black, x0, y0)
        g.DrawString(FormatCurrency(percentTotal), b, Brushes.Black, x2, y0)
        y0 += y2
        g.DrawString("TOTAL DEDUCTIBLE EXPENSES:", b, Brushes.Black, x0, y0)
        g.DrawString(FormatCurrency(total), b, Brushes.Black, x2, y0)
    End Sub
End Class