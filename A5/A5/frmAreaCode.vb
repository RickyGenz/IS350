Public Class frmAreaCode

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If txtPhone.Text Like "###-###-####" Then
            txtArea.Text = txtPhone.Text.Substring(0, 3)
        Else
            MsgBox("Phone number must be '###-###-####'", MsgBoxStyle.Critical)
        End If
    End Sub

End Class