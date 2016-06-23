<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMono
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
        Me.lblMonogramming = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.radButtonYes = New System.Windows.Forms.RadioButton()
        Me.radButtonNo = New System.Windows.Forms.RadioButton()
        Me.chkBox1 = New System.Windows.Forms.CheckBox()
        Me.chkBox2 = New System.Windows.Forms.CheckBox()
        Me.chkBox3 = New System.Windows.Forms.CheckBox()
        Me.txtBoxItem1 = New System.Windows.Forms.TextBox()
        Me.txtBoxItem2 = New System.Windows.Forms.TextBox()
        Me.txtBoxItem3 = New System.Windows.Forms.TextBox()
        Me.lblWhatLetter = New System.Windows.Forms.Label()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.txtBoxMonogramming = New System.Windows.Forms.TextBox()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.grpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMonogramming
        '
        Me.lblMonogramming.AutoSize = True
        Me.lblMonogramming.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonogramming.Location = New System.Drawing.Point(12, 9)
        Me.lblMonogramming.Name = "lblMonogramming"
        Me.lblMonogramming.Size = New System.Drawing.Size(131, 20)
        Me.lblMonogramming.TabIndex = 0
        Me.lblMonogramming.Text = "Monogramming"
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(33, 16)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(180, 28)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "Would you like to add a Monogram?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cost is $5 per letter." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'radButtonYes
        '
        Me.radButtonYes.AutoSize = True
        Me.radButtonYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radButtonYes.Location = New System.Drawing.Point(62, 64)
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
        Me.radButtonNo.Location = New System.Drawing.Point(136, 64)
        Me.radButtonNo.Name = "radButtonNo"
        Me.radButtonNo.Size = New System.Drawing.Size(39, 17)
        Me.radButtonNo.TabIndex = 3
        Me.radButtonNo.Text = "No"
        Me.radButtonNo.UseVisualStyleBackColor = True
        '
        'chkBox1
        '
        Me.chkBox1.AutoCheck = False
        Me.chkBox1.AutoSize = True
        Me.chkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox1.Location = New System.Drawing.Point(16, 183)
        Me.chkBox1.Name = "chkBox1"
        Me.chkBox1.Size = New System.Drawing.Size(65, 17)
        Me.chkBox1.TabIndex = 4
        Me.chkBox1.Text = "Item #1:"
        Me.chkBox1.UseVisualStyleBackColor = True
        '
        'chkBox2
        '
        Me.chkBox2.AutoSize = True
        Me.chkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox2.Location = New System.Drawing.Point(16, 208)
        Me.chkBox2.Name = "chkBox2"
        Me.chkBox2.Size = New System.Drawing.Size(65, 17)
        Me.chkBox2.TabIndex = 5
        Me.chkBox2.Text = "Item #2:"
        Me.chkBox2.UseVisualStyleBackColor = True
        '
        'chkBox3
        '
        Me.chkBox3.AutoSize = True
        Me.chkBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox3.Location = New System.Drawing.Point(16, 233)
        Me.chkBox3.Name = "chkBox3"
        Me.chkBox3.Size = New System.Drawing.Size(65, 17)
        Me.chkBox3.TabIndex = 6
        Me.chkBox3.Text = "Item #3:"
        Me.chkBox3.UseVisualStyleBackColor = True
        '
        'txtBoxItem1
        '
        Me.txtBoxItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxItem1.Location = New System.Drawing.Point(116, 180)
        Me.txtBoxItem1.MaxLength = 3
        Me.txtBoxItem1.Name = "txtBoxItem1"
        Me.txtBoxItem1.Size = New System.Drawing.Size(61, 20)
        Me.txtBoxItem1.TabIndex = 7
        Me.txtBoxItem1.Text = "MGS"
        '
        'txtBoxItem2
        '
        Me.txtBoxItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxItem2.Location = New System.Drawing.Point(116, 205)
        Me.txtBoxItem2.MaxLength = 3
        Me.txtBoxItem2.Name = "txtBoxItem2"
        Me.txtBoxItem2.Size = New System.Drawing.Size(61, 20)
        Me.txtBoxItem2.TabIndex = 8
        Me.txtBoxItem2.Text = "MS"
        '
        'txtBoxItem3
        '
        Me.txtBoxItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxItem3.Location = New System.Drawing.Point(116, 230)
        Me.txtBoxItem3.MaxLength = 3
        Me.txtBoxItem3.Name = "txtBoxItem3"
        Me.txtBoxItem3.Size = New System.Drawing.Size(61, 20)
        Me.txtBoxItem3.TabIndex = 9
        '
        'lblWhatLetter
        '
        Me.lblWhatLetter.AutoSize = True
        Me.lblWhatLetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatLetter.Location = New System.Drawing.Point(105, 135)
        Me.lblWhatLetter.Name = "lblWhatLetter"
        Me.lblWhatLetter.Size = New System.Drawing.Size(72, 26)
        Me.lblWhatLetter.TabIndex = 10
        Me.lblWhatLetter.Text = "What letters?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Maximum - 3)"
        '
        'btnTotal
        '
        Me.btnTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(197, 183)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(60, 29)
        Me.btnTotal.TabIndex = 11
        Me.btnTotal.Text = "Total"
        Me.btnTotal.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(16, 271)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(241, 42)
        Me.btnReturn.TabIndex = 12
        Me.btnReturn.Text = "Return to Additional Charges Screen"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'txtBoxMonogramming
        '
        Me.txtBoxMonogramming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxMonogramming.Location = New System.Drawing.Point(197, 230)
        Me.txtBoxMonogramming.Name = "txtBoxMonogramming"
        Me.txtBoxMonogramming.Size = New System.Drawing.Size(60, 20)
        Me.txtBoxMonogramming.TabIndex = 13
        Me.txtBoxMonogramming.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.lblQuestion)
        Me.grpBox.Controls.Add(Me.radButtonNo)
        Me.grpBox.Controls.Add(Me.radButtonYes)
        Me.grpBox.Location = New System.Drawing.Point(16, 29)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(241, 92)
        Me.grpBox.TabIndex = 14
        Me.grpBox.TabStop = False
        '
        'frmMono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 325)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.txtBoxMonogramming)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.lblWhatLetter)
        Me.Controls.Add(Me.txtBoxItem3)
        Me.Controls.Add(Me.txtBoxItem2)
        Me.Controls.Add(Me.txtBoxItem1)
        Me.Controls.Add(Me.chkBox3)
        Me.Controls.Add(Me.chkBox2)
        Me.Controls.Add(Me.chkBox1)
        Me.Controls.Add(Me.lblMonogramming)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMono"
        Me.Text = "Monogramming Form"
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMonogramming As System.Windows.Forms.Label
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents radButtonYes As System.Windows.Forms.RadioButton
    Friend WithEvents radButtonNo As System.Windows.Forms.RadioButton
    Friend WithEvents chkBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtBoxItem1 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxItem2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxItem3 As System.Windows.Forms.TextBox
    Friend WithEvents lblWhatLetter As System.Windows.Forms.Label
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents txtBoxMonogramming As System.Windows.Forms.TextBox
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
End Class
