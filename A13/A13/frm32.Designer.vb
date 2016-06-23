<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm32
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(11, 40)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(324, 60)
        Me.lstOutput.TabIndex = 11
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(117, 11)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(112, 23)
        Me.btnDisplay.TabIndex = 10
        Me.btnDisplay.Text = "Display Information"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frm32
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 108)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "frm32"
        Me.Text = "Languages"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
End Class
