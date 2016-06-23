Public Class frmPassword
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        If txtPassword.Text = "" Or txtConfirm.Text = "" Then MsgBox("Can not be blank.") : Exit Sub
        If txtPassword.Text.Length <> 6 Then MsgBox("Must be six characters in length.") : Exit Sub
        If Not txtPassword.Text Like "[A-Za-z][A-Za-z][A-Za-z][A-Za-z]##" Then MsgBox("Must be four letters and then two numbers.") : Exit Sub
        Dim Upper As Boolean = False
        Dim Lower As Boolean = False
        For I As Integer = 0 To txtPassword.Text.Length - 1
            Dim NextChar As String = txtPassword.Text.Substring(I, 1)
            If NextChar Like "[A-Z]" Then Upper = True
            If NextChar Like "[a-z]" Then Lower = True
        Next
        If Not Upper Or Not Lower Then MsgBox("Must have uppercase and lowercase letters.") : Exit Sub
        If txtPassword.Text <> txtConfirm.Text Then MsgBox("Passwords must match.") : Exit Sub
        MsgBox("Valid Password.")
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class