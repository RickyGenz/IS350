<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCC
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
        Me.grpButtons = New System.Windows.Forms.GroupBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.grpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpButtons
        '
        Me.grpButtons.Controls.Add(Me.btnOk)
        Me.grpButtons.Controls.Add(Me.btnExit)
        Me.grpButtons.Location = New System.Drawing.Point(34, 119)
        Me.grpButtons.Name = "grpButtons"
        Me.grpButtons.Size = New System.Drawing.Size(195, 66)
        Me.grpButtons.TabIndex = 177
        Me.grpButtons.TabStop = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnOk.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(9, 17)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 40)
        Me.btnOk.TabIndex = 29
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnExit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(109, 17)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 40)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(238, 15)
        Me.lblInfo.TabIndex = 178
        Me.lblInfo.Text = "This form is for paying with a credit card"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Select Card Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Card Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 181
        Me.Label3.Text = "Expiration Date (mm/yy)"
        '
        'txtDate
        '
        Me.txtDate.AccessibleDescription = "Required"
        Me.txtDate.AccessibleName = "Expiration Date"
        Me.txtDate.Location = New System.Drawing.Point(137, 84)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(38, 20)
        Me.txtDate.TabIndex = 2
        Me.txtDate.Text = "12/17"
        '
        'txtNumber
        '
        Me.txtNumber.AccessibleDescription = "Required"
        Me.txtNumber.AccessibleName = "Card Number"
        Me.txtNumber.Location = New System.Drawing.Point(137, 58)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(113, 20)
        Me.txtNumber.TabIndex = 1
        Me.txtNumber.Text = "1234-5678-9012-1234"
        '
        'cboType
        '
        Me.cboType.AccessibleDescription = "Required"
        Me.cboType.AccessibleName = "Select Card Type"
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"American Express", "Discover", "MasterCard", "Visa"})
        Me.cboType.Location = New System.Drawing.Point(137, 32)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(113, 21)
        Me.cboType.TabIndex = 0
        '
        'frmCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 198)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.grpButtons)
        Me.Name = "frmCC"
        Me.Text = "Credit Card Payment"
        Me.grpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpButtons As System.Windows.Forms.GroupBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
End Class
