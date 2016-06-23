Public Class frm28
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim num, fac As Decimal
        num = CDec(txtInput.Text)
        fac = 2
        lstOutput.Items.Add("The prime factors of " & num & " are:")
        Do While num > 1
            If num Mod fac = 0 Then
                lstOutput.Items.Add(fac)
                num = num / fac
            End If
            fac += 1
        Loop
    End Sub
End Class