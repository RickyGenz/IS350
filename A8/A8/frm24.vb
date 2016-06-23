Public Class frm24
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Copies, Cost As Single
        Copies = txtCopies.Text
        If Copies <= 100 Then
            Cost = Copies * 0.05
        ElseIf Copies > 100 Then
            Cost = ((Copies - 100) * 0.03) + 5
        End If
        txtCost.Text = FormatCurrency(Cost)
    End Sub
End Class