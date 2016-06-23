Public Class frmInstructions

    Private Sub frmInstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = Me
    End Sub

    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        lblInstructions.Text = "Enter your full name."
    End Sub

    Private Sub txtPhone_GotFocus(sender As Object, e As EventArgs) Handles txtPhone.GotFocus
        lblInstructions.Text = "Enter your phone number, including area code."
    End Sub

End Class