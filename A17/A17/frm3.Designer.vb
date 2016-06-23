<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm3
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtVelocity = New System.Windows.Forms.TextBox()
        Me.btnMaxHeight = New System.Windows.Forms.Button()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Initial Height (feet):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Initial Velocity (feet/second):"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(113, 6)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(51, 20)
        Me.txtHeight.TabIndex = 2
        Me.txtHeight.Text = "5"
        '
        'txtVelocity
        '
        Me.txtVelocity.Location = New System.Drawing.Point(317, 6)
        Me.txtVelocity.Name = "txtVelocity"
        Me.txtVelocity.Size = New System.Drawing.Size(36, 20)
        Me.txtVelocity.TabIndex = 3
        Me.txtVelocity.Text = "34"
        '
        'btnMaxHeight
        '
        Me.btnMaxHeight.Location = New System.Drawing.Point(12, 36)
        Me.btnMaxHeight.Name = "btnMaxHeight"
        Me.btnMaxHeight.Size = New System.Drawing.Size(171, 23)
        Me.btnMaxHeight.TabIndex = 4
        Me.btnMaxHeight.Text = "Determine Maximum Height"
        Me.btnMaxHeight.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Location = New System.Drawing.Point(12, 71)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(341, 23)
        Me.btnTime.TabIndex = 5
        Me.btnTime.Text = "Determine Approximate Time Until Ball Hits the Ground"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(189, 36)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(100, 23)
        Me.btnDisplay.TabIndex = 6
        Me.btnDisplay.Text = "Display Table"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(295, 36)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(58, 23)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(15, 100)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(338, 228)
        Me.lstOutput.TabIndex = 8
        '
        'frm3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 343)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnMaxHeight)
        Me.Controls.Add(Me.txtVelocity)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm3"
        Me.Text = "Projectile Motion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtVelocity As System.Windows.Forms.TextBox
    Friend WithEvents btnMaxHeight As System.Windows.Forms.Button
    Friend WithEvents btnTime As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
End Class
