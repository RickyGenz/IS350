<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextBox
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
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(12, 12)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(156, 20)
        Me.txtBox.TabIndex = 0
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(12, 38)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(156, 23)
        Me.btnDisable.TabIndex = 1
        Me.btnDisable.Text = "Disable Text Box"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'btnEnable
        '
        Me.btnEnable.Location = New System.Drawing.Point(12, 67)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(156, 23)
        Me.btnEnable.TabIndex = 2
        Me.btnEnable.Text = "Enable Text Box"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'frmTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(180, 101)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.txtBox)
        Me.Name = "frmTextBox"
        Me.Text = "Text Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBox As System.Windows.Forms.TextBox
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents btnEnable As System.Windows.Forms.Button
End Class
