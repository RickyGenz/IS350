<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm24
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstBalance = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount to be deposited at the beginning of each month:"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(160, 24)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(42, 20)
        Me.txtDeposit.TabIndex = 1
        Me.txtDeposit.Text = "1000"
        Me.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(15, 50)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(187, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Monthly Balances"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstBalance
        '
        Me.lstBalance.FormattingEnabled = True
        Me.lstBalance.Location = New System.Drawing.Point(15, 89)
        Me.lstBalance.Name = "lstBalance"
        Me.lstBalance.Size = New System.Drawing.Size(187, 69)
        Me.lstBalance.TabIndex = 3
        '
        'frm24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 170)
        Me.Controls.Add(Me.lstBalance)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm24"
        Me.Text = "Investment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lstBalance As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
