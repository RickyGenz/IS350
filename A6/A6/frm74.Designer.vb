<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm74
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.mtxtDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(82, 34)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtOutput.TabIndex = 1
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(188, 20)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(69, 23)
        Me.btnDetermine.TabIndex = 3
        Me.btnDetermine.Text = "Determine"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'mtxtDate
        '
        Me.mtxtDate.Location = New System.Drawing.Point(82, 6)
        Me.mtxtDate.Mask = "00/00/0000"
        Me.mtxtDate.Name = "mtxtDate"
        Me.mtxtDate.Size = New System.Drawing.Size(100, 20)
        Me.mtxtDate.TabIndex = 4
        Me.mtxtDate.ValidatingType = GetType(Date)
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(43, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 5
        Me.lblDate.Text = "Date:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(3, 37)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(73, 13)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.Text = "Day of Week:"
        '
        'frm74
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 60)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.mtxtDate)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtOutput)
        Me.Name = "frm74"
        Me.Text = "74"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
    Friend WithEvents mtxtDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
End Class
