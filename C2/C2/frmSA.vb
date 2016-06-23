Public Class frmSA

    Public Function IsInputInvalid() As Boolean
        'Tests if any input is invalid
        Dim Controls = From c In Me.Controls Order By c.TabIndex
        For Each c In Controls
            If c.AccessibleDescription = "Required" Then
                Dim num = CZer(c.Text)
                If IsNegative(num) Then
                    MsgBox(c.AccessibleName & " is not valid. Must be positive.", MsgBoxStyle.Critical, "Error")
                    c.Focus()
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub UtilityButtons(sender As Object, e As EventArgs) Handles btnCCW.Click, btnReturn.Click, btnExit.Click
        'Opens the child care worksheet form, saves the total in a global variable, and then reruns the Calculate sub
        If sender Is btnCCW Then
            frmCCW.ShowDialog()
            txtCCExp.Text = CCWTotal
            Calculate(sender, e)
        End If
        'Returns to the main form
        If sender Is btnReturn Then Close()
        'Ends execution
        If sender Is btnExit Then End
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnCompute.Click
        'Runs invalid input test
        If IsInputInvalid() Then Exit Sub
        'Stores amounts in local variables and formats as currency
        Dim L1 = CZer(txtMDExpenses.Text)
        txtMDExpenses.Text = FormatCurrency(L1)
        Dim L2 = CZer(txtTaxesPaid.Text)
        txtTaxesPaid.Text = FormatCurrency(L2)
        Dim L3 = CZer(txtInterestPaid.Text)
        txtInterestPaid.Text = FormatCurrency(L3)
        Dim L4 = CZer(txtCharity.Text)
        txtCharity.Text = FormatCurrency(L4)
        Dim L5 = CZer(txtLosses.Text)
        txtLosses.Text = FormatCurrency(L5)
        Dim L6 = CZer(txtMiscExp.Text)
        txtMiscExp.Text = FormatCurrency(L6)
        Dim L7 = CZer(txtCCExp.Text)
        txtCCExp.Text = FormatCurrency(L7)
        'Calculates the total, saves in global variable, and then formats as currency
        SATotal = L1 + L2 + L3 + L4 + L5 + L6 + L7
        txtTotal.Text = FormatCurrency(SATotal)
    End Sub

End Class