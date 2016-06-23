Public Class frmSC

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
            If c.Name = "txtName" Then
                If IsBlank(c) Then
                    MsgBox(c.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                    c.Focus()
                    Return True
                End If
            ElseIf c.Name = "txtAddress" Then
                If IsBlank(c) Then
                    MsgBox(c.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                    c.Focus()
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub UtilityButtons(sender As Object, e As EventArgs) Handles btnReturn.Click, btnExit.Click
        'Returns to the main form
        If sender Is btnReturn Then Close()
        'Ends execution
        If sender Is btnExit Then End
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Runs invalid input test
        If IsInputInvalid() Then Exit Sub
        'Stores amounts in local variables and formats as currency
        Dim L1 = CZer(txtInvBeg.Text)
        txtInvBeg.Text = FormatCurrency(L1)
        Dim L2 = CZer(txtInvEnd.Text)
        txtInvEnd.Text = FormatCurrency(L2)
        Dim L3 = L1 - L2
        If L3 < 0 Then L3 = 0
        txtCOGS.Text = FormatCurrency(L3)
        Dim L4 = CZer(txtSales.Text)
        txtSales.Text = FormatCurrency(L4)
        txtCOGS5.Text = FormatCurrency(L3)
        Dim L6 = L4 - L3
        txtGrossIncome.Text = FormatCurrency(L6)
        Dim L7a = CZer(txtAdvertising.Text)
        txtAdvertising.Text = FormatCurrency(L7a)
        Dim L7b = CZer(txtCommissions.Text)
        txtCommissions.Text = FormatCurrency(L7b)
        Dim L7c = CZer(txtMortgage.Text)
        txtMortgage.Text = FormatCurrency(L7c)
        Dim L7d = CZer(txtOffice.Text)
        txtOffice.Text = FormatCurrency(L7d)
        Dim L8 = L7a + L7b + L7c + L7d
        txtTotal.Text = FormatCurrency(L8)
        'Calculates the total, saves in global variable, and then formats as currency
        SCTotal = L6 - L8
        txtNetProfit.Text = FormatCurrency(SCTotal)
    End Sub

End Class