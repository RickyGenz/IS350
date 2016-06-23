Public Class frm26
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim num, min As Decimal
        Dim count As Decimal = 0
        Dim prompt As String = "Enter a nonnegative number. " &
                               "Enter -1 to terminate entering numbers."
        num = CDec(InputBox(prompt))
        min = num
        Do While num >= 0
            count += 1
            num = CDec(InputBox(prompt))
            If (num <> -1) Then
                If num < min Then min = num
            End If
        Loop
        If count > 0 Then
            txtOutput.Text = CStr(min)
        Else
            MsgBox("No numbers were entered.")
        End If
    End Sub
End Class