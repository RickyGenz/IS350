Public Class frmMain
    Function IsInput(ByVal s As String) As Boolean
        'Test input fields for valid data.
        Dim Controls = From c In Me.Controls Order By c.TabIndex
        For Each c In Controls
            If c.AccessibleRole = Windows.Forms.AccessibleRole.Text Then
                If Len(Trim(c.Text)) <= 0 Then
                    MsgBox(c.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                    c.Focus()
                    Return False
                End If
            End If
            If c.AccessibleName Like s Then
                If Not c.Text Like "###-##-####" Then
                    MsgBox(c.AccessibleName & " is not valid.", MsgBoxStyle.Critical, "Error")
                    c.Focus()
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Function IsPassword() As Boolean
        'Test password input for valid data.
        Password = InputBox("Please enter your password.", "Employee Application System")
        If Password Like "###-[A-Z][A-Z]" Then
            Attempts = 5
            Return True
        ElseIf Password = "" Then
            MsgBox("No Password Found.", MsgBoxStyle.Information, "Error")
        End If
        Return False
    End Function
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Test for valid password when form loads. User gets three attempts.
        While Attempts < 5
            Attempts += 1
            If Attempts = 1 Then IsPassword()
            If Attempts = 2 Then IsPassword()
            If Attempts = 3 Then IsPassword()
            If Attempts = 4 Then
                MsgBox("Entered the wrong password too many times!", MsgBoxStyle.Critical, "Failed Password")
                End
            End If
        End While
    End Sub
    Private Sub btnSecondForm_Click(sender As Object, e As EventArgs) Handles btnSecondForm.Click
        'Test for valid SSN, First Name, Last Name, Address, City, State, and Zip Code.
        If IsInput("SSN") Then
            FullName = txtFirstName.Text & " " & txtLastName.Text
            SSN = txtSSN.Text
            frmNetPay.ShowDialog()
        End If
    End Sub
    Private Sub btnNetPay_Click(sender As Object, e As EventArgs) Handles btnNetPay.Click
        'Display Net Pay
        txtNetPay.Text = FormatCurrency(NetPay)
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Print summary.
        PreviewSummary.Document = PrintSummary
        PreviewSummary.ShowDialog()
    End Sub
    Private Sub PrintSummary_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSummary.PrintPage
        'Declare and set printing variables.
        Dim g As Graphics = e.Graphics
        Dim x0 As Single = 50
        Dim x1 As Single = 275
        Dim x2 As Single = 125
        Dim y0 As Single = 50
        Dim y1 As Single = 25
        Dim y2 As Single = 50
        Dim h As New Font("Arial Black", 12)
        Dim b As New Font("Courier New", 10, FontStyle.Bold)
        Dim fmt As String = "{0,12:c2}"
        'Draw heading.
        g.DrawString("MGS Payroll System", h, Brushes.Black, x2, y0)
        y0 += y2
        'Draw  information.
        g.DrawString("Name:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, FullName), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString("Soc. Sec. Number:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, SSN), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString("Gross Pay:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, Gross), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString("Health Plan Costs:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, HPCosts), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString("Additional Deductions:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, ADCosts), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString("Net Pay:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, NetPay), b, Brushes.Black, x1, y0)
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'End execution
        End
    End Sub
End Class