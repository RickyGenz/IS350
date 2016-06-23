<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextBoxes
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
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(12, 12)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(173, 20)
        Me.txtOne.TabIndex = 0
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(12, 38)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(173, 20)
        Me.txtTwo.TabIndex = 1
        '
        'frmTextBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(197, 74)
        Me.Controls.Add(Me.txtTwo)
        Me.Controls.Add(Me.txtOne)
        Me.Name = "frmTextBoxes"
        Me.Text = "Text Boxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOne As System.Windows.Forms.TextBox
    Friend WithEvents txtTwo As System.Windows.Forms.TextBox
End Class
