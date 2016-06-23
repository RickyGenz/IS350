Public Class frm26
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim fmth As String = "{0,-4} {1, -9} {2, -9}"
        Dim fmtd As String = "{0,-4} {1, 9:c2} {2, 9:c2}"
        lstOutput.Items.Add(String.Format(fmth, "", "SIMPLE", "COMPOUND"))
        lstOutput.Items.Add(String.Format(fmth, "YEAR", "INTEREST", "INTEREST"))
        Dim s As Decimal = 1000, c As Decimal = 1000
        For i As Integer = 1 To 9 Step 0
            s = s + 50
            c = c * 1.05
            lstOutput.Items.Add(String.Format(fmtd, i, s, c))
            i += 1
        Next
    End Sub
End Class