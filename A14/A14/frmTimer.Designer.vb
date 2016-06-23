<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimer
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
        Me.components = New System.ComponentModel.Container()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAddMinute = New System.Windows.Forms.Button()
        Me.btnAddSecond = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Location = New System.Drawing.Point(68, 9)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(44, 13)
        Me.lblMinutes.TabIndex = 0
        Me.lblMinutes.Text = "Minutes"
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Location = New System.Drawing.Point(226, 9)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(49, 13)
        Me.lblSeconds.TabIndex = 1
        Me.lblSeconds.Text = "Seconds"
        '
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(174, 25)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(156, 20)
        Me.txtSeconds.TabIndex = 3
        Me.txtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMinutes
        '
        Me.txtMinutes.Location = New System.Drawing.Point(12, 25)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.Size = New System.Drawing.Size(156, 20)
        Me.txtMinutes.TabIndex = 2
        Me.txtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 51)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(93, 51)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAddMinute
        '
        Me.btnAddMinute.Location = New System.Drawing.Point(174, 51)
        Me.btnAddMinute.Name = "btnAddMinute"
        Me.btnAddMinute.Size = New System.Drawing.Size(75, 23)
        Me.btnAddMinute.TabIndex = 6
        Me.btnAddMinute.Text = "Minutes +1"
        Me.btnAddMinute.UseVisualStyleBackColor = True
        '
        'btnAddSecond
        '
        Me.btnAddSecond.Location = New System.Drawing.Point(255, 51)
        Me.btnAddSecond.Name = "btnAddSecond"
        Me.btnAddSecond.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSecond.TabIndex = 7
        Me.btnAddSecond.Text = "Seconds +1"
        Me.btnAddSecond.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'frmTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 88)
        Me.Controls.Add(Me.btnAddSecond)
        Me.Controls.Add(Me.btnAddMinute)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTimer"
        Me.Text = "Kitchen Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents txtSeconds As System.Windows.Forms.TextBox
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAddMinute As System.Windows.Forms.Button
    Friend WithEvents btnAddSecond As System.Windows.Forms.Button
    Friend WithEvents Timer As System.Windows.Forms.Timer
End Class
