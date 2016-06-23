<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWrap
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
        Me.radButtonYes = New System.Windows.Forms.RadioButton()
        Me.radButtonNo = New System.Windows.Forms.RadioButton()
        Me.radButton1 = New System.Windows.Forms.RadioButton()
        Me.radButton2 = New System.Windows.Forms.RadioButton()
        Me.radButton3 = New System.Windows.Forms.RadioButton()
        Me.radButton4 = New System.Windows.Forms.RadioButton()
        Me.radButton5 = New System.Windows.Forms.RadioButton()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.txtBoxResult = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.grpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(6, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(120, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Gift Wrapping"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(10, 36)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(201, 15)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "Would you like to purchse gift wrapping?"
        '
        'radButtonYes
        '
        Me.radButtonYes.AutoSize = True
        Me.radButtonYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtonYes.Location = New System.Drawing.Point(47, 61)
        Me.radButtonYes.Name = "radButtonYes"
        Me.radButtonYes.Size = New System.Drawing.Size(43, 17)
        Me.radButtonYes.TabIndex = 2
        Me.radButtonYes.Text = "Yes"
        Me.radButtonYes.UseVisualStyleBackColor = True
        '
        'radButtonNo
        '
        Me.radButtonNo.AutoSize = True
        Me.radButtonNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtonNo.Location = New System.Drawing.Point(150, 61)
        Me.radButtonNo.Name = "radButtonNo"
        Me.radButtonNo.Size = New System.Drawing.Size(39, 17)
        Me.radButtonNo.TabIndex = 3
        Me.radButtonNo.Text = "No"
        Me.radButtonNo.UseVisualStyleBackColor = True
        '
        'radButton1
        '
        Me.radButton1.AutoSize = True
        Me.radButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButton1.Location = New System.Drawing.Point(12, 21)
        Me.radButton1.Name = "radButton1"
        Me.radButton1.Size = New System.Drawing.Size(158, 17)
        Me.radButton1.TabIndex = 4
        Me.radButton1.Text = "Simple Box and Bow ($5.95)"
        Me.radButton1.UseVisualStyleBackColor = True
        '
        'radButton2
        '
        Me.radButton2.AutoSize = True
        Me.radButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButton2.Location = New System.Drawing.Point(12, 43)
        Me.radButton2.Name = "radButton2"
        Me.radButton2.Size = New System.Drawing.Size(133, 17)
        Me.radButton2.TabIndex = 5
        Me.radButton2.Text = "Standard Wrap ($7.95)"
        Me.radButton2.UseVisualStyleBackColor = True
        '
        'radButton3
        '
        Me.radButton3.AutoSize = True
        Me.radButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButton3.Location = New System.Drawing.Point(12, 65)
        Me.radButton3.Name = "radButton3"
        Me.radButton3.Size = New System.Drawing.Size(179, 17)
        Me.radButton3.TabIndex = 6
        Me.radButton3.Text = "Special Christmas Wrap ($10.95)"
        Me.radButton3.UseVisualStyleBackColor = True
        '
        'radButton4
        '
        Me.radButton4.AutoSize = True
        Me.radButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButton4.Location = New System.Drawing.Point(12, 88)
        Me.radButton4.Name = "radButton4"
        Me.radButton4.Size = New System.Drawing.Size(185, 17)
        Me.radButton4.TabIndex = 7
        Me.radButton4.Text = "Happy Anniversary Wrap ($19.95)"
        Me.radButton4.UseVisualStyleBackColor = True
        '
        'radButton5
        '
        Me.radButton5.AutoSize = True
        Me.radButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButton5.Location = New System.Drawing.Point(12, 111)
        Me.radButton5.Name = "radButton5"
        Me.radButton5.Size = New System.Drawing.Size(131, 17)
        Me.radButton5.TabIndex = 8
        Me.radButton5.Text = "Custom Wrap ($29.95)"
        Me.radButton5.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(48, 226)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(59, 23)
        Me.btnTotal.TabIndex = 9
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'txtBoxResult
        '
        Me.txtBoxResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxResult.Location = New System.Drawing.Point(124, 228)
        Me.txtBoxResult.Name = "txtBoxResult"
        Me.txtBoxResult.Size = New System.Drawing.Size(66, 20)
        Me.txtBoxResult.TabIndex = 10
        Me.txtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(10, 255)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(201, 23)
        Me.btnReturn.TabIndex = 11
        Me.btnReturn.Text = "Return To Additional Charges Screen"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.radButton1)
        Me.grpBox.Controls.Add(Me.radButton2)
        Me.grpBox.Controls.Add(Me.radButton3)
        Me.grpBox.Controls.Add(Me.radButton4)
        Me.grpBox.Controls.Add(Me.radButton5)
        Me.grpBox.Location = New System.Drawing.Point(10, 79)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(201, 143)
        Me.grpBox.TabIndex = 12
        Me.grpBox.TabStop = False
        '
        'frmWrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 286)
        Me.Controls.Add(Me.radButtonNo)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.radButtonYes)
        Me.Controls.Add(Me.txtBoxResult)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmWrap"
        Me.Text = "Wrapping Form"
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents radButtonYes As System.Windows.Forms.RadioButton
    Friend WithEvents radButtonNo As System.Windows.Forms.RadioButton
    Friend WithEvents radButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents radButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents radButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents radButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents txtBoxResult As System.Windows.Forms.TextBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
End Class
