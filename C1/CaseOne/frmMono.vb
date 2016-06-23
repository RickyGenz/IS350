Public Class frmMono
    Private Sub Monogramming_Load_radButtonNo_CheckedChanged(sender As Object, e As EventArgs) Handles MyBase.Load, radButtonNo.CheckedChanged
        'Disable checkboxes and textboxes.
        chkBox1.Enabled = False
        chkBox2.Enabled = False
        chkBox3.Enabled = False
        chkBox1.Checked = False
        txtBoxItem1.Enabled = False
        txtBoxItem2.Enabled = False
        txtBoxItem3.Enabled = False
        txtBoxMonogramming.Enabled = False
    End Sub
    Private Sub radButtonYes_CheckedChanged(sender As Object, e As EventArgs) Handles radButtonYes.CheckedChanged
        'Enable the checkboxes and check the first checkbox.
        chkBox1.Enabled = True
        chkBox2.Enabled = True
        chkBox3.Enabled = True
        txtBoxItem1.Enabled = True
        chkBox1.Checked = True
    End Sub
    Private Sub chkBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox2.CheckedChanged
        'Enable textbox 2 when checkbox 2 is checked.
        txtBoxItem2.Enabled = True
    End Sub
    Private Sub chkBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox3.CheckedChanged
        'Enable textbox 3 when checkbox 3 is checked.
        txtBoxItem3.Enabled = True
    End Sub
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        'Compute the total price based on each items length.
        Dim length1, price1 As Double
        Dim length2, price2 As Double
        Dim length3, price3 As Double
        If chkBox1.Checked Then
            'Test input box for valid content.
            If txtBoxItem1.Text = "" Then
                MsgBox("No Item #1 Monogram Found.", MsgBoxStyle.Information, "Error")
                txtBoxItem1.Focus()
                Exit Sub
            ElseIf txtBoxItem1.Text.Trim.Length <= 3 Then
                MsgBox("Item #1 Monogram is 3 or less characters.", MsgBoxStyle.Information, "Error")
            End If
            length1 = txtBoxItem1.Text.Trim.Length
            price1 = length1 * 5
        End If
        If chkBox2.Checked Then
            'Test input box for valid content.
            If txtBoxItem2.Text = "" Then
                MsgBox("No Item #2 Monogram Found.", MsgBoxStyle.Information, "Error")
                txtBoxItem2.Focus()
                Exit Sub
            ElseIf txtBoxItem2.Text.Trim.Length <= 3 Then
                MsgBox("Item #2 Monogram is 3 or less characters.", MsgBoxStyle.Information, "Error")
            End If
            length2 = txtBoxItem2.Text.Trim.Length
            price2 = length2 * 5
        End If
        If chkBox3.Checked Then
            'Test input box for valid content.
            If txtBoxItem3.Text = "" Then
                MsgBox("No Item #3 Monogram Found.", MsgBoxStyle.Information, "Error")
                txtBoxItem3.Focus()
                Exit Sub
            ElseIf txtBoxItem3.Text.Trim.Length <= 3 Then
                MsgBox("Item #3 Monogram is 3 or less characters.", MsgBoxStyle.Information, "Error")
            End If
            length3 = txtBoxItem3.Text.Trim.Length
            price3 = length3 * 5
        End If
        monogrammingsum = price1 + price2 + price3
        txtBoxMonogramming.Text = FormatCurrency(monogrammingsum)
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Save monogrammingsum as a global variable and close.
        monogrammingsum = Math.Round(monogrammingsum, 2)
        Me.Close()
    End Sub
End Class
