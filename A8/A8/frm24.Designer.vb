<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm24
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
        Me.lblCopies = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtCopies = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCopies
        '
        Me.lblCopies.AutoSize = True
        Me.lblCopies.Location = New System.Drawing.Point(12, 9)
        Me.lblCopies.Name = "lblCopies"
        Me.lblCopies.Size = New System.Drawing.Size(93, 13)
        Me.lblCopies.TabIndex = 0
        Me.lblCopies.Text = "Number of copies:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(74, 66)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(31, 13)
        Me.lblCost.TabIndex = 1
        Me.lblCost.Text = "Cost:"
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(63, 34)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 2
        Me.btnCompute.Text = "Compute Cost"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtCopies
        '
        Me.txtCopies.Location = New System.Drawing.Point(111, 6)
        Me.txtCopies.Name = "txtCopies"
        Me.txtCopies.Size = New System.Drawing.Size(92, 20)
        Me.txtCopies.TabIndex = 3
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(111, 63)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.ReadOnly = True
        Me.txtCost.Size = New System.Drawing.Size(92, 20)
        Me.txtCost.TabIndex = 4
        '
        'frm24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 91)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtCopies)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblCopies)
        Me.Name = "frm24"
        Me.Text = "Cost of Copies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCopies As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents txtCopies As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
End Class
