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
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstCosts = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(107, 14)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(53, 20)
        Me.txtDay.TabIndex = 0
        Me.txtDay.Text = "3"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(166, 12)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(193, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate Cost of Gifts"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstCosts
        '
        Me.lstCosts.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCosts.FormattingEnabled = True
        Me.lstCosts.ItemHeight = 14
        Me.lstCosts.Location = New System.Drawing.Point(12, 41)
        Me.lstCosts.Name = "lstCosts"
        Me.lstCosts.Size = New System.Drawing.Size(347, 116)
        Me.lstCosts.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Day of Christmas:"
        '
        'frm36
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 170)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstCosts)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtDay)
        Me.Name = "frm36"
        Me.Text = "The Twelve Days of Christmas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstCosts As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
