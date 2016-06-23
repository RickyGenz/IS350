<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockPurchase
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
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(12, 12)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(109, 30)
        Me.lstResult.TabIndex = 0
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(127, 12)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 29)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'frmStockPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 53)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lstResult)
        Me.Name = "frmStockPurchase"
        Me.Text = "Stock Purchase"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
End Class
