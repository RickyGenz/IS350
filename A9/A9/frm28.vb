Public Class frm28
    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        Dim n As Integer
        n = CInt(txtRegistrants.Text)
        Select Case n
            Case Is > 30
                txtTotalCost.Text = FormatCurrency(n * 400)
            Case Is > 20
                txtTotalCost.Text = FormatCurrency(n * 450)
            Case Is >= 10
                txtTotalCost.Text = FormatCurrency(n * 500)
            Case Else
                txtTotalCost.Clear()
                MsgBox("Number of registants must be at least 10.", MsgBoxStyle.Information, "Error")
        End Select
    End Sub
    Private Sub txtRegistrants_TextChanged(sender As Object, e As EventArgs) Handles txtRegistrants.TextChanged
        If IsNumeric(txtRegistrants.Text) = False Then
            MsgBox("Number of registants must be a numeric value.", MsgBoxStyle.Information, "Error")
            Exit Sub
        Else
            btnComputeTotal.Enabled = True
        End If
    End Sub
End Class