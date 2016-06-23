Public Class frm2
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim num As Integer = 3
        Do
            num = 2 * num
        Loop Until num > 15
        txtOutput.Text = CStr(num)
    End Sub
End Class