Public Class frm24
    Private Sub btnFindBook_Click(sender As Object, e As EventArgs) Handles btnFindBook.Click
        Dim n As Integer
        n = CInt(txtCallNumber.Text)
        Select Case n
            Case 100 To 199
                txtLocation.Text = "Basement"
            Case 200 To 500, Is > 900
                txtLocation.Text = "Main Floor"
            Case 700 To 750
                txtLocation.Text = "Archives"
            Case 501 To 900
                txtLocation.Text = "Upper Floor"
            Case Else
                txtLocation.Text = "Invalid Call Number"
        End Select
    End Sub
End Class