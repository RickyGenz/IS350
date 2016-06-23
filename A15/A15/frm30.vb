Public Class frm30
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Dim r, x, y, z As Decimal
        r = CDec(txtRate.Text)
        x = Math.Log(2)
        y = Math.Log(1 + r)
        z = x / y
        txtTime.Text = CStr(Math.Round(z, 2))
    End Sub
End Class