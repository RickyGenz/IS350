Public Class frm28
    Function CountSibilants(s As String) As Integer
        Dim n As Integer
        For i As Integer = 0 To s.Length - 1
            Dim c As String = s.Substring(i, 1)
            If c.ToLower Like "s" Then n += 1
            If c.ToLower Like "z" Then n += 1
        Next
        Return n
    End Function
    Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
        Dim Count As Integer = CountSibilants(txtInput.Text)
        Dim Pronoun As String = "is ", Noun As String = " sibilant"
        If Count = 0 Or Count > 1 Then Pronoun = "are " : Noun = " sibilants"
        txtOutput.Text = "There " & Pronoun & Count & Noun & " in the sentence."
    End Sub
End Class