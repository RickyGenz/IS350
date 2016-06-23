Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Test for valid password when main form loads. User gets three attempts.
        Dim Password As String
        Dim attempts As Single = 0
        While attempts < 5
            attempts += 1
            If attempts = 1 Then
                Password = InputBox("Please provide your password.", "Password Attempt One")
                If Password.ToLower = "a" Then
                    attempts = 5
                ElseIf Password = "" Then
                    MsgBox("No Password Found.", MsgBoxStyle.Information, "Error")
                End If
            ElseIf attempts = 2 Then
                Password = InputBox("Please provide your password.", "Password Attempt Two")
                If Password.ToLower = "a" Then
                    attempts = 5
                ElseIf Password = "" Then
                    MsgBox("No Password Found.", MsgBoxStyle.Information, "Error")
                End If
            ElseIf attempts = 3 Then
                Password = InputBox("Please provide your password.", "Password Attempt Three")
                If Password.ToLower = "a" Then
                    attempts = 5
                ElseIf Password = "" Then
                    MsgBox("No Password Found.", MsgBoxStyle.Information, "Error")
                End If
            ElseIf attempts = 4 Then
                MsgBox("Entered the wrong password too many times!", MsgBoxStyle.Critical, "Termination")
                Me.Close()
            End If
        End While
    End Sub
    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        'Clear all fields.
        txtName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()
        txtPhone.Clear()
        txtPurchaseAmount.Clear()
        txtShippingCost.Clear()
        txtAdditionalCharges.Clear()
        txtBroadwayShows.Clear()
        txtGrandTotal.Clear()
    End Sub
    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        'Display labels and textboxes.
        lblShippingCost.Visible = True
        txtShippingCost.Visible = True
        lblAdditionalCharges.Visible = True
        txtAdditionalCharges.Visible = True
        lblBroadwayShows.Visible = True
        txtBroadwayShows.Visible = True
        lblSpace.Visible = True
        lblGrandTotal.Visible = True
        txtGrandTotal.Visible = True
        'Compute GrandTotal.
        GrandTotal = PurchaseAmount + TotalShippingCharges + TotalAdditionalCharges + TotalBroadwayShows
        'Format totals as currency.
        txtPurchaseAmount.Text = FormatCurrency(PurchaseAmount)
        txtShippingCost.Text = FormatCurrency(TotalShippingCharges)
        txtAdditionalCharges.Text = FormatCurrency(TotalAdditionalCharges)
        txtBroadwayShows.Text = FormatCurrency(TotalBroadwayShows)
        txtGrandTotal.Text = FormatCurrency(GrandTotal)
    End Sub
    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        'Show about form.
        frmAbout.ShowDialog()
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Close the form after user ensures they wanted to quit.
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub btnShippingCharges_Click(sender As Object, e As EventArgs) Handles btnShippingCharges.Click
        'Test input boxes for valid content.
        If txtName.Text = "" Then
            MsgBox("No Customer Name Found.", MsgBoxStyle.Information, "Error")
            txtName.Focus()
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            MsgBox("No Street Address Found.", MsgBoxStyle.Information, "Error")
            txtAddress.Focus()
            Exit Sub
        ElseIf txtCity.Text = "" Then
            MsgBox("No City Found.", MsgBoxStyle.Information, "Error")
            txtCity.Focus()
            Exit Sub
        ElseIf txtState.Text = "" Then
            MsgBox("No State Found.", MsgBoxStyle.Information, "Error")
            txtState.Focus()
            Exit Sub
        ElseIf txtZip.Text = "" Then
            MsgBox("No Zip Found.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf IsNumeric(txtZip.Text) = False Then
            MsgBox("Zip must be numeric.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf txtZip.Text Like "#####" = False Then
            MsgBox("Zip must be like 00000.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf txtPhone.Text = "" Then
            MsgBox("No Phone Number Found.", MsgBoxStyle.Information, "Error")
            txtPhone.Focus()
            Exit Sub
        ElseIf txtPurchaseAmount.Text = "" Then
            MsgBox("No Purchase Amount Found.", MsgBoxStyle.Information, "Error")
            txtPurchaseAmount.Focus()
            Exit Sub
        ElseIf IsNumeric(txtPurchaseAmount.Text) = False Then
            MsgBox("Purchase Amount must be numeric.", MsgBoxStyle.Information, "Error")
            txtPurchaseAmount.Focus()
            Exit Sub
        End If
        'Save purchase amount as global variable.
        PurchaseAmount = txtPurchaseAmount.Text
        'Show shipping form.
        frmShip.ShowDialog()
        'Display global variable.
        txtShippingCost.Text = TotalShippingCharges
        lblShippingCost.Visible = True
        txtShippingCost.Visible = True
    End Sub
    Private Sub btnAdditionalCharges_Click(sender As Object, e As EventArgs) Handles btnAdditionalCharges.Click
        'Test input boxes for valid content.
        If txtName.Text = "" Then
            MsgBox("No Customer Name Found.", MsgBoxStyle.Information, "Error")
            txtName.Focus()
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            MsgBox("No Street Address Found.", MsgBoxStyle.Information, "Error")
            txtAddress.Focus()
            Exit Sub
        ElseIf txtCity.Text = "" Then
            MsgBox("No City Found.", MsgBoxStyle.Information, "Error")
            txtCity.Focus()
            Exit Sub
        ElseIf txtState.Text = "" Then
            MsgBox("No State Found.", MsgBoxStyle.Information, "Error")
            txtState.Focus()
            Exit Sub
        ElseIf txtZip.Text = "" Then
            MsgBox("No Zip Found.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf IsNumeric(txtZip.Text) = False Then
            MsgBox("Zip must be numeric.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf txtZip.Text Like "#####" = False Then
            MsgBox("Zip must be like 00000.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf txtPhone.Text = "" Then
            MsgBox("No Phone Number Found.", MsgBoxStyle.Information, "Error")
            txtPhone.Focus()
            Exit Sub
        ElseIf txtPurchaseAmount.Text = "" Then
            MsgBox("No Purchase Amount Found.", MsgBoxStyle.Information, "Error")
            txtPurchaseAmount.Focus()
            Exit Sub
        ElseIf IsNumeric(txtPurchaseAmount.Text) = False Then
            MsgBox("Purchase Amount must be numeric.", MsgBoxStyle.Information, "Error")
            txtPurchaseAmount.Focus()
            Exit Sub
        End If
        'Save purchase amount as global variable.
        PurchaseAmount = txtPurchaseAmount.Text
        'Show additional charges form.
        frmAdd.ShowDialog()
        'Display global variable.
        txtAdditionalCharges.Text = TotalAdditionalCharges
        lblAdditionalCharges.Visible = True
        txtAdditionalCharges.Visible = True
    End Sub
    Private Sub btnBroadwayShows_Click(sender As Object, e As EventArgs) Handles btnBroadwayShows.Click
        'Test input boxes for valid content.
        If txtName.Text = "" Then
            MsgBox("No Customer Name Found.", MsgBoxStyle.Information, "Error")
            txtName.Focus()
            Exit Sub
        ElseIf txtAddress.Text = "" Then
            MsgBox("No Street Address Found.", MsgBoxStyle.Information, "Error")
            txtAddress.Focus()
            Exit Sub
        ElseIf txtCity.Text = "" Then
            MsgBox("No City Found.", MsgBoxStyle.Information, "Error")
            txtCity.Focus()
            Exit Sub
        ElseIf txtState.Text = "" Then
            MsgBox("No State Found.", MsgBoxStyle.Information, "Error")
            txtState.Focus()
            Exit Sub
        ElseIf txtZip.Text = "" Then
            MsgBox("No Zip Found.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf IsNumeric(txtZip.Text) = False Then
            MsgBox("Zip must be numeric.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf txtZip.Text Like "#####" = False Then
            MsgBox("Zip must be like 00000.", MsgBoxStyle.Information, "Error")
            txtZip.Focus()
            Exit Sub
        ElseIf txtPhone.Text = "" Then
            MsgBox("No Phone Number Found.", MsgBoxStyle.Information, "Error")
            txtPhone.Focus()
            Exit Sub
        ElseIf txtPurchaseAmount.Text = "" Then
            MsgBox("No Purchase Amount Found.", MsgBoxStyle.Information, "Error")
            txtPurchaseAmount.Focus()
            Exit Sub
        ElseIf IsNumeric(txtPurchaseAmount.Text) = False Then
            MsgBox("Purchase Amount must be numeric.", MsgBoxStyle.Information, "Error")
            txtPurchaseAmount.Focus()
            Exit Sub
        End If
        'Save purchase amount as global variable.
        PurchaseAmount = txtPurchaseAmount.Text
        'Show broadway form.
        frmBroad.ShowDialog()
        'Display global variable.
        txtBroadwayShows.Text = TotalBroadwayShows
        lblBroadwayShows.Visible = True
        txtBroadwayShows.Visible = True
    End Sub
    Private Sub btnPrintInvoice_Click(sender As Object, e As EventArgs) Handles btnPrintInvoice.Click
        'Print Invoice.
        PrintInvoice.Print()
    End Sub
    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        'Preview print invoice.
        PreviewInvoice.Document = PrintInvoice
        PreviewInvoice.ShowDialog()
    End Sub
    Private Sub PrintInvoice_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintInvoice.PrintPage
        'Set information variables
        Name = txtName.Text
        Address = txtAddress.Text
        City = txtCity.Text
        StateZip = txtState.Text & ", " & txtZip.Text
        'Declare and set printing variables.
        Dim g As Graphics = e.Graphics
        Dim x0 As Single = 50
        Dim x1 As Single = 275
        Dim x2 As Single = 100
        Dim x3 As Single = 325
        Dim x4 As Single = 250
        Dim y0 As Single = 50
        Dim y1 As Single = 25
        Dim y2 As Single = 50
        Dim y3 As Single = 5
        Dim h As New Font("Arial Black", 12, FontStyle.Underline)
        Dim b As New Font("Courier New", 10, FontStyle.Bold)
        Dim fmt As String = "{0,8:n2}"
        'Draw heading.
        g.DrawString("Downtown Department Store Invoice", h, Brushes.Black, x0, y0)
        y0 += y2
        'Draw customer information.
        g.DrawString("Customer Name:", b, Brushes.Black, x0, y0)
        g.DrawString(Name, b, Brushes.Black, x4, y0)
        y0 += y1
        g.DrawString("Street Address:", b, Brushes.Black, x0, y0)
        g.DrawString(Address, b, Brushes.Black, x4, y0)
        y0 += y1
        g.DrawString("City:", b, Brushes.Black, x0, y0)
        g.DrawString(City, b, Brushes.Black, x4, y0)
        y0 += y1
        g.DrawString("State, Zip Code:", b, Brushes.Black, x0, y0)
        g.DrawString(StateZip, b, Brushes.Black, x4, y0)
        y0 += y2
        'Draw invoice amounts.
        g.DrawString("Amount of Purchase:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, PurchaseAmount), b, Brushes.Black, x3, y0)
        y0 += y1
        g.DrawString("Shipping Costs:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, TotalShippingCharges), b, Brushes.Black, x3, y0)
        y0 += y1
        g.DrawString("Additional Charges:", b, Brushes.Black, x0, y0)
        y0 += y1
        g.DrawString("Monogramming:", b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, monogrammingsum), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString("Telegram:", b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, telegramssum), b, Brushes.Black, x1, y0)
        y0 += y1
        g.DrawString("Gift Wrapping:", b, Brushes.Black, x2, y0)
        g.DrawString(String.Format(fmt, wrappingsum), b, Brushes.Black, x1, y0)
        g.DrawString("______", b, Brushes.Black, x1 + 20, y0 + y3)
        y0 += y1
        g.DrawString("Total Additional Charges:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, TotalAdditionalCharges), b, Brushes.Black, x3, y0)
        y0 += y1
        g.DrawString("Broadway Show Tickets:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, TotalBroadwayShows), b, Brushes.Black, x3, y0)
        g.DrawString("________", b, Brushes.Black, x3, y0 + y3)
        y0 += y1
        g.DrawString("Grand Total:", b, Brushes.Black, x0, y0)
        g.DrawString(String.Format(fmt, GrandTotal), b, Brushes.Black, x3, y0)
    End Sub
End Class