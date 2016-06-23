Public Class frmVM
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'Declare Variables
        Dim Purchase As Single = txtPurchase.Text
        Dim Payment As Single = txtPayment.Text
        Dim Change As Decimal
        Dim Fives, Ones, Quarters, Dimes, Nickles, Pennies As Integer
        'Test: Payment < Purchase & Payment > 20
        lstMessages.Items.Clear()
        If Payment < Purchase Then
            lstMessages.Items.Add("Payment amount is less than the")
            lstMessages.Items.Add("purchase amount.")
            txtPayment.Clear()
            txtPayment.Focus()
            Exit Sub
        ElseIf Payment > 20 Then
            lstMessages.Items.Add("The largest bill the machine accepts")
            lstMessages.Items.Add("is a $20.")
            txtPayment.Clear()
            txtPayment.Focus()
            Exit Sub
        End If
        'Calculate Total Change
        Change = Payment - Purchase
        txtChange.Text = FormatCurrency(Change)
        'Calculate Change Breakdown
        Fives = Int(Change / 5)
        Change = Change - (Fives * 5)
        txtFives.Text = Fives
        Ones = Int(Change / 1)
        Change = Change - (Ones * 1)
        txtOnes.Text = Ones
        Quarters = Int(Change / 0.25)
        Change = Change - (Quarters * 0.25)
        txtQuarters.Text = Quarters
        Dimes = Int(Change / 0.1)
        Change = Change - (Dimes * 0.1)
        txtDimes.Text = Dimes
        Nickles = Int(Change / 0.05)
        Change = Change - (Nickles * 0.05)
        txtNickles.Text = Nickles
        Pennies = Int(Change / 0.01)
        Change = Change - (Pennies * 0.01)
        txtPennies.Text = Pennies
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear
        txtPurchase.Clear()
        txtPayment.Clear()
        txtChange.Clear()
        lstMessages.Items.Clear()
        txtFives.Clear()
        txtOnes.Clear()
        txtQuarters.Clear()
        txtDimes.Clear()
        txtNickles.Clear()
        txtPennies.Clear()
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'End
        End
    End Sub
End Class