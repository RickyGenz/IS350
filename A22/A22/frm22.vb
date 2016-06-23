Public Class frm22
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sr As IO.StreamReader = IO.File.OpenText("Order.txt")
        Dim Order(4) As String
        For I As Integer = 0 To 4
            Order(I) = sr.ReadLine
        Next
        sr = IO.File.OpenText("Cowboy.txt")
        Dim Items() As String
        Dim Total As Decimal = 0
        For I As Integer = 0 To 4
            Items = sr.ReadLine.Split(",")
            Dim fmt As String = "{0,-2} {1,-20} {2,8:c2}"
            lstReceipt.Items.Add(String.Format(fmt, Order(I), Items(0), Items(1)))
            Total += Order(I) * Items(1)
        Next
        lstReceipt.Items.Add("TOTAL  " & FormatCurrency(Total))
    End Sub
End Class