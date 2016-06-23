Public Class frm12
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim hours, payPerHour, overtimeHours, pay As Double
        InputData(hours, payPerHour)
        CalculateValues(hours, payPerHour, overtimeHours, pay)
        DisplayData(overtimeHours, pay)
    End Sub
    Sub InputData(ByRef hours As Decimal, ByRef payPerHour As Decimal)
        hours = txtHours.Text
        payPerHour = txtPayPerHour.Text
    End Sub
    Sub CalculateValues(ByVal hours As Decimal, ByVal payPerHour As Decimal, ByRef overtimeHours As Decimal, ByRef pay As Decimal)
        If hours > 40 Then overtimeHours = hours - 40 Else overtimeHours = 0
        If overtimeHours = 0 Then pay = hours * payPerHour Else pay = (40 * payPerHour) + (overtimeHours * (payPerHour * 1.5))
    End Sub
    Sub DisplayData(ByVal overtimeHours As Decimal, ByVal pay As Decimal)
        txtOvertimeHours.Text = overtimeHours
        txtPay.Text = FormatCurrency(pay)
    End Sub
End Class