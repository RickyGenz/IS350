<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm76
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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.mtxtDate = New System.Windows.Forms.MaskedTextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(2, 43)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(73, 13)
        Me.lblOutput.TabIndex = 11
        Me.lblOutput.Text = "Day of Week:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(6, 15)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(69, 13)
        Me.lblDate.TabIndex = 10
        Me.lblDate.Text = "Date of Birth:"
        '
        'mtxtDate
        '
        Me.mtxtDate.Location = New System.Drawing.Point(81, 12)
        Me.mtxtDate.Mask = "00/00/0000"
        Me.mtxtDate.Name = "mtxtDate"
        Me.mtxtDate.Size = New System.Drawing.Size(100, 20)
        Me.mtxtDate.TabIndex = 9
        Me.mtxtDate.ValidatingType = GetType(Date)
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(187, 26)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(69, 23)
        Me.btnDetermine.TabIndex = 8
        Me.btnDetermine.Text = "Determine"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(81, 40)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtOutput.TabIndex = 7
        '
        'frm76
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 69)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.mtxtDate)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtOutput)
        Me.Name = "frm76"
        Me.Text = "76"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents mtxtDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
