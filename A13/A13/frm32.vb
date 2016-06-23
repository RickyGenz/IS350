Public Class frm32
    Sub Enrollment(Students As Integer, Course As String)
        Students = Students / 1000
        lstOutput.Items.Add(Students & " thousand students took a " & Course & " course.")
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstOutput.Items.Add("In a recent year,")
        Call Enrollment(823000, "Spanish")
        Call Enrollment(206000, "French")
    End Sub
End Class