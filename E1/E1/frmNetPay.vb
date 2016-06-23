Public Class frmNetPay
    Function IsInput() As Boolean
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
        Next
        Return True
    End Function
    Private Sub frmNetPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display Name and SSN on form load.
        lblName.Text = FullName
        lblSSN.Text = SSN
    End Sub
    Private Sub btnComputeNetPay_Click(sender As Object, e As EventArgs) Handles btnComputeNetPay.Click
        'Calculate Gross and Net Weekly Pay. Format all values to currency.
        If IsInput() Then
            Hours = CInt(txtHours.Text)
            Rate = CDec(txtRate.Text)
            Select Case Hours
                Case 1 To 40
                    Gross = Hours * Rate
                Case 41 To 60
                    Gross = (40 * Rate) + ((Hours - 40) * Rate * 1.5)
                Case Is > 60
                    Gross = (40 * Rate) + (20 * Rate * 1.5) + ((Hours - 60) * Rate * 2)
            End Select
            txtGross.Text = FormatCurrency(Gross)
            txtHealthPlanCosts.Text = FormatCurrency(HPCosts)
            txtAdditionalDeductions.Text = FormatCurrency(ADCosts)
            NetPay = Gross - HPCosts - ADCosts
            txtNetPay.Text = FormatCurrency(NetPay)
        End If
    End Sub
    Private Sub btnReturnToMainForm_Click(sender As Object, e As EventArgs) Handles btnReturnToMainForm.Click
        'Return to Main Form
        Me.Close()
    End Sub
    Private Sub HealthPlanDeductions(sender As Object, e As EventArgs) Handles rdoHPOfNevada.CheckedChanged, rdoKaiserPermanente.CheckedChanged, rdoBlueCross.CheckedChanged, rdoHomeTownHealth.CheckedChanged
        'Recalculate the Health Plan Deduction costs each time a radio button is clicked.
        HPCosts = 0
        If rdoHPOfNevada.Checked Then
            HPCosts = 62.5
        End If
        If rdoKaiserPermanente.Checked Then
            HPCosts = 35.6
        End If
        If rdoBlueCross.Checked Then
            HPCosts = 75.25
        End If
        If rdoHomeTownHealth.Checked Then
            HPCosts = 58.85
        End If
    End Sub
    Private Sub AdditionalDeductions(sender As Object, e As EventArgs) Handles chkUnionDues.CheckedChanged, chkUnitedWay.CheckedChanged, chkParking.CheckedChanged, chkRetirement.CheckedChanged
        'Recalculate the Additional Deductions costs each time a checkbox is clicked.
        ADCosts = 0
        If chkUnionDues.Checked Then
            ADCosts += 15.5
        End If
        If chkUnitedWay.Checked Then
            ADCosts += 25.5
        End If
        If chkParking.Checked Then
            ADCosts += 20.0
        End If
        If chkRetirement.Checked Then
            ADCosts += 80.0
        End If
        If chkUnionDues.Checked And chkUnitedWay.Checked And chkParking.Checked And chkRetirement.Checked Then ADCosts += -40
    End Sub
End Class