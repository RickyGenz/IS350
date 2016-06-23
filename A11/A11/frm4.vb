Public Class frm4
    Private Sub btnSolution_Click(sender As Object, e As EventArgs) Handles btnSolution.Click
        Dim A, B, C, D, x1, x2 As Decimal
        A = Val(txtA.Text)
        B = Val(txtB.Text)
        C = Val(txtC.Text)
        D = Val(B ^ 2 - 4 * A * C)
        If A = 0 Then txtSolution.Text = "None" : Exit Sub
        If D < 0 Then txtSolution.Text = "None" : Exit Sub
        If D = 0 Then
            x1 = Math.Round((-B + Math.Sqrt(B ^ 2 - 4 * A * C)) / (2 * A), 2)
            txtSolution.Text = x1
        ElseIf D > 0 Then
            x1 = Math.Round((-B + Math.Sqrt(B ^ 2 - 4 * A * C)) / (2 * A), 2)
            x2 = Math.Round((-B - Math.Sqrt(B ^ 2 - 4 * A * C)) / (2 * A), 2)
            txtSolution.Text = x1 & " and " & x2
        End If
    End Sub
End Class