Public Class frm3
    Private Sub btnMaxHeight_Click(sender As Object, e As EventArgs) Handles btnMaxHeight.Click
        lstOutput.Items.Clear()
        Dim h As Decimal = CDec(txtHeight.Text)
        Dim v As Decimal = CDec(txtVelocity.Text)
        Dim t As Decimal = v / 32
        Dim MaxHeight As Decimal = h + (v * t) - (16 * (t ^ 2))
        lstOutput.Items.Add("The maximum height is " & MaxHeight & " feet.")
    End Sub
    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        lstOutput.Items.Clear()
        Dim h As Decimal = CDec(txtHeight.Text)
        Dim v As Decimal = CDec(txtVelocity.Text)
        Dim t As Decimal = 0
        Dim Height As Decimal = h + (v * t) - (16 * (t ^ 2))
        Do While Height > 0
            t += 0.1
            Height = h + (v * t) - (16 * (t ^ 2))
        Loop
        lstOutput.Items.Add("The ball will hit the ground after " & t & " seconds.")
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        lstOutput.Items.Clear()
        Dim f As String = "{0,-6:n2}{1,6:n2}"
        Dim h As Decimal = CDec(txtHeight.Text)
        Dim v As Decimal = CDec(txtVelocity.Text)
        Dim Height As Decimal = 0
        lstOutput.Items.Add(String.Format(f, "Time", "Height"))
        For t As Double = 0 To 5 Step 0.25
            Height = h + (v * t) - (16 * (t ^ 2))
            If Height < 0 Then Exit Sub
            lstOutput.Items.Add(String.Format(f, t, Height))
        Next
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class