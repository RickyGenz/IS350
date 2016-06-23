Public Class frm1040

    Public Function IsInputInvalid() As Boolean
        'Tests if any input is invalid
        Dim Controls = From c In Me.Controls Order By c.TabIndex
        For Each c In Controls
            If c.AccessibleDescription = "Required" Then
                Dim num = CZer(c.Text)
                If IsNegative(num) Then
                    MsgBox(c.AccessibleName & " is not valid. Must be positive.", MsgBoxStyle.Critical, "Error")
                    c.Focus()
                    Return True
                End If
            End If
            If c.Name = "txtIncome" Then
                Dim num = CZer(c.Text)
                If num < 1 Or num > 500000 Then
                    MsgBox(c.AccessibleName & " is not valid. Must be between $1.00 and $500,000.00.", MsgBoxStyle.Critical, "Error")
                    c.Focus()
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub UtilityButtons(sender As Object, e As EventArgs) Handles btnIncome.Click, chkCreditCard.CheckedChanged, btnReturn.Click, btnExit.Click
        'Opens the credit card form
        If sender Is chkCreditCard Then frmCC.ShowDialog()
        'Opens the wage calculation form
        If sender Is btnIncome Then frmIncome.ShowDialog()
        'Returns to the main form
        If sender Is btnReturn Then Close()
        'Ends execution
        If sender Is btnExit Then End
    End Sub

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialize all neccessary values into the form from global variables
        grpYou.Text = YName & " (" & FSString & ")"
        txtIncome.Text = FormatCurrency(Income)
        txtInterest.Text = FormatCurrency(IITotal)
        txtDividend.Text = FormatCurrency(DITotal)
        txtBusiness.Text = FormatCurrency(SCTotal)
        txtSTGL.Text = FormatCurrency(STTotal)
        txtLTGL.Text = FormatCurrency(LTTotal)
        txtRental.Text = FormatCurrency(SETotal)
        txtDeductions.Text = FormatCurrency(SATotal)
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Runs invalid input test
        If IsInputInvalid() Then Exit Sub
        'Calculates amounts, saves in global variables, and then formats as currency
        Exemptions = CZer(txtDependents.Text)
        If chkYourself.Checked Then Exemptions += 1
        If chkSpouse.Checked Then Exemptions += 1
        txtExemptionsNumber.Text = Format(Exemptions, 0)
        Income = CZer(txtIncome.Text)
        txtIncome.Text = FormatCurrency(Income)
        AGI = Income + IITotal + DITotal + SCTotal + STTotal + LTTotal + SETotal
        txtAGI.Text = FormatCurrency(AGI)
        TotalExemptions = Exemptions * 2450
        txtExemptions.Text = FormatCurrency(TotalExemptions)
        TaxableIncome = AGI - SATotal - TotalExemptions
        txtTaxableIncome.Text = FormatCurrency(TaxableIncome)
        'Determines which tax rate is applicable to the taxable income amount
        Select Case TaxableIncome
            Case Is < 10000.99
                If FSNum = 1 Then TotalTax = TaxableIncome * 0.1
                If FSNum = 2 Then TotalTax = TaxableIncome * 0.1
                If FSNum = 3 Then TotalTax = TaxableIncome * 0.1
            Case 10001 To 25000.99
                If FSNum = 1 Then TotalTax = TaxableIncome * 0.15
                If FSNum = 2 Then TotalTax = TaxableIncome * 0.16
                If FSNum = 3 Then TotalTax = TaxableIncome * 0.145
            Case 25001 To 90000.99
                If FSNum = 1 Then TotalTax = TaxableIncome * 0.18
                If FSNum = 2 Then TotalTax = TaxableIncome * 0.195
                If FSNum = 3 Then TotalTax = TaxableIncome * 0.175
            Case 90001 To 130000.99
                If FSNum = 1 Then TotalTax = TaxableIncome * 0.28
                If FSNum = 2 Then TotalTax = TaxableIncome * 0.255
                If FSNum = 3 Then TotalTax = TaxableIncome * 0.245
            Case Is >= 130001
                If FSNum = 1 Then TotalTax = TaxableIncome * 0.31
                If FSNum = 2 Then TotalTax = TaxableIncome * 0.34
                If FSNum = 3 Then TotalTax = TaxableIncome * 0.365
        End Select
        'Calculates totals and formats as currency
        txtTotalTax.Text = FormatCurrency(TotalTax)
        Withheld = CZer(txtTaxWithheld.Text)
        txtTaxWithheld.Text = FormatCurrency(Withheld)
        'Determines if tax is owed or refunded
        Taxes = TotalTax - Withheld
        If Taxes < 0 Then
            Taxes = Taxes * -1
            lblFifteen.Text = "15. This is the Amount You Will be Refunded"
            grpPayment.Visible = False
        Else
            lblFifteen.Text = "15. This is the Amount You Owe"
            grpPayment.Visible = True
        End If
        txtTax.Text = FormatCurrency(Taxes)
    End Sub

    Private Sub PrintPagePreview(sender As Object, e As EventArgs) Handles btnPrintSummary.Click
        'Preview print summary.
        PreviewSummary.Document = PrintSummary
        PreviewSummary.ShowDialog()
    End Sub

    Private Sub PrintPageSummary(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintSummary.PrintPage
        'Declare and set printing variables.
        Dim g As Graphics = e.Graphics
        Dim x0 As Single = 50
        Dim x1 As Single = 550
        Dim x2 As Single = 75
        Dim x3 As Single = 665
        Dim x4 As Single = 275
        Dim x5 As Single = 275
        Dim x6 As Single = 310
        Dim y0 As Single = 50
        Dim y1 As Single = 25
        Dim y2 As Single = 50
        Dim y3 As Single = 5
        Dim y4 As Single = 35
        Dim h1 As New Font("Arial Black", 14, FontStyle.Bold)
        Dim h2 As New Font("Arial Black", 12, FontStyle.Italic)
        Dim b As New Font("Courier New", 10, FontStyle.Bold)
        Dim fmt As String = "{0,11:n2}"
        Dim fmtc As String = "{0,11:c2}"
        'Draw heading.
        g.DrawString(Title, h1, Brushes.Black, x5, y0)
        y0 += y4
        g.DrawString(Slogan, h2, Brushes.Black, x6, y0)
        y0 += y2
        'Draw customer information.
        g.DrawString("Income Tax Return for:", b, Brushes.Black, x0, y0)
        g.DrawString(YName, b, Brushes.Black, x4, y0)
        y0 += y1
        g.DrawString("Date:", b, Brushes.Black, x0, y0)
        g.DrawString(Today, b, Brushes.Black, x4, y0)
        y0 += y1
        g.DrawString("Number of Exemptions:", b, Brushes.Black, x0, y0)
        g.DrawString(Exemptions, b, Brushes.Black, x4, y0)
        y0 += y2
        'Draw summary amounts.
        g.DrawString(lblPartOneDesc.Text, b, Brushes.Black, x0, y0)
        y0 += y1
        g.DrawString(lblTwo.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmtc, Income), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblThree.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, IITotal), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblFour.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, DITotal), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblFive.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, SCTotal), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblSix.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, STTotal), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblSeven.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, LTTotal), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblEight.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, SETotal), b, Brushes.Black, x1, y0)
        g.DrawString(String.Format(fmt, "__________"), b, Brushes.Black, x1, y0 + y3)
        y0 += y1
        g.DrawString(lblPartTwoDesc.Text, b, Brushes.Black, x0, y0)
        y0 += y1
        g.DrawString(lblNine.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmtc, AGI), b, Brushes.Black, x3, y0)
        y0 += y1
        g.DrawString(lblTen.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, SATotal), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString(lblEleven.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, TotalExemptions), b, Brushes.Black, x1, y0)
        g.DrawString(String.Format(fmt, "__________"), b, Brushes.Black, x1, y0 + y3)
        y0 += y1
        g.DrawString(lblTwelve.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, TaxableIncome), b, Brushes.Black, x3, y0)
        y0 += y1
        g.DrawString(lblThirteen.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, TotalTax), b, Brushes.Black, x3, y0)
        y0 += y1
        g.DrawString(lblFourteen.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, Withheld), b, Brushes.Black, x3, y0)
        g.DrawString(String.Format(fmt, "__________"), b, Brushes.Black, x3, y0 + y3)
        y0 += y1
        g.DrawString(lblPartThreeDesc.Text, b, Brushes.Black, x0, y0)
        y0 += y1
        g.DrawString(lblFifteen.Text, b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmtc, Taxes), b, Brushes.Black, x3, y0)
    End Sub

End Class