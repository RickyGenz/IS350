Public Class frmShip
    Private Sub frmShip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display purchase amount global variable locally.
        txtPurchaseAmount.Text = PurchaseAmount
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all fields and local variables.
        rdoUPS.Checked = False
        rdoUSPS.Checked = False
        rdoFedEx.Checked = False
        rdoDHL.Checked = False
        chkOvernight.Checked = False
        chkSaturday.Checked = False
        chkSignature.Checked = False
        chkInsurance.Checked = False
        shippingCost = 0
        txtShippingCost.Clear()
        deliveryCost = 0
        txtDeliveryCost.Clear()
        txtTotalShippingCharges.Clear()
    End Sub
    Private Sub btnComputeTotal_Click(sender As Object, e As EventArgs) Handles btnComputeTotal.Click
        'Compute the total shipping costs.
        txtShippingCost.Text = FormatCurrency(ShippingCost)
        txtDeliveryCost.Text = FormatCurrency(DeliveryCost)
        TotalShippingCharges = ShippingCost + DeliveryCost
        txtTotalShippingCharges.Text = FormatCurrency(TotalShippingCharges)
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Save shipping charges as a global variable and then close.
        TotalShippingCharges = Math.Round(TotalShippingCharges, 2)
        Me.Close()
    End Sub
    Private Sub rdoDHL_rdoFedEx_rdoUSPS_rdoUPS_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDHL.CheckedChanged, rdoFedEx.CheckedChanged, rdoUSPS.CheckedChanged, rdoUPS.CheckedChanged
        'Recalculate the shipping costs each time a radio button is clicked.
        txtShippingCost.Clear()
        ShippingCost = 0
        If rdoDHL.Checked Then
            ShippingCost = 49.95
        End If
        If rdoFedEx.Checked Then
            ShippingCost = 32.55
        End If
        If rdoUSPS.Checked Then
            ShippingCost = 19.95
        End If
        If rdoUPS.Checked Then
            ShippingCost = 18.95
        End If
        txtShippingCost.Text = ShippingCost
    End Sub
    Private Sub chkInsurance_CheckedChanged(sender As Object, e As EventArgs) Handles chkInsurance.CheckedChanged
        'Check insurance and set the insurance variable.
        If chkInsurance.Checked Then
            Insurance = InputBox("Please enter the amount of insurance you wish for your order.", "Insurance")
            If Insurance = "" Then
                MsgBox("Insurance was not found.", MsgBoxStyle.Information, "Error")
                chkInsurance.Checked = False
                Exit Sub
            ElseIf IsNumeric(Insurance) = False Then
                MsgBox("Insurance is not numeric.", MsgBoxStyle.Information, "Error")
                chkInsurance.Checked = False
                Exit Sub
            ElseIf Insurance < 1 Or Insurance > 100000 Then
                MsgBox("Insurance must be between 1 and 100000.", MsgBoxStyle.Information, "Error")
                chkInsurance.Checked = False
                Exit Sub
            End If
            lblInsurance.Text = "Your package is insured for " & FormatCurrency(Insurance) & "."
            lblInsurance.Visible = True
        Else
            lblInsurance.Visible = False
            Insurance = 0
        End If
    End Sub
    Private Sub chkSignature_chkSaturday_chkOvernight_CheckedChanged(sender As Object, e As EventArgs) Handles chkSignature.CheckedChanged, chkSaturday.CheckedChanged, chkInsurance.CheckedChanged, chkOvernight.CheckedChanged
        'Recalculate the delivery costs each time a delivery option is clicked.
        txtDeliveryCost.Clear()
        DeliveryCost = 0
        If chkSignature.Checked Then
            DeliveryCost += 9.95
        End If
        If chkSaturday.Checked Then
            DeliveryCost += 12.95
        End If
        If chkInsurance.Checked Then
            DeliveryCost += Insurance * 0.03
        End If
        If chkOvernight.Checked Then
            DeliveryCost += 23.95
        End If
        txtDeliveryCost.Text = DeliveryCost
    End Sub
End Class