Public Class frm30
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Balance, Withdrawal As Single
        Balance = txtBalance.Text
        Withdrawal = txtWithdrawal.Text
        If Withdrawal > Balance Then
            txtOutput.Clear()
            MsgBox("Withdrawal denied.", MsgBoxStyle.Information, "Insufficient Funds")
        ElseIf Withdrawal <= Balance Then
            Balance = Balance - Withdrawal
            txtOutput.Text = "New balance is " & FormatCurrency(Balance)
        End If
        If Balance < 150 Then
            MsgBox("Your new balance is below $150.", MsgBoxStyle.Information, "Low Balance Warning")
        End If
    End Sub
End Class