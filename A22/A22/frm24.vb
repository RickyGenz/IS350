Public Class frm24
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim Input(1) As String
        Input(0) = txtItem.Text
        Input(1) = txtPrice.Text
        Dim sw As IO.StreamWriter = IO.File.AppendText("Cowboy.txt")
        sw.WriteLine(Join(Input, ","))
        sw.Close()
    End Sub
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        End
    End Sub
End Class