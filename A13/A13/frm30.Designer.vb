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
        Me.lblDoB = New System.Windows.Forms.Label()
        Me.lblToday = New System.Windows.Forms.Label()
        Me.txtDoB = New System.Windows.Forms.TextBox()
        Me.txtToday = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblDoB
        '
        Me.lblDoB.AutoSize = True
        Me.lblDoB.Location = New System.Drawing.Point(12, 9)
        Me.lblDoB.Name = "lblDoB"
        Me.lblDoB.Size = New System.Drawing.Size(57, 13)
        Me.lblDoB.TabIndex = 0
        Me.lblDoB.Text = "Birth Date:"
        '
        'lblToday
        '
        Me.lblToday.AutoSize = True
        Me.lblToday.Location = New System.Drawing.Point(147, 9)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(40, 13)
        Me.lblToday.TabIndex = 1
        Me.lblToday.Text = "Today:"
        '
        'txtDoB
        '
        Me.txtDoB.Location = New System.Drawing.Point(75, 6)
        Me.txtDoB.Name = "txtDoB"
        Me.txtDoB.Size = New System.Drawing.Size(66, 20)
        Me.txtDoB.TabIndex = 2
        Me.txtDoB.Text = "12/23/1994"
        '
        'txtToday
        '
        Me.txtToday.Location = New System.Drawing.Point(193, 6)
        Me.txtToday.Name = "txtToday"
        Me.txtToday.Size = New System.Drawing.Size(66, 20)
        Me.txtToday.TabIndex = 3
        Me.txtToday.Text = "10/11/2013"
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(75, 32)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(112, 23)
        Me.btnDetermine.TabIndex = 4
        Me.btnDetermine.Text = "Determine Age"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(15, 60)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(244, 46)
        Me.lstOutput.TabIndex = 5
        '
        'frm30
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 115)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtToday)
        Me.Controls.Add(Me.txtDoB)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.lblDoB)
        Me.Name = "frm30"
        Me.Text = "Age"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDoB As System.Windows.Forms.Label
    Friend WithEvents lblToday As System.Windows.Forms.Label
    Friend WithEvents txtDoB As System.Windows.Forms.TextBox
    Friend WithEvents txtToday As System.Windows.Forms.TextBox
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox

End Class
