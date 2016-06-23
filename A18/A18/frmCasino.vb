Public Class frmCasino
    Dim Winnings As Decimal
    Function Reel(i As Single) As String
        Dim Num As Decimal = Rnd(i)
        Select Case Num
            Case 0 To 0.2
                Reel = "$"
            Case 0.2 To 0.4
                Reel = "#"
            Case 0.4 To 0.6
                Reel = "@"
            Case 0.6 To 0.8
                Reel = "%"
            Case 0.8 To 1
                Reel = "*"
            Case Else
                Reel = "" : MsgBox("Reel Error!")
        End Select
    End Function
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        If txtInput.Text = "" Then
            MsgBox("Invalid Wager!")
            Exit Sub
        ElseIf Not IsNumeric(txtInput.Text) Then
            MsgBox("Invalid Wager!")
            Exit Sub
        ElseIf txtInput.Text <= 0 Then
            MsgBox("Invalid Wager!")
            Exit Sub
        End If
        Dim Wager As Decimal = txtInput.Text
        txtOne.Text = Reel(Wager)
        txtTwo.Text = Reel(Wager)
        txtThree.Text = Reel(Wager)
        txtOutput.Clear()
        If txtOne.Text = txtTwo.Text And txtOne.Text = txtThree.Text Then
            txtOutput.Text = "Winner! " & (Wager * 3)
            Winnings += (Wager * 3)
        ElseIf txtOne.Text = txtTwo.Text Or txtOne.Text = txtThree.Text Or txtTwo.Text = txtThree.Text Then
            txtOutput.Text = "Winner! " & (Wager * 2)
            Winnings += (Wager * 2)
        Else
            txtOutput.Text = "Loser! " & Wager
            Winnings -= Wager
        End If

    End Sub
    Private Sub btnWinnings_Click(sender As Object, e As EventArgs) Handles btnWinnings.Click
        txtOutput.Clear()
        txtOutput.Text = "Total Winnings: " & Winnings
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class