<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNetPay
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.grpHealthPlanDeduction = New System.Windows.Forms.GroupBox()
        Me.rdoHomeTownHealth = New System.Windows.Forms.RadioButton()
        Me.rdoBlueCross = New System.Windows.Forms.RadioButton()
        Me.rdoKaiserPermanente = New System.Windows.Forms.RadioButton()
        Me.rdoHPOfNevada = New System.Windows.Forms.RadioButton()
        Me.grpAdditionalDeductions = New System.Windows.Forms.GroupBox()
        Me.chkRetirement = New System.Windows.Forms.CheckBox()
        Me.chkParking = New System.Windows.Forms.CheckBox()
        Me.chkUnitedWay = New System.Windows.Forms.CheckBox()
        Me.chkUnionDues = New System.Windows.Forms.CheckBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.lblHealthPlanCosts = New System.Windows.Forms.Label()
        Me.lblAdditionalDeductions = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtHealthPlanCosts = New System.Windows.Forms.TextBox()
        Me.txtAdditionalDeductions = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.btnComputeNetPay = New System.Windows.Forms.Button()
        Me.btnReturnToMainForm = New System.Windows.Forms.Button()
        Me.grpHealthPlanDeduction.SuspendLayout()
        Me.grpAdditionalDeductions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(35, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Full Name"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(134, 9)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(29, 13)
        Me.lblSSN.TabIndex = 1
        Me.lblSSN.Text = "SSN"
        '
        'grpHealthPlanDeduction
        '
        Me.grpHealthPlanDeduction.Controls.Add(Me.rdoHomeTownHealth)
        Me.grpHealthPlanDeduction.Controls.Add(Me.rdoBlueCross)
        Me.grpHealthPlanDeduction.Controls.Add(Me.rdoKaiserPermanente)
        Me.grpHealthPlanDeduction.Controls.Add(Me.rdoHPOfNevada)
        Me.grpHealthPlanDeduction.Location = New System.Drawing.Point(12, 36)
        Me.grpHealthPlanDeduction.Name = "grpHealthPlanDeduction"
        Me.grpHealthPlanDeduction.Size = New System.Drawing.Size(175, 125)
        Me.grpHealthPlanDeduction.TabIndex = 2
        Me.grpHealthPlanDeduction.TabStop = False
        Me.grpHealthPlanDeduction.Text = "Health Plan Deduction"
        '
        'rdoHomeTownHealth
        '
        Me.rdoHomeTownHealth.AutoSize = True
        Me.rdoHomeTownHealth.Location = New System.Drawing.Point(11, 100)
        Me.rdoHomeTownHealth.Name = "rdoHomeTownHealth"
        Me.rdoHomeTownHealth.Size = New System.Drawing.Size(159, 17)
        Me.rdoHomeTownHealth.TabIndex = 3
        Me.rdoHomeTownHealth.TabStop = True
        Me.rdoHomeTownHealth.Text = "Home Town Health ($58.85)"
        Me.rdoHomeTownHealth.UseVisualStyleBackColor = True
        '
        'rdoBlueCross
        '
        Me.rdoBlueCross.AutoSize = True
        Me.rdoBlueCross.Location = New System.Drawing.Point(11, 73)
        Me.rdoBlueCross.Name = "rdoBlueCross"
        Me.rdoBlueCross.Size = New System.Drawing.Size(117, 17)
        Me.rdoBlueCross.TabIndex = 2
        Me.rdoBlueCross.TabStop = True
        Me.rdoBlueCross.Text = "Blue Cross ($75.25)"
        Me.rdoBlueCross.UseVisualStyleBackColor = True
        '
        'rdoKaiserPermanente
        '
        Me.rdoKaiserPermanente.AutoSize = True
        Me.rdoKaiserPermanente.Location = New System.Drawing.Point(11, 46)
        Me.rdoKaiserPermanente.Name = "rdoKaiserPermanente"
        Me.rdoKaiserPermanente.Size = New System.Drawing.Size(156, 17)
        Me.rdoKaiserPermanente.TabIndex = 1
        Me.rdoKaiserPermanente.TabStop = True
        Me.rdoKaiserPermanente.Text = "Kaiser Permanente ($35.60)"
        Me.rdoKaiserPermanente.UseVisualStyleBackColor = True
        '
        'rdoHPOfNevada
        '
        Me.rdoHPOfNevada.AutoSize = True
        Me.rdoHPOfNevada.Location = New System.Drawing.Point(11, 19)
        Me.rdoHPOfNevada.Name = "rdoHPOfNevada"
        Me.rdoHPOfNevada.Size = New System.Drawing.Size(135, 17)
        Me.rdoHPOfNevada.TabIndex = 0
        Me.rdoHPOfNevada.TabStop = True
        Me.rdoHPOfNevada.Text = "HP of Nevada ($62.50)"
        Me.rdoHPOfNevada.UseVisualStyleBackColor = True
        '
        'grpAdditionalDeductions
        '
        Me.grpAdditionalDeductions.Controls.Add(Me.chkRetirement)
        Me.grpAdditionalDeductions.Controls.Add(Me.chkParking)
        Me.grpAdditionalDeductions.Controls.Add(Me.chkUnitedWay)
        Me.grpAdditionalDeductions.Controls.Add(Me.chkUnionDues)
        Me.grpAdditionalDeductions.Location = New System.Drawing.Point(12, 171)
        Me.grpAdditionalDeductions.Name = "grpAdditionalDeductions"
        Me.grpAdditionalDeductions.Size = New System.Drawing.Size(175, 125)
        Me.grpAdditionalDeductions.TabIndex = 3
        Me.grpAdditionalDeductions.TabStop = False
        Me.grpAdditionalDeductions.Text = "Additional Deductions"
        '
        'chkRetirement
        '
        Me.chkRetirement.AutoSize = True
        Me.chkRetirement.Location = New System.Drawing.Point(11, 97)
        Me.chkRetirement.Name = "chkRetirement"
        Me.chkRetirement.Size = New System.Drawing.Size(119, 17)
        Me.chkRetirement.TabIndex = 3
        Me.chkRetirement.Text = "Retirement ($80.00)"
        Me.chkRetirement.UseVisualStyleBackColor = True
        '
        'chkParking
        '
        Me.chkParking.AutoSize = True
        Me.chkParking.Location = New System.Drawing.Point(11, 71)
        Me.chkParking.Name = "chkParking"
        Me.chkParking.Size = New System.Drawing.Size(104, 17)
        Me.chkParking.TabIndex = 2
        Me.chkParking.Text = "Parking ($20.00)"
        Me.chkParking.UseVisualStyleBackColor = True
        '
        'chkUnitedWay
        '
        Me.chkUnitedWay.AutoSize = True
        Me.chkUnitedWay.Location = New System.Drawing.Point(11, 45)
        Me.chkUnitedWay.Name = "chkUnitedWay"
        Me.chkUnitedWay.Size = New System.Drawing.Size(124, 17)
        Me.chkUnitedWay.TabIndex = 1
        Me.chkUnitedWay.Text = "United Way ($25.50)"
        Me.chkUnitedWay.UseVisualStyleBackColor = True
        '
        'chkUnionDues
        '
        Me.chkUnionDues.AutoSize = True
        Me.chkUnionDues.Location = New System.Drawing.Point(11, 19)
        Me.chkUnionDues.Name = "chkUnionDues"
        Me.chkUnionDues.Size = New System.Drawing.Size(124, 17)
        Me.chkUnionDues.TabIndex = 0
        Me.chkUnionDues.Text = "Union Dues ($15.50)"
        Me.chkUnionDues.UseVisualStyleBackColor = True
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(213, 36)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(115, 13)
        Me.lblHours.TabIndex = 4
        Me.lblHours.Text = "Weekly Hours Worked"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(233, 69)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(95, 13)
        Me.lblRate.TabIndex = 5
        Me.lblRate.Text = "Pay Rate per Hour"
        '
        'lblGross
        '
        Me.lblGross.AutoSize = True
        Me.lblGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.Location = New System.Drawing.Point(250, 120)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(73, 13)
        Me.lblGross.TabIndex = 6
        Me.lblGross.Text = "Weekly Gross"
        '
        'lblHealthPlanCosts
        '
        Me.lblHealthPlanCosts.AutoSize = True
        Me.lblHealthPlanCosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealthPlanCosts.Location = New System.Drawing.Point(233, 153)
        Me.lblHealthPlanCosts.Name = "lblHealthPlanCosts"
        Me.lblHealthPlanCosts.Size = New System.Drawing.Size(91, 13)
        Me.lblHealthPlanCosts.TabIndex = 7
        Me.lblHealthPlanCosts.Text = "Health Plan Costs"
        '
        'lblAdditionalDeductions
        '
        Me.lblAdditionalDeductions.AutoSize = True
        Me.lblAdditionalDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdditionalDeductions.Location = New System.Drawing.Point(213, 186)
        Me.lblAdditionalDeductions.Name = "lblAdditionalDeductions"
        Me.lblAdditionalDeductions.Size = New System.Drawing.Size(110, 13)
        Me.lblAdditionalDeductions.TabIndex = 8
        Me.lblAdditionalDeductions.Text = "Additional Deductions"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(239, 219)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(84, 13)
        Me.lblNetPay.TabIndex = 9
        Me.lblNetPay.Text = "Weekly Net Pay"
        '
        'txtHours
        '
        Me.txtHours.AccessibleName = "Hours"
        Me.txtHours.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtHours.Location = New System.Drawing.Point(329, 33)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(35, 20)
        Me.txtHours.TabIndex = 0
        Me.txtHours.Text = "40"
        '
        'txtRate
        '
        Me.txtRate.AccessibleName = "Rate"
        Me.txtRate.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtRate.Location = New System.Drawing.Point(329, 66)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(35, 20)
        Me.txtRate.TabIndex = 1
        Me.txtRate.Text = "10"
        '
        'txtGross
        '
        Me.txtGross.Location = New System.Drawing.Point(329, 117)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.ReadOnly = True
        Me.txtGross.Size = New System.Drawing.Size(100, 20)
        Me.txtGross.TabIndex = 12
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHealthPlanCosts
        '
        Me.txtHealthPlanCosts.Location = New System.Drawing.Point(329, 150)
        Me.txtHealthPlanCosts.Name = "txtHealthPlanCosts"
        Me.txtHealthPlanCosts.ReadOnly = True
        Me.txtHealthPlanCosts.Size = New System.Drawing.Size(100, 20)
        Me.txtHealthPlanCosts.TabIndex = 13
        Me.txtHealthPlanCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAdditionalDeductions
        '
        Me.txtAdditionalDeductions.Location = New System.Drawing.Point(329, 183)
        Me.txtAdditionalDeductions.Name = "txtAdditionalDeductions"
        Me.txtAdditionalDeductions.ReadOnly = True
        Me.txtAdditionalDeductions.Size = New System.Drawing.Size(100, 20)
        Me.txtAdditionalDeductions.TabIndex = 14
        Me.txtAdditionalDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetPay
        '
        Me.txtNetPay.Location = New System.Drawing.Point(329, 216)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(100, 20)
        Me.txtNetPay.TabIndex = 15
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(206, 239)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(223, 13)
        Me.lblLine.TabIndex = 16
        Me.lblLine.Text = "____________________________________"
        '
        'btnComputeNetPay
        '
        Me.btnComputeNetPay.Location = New System.Drawing.Point(248, 259)
        Me.btnComputeNetPay.Name = "btnComputeNetPay"
        Me.btnComputeNetPay.Size = New System.Drawing.Size(75, 37)
        Me.btnComputeNetPay.TabIndex = 17
        Me.btnComputeNetPay.Text = "Compute Net Pay"
        Me.btnComputeNetPay.UseVisualStyleBackColor = True
        '
        'btnReturnToMainForm
        '
        Me.btnReturnToMainForm.Location = New System.Drawing.Point(329, 259)
        Me.btnReturnToMainForm.Name = "btnReturnToMainForm"
        Me.btnReturnToMainForm.Size = New System.Drawing.Size(75, 37)
        Me.btnReturnToMainForm.TabIndex = 18
        Me.btnReturnToMainForm.Text = "Return to Main Form"
        Me.btnReturnToMainForm.UseVisualStyleBackColor = True
        '
        'frmNetPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 304)
        Me.Controls.Add(Me.btnReturnToMainForm)
        Me.Controls.Add(Me.btnComputeNetPay)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtAdditionalDeductions)
        Me.Controls.Add(Me.txtHealthPlanCosts)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblAdditionalDeductions)
        Me.Controls.Add(Me.lblHealthPlanCosts)
        Me.Controls.Add(Me.lblGross)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.grpAdditionalDeductions)
        Me.Controls.Add(Me.grpHealthPlanDeduction)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmNetPay"
        Me.Text = "Estimate Net Pay Screen"
        Me.grpHealthPlanDeduction.ResumeLayout(False)
        Me.grpHealthPlanDeduction.PerformLayout()
        Me.grpAdditionalDeductions.ResumeLayout(False)
        Me.grpAdditionalDeductions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents grpHealthPlanDeduction As System.Windows.Forms.GroupBox
    Friend WithEvents rdoHomeTownHealth As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBlueCross As System.Windows.Forms.RadioButton
    Friend WithEvents rdoKaiserPermanente As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHPOfNevada As System.Windows.Forms.RadioButton
    Friend WithEvents grpAdditionalDeductions As System.Windows.Forms.GroupBox
    Friend WithEvents chkRetirement As System.Windows.Forms.CheckBox
    Friend WithEvents chkParking As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnitedWay As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnionDues As System.Windows.Forms.CheckBox
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents lblHealthPlanCosts As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalDeductions As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtGross As System.Windows.Forms.TextBox
    Friend WithEvents txtHealthPlanCosts As System.Windows.Forms.TextBox
    Friend WithEvents txtAdditionalDeductions As System.Windows.Forms.TextBox
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents btnComputeNetPay As System.Windows.Forms.Button
    Friend WithEvents btnReturnToMainForm As System.Windows.Forms.Button
End Class
