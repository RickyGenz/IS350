Public Class frm7
    Function IsPalindrome(Input As String) As Boolean
        Dim CleanInput As String = ""
        Dim NextChar As String = ""
        For i As Integer = 0 To Input.Length - 1
            NextChar = Input.Substring(i, 1).ToLower
            If NextChar Like "[a-z]" Then CleanInput += NextChar
        Next
        Dim InputRev As String = StrReverse(CleanInput).ToLower
        If CleanInput = InputRev Then Return True
        Return False
    End Function
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        If IsPalindrome(txtInput.Text) Then txtOutput.Text = "Yes" Else txtOutput.Text = "No"
    End Sub
End Class