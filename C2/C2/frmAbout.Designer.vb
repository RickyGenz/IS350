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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblPicture = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInfo.Location = New System.Drawing.Point(193, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.lblInfo.Size = New System.Drawing.Size(217, 75)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Date:            April 2, 2015" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Developer:   Ricky Genz" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Location:      Universit" & _
    "y of Nevada, Reno" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All Rights Reserved."
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOk.Location = New System.Drawing.Point(12, 187)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(398, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'lblPicture
        '
        Me.lblPicture.Image = CType(resources.GetObject("lblPicture.Image"), System.Drawing.Image)
        Me.lblPicture.Location = New System.Drawing.Point(12, 9)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(175, 175)
        Me.lblPicture.TabIndex = 0
        '
        'lblWarning
        '
        Me.lblWarning.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWarning.Location = New System.Drawing.Point(193, 94)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Padding = New System.Windows.Forms.Padding(3)
        Me.lblWarning.Size = New System.Drawing.Size(217, 90)
        Me.lblWarning.TabIndex = 4
        Me.lblWarning.Text = resources.GetString("lblWarning.Text")
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 223)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblPicture)
        Me.Name = "frmAbout"
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblPicture As System.Windows.Forms.Label
    Friend WithEvents lblWarning As System.Windows.Forms.Label
End Class
