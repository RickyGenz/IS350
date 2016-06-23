Public Class frmBroad
    Private Sub chkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox1.CheckedChanged
        'If CheckBox 1 is checked then it becomes visible, if it is unchecked it is hidden.
        If chkBox1.Checked = True Then
            txtBoxQTY1.Visible = True
            txtBoxExtension1.Visible = True
        Else
            txtBoxQTY1.Visible = False
            txtBoxExtension1.Visible = False
            txtBoxQTY1.Clear()
            txtBoxExtension1.Clear()
        End If
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'Close the form after user ensures they wanted to quit.
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Quit Confirmation") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub chkBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox2.CheckedChanged
        'If CheckBox 2 is checked then it becomes visible, if it is unchecked it is hidden.
        If chkBox2.Checked = True Then
            txtBoxQTY2.Visible = True
            txtBoxExtension2.Visible = True
        Else
            txtBoxQTY2.Visible = False
            txtBoxExtension2.Visible = False
            txtBoxQTY2.Clear()
            txtBoxExtension2.Clear()
        End If
    End Sub
    Private Sub chkBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox3.CheckedChanged
        'If CheckBox 3 is checked then it becomes visible, if it is unchecked it is hidden.
        If chkBox3.Checked = True Then
            txtBoxQTY3.Visible = True
            txtBoxExtension3.Visible = True
        Else
            txtBoxQTY3.Visible = False
            txtBoxExtension3.Visible = False
            txtBoxQTY3.Clear()
            txtBoxExtension3.Clear()
        End If
    End Sub
    Private Sub chkBox4_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox4.CheckedChanged
        'If CheckBox 4 is checked then it becomes visible, if it is unchecked it is hidden.
        If chkBox4.Checked = True Then
            txtBoxQTY4.Visible = True
            txtBoxExtension4.Visible = True
        Else
            txtBoxQTY4.Visible = False
            txtBoxExtension4.Visible = False
            txtBoxQTY4.Clear()
            txtBoxExtension4.Clear()
        End If
    End Sub
    Private Sub chkBox5_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox5.CheckedChanged
        'If CheckBox 5 is checked then it becomes visible, if it is unchecked it is hidden.
        If chkBox5.Checked = True Then
            txtBoxQTY5.Visible = True
            txtBoxExtension5.Visible = True
        Else
            txtBoxExtension5.Visible = False
            txtBoxQTY5.Visible = False
            txtBoxQTY5.Clear()
            txtBoxExtension5.Clear()
        End If
    End Sub
    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        'Calculates total price of tickets in extension box 1 by multiplying quantity times price.
        If chkBox1.Checked Then
            If IsNumeric(txtBoxQTY1.Text) = False Then
                MsgBox("Quantity must be a number.", , "Error")
                txtBoxQTY1.Clear()
                Exit Sub
            Else
                txtBoxExtension1.Text = FormatNumber(txtBoxQTY1.Text * 29.95)
            End If
        End If
        'Calculates total price of tickets in extension box 2 by multiplying quantity times price. 
        If chkBox2.Checked Then
            If IsNumeric(txtBoxQTY2.Text) = False Then
                MsgBox("Quantity must be a number.", , "Error")
                txtBoxQTY2.Clear()
                Exit Sub
            Else
                txtBoxExtension2.Text = FormatNumber(txtBoxQTY2.Text * 37.95)
            End If
        End If
        'Calculates total price of tickets in extension box 3 by multiplying quantity times price. 
        If chkBox3.Checked Then
            If IsNumeric(txtBoxQTY3.Text) = False Then
                MsgBox("Quantity must be a number.", , "Error")
                txtBoxQTY3.Clear()
                Exit Sub
            Else
                txtBoxExtension3.Text = FormatNumber(txtBoxQTY3.Text * 49.95)
            End If
        End If
        'Calculates total price of tickets in extension box 4 by multiplying quantity times price. 
        If chkBox4.Checked Then
            If IsNumeric(txtBoxQTY4.Text) = False Then
                MsgBox("Quantity must be a number.", , "Error")
                txtBoxQTY4.Clear()
                Exit Sub
            Else
                txtBoxExtension4.Text = FormatNumber(txtBoxQTY4.Text * 29.95)
            End If
        End If
        'Calculates total price of tickets in extension box 5 by multiplying quantity times price. 
        If chkBox5.Checked Then
            If IsNumeric(txtBoxQTY5.Text) = False Then
                MsgBox("Quantity must be a number.", , "Error")
                txtBoxQTY5.Clear()
                Exit Sub
            Else
                txtBoxExtension5.Text = FormatNumber(txtBoxQTY5.Text * 42.95)
            End If
        End If
        'Calculates total price of all tickets in Subtotal Textbox.
        Dim total As Double
        Dim x1 As Double = Val(txtBoxExtension1.Text)
        Dim x2 As Double = Val(txtBoxExtension2.Text)
        Dim x3 As Double = Val(txtBoxExtension3.Text)
        Dim x4 As Double = Val(txtBoxExtension4.Text)
        Dim x5 As Double = Val(txtBoxExtension5.Text)
        total = x1 + x2 + x3 + x4 + x5
        txtBoxSubtotal.Text = FormatNumber(total)
        'Gives 10% discount if customer buys at least one of each ticket.
        If IsNumeric(txtBoxQTY1.Text) = True And
           IsNumeric(txtBoxQTY2.Text) = True And
           IsNumeric(txtBoxQTY3.Text) = True And
           IsNumeric(txtBoxQTY4.Text) = True And
           IsNumeric(txtBoxQTY5.Text) = True Then
            txtBoxDiscounts.Text = (0.1 * txtBoxSubtotal.Text)
            MsgBox("You're entitled to the 10% discount!", , "Congratulations!")
        Else : txtBoxDiscounts.Text = ""
        End If
        'Gives 5% Senior discount if checkbox is checked.
        If chkBox6.Checked = True Then
            txtBoxDiscounts.Text = FormatNumber(0.05 * txtBoxSubtotal.Text)
        Else
            txtBoxDiscounts.Clear()
        End If
        'Gives 15% discount if customer checks senior discount box and orders at least one of each ticket.
        If IsNumeric(txtBoxQTY1.Text) = True And
           IsNumeric(txtBoxQTY2.Text) = True And
           IsNumeric(txtBoxQTY3.Text) = True And
           IsNumeric(txtBoxQTY4.Text) = True And
           IsNumeric(txtBoxQTY5.Text) = True And
           chkBox6.Checked = True Then
            txtBoxDiscounts.Text = FormatNumber(0.15 * txtBoxSubtotal.Text)
        End If
        'Gives 10% Discount if Senior Discount is unchecked and customer orders at least one of each ticket.
        If chkBox6.Checked = False And
           IsNumeric(txtBoxQTY1.Text) = True And
           IsNumeric(txtBoxQTY2.Text) = True And
           IsNumeric(txtBoxQTY3.Text) = True And
           IsNumeric(txtBoxQTY4.Text) = True And
           IsNumeric(txtBoxQTY5.Text) = True Then
            txtBoxDiscounts.Text = FormatNumber(0.1 * txtBoxSubtotal.Text)
        End If
        'Adds service fees of $2.50 times quantity of tickets selected.
        Dim boxQ1, boxQ2, boxQ3, boxQ4, boxQ5 As Double
        boxQ1 = Val(txtBoxQTY1.Text)
        boxQ2 = Val(txtBoxQTY2.Text)
        boxQ3 = Val(txtBoxQTY3.Text)
        boxQ4 = Val(txtBoxQTY4.Text)
        boxQ5 = Val(txtBoxQTY5.Text)
        txtBoxServiceFees.Text = FormatNumber((boxQ1 + boxQ2 + boxQ3 + boxQ4 + boxQ5) * 2.5)
        'Total cost of tickets after adding service fees and subtracting discounts.
        Dim y As Double = Val(txtBoxSubtotal.Text)
        Dim z As Double = Val(txtBoxServiceFees.Text)
        Dim q As Double = Val(txtBoxDiscounts.Text)
        txtBoxTotalCost.Text = FormatNumber(y + (z - q))
        'Calculates cost of tax at 7.35%.
        Dim n As Double = Val(txtBoxTotalCost.Text)
        txtBoxTax.Text = FormatNumber(0.0735 * n)
        'Grand total is total costs plus tax.
        Dim l As Double = Val(txtBoxTax.Text)
        Dim o As Double = Val(txtBoxTotalCost.Text)
        txtBoxGrandTotal.Text = FormatNumber(o + l)
        TotalBroadwayShows = txtBoxGrandTotal.Text
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Alerts customer if they try to return to main form without having computed grand total.
        If IsNumeric(txtBoxGrandTotal.Text) = False Then
            MsgBox("Grand Total is blank!", , "Return")
        Else
            TotalBroadwayShows = Math.Round(TotalBroadwayShows, 2)
            Close()
        End If
    End Sub
    Private Sub chkBox6_CheckedChanged(sender As Object, e As EventArgs) Handles chkBox6.CheckedChanged
        'Clears grand total textbox if senior discount is unchecked or checked after already being computed.
        If chkBox6.Checked = False Then
            txtBoxGrandTotal.Clear()
        End If
        If chkBox6.Checked = True Then
            txtBoxGrandTotal.Clear()
        End If
    End Sub
End Class