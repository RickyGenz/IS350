<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm22
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.lstReceipt = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 12)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(258, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create Sales Receipt"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'lstReceipt
        '
        Me.lstReceipt.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstReceipt.FormattingEnabled = True
        Me.lstReceipt.ItemHeight = 14
        Me.lstReceipt.Location = New System.Drawing.Point(12, 41)
        Me.lstReceipt.Name = "lstReceipt"
        Me.lstReceipt.Size = New System.Drawing.Size(258, 88)
        Me.lstReceipt.TabIndex = 1
        '
        'frm22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 149)
        Me.Controls.Add(Me.lstReceipt)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "frm22"
        Me.Text = "Cowboys"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents lstReceipt As System.Windows.Forms.ListBox
End Class
