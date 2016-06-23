<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm22
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
        Me.btnInputOld = New System.Windows.Forms.Button()
        Me.txtOutputOld = New System.Windows.Forms.TextBox()
        Me.txtOutputNew = New System.Windows.Forms.TextBox()
        Me.btnInputNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInputOld
        '
        Me.btnInputOld.Location = New System.Drawing.Point(12, 38)
        Me.btnInputOld.Name = "btnInputOld"
        Me.btnInputOld.Size = New System.Drawing.Size(100, 23)
        Me.btnInputOld.TabIndex = 5
        Me.btnInputOld.Text = "Input Old"
        Me.btnInputOld.UseVisualStyleBackColor = True
        '
        'txtOutputOld
        '
        Me.txtOutputOld.Location = New System.Drawing.Point(12, 12)
        Me.txtOutputOld.Name = "txtOutputOld"
        Me.txtOutputOld.Size = New System.Drawing.Size(100, 20)
        Me.txtOutputOld.TabIndex = 6
        '
        'txtOutputNew
        '
        Me.txtOutputNew.Location = New System.Drawing.Point(118, 12)
        Me.txtOutputNew.Name = "txtOutputNew"
        Me.txtOutputNew.Size = New System.Drawing.Size(100, 20)
        Me.txtOutputNew.TabIndex = 7
        '
        'btnInputNew
        '
        Me.btnInputNew.Location = New System.Drawing.Point(118, 38)
        Me.btnInputNew.Name = "btnInputNew"
        Me.btnInputNew.Size = New System.Drawing.Size(100, 23)
        Me.btnInputNew.TabIndex = 8
        Me.btnInputNew.Text = "Input New"
        Me.btnInputNew.UseVisualStyleBackColor = True
        '
        'frm22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 71)
        Me.Controls.Add(Me.btnInputNew)
        Me.Controls.Add(Me.txtOutputNew)
        Me.Controls.Add(Me.txtOutputOld)
        Me.Controls.Add(Me.btnInputOld)
        Me.Name = "frm22"
        Me.Text = "Form 22"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnInputOld As System.Windows.Forms.Button
    Friend WithEvents txtOutputOld As System.Windows.Forms.TextBox
    Friend WithEvents txtOutputNew As System.Windows.Forms.TextBox
    Friend WithEvents btnInputNew As System.Windows.Forms.Button
End Class
