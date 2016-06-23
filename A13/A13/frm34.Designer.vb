<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm34
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
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Location = New System.Drawing.Point(9, 9)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(108, 13)
        Me.lblOccupation.TabIndex = 0
        Me.lblOccupation.Text = "Person's Occupation:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(25, 41)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(92, 13)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Amount of the Bill:"
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(29, 72)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(83, 13)
        Me.lblPercentage.TabIndex = 2
        Me.lblPercentage.Text = "Percentage Tip:"
        '
        'txtOccupation
        '
        Me.txtOccupation.Location = New System.Drawing.Point(123, 6)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(100, 20)
        Me.txtOccupation.TabIndex = 3
        Me.txtOccupation.Text = "Taxi Driver"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(123, 38)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 4
        Me.txtAmount.Text = "20.00"
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(123, 69)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentage.TabIndex = 5
        Me.txtPercentage.Text = "15"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(12, 95)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(211, 23)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute Tip"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 124)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(211, 20)
        Me.txtOutput.TabIndex = 7
        '
        'frm34
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 156)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtOccupation)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblOccupation)
        Me.Name = "frm34"
        Me.Text = "Gratuities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOccupation As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblPercentage As System.Windows.Forms.Label
    Friend WithEvents txtOccupation As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
