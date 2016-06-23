<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm32
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
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(12, 41)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.ReadOnly = True
        Me.txtCount.Size = New System.Drawing.Size(145, 20)
        Me.txtCount.TabIndex = 3
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(12, 12)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(145, 23)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create New File"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'frm32
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(173, 70)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "frm32"
        Me.Text = "Justice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
End Class
