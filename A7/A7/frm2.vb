Public Class frm2
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Variable Declarations
        Dim fmtStr As String = "{0,-10} {1,10}"
        Dim Customer As String
        Dim LaborCost, PartsCost, TotalCost As Single
        'Operations
        lstResults.Items.Clear()
        Customer = txtCustomer.Text
        LaborCost = txtHours.Text * 35
        PartsCost = txtCost.Text * 1.05
        TotalCost = LaborCost + PartsCost
        'Display
        lstResults.Items.Add(String.Format(fmtStr, "Customer", Customer))
        lstResults.Items.Add(String.Format(fmtStr, "Labor Cost", FormatCurrency(LaborCost)))
        lstResults.Items.Add(String.Format(fmtStr, "Parts Cost", FormatCurrency(PartsCost)))
        lstResults.Items.Add(String.Format(fmtStr, "Total Cost", FormatCurrency(TotalCost)))
    End Sub
End Class