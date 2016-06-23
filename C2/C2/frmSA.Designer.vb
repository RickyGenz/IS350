<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSA
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
        Me.lblMDExpenses = New System.Windows.Forms.Label()
        Me.lblMDExpensesDesc = New System.Windows.Forms.Label()
        Me.txtMDExpenses = New System.Windows.Forms.TextBox()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCCW = New System.Windows.Forms.Button()
        Me.lblSlogan = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSpace = New System.Windows.Forms.Label()
        Me.lblTaxesPaid = New System.Windows.Forms.Label()
        Me.lblTaxesPaidDesc = New System.Windows.Forms.Label()
        Me.txtTaxesPaid = New System.Windows.Forms.TextBox()
        Me.lblInterestPaid = New System.Windows.Forms.Label()
        Me.lblInterestPaidDesc = New System.Windows.Forms.Label()
        Me.txtInterestPaid = New System.Windows.Forms.TextBox()
        Me.lblCharity = New System.Windows.Forms.Label()
        Me.lblCharityDesc = New System.Windows.Forms.Label()
        Me.txtCharity = New System.Windows.Forms.TextBox()
        Me.lblLosses = New System.Windows.Forms.Label()
        Me.lblLossesDesc = New System.Windows.Forms.Label()
        Me.txtLosses = New System.Windows.Forms.TextBox()
        Me.lblMiscExp = New System.Windows.Forms.Label()
        Me.lblMiscExpDesc = New System.Windows.Forms.Label()
        Me.txtMiscExp = New System.Windows.Forms.TextBox()
        Me.lblCCExp = New System.Windows.Forms.Label()
        Me.lblCCExpDesc = New System.Windows.Forms.Label()
        Me.txtCCExp = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalDesc = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMDExpenses
        '
        Me.lblMDExpenses.AutoSize = True
        Me.lblMDExpenses.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMDExpenses.Location = New System.Drawing.Point(12, 59)
        Me.lblMDExpenses.Name = "lblMDExpenses"
        Me.lblMDExpenses.Size = New System.Drawing.Size(176, 15)
        Me.lblMDExpenses.TabIndex = 0
        Me.lblMDExpenses.Text = "Medical and Dental Expenses:"
        '
        'lblMDExpensesDesc
        '
        Me.lblMDExpensesDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMDExpensesDesc.Location = New System.Drawing.Point(206, 59)
        Me.lblMDExpensesDesc.Name = "lblMDExpensesDesc"
        Me.lblMDExpensesDesc.Size = New System.Drawing.Size(165, 17)
        Me.lblMDExpensesDesc.TabIndex = 1
        Me.lblMDExpensesDesc.Text = "1. Medical and Dental Expenses"
        '
        'txtMDExpenses
        '
        Me.txtMDExpenses.AccessibleDescription = "Required"
        Me.txtMDExpenses.AccessibleName = "Medical and Dental Expenses"
        Me.txtMDExpenses.Location = New System.Drawing.Point(450, 59)
        Me.txtMDExpenses.Name = "txtMDExpenses"
        Me.txtMDExpenses.Size = New System.Drawing.Size(100, 20)
        Me.txtMDExpenses.TabIndex = 0
        Me.txtMDExpenses.Text = "1000"
        Me.txtMDExpenses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnReturn)
        Me.grpButtons.Controls.Add(Me.btnCompute)
        Me.grpButtons.Controls.Add(Me.btnExit)
        Me.grpButtons.Controls.Add(Me.btnCCW)
        Me.grpButtons.Location = New System.Drawing.Point(81, 491)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(405, 66)
        Me.grpButtons.TabIndex = 41
        Me.grpButtons.TabStop = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReturn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(215, 15)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 40)
        Me.btnReturn.TabIndex = 29
        Me.btnReturn.Text = "&Main Menu"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCompute.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(115, 15)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 40)
        Me.btnCompute.TabIndex = 28
        Me.btnCompute.Text = "Compute &Deductions"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(315, 17)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCCW
        '
        Me.btnCCW.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCCW.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCCW.Location = New System.Drawing.Point(15, 15)
        Me.btnCCW.Name = "btnCCW"
        Me.btnCCW.Size = New System.Drawing.Size(75, 40)
        Me.btnCCW.TabIndex = 26
        Me.btnCCW.Text = "&Child Care Worksheet"
        Me.btnCCW.UseVisualStyleBackColor = False
        '
        'lblSlogan
        '
        Me.lblSlogan.AutoSize = True
        Me.lblSlogan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlogan.Location = New System.Drawing.Point(117, 12)
        Me.lblSlogan.Name = "lblSlogan"
        Me.lblSlogan.Size = New System.Drawing.Size(129, 16)
        Me.lblSlogan.TabIndex = 43
        Me.lblSlogan.Text = "Itemized Deductions"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(91, 20)
        Me.lblTitle.TabIndex = 42
        Me.lblTitle.Text = "Schedule A"
        '
        'lblSpace
        '
        Me.lblSpace.AutoSize = True
        Me.lblSpace.Location = New System.Drawing.Point(13, 402)
        Me.lblSpace.Name = "lblSpace"
        Me.lblSpace.Size = New System.Drawing.Size(541, 13)
        Me.lblSpace.TabIndex = 44
        Me.lblSpace.Text = "_________________________________________________________________________________" & _
    "________"
        '
        'lblTaxesPaid
        '
        Me.lblTaxesPaid.AutoSize = True
        Me.lblTaxesPaid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxesPaid.Location = New System.Drawing.Point(93, 110)
        Me.lblTaxesPaid.Name = "lblTaxesPaid"
        Me.lblTaxesPaid.Size = New System.Drawing.Size(95, 15)
        Me.lblTaxesPaid.TabIndex = 45
        Me.lblTaxesPaid.Text = "Taxes You Paid:"
        '
        'lblTaxesPaidDesc
        '
        Me.lblTaxesPaidDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxesPaidDesc.Location = New System.Drawing.Point(207, 110)
        Me.lblTaxesPaidDesc.Name = "lblTaxesPaidDesc"
        Me.lblTaxesPaidDesc.Size = New System.Drawing.Size(212, 37)
        Me.lblTaxesPaidDesc.TabIndex = 46
        Me.lblTaxesPaidDesc.Text = "2. State/Local Income, Real Estate, and Personal Property Taxes"
        '
        'txtTaxesPaid
        '
        Me.txtTaxesPaid.AccessibleDescription = "Required"
        Me.txtTaxesPaid.AccessibleName = "Taxes You Paid"
        Me.txtTaxesPaid.Location = New System.Drawing.Point(450, 110)
        Me.txtTaxesPaid.Name = "txtTaxesPaid"
        Me.txtTaxesPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxesPaid.TabIndex = 1
        Me.txtTaxesPaid.Text = "2000"
        Me.txtTaxesPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInterestPaid
        '
        Me.lblInterestPaid.AutoSize = True
        Me.lblInterestPaid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestPaid.Location = New System.Drawing.Point(83, 161)
        Me.lblInterestPaid.Name = "lblInterestPaid"
        Me.lblInterestPaid.Size = New System.Drawing.Size(105, 15)
        Me.lblInterestPaid.TabIndex = 48
        Me.lblInterestPaid.Text = "Interest You Paid:"
        '
        'lblInterestPaidDesc
        '
        Me.lblInterestPaidDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestPaidDesc.Location = New System.Drawing.Point(206, 161)
        Me.lblInterestPaidDesc.Name = "lblInterestPaidDesc"
        Me.lblInterestPaidDesc.Size = New System.Drawing.Size(212, 37)
        Me.lblInterestPaidDesc.TabIndex = 49
        Me.lblInterestPaidDesc.Text = "3. Home Mortgage and Investment Interest"
        '
        'txtInterestPaid
        '
        Me.txtInterestPaid.AccessibleDescription = "Required"
        Me.txtInterestPaid.AccessibleName = "Interest You Paid"
        Me.txtInterestPaid.Location = New System.Drawing.Point(450, 161)
        Me.txtInterestPaid.Name = "txtInterestPaid"
        Me.txtInterestPaid.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestPaid.TabIndex = 2
        Me.txtInterestPaid.Text = "5750"
        Me.txtInterestPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCharity
        '
        Me.lblCharity.AutoSize = True
        Me.lblCharity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharity.Location = New System.Drawing.Point(93, 212)
        Me.lblCharity.Name = "lblCharity"
        Me.lblCharity.Size = New System.Drawing.Size(93, 15)
        Me.lblCharity.TabIndex = 51
        Me.lblCharity.Text = "Gifts to Charity:"
        '
        'lblCharityDesc
        '
        Me.lblCharityDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharityDesc.Location = New System.Drawing.Point(206, 212)
        Me.lblCharityDesc.Name = "lblCharityDesc"
        Me.lblCharityDesc.Size = New System.Drawing.Size(212, 37)
        Me.lblCharityDesc.TabIndex = 52
        Me.lblCharityDesc.Text = "4. Gifts by Cash or Check"
        '
        'txtCharity
        '
        Me.txtCharity.AccessibleDescription = "Required"
        Me.txtCharity.AccessibleName = "Gifts to Charity"
        Me.txtCharity.Location = New System.Drawing.Point(450, 212)
        Me.txtCharity.Name = "txtCharity"
        Me.txtCharity.Size = New System.Drawing.Size(100, 20)
        Me.txtCharity.TabIndex = 3
        Me.txtCharity.Text = "1000"
        Me.txtCharity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLosses
        '
        Me.lblLosses.AutoSize = True
        Me.lblLosses.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLosses.Location = New System.Drawing.Point(35, 263)
        Me.lblLosses.Name = "lblLosses"
        Me.lblLosses.Size = New System.Drawing.Size(151, 15)
        Me.lblLosses.TabIndex = 54
        Me.lblLosses.Text = "Casualty or Theft Losses:"
        '
        'lblLossesDesc
        '
        Me.lblLossesDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLossesDesc.Location = New System.Drawing.Point(206, 263)
        Me.lblLossesDesc.Name = "lblLossesDesc"
        Me.lblLossesDesc.Size = New System.Drawing.Size(212, 17)
        Me.lblLossesDesc.TabIndex = 55
        Me.lblLossesDesc.Text = "5. Casualty or Theft Losses"
        '
        'txtLosses
        '
        Me.txtLosses.AccessibleDescription = "Required"
        Me.txtLosses.AccessibleName = "Casualty or Theft Losses"
        Me.txtLosses.Location = New System.Drawing.Point(450, 263)
        Me.txtLosses.Name = "txtLosses"
        Me.txtLosses.Size = New System.Drawing.Size(100, 20)
        Me.txtLosses.TabIndex = 4
        Me.txtLosses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblMiscExp
        '
        Me.lblMiscExp.AutoSize = True
        Me.lblMiscExp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscExp.Location = New System.Drawing.Point(90, 314)
        Me.lblMiscExp.Name = "lblMiscExp"
        Me.lblMiscExp.Size = New System.Drawing.Size(99, 15)
        Me.lblMiscExp.TabIndex = 57
        Me.lblMiscExp.Text = "Misc. Expenses:"
        '
        'lblMiscExpDesc
        '
        Me.lblMiscExpDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscExpDesc.Location = New System.Drawing.Point(206, 314)
        Me.lblMiscExpDesc.Name = "lblMiscExpDesc"
        Me.lblMiscExpDesc.Size = New System.Drawing.Size(212, 37)
        Me.lblMiscExpDesc.TabIndex = 58
        Me.lblMiscExpDesc.Text = "6. Unreimbursed Employee Expenses, Tax Prep. Fees, and Misc. Expenses"
        '
        'txtMiscExp
        '
        Me.txtMiscExp.AccessibleDescription = "Required"
        Me.txtMiscExp.AccessibleName = "Misc. Expenses"
        Me.txtMiscExp.Location = New System.Drawing.Point(450, 314)
        Me.txtMiscExp.Name = "txtMiscExp"
        Me.txtMiscExp.Size = New System.Drawing.Size(100, 20)
        Me.txtMiscExp.TabIndex = 5
        Me.txtMiscExp.Text = "2500"
        Me.txtMiscExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCCExp
        '
        Me.lblCCExp.AutoSize = True
        Me.lblCCExp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCExp.Location = New System.Drawing.Point(59, 365)
        Me.lblCCExp.Name = "lblCCExp"
        Me.lblCCExp.Size = New System.Drawing.Size(127, 15)
        Me.lblCCExp.TabIndex = 60
        Me.lblCCExp.Text = "Child Care Expenses:"
        '
        'lblCCExpDesc
        '
        Me.lblCCExpDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCExpDesc.Location = New System.Drawing.Point(206, 365)
        Me.lblCCExpDesc.Name = "lblCCExpDesc"
        Me.lblCCExpDesc.Size = New System.Drawing.Size(212, 37)
        Me.lblCCExpDesc.TabIndex = 61
        Me.lblCCExpDesc.Text = "7. Total Child/Dependent Care Expenses from Worksheet"
        '
        'txtCCExp
        '
        Me.txtCCExp.AccessibleDescription = "Required"
        Me.txtCCExp.AccessibleName = "Child Care Expenses"
        Me.txtCCExp.Location = New System.Drawing.Point(450, 365)
        Me.txtCCExp.Name = "txtCCExp"
        Me.txtCCExp.Size = New System.Drawing.Size(100, 20)
        Me.txtCCExp.TabIndex = 62
        Me.txtCCExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(82, 437)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(101, 15)
        Me.lblTotal.TabIndex = 63
        Me.lblTotal.Text = "Total Deductions"
        '
        'lblTotalDesc
        '
        Me.lblTotalDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDesc.Location = New System.Drawing.Point(206, 437)
        Me.lblTotalDesc.Name = "lblTotalDesc"
        Me.lblTotalDesc.Size = New System.Drawing.Size(212, 37)
        Me.lblTotalDesc.TabIndex = 64
        Me.lblTotalDesc.Text = "8. Add the Amounts from Lines 1-7 for Total Itemized Deductions"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(450, 437)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 65
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 565)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotalDesc)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtCCExp)
        Me.Controls.Add(Me.lblCCExpDesc)
        Me.Controls.Add(Me.lblCCExp)
        Me.Controls.Add(Me.txtMiscExp)
        Me.Controls.Add(Me.lblMiscExpDesc)
        Me.Controls.Add(Me.lblMiscExp)
        Me.Controls.Add(Me.txtLosses)
        Me.Controls.Add(Me.lblLossesDesc)
        Me.Controls.Add(Me.lblLosses)
        Me.Controls.Add(Me.txtCharity)
        Me.Controls.Add(Me.lblCharityDesc)
        Me.Controls.Add(Me.lblCharity)
        Me.Controls.Add(Me.txtInterestPaid)
        Me.Controls.Add(Me.lblInterestPaidDesc)
        Me.Controls.Add(Me.lblInterestPaid)
        Me.Controls.Add(Me.txtTaxesPaid)
        Me.Controls.Add(Me.lblTaxesPaidDesc)
        Me.Controls.Add(Me.lblTaxesPaid)
        Me.Controls.Add(Me.lblSpace)
        Me.Controls.Add(Me.lblSlogan)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.txtMDExpenses)
        Me.Controls.Add(Me.lblMDExpensesDesc)
        Me.Controls.Add(Me.lblMDExpenses)
        Me.Name = "frmSA"
        Me.Text = "Schedule A - Itemized Deductions"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMDExpenses As System.Windows.Forms.Label
    Friend WithEvents lblMDExpensesDesc As System.Windows.Forms.Label
    Friend WithEvents txtMDExpenses As System.Windows.Forms.TextBox
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnCCW As System.Windows.Forms.Button
    Friend WithEvents lblSlogan As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSpace As System.Windows.Forms.Label
    Friend WithEvents lblTaxesPaid As System.Windows.Forms.Label
    Friend WithEvents lblTaxesPaidDesc As System.Windows.Forms.Label
    Friend WithEvents txtTaxesPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblInterestPaid As System.Windows.Forms.Label
    Friend WithEvents lblInterestPaidDesc As System.Windows.Forms.Label
    Friend WithEvents txtInterestPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblCharity As System.Windows.Forms.Label
    Friend WithEvents lblCharityDesc As System.Windows.Forms.Label
    Friend WithEvents txtCharity As System.Windows.Forms.TextBox
    Friend WithEvents lblLosses As System.Windows.Forms.Label
    Friend WithEvents lblLossesDesc As System.Windows.Forms.Label
    Friend WithEvents txtLosses As System.Windows.Forms.TextBox
    Friend WithEvents lblMiscExp As System.Windows.Forms.Label
    Friend WithEvents lblMiscExpDesc As System.Windows.Forms.Label
    Friend WithEvents txtMiscExp As System.Windows.Forms.TextBox
    Friend WithEvents lblCCExp As System.Windows.Forms.Label
    Friend WithEvents lblCCExpDesc As System.Windows.Forms.Label
    Friend WithEvents txtCCExp As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalDesc As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
End Class
