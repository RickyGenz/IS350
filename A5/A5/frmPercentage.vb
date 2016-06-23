Public Class frmPercentage

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim p As Integer
        p = txtPercentage.Text.IndexOf("%")
        txtDecimal.Text = txtPercentage.Text.Substring(0, p) / 100
    End Sub

End Class