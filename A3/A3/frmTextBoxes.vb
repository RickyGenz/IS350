Public Class frmTextBoxes

    Private Sub txtOne_Click(sender As Object, e As EventArgs) Handles txtOne.Click
        txtTwo.Text = txtOne.Text
        txtOne.Clear()
    End Sub

    Private Sub txtTwo_Click(sender As Object, e As EventArgs) Handles txtTwo.Click
        txtOne.Text = txtTwo.Text
        txtTwo.Clear()
    End Sub

End Class