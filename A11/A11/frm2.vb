Public Class frm2
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Calories As Integer = txtCalories.Text
        Dim Fat As Integer = txtFat.Text
        Dim Result As Decimal = (Fat * 9) / Calories
        lstResult.Items.Clear()
        lstResult.Items.Add(txtFood.Text & " contains " & FormatPercent(Result) & " calories from fat,")
        If Result > 0.3 Then
            lstResult.Items.Add("which exceeds AHA recommendation.")
        Else
            lstResult.Items.Add("which meets AHA recommendation.")
        End If
    End Sub
End Class