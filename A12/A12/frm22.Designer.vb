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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnDetermine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(54, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Minimum:"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(34, 6)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(20, 20)
        Me.txt1.TabIndex = 4
        Me.txt1.Text = "3"
        Me.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(114, 6)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(20, 20)
        Me.txt2.TabIndex = 5
        Me.txt2.Text = "7"
        Me.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(194, 6)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(20, 20)
        Me.txt3.TabIndex = 6
        Me.txt3.Text = "6"
        Me.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(114, 61)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(20, 20)
        Me.txtResult.TabIndex = 7
        Me.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDetermine
        '
        Me.btnDetermine.Location = New System.Drawing.Point(12, 32)
        Me.btnDetermine.Name = "btnDetermine"
        Me.btnDetermine.Size = New System.Drawing.Size(202, 23)
        Me.btnDetermine.TabIndex = 8
        Me.btnDetermine.Text = "Determine Minimum"
        Me.btnDetermine.UseVisualStyleBackColor = True
        '
        'frm22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 87)
        Me.Controls.Add(Me.btnDetermine)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm22"
        Me.Text = "Minimum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnDetermine As System.Windows.Forms.Button
End Class
