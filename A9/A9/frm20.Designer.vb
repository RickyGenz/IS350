<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm20
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
        Me.lstOutputOld = New System.Windows.Forms.ListBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lstOutputNew = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstOutputOld
        '
        Me.lstOutputOld.FormattingEnabled = True
        Me.lstOutputOld.Location = New System.Drawing.Point(12, 12)
        Me.lstOutputOld.Name = "lstOutputOld"
        Me.lstOutputOld.Size = New System.Drawing.Size(154, 95)
        Me.lstOutputOld.TabIndex = 0
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 113)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(315, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lstOutputNew
        '
        Me.lstOutputNew.FormattingEnabled = True
        Me.lstOutputNew.Location = New System.Drawing.Point(172, 12)
        Me.lstOutputNew.Name = "lstOutputNew"
        Me.lstOutputNew.Size = New System.Drawing.Size(154, 95)
        Me.lstOutputNew.TabIndex = 3
        '
        'frm20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 147)
        Me.Controls.Add(Me.lstOutputNew)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lstOutputOld)
        Me.Name = "frm20"
        Me.Text = "Form 20"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstOutputOld As System.Windows.Forms.ListBox
    Friend WithEvents btnInput As System.Windows.Forms.Button
    Friend WithEvents lstOutputNew As System.Windows.Forms.ListBox
End Class
