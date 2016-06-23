Public Class frm22
    Private Sub btnDetermine_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        If (txt1.Text < txt2.Text) And (txt1.Text < txt3.Text) Then txtResult.Text = txt1.Text
        If (txt2.Text < txt1.Text) And (txt2.Text < txt3.Text) Then txtResult.Text = txt2.Text
        If (txt3.Text < txt1.Text) And (txt3.Text < txt2.Text) Then txtResult.Text = txt3.Text
    End Sub
End Class