Public Class frm30
    Sub Years(DoB As Date, Today As Date)
        Dim Years As Integer
        Years = DateDiff(DateInterval.Year, DoB, Today)
        lstOutput.Items.Add("You are " & Years & " years old.")
    End Sub
    Sub Days(DoB As Date, Today As Date)
        Dim Days As Integer
        Days = DateDiff(DateInterval.Day, DoB, Today)
        lstOutput.Items.Add("You are " & Days & " days old.")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDetermine.Click
        Call Years(txtDoB.Text, txtToday.Text)
        Call Days(txtDoB.Text, txtToday.Text)
    End Sub
End Class
