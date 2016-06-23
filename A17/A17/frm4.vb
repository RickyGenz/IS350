Public Class frm4
    Private Sub btnSL_Click(sender As Object, e As EventArgs) Handles btnSL.Click
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Description: " & txtItem.Text)
        Dim Year As Decimal = CDec(txtYear.Text)
        lstOutput.Items.Add("Year of purchase: " & Year)
        Dim Cost As Decimal = CDec(txtCost.Text)
        lstOutput.Items.Add("Cost: " & FormatCurrency(Cost))
        Dim Years As Decimal = CDec(txtYears.Text)
        lstOutput.Items.Add("Estimated life: " & Years)
        lstOutput.Items.Add("Method: straight-line")
        Dim Dep As Decimal = (1 / Years) * Cost
        Dim TDep As Decimal = 0
        Years = Year + Years - 1
        For i As Integer = Year To Years Step 1
            lstOutput.Items.Add("")
            lstOutput.Items.Add("Value at beginning of " & i & ": " & FormatCurrency(Cost))
            Cost -= Dep
            lstOutput.Items.Add("Amount of depreciation during " & i & ": " & FormatCurrency(Dep))
            TDep += Dep
            lstOutput.Items.Add("Total depreciation at end of " & i & ": " & FormatCurrency(TDep))
        Next
    End Sub
    Private Sub btnDDB_Click(sender As Object, e As EventArgs) Handles btnDDB.Click
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Description: " & txtItem.Text)
        Dim Year As Decimal = CDec(txtYear.Text)
        lstOutput.Items.Add("Year of purchase: " & Year)
        Dim Cost As Decimal = CDec(txtCost.Text)
        lstOutput.Items.Add("Cost: " & FormatCurrency(Cost))
        Dim Years As Decimal = CDec(txtYears.Text)
        lstOutput.Items.Add("Estimated life: " & Years)
        lstOutput.Items.Add("Method: double-declining-balance")
        Dim Dep As Decimal = 0
        Dim TDep As Decimal = 0
        Dim TYears = Year + Years - 1
        For i As Integer = Year To TYears Step 1
            lstOutput.Items.Add("")
            Dep = (2 / Years) * Cost
            If i = TYears Then Dep = Cost
            lstOutput.Items.Add("Value at beginning of " & i & ": " & FormatCurrency(Cost))
            Cost -= Dep
            lstOutput.Items.Add("Amount of depreciation during " & i & ": " & FormatCurrency(Dep))
            TDep += Dep
            lstOutput.Items.Add("Total depreciation at end of " & i & ": " & FormatCurrency(TDep))
        Next
    End Sub
End Class