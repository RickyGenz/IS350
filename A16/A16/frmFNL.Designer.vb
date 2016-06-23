<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFNL
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
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnTip = New System.Windows.Forms.Button()
        Me.txtTip = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(12, 12)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(476, 214)
        Me.lstOutput.TabIndex = 0
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Location = New System.Drawing.Point(494, 40)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(106, 23)
        Me.btnMultiplication.TabIndex = 1
        Me.btnMultiplication.Text = "Multiplication"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(494, 85)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(106, 23)
        Me.btnDivision.TabIndex = 2
        Me.btnDivision.Text = "Division"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnTip
        '
        Me.btnTip.Location = New System.Drawing.Point(494, 130)
        Me.btnTip.Name = "btnTip"
        Me.btnTip.Size = New System.Drawing.Size(106, 23)
        Me.btnTip.TabIndex = 3
        Me.btnTip.Text = "Tipping"
        Me.btnTip.UseVisualStyleBackColor = True
        '
        'txtTip
        '
        Me.txtTip.Location = New System.Drawing.Point(494, 175)
        Me.txtTip.Name = "txtTip"
        Me.txtTip.Size = New System.Drawing.Size(106, 20)
        Me.txtTip.TabIndex = 4
        Me.txtTip.Text = "0.15"
        '
        'frmFNL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 242)
        Me.Controls.Add(Me.txtTip)
        Me.Controls.Add(Me.btnTip)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.lstOutput)
        Me.Name = "frmFNL"
        Me.Text = "Multiplication and Tipping Tables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnMultiplication As System.Windows.Forms.Button
    Friend WithEvents btnDivision As System.Windows.Forms.Button
    Friend WithEvents btnTip As System.Windows.Forms.Button
    Friend WithEvents txtTip As System.Windows.Forms.TextBox
End Class
