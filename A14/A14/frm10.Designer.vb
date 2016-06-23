<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm10
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOldBalance = New System.Windows.Forms.TextBox()
        Me.txtCharges = New System.Windows.Forms.TextBox()
        Me.txtCredits = New System.Windows.Forms.TextBox()
        Me.txtNewBalance = New System.Windows.Forms.TextBox()
        Me.txtMinPayment = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Charges"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Credits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "New Balance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Minimum Payment"
        '
        'txtOldBalance
        '
        Me.txtOldBalance.Location = New System.Drawing.Point(140, 6)
        Me.txtOldBalance.Name = "txtOldBalance"
        Me.txtOldBalance.Size = New System.Drawing.Size(132, 20)
        Me.txtOldBalance.TabIndex = 5
        Me.txtOldBalance.Text = "200"
        '
        'txtCharges
        '
        Me.txtCharges.Location = New System.Drawing.Point(57, 41)
        Me.txtCharges.Name = "txtCharges"
        Me.txtCharges.Size = New System.Drawing.Size(64, 20)
        Me.txtCharges.TabIndex = 6
        Me.txtCharges.Text = "150"
        '
        'txtCredits
        '
        Me.txtCredits.Location = New System.Drawing.Point(182, 41)
        Me.txtCredits.Name = "txtCredits"
        Me.txtCredits.Size = New System.Drawing.Size(90, 20)
        Me.txtCredits.TabIndex = 7
        Me.txtCredits.Text = "100"
        '
        'txtNewBalance
        '
        Me.txtNewBalance.Location = New System.Drawing.Point(140, 116)
        Me.txtNewBalance.Name = "txtNewBalance"
        Me.txtNewBalance.ReadOnly = True
        Me.txtNewBalance.Size = New System.Drawing.Size(132, 20)
        Me.txtNewBalance.TabIndex = 8
        '
        'txtMinPayment
        '
        Me.txtMinPayment.Location = New System.Drawing.Point(140, 155)
        Me.txtMinPayment.Name = "txtMinPayment"
        Me.txtMinPayment.ReadOnly = True
        Me.txtMinPayment.Size = New System.Drawing.Size(132, 20)
        Me.txtMinPayment.TabIndex = 9
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(15, 80)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(257, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate New Bal. and Min. Payment"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'frm10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 190)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtMinPayment)
        Me.Controls.Add(Me.txtNewBalance)
        Me.Controls.Add(Me.txtCredits)
        Me.Controls.Add(Me.txtCharges)
        Me.Controls.Add(Me.txtOldBalance)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm10"
        Me.Text = "Credit Card"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOldBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtCredits As System.Windows.Forms.TextBox
    Friend WithEvents txtNewBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtMinPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
