Public Class frmIncome

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
        'Returns to the previous form
        If sender Is btnReturn Then Close()
        'Ends execution
        If sender Is btnExit Then End
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnCompute.Click
        'Runs invalid input test
        If IsInputInvalid() Then Exit Sub
        'Stores amounts in local variables and formats totals as currency for your income
        Dim YHours = CZer(txtYHours.Text)
        txtYHours.Text = YHours
        Dim YRate = CZer(txtYRate.Text)
        txtYRate.Text = YRate
        Dim YOHours As Integer
        If YHours > 40 Then YOHours = YHours - 40 Else YOHours = 0
        Dim L1 As Decimal
        If YOHours = 0 Then L1 = YHours * YRate Else L1 = (40 * YRate) + (YOHours * (YRate * 1.5))
        txtYWages.Text = FormatCurrency(L1)
        Dim L2 = CZer(txtYSalary.Text)
        txtYSalary.Text = FormatCurrency(L2)
        Dim L3 = CZer(txtYTips.Text)
        txtYTips.Text = FormatCurrency(L3)
        Dim L4 = CZer(txtYEtc.Text)
        txtYEtc.Text = FormatCurrency(L4)
        Dim L5 = L1 + L2 + L3 + L4
        txtYIncome.Text = FormatCurrency(L5)
        'Stores amounts in local variables and formats totals as currency for spouse income
        Dim SHours = CZer(txtSHours.Text)
        txtSHours.Text = SHours
        Dim SRate = CZer(txtSRate.Text)
        txtSRate.Text = SRate
        Dim SOHours As Integer
        If SHours > 40 Then SOHours = SHours - 40 Else SOHours = 0
        Dim L6 As Decimal
        If SOHours = 0 Then L6 = SHours * SRate Else L6 = (40 * SRate) + (SOHours * (SRate * 1.5))
        txtSWages.Text = FormatCurrency(L6)
        Dim L7 = CZer(txtSSalary.Text)
        txtSSalary.Text = FormatCurrency(L7)
        Dim L8 = CZer(txtSTips.Text)
        txtSTips.Text = FormatCurrency(L8)
        Dim L9 = CZer(txtSEtc.Text)
        txtSEtc.Text = FormatCurrency(L9)
        Dim L10 = L6 + L7 + L8 + L9
        txtSIncome.Text = FormatCurrency(L10)
        'Calculates the total or your and spouse income, saves in global variable, and then formats as currency
        Income = L5 + L10
        txtIncome.Text = FormatCurrency(Income)
    End Sub

End Class