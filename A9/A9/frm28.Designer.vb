<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm28
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
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnComputeTotal = New System.Windows.Forms.Button()
        Me.txtRegistrants = New System.Windows.Forms.TextBox()
        Me.lblRegistrants = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(92, 61)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(95, 20)
        Me.txtTotalCost.TabIndex = 9
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(28, 64)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 8
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'btnComputeTotal
        '
        Me.btnComputeTotal.Enabled = False
        Me.btnComputeTotal.Location = New System.Drawing.Point(12, 32)
        Me.btnComputeTotal.Name = "btnComputeTotal"
        Me.btnComputeTotal.Size = New System.Drawing.Size(175, 23)
        Me.btnComputeTotal.TabIndex = 7
        Me.btnComputeTotal.Text = "Compute Total Cost of Tour"
        Me.btnComputeTotal.UseVisualStyleBackColor = True
        '
        'txtRegistrants
        '
        Me.txtRegistrants.Location = New System.Drawing.Point(133, 6)
        Me.txtRegistrants.Name = "txtRegistrants"
        Me.txtRegistrants.Size = New System.Drawing.Size(54, 20)
        Me.txtRegistrants.TabIndex = 6
        '
        'lblRegistrants
        '
        Me.lblRegistrants.AutoSize = True
        Me.lblRegistrants.Location = New System.Drawing.Point(12, 9)
        Me.lblRegistrants.Name = "lblRegistrants"
        Me.lblRegistrants.Size = New System.Drawing.Size(115, 13)
        Me.lblRegistrants.TabIndex = 5
        Me.lblRegistrants.Text = "Number of Registrants:"
        '
        'frm28
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 88)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.btnComputeTotal)
        Me.Controls.Add(Me.txtRegistrants)
        Me.Controls.Add(Me.lblRegistrants)
        Me.Name = "frm28"
        Me.Text = "Tour"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents btnComputeTotal As System.Windows.Forms.Button
    Friend WithEvents txtRegistrants As System.Windows.Forms.TextBox
    Friend WithEvents lblRegistrants As System.Windows.Forms.Label
End Class
