<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm30
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
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtWithdrawal = New System.Windows.Forms.TextBox()
        Me.lblWithdrawal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(15, 87)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(188, 20)
        Me.txtOutput.TabIndex = 9
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(111, 6)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(92, 20)
        Me.txtBalance.TabIndex = 8
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(66, 58)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = "Compute Cost"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(12, 9)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(85, 13)
        Me.lblBalance.TabIndex = 5
        Me.lblBalance.Text = "Current balance:"
        '
        'txtWithdrawal
        '
        Me.txtWithdrawal.Location = New System.Drawing.Point(111, 32)
        Me.txtWithdrawal.Name = "txtWithdrawal"
        Me.txtWithdrawal.Size = New System.Drawing.Size(92, 20)
        Me.txtWithdrawal.TabIndex = 11
        '
        'lblWithdrawal
        '
        Me.lblWithdrawal.AutoSize = True
        Me.lblWithdrawal.Location = New System.Drawing.Point(34, 35)
        Me.lblWithdrawal.Name = "lblWithdrawal"
        Me.lblWithdrawal.Size = New System.Drawing.Size(63, 13)
        Me.lblWithdrawal.TabIndex = 10
        Me.lblWithdrawal.Text = "Withdrawal:"
        '
        'frm30
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 114)
        Me.Controls.Add(Me.txtWithdrawal)
        Me.Controls.Add(Me.lblWithdrawal)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblBalance)
        Me.Name = "frm30"
        Me.Text = "Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents txtWithdrawal As System.Windows.Forms.TextBox
    Friend WithEvents lblWithdrawal As System.Windows.Forms.Label
End Class
