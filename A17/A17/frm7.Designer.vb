<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm7
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a Word or Phrase:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(15, 25)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(257, 20)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "racecar"
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(15, 51)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(257, 23)
        Me.btnDetermine.TabIndex = 2
        Me.btnDetermine.Text = "Determine If Palindrome"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(15, 80)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(257, 20)
        Me.txtOutput.TabIndex = 3
        Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 112)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm7"
        Me.Text = "Palindrome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
