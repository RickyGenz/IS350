Public Class frmWrap
    Private Sub Wrapping_Load_radButtonNo_CheckedChanged(sender As Object, e As EventArgs) Handles MyBase.Load, radButtonNo.CheckedChanged
        'Disable radio buttons on load.
        radButton1.Enabled = False
        radButton2.Enabled = False
        radButton3.Enabled = False
        radButton4.Enabled = False
        radButton5.Enabled = False
    End Sub
    Private Sub radButtonYes_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonYes.CheckedChanged
        'Enable radio buttons when yes button is clicked.
        radButton1.Enabled = True
        radButton2.Enabled = True
        radButton3.Enabled = True
        radButton4.Enabled = True
        radButton5.Enabled = True
    End Sub
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'Compute the total based on which radio button is checked.
        Dim z As Double
        If radButton1.Checked = True Then txtBoxResult.Text = 5.95
        If radButton2.Checked = True Then txtBoxResult.Text = 7.95
        If radButton3.Checked = True Then txtBoxResult.Text = 10.95
        If radButton4.Checked = True Then txtBoxResult.Text = 19.95
        If radButton5.Checked = True Then txtBoxResult.Text = 29.95
        z = txtBoxResult.Text
        txtBoxResult.Text = FormatCurrency(z)
    End Sub
    Private Sub radButton1_CheckedChanged(sender As Object, e As EventArgs) Handles radButton1.CheckedChanged, radButton2.CheckedChanged, radButton3.CheckedChanged, radButton4.CheckedChanged, radButton5.CheckedChanged
        'Clear the total each time a radio button is clicked.
        If radButton1.Checked = True Then txtBoxResult.Clear()
        If radButton2.Checked = True Then txtBoxResult.Clear()
        If radButton3.Checked = True Then txtBoxResult.Clear()
        If radButton4.Checked = True Then txtBoxResult.Clear()
        If radButton5.Checked = True Then txtBoxResult.Clear()
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Save wrappingsum as a global variable and close.
        wrappingsum = txtBoxResult.Text
        Me.Close()
    End Sub
End Class