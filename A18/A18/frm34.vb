Public Class frm34
    Dim nums() As Integer = {1, 2, 3, 4, 5}
    Function Average(Input As Array) As Integer
        Dim Total, Count As Integer
        For Each i In Input
            Total += i
            Count += 1
        Next
        Average = Total / Count
    End Function
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        txtOutput.Text = Average(nums)
    End Sub
End Class