Public Class frm32
    Function IsQwerty(s As String) As Boolean
        Dim Count As Integer
        For i As Integer = 0 To s.Length - 1
            Dim c As String = s.Substring(i, 1)
            If c.ToLower Like "q" Then Count += 1
            If c.ToLower Like "w" Then Count += 1
            If c.ToLower Like "e" Then Count += 1
            If c.ToLower Like "r" Then Count += 1
            If c.ToLower Like "t" Then Count += 1
            If c.ToLower Like "y" Then Count += 1
            If c.ToLower Like "u" Then Count += 1
            If c.ToLower Like "i" Then Count += 1
            If c.ToLower Like "o" Then Count += 1
            If c.ToLower Like "p" Then Count += 1
        Next
        If Count = s.Length Then Return True Else Return False
    End Function
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        If IsQwerty(txtInput.Text) Then txtOutput.Text = "Yes" Else txtOutput.Text = "No"
    End Sub
End Class