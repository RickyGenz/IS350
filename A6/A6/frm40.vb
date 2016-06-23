Public Class frm40
    Private Sub frm40_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt1 As Date = #1/1/2012# '2012 was a leap year
        Dim dt2 As Date = #1/1/2013#
        txtOutput.Text = CStr(DateDiff(DateInterval.Day, dt1, dt2))
    End Sub
End Class