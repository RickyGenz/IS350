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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblPurchaseAmount = New System.Windows.Forms.Label()
        Me.lblShippingCost = New System.Windows.Forms.Label()
        Me.lblAdditionalCharges = New System.Windows.Forms.Label()
        Me.lblBroadwayShows = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblSpace = New System.Windows.Forms.Label()
        Me.txtPurchaseAmount = New System.Windows.Forms.TextBox()
        Me.txtShippingCost = New System.Windows.Forms.TextBox()
        Me.txtAdditionalCharges = New System.Windows.Forms.TextBox()
        Me.txtBroadwayShows = New System.Windows.Forms.TextBox()
        Me.txtGrandTotal = New System.Windows.Forms.TextBox()
        Me.btnShippingCharges = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnAdditionalCharges = New System.Windows.Forms.Button()
        Me.btnPrintInvoice = New System.Windows.Forms.Button()
        Me.btnBroadwayShows = New System.Windows.Forms.Button()
        Me.btnPrintPreview = New System.Windows.Forms.Button()
        Me.btnComputeTotal = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblBorder = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddress = New System.Windows.Forms.MaskedTextBox()
        Me.txtCity = New System.Windows.Forms.MaskedTextBox()
        Me.txtState = New System.Windows.Forms.MaskedTextBox()
        Me.txtZip = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.PrintInvoice = New System.Drawing.Printing.PrintDocument()
        Me.PreviewInvoice = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(241, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Downtown Department Store"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(85, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Customer Name:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(7, 76)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(79, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Street Address:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(7, 104)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(79, 13)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "City, State, Zip:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(7, 132)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(101, 13)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Cell Phone Number:"
        '
        'lblPurchaseAmount
        '
        Me.lblPurchaseAmount.AutoSize = True
        Me.lblPurchaseAmount.Location = New System.Drawing.Point(33, 185)
        Me.lblPurchaseAmount.Name = "lblPurchaseAmount"
        Me.lblPurchaseAmount.Size = New System.Drawing.Size(103, 13)
        Me.lblPurchaseAmount.TabIndex = 5
        Me.lblPurchaseAmount.Text = "Amount of Purchase"
        '
        'lblShippingCost
        '
        Me.lblShippingCost.AutoSize = True
        Me.lblShippingCost.Location = New System.Drawing.Point(33, 211)
        Me.lblShippingCost.Name = "lblShippingCost"
        Me.lblShippingCost.Size = New System.Drawing.Size(72, 13)
        Me.lblShippingCost.TabIndex = 6
        Me.lblShippingCost.Text = "Shipping Cost"
        Me.lblShippingCost.Visible = False
        '
        'lblAdditionalCharges
        '
        Me.lblAdditionalCharges.AutoSize = True
        Me.lblAdditionalCharges.Location = New System.Drawing.Point(33, 237)
        Me.lblAdditionalCharges.Name = "lblAdditionalCharges"
        Me.lblAdditionalCharges.Size = New System.Drawing.Size(95, 13)
        Me.lblAdditionalCharges.TabIndex = 7
        Me.lblAdditionalCharges.Text = "Additional Charges"
        Me.lblAdditionalCharges.Visible = False
        '
        'lblBroadwayShows
        '
        Me.lblBroadwayShows.AutoSize = True
        Me.lblBroadwayShows.Location = New System.Drawing.Point(33, 263)
        Me.lblBroadwayShows.Name = "lblBroadwayShows"
        Me.lblBroadwayShows.Size = New System.Drawing.Size(89, 13)
        Me.lblBroadwayShows.TabIndex = 8
        Me.lblBroadwayShows.Text = "Broadway Shows"
        Me.lblBroadwayShows.Visible = False
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Location = New System.Drawing.Point(33, 308)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblGrandTotal.TabIndex = 9
        Me.lblGrandTotal.Text = "Total"
        Me.lblGrandTotal.Visible = False
        '
        'lblSpace
        '
        Me.lblSpace.AutoSize = True
        Me.lblSpace.Location = New System.Drawing.Point(33, 285)
        Me.lblSpace.Name = "lblSpace"
        Me.lblSpace.Size = New System.Drawing.Size(259, 13)
        Me.lblSpace.TabIndex = 10
        Me.lblSpace.Text = "__________________________________________"
        Me.lblSpace.Visible = False
        '
        'txtPurchaseAmount
        '
        Me.txtPurchaseAmount.Location = New System.Drawing.Point(220, 178)
        Me.txtPurchaseAmount.Name = "txtPurchaseAmount"
        Me.txtPurchaseAmount.Size = New System.Drawing.Size(70, 20)
        Me.txtPurchaseAmount.TabIndex = 6
        Me.txtPurchaseAmount.Text = "100"
        Me.txtPurchaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtShippingCost
        '
        Me.txtShippingCost.Location = New System.Drawing.Point(220, 205)
        Me.txtShippingCost.Name = "txtShippingCost"
        Me.txtShippingCost.ReadOnly = True
        Me.txtShippingCost.Size = New System.Drawing.Size(70, 20)
        Me.txtShippingCost.TabIndex = 18
        Me.txtShippingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtShippingCost.Visible = False
        '
        'txtAdditionalCharges
        '
        Me.txtAdditionalCharges.Location = New System.Drawing.Point(220, 232)
        Me.txtAdditionalCharges.Name = "txtAdditionalCharges"
        Me.txtAdditionalCharges.ReadOnly = True
        Me.txtAdditionalCharges.Size = New System.Drawing.Size(70, 20)
        Me.txtAdditionalCharges.TabIndex = 19
        Me.txtAdditionalCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAdditionalCharges.Visible = False
        '
        'txtBroadwayShows
        '
        Me.txtBroadwayShows.Location = New System.Drawing.Point(220, 258)
        Me.txtBroadwayShows.Name = "txtBroadwayShows"
        Me.txtBroadwayShows.ReadOnly = True
        Me.txtBroadwayShows.Size = New System.Drawing.Size(70, 20)
        Me.txtBroadwayShows.TabIndex = 20
        Me.txtBroadwayShows.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBroadwayShows.Visible = False
        '
        'txtGrandTotal
        '
        Me.txtGrandTotal.Location = New System.Drawing.Point(220, 301)
        Me.txtGrandTotal.Name = "txtGrandTotal"
        Me.txtGrandTotal.ReadOnly = True
        Me.txtGrandTotal.Size = New System.Drawing.Size(70, 20)
        Me.txtGrandTotal.TabIndex = 21
        Me.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtGrandTotal.Visible = False
        '
        'btnShippingCharges
        '
        Me.btnShippingCharges.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnShippingCharges.Location = New System.Drawing.Point(355, 41)
        Me.btnShippingCharges.Name = "btnShippingCharges"
        Me.btnShippingCharges.Size = New System.Drawing.Size(90, 50)
        Me.btnShippingCharges.TabIndex = 7
        Me.btnShippingCharges.Text = "&Shipping Charges"
        Me.btnShippingCharges.UseVisualStyleBackColor = False
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnClearAll.Location = New System.Drawing.Point(462, 41)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(90, 50)
        Me.btnClearAll.TabIndex = 23
        Me.btnClearAll.Text = "Cl&ear All"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'btnAdditionalCharges
        '
        Me.btnAdditionalCharges.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAdditionalCharges.Location = New System.Drawing.Point(355, 103)
        Me.btnAdditionalCharges.Name = "btnAdditionalCharges"
        Me.btnAdditionalCharges.Size = New System.Drawing.Size(90, 50)
        Me.btnAdditionalCharges.TabIndex = 8
        Me.btnAdditionalCharges.Text = "&Additional Charges"
        Me.btnAdditionalCharges.UseVisualStyleBackColor = False
        '
        'btnPrintInvoice
        '
        Me.btnPrintInvoice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPrintInvoice.Location = New System.Drawing.Point(461, 103)
        Me.btnPrintInvoice.Name = "btnPrintInvoice"
        Me.btnPrintInvoice.Size = New System.Drawing.Size(90, 50)
        Me.btnPrintInvoice.TabIndex = 25
        Me.btnPrintInvoice.Text = "&Print Invoice"
        Me.btnPrintInvoice.UseVisualStyleBackColor = False
        '
        'btnBroadwayShows
        '
        Me.btnBroadwayShows.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBroadwayShows.Location = New System.Drawing.Point(355, 165)
        Me.btnBroadwayShows.Name = "btnBroadwayShows"
        Me.btnBroadwayShows.Size = New System.Drawing.Size(90, 50)
        Me.btnBroadwayShows.TabIndex = 9
        Me.btnBroadwayShows.Text = "&Broadway Shows"
        Me.btnBroadwayShows.UseVisualStyleBackColor = False
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnPrintPreview.Location = New System.Drawing.Point(462, 165)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(90, 50)
        Me.btnPrintPreview.TabIndex = 27
        Me.btnPrintPreview.Text = "Print P&review"
        Me.btnPrintPreview.UseVisualStyleBackColor = False
        '
        'btnComputeTotal
        '
        Me.btnComputeTotal.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnComputeTotal.Location = New System.Drawing.Point(355, 227)
        Me.btnComputeTotal.Name = "btnComputeTotal"
        Me.btnComputeTotal.Size = New System.Drawing.Size(90, 50)
        Me.btnComputeTotal.TabIndex = 10
        Me.btnComputeTotal.Text = "&Compute Total"
        Me.btnComputeTotal.UseVisualStyleBackColor = False
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnAbout.Location = New System.Drawing.Point(461, 227)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(90, 50)
        Me.btnAbout.TabIndex = 29
        Me.btnAbout.Text = "Ab&out Project"
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnQuit.Location = New System.Drawing.Point(355, 289)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(196, 50)
        Me.btnQuit.TabIndex = 30
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblBorder
        '
        Me.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBorder.Location = New System.Drawing.Point(10, 166)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(311, 173)
        Me.lblBorder.TabIndex = 31
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(114, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(207, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "Mark G. Simkin"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(114, 69)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(207, 20)
        Me.txtAddress.TabIndex = 1
        Me.txtAddress.Text = "1234 Main Street"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(114, 97)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(100, 20)
        Me.txtCity.TabIndex = 2
        Me.txtCity.Text = "Reno"
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(220, 97)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(24, 20)
        Me.txtState.TabIndex = 3
        Me.txtState.Text = "NV"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(250, 97)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(71, 20)
        Me.txtZip.TabIndex = 4
        Me.txtZip.Text = "12345"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(114, 125)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(207, 20)
        Me.txtPhone.TabIndex = 5
        Me.txtPhone.Text = "(123) 456 - 7890"
        '
        'PrintInvoice
        '
        '
        'PreviewInvoice
        '
        Me.PreviewInvoice.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreviewInvoice.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreviewInvoice.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreviewInvoice.Enabled = True
        Me.PreviewInvoice.Icon = CType(resources.GetObject("PreviewInvoice.Icon"), System.Drawing.Icon)
        Me.PreviewInvoice.Name = "PreviewInvoice"
        Me.PreviewInvoice.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 347)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnComputeTotal)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.btnBroadwayShows)
        Me.Controls.Add(Me.btnPrintInvoice)
        Me.Controls.Add(Me.btnAdditionalCharges)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnShippingCharges)
        Me.Controls.Add(Me.txtGrandTotal)
        Me.Controls.Add(Me.txtBroadwayShows)
        Me.Controls.Add(Me.txtAdditionalCharges)
        Me.Controls.Add(Me.txtShippingCost)
        Me.Controls.Add(Me.txtPurchaseAmount)
        Me.Controls.Add(Me.lblSpace)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblBroadwayShows)
        Me.Controls.Add(Me.lblAdditionalCharges)
        Me.Controls.Add(Me.lblShippingCost)
        Me.Controls.Add(Me.lblPurchaseAmount)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblBorder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblPurchaseAmount As System.Windows.Forms.Label
    Friend WithEvents lblShippingCost As System.Windows.Forms.Label
    Friend WithEvents lblAdditionalCharges As System.Windows.Forms.Label
    Friend WithEvents lblBroadwayShows As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents lblSpace As System.Windows.Forms.Label
    Friend WithEvents txtPurchaseAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtShippingCost As System.Windows.Forms.TextBox
    Friend WithEvents txtAdditionalCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtBroadwayShows As System.Windows.Forms.TextBox
    Friend WithEvents txtGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnShippingCharges As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnAdditionalCharges As System.Windows.Forms.Button
    Friend WithEvents btnPrintInvoice As System.Windows.Forms.Button
    Friend WithEvents btnBroadwayShows As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents btnComputeTotal As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblBorder As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtAddress As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCity As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtState As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PrintInvoice As System.Drawing.Printing.PrintDocument
    Friend WithEvents PreviewInvoice As System.Windows.Forms.PrintPreviewDialog
End Class
