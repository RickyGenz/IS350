<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm18
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
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(12, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(177, 23)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Find Sum of 1 through 100"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 41)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(177, 20)
        Me.txtOutput.TabIndex = 1
        '
        'frm18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 73)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnFind)
        Me.Name = "frm18"
        Me.Text = "Sum Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
