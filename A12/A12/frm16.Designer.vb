<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm16
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
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtRHR = New System.Windows.Forms.TextBox()
        Me.txtTHR = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resting Heart Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "THR:"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(45, 6)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(27, 20)
        Me.txtAge.TabIndex = 3
        Me.txtAge.Text = "20"
        '
        'txtRHR
        '
        Me.txtRHR.Location = New System.Drawing.Point(185, 6)
        Me.txtRHR.Name = "txtRHR"
        Me.txtRHR.Size = New System.Drawing.Size(26, 20)
        Me.txtRHR.TabIndex = 4
        Me.txtRHR.Text = "70"
        '
        'txtTHR
        '
        Me.txtTHR.Location = New System.Drawing.Point(117, 62)
        Me.txtTHR.Name = "txtTHR"
        Me.txtTHR.ReadOnly = True
        Me.txtTHR.Size = New System.Drawing.Size(29, 20)
        Me.txtTHR.TabIndex = 5
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(12, 32)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(201, 23)
        Me.btnDetermine.TabIndex = 6
        Me.btnDetermine.Text = "Determine Training Heart Rate"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'frm16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 90)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtTHR)
        Me.Controls.Add(Me.txtRHR)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm16"
        Me.Text = "Heart Rate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtRHR As System.Windows.Forms.TextBox
    Friend WithEvents txtTHR As System.Windows.Forms.TextBox
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
End Class
