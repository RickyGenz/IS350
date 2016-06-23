<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCCW
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
        Me.lblPartTwoDesc = New System.Windows.Forms.Label()
        Me.lblPartTwo = New System.Windows.Forms.Label()
        Me.txtPayeeTwoPaid = New System.Windows.Forms.TextBox()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.lblPayee = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtPayeeOnePaid = New System.Windows.Forms.TextBox()
        Me.lblSpaceOne = New System.Windows.Forms.Label()
        Me.lblPartOneDesc = New System.Windows.Forms.Label()
        Me.txtTotalPaid = New System.Windows.Forms.TextBox()
        Me.lblPartOne = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtLastFive = New System.Windows.Forms.TextBox()
        Me.txtFirstFive = New System.Windows.Forms.TextBox()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.txtExpFive = New System.Windows.Forms.TextBox()
        Me.txtLastFour = New System.Windows.Forms.TextBox()
        Me.txtFirstFour = New System.Windows.Forms.TextBox()
        Me.txtFour = New System.Windows.Forms.TextBox()
        Me.lblExp = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.txtExpFour = New System.Windows.Forms.TextBox()
        Me.lblSpaceTwo = New System.Windows.Forms.Label()
        Me.txtExpSum = New System.Windows.Forms.TextBox()
        Me.lblSix = New System.Windows.Forms.Label()
        Me.txtSmaller = New System.Windows.Forms.TextBox()
        Me.lblSeven = New System.Windows.Forms.Label()
        Me.txtCCExp = New System.Windows.Forms.TextBox()
        Me.lblNine = New System.Windows.Forms.Label()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.lblEight = New System.Windows.Forms.Label()
        Me.grpPercentages = New System.Windows.Forms.GroupBox()
        Me.rdo18 = New System.Windows.Forms.RadioButton()
        Me.rdo20 = New System.Windows.Forms.RadioButton()
        Me.rdo22 = New System.Windows.Forms.RadioButton()
        Me.rdo27 = New System.Windows.Forms.RadioButton()
        Me.rdo30 = New System.Windows.Forms.RadioButton()
        Me.lblPayeeOne = New System.Windows.Forms.Label()
        Me.lblPayeeOneName = New System.Windows.Forms.Label()
        Me.lblPayeeTwoName = New System.Windows.Forms.Label()
        Me.lblPayeeTwo = New System.Windows.Forms.Label()
        Me.lblPayeeOneSSN = New System.Windows.Forms.Label()
        Me.lblPayeeTwoSSN = New System.Windows.Forms.Label()
        Me.grpButtons.SuspendLayout()
        Me.grpPercentages.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPartTwoDesc
        '
        Me.lblPartTwoDesc.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPartTwoDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartTwoDesc.Location = New System.Drawing.Point(56, 203)
        Me.lblPartTwoDesc.Name = "lblPartTwoDesc"
        Me.lblPartTwoDesc.Size = New System.Drawing.Size(211, 15)
        Me.lblPartTwoDesc.TabIndex = 292
        Me.lblPartTwoDesc.Text = "Child/Dependent Information"
        '
        'lblPartTwo
        '
        Me.lblPartTwo.AutoSize = True
        Me.lblPartTwo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartTwo.Location = New System.Drawing.Point(13, 203)
        Me.lblPartTwo.Name = "lblPartTwo"
        Me.lblPartTwo.Size = New System.Drawing.Size(40, 15)
        Me.lblPartTwo.TabIndex = 289
        Me.lblPartTwo.Text = "Part II"
        '
        'txtPayeeTwoPaid
        '
        Me.txtPayeeTwoPaid.Location = New System.Drawing.Point(364, 134)
        Me.txtPayeeTwoPaid.Name = "txtPayeeTwoPaid"
        Me.txtPayeeTwoPaid.Size = New System.Drawing.Size(162, 20)
        Me.txtPayeeTwoPaid.TabIndex = 283
        Me.txtPayeeTwoPaid.Text = "1760"
        Me.txtPayeeTwoPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPaid
        '
        Me.lblPaid.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.Location = New System.Drawing.Point(364, 77)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(162, 15)
        Me.lblPaid.TabIndex = 277
        Me.lblPaid.Text = "Amount Paid by this Payee"
        '
        'lblSSN
        '
        Me.lblSSN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSN.Location = New System.Drawing.Point(215, 77)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(143, 15)
        Me.lblSSN.TabIndex = 275
        Me.lblSSN.Text = "Social Security Number"
        '
        'lblPayee
        '
        Me.lblPayee.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayee.Location = New System.Drawing.Point(46, 77)
        Me.lblPayee.Name = "lblPayee"
        Me.lblPayee.Size = New System.Drawing.Size(163, 15)
        Me.lblPayee.TabIndex = 273
        Me.lblPayee.Text = "Name of the Payee"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReturn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(114, 17)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 40)
        Me.btnReturn.TabIndex = 29
        Me.btnReturn.Text = "&Return"
        Me.btnReturn.UseVisualStyleBackColor = False
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
        'txtPayeeOnePaid
        '
        Me.txtPayeeOnePaid.Location = New System.Drawing.Point(364, 108)
        Me.txtPayeeOnePaid.Name = "txtPayeeOnePaid"
        Me.txtPayeeOnePaid.Size = New System.Drawing.Size(162, 20)
        Me.txtPayeeOnePaid.TabIndex = 272
        Me.txtPayeeOnePaid.Text = "4165"
        Me.txtPayeeOnePaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSpaceOne
        '
        Me.lblSpaceOne.AutoSize = True
        Me.lblSpaceOne.Location = New System.Drawing.Point(14, 92)
        Me.lblSpaceOne.Name = "lblSpaceOne"
        Me.lblSpaceOne.Size = New System.Drawing.Size(517, 13)
        Me.lblSpaceOne.TabIndex = 270
        Me.lblSpaceOne.Text = "_________________________________________________________________________________" & _
    "____"
        '
        'lblPartOneDesc
        '
        Me.lblPartOneDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartOneDesc.Location = New System.Drawing.Point(56, 52)
        Me.lblPartOneDesc.Name = "lblPartOneDesc"
        Me.lblPartOneDesc.Size = New System.Drawing.Size(224, 15)
        Me.lblPartOneDesc.TabIndex = 265
        Me.lblPartOneDesc.Text = "Payee Information"
        '
        'txtTotalPaid
        '
        Me.txtTotalPaid.Location = New System.Drawing.Point(364, 160)
        Me.txtTotalPaid.Name = "txtTotalPaid"
        Me.txtTotalPaid.ReadOnly = True
        Me.txtTotalPaid.Size = New System.Drawing.Size(162, 20)
        Me.txtTotalPaid.TabIndex = 261
        Me.txtTotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPartOne
        '
        Me.lblPartOne.AutoSize = True
        Me.lblPartOne.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartOne.Location = New System.Drawing.Point(13, 52)
        Me.lblPartOne.Name = "lblPartOne"
        Me.lblPartOne.Size = New System.Drawing.Size(37, 15)
        Me.lblPartOne.TabIndex = 259
        Me.lblPartOne.Text = "Part I"
        '
        'lblThree
        '
        Me.lblThree.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThree.Location = New System.Drawing.Point(16, 160)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(342, 20)
        Me.lblThree.TabIndex = 260
        Me.lblThree.Text = "3. Total Paid"
        Me.lblThree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnReturn)
        Me.grpButtons.Controls.Add(Me.btnCalculate)
        Me.grpButtons.Controls.Add(Me.btnExit)
        Me.grpButtons.Location = New System.Drawing.Point(121, 631)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(302, 66)
        Me.grpButtons.TabIndex = 262
        Me.grpButtons.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(14, 17)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 40)
        Me.btnCalculate.TabIndex = 28
        Me.btnCalculate.Text = "&Calculate Expenses"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(163, 20)
        Me.lblTitle.TabIndex = 263
        Me.lblTitle.Text = "Child Care Worksheet"
        '
        'txtLastFive
        '
        Me.txtLastFive.Location = New System.Drawing.Point(215, 284)
        Me.txtLastFive.Name = "txtLastFive"
        Me.txtLastFive.Size = New System.Drawing.Size(143, 20)
        Me.txtLastFive.TabIndex = 306
        '
        'txtFirstFive
        '
        Me.txtFirstFive.Location = New System.Drawing.Point(46, 284)
        Me.txtFirstFive.Name = "txtFirstFive"
        Me.txtFirstFive.Size = New System.Drawing.Size(163, 20)
        Me.txtFirstFive.TabIndex = 305
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(16, 284)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.ReadOnly = True
        Me.txtFive.Size = New System.Drawing.Size(24, 20)
        Me.txtFive.TabIndex = 304
        Me.txtFive.Text = "5"
        Me.txtFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtExpFive
        '
        Me.txtExpFive.Location = New System.Drawing.Point(364, 284)
        Me.txtExpFive.Name = "txtExpFive"
        Me.txtExpFive.Size = New System.Drawing.Size(162, 20)
        Me.txtExpFive.TabIndex = 303
        Me.txtExpFive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLastFour
        '
        Me.txtLastFour.Location = New System.Drawing.Point(215, 258)
        Me.txtLastFour.Name = "txtLastFour"
        Me.txtLastFour.Size = New System.Drawing.Size(143, 20)
        Me.txtLastFour.TabIndex = 302
        Me.txtLastFour.Text = "Sample"
        '
        'txtFirstFour
        '
        Me.txtFirstFour.Location = New System.Drawing.Point(46, 258)
        Me.txtFirstFour.Name = "txtFirstFour"
        Me.txtFirstFour.Size = New System.Drawing.Size(163, 20)
        Me.txtFirstFour.TabIndex = 301
        Me.txtFirstFour.Text = "Marjorie"
        '
        'txtFour
        '
        Me.txtFour.Location = New System.Drawing.Point(16, 258)
        Me.txtFour.Name = "txtFour"
        Me.txtFour.ReadOnly = True
        Me.txtFour.Size = New System.Drawing.Size(24, 20)
        Me.txtFour.TabIndex = 300
        Me.txtFour.Text = "4"
        Me.txtFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblExp
        '
        Me.lblExp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExp.Location = New System.Drawing.Point(364, 227)
        Me.lblExp.Name = "lblExp"
        Me.lblExp.Size = New System.Drawing.Size(162, 15)
        Me.lblExp.TabIndex = 299
        Me.lblExp.Text = "Qualified Expenses"
        '
        'lblLast
        '
        Me.lblLast.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.Location = New System.Drawing.Point(215, 227)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(143, 15)
        Me.lblLast.TabIndex = 298
        Me.lblLast.Text = "Last Name"
        '
        'lblFirst
        '
        Me.lblFirst.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(46, 227)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(163, 15)
        Me.lblFirst.TabIndex = 297
        Me.lblFirst.Text = "First Name"
        '
        'txtExpFour
        '
        Me.txtExpFour.Location = New System.Drawing.Point(364, 258)
        Me.txtExpFour.Name = "txtExpFour"
        Me.txtExpFour.Size = New System.Drawing.Size(162, 20)
        Me.txtExpFour.TabIndex = 296
        Me.txtExpFour.Text = "4235"
        Me.txtExpFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSpaceTwo
        '
        Me.lblSpaceTwo.AutoSize = True
        Me.lblSpaceTwo.Location = New System.Drawing.Point(14, 242)
        Me.lblSpaceTwo.Name = "lblSpaceTwo"
        Me.lblSpaceTwo.Size = New System.Drawing.Size(517, 13)
        Me.lblSpaceTwo.TabIndex = 295
        Me.lblSpaceTwo.Text = "_________________________________________________________________________________" & _
    "____"
        '
        'txtExpSum
        '
        Me.txtExpSum.Location = New System.Drawing.Point(364, 310)
        Me.txtExpSum.Name = "txtExpSum"
        Me.txtExpSum.ReadOnly = True
        Me.txtExpSum.Size = New System.Drawing.Size(162, 20)
        Me.txtExpSum.TabIndex = 294
        Me.txtExpSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSix
        '
        Me.lblSix.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSix.Location = New System.Drawing.Point(16, 310)
        Me.lblSix.Name = "lblSix"
        Me.lblSix.Size = New System.Drawing.Size(342, 20)
        Me.lblSix.TabIndex = 293
        Me.lblSix.Text = "6. Sum of Qualified Expenses"
        Me.lblSix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSmaller
        '
        Me.txtSmaller.Location = New System.Drawing.Point(364, 336)
        Me.txtSmaller.Name = "txtSmaller"
        Me.txtSmaller.ReadOnly = True
        Me.txtSmaller.Size = New System.Drawing.Size(162, 20)
        Me.txtSmaller.TabIndex = 308
        Me.txtSmaller.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSeven
        '
        Me.lblSeven.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeven.Location = New System.Drawing.Point(16, 336)
        Me.lblSeven.Name = "lblSeven"
        Me.lblSeven.Size = New System.Drawing.Size(342, 32)
        Me.lblSeven.TabIndex = 307
        Me.lblSeven.Text = "7. Enter the Smaller of Total Paid Expenses (Line 3) or Qualified Expenses"
        Me.lblSeven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCCExp
        '
        Me.txtCCExp.Location = New System.Drawing.Point(364, 417)
        Me.txtCCExp.Name = "txtCCExp"
        Me.txtCCExp.ReadOnly = True
        Me.txtCCExp.Size = New System.Drawing.Size(162, 20)
        Me.txtCCExp.TabIndex = 312
        Me.txtCCExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNine
        '
        Me.lblNine.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNine.Location = New System.Drawing.Point(16, 417)
        Me.lblNine.Name = "lblNine"
        Me.lblNine.Size = New System.Drawing.Size(342, 47)
        Me.lblNine.TabIndex = 311
        Me.lblNine.Text = "9. Allowable Child Care Expenses. Multiply the appropriate percentage times the a" & _
    "mount in Line 7 and enter this amount on Line 7 in Schedule A"
        Me.lblNine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(364, 375)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.ReadOnly = True
        Me.txtPercentage.Size = New System.Drawing.Size(162, 20)
        Me.txtPercentage.TabIndex = 310
        Me.txtPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEight
        '
        Me.lblEight.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEight.Location = New System.Drawing.Point(16, 375)
        Me.lblEight.Name = "lblEight"
        Me.lblEight.Size = New System.Drawing.Size(342, 33)
        Me.lblEight.TabIndex = 309
        Me.lblEight.Text = "8. Select an option from the choices to the right to enter the appropriate percen" & _
    "tages"
        Me.lblEight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpPercentages
        '
        Me.grpPercentages.Controls.Add(Me.rdo18)
        Me.grpPercentages.Controls.Add(Me.rdo20)
        Me.grpPercentages.Controls.Add(Me.rdo22)
        Me.grpPercentages.Controls.Add(Me.rdo27)
        Me.grpPercentages.Controls.Add(Me.rdo30)
        Me.grpPercentages.Location = New System.Drawing.Point(19, 476)
        Me.grpPercentages.Name = "grpPercentages"
        Me.grpPercentages.Size = New System.Drawing.Size(163, 142)
        Me.grpPercentages.TabIndex = 313
        Me.grpPercentages.TabStop = False
        Me.grpPercentages.Text = "Applicable Percentage"
        '
        'rdo18
        '
        Me.rdo18.AutoSize = True
        Me.rdo18.Location = New System.Drawing.Point(13, 111)
        Me.rdo18.Name = "rdo18"
        Me.rdo18.Size = New System.Drawing.Size(116, 17)
        Me.rdo18.TabIndex = 4
        Me.rdo18.TabStop = True
        Me.rdo18.Text = "Over $75,000: 18%"
        Me.rdo18.UseVisualStyleBackColor = True
        '
        'rdo20
        '
        Me.rdo20.AutoSize = True
        Me.rdo20.Location = New System.Drawing.Point(13, 88)
        Me.rdo20.Name = "rdo20"
        Me.rdo20.Size = New System.Drawing.Size(138, 17)
        Me.rdo20.TabIndex = 3
        Me.rdo20.TabStop = True
        Me.rdo20.Text = "$55,000 - $75,000: 20%"
        Me.rdo20.UseVisualStyleBackColor = True
        '
        'rdo22
        '
        Me.rdo22.AutoSize = True
        Me.rdo22.Location = New System.Drawing.Point(13, 65)
        Me.rdo22.Name = "rdo22"
        Me.rdo22.Size = New System.Drawing.Size(138, 17)
        Me.rdo22.TabIndex = 2
        Me.rdo22.TabStop = True
        Me.rdo22.Text = "$40,000 - $54,999: 22%"
        Me.rdo22.UseVisualStyleBackColor = True
        '
        'rdo27
        '
        Me.rdo27.AutoSize = True
        Me.rdo27.Location = New System.Drawing.Point(13, 42)
        Me.rdo27.Name = "rdo27"
        Me.rdo27.Size = New System.Drawing.Size(138, 17)
        Me.rdo27.TabIndex = 1
        Me.rdo27.TabStop = True
        Me.rdo27.Text = "$20,001 - $39,999: 27%"
        Me.rdo27.UseVisualStyleBackColor = True
        '
        'rdo30
        '
        Me.rdo30.AutoSize = True
        Me.rdo30.Location = New System.Drawing.Point(13, 19)
        Me.rdo30.Name = "rdo30"
        Me.rdo30.Size = New System.Drawing.Size(111, 17)
        Me.rdo30.TabIndex = 0
        Me.rdo30.TabStop = True
        Me.rdo30.Text = "$0 - $20,000: 30%"
        Me.rdo30.UseVisualStyleBackColor = True
        '
        'lblPayeeOne
        '
        Me.lblPayeeOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayeeOne.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayeeOne.Location = New System.Drawing.Point(16, 108)
        Me.lblPayeeOne.Name = "lblPayeeOne"
        Me.lblPayeeOne.Size = New System.Drawing.Size(24, 20)
        Me.lblPayeeOne.TabIndex = 314
        Me.lblPayeeOne.Text = "1"
        Me.lblPayeeOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayeeOneName
        '
        Me.lblPayeeOneName.AccessibleName = "Payee One Name"
        Me.lblPayeeOneName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayeeOneName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayeeOneName.Location = New System.Drawing.Point(46, 108)
        Me.lblPayeeOneName.Name = "lblPayeeOneName"
        Me.lblPayeeOneName.Size = New System.Drawing.Size(163, 20)
        Me.lblPayeeOneName.TabIndex = 315
        Me.lblPayeeOneName.Text = "John Q. Sample"
        Me.lblPayeeOneName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayeeTwoName
        '
        Me.lblPayeeTwoName.AccessibleName = "Payee Two Name"
        Me.lblPayeeTwoName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayeeTwoName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayeeTwoName.Location = New System.Drawing.Point(46, 134)
        Me.lblPayeeTwoName.Name = "lblPayeeTwoName"
        Me.lblPayeeTwoName.Size = New System.Drawing.Size(163, 20)
        Me.lblPayeeTwoName.TabIndex = 316
        Me.lblPayeeTwoName.Text = "Shelia S. Sample"
        Me.lblPayeeTwoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayeeTwo
        '
        Me.lblPayeeTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayeeTwo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayeeTwo.Location = New System.Drawing.Point(16, 134)
        Me.lblPayeeTwo.Name = "lblPayeeTwo"
        Me.lblPayeeTwo.Size = New System.Drawing.Size(24, 20)
        Me.lblPayeeTwo.TabIndex = 317
        Me.lblPayeeTwo.Text = "2"
        Me.lblPayeeTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPayeeOneSSN
        '
        Me.lblPayeeOneSSN.AccessibleName = "Payee One SSN"
        Me.lblPayeeOneSSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayeeOneSSN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayeeOneSSN.Location = New System.Drawing.Point(215, 108)
        Me.lblPayeeOneSSN.Name = "lblPayeeOneSSN"
        Me.lblPayeeOneSSN.Size = New System.Drawing.Size(143, 20)
        Me.lblPayeeOneSSN.TabIndex = 318
        Me.lblPayeeOneSSN.Text = "123-45-6789"
        Me.lblPayeeOneSSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayeeTwoSSN
        '
        Me.lblPayeeTwoSSN.AccessibleName = "Payee Two SSN"
        Me.lblPayeeTwoSSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayeeTwoSSN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayeeTwoSSN.Location = New System.Drawing.Point(215, 134)
        Me.lblPayeeTwoSSN.Name = "lblPayeeTwoSSN"
        Me.lblPayeeTwoSSN.Size = New System.Drawing.Size(143, 20)
        Me.lblPayeeTwoSSN.TabIndex = 319
        Me.lblPayeeTwoSSN.Text = "234-56-7890"
        Me.lblPayeeTwoSSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmCCW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 708)
        Me.Controls.Add(Me.grpPercentages)
        Me.Controls.Add(Me.txtCCExp)
        Me.Controls.Add(Me.lblNine)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.lblEight)
        Me.Controls.Add(Me.txtSmaller)
        Me.Controls.Add(Me.lblSeven)
        Me.Controls.Add(Me.txtLastFive)
        Me.Controls.Add(Me.txtFirstFive)
        Me.Controls.Add(Me.txtFive)
        Me.Controls.Add(Me.txtExpFive)
        Me.Controls.Add(Me.txtLastFour)
        Me.Controls.Add(Me.txtFirstFour)
        Me.Controls.Add(Me.txtFour)
        Me.Controls.Add(Me.lblExp)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtExpFour)
        Me.Controls.Add(Me.lblSpaceTwo)
        Me.Controls.Add(Me.txtExpSum)
        Me.Controls.Add(Me.lblSix)
        Me.Controls.Add(Me.lblPartTwoDesc)
        Me.Controls.Add(Me.lblPartTwo)
        Me.Controls.Add(Me.txtPayeeTwoPaid)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.lblPayee)
        Me.Controls.Add(Me.txtPayeeOnePaid)
        Me.Controls.Add(Me.lblSpaceOne)
        Me.Controls.Add(Me.lblPartOneDesc)
        Me.Controls.Add(Me.txtTotalPaid)
        Me.Controls.Add(Me.lblPartOne)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblPayeeOne)
        Me.Controls.Add(Me.lblPayeeOneName)
        Me.Controls.Add(Me.lblPayeeTwoName)
        Me.Controls.Add(Me.lblPayeeTwo)
        Me.Controls.Add(Me.lblPayeeOneSSN)
        Me.Controls.Add(Me.lblPayeeTwoSSN)
        Me.Name = "frmCCW"
        Me.Text = "Child Care Worksheet"
        Me.grpButtons.ResumeLayout(False)
        Me.grpPercentages.ResumeLayout(False)
        Me.grpPercentages.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPartTwoDesc As System.Windows.Forms.Label
    Friend WithEvents lblPartTwo As System.Windows.Forms.Label
    Friend WithEvents txtPayeeTwoPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents lblPayee As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtPayeeOnePaid As System.Windows.Forms.TextBox
    Friend WithEvents lblSpaceOne As System.Windows.Forms.Label
    Friend WithEvents lblPartOneDesc As System.Windows.Forms.Label
    Friend WithEvents txtTotalPaid As System.Windows.Forms.TextBox
    Friend WithEvents lblPartOne As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtLastFive As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstFive As System.Windows.Forms.TextBox
    Friend WithEvents txtFive As System.Windows.Forms.TextBox
    Friend WithEvents txtExpFive As System.Windows.Forms.TextBox
    Friend WithEvents txtLastFour As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstFour As System.Windows.Forms.TextBox
    Friend WithEvents txtFour As System.Windows.Forms.TextBox
    Friend WithEvents lblExp As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents txtExpFour As System.Windows.Forms.TextBox
    Friend WithEvents lblSpaceTwo As System.Windows.Forms.Label
    Friend WithEvents txtExpSum As System.Windows.Forms.TextBox
    Friend WithEvents lblSix As System.Windows.Forms.Label
    Friend WithEvents txtSmaller As System.Windows.Forms.TextBox
    Friend WithEvents lblSeven As System.Windows.Forms.Label
    Friend WithEvents txtCCExp As System.Windows.Forms.TextBox
    Friend WithEvents lblNine As System.Windows.Forms.Label
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox
    Friend WithEvents lblEight As System.Windows.Forms.Label
    Friend WithEvents grpPercentages As System.Windows.Forms.GroupBox
    Friend WithEvents rdo18 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo20 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo22 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo27 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo30 As System.Windows.Forms.RadioButton
    Friend WithEvents lblPayeeOne As System.Windows.Forms.Label
    Friend WithEvents lblPayeeOneName As System.Windows.Forms.Label
    Friend WithEvents lblPayeeTwoName As System.Windows.Forms.Label
    Friend WithEvents lblPayeeTwo As System.Windows.Forms.Label
    Friend WithEvents lblPayeeOneSSN As System.Windows.Forms.Label
    Friend WithEvents lblPayeeTwoSSN As System.Windows.Forms.Label
End Class
