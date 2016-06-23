Public Class frm72
    Private Sub frm72_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt1 As Date = #7/4/1776# 'Date Declaration of Independence was ratified.
        Dim dt2 As Date = Date.Now 'Current Date
        txtOutput.Text = CStr(DateDiff(DateInterval.Day, dt1, dt2))
    End Sub
End Class