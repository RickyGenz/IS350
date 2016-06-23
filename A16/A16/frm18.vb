Public Class frm18
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim Sum As Integer
        For i As Integer = 0 To 100 Step 0
            Sum += i
            i += 1
        Next
        txtOutput.Text = Sum
    End Sub
End Class