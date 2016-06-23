<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.rdoWidow = New System.Windows.Forms.RadioButton()
        Me.rdoSeperately = New System.Windows.Forms.RadioButton()
        Me.rdoJointly = New System.Windows.Forms.RadioButton()
        Me.rdoHoH = New System.Windows.Forms.RadioButton()
        Me.rdoSingle = New System.Windows.Forms.RadioButton()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSlogan = New System.Windows.Forms.Label()
        Me.grpForms = New System.Windows.Forms.GroupBox()
        Me.btnSE = New System.Windows.Forms.Button()
        Me.btnSD = New System.Windows.Forms.Button()
        Me.btnSC = New System.Windows.Forms.Button()
        Me.btnSB = New System.Windows.Forms.Button()
        Me.btnSA = New System.Windows.Forms.Button()
        Me.btnF1040 = New System.Windows.Forms.Button()
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnIncome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.txtYName = New System.Windows.Forms.TextBox()
        Me.lblSSSN = New System.Windows.Forms.Label()
        Me.lblYSSN = New System.Windows.Forms.Label()
        Me.lblSName = New System.Windows.Forms.Label()
        Me.lblYName = New System.Windows.Forms.Label()
        Me.txtYSSN = New System.Windows.Forms.TextBox()
        Me.txtSSSN = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpStatus.SuspendLayout()
        Me.grpForms.SuspendLayout()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.rdoWidow)
        Me.grpStatus.Controls.Add(Me.rdoSeperately)
        Me.grpStatus.Controls.Add(Me.rdoJointly)
        Me.grpStatus.Controls.Add(Me.rdoHoH)
        Me.grpStatus.Controls.Add(Me.rdoSingle)
        Me.grpStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStatus.Location = New System.Drawing.Point(343, 131)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(206, 146)
        Me.grpStatus.TabIndex = 8
        Me.grpStatus.TabStop = False
        Me.grpStatus.Text = "Filing Status:"
        '
        'rdoWidow
        '
        Me.rdoWidow.AutoSize = True
        Me.rdoWidow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoWidow.Location = New System.Drawing.Point(14, 119)
        Me.rdoWidow.Name = "rdoWidow"
        Me.rdoWidow.Size = New System.Drawing.Size(174, 18)
        Me.rdoWidow.TabIndex = 4
        Me.rdoWidow.TabStop = True
        Me.rdoWidow.Text = "Widower with Dependent Child"
        Me.rdoWidow.UseVisualStyleBackColor = True
        '
        'rdoSeperately
        '
        Me.rdoSeperately.AutoSize = True
        Me.rdoSeperately.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSeperately.Location = New System.Drawing.Point(14, 71)
        Me.rdoSeperately.Name = "rdoSeperately"
        Me.rdoSeperately.Size = New System.Drawing.Size(145, 18)
        Me.rdoSeperately.TabIndex = 3
        Me.rdoSeperately.TabStop = True
        Me.rdoSeperately.Text = "Married Filling Seperately"
        Me.rdoSeperately.UseVisualStyleBackColor = True
        '
        'rdoJointly
        '
        Me.rdoJointly.AutoSize = True
        Me.rdoJointly.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoJointly.Location = New System.Drawing.Point(14, 47)
        Me.rdoJointly.Name = "rdoJointly"
        Me.rdoJointly.Size = New System.Drawing.Size(123, 18)
        Me.rdoJointly.TabIndex = 2
        Me.rdoJointly.TabStop = True
        Me.rdoJointly.Text = "Married Filling Jointly"
        Me.rdoJointly.UseVisualStyleBackColor = True
        '
        'rdoHoH
        '
        Me.rdoHoH.AutoSize = True
        Me.rdoHoH.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoHoH.Location = New System.Drawing.Point(14, 95)
        Me.rdoHoH.Name = "rdoHoH"
        Me.rdoHoH.Size = New System.Drawing.Size(117, 18)
        Me.rdoHoH.TabIndex = 1
        Me.rdoHoH.TabStop = True
        Me.rdoHoH.Text = "Head of Household"
        Me.rdoHoH.UseVisualStyleBackColor = True
        '
        'rdoSingle
        '
        Me.rdoSingle.AutoSize = True
        Me.rdoSingle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSingle.Location = New System.Drawing.Point(14, 23)
        Me.rdoSingle.Name = "rdoSingle"
        Me.rdoSingle.Size = New System.Drawing.Size(54, 18)
        Me.rdoSingle.TabIndex = 0
        Me.rdoSingle.TabStop = True
        Me.rdoSingle.Text = "Single"
        Me.rdoSingle.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(177, 20)
        Me.lblTitle.TabIndex = 26
        Me.lblTitle.Text = "Simpleminded Software"
        '
        'lblSlogan
        '
        Me.lblSlogan.AutoSize = True
        Me.lblSlogan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSlogan.Location = New System.Drawing.Point(195, 12)
        Me.lblSlogan.Name = "lblSlogan"
        Me.lblSlogan.Size = New System.Drawing.Size(136, 16)
        Me.lblSlogan.TabIndex = 27
        Me.lblSlogan.Text = """Taxes Done Simply"""
        '
        'grpForms
        '
        Me.grpForms.Controls.Add(Me.btnSE)
        Me.grpForms.Controls.Add(Me.btnSD)
        Me.grpForms.Controls.Add(Me.btnSC)
        Me.grpForms.Controls.Add(Me.btnSB)
        Me.grpForms.Controls.Add(Me.btnSA)
        Me.grpForms.Controls.Add(Me.btnF1040)
        Me.grpForms.Location = New System.Drawing.Point(15, 283)
        Me.grpForms.Name = "grpForms"
        Me.grpForms.Size = New System.Drawing.Size(534, 67)
        Me.grpForms.TabIndex = 39
        Me.grpForms.TabStop = False
        '
        'btnSE
        '
        Me.btnSE.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSE.Location = New System.Drawing.Point(454, 11)
        Me.btnSE.Name = "btnSE"
        Me.btnSE.Size = New System.Drawing.Size(75, 50)
        Me.btnSE.TabIndex = 28
        Me.btnSE.Text = "Schedule &E"
        Me.btnSE.UseVisualStyleBackColor = False
        '
        'btnSD
        '
        Me.btnSD.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSD.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSD.Location = New System.Drawing.Point(364, 11)
        Me.btnSD.Name = "btnSD"
        Me.btnSD.Size = New System.Drawing.Size(75, 50)
        Me.btnSD.TabIndex = 27
        Me.btnSD.Text = "Schedule &D"
        Me.btnSD.UseVisualStyleBackColor = False
        '
        'btnSC
        '
        Me.btnSC.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSC.Location = New System.Drawing.Point(274, 11)
        Me.btnSC.Name = "btnSC"
        Me.btnSC.Size = New System.Drawing.Size(75, 50)
        Me.btnSC.TabIndex = 26
        Me.btnSC.Text = "Schedule &C"
        Me.btnSC.UseVisualStyleBackColor = False
        '
        'btnSB
        '
        Me.btnSB.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSB.Location = New System.Drawing.Point(184, 11)
        Me.btnSB.Name = "btnSB"
        Me.btnSB.Size = New System.Drawing.Size(75, 50)
        Me.btnSB.TabIndex = 25
        Me.btnSB.Text = "Schedule &B"
        Me.btnSB.UseVisualStyleBackColor = False
        '
        'btnSA
        '
        Me.btnSA.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSA.Location = New System.Drawing.Point(94, 11)
        Me.btnSA.Name = "btnSA"
        Me.btnSA.Size = New System.Drawing.Size(75, 50)
        Me.btnSA.TabIndex = 24
        Me.btnSA.Text = "Schedule &A"
        Me.btnSA.UseVisualStyleBackColor = False
        '
        'btnF1040
        '
        Me.btnF1040.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnF1040.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnF1040.Location = New System.Drawing.Point(4, 11)
        Me.btnF1040.Name = "btnF1040"
        Me.btnF1040.Size = New System.Drawing.Size(75, 50)
        Me.btnF1040.TabIndex = 23
        Me.btnF1040.Text = "&Form 1040"
        Me.btnF1040.UseVisualStyleBackColor = False
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnIncome)
        Me.grpButtons.Controls.Add(Me.btnExit)
        Me.grpButtons.Controls.Add(Me.btnAbout)
        Me.grpButtons.Location = New System.Drawing.Point(15, 219)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(318, 58)
        Me.grpButtons.TabIndex = 40
        Me.grpButtons.TabStop = False
        '
        'btnIncome
        '
        Me.btnIncome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnIncome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncome.Location = New System.Drawing.Point(119, 15)
        Me.btnIncome.Name = "btnIncome"
        Me.btnIncome.Size = New System.Drawing.Size(75, 35)
        Me.btnIncome.TabIndex = 28
        Me.btnIncome.Text = "&Income Calc"
        Me.btnIncome.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(230, 15)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAbout.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(15, 15)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 35)
        Me.btnAbout.TabIndex = 26
        Me.btnAbout.Text = "Ab&out"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'txtSName
        '
        Me.txtSName.AccessibleName = "Spouse Full Name"
        Me.txtSName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSName.Location = New System.Drawing.Point(134, 93)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(186, 20)
        Me.txtSName.TabIndex = 37
        '
        'txtYName
        '
        Me.txtYName.AccessibleDescription = "Required"
        Me.txtYName.AccessibleName = "Your Full Name"
        Me.txtYName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYName.Location = New System.Drawing.Point(134, 65)
        Me.txtYName.Name = "txtYName"
        Me.txtYName.Size = New System.Drawing.Size(186, 20)
        Me.txtYName.TabIndex = 36
        Me.txtYName.Text = "John Q. Sample"
        '
        'lblSSSN
        '
        Me.lblSSSN.AccessibleName = "Spouse SSN"
        Me.lblSSSN.AutoSize = True
        Me.lblSSSN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSSN.Location = New System.Drawing.Point(364, 96)
        Me.lblSSSN.Name = "lblSSSN"
        Me.lblSSSN.Size = New System.Drawing.Size(71, 14)
        Me.lblSSSN.TabIndex = 41
        Me.lblSSSN.Text = "Spouse SSN:"
        '
        'lblYSSN
        '
        Me.lblYSSN.AutoSize = True
        Me.lblYSSN.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYSSN.Location = New System.Drawing.Point(378, 68)
        Me.lblYSSN.Name = "lblYSSN"
        Me.lblYSSN.Size = New System.Drawing.Size(57, 14)
        Me.lblYSSN.TabIndex = 40
        Me.lblYSSN.Text = "Your SSN:"
        '
        'lblSName
        '
        Me.lblSName.AccessibleName = "Spouse Full Name"
        Me.lblSName.AutoSize = True
        Me.lblSName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSName.Location = New System.Drawing.Point(32, 96)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(96, 14)
        Me.lblSName.TabIndex = 39
        Me.lblSName.Text = "Spouse Full Name:"
        '
        'lblYName
        '
        Me.lblYName.AutoSize = True
        Me.lblYName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYName.Location = New System.Drawing.Point(46, 68)
        Me.lblYName.Name = "lblYName"
        Me.lblYName.Size = New System.Drawing.Size(82, 14)
        Me.lblYName.TabIndex = 38
        Me.lblYName.Text = "Your Full Name:"
        '
        'txtYSSN
        '
        Me.txtYSSN.AccessibleDescription = "Required"
        Me.txtYSSN.AccessibleName = "Your SSN"
        Me.txtYSSN.Location = New System.Drawing.Point(441, 65)
        Me.txtYSSN.Name = "txtYSSN"
        Me.txtYSSN.Size = New System.Drawing.Size(87, 20)
        Me.txtYSSN.TabIndex = 42
        Me.txtYSSN.Text = "123-45-6789"
        '
        'txtSSSN
        '
        Me.txtSSSN.AccessibleDescription = ""
        Me.txtSSSN.AccessibleName = "Spouse SSN"
        Me.txtSSSN.Location = New System.Drawing.Point(441, 93)
        Me.txtSSSN.Name = "txtSSSN"
        Me.txtSSSN.Size = New System.Drawing.Size(87, 20)
        Me.txtSSSN.TabIndex = 43
        '
        'txtState
        '
        Me.txtState.AccessibleDescription = "Required"
        Me.txtState.AccessibleName = "State"
        Me.txtState.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(211, 180)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(27, 20)
        Me.txtState.TabIndex = 53
        Me.txtState.Text = "NV"
        '
        'txtCity
        '
        Me.txtCity.AccessibleDescription = "Required"
        Me.txtCity.AccessibleName = "City"
        Me.txtCity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(85, 180)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(79, 20)
        Me.txtCity.TabIndex = 52
        Me.txtCity.Text = "Reno"
        '
        'txtAddress
        '
        Me.txtAddress.AccessibleDescription = "Required"
        Me.txtAddress.AccessibleName = "State"
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(85, 152)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(235, 20)
        Me.txtAddress.TabIndex = 51
        Me.txtAddress.Text = "123 Main Street"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZip.Location = New System.Drawing.Point(244, 183)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(25, 14)
        Me.lblZip.TabIndex = 58
        Me.lblZip.Text = "Zip:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(170, 183)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 14)
        Me.lblState.TabIndex = 57
        Me.lblState.Text = "State:"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(51, 183)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(28, 14)
        Me.lblCity.TabIndex = 56
        Me.lblCity.Text = "City:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(27, 155)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(52, 14)
        Me.lblAddress.TabIndex = 55
        Me.lblAddress.Text = "Address:"
        '
        'txtZip
        '
        Me.txtZip.AccessibleDescription = "Required"
        Me.txtZip.AccessibleName = "Zip"
        Me.txtZip.Location = New System.Drawing.Point(275, 180)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(45, 20)
        Me.txtZip.TabIndex = 54
        Me.txtZip.Text = "89557"
        '
        'lblInfo
        '
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Location = New System.Drawing.Point(16, 49)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(533, 79)
        Me.lblInfo.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(16, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 80)
        Me.Label1.TabIndex = 60
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 361)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtSName)
        Me.Controls.Add(Me.grpButtons)
        Me.Controls.Add(Me.txtYName)
        Me.Controls.Add(Me.grpForms)
        Me.Controls.Add(Me.lblSSSN)
        Me.Controls.Add(Me.grpStatus)
        Me.Controls.Add(Me.lblYSSN)
        Me.Controls.Add(Me.lblSName)
        Me.Controls.Add(Me.lblSlogan)
        Me.Controls.Add(Me.lblYName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtYSSN)
        Me.Controls.Add(Me.txtSSSN)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "Main Screen"
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.grpForms.ResumeLayout(False)
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpStatus As System.Windows.Forms.GroupBox
    Friend WithEvents rdoWidow As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSeperately As System.Windows.Forms.RadioButton
    Friend WithEvents rdoJointly As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHoH As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSingle As System.Windows.Forms.RadioButton
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSlogan As System.Windows.Forms.Label
    Friend WithEvents grpForms As System.Windows.Forms.GroupBox
    Friend WithEvents btnSE As System.Windows.Forms.Button
    Friend WithEvents btnSD As System.Windows.Forms.Button
    Friend WithEvents btnSC As System.Windows.Forms.Button
    Friend WithEvents btnSB As System.Windows.Forms.Button
    Friend WithEvents btnSA As System.Windows.Forms.Button
    Friend WithEvents btnF1040 As System.Windows.Forms.Button
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnIncome As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents txtSName As System.Windows.Forms.TextBox
    Friend WithEvents txtYName As System.Windows.Forms.TextBox
    Friend WithEvents lblSSSN As System.Windows.Forms.Label
    Friend WithEvents lblYSSN As System.Windows.Forms.Label
    Friend WithEvents lblSName As System.Windows.Forms.Label
    Friend WithEvents lblYName As System.Windows.Forms.Label
    Friend WithEvents txtYSSN As System.Windows.Forms.TextBox
    Friend WithEvents txtSSSN As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
