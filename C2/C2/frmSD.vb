Public Class frmSD

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
        Dim STP1 = CZer(txtSTPriceOne.Text)
        txtSTPriceOne.Text = FormatCurrency(STP1)
        Dim STC1 = CZer(txtSTCostOne.Text)
        txtSTCostOne.Text = FormatCurrency(STC1)
        Dim STGL1 = STP1 - STC1
        txtSTGLOne.Text = FormatCurrency(STGL1)
        Dim STP2 = CZer(txtSTPriceTwo.Text)
        txtSTPriceTwo.Text = FormatCurrency(STP2)
        Dim STC2 = CZer(txtSTCostTwo.Text)
        txtSTCostTwo.Text = FormatCurrency(STC2)
        Dim STGL2 = STP2 - STC2
        txtSTGLTwo.Text = FormatCurrency(STGL2)
        'Calculates the total, saves in global variable, and then formats as currency
        Dim STGL = STGL1 + STGL2
        txtSTNetGL.Text = FormatCurrency(STGL)
        Dim STCO = CZer(txtSTCarryOver.Text)
        txtSTCarryOver.Text = FormatCurrency(STCO)
        STTotal = STGL - STCO
        txtNetSTGL.Text = FormatCurrency(STTotal)
        'Stores amounts in local variables and formats as currency
        Dim LTP1 = CZer(txtLTPriceOne.Text)
        txtLTPriceOne.Text = FormatCurrency(LTP1)
        Dim LTC1 = CZer(txtLTCostOne.Text)
        txtLTCostOne.Text = FormatCurrency(LTC1)
        Dim LTGL1 = LTP1 - LTC1
        txtLTGLOne.Text = FormatCurrency(LTGL1)
        Dim LTP2 = CZer(txtLTPriceTwo.Text)
        txtLTPriceTwo.Text = FormatCurrency(LTP2)
        Dim LTC2 = CZer(txtLTCostTwo.Text)
        txtLTCostTwo.Text = FormatCurrency(LTC2)
        Dim LTGL2 = LTP2 - LTC2
        txtLTGLTwo.Text = FormatCurrency(LTGL2)
        'Calculates the total, saves in global variable, and then formats as currency
        Dim LTGL = LTGL1 + LTGL2
        txtLTNetGL.Text = FormatCurrency(LTGL)
        Dim LTCO = CZer(txtLTCarryOver.Text)
        txtLTCarryOver.Text = FormatCurrency(LTCO)
        LTTotal = LTGL - LTCO
        txtNetLTGL.Text = FormatCurrency(LTTotal)
        LTTotal = LTTotal / 2
    End Sub

End Class