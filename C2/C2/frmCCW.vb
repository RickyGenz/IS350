Public Class frmCCW

    Private Sub UtilityButtons(sender As Object, e As EventArgs) Handles btnReturn.Click, btnExit.Click
        'Returns to Schedule A
        If sender Is btnReturn Then Close()
        'Ends execution
        If sender Is btnExit Then End
    End Sub

    Private Sub PayeeOne(sender As Object, e As EventArgs) Handles lblPayeeOne.Click
        'Populates Payee One information on Payee One label click
        Dim PayeeOneName = InputBox("Please enter the name of the first payee.", "Name of Payee One")
        Dim PayeeOneSSN = InputBox("Please enter the social security number of the first payee.", "SSN of Payee One")
        lblPayeeOneName.Text = PayeeOneName
        lblPayeeOneSSN.Text = PayeeOneSSN
    End Sub

    Private Sub PayeeTwo(sender As Object, e As EventArgs) Handles lblPayeeTwo.Click
        'Populates Payee Two information on Payee Two label click
        Dim PayeeTwoName = InputBox("Please enter the name of the second payee.", "Name of Payee Two")
        Dim PayeeTwoSSN = InputBox("Please enter the social security number of the second payee.", "SSN of Payee Two")
        lblPayeeTwoName.Text = PayeeTwoName
        lblPayeeTwoSSN.Text = PayeeTwoSSN
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Runs invalid SSN test if Payee One or Payee Two has information present
        Dim b As Boolean = False
        If IsBlank(lblPayeeOneName) = False Then Call IsInvalidSSN(lblPayeeOneSSN, b)
        If b Then Exit Sub
        If IsBlank(lblPayeeTwoName) = False Then Call IsInvalidSSN(lblPayeeTwoSSN, b)
        If b Then Exit Sub
        'Stores amounts in local variables and formats as currency
        Dim L1 = CZer(txtPayeeOnePaid.Text)
        txtPayeeOnePaid.Text = FormatCurrency(L1)
        Dim L2 = CZer(txtPayeeTwoPaid.Text)
        txtPayeeTwoPaid.Text = FormatCurrency(L2)
        Dim L3 = L1 + L2
        txtTotalPaid.Text = FormatCurrency(L3)
        Dim L4 = CZer(txtExpFour.Text)
        txtExpFour.Text = FormatCurrency(L4)
        Dim L5 = CZer(txtExpFive.Text)
        txtExpFive.Text = FormatCurrency(L5)
        Dim L6 = L4 + L5
        txtExpSum.Text = FormatCurrency(L6)
        'Tests both subtotals to see which is smaller
        Dim L7
        If L3 < L6 Then L7 = L3 Else L7 = L6
        txtSmaller.Text = FormatCurrency(L7)
        'Stores the selected percentage in a local variable
        Dim L8 = 0.0
        If rdo30.Checked Then L8 = 0.3
        If rdo27.Checked Then L8 = 0.27
        If rdo22.Checked Then L8 = 0.22
        If rdo20.Checked Then L8 = 0.2
        If rdo18.Checked Then L8 = 0.18
        txtPercentage.Text = FormatPercent(L8)
        'Calculates the total, saves in global variable, and then formats as currency
        CCWTotal = L8 * L7
        txtCCExp.Text = FormatCurrency(CCWTotal)
    End Sub

End Class