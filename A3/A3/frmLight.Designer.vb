<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLight
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
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.txtYellow = New System.Windows.Forms.TextBox()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtGreen
        '
        Me.txtGreen.BackColor = System.Drawing.Color.DarkGray
        Me.txtGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGreen.Location = New System.Drawing.Point(77, 92)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(35, 20)
        Me.txtGreen.TabIndex = 0
        '
        'txtYellow
        '
        Me.txtYellow.BackColor = System.Drawing.Color.DarkGray
        Me.txtYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYellow.Location = New System.Drawing.Point(77, 52)
        Me.txtYellow.Name = "txtYellow"
        Me.txtYellow.Size = New System.Drawing.Size(35, 20)
        Me.txtYellow.TabIndex = 1
        '
        'txtRed
        '
        Me.txtRed.BackColor = System.Drawing.Color.DarkGray
        Me.txtRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRed.Location = New System.Drawing.Point(77, 12)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(35, 20)
        Me.txtRed.TabIndex = 2
        '
        'frmLight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 123)
        Me.Controls.Add(Me.txtRed)
        Me.Controls.Add(Me.txtYellow)
        Me.Controls.Add(Me.txtGreen)
        Me.Name = "frmLight"
        Me.Text = "Traffic Light"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGreen As System.Windows.Forms.TextBox
    Friend WithEvents txtYellow As System.Windows.Forms.TextBox
    Friend WithEvents txtRed As System.Windows.Forms.TextBox
End Class
