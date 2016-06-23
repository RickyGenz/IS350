<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.lblDevelopers = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDevelopers
        '
        Me.lblDevelopers.AutoSize = True
        Me.lblDevelopers.Location = New System.Drawing.Point(12, 9)
        Me.lblDevelopers.Name = "lblDevelopers"
        Me.lblDevelopers.Size = New System.Drawing.Size(86, 52)
        Me.lblDevelopers.TabIndex = 0
        Me.lblDevelopers.Text = "Developers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Ricky Genz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Pradip Pathak" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Natalie Wright"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(114, 9)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(72, 13)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version: 1.0.0"
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOk.Location = New System.Drawing.Point(117, 38)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(69, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(198, 71)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblDevelopers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAbout"
        Me.Text = "About Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDevelopers As System.Windows.Forms.Label
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
