Public Class frm10_16
    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        cboBox.SelectedItem = cboBox.Items(2)
    End Sub
    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        cboBox.Items.Remove("Goethe")
    End Sub
    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        For N = 0 To cboBox.Items.Count - 1 Step 2
            lstBox.Items.Add(cboBox.Items(N))
        Next
    End Sub
    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        If cboBox.Items.IndexOf("Cervantes") = -1 Then MsgBox("Cervantes is not in the list.")
    End Sub
End Class