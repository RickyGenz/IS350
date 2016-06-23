Public Class frm16
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim RHR As Integer = txtRHR.Text
        Dim MHR As Integer = 220 - CInt(txtAge.Text)
        Dim THR As Integer = ((MHR - RHR) * 0.6) + RHR
        txtTHR.Text = THR
    End Sub
End Class