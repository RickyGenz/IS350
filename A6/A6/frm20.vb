Public Class frm20

    Private Sub btnPrintLingo_Click(sender As Object, e As EventArgs) Handles btnPrintLingo.Click
        PrintLingo.Print()
    End Sub

    Private Sub btnPreviewLingo_Click(sender As Object, e As EventArgs) Handles btnPreviewLingo.Click
        PreviewLingo.Document = PrintLingo
        PreviewLingo.ShowDialog()
    End Sub

    Const w As Integer = 100 'Number of points in an inch
    Const h As Integer = 25 'One-quarter of an inch

    Private Sub PrintLingo_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintLingo.PrintPage
        Dim g As Graphics = e.Graphics
        Dim x1 As Integer = w 'Declare first column as standard width [100 points]
        Dim x2 As Integer = w * 2 'Declare second column as double standard width [200 points]
        Dim y As Integer = w 'Declare row at standard height [25 points]
        Dim f As New Font("Arial Black", 12, FontStyle.Underline) 'Declare font styles for heading

        g.DrawString("Lingo", f, Brushes.Black, x1, y) 'Draw "Lingo" in column one at the standard row height [100 points right & 25 points down]
        g.DrawString("Meaning", f, Brushes.Black, x2, y) 'Draw "Meaning" in column two at the standard row height [200 points right & 25 points down]
        y += h

        f = New Font("Arial", 10, FontStyle.Bold) 'Modify font styles for body
        g.DrawString("PLS", f, Brushes.Black, x1, y)
        g.DrawString("Please", f, Brushes.Black, x2, y)
        y += h
        g.DrawString("TAFN", f, Brushes.Black, x1, y)
        g.DrawString("That's all for now", f, Brushes.Black, x2, y)
        y += h
        g.DrawString("HHOK", f, Brushes.Black, x1, y)
        g.DrawString("Ha, ha-only kidding", f, Brushes.Black, x2, y)
        y += h
        g.DrawString("FWIW", f, Brushes.Black, x1, y)
        g.DrawString("For what it's worth", f, Brushes.Black, x2, y)
        y += h
        g.DrawString("IMHO", f, Brushes.Black, x1, y)
        g.DrawString("In my humble opinion", f, Brushes.Black, x2, y)
    End Sub

End Class