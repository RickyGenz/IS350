<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm10_16
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
        Me.cboBox = New System.Windows.Forms.ComboBox()
        Me.btn10 = New System.Windows.Forms.Button()
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn14 = New System.Windows.Forms.Button()
        Me.btn16 = New System.Windows.Forms.Button()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cboBox
        '
        Me.cboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboBox.FormattingEnabled = True
        Me.cboBox.Items.AddRange(New Object() {"Dante", "Goethe", "Moliere", "Shakespeare"})
        Me.cboBox.Location = New System.Drawing.Point(12, 12)
        Me.cboBox.Name = "cboBox"
        Me.cboBox.Size = New System.Drawing.Size(162, 98)
        Me.cboBox.Sorted = True
        Me.cboBox.TabIndex = 0
        '
        'btn10
        '
        Me.btn10.Location = New System.Drawing.Point(180, 12)
        Me.btn10.Name = "btn10"
        Me.btn10.Size = New System.Drawing.Size(68, 23)
        Me.btn10.TabIndex = 1
        Me.btn10.Text = "No 10"
        Me.btn10.UseVisualStyleBackColor = True
        '
        'btn12
        '
        Me.btn12.Location = New System.Drawing.Point(180, 41)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(68, 23)
        Me.btn12.TabIndex = 2
        Me.btn12.Text = "No 12"
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn14
        '
        Me.btn14.Location = New System.Drawing.Point(180, 70)
        Me.btn14.Name = "btn14"
        Me.btn14.Size = New System.Drawing.Size(68, 23)
        Me.btn14.TabIndex = 3
        Me.btn14.Text = "No 14"
        Me.btn14.UseVisualStyleBackColor = True
        '
        'btn16
        '
        Me.btn16.Location = New System.Drawing.Point(180, 99)
        Me.btn16.Name = "btn16"
        Me.btn16.Size = New System.Drawing.Size(68, 23)
        Me.btn16.TabIndex = 4
        Me.btn16.Text = "No 16"
        Me.btn16.UseVisualStyleBackColor = True
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Location = New System.Drawing.Point(12, 116)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(162, 43)
        Me.lstBox.TabIndex = 5
        '
        'frm10_16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 171)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.btn16)
        Me.Controls.Add(Me.btn14)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.btn10)
        Me.Controls.Add(Me.cboBox)
        Me.Name = "frm10_16"
        Me.Text = "Exercises 10-16"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cboBox As System.Windows.Forms.ComboBox
    Friend WithEvents btn10 As System.Windows.Forms.Button
    Friend WithEvents btn12 As System.Windows.Forms.Button
    Friend WithEvents btn14 As System.Windows.Forms.Button
    Friend WithEvents btn16 As System.Windows.Forms.Button
    Friend WithEvents lstBox As System.Windows.Forms.ListBox
End Class
