<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGasMileage
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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(13, 12)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(187, 29)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "Compute Gas Mileage"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(76, 47)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(60, 17)
        Me.lstResult.TabIndex = 2
        '
        'frmGasMileage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(211, 75)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lstResult)
        Me.Name = "frmGasMileage"
        Me.Text = "Gas Mileage"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
End Class
