<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2
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
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(12, 15)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(54, 13)
        Me.lblCustomer.TabIndex = 0
        Me.lblCustomer.Text = "Customer:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(12, 41)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(76, 13)
        Me.lblHours.TabIndex = 1
        Me.lblHours.Text = "Hours of labor:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(12, 67)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(69, 13)
        Me.lblCost.TabIndex = 2
        Me.lblCost.Text = "Cost of parts:"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(12, 86)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(206, 69)
        Me.lstResults.TabIndex = 3
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(72, 8)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(146, 20)
        Me.txtCustomer.TabIndex = 4
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(94, 34)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(39, 20)
        Me.txtHours.TabIndex = 5
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(87, 60)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(46, 20)
        Me.txtCost.TabIndex = 6
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(139, 34)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(79, 46)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "Display Bill"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 166)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblCustomer)
        Me.Name = "frm2"
        Me.Text = "Repair Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lstResults As System.Windows.Forms.ListBox
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
End Class
