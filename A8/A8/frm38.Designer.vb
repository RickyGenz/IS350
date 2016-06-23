<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm38
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
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Location = New System.Drawing.Point(12, 9)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(85, 13)
        Me.lblIncome.TabIndex = 0
        Me.lblIncome.Text = "Taxable income:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(12, 62)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 1
        Me.lblTax.Text = "Tax:"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(103, 6)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(72, 20)
        Me.txtIncome.TabIndex = 0
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(46, 59)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.ReadOnly = True
        Me.txtTax.Size = New System.Drawing.Size(129, 20)
        Me.txtTax.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(55, 30)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Tax"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frm38
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(187, 88)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblIncome)
        Me.Name = "frm38"
        Me.Text = "Income Tax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblIncome As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtIncome As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
