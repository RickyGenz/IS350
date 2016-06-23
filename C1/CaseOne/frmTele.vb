Public Class frmTele
    Private Sub Telegrams_Load_radBtnNo_CheckedChanged(sender As Object, e As EventArgs) Handles MyBase.Load, radBtnNo.CheckedChanged
        'Disable checkboxes.
        chkBoxAnniv.Enabled = False
        chkBoxBirth.Enabled = False
        chkBoxChrist.Enabled = False
        chkBoxValen.Enabled = False
    End Sub
    Private Sub radBtnYes_CheckedChanged(sender As Object, e As EventArgs) Handles radBtnYes.CheckedChanged
        'Enable checkboxes when yes button is clicked.
        chkBoxAnniv.Enabled = True
        chkBoxBirth.Enabled = True
        chkBoxChrist.Enabled = True
        chkBoxValen.Enabled = True
    End Sub
    Private Sub btnCmpt_Click(sender As Object, e As EventArgs) Handles btnCmpt.Click
        'Compute total cost.
        Dim Birth, Anniv, Christ, Valen As Double
        txtBoxResult.Clear()
        If chkBoxBirth.Checked Then
            Birth = 19.95
        End If
        If chkBoxAnniv.Checked Then
            Anniv = 22.95
        End If
        If chkBoxChrist.Checked Then
            Christ = 24.95
        End If
        If chkBoxValen.Checked Then
            Valen = 29.95
        End If
        telegramssum = Birth + Anniv + Christ + Valen
        txtBoxResult.Text = FormatCurrency(telegramssum)
    End Sub
    Private Sub chkBoxBirth_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxBirth.CheckedChanged, chkBoxAnniv.CheckedChanged, chkBoxChrist.CheckedChanged, chkBoxValen.CheckedChanged
        'Reset total cost when checkbox is checked.
        If chkBoxBirth.Checked = True Then txtBoxResult.Clear()
        If chkBoxAnniv.Checked = True Then txtBoxResult.Clear()
        If chkBoxChrist.Checked = True Then txtBoxResult.Clear()
        If chkBoxValen.Checked = True Then txtBoxResult.Clear()
        txtBoxResult.Text = "0"
    End Sub
    Private Sub btnRetrn_Click(sender As Object, e As EventArgs) Handles btnRetrn.Click
        'Save telegrammssum as global variable and close.
        telegramssum = Math.Round(telegramssum, 2)
        Me.Close()
    End Sub
End Class