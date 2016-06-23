<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalyzeNumbers
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
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtRight = New System.Windows.Forms.TextBox()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(43, 50)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(126, 23)
        Me.btnDetermine.TabIndex = 14
        Me.btnDetermine.Text = "Determine"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'txtLeft
        '
        Me.txtLeft.Location = New System.Drawing.Point(122, 86)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.ReadOnly = True
        Me.txtLeft.Size = New System.Drawing.Size(69, 20)
        Me.txtLeft.TabIndex = 13
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(106, 15)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(85, 20)
        Me.txtPhone.TabIndex = 12
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Location = New System.Drawing.Point(40, 89)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(69, 13)
        Me.lblLeft.TabIndex = 11
        Me.lblLeft.Text = "Digits to Left:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(19, 18)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(87, 13)
        Me.lblNumber.TabIndex = 10
        Me.lblNumber.Text = "Positive Number:"
        '
        'txtRight
        '
        Me.txtRight.Location = New System.Drawing.Point(122, 112)
        Me.txtRight.Name = "txtRight"
        Me.txtRight.ReadOnly = True
        Me.txtRight.Size = New System.Drawing.Size(69, 20)
        Me.txtRight.TabIndex = 16
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Location = New System.Drawing.Point(40, 115)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(76, 13)
        Me.lblRight.TabIndex = 15
        Me.lblRight.Text = "Digits to Right:"
        '
        'frmAnalyzeNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 143)
        Me.Controls.Add(Me.txtRight)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtLeft)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "frmAnalyzeNumbers"
        Me.Text = "Analyze Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents txtRight As System.Windows.Forms.TextBox
    Friend WithEvents lblRight As System.Windows.Forms.Label
End Class
