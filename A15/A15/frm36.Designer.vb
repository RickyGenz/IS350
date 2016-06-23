<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm36
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(12, 12)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(216, 23)
        Me.btnDetermine.TabIndex = 0
        Me.btnDetermine.Text = "Determine When Annuity Is Worth $3000"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 41)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(216, 20)
        Me.txtOutput.TabIndex = 1
        '
        'frm36
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 75)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnDetermine)
        Me.Name = "frm36"
        Me.Text = "Annuity"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
End Class
