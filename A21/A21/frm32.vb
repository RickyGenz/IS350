Public Class frm32
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim Justice() As String = IO.File.ReadAllLines("Justice.txt")
        txtCount.Text = IO.File.ReadAllLines("NewFile.txt").Count
    End Sub
End Class