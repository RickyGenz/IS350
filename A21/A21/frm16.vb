Public Class frm16
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim USPres() As String = IO.File.ReadAllLines("USPres.txt")
        Dim VPres() As String = IO.File.ReadAllLines("VPres.txt")
        IO.File.WriteAllLines("Union.txt", USPres.Union(VPres))
        txtCount.Text = IO.File.ReadAllLines("Union.txt").Count
    End Sub
End Class