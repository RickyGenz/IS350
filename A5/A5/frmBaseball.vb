Public Class frmBaseball

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Won, Lost, Result As Single
        Won = txtWon.Text
        Lost = txtLost.Text
        Result = Won / (Won + Lost)
        lblResult.Text = "The " & txtTeam.Text & " won " & FormatPercent(Result, 1) & " of their games."
    End Sub

End Class