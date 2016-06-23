Public Class frmISBN
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim CheckNum As String = ""
        Dim NextChar As String
        For I As Integer = 0 To txtISBN.Text.Length - 1
            NextChar = txtISBN.Text.Substring(I, 1)
            If NextChar Like "#" Then CheckNum += NextChar
            If NextChar Like "X" Then CheckNum += "10"
        Next
        If CheckNum.Length <> 10 Then MsgBox("Must be exactly ten digits.") : Exit Sub
        Dim Num As Decimal
        Dim NextNum As Integer
        For I As Integer = 0 To CheckNum.Length - 1
            NextNum = CInt(CheckNum.Substring(I, 1))
            Num += (NextNum * (10 - I))
        Next
        If Num Mod 11 = 0 Then MsgBox("The ISBN " & CheckNum & " is valid.") Else MsgBox("The ISBN " & CheckNum & " is invalid.")
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        End
    End Sub
End Class