<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseball
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
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.lblWon = New System.Windows.Forms.Label()
        Me.lblLost = New System.Windows.Forms.Label()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.txtWon = New System.Windows.Forms.TextBox()
        Me.txtLost = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Location = New System.Drawing.Point(56, 19)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(37, 13)
        Me.lblTeam.TabIndex = 0
        Me.lblTeam.Text = "Team:"
        '
        'lblWon
        '
        Me.lblWon.AutoSize = True
        Me.lblWon.Location = New System.Drawing.Point(12, 46)
        Me.lblWon.Name = "lblWon"
        Me.lblWon.Size = New System.Drawing.Size(69, 13)
        Me.lblWon.TabIndex = 1
        Me.lblWon.Text = "Games Won:"
        '
        'lblLost
        '
        Me.lblLost.AutoSize = True
        Me.lblLost.Location = New System.Drawing.Point(127, 46)
        Me.lblLost.Name = "lblLost"
        Me.lblLost.Size = New System.Drawing.Size(66, 13)
        Me.lblLost.TabIndex = 2
        Me.lblLost.Text = "Games Lost:"
        '
        'txtTeam
        '
        Me.txtTeam.Location = New System.Drawing.Point(99, 12)
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(104, 20)
        Me.txtTeam.TabIndex = 3
        '
        'txtWon
        '
        Me.txtWon.Location = New System.Drawing.Point(84, 43)
        Me.txtWon.Name = "txtWon"
        Me.txtWon.Size = New System.Drawing.Size(25, 20)
        Me.txtWon.TabIndex = 4
        '
        'txtLost
        '
        Me.txtLost.Location = New System.Drawing.Point(199, 43)
        Me.txtLost.Name = "txtLost"
        Me.txtLost.Size = New System.Drawing.Size(25, 20)
        Me.txtLost.TabIndex = 5
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(84, 74)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(25, 111)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(2, 15)
        Me.lblResult.TabIndex = 7
        '
        'frmBaseball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 135)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtLost)
        Me.Controls.Add(Me.txtWon)
        Me.Controls.Add(Me.txtTeam)
        Me.Controls.Add(Me.lblLost)
        Me.Controls.Add(Me.lblWon)
        Me.Controls.Add(Me.lblTeam)
        Me.Name = "frmBaseball"
        Me.Text = "Baseball"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTeam As System.Windows.Forms.Label
    Friend WithEvents lblWon As System.Windows.Forms.Label
    Friend WithEvents lblLost As System.Windows.Forms.Label
    Friend WithEvents txtTeam As System.Windows.Forms.TextBox
    Friend WithEvents txtWon As System.Windows.Forms.TextBox
    Friend WithEvents txtLost As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
