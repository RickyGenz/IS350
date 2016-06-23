Public Class frm36
    Structure Gift
        Dim day As Integer
        Dim name As String
        Dim cost As Decimal
    End Structure
    Dim gifts() As Gift
    Private Sub frm36_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim days() As String = IO.File.ReadAllLines("Gifts.txt")
        Dim n As Integer = days.Count - 1
        ReDim gifts(n)
        Dim data(2) As String
        For i As Integer = 0 To n
            data = days(i).Split(","c)
            gifts(i).day = CInt(data(0))
            gifts(i).name = data(1)
            gifts(i).cost = CDec(data(2))
        Next
    End Sub
    Function IsDayInvalid(box As TextBox) As Boolean
        If box.Text = "" Then Return True
        If Not IsNumeric(box.Text) Then Return True
        If box.Text > 12 Or box.Text < 1 Then Return True
        Return False
    End Function
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If IsDayInvalid(txtDay) Then MsgBox("Invalid Day!") : Exit Sub
        lstCosts.Items.Clear()
        Dim dayCosts As Decimal
        Dim totalCosts As Decimal
        Dim query = From g In gifts
                    Where g.day <= CInt(txtDay.Text)
                    Select g
        lstCosts.Items.Add("The gifts for day " & txtDay.Text & " are")
        For Each q In query
            lstCosts.Items.Add(q.day & " " & q.name)
            dayCosts += q.day * q.cost
            totalCosts += dayCosts
        Next
        lstCosts.Items.Add("")
        lstCosts.Items.Add("Costs for day " & txtDay.Text & ": " & FormatCurrency(dayCosts))
        lstCosts.Items.Add("Total costs for the first " & txtDay.Text & " days: " & FormatCurrency(totalCosts))
    End Sub
End Class