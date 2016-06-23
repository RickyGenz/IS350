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
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtHigh = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(13, 15)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(38, 13)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "Score:"
        '
        'lblHigh
        '
        Me.lblHigh.AutoSize = True
        Me.lblHigh.Location = New System.Drawing.Point(13, 101)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(102, 13)
        Me.lblHigh.TabIndex = 1
        Me.lblHigh.Text = "Two highest scores:"
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(57, 12)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(144, 20)
        Me.txtScore.TabIndex = 2
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(16, 36)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(185, 23)
        Me.btnRead.TabIndex = 3
        Me.btnRead.Text = "Read Current Score"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(16, 65)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(185, 23)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display Two Highest Scores"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtHigh
        '
        Me.txtHigh.Location = New System.Drawing.Point(120, 98)
        Me.txtHigh.Name = "txtHigh"
        Me.txtHigh.ReadOnly = True
        Me.txtHigh.Size = New System.Drawing.Size(81, 20)
        Me.txtHigh.TabIndex = 5
        '
        'frm36
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 127)
        Me.Controls.Add(Me.txtHigh)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.lblScore)
        Me.Name = "frm36"
        Me.Text = "Highest Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblHigh As System.Windows.Forms.Label
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents btnRead As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents txtHigh As System.Windows.Forms.TextBox
End Class
