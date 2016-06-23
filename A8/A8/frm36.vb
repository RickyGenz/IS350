Public Class frm36
    Dim ScoreOne As Single = 0
    Dim ScoreTwo As Single = 0
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim Score As Single
        Select Case Val(txtScore.Text)
            Case 0 To 100
                Score = txtScore.Text
            Case Else
                txtScore.Clear()
                MsgBox("Not a vaild score. [0 - 100]", MsgBoxStyle.Information, "Invalid Score")
        End Select
        If Score > ScoreOne Then
            ScoreOne = Score
            txtScore.Clear()
        ElseIf Score > ScoreTwo Then
            ScoreTwo = Score
            txtScore.Clear()
        ElseIf Score = ScoreOne Or Score = ScoreTwo Then
            txtScore.Clear()
        End If
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtHigh.Text = ScoreOne & " " & ScoreTwo
    End Sub
End Class