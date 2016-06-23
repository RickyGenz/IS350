<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSB
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
        Me.txtInterestPayerOne = New System.Windows.Forms.TextBox()
        Me.txtInterestPayerTwo = New System.Windows.Forms.TextBox()
        Me.txtInterestTotal = New System.Windows.Forms.TextBox()
        Me.txtInterestExcludable = New System.Windows.Forms.TextBox()
        Me.txtInterestSubtotal = New System.Windows.Forms.TextBox()
        Me.txtInterestAmountTwo = New System.Windows.Forms.TextBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblPartOneDesc = New System.Windows.Forms.Label()
        Me.lblSpace = New System.Windows.Forms.Label()
        Me.lblSlogan = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.txtInterestAmountOne = New System.Windows.Forms.TextBox()
        Me.lblInterestPayers = New System.Windows.Forms.Label()
        Me.lblPartOne = New System.Windows.Forms.Label()
        Me.lblPartTwoDesc = New System.Windows.Forms.Label()
        Me.lblPartTwo = New System.Windows.Forms.Label()
        Me.lblExcludable = New System.Windows.Forms.Label()
        Me.lblInterestIncome = New System.Windows.Forms.Label()
        Me.lblDividendPayers = New System.Windows.Forms.Label()
        Me.lblDividendIncome = New System.Windows.Forms.Label()
        Me.txtDividendPayerOne = New System.Windows.Forms.TextBox()
        Me.txtDividendPayerTwo = New System.Windows.Forms.TextBox()
        Me.txtDividendAmountTwo = New System.Windows.Forms.TextBox()
        Me.txtDividendAmountOne = New System.Windows.Forms.TextBox()
        Me.txtDividendTotal = New System.Windows.Forms.TextBox()
        Me.lblInterestAmounts = New System.Windows.Forms.Label()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInterestPayerOne
        '
        Me.txtInterestPayerOne.Location = New System.Drawing.Point(132, 71)
        Me.txtInterestPayerOne.Name = "txtInterestPayerOne"
        Me.txtInterestPayerOne.Size = New System.Drawing.Size(187, 20)
        Me.txtInterestPayerOne.TabIndex = 93
        Me.txtInterestPayerOne.Text = "Bank of America"
        '
        'txtInterestPayerTwo
        '
        Me.txtInterestPayerTwo.Location = New System.Drawing.Point(132, 97)
        Me.txtInterestPayerTwo.Name = "txtInterestPayerTwo"
        Me.txtInterestPayerTwo.Size = New System.Drawing.Size(187, 20)
        Me.txtInterestPayerTwo.TabIndex = 90
        Me.txtInterestPayerTwo.Text = "iSharesBank Mutual Fund"
        '
        'txtInterestTotal
        '
        Me.txtInterestTotal.Location = New System.Drawing.Point(347, 209)
        Me.txtInterestTotal.Name = "txtInterestTotal"
        Me.txtInterestTotal.ReadOnly = True
        Me.txtInterestTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestTotal.TabIndex = 84
        Me.txtInterestTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterestExcludable
        '
        Me.txtInterestExcludable.AccessibleDescription = "Required"
        Me.txtInterestExcludable.AccessibleName = "Exculdable Amounts"
        Me.txtInterestExcludable.Location = New System.Drawing.Point(347, 162)
        Me.txtInterestExcludable.Name = "txtInterestExcludable"
        Me.txtInterestExcludable.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestExcludable.TabIndex = 81
        Me.txtInterestExcludable.Text = "34.75"
        Me.txtInterestExcludable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterestSubtotal
        '
        Me.txtInterestSubtotal.Location = New System.Drawing.Point(347, 136)
        Me.txtInterestSubtotal.Name = "txtInterestSubtotal"
        Me.txtInterestSubtotal.ReadOnly = True
        Me.txtInterestSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestSubtotal.TabIndex = 78
        Me.txtInterestSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtInterestAmountTwo
        '
        Me.txtInterestAmountTwo.AccessibleDescription = "Required"
        Me.txtInterestAmountTwo.AccessibleName = "Interest Payer Two Amount"
        Me.txtInterestAmountTwo.Location = New System.Drawing.Point(347, 97)
        Me.txtInterestAmountTwo.Name = "txtInterestAmountTwo"
        Me.txtInterestAmountTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestAmountTwo.TabIndex = 75
        Me.txtInterestAmountTwo.Text = "532.56"
        Me.txtInterestAmountTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSubtotal
        '
        Me.lblSubtotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.Location = New System.Drawing.Point(179, 136)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(212, 20)
        Me.lblSubtotal.TabIndex = 74
        Me.lblSubtotal.Text = "Subtotal"
        '
        'lblPartOneDesc
        '
        Me.lblPartOneDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartOneDesc.Location = New System.Drawing.Point(36, 66)
        Me.lblPartOneDesc.Name = "lblPartOneDesc"
        Me.lblPartOneDesc.Size = New System.Drawing.Size(67, 52)
        Me.lblPartOneDesc.TabIndex = 73
        Me.lblPartOneDesc.Text = "Interest Income"
        '
        'lblSpace
        '
        Me.lblSpace.AutoSize = True
        Me.lblSpace.Location = New System.Drawing.Point(13, 232)
        Me.lblSpace.Name = "lblSpace"
        Me.lblSpace.Size = New System.Drawing.Size(439, 13)
        Me.lblSpace.TabIndex = 72
        Me.lblSpace.Text = "________________________________________________________________________"
        '
        'lblSlogan
        '
        Me.lblSlogan.AutoSize = True
        Me.lblSlogan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlogan.Location = New System.Drawing.Point(117, 12)
        Me.lblSlogan.Name = "lblSlogan"
        Me.lblSlogan.Size = New System.Drawing.Size(181, 16)
        Me.lblSlogan.TabIndex = 71
        Me.lblSlogan.Text = "Interest and Dividend Income"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(91, 20)
        Me.lblTitle.TabIndex = 70
        Me.lblTitle.Text = "Schedule B"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReturn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(114, 17)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 40)
        Me.btnReturn.TabIndex = 29
        Me.btnReturn.Text = "&Main Menu"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(14, 17)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 40)
        Me.btnCalculate.TabIndex = 28
        Me.btnCalculate.Text = "&Calculate Income"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(214, 19)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnReturn)
        Me.grpButtons.Controls.Add(Me.btnCalculate)
        Me.grpButtons.Controls.Add(Me.btnExit)
        Me.grpButtons.Location = New System.Drawing.Point(81, 391)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(302, 66)
        Me.grpButtons.TabIndex = 69
        Me.grpButtons.TabStop = False
        '
        'txtInterestAmountOne
        '
        Me.txtInterestAmountOne.AccessibleDescription = "Required"
        Me.txtInterestAmountOne.AccessibleName = "Interest Payer One Amount"
        Me.txtInterestAmountOne.Location = New System.Drawing.Point(347, 71)
        Me.txtInterestAmountOne.Name = "txtInterestAmountOne"
        Me.txtInterestAmountOne.Size = New System.Drawing.Size(100, 20)
        Me.txtInterestAmountOne.TabIndex = 68
        Me.txtInterestAmountOne.Text = "123.5"
        Me.txtInterestAmountOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInterestPayers
        '
        Me.lblInterestPayers.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestPayers.Location = New System.Drawing.Point(117, 51)
        Me.lblInterestPayers.Name = "lblInterestPayers"
        Me.lblInterestPayers.Size = New System.Drawing.Size(165, 17)
        Me.lblInterestPayers.TabIndex = 67
        Me.lblInterestPayers.Text = "1. List Name(s) of Payer(s):"
        '
        'lblPartOne
        '
        Me.lblPartOne.AutoSize = True
        Me.lblPartOne.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartOne.Location = New System.Drawing.Point(13, 51)
        Me.lblPartOne.Name = "lblPartOne"
        Me.lblPartOne.Size = New System.Drawing.Size(37, 15)
        Me.lblPartOne.TabIndex = 66
        Me.lblPartOne.Text = "Part I"
        '
        'lblPartTwoDesc
        '
        Me.lblPartTwoDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartTwoDesc.Location = New System.Drawing.Point(36, 270)
        Me.lblPartTwoDesc.Name = "lblPartTwoDesc"
        Me.lblPartTwoDesc.Size = New System.Drawing.Size(67, 52)
        Me.lblPartTwoDesc.TabIndex = 95
        Me.lblPartTwoDesc.Text = "Dividend Income"
        '
        'lblPartTwo
        '
        Me.lblPartTwo.AutoSize = True
        Me.lblPartTwo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartTwo.Location = New System.Drawing.Point(13, 255)
        Me.lblPartTwo.Name = "lblPartTwo"
        Me.lblPartTwo.Size = New System.Drawing.Size(40, 15)
        Me.lblPartTwo.TabIndex = 94
        Me.lblPartTwo.Text = "Part II"
        '
        'lblExcludable
        '
        Me.lblExcludable.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExcludable.Location = New System.Drawing.Point(179, 162)
        Me.lblExcludable.Name = "lblExcludable"
        Me.lblExcludable.Size = New System.Drawing.Size(139, 37)
        Me.lblExcludable.TabIndex = 96
        Me.lblExcludable.Text = "Exculdable Amounts from EE Savings Bonds"
        '
        'lblInterestIncome
        '
        Me.lblInterestIncome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestIncome.Location = New System.Drawing.Point(117, 209)
        Me.lblInterestIncome.Name = "lblInterestIncome"
        Me.lblInterestIncome.Size = New System.Drawing.Size(212, 20)
        Me.lblInterestIncome.TabIndex = 97
        Me.lblInterestIncome.Text = "2. Reportable Interest Income"
        '
        'lblDividendPayers
        '
        Me.lblDividendPayers.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDividendPayers.Location = New System.Drawing.Point(117, 255)
        Me.lblDividendPayers.Name = "lblDividendPayers"
        Me.lblDividendPayers.Size = New System.Drawing.Size(165, 17)
        Me.lblDividendPayers.TabIndex = 98
        Me.lblDividendPayers.Text = "3. List Name(s) of Payer(s):"
        '
        'lblDividendIncome
        '
        Me.lblDividendIncome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDividendIncome.Location = New System.Drawing.Point(117, 341)
        Me.lblDividendIncome.Name = "lblDividendIncome"
        Me.lblDividendIncome.Size = New System.Drawing.Size(212, 37)
        Me.lblDividendIncome.TabIndex = 99
        Me.lblDividendIncome.Text = "4. Reportable Dividend Income"
        '
        'txtDividendPayerOne
        '
        Me.txtDividendPayerOne.Location = New System.Drawing.Point(132, 275)
        Me.txtDividendPayerOne.Name = "txtDividendPayerOne"
        Me.txtDividendPayerOne.Size = New System.Drawing.Size(187, 20)
        Me.txtDividendPayerOne.TabIndex = 103
        Me.txtDividendPayerOne.Text = "IGT Corporation"
        '
        'txtDividendPayerTwo
        '
        Me.txtDividendPayerTwo.Location = New System.Drawing.Point(132, 301)
        Me.txtDividendPayerTwo.Name = "txtDividendPayerTwo"
        Me.txtDividendPayerTwo.Size = New System.Drawing.Size(186, 20)
        Me.txtDividendPayerTwo.TabIndex = 102
        '
        'txtDividendAmountTwo
        '
        Me.txtDividendAmountTwo.AccessibleDescription = "Required"
        Me.txtDividendAmountTwo.AccessibleName = "Dividend Payer Two Amount"
        Me.txtDividendAmountTwo.Location = New System.Drawing.Point(348, 301)
        Me.txtDividendAmountTwo.Name = "txtDividendAmountTwo"
        Me.txtDividendAmountTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtDividendAmountTwo.TabIndex = 101
        Me.txtDividendAmountTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDividendAmountOne
        '
        Me.txtDividendAmountOne.AccessibleDescription = "Required"
        Me.txtDividendAmountOne.AccessibleName = "Dividend Payer One Amount"
        Me.txtDividendAmountOne.Location = New System.Drawing.Point(347, 275)
        Me.txtDividendAmountOne.Name = "txtDividendAmountOne"
        Me.txtDividendAmountOne.Size = New System.Drawing.Size(100, 20)
        Me.txtDividendAmountOne.TabIndex = 100
        Me.txtDividendAmountOne.Text = "65.95"
        Me.txtDividendAmountOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDividendTotal
        '
        Me.txtDividendTotal.Location = New System.Drawing.Point(348, 341)
        Me.txtDividendTotal.Name = "txtDividendTotal"
        Me.txtDividendTotal.ReadOnly = True
        Me.txtDividendTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtDividendTotal.TabIndex = 104
        Me.txtDividendTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblInterestAmounts
        '
        Me.lblInterestAmounts.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestAmounts.Location = New System.Drawing.Point(345, 52)
        Me.lblInterestAmounts.Name = "lblInterestAmounts"
        Me.lblInterestAmounts.Size = New System.Drawing.Size(102, 17)
        Me.lblInterestAmounts.TabIndex = 105
        Me.lblInterestAmounts.Text = "Amount"
        '
        'frmSB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 466)
        Me.Controls.Add(Me.lblInterestAmounts)
        Me.Controls.Add(Me.txtDividendTotal)
        Me.Controls.Add(Me.txtDividendPayerOne)
        Me.Controls.Add(Me.txtDividendPayerTwo)
        Me.Controls.Add(Me.txtDividendAmountTwo)
        Me.Controls.Add(Me.txtDividendAmountOne)
        Me.Controls.Add(Me.lblDividendIncome)
        Me.Controls.Add(Me.lblDividendPayers)
        Me.Controls.Add(Me.lblInterestIncome)
        Me.Controls.Add(Me.lblExcludable)
        Me.Controls.Add(Me.lblPartTwoDesc)
        Me.Controls.Add(Me.lblPartTwo)
        Me.Controls.Add(Me.txtInterestPayerOne)
        Me.Controls.Add(Me.txtInterestPayerTwo)
        Me.Controls.Add(Me.txtInterestTotal)
        Me.Controls.Add(Me.txtInterestExcludable)
        Me.Controls.Add(Me.txtInterestSubtotal)
        Me.Controls.Add(Me.txtInterestAmountTwo)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.lblPartOneDesc)
        Me.Controls.Add(Me.lblSpace)
        Me.Controls.Add(Me.lblSlogan)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.txtInterestAmountOne)
        Me.Controls.Add(Me.lblInterestPayers)
        Me.Controls.Add(Me.lblPartOne)
        Me.Name = "frmSB"
        Me.Text = "Schedule B - Interest and Dividend Income"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInterestPayerOne As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestPayerTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestExcludable As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtInterestAmountTwo As System.Windows.Forms.TextBox
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblPartOneDesc As System.Windows.Forms.Label
    Friend WithEvents lblSpace As System.Windows.Forms.Label
    Friend WithEvents lblSlogan As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents txtInterestAmountOne As System.Windows.Forms.TextBox
    Friend WithEvents lblInterestPayers As System.Windows.Forms.Label
    Friend WithEvents lblPartOne As System.Windows.Forms.Label
    Friend WithEvents lblPartTwoDesc As System.Windows.Forms.Label
    Friend WithEvents lblPartTwo As System.Windows.Forms.Label
    Friend WithEvents lblExcludable As System.Windows.Forms.Label
    Friend WithEvents lblInterestIncome As System.Windows.Forms.Label
    Friend WithEvents lblDividendPayers As System.Windows.Forms.Label
    Friend WithEvents lblDividendIncome As System.Windows.Forms.Label
    Friend WithEvents txtDividendPayerOne As System.Windows.Forms.TextBox
    Friend WithEvents txtDividendPayerTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtDividendAmountTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtDividendAmountOne As System.Windows.Forms.TextBox
    Friend WithEvents txtDividendTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblInterestAmounts As System.Windows.Forms.Label
End Class
