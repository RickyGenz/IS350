<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDeliveryCost = New System.Windows.Forms.MaskedTextBox()
        Me.txtTotalShippingCharges = New System.Windows.Forms.MaskedTextBox()
        Me.txtShippingCost = New System.Windows.Forms.MaskedTextBox()
        Me.txtPurchaseAmount = New System.Windows.Forms.MaskedTextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnComputeTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblSpace = New System.Windows.Forms.Label()
        Me.lblDeliveryOptions = New System.Windows.Forms.Label()
        Me.lblDeliveryCost = New System.Windows.Forms.Label()
        Me.lblShippingCost = New System.Windows.Forms.Label()
        Me.lblPurchaseAmount = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblDeliveryOptionsBorder = New System.Windows.Forms.Label()
        Me.lblShippingChoices = New System.Windows.Forms.Label()
        Me.lblTotalShippingCharges = New System.Windows.Forms.Label()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblShippingChoicesBorder = New System.Windows.Forms.Label()
        Me.rdoUPS = New System.Windows.Forms.RadioButton()
        Me.rdoUSPS = New System.Windows.Forms.RadioButton()
        Me.rdoFedEx = New System.Windows.Forms.RadioButton()
        Me.rdoDHL = New System.Windows.Forms.RadioButton()
        Me.chkOvernight = New System.Windows.Forms.CheckBox()
        Me.chkSaturday = New System.Windows.Forms.CheckBox()
        Me.chkInsurance = New System.Windows.Forms.CheckBox()
        Me.chkSignature = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtDeliveryCost
        '
        Me.txtDeliveryCost.Location = New System.Drawing.Point(144, 198)
        Me.txtDeliveryCost.Name = "txtDeliveryCost"
        Me.txtDeliveryCost.ReadOnly = True
        Me.txtDeliveryCost.Size = New System.Drawing.Size(100, 20)
        Me.txtDeliveryCost.TabIndex = 68
        Me.txtDeliveryCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalShippingCharges
        '
        Me.txtTotalShippingCharges.Location = New System.Drawing.Point(144, 235)
        Me.txtTotalShippingCharges.Name = "txtTotalShippingCharges"
        Me.txtTotalShippingCharges.ReadOnly = True
        Me.txtTotalShippingCharges.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalShippingCharges.TabIndex = 67
        Me.txtTotalShippingCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShippingCost
        '
        Me.txtShippingCost.Location = New System.Drawing.Point(144, 173)
        Me.txtShippingCost.Name = "txtShippingCost"
        Me.txtShippingCost.ReadOnly = True
        Me.txtShippingCost.Size = New System.Drawing.Size(100, 20)
        Me.txtShippingCost.TabIndex = 66
        Me.txtShippingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurchaseAmount
        '
        Me.txtPurchaseAmount.Location = New System.Drawing.Point(144, 41)
        Me.txtPurchaseAmount.Name = "txtPurchaseAmount"
        Me.txtPurchaseAmount.ReadOnly = True
        Me.txtPurchaseAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchaseAmount.TabIndex = 64
        Me.txtPurchaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReturn.Location = New System.Drawing.Point(494, 195)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(90, 50)
        Me.btnReturn.TabIndex = 58
        Me.btnReturn.Text = "&Return to Main Form"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnComputeTotal
        '
        Me.btnComputeTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnComputeTotal.Location = New System.Drawing.Point(494, 129)
        Me.btnComputeTotal.Name = "btnComputeTotal"
        Me.btnComputeTotal.Size = New System.Drawing.Size(90, 50)
        Me.btnComputeTotal.TabIndex = 56
        Me.btnComputeTotal.Text = "Compute &Total"
        Me.btnComputeTotal.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnClear.Location = New System.Drawing.Point(494, 60)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 50)
        Me.btnClear.TabIndex = 54
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblSpace
        '
        Me.lblSpace.AutoSize = True
        Me.lblSpace.Location = New System.Drawing.Point(7, 219)
        Me.lblSpace.Name = "lblSpace"
        Me.lblSpace.Size = New System.Drawing.Size(241, 13)
        Me.lblSpace.TabIndex = 48
        Me.lblSpace.Text = "_______________________________________"
        '
        'lblDeliveryOptions
        '
        Me.lblDeliveryOptions.AutoSize = True
        Me.lblDeliveryOptions.Location = New System.Drawing.Point(286, 167)
        Me.lblDeliveryOptions.Name = "lblDeliveryOptions"
        Me.lblDeliveryOptions.Size = New System.Drawing.Size(87, 13)
        Me.lblDeliveryOptions.TabIndex = 45
        Me.lblDeliveryOptions.Text = "Delivery Options:"
        '
        'lblDeliveryCost
        '
        Me.lblDeliveryCost.AutoSize = True
        Me.lblDeliveryCost.Location = New System.Drawing.Point(7, 205)
        Me.lblDeliveryCost.Name = "lblDeliveryCost"
        Me.lblDeliveryCost.Size = New System.Drawing.Size(72, 13)
        Me.lblDeliveryCost.TabIndex = 41
        Me.lblDeliveryCost.Text = "Delivery Cost:"
        '
        'lblShippingCost
        '
        Me.lblShippingCost.AutoSize = True
        Me.lblShippingCost.Location = New System.Drawing.Point(7, 180)
        Me.lblShippingCost.Name = "lblShippingCost"
        Me.lblShippingCost.Size = New System.Drawing.Size(75, 13)
        Me.lblShippingCost.TabIndex = 40
        Me.lblShippingCost.Text = "Shipping Cost:"
        '
        'lblPurchaseAmount
        '
        Me.lblPurchaseAmount.AutoSize = True
        Me.lblPurchaseAmount.Location = New System.Drawing.Point(7, 48)
        Me.lblPurchaseAmount.Name = "lblPurchaseAmount"
        Me.lblPurchaseAmount.Size = New System.Drawing.Size(94, 13)
        Me.lblPurchaseAmount.TabIndex = 39
        Me.lblPurchaseAmount.Text = "Purchase Amount:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(6, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(315, 20)
        Me.lblTitle.TabIndex = 38
        Me.lblTitle.Text = "Compute Your Shipping Charges Here"
        '
        'lblDeliveryOptionsBorder
        '
        Me.lblDeliveryOptionsBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeliveryOptionsBorder.Location = New System.Drawing.Point(274, 173)
        Me.lblDeliveryOptionsBorder.Name = "lblDeliveryOptionsBorder"
        Me.lblDeliveryOptionsBorder.Size = New System.Drawing.Size(200, 117)
        Me.lblDeliveryOptionsBorder.TabIndex = 63
        '
        'lblShippingChoices
        '
        Me.lblShippingChoices.AutoSize = True
        Me.lblShippingChoices.Location = New System.Drawing.Point(286, 35)
        Me.lblShippingChoices.Name = "lblShippingChoices"
        Me.lblShippingChoices.Size = New System.Drawing.Size(92, 13)
        Me.lblShippingChoices.TabIndex = 72
        Me.lblShippingChoices.Text = "Shipping Choices:"
        '
        'lblTotalShippingCharges
        '
        Me.lblTotalShippingCharges.AutoSize = True
        Me.lblTotalShippingCharges.Location = New System.Drawing.Point(7, 242)
        Me.lblTotalShippingCharges.Name = "lblTotalShippingCharges"
        Me.lblTotalShippingCharges.Size = New System.Drawing.Size(120, 13)
        Me.lblTotalShippingCharges.TabIndex = 82
        Me.lblTotalShippingCharges.Text = "Total Shipping Charges:"
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsurance.Location = New System.Drawing.Point(7, 72)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(136, 13)
        Me.lblInsurance.TabIndex = 83
        Me.lblInsurance.Text = "Your package is insured for"
        Me.lblInsurance.Visible = False
        '
        'lblShippingChoicesBorder
        '
        Me.lblShippingChoicesBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShippingChoicesBorder.Location = New System.Drawing.Point(274, 41)
        Me.lblShippingChoicesBorder.Name = "lblShippingChoicesBorder"
        Me.lblShippingChoicesBorder.Size = New System.Drawing.Size(200, 119)
        Me.lblShippingChoicesBorder.TabIndex = 81
        '
        'rdoUPS
        '
        Me.rdoUPS.AutoSize = True
        Me.rdoUPS.Location = New System.Drawing.Point(289, 60)
        Me.rdoUPS.Name = "rdoUPS"
        Me.rdoUPS.Size = New System.Drawing.Size(89, 17)
        Me.rdoUPS.TabIndex = 84
        Me.rdoUPS.Text = "UPS ($18.95)"
        Me.rdoUPS.UseVisualStyleBackColor = True
        '
        'rdoUSPS
        '
        Me.rdoUSPS.AutoSize = True
        Me.rdoUSPS.Location = New System.Drawing.Point(289, 83)
        Me.rdoUSPS.Name = "rdoUSPS"
        Me.rdoUSPS.Size = New System.Drawing.Size(152, 17)
        Me.rdoUSPS.TabIndex = 85
        Me.rdoUSPS.Text = "USPS Priority Mail ($19.95)"
        Me.rdoUSPS.UseVisualStyleBackColor = True
        '
        'rdoFedEx
        '
        Me.rdoFedEx.AutoSize = True
        Me.rdoFedEx.Location = New System.Drawing.Point(289, 106)
        Me.rdoFedEx.Name = "rdoFedEx"
        Me.rdoFedEx.Size = New System.Drawing.Size(142, 17)
        Me.rdoFedEx.TabIndex = 86
        Me.rdoFedEx.Text = "Federal Express ($32.55)"
        Me.rdoFedEx.UseVisualStyleBackColor = True
        '
        'rdoDHL
        '
        Me.rdoDHL.AutoSize = True
        Me.rdoDHL.Location = New System.Drawing.Point(289, 129)
        Me.rdoDHL.Name = "rdoDHL"
        Me.rdoDHL.Size = New System.Drawing.Size(156, 17)
        Me.rdoDHL.TabIndex = 87
        Me.rdoDHL.Text = "DHL (International) ($49.95)"
        Me.rdoDHL.UseVisualStyleBackColor = True
        '
        'chkOvernight
        '
        Me.chkOvernight.AutoSize = True
        Me.chkOvernight.Location = New System.Drawing.Point(289, 196)
        Me.chkOvernight.Name = "chkOvernight"
        Me.chkOvernight.Size = New System.Drawing.Size(114, 17)
        Me.chkOvernight.TabIndex = 88
        Me.chkOvernight.Text = "Overnight ($23.95)"
        Me.chkOvernight.UseVisualStyleBackColor = True
        '
        'chkSaturday
        '
        Me.chkSaturday.AutoSize = True
        Me.chkSaturday.Location = New System.Drawing.Point(289, 219)
        Me.chkSaturday.Name = "chkSaturday"
        Me.chkSaturday.Size = New System.Drawing.Size(151, 17)
        Me.chkSaturday.TabIndex = 89
        Me.chkSaturday.Text = "Saturday Delivery ($12.95)"
        Me.chkSaturday.UseVisualStyleBackColor = True
        '
        'chkInsurance
        '
        Me.chkInsurance.AutoSize = True
        Me.chkInsurance.Location = New System.Drawing.Point(289, 242)
        Me.chkInsurance.Name = "chkInsurance"
        Me.chkInsurance.Size = New System.Drawing.Size(184, 17)
        Me.chkInsurance.TabIndex = 90
        Me.chkInsurance.Text = "Insurance (3% of Declared Value)"
        Me.chkInsurance.UseVisualStyleBackColor = True
        '
        'chkSignature
        '
        Me.chkSignature.AutoSize = True
        Me.chkSignature.Location = New System.Drawing.Point(289, 265)
        Me.chkSignature.Name = "chkSignature"
        Me.chkSignature.Size = New System.Drawing.Size(153, 17)
        Me.chkSignature.TabIndex = 91
        Me.chkSignature.Text = "Signature Required ($9.95)"
        Me.chkSignature.UseVisualStyleBackColor = True
        '
        'frmShip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 300)
        Me.Controls.Add(Me.chkSignature)
        Me.Controls.Add(Me.chkInsurance)
        Me.Controls.Add(Me.chkSaturday)
        Me.Controls.Add(Me.chkOvernight)
        Me.Controls.Add(Me.rdoDHL)
        Me.Controls.Add(Me.rdoFedEx)
        Me.Controls.Add(Me.rdoUSPS)
        Me.Controls.Add(Me.rdoUPS)
        Me.Controls.Add(Me.lblInsurance)
        Me.Controls.Add(Me.lblTotalShippingCharges)
        Me.Controls.Add(Me.lblShippingChoices)
        Me.Controls.Add(Me.lblShippingChoicesBorder)
        Me.Controls.Add(Me.txtDeliveryCost)
        Me.Controls.Add(Me.txtTotalShippingCharges)
        Me.Controls.Add(Me.txtShippingCost)
        Me.Controls.Add(Me.txtPurchaseAmount)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnComputeTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblSpace)
        Me.Controls.Add(Me.lblDeliveryOptions)
        Me.Controls.Add(Me.lblDeliveryCost)
        Me.Controls.Add(Me.lblShippingCost)
        Me.Controls.Add(Me.lblPurchaseAmount)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblDeliveryOptionsBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmShip"
        Me.Text = "Shipping Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDeliveryCost As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTotalShippingCharges As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtShippingCost As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPurchaseAmount As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnComputeTotal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblSpace As System.Windows.Forms.Label
    Friend WithEvents lblDeliveryOptions As System.Windows.Forms.Label
    Friend WithEvents lblDeliveryCost As System.Windows.Forms.Label
    Friend WithEvents lblShippingCost As System.Windows.Forms.Label
    Friend WithEvents lblPurchaseAmount As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblDeliveryOptionsBorder As System.Windows.Forms.Label
    Friend WithEvents lblShippingChoices As System.Windows.Forms.Label
    Friend WithEvents lblTotalShippingCharges As System.Windows.Forms.Label
    Friend WithEvents lblInsurance As System.Windows.Forms.Label
    Friend WithEvents lblShippingChoicesBorder As System.Windows.Forms.Label
    Friend WithEvents rdoUPS As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUSPS As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFedEx As System.Windows.Forms.RadioButton
    Friend WithEvents rdoDHL As System.Windows.Forms.RadioButton
    Friend WithEvents chkOvernight As System.Windows.Forms.CheckBox
    Friend WithEvents chkSaturday As System.Windows.Forms.CheckBox
    Friend WithEvents chkInsurance As System.Windows.Forms.CheckBox
    Friend WithEvents chkSignature As System.Windows.Forms.CheckBox
End Class
