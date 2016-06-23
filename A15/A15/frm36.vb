Public Class frm36
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim balance, months As Decimal
        Do While balance < 3000
            balance = ((1.0025) * balance) + 100
            months += 1
        Loop
        txtOutput.Text = months & " months"
    End Sub
End Class