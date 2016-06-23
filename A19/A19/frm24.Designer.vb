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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(153, 23)
        Me.btnDisplay.TabIndex = 0
        Me.btnDisplay.Text = "Display Teams"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(12, 41)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(153, 95)
        Me.lstOutput.TabIndex = 1
        '
        'frm24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(177, 146)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "frm24"
        Me.Text = "Baseball"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
End Class
