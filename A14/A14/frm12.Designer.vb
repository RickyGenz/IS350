<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm12
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.txtOvertimeHours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPayPerHour = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 80)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(257, 23)
        Me.btnCalculate.TabIndex = 21
        Me.btnCalculate.Text = "Calculate Overtime Hours and Week's Pay"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtPay
        '
        Me.txtPay.Location = New System.Drawing.Point(137, 155)
        Me.txtPay.Name = "txtPay"
        Me.txtPay.ReadOnly = True
        Me.txtPay.Size = New System.Drawing.Size(132, 20)
        Me.txtPay.TabIndex = 20
        '
        'txtOvertimeHours
        '
        Me.txtOvertimeHours.Location = New System.Drawing.Point(137, 116)
        Me.txtOvertimeHours.Name = "txtOvertimeHours"
        Me.txtOvertimeHours.ReadOnly = True
        Me.txtOvertimeHours.Size = New System.Drawing.Size(132, 20)
        Me.txtOvertimeHours.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Week's Pay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Overtime hours worked"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Hourly Pay"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Hours Worked"
        '
        'txtPayPerHour
        '
        Me.txtPayPerHour.Location = New System.Drawing.Point(137, 42)
        Me.txtPayPerHour.Name = "txtPayPerHour"
        Me.txtPayPerHour.Size = New System.Drawing.Size(132, 20)
        Me.txtPayPerHour.TabIndex = 22
        Me.txtPayPerHour.Text = "10.00"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(136, 6)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(132, 20)
        Me.txtHours.TabIndex = 23
        Me.txtHours.Text = "42"
        '
        'frm12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 189)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtPayPerHour)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPay)
        Me.Controls.Add(Me.txtOvertimeHours)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frm12"
        Me.Text = "Weekly Pay"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtPay As System.Windows.Forms.TextBox
    Friend WithEvents txtOvertimeHours As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPayPerHour As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
End Class
