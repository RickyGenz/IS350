<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCasino
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
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnWinnings = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Visual Basic Casino"
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(37, 66)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.ReadOnly = True
        Me.txtOne.Size = New System.Drawing.Size(20, 20)
        Me.txtOne.TabIndex = 1
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(109, 66)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.ReadOnly = True
        Me.txtThree.Size = New System.Drawing.Size(20, 20)
        Me.txtThree.TabIndex = 2
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(73, 66)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.ReadOnly = True
        Me.txtTwo.Size = New System.Drawing.Size(20, 20)
        Me.txtTwo.TabIndex = 3
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(73, 95)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(161, 23)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnWinnings
        '
        Me.btnWinnings.Location = New System.Drawing.Point(159, 38)
        Me.btnWinnings.Name = "btnWinnings"
        Me.btnWinnings.Size = New System.Drawing.Size(75, 23)
        Me.btnWinnings.TabIndex = 5
        Me.btnWinnings.Text = "Winnings"
        Me.btnWinnings.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(159, 67)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(17, 40)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(136, 20)
        Me.txtOutput.TabIndex = 7
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(17, 95)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(40, 20)
        Me.txtInput.TabIndex = 8
        Me.txtInput.Text = "10"
        '
        'frmCasino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 127)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnWinnings)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtThree)
        Me.Controls.Add(Me.txtOne)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCasino"
        Me.Text = "VB Casino"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOne As System.Windows.Forms.TextBox
    Friend WithEvents txtThree As System.Windows.Forms.TextBox
    Friend WithEvents txtTwo As System.Windows.Forms.TextBox
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnWinnings As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
End Class
