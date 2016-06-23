Public Class frm24
    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        'Test: Fore & Back Color Selected
        If (rdoFWhite.Checked Or rdoFYellow.Checked Or rdoFRed.Checked Or rdoFBlue.Checked) And
           (rdoBWhite.Checked Or rdoBYellow.Checked Or rdoBRed.Checked Or rdoBBlue.Checked) Then
        Else
            MsgBox("Fore and Back Color must be selected!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        'Test: Fore & Back Color Not Same
        If (rdoFWhite.Checked And rdoBWhite.Checked) Or
           (rdoFYellow.Checked And rdoBYellow.Checked) Or
           (rdoFRed.Checked And rdoBRed.Checked) Or
           (rdoFBlue.Checked And rdoBBlue.Checked) Then
            MsgBox("Fore and Back Colors must be different!", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        'Set: ForeColor
        If rdoFWhite.Checked Then
            lblVB.ForeColor = Color.White
        ElseIf rdoFYellow.Checked Then
            lblVB.ForeColor = Color.Yellow
        ElseIf rdoFRed.Checked Then
            lblVB.ForeColor = Color.Red
        ElseIf rdoFBlue.Checked Then
            lblVB.ForeColor = Color.Blue
        End If
        'Set: BackColor
        If rdoBWhite.Checked Then
            lblVB.BackColor = Color.White
        ElseIf rdoBYellow.Checked Then
            lblVB.BackColor = Color.Yellow
        ElseIf rdoBRed.Checked Then
            lblVB.BackColor = Color.Red
        ElseIf rdoBBlue.Checked Then
            lblVB.BackColor = Color.Blue
        End If
    End Sub
End Class