Public Class frmSB

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
        Dim L1a = CZer(txtInterestAmountOne.Text)
        txtInterestAmountOne.Text = FormatCurrency(L1a)
        Dim L1b = CZer(txtInterestAmountTwo.Text)
        txtInterestAmountTwo.Text = FormatCurrency(L1b)
        Dim L1c = L1a + L1b
        txtInterestSubtotal.Text = FormatCurrency(L1c)
        Dim L1d = CZer(txtInterestExcludable.Text)
        txtInterestExcludable.Text = FormatCurrency(L1d)
        'Calculates the total, saves in global variable, and then formats as currency
        IITotal = L1c - L1d
        txtInterestTotal.Text = FormatCurrency(IITotal)
        'Stores amounts in local variables and formats as currency
        Dim L3a = CZer(txtDividendAmountOne.Text)
        txtDividendAmountOne.Text = FormatCurrency(L3a)
        Dim L3b = CZer(txtDividendAmountTwo.Text)
        txtDividendAmountTwo.Text = FormatCurrency(L3b)
        'Calculates the total, saves in global variable, and then formats as currency
        DITotal = L3a + L3b
        txtDividendTotal.Text = FormatCurrency(DITotal)
    End Sub

End Class