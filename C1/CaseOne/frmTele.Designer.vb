<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTele
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnCmpt = New System.Windows.Forms.Button()
        Me.btnRetrn = New System.Windows.Forms.Button()
        Me.radBtnYes = New System.Windows.Forms.RadioButton()
        Me.radBtnNo = New System.Windows.Forms.RadioButton()
        Me.chkBoxBirth = New System.Windows.Forms.CheckBox()
        Me.chkBoxAnniv = New System.Windows.Forms.CheckBox()
        Me.chkBoxChrist = New System.Windows.Forms.CheckBox()
        Me.chkBoxValen = New System.Windows.Forms.CheckBox()
        Me.txtBoxResult = New System.Windows.Forms.TextBox()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.grpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(148, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Singing Telegram"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(6, 16)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(230, 13)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "Would you like to purchase a singing telegram?"
        '
        'btnCmpt
        '
        Me.btnCmpt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCmpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCmpt.Location = New System.Drawing.Point(43, 221)
        Me.btnCmpt.Name = "btnCmpt"
        Me.btnCmpt.Size = New System.Drawing.Size(99, 23)
        Me.btnCmpt.TabIndex = 2
        Me.btnCmpt.Text = "Compute Total"
        Me.btnCmpt.UseVisualStyleBackColor = False
        '
        'btnRetrn
        '
        Me.btnRetrn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnRetrn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetrn.Location = New System.Drawing.Point(13, 261)
        Me.btnRetrn.Name = "btnRetrn"
        Me.btnRetrn.Size = New System.Drawing.Size(243, 23)
        Me.btnRetrn.TabIndex = 3
        Me.btnRetrn.Text = "Return to Additional Charges Screen"
        Me.btnRetrn.UseVisualStyleBackColor = False
        '
        'radBtnYes
        '
        Me.radBtnYes.AutoSize = True
        Me.radBtnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnYes.Location = New System.Drawing.Point(50, 47)
        Me.radBtnYes.Name = "radBtnYes"
        Me.radBtnYes.Size = New System.Drawing.Size(43, 17)
        Me.radBtnYes.TabIndex = 4
        Me.radBtnYes.Text = "Yes"
        Me.radBtnYes.UseVisualStyleBackColor = True
        '
        'radBtnNo
        '
        Me.radBtnNo.AutoSize = True
        Me.radBtnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBtnNo.Location = New System.Drawing.Point(156, 47)
        Me.radBtnNo.Name = "radBtnNo"
        Me.radBtnNo.Size = New System.Drawing.Size(39, 17)
        Me.radBtnNo.TabIndex = 5
        Me.radBtnNo.Text = "No"
        Me.radBtnNo.UseVisualStyleBackColor = True
        '
        'chkBoxBirth
        '
        Me.chkBoxBirth.AutoSize = True
        Me.chkBoxBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxBirth.Location = New System.Drawing.Point(43, 119)
        Me.chkBoxBirth.Name = "chkBoxBirth"
        Me.chkBoxBirth.Size = New System.Drawing.Size(153, 17)
        Me.chkBoxBirth.TabIndex = 6
        Me.chkBoxBirth.Text = "Birthday Telegram ($19.95)"
        Me.chkBoxBirth.UseVisualStyleBackColor = True
        '
        'chkBoxAnniv
        '
        Me.chkBoxAnniv.AutoSize = True
        Me.chkBoxAnniv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxAnniv.Location = New System.Drawing.Point(43, 142)
        Me.chkBoxAnniv.Name = "chkBoxAnniv"
        Me.chkBoxAnniv.Size = New System.Drawing.Size(170, 17)
        Me.chkBoxAnniv.TabIndex = 7
        Me.chkBoxAnniv.Text = "Anniversary Telegram ($22.95)"
        Me.chkBoxAnniv.UseVisualStyleBackColor = True
        '
        'chkBoxChrist
        '
        Me.chkBoxChrist.AutoSize = True
        Me.chkBoxChrist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxChrist.Location = New System.Drawing.Point(43, 165)
        Me.chkBoxChrist.Name = "chkBoxChrist"
        Me.chkBoxChrist.Size = New System.Drawing.Size(160, 17)
        Me.chkBoxChrist.TabIndex = 8
        Me.chkBoxChrist.Text = "Christmas Telegram ($24.95)"
        Me.chkBoxChrist.UseVisualStyleBackColor = True
        '
        'chkBoxValen
        '
        Me.chkBoxValen.AutoSize = True
        Me.chkBoxValen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBoxValen.Location = New System.Drawing.Point(43, 188)
        Me.chkBoxValen.Name = "chkBoxValen"
        Me.chkBoxValen.Size = New System.Drawing.Size(193, 17)
        Me.chkBoxValen.TabIndex = 9
        Me.chkBoxValen.Text = "Valentines's Day Telegram ($29.95)"
        Me.chkBoxValen.UseVisualStyleBackColor = True
        '
        'txtBoxResult
        '
        Me.txtBoxResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxResult.Location = New System.Drawing.Point(155, 223)
        Me.txtBoxResult.Name = "txtBoxResult"
        Me.txtBoxResult.Size = New System.Drawing.Size(81, 20)
        Me.txtBoxResult.TabIndex = 10
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.radBtnNo)
        Me.grpBox.Controls.Add(Me.radBtnYes)
        Me.grpBox.Controls.Add(Me.lblQuestion)
        Me.grpBox.Location = New System.Drawing.Point(13, 29)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(243, 73)
        Me.grpBox.TabIndex = 11
        Me.grpBox.TabStop = False
        '
        'frmTele
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 291)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.txtBoxResult)
        Me.Controls.Add(Me.chkBoxValen)
        Me.Controls.Add(Me.chkBoxChrist)
        Me.Controls.Add(Me.chkBoxAnniv)
        Me.Controls.Add(Me.chkBoxBirth)
        Me.Controls.Add(Me.btnRetrn)
        Me.Controls.Add(Me.btnCmpt)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTele"
        Me.Text = "Telegrams Form"
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btnCmpt As System.Windows.Forms.Button
    Friend WithEvents btnRetrn As System.Windows.Forms.Button
    Friend WithEvents radBtnYes As System.Windows.Forms.RadioButton
    Friend WithEvents radBtnNo As System.Windows.Forms.RadioButton
    Friend WithEvents chkBoxBirth As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxAnniv As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxChrist As System.Windows.Forms.CheckBox
    Friend WithEvents chkBoxValen As System.Windows.Forms.CheckBox
    Friend WithEvents txtBoxResult As System.Windows.Forms.TextBox
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
End Class
