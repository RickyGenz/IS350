<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuessRight
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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblValid = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblZip = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtValid = New System.Windows.Forms.TextBox()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(37, 59)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = "First Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(18, 89)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(76, 13)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Street Address"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(70, 119)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(24, 13)
        Me.lblCity.TabIndex = 2
        Me.lblCity.Text = "City"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(16, 149)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone Number"
        '
        'lblValid
        '
        Me.lblValid.AutoSize = True
        Me.lblValid.Location = New System.Drawing.Point(37, 179)
        Me.lblValid.Name = "lblValid"
        Me.lblValid.Size = New System.Drawing.Size(57, 13)
        Me.lblValid.TabIndex = 4
        Me.lblValid.Text = "Valid Info?"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(237, 59)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 5
        Me.lblLast.Text = "Last Name"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(182, 119)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 13)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State"
        '
        'lblZip
        '
        Me.lblZip.AutoSize = True
        Me.lblZip.Location = New System.Drawing.Point(301, 119)
        Me.lblZip.Name = "lblZip"
        Me.lblZip.Size = New System.Drawing.Size(50, 13)
        Me.lblZip.TabIndex = 7
        Me.lblZip.Text = "Zip Code"
        '
        'txtFirst
        '
        Me.txtFirst.AccessibleName = "First Name"
        Me.txtFirst.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtFirst.Location = New System.Drawing.Point(100, 56)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(131, 20)
        Me.txtFirst.TabIndex = 0
        Me.txtFirst.Text = "Barbara"
        '
        'txtAddress
        '
        Me.txtAddress.AccessibleName = "Street Address"
        Me.txtAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtAddress.Location = New System.Drawing.Point(100, 86)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(332, 20)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.Text = "123 Main Street"
        '
        'txtCity
        '
        Me.txtCity.AccessibleName = "City"
        Me.txtCity.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtCity.Location = New System.Drawing.Point(100, 116)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(75, 20)
        Me.txtCity.TabIndex = 3
        Me.txtCity.Text = "Reno"
        '
        'txtState
        '
        Me.txtState.AccessibleName = "State"
        Me.txtState.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtState.Location = New System.Drawing.Point(220, 116)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(75, 20)
        Me.txtState.TabIndex = 4
        Me.txtState.Text = "NV"
        '
        'txtZip
        '
        Me.txtZip.AccessibleName = "Zip Code"
        Me.txtZip.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtZip.Location = New System.Drawing.Point(357, 116)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(75, 20)
        Me.txtZip.TabIndex = 5
        Me.txtZip.Text = "12345"
        '
        'txtLast
        '
        Me.txtLast.AccessibleName = "Last Name"
        Me.txtLast.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtLast.Location = New System.Drawing.Point(304, 56)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(128, 20)
        Me.txtLast.TabIndex = 1
        Me.txtLast.Text = "Babson"
        '
        'txtPhone
        '
        Me.txtPhone.AccessibleName = "Phone Number"
        Me.txtPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtPhone.Location = New System.Drawing.Point(100, 146)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(114, 20)
        Me.txtPhone.TabIndex = 6
        Me.txtPhone.Text = "(775) 234-5678"
        '
        'txtValid
        '
        Me.txtValid.Location = New System.Drawing.Point(100, 176)
        Me.txtValid.Name = "txtValid"
        Me.txtValid.ReadOnly = True
        Me.txtValid.Size = New System.Drawing.Size(332, 20)
        Me.txtValid.TabIndex = 15
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(220, 144)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(101, 23)
        Me.btnValidate.TabIndex = 16
        Me.btnValidate.Text = "Validate"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(327, 144)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(105, 23)
        Me.btnQuit.TabIndex = 17
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(59, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(334, 31)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "Office of Dr. GuessRight"
        '
        'frmGuessRight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 208)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.txtValid)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblZip)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblValid)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "frmGuessRight"
        Me.Text = "Validating Inputs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblValid As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZip As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtValid As System.Windows.Forms.TextBox
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
