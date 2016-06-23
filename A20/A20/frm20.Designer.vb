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
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(12, 12)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(138, 23)
        Me.btnSort.TabIndex = 0
        Me.btnSort.Text = "Sort the Words"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lstBox
        '
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.Items.AddRange(New Object() {"in", "order", "to", "create", "a", "more", "perfect"})
        Me.lstBox.Location = New System.Drawing.Point(12, 41)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(138, 121)
        Me.lstBox.TabIndex = 1
        '
        'frm20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(162, 176)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.btnSort)
        Me.Name = "frm20"
        Me.Text = "Words"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lstBox As System.Windows.Forms.ListBox
End Class
