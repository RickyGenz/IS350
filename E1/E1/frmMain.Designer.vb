<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtSSN = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.btnSecondForm = New System.Windows.Forms.Button()
        Me.btnNetPay = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.PreviewSummary = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintSummary = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(38, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(266, 38)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "<MGS Company>"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(48, 55)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(47, 87)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(11, 119)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(94, 13)
        Me.lblSSN.TabIndex = 3
        Me.lblSSN.Text = "Soc. Sec. Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(29, 152)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(76, 13)
        Me.lblAddress.TabIndex = 4
        Me.lblAddress.Text = "Street Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(81, 184)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(73, 216)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(55, 249)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(50, 13)
        Me.lblZipCode.TabIndex = 7
        Me.lblZipCode.Text = "Zip Code"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(16, 290)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(195, 13)
        Me.lblNetPay.TabIndex = 8
        Me.lblNetPay.Text = "Estimated Net Pay from Net Pay Screen"
        '
        'txtFirstName
        '
        Me.txtFirstName.AccessibleName = "First Name"
        Me.txtFirstName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtFirstName.Location = New System.Drawing.Point(111, 52)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        Me.txtFirstName.Text = "Sam"
        '
        'txtLastName
        '
        Me.txtLastName.AccessibleName = "Last Name"
        Me.txtLastName.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtLastName.Location = New System.Drawing.Point(111, 84)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 1
        Me.txtLastName.Text = "Sample"
        '
        'txtSSN
        '
        Me.txtSSN.AccessibleName = "SSN"
        Me.txtSSN.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtSSN.Location = New System.Drawing.Point(111, 116)
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(100, 20)
        Me.txtSSN.TabIndex = 2
        Me.txtSSN.Text = "123-45-6789"
        '
        'txtAddress
        '
        Me.txtAddress.AccessibleName = "Address"
        Me.txtAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtAddress.Location = New System.Drawing.Point(111, 149)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(100, 20)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.Text = "123 Main Street"
        '
        'txtCity
        '
        Me.txtCity.AccessibleName = "City"
        Me.txtCity.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtCity.Location = New System.Drawing.Point(111, 181)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 4
        Me.txtCity.Text = "Samstown"
        '
        'txtState
        '
        Me.txtState.AccessibleName = "State"
        Me.txtState.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtState.Location = New System.Drawing.Point(111, 213)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(100, 20)
        Me.txtState.TabIndex = 5
        Me.txtState.Text = "SC"
        '
        'txtZipCode
        '
        Me.txtZipCode.AccessibleName = "Zip Code"
        Me.txtZipCode.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtZipCode.Location = New System.Drawing.Point(111, 246)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 20)
        Me.txtZipCode.TabIndex = 6
        Me.txtZipCode.Text = "12345"
        '
        'txtNetPay
        '
        Me.txtNetPay.Location = New System.Drawing.Point(228, 287)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(100, 20)
        Me.txtNetPay.TabIndex = 16
        Me.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSecondForm
        '
        Me.btnSecondForm.Location = New System.Drawing.Point(228, 52)
        Me.btnSecondForm.Name = "btnSecondForm"
        Me.btnSecondForm.Size = New System.Drawing.Size(100, 23)
        Me.btnSecondForm.TabIndex = 17
        Me.btnSecondForm.Text = "Second Form"
        Me.btnSecondForm.UseVisualStyleBackColor = True
        '
        'btnNetPay
        '
        Me.btnNetPay.Location = New System.Drawing.Point(228, 84)
        Me.btnNetPay.Name = "btnNetPay"
        Me.btnNetPay.Size = New System.Drawing.Size(100, 23)
        Me.btnNetPay.TabIndex = 18
        Me.btnNetPay.Text = "Show Net Pay"
        Me.btnNetPay.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(228, 119)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 23)
        Me.btnPrint.TabIndex = 19
        Me.btnPrint.Text = "Print Summary"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(228, 152)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(100, 23)
        Me.btnQuit.TabIndex = 20
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'PreviewSummary
        '
        Me.PreviewSummary.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreviewSummary.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreviewSummary.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreviewSummary.Enabled = True
        Me.PreviewSummary.Icon = CType(resources.GetObject("PreviewSummary.Icon"), System.Drawing.Icon)
        Me.PreviewSummary.Name = "PreviewSummary"
        Me.PreviewSummary.Visible = False
        '
        'PrintSummary
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 318)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnNetPay)
        Me.Controls.Add(Me.btnSecondForm)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblZipCode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Main_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents lblNetPay As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtNetPay As System.Windows.Forms.TextBox
    Friend WithEvents btnSecondForm As System.Windows.Forms.Button
    Friend WithEvents btnNetPay As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents PreviewSummary As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintSummary As System.Drawing.Printing.PrintDocument
End Class
