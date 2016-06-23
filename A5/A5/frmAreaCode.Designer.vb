<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAreaCode
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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(36, 47)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(126, 23)
        Me.btnDisplay.TabIndex = 9
        Me.btnDisplay.Text = "Display Area Code"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(99, 83)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.ReadOnly = True
        Me.txtArea.Size = New System.Drawing.Size(85, 20)
        Me.txtArea.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(99, 12)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(85, 20)
        Me.txtPhone.TabIndex = 7
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(33, 86)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(60, 13)
        Me.lblArea.TabIndex = 6
        Me.lblArea.Text = "Area Code:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(12, 15)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(81, 13)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone Number:"
        '
        'frmAreaCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 117)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtArea)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.lblPhone)
        Me.Name = "frmAreaCode"
        Me.Text = "Area Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents txtArea As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
End Class
