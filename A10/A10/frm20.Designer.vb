<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm20
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
        Me.grpCitizen = New System.Windows.Forms.GroupBox()
        Me.rdoCNo = New System.Windows.Forms.RadioButton()
        Me.rdoCYes = New System.Windows.Forms.RadioButton()
        Me.grpResident = New System.Windows.Forms.GroupBox()
        Me.rdoRNo = New System.Windows.Forms.RadioButton()
        Me.rdoRYes = New System.Windows.Forms.RadioButton()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.MaskedTextBox()
        Me.grpCitizen.SuspendLayout()
        Me.grpResident.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCitizen
        '
        Me.grpCitizen.Controls.Add(Me.rdoCNo)
        Me.grpCitizen.Controls.Add(Me.rdoCYes)
        Me.grpCitizen.Location = New System.Drawing.Point(12, 12)
        Me.grpCitizen.Name = "grpCitizen"
        Me.grpCitizen.Size = New System.Drawing.Size(129, 72)
        Me.grpCitizen.TabIndex = 0
        Me.grpCitizen.TabStop = False
        Me.grpCitizen.Text = "Natural-born Citizen?"
        '
        'rdoCNo
        '
        Me.rdoCNo.AutoSize = True
        Me.rdoCNo.Location = New System.Drawing.Point(14, 42)
        Me.rdoCNo.Name = "rdoCNo"
        Me.rdoCNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoCNo.TabIndex = 1
        Me.rdoCNo.TabStop = True
        Me.rdoCNo.Text = "No"
        Me.rdoCNo.UseVisualStyleBackColor = True
        '
        'rdoCYes
        '
        Me.rdoCYes.AutoSize = True
        Me.rdoCYes.Checked = True
        Me.rdoCYes.Location = New System.Drawing.Point(14, 19)
        Me.rdoCYes.Name = "rdoCYes"
        Me.rdoCYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoCYes.TabIndex = 0
        Me.rdoCYes.TabStop = True
        Me.rdoCYes.Text = "Yes"
        Me.rdoCYes.UseVisualStyleBackColor = True
        '
        'grpResident
        '
        Me.grpResident.Controls.Add(Me.rdoRNo)
        Me.grpResident.Controls.Add(Me.rdoRYes)
        Me.grpResident.Location = New System.Drawing.Point(147, 12)
        Me.grpResident.Name = "grpResident"
        Me.grpResident.Size = New System.Drawing.Size(133, 72)
        Me.grpResident.TabIndex = 1
        Me.grpResident.TabStop = False
        Me.grpResident.Text = "14-year U.S. Resident?"
        '
        'rdoRNo
        '
        Me.rdoRNo.AutoSize = True
        Me.rdoRNo.Location = New System.Drawing.Point(16, 42)
        Me.rdoRNo.Name = "rdoRNo"
        Me.rdoRNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoRNo.TabIndex = 1
        Me.rdoRNo.TabStop = True
        Me.rdoRNo.Text = "No"
        Me.rdoRNo.UseVisualStyleBackColor = True
        '
        'rdoRYes
        '
        Me.rdoRYes.AutoSize = True
        Me.rdoRYes.Checked = True
        Me.rdoRYes.Location = New System.Drawing.Point(16, 19)
        Me.rdoRYes.Name = "rdoRYes"
        Me.rdoRYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoRYes.TabIndex = 0
        Me.rdoRYes.TabStop = True
        Me.rdoRYes.Text = "Yes"
        Me.rdoRYes.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(72, 101)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(69, 13)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date of Birth:"
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(12, 124)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(268, 23)
        Me.btnDetermine.TabIndex = 4
        Me.btnDetermine.Text = "Determine Eligibility to Run for President in 2016"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 153)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(268, 20)
        Me.txtResult.TabIndex = 5
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(147, 98)
        Me.txtDate.Mask = "00/00/0000"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 6
        Me.txtDate.Text = "12221980"
        Me.txtDate.ValidatingType = GetType(Date)
        '
        'frm20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 185)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.grpResident)
        Me.Controls.Add(Me.grpCitizen)
        Me.Name = "frm20"
        Me.Text = "Presidential Eligibility"
        Me.grpCitizen.ResumeLayout(False)
        Me.grpCitizen.PerformLayout()
        Me.grpResident.ResumeLayout(False)
        Me.grpResident.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCitizen As System.Windows.Forms.GroupBox
    Friend WithEvents rdoCNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCYes As System.Windows.Forms.RadioButton
    Friend WithEvents grpResident As System.Windows.Forms.GroupBox
    Friend WithEvents rdoRNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.MaskedTextBox
End Class
