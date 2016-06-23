<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalc))
        Me.lblWindow = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClearEntry = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMemorySubtract = New System.Windows.Forms.Button()
        Me.btnTwoDecimals = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnDecimal = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEqual = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnMemoryAdd = New System.Windows.Forms.Button()
        Me.btnMemorySave = New System.Windows.Forms.Button()
        Me.btnMemoryReturn = New System.Windows.Forms.Button()
        Me.btnMemoryClear = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnFourDecimals = New System.Windows.Forms.Button()
        Me.btnInverse = New System.Windows.Forms.Button()
        Me.btnExponent = New System.Windows.Forms.Button()
        Me.lblWorking = New System.Windows.Forms.Label()
        Me.lblStorage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWindow
        '
        Me.lblWindow.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWindow.Location = New System.Drawing.Point(12, 9)
        Me.lblWindow.Name = "lblWindow"
        Me.lblWindow.Size = New System.Drawing.Size(300, 66)
        Me.lblWindow.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 78)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(96, 45)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "←"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClearEntry
        '
        Me.btnClearEntry.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClearEntry.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearEntry.Location = New System.Drawing.Point(114, 78)
        Me.btnClearEntry.Name = "btnClearEntry"
        Me.btnClearEntry.Size = New System.Drawing.Size(45, 45)
        Me.btnClearEntry.TabIndex = 2
        Me.btnClearEntry.Text = "CE"
        Me.btnClearEntry.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(165, 78)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(45, 45)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnMemorySubtract
        '
        Me.btnMemorySubtract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMemorySubtract.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemorySubtract.Location = New System.Drawing.Point(216, 129)
        Me.btnMemorySubtract.Name = "btnMemorySubtract"
        Me.btnMemorySubtract.Size = New System.Drawing.Size(45, 45)
        Me.btnMemorySubtract.TabIndex = 4
        Me.btnMemorySubtract.Text = "M-"
        Me.btnMemorySubtract.UseVisualStyleBackColor = False
        '
        'btnTwoDecimals
        '
        Me.btnTwoDecimals.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnTwoDecimals.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwoDecimals.Location = New System.Drawing.Point(267, 129)
        Me.btnTwoDecimals.Name = "btnTwoDecimals"
        Me.btnTwoDecimals.Size = New System.Drawing.Size(45, 45)
        Me.btnTwoDecimals.TabIndex = 5
        Me.btnTwoDecimals.Text = ".00"
        Me.btnTwoDecimals.UseVisualStyleBackColor = False
        '
        'btnSign
        '
        Me.btnSign.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSign.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSign.Location = New System.Drawing.Point(216, 180)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(45, 45)
        Me.btnSign.TabIndex = 6
        Me.btnSign.Text = "±"
        Me.btnSign.UseVisualStyleBackColor = False
        '
        'btnDivide
        '
        Me.btnDivide.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDivide.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(165, 180)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(45, 45)
        Me.btnDivide.TabIndex = 7
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = False
        '
        'btnNine
        '
        Me.btnNine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnNine.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(114, 180)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(45, 45)
        Me.btnNine.TabIndex = 8
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = False
        '
        'btnEight
        '
        Me.btnEight.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnEight.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(63, 180)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(45, 45)
        Me.btnEight.TabIndex = 9
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = False
        '
        'btnSeven
        '
        Me.btnSeven.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSeven.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(12, 180)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(45, 45)
        Me.btnSeven.TabIndex = 10
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = False
        '
        'btnFour
        '
        Me.btnFour.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFour.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(12, 231)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(45, 45)
        Me.btnFour.TabIndex = 11
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = False
        '
        'btnFive
        '
        Me.btnFive.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnFive.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(63, 231)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(45, 45)
        Me.btnFive.TabIndex = 12
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = False
        '
        'btnSix
        '
        Me.btnSix.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnSix.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(114, 231)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(45, 45)
        Me.btnSix.TabIndex = 13
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = False
        '
        'btnMultiply
        '
        Me.btnMultiply.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMultiply.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(165, 231)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(45, 45)
        Me.btnMultiply.TabIndex = 14
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = False
        '
        'btnSqrt
        '
        Me.btnSqrt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSqrt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSqrt.Location = New System.Drawing.Point(216, 231)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(45, 45)
        Me.btnSqrt.TabIndex = 15
        Me.btnSqrt.Text = "√"
        Me.btnSqrt.UseVisualStyleBackColor = False
        '
        'btnOne
        '
        Me.btnOne.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOne.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(12, 282)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(45, 45)
        Me.btnOne.TabIndex = 16
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = False
        '
        'btnTwo
        '
        Me.btnTwo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnTwo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(63, 282)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(45, 45)
        Me.btnTwo.TabIndex = 17
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = False
        '
        'btnThree
        '
        Me.btnThree.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnThree.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(114, 282)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(45, 45)
        Me.btnThree.TabIndex = 18
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = False
        '
        'btnSubtract
        '
        Me.btnSubtract.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSubtract.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.Location = New System.Drawing.Point(165, 282)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(45, 45)
        Me.btnSubtract.TabIndex = 19
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = False
        '
        'btnZero
        '
        Me.btnZero.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnZero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(12, 333)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(96, 45)
        Me.btnZero.TabIndex = 21
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = False
        '
        'btnDecimal
        '
        Me.btnDecimal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnDecimal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecimal.Location = New System.Drawing.Point(114, 333)
        Me.btnDecimal.Name = "btnDecimal"
        Me.btnDecimal.Size = New System.Drawing.Size(45, 45)
        Me.btnDecimal.TabIndex = 23
        Me.btnDecimal.Text = "."
        Me.btnDecimal.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(165, 333)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(45, 45)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEqual
        '
        Me.btnEqual.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEqual.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEqual.Location = New System.Drawing.Point(216, 333)
        Me.btnEqual.Name = "btnEqual"
        Me.btnEqual.Size = New System.Drawing.Size(96, 45)
        Me.btnEqual.TabIndex = 25
        Me.btnEqual.Text = "="
        Me.btnEqual.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(216, 78)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(96, 45)
        Me.btnQuit.TabIndex = 30
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnMemoryAdd
        '
        Me.btnMemoryAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMemoryAdd.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemoryAdd.Location = New System.Drawing.Point(165, 129)
        Me.btnMemoryAdd.Name = "btnMemoryAdd"
        Me.btnMemoryAdd.Size = New System.Drawing.Size(45, 45)
        Me.btnMemoryAdd.TabIndex = 29
        Me.btnMemoryAdd.Text = "M+"
        Me.btnMemoryAdd.UseVisualStyleBackColor = False
        '
        'btnMemorySave
        '
        Me.btnMemorySave.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMemorySave.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemorySave.Location = New System.Drawing.Point(114, 129)
        Me.btnMemorySave.Name = "btnMemorySave"
        Me.btnMemorySave.Size = New System.Drawing.Size(45, 45)
        Me.btnMemorySave.TabIndex = 28
        Me.btnMemorySave.Text = "MS"
        Me.btnMemorySave.UseVisualStyleBackColor = False
        '
        'btnMemoryReturn
        '
        Me.btnMemoryReturn.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMemoryReturn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemoryReturn.Location = New System.Drawing.Point(63, 129)
        Me.btnMemoryReturn.Name = "btnMemoryReturn"
        Me.btnMemoryReturn.Size = New System.Drawing.Size(45, 45)
        Me.btnMemoryReturn.TabIndex = 27
        Me.btnMemoryReturn.Text = "MR"
        Me.btnMemoryReturn.UseVisualStyleBackColor = False
        '
        'btnMemoryClear
        '
        Me.btnMemoryClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMemoryClear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMemoryClear.Location = New System.Drawing.Point(12, 129)
        Me.btnMemoryClear.Name = "btnMemoryClear"
        Me.btnMemoryClear.Size = New System.Drawing.Size(45, 45)
        Me.btnMemoryClear.TabIndex = 26
        Me.btnMemoryClear.Text = "MC"
        Me.btnMemoryClear.UseVisualStyleBackColor = False
        '
        'btnPercent
        '
        Me.btnPercent.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPercent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPercent.Location = New System.Drawing.Point(267, 231)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(45, 45)
        Me.btnPercent.TabIndex = 33
        Me.btnPercent.Text = "%"
        Me.btnPercent.UseVisualStyleBackColor = False
        '
        'btnFourDecimals
        '
        Me.btnFourDecimals.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnFourDecimals.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFourDecimals.Location = New System.Drawing.Point(267, 180)
        Me.btnFourDecimals.Name = "btnFourDecimals"
        Me.btnFourDecimals.Size = New System.Drawing.Size(45, 45)
        Me.btnFourDecimals.TabIndex = 31
        Me.btnFourDecimals.Text = ".0000"
        Me.btnFourDecimals.UseVisualStyleBackColor = False
        '
        'btnInverse
        '
        Me.btnInverse.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnInverse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInverse.Location = New System.Drawing.Point(267, 282)
        Me.btnInverse.Name = "btnInverse"
        Me.btnInverse.Size = New System.Drawing.Size(45, 45)
        Me.btnInverse.TabIndex = 35
        Me.btnInverse.Text = "1/x"
        Me.btnInverse.UseVisualStyleBackColor = False
        '
        'btnExponent
        '
        Me.btnExponent.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExponent.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExponent.Location = New System.Drawing.Point(216, 282)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(45, 45)
        Me.btnExponent.TabIndex = 34
        Me.btnExponent.Text = "10 ⁿ"
        Me.btnExponent.UseVisualStyleBackColor = False
        '
        'lblWorking
        '
        Me.lblWorking.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWorking.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorking.Location = New System.Drawing.Point(13, 35)
        Me.lblWorking.Name = "lblWorking"
        Me.lblWorking.Size = New System.Drawing.Size(298, 39)
        Me.lblWorking.TabIndex = 36
        Me.lblWorking.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblStorage
        '
        Me.lblStorage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStorage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStorage.Location = New System.Drawing.Point(13, 10)
        Me.lblStorage.Name = "lblStorage"
        Me.lblStorage.Size = New System.Drawing.Size(298, 25)
        Me.lblStorage.TabIndex = 37
        Me.lblStorage.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(321, 386)
        Me.Controls.Add(Me.lblStorage)
        Me.Controls.Add(Me.lblWorking)
        Me.Controls.Add(Me.btnInverse)
        Me.Controls.Add(Me.btnExponent)
        Me.Controls.Add(Me.btnPercent)
        Me.Controls.Add(Me.btnFourDecimals)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnMemoryAdd)
        Me.Controls.Add(Me.btnMemorySave)
        Me.Controls.Add(Me.btnMemoryReturn)
        Me.Controls.Add(Me.btnMemoryClear)
        Me.Controls.Add(Me.btnEqual)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDecimal)
        Me.Controls.Add(Me.btnZero)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSix)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnSeven)
        Me.Controls.Add(Me.btnEight)
        Me.Controls.Add(Me.btnNine)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnTwoDecimals)
        Me.Controls.Add(Me.btnMemorySubtract)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClearEntry)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblWindow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCalc"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblWindow As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClearEntry As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnMemorySubtract As System.Windows.Forms.Button
    Friend WithEvents btnTwoDecimals As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnNine As System.Windows.Forms.Button
    Friend WithEvents btnEight As System.Windows.Forms.Button
    Friend WithEvents btnSeven As System.Windows.Forms.Button
    Friend WithEvents btnFour As System.Windows.Forms.Button
    Friend WithEvents btnFive As System.Windows.Forms.Button
    Friend WithEvents btnSix As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnSqrt As System.Windows.Forms.Button
    Friend WithEvents btnOne As System.Windows.Forms.Button
    Friend WithEvents btnTwo As System.Windows.Forms.Button
    Friend WithEvents btnThree As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnZero As System.Windows.Forms.Button
    Friend WithEvents btnDecimal As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEqual As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnMemoryAdd As System.Windows.Forms.Button
    Friend WithEvents btnMemorySave As System.Windows.Forms.Button
    Friend WithEvents btnMemoryReturn As System.Windows.Forms.Button
    Friend WithEvents btnMemoryClear As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnFourDecimals As System.Windows.Forms.Button
    Friend WithEvents btnInverse As System.Windows.Forms.Button
    Friend WithEvents btnExponent As System.Windows.Forms.Button
    Friend WithEvents lblWorking As System.Windows.Forms.Label
    Friend WithEvents lblStorage As System.Windows.Forms.Label
End Class
