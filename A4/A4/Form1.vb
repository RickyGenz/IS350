Public Class Form1
    ' On Form1 load execute this code.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Evaluate the expression of "15-3(2+3^4)" and store the answer in the Result Label's Text field.
        lblResult.Text = 15 - 3 * (2 + 3 ^ 4)
    End Sub
End Class
