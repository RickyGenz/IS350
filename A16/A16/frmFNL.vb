Public Class frmFNL
    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        Dim fmt As String = "{0,5}"
        Dim Output As String = ""
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Multiplication Table")
        lstOutput.Items.Add("")
        For n As Integer = 1 To 9 Step 1
            Output += String.Format(fmt, n) & " "
        Next
        lstOutput.Items.Add("      " & Output)
        Output = ""
        For i As Integer = 1 To 9 Step 1
            Output += String.Format(fmt, i) & " "
            For n As Integer = 1 To 9 Step 1
                Output += String.Format(fmt, n * i) & " "
            Next
            lstOutput.Items.Add(Output)
            Output = ""
        Next
    End Sub
    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim fmt As String = "{0,5:n2}"
        Dim Output As String = ""
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Division Table")
        lstOutput.Items.Add("")
        For n As Integer = 1 To 9 Step 1
            Output += String.Format(fmt, n) & " "
        Next
        lstOutput.Items.Add("      " & Output)
        Output = ""
        For i As Integer = 1 To 9 Step 1
            Output += String.Format(fmt, i) & " "
            For n As Integer = 1 To 9 Step 1
                Output += String.Format(fmt, n / i) & " "
            Next
            lstOutput.Items.Add(Output)
            Output = ""
        Next
    End Sub
    Private Sub btnTip_Click(sender As Object, e As EventArgs) Handles btnTip.Click
        Dim fmt As String = "{0,5:n2}"
        Dim Input As Decimal = CDec(txtTip.Text)
        Dim Output As String = ""
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Tipping Table")
        lstOutput.Items.Add("")
        For n As Double = 0 To 0.9 Step 0.1
            Output += String.Format(fmt, n) & " "
        Next
        lstOutput.Items.Add("      " & Output)
        Output = ""
        For i As Integer = 10 To 20 Step 1
            Output += String.Format(fmt, i) & " "
            For n As Double = 0 To 0.9 Step 0.1
                Output += String.Format(fmt, i * Input + (Input * n)) & " "
            Next
            lstOutput.Items.Add(Output)
            Output = ""
        Next
    End Sub
End Class