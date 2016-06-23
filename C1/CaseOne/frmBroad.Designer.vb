<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBroad
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
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnComputeTotal = New System.Windows.Forms.Button()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.lblTotalCosts = New System.Windows.Forms.Label()
        Me.lblServiceFees = New System.Windows.Forms.Label()
        Me.lblLDiscounts = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtBoxGrandTotal = New System.Windows.Forms.TextBox()
        Me.txtBoxTax = New System.Windows.Forms.TextBox()
        Me.txtBoxTotalCost = New System.Windows.Forms.TextBox()
        Me.txtBoxServiceFees = New System.Windows.Forms.TextBox()
        Me.txtBoxDiscounts = New System.Windows.Forms.TextBox()
        Me.txtBoxSubtotal = New System.Windows.Forms.TextBox()
        Me.txtBoxBroadway = New System.Windows.Forms.TextBox()
        Me.txtBoxExtension5 = New System.Windows.Forms.TextBox()
        Me.txtBoxExtension4 = New System.Windows.Forms.TextBox()
        Me.txtBoxExtension3 = New System.Windows.Forms.TextBox()
        Me.txtBoxExtension2 = New System.Windows.Forms.TextBox()
        Me.txtBoxExtension1 = New System.Windows.Forms.TextBox()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.lblQTY = New System.Windows.Forms.Label()
        Me.txtBoxQTY5 = New System.Windows.Forms.TextBox()
        Me.txtBoxQTY4 = New System.Windows.Forms.TextBox()
        Me.txtBoxQTY3 = New System.Windows.Forms.TextBox()
        Me.txtBoxQTY2 = New System.Windows.Forms.TextBox()
        Me.txtBoxQTY1 = New System.Windows.Forms.TextBox()
        Me.lblNameofShow = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.chkBox6 = New System.Windows.Forms.CheckBox()
        Me.chkBox5 = New System.Windows.Forms.CheckBox()
        Me.chkBox4 = New System.Windows.Forms.CheckBox()
        Me.chkBox3 = New System.Windows.Forms.CheckBox()
        Me.chkBox2 = New System.Windows.Forms.CheckBox()
        Me.chkBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(251, 389)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(82, 13)
        Me.lblTax.TabIndex = 79
        Me.lblTax.Text = "Tax (7.35%) :"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.Location = New System.Drawing.Point(-12, 254)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(619, 13)
        Me.lblLine.TabIndex = 78
        Me.lblLine.Text = "_________________________________________________________________________________" & _
    "_____________________"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(295, 457)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 42)
        Me.btnQuit.TabIndex = 77
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(175, 457)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 42)
        Me.btnReturn.TabIndex = 76
        Me.btnReturn.Text = "&Return to Main Form"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnComputeTotal
        '
        Me.btnComputeTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnComputeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeTotal.Location = New System.Drawing.Point(57, 457)
        Me.btnComputeTotal.Name = "btnComputeTotal"
        Me.btnComputeTotal.Size = New System.Drawing.Size(74, 42)
        Me.btnComputeTotal.TabIndex = 75
        Me.btnComputeTotal.Text = "&Compute Total"
        Me.btnComputeTotal.UseVisualStyleBackColor = False
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.AutoSize = True
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.Location = New System.Drawing.Point(228, 419)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(78, 13)
        Me.lblGrandTotal.TabIndex = 74
        Me.lblGrandTotal.Text = "Grand Total:"
        '
        'lblTotalCosts
        '
        Me.lblTotalCosts.AutoSize = True
        Me.lblTotalCosts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCosts.Location = New System.Drawing.Point(228, 364)
        Me.lblTotalCosts.Name = "lblTotalCosts"
        Me.lblTotalCosts.Size = New System.Drawing.Size(75, 13)
        Me.lblTotalCosts.TabIndex = 73
        Me.lblTotalCosts.Text = "Total Costs:"
        '
        'lblServiceFees
        '
        Me.lblServiceFees.AutoSize = True
        Me.lblServiceFees.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceFees.Location = New System.Drawing.Point(251, 338)
        Me.lblServiceFees.Name = "lblServiceFees"
        Me.lblServiceFees.Size = New System.Drawing.Size(113, 13)
        Me.lblServiceFees.TabIndex = 72
        Me.lblServiceFees.Text = "Plus Service Fees:"
        '
        'lblLDiscounts
        '
        Me.lblLDiscounts.AutoSize = True
        Me.lblLDiscounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLDiscounts.Location = New System.Drawing.Point(251, 312)
        Me.lblLDiscounts.Name = "lblLDiscounts"
        Me.lblLDiscounts.Size = New System.Drawing.Size(97, 13)
        Me.lblLDiscounts.TabIndex = 71
        Me.lblLDiscounts.Text = "Less Discounts:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(228, 286)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(58, 13)
        Me.lblTotal.TabIndex = 70
        Me.lblTotal.Text = "Subtotal:"
        '
        'txtBoxGrandTotal
        '
        Me.txtBoxGrandTotal.Location = New System.Drawing.Point(370, 412)
        Me.txtBoxGrandTotal.Name = "txtBoxGrandTotal"
        Me.txtBoxGrandTotal.ReadOnly = True
        Me.txtBoxGrandTotal.Size = New System.Drawing.Size(65, 20)
        Me.txtBoxGrandTotal.TabIndex = 69
        Me.txtBoxGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxTax
        '
        Me.txtBoxTax.Location = New System.Drawing.Point(370, 386)
        Me.txtBoxTax.Name = "txtBoxTax"
        Me.txtBoxTax.ReadOnly = True
        Me.txtBoxTax.Size = New System.Drawing.Size(65, 20)
        Me.txtBoxTax.TabIndex = 68
        Me.txtBoxTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxTotalCost
        '
        Me.txtBoxTotalCost.Location = New System.Drawing.Point(370, 357)
        Me.txtBoxTotalCost.Name = "txtBoxTotalCost"
        Me.txtBoxTotalCost.ReadOnly = True
        Me.txtBoxTotalCost.Size = New System.Drawing.Size(65, 20)
        Me.txtBoxTotalCost.TabIndex = 67
        Me.txtBoxTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxServiceFees
        '
        Me.txtBoxServiceFees.Location = New System.Drawing.Point(370, 331)
        Me.txtBoxServiceFees.Name = "txtBoxServiceFees"
        Me.txtBoxServiceFees.ReadOnly = True
        Me.txtBoxServiceFees.Size = New System.Drawing.Size(65, 20)
        Me.txtBoxServiceFees.TabIndex = 66
        Me.txtBoxServiceFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxDiscounts
        '
        Me.txtBoxDiscounts.Location = New System.Drawing.Point(370, 305)
        Me.txtBoxDiscounts.Name = "txtBoxDiscounts"
        Me.txtBoxDiscounts.ReadOnly = True
        Me.txtBoxDiscounts.Size = New System.Drawing.Size(65, 20)
        Me.txtBoxDiscounts.TabIndex = 65
        Me.txtBoxDiscounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxSubtotal
        '
        Me.txtBoxSubtotal.Location = New System.Drawing.Point(370, 279)
        Me.txtBoxSubtotal.Name = "txtBoxSubtotal"
        Me.txtBoxSubtotal.ReadOnly = True
        Me.txtBoxSubtotal.Size = New System.Drawing.Size(65, 20)
        Me.txtBoxSubtotal.TabIndex = 64
        Me.txtBoxSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxBroadway
        '
        Me.txtBoxBroadway.BackColor = System.Drawing.SystemColors.Control
        Me.txtBoxBroadway.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxBroadway.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBroadway.Location = New System.Drawing.Point(12, 12)
        Me.txtBoxBroadway.Name = "txtBoxBroadway"
        Me.txtBoxBroadway.Size = New System.Drawing.Size(274, 19)
        Me.txtBoxBroadway.TabIndex = 63
        Me.txtBoxBroadway.Text = "Broadway Comes to Visual Basic"
        Me.txtBoxBroadway.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBoxExtension5
        '
        Me.txtBoxExtension5.Location = New System.Drawing.Point(337, 215)
        Me.txtBoxExtension5.Name = "txtBoxExtension5"
        Me.txtBoxExtension5.ReadOnly = True
        Me.txtBoxExtension5.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxExtension5.TabIndex = 62
        Me.txtBoxExtension5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxExtension5.Visible = False
        '
        'txtBoxExtension4
        '
        Me.txtBoxExtension4.Location = New System.Drawing.Point(337, 184)
        Me.txtBoxExtension4.Name = "txtBoxExtension4"
        Me.txtBoxExtension4.ReadOnly = True
        Me.txtBoxExtension4.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxExtension4.TabIndex = 61
        Me.txtBoxExtension4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxExtension4.Visible = False
        '
        'txtBoxExtension3
        '
        Me.txtBoxExtension3.Location = New System.Drawing.Point(337, 155)
        Me.txtBoxExtension3.Name = "txtBoxExtension3"
        Me.txtBoxExtension3.ReadOnly = True
        Me.txtBoxExtension3.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxExtension3.TabIndex = 60
        Me.txtBoxExtension3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxExtension3.Visible = False
        '
        'txtBoxExtension2
        '
        Me.txtBoxExtension2.Location = New System.Drawing.Point(337, 122)
        Me.txtBoxExtension2.Name = "txtBoxExtension2"
        Me.txtBoxExtension2.ReadOnly = True
        Me.txtBoxExtension2.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxExtension2.TabIndex = 59
        Me.txtBoxExtension2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxExtension2.Visible = False
        '
        'txtBoxExtension1
        '
        Me.txtBoxExtension1.Location = New System.Drawing.Point(337, 90)
        Me.txtBoxExtension1.Name = "txtBoxExtension1"
        Me.txtBoxExtension1.ReadOnly = True
        Me.txtBoxExtension1.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxExtension1.TabIndex = 58
        Me.txtBoxExtension1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxExtension1.Visible = False
        '
        'lblExtension
        '
        Me.lblExtension.AutoSize = True
        Me.lblExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtension.Location = New System.Drawing.Point(350, 66)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(62, 13)
        Me.lblExtension.TabIndex = 57
        Me.lblExtension.Text = "Extension"
        '
        'lblQTY
        '
        Me.lblQTY.AutoSize = True
        Me.lblQTY.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblQTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQTY.Location = New System.Drawing.Point(274, 66)
        Me.lblQTY.Name = "lblQTY"
        Me.lblQTY.Size = New System.Drawing.Size(26, 13)
        Me.lblQTY.TabIndex = 56
        Me.lblQTY.Text = "Qty"
        '
        'txtBoxQTY5
        '
        Me.txtBoxQTY5.Location = New System.Drawing.Point(265, 215)
        Me.txtBoxQTY5.Name = "txtBoxQTY5"
        Me.txtBoxQTY5.Size = New System.Drawing.Size(45, 20)
        Me.txtBoxQTY5.TabIndex = 55
        Me.txtBoxQTY5.Text = "4"
        Me.txtBoxQTY5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxQTY5.Visible = False
        '
        'txtBoxQTY4
        '
        Me.txtBoxQTY4.Location = New System.Drawing.Point(264, 184)
        Me.txtBoxQTY4.Name = "txtBoxQTY4"
        Me.txtBoxQTY4.Size = New System.Drawing.Size(45, 20)
        Me.txtBoxQTY4.TabIndex = 54
        Me.txtBoxQTY4.Text = "2"
        Me.txtBoxQTY4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxQTY4.Visible = False
        '
        'txtBoxQTY3
        '
        Me.txtBoxQTY3.Location = New System.Drawing.Point(264, 155)
        Me.txtBoxQTY3.Name = "txtBoxQTY3"
        Me.txtBoxQTY3.Size = New System.Drawing.Size(45, 20)
        Me.txtBoxQTY3.TabIndex = 53
        Me.txtBoxQTY3.Text = "2"
        Me.txtBoxQTY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxQTY3.Visible = False
        '
        'txtBoxQTY2
        '
        Me.txtBoxQTY2.Location = New System.Drawing.Point(264, 122)
        Me.txtBoxQTY2.Name = "txtBoxQTY2"
        Me.txtBoxQTY2.Size = New System.Drawing.Size(45, 20)
        Me.txtBoxQTY2.TabIndex = 52
        Me.txtBoxQTY2.Text = "2"
        Me.txtBoxQTY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxQTY2.Visible = False
        '
        'txtBoxQTY1
        '
        Me.txtBoxQTY1.Location = New System.Drawing.Point(264, 90)
        Me.txtBoxQTY1.Name = "txtBoxQTY1"
        Me.txtBoxQTY1.Size = New System.Drawing.Size(45, 20)
        Me.txtBoxQTY1.TabIndex = 51
        Me.txtBoxQTY1.Text = "2"
        Me.txtBoxQTY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtBoxQTY1.Visible = False
        '
        'lblNameofShow
        '
        Me.lblNameofShow.AutoSize = True
        Me.lblNameofShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameofShow.Location = New System.Drawing.Point(33, 66)
        Me.lblNameofShow.Name = "lblNameofShow"
        Me.lblNameofShow.Size = New System.Drawing.Size(89, 13)
        Me.lblNameofShow.TabIndex = 50
        Me.lblNameofShow.Text = "Name of Show"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(33, 287)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(122, 26)
        Me.lblDiscount.TabIndex = 49
        Me.lblDiscount.Text = "Check here for a 5%" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " senior discount"
        '
        'chkBox6
        '
        Me.chkBox6.AutoSize = True
        Me.chkBox6.Checked = True
        Me.chkBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBox6.Location = New System.Drawing.Point(12, 287)
        Me.chkBox6.Name = "chkBox6"
        Me.chkBox6.Size = New System.Drawing.Size(15, 14)
        Me.chkBox6.TabIndex = 48
        Me.chkBox6.UseVisualStyleBackColor = True
        '
        'chkBox5
        '
        Me.chkBox5.AutoSize = True
        Me.chkBox5.Checked = True
        Me.chkBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox5.Location = New System.Drawing.Point(12, 221)
        Me.chkBox5.Name = "chkBox5"
        Me.chkBox5.Size = New System.Drawing.Size(215, 17)
        Me.chkBox5.TabIndex = 47
        Me.chkBox5.Text = "Blues in the (VB) Projects (42.95)"
        Me.chkBox5.UseVisualStyleBackColor = True
        '
        'chkBox4
        '
        Me.chkBox4.AutoSize = True
        Me.chkBox4.Checked = True
        Me.chkBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox4.Location = New System.Drawing.Point(12, 190)
        Me.chkBox4.Name = "chkBox4"
        Me.chkBox4.Size = New System.Drawing.Size(247, 17)
        Me.chkBox4.TabIndex = 46
        Me.chkBox4.Text = "Justin Bieber does Visual Basic (29.95)"
        Me.chkBox4.UseVisualStyleBackColor = True
        '
        'chkBox3
        '
        Me.chkBox3.AutoSize = True
        Me.chkBox3.Checked = True
        Me.chkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox3.Location = New System.Drawing.Point(12, 162)
        Me.chkBox3.Name = "chkBox3"
        Me.chkBox3.Size = New System.Drawing.Size(138, 17)
        Me.chkBox3.TabIndex = 45
        Me.chkBox3.Text = "VB for Me!!! (49.95)"
        Me.chkBox3.UseVisualStyleBackColor = True
        '
        'chkBox2
        '
        Me.chkBox2.AutoSize = True
        Me.chkBox2.Checked = True
        Me.chkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox2.Location = New System.Drawing.Point(12, 128)
        Me.chkBox2.Name = "chkBox2"
        Me.chkBox2.Size = New System.Drawing.Size(231, 17)
        Me.chkBox2.TabIndex = 44
        Me.chkBox2.Text = "The MS Mouse in the House (37.95)"
        Me.chkBox2.UseVisualStyleBackColor = True
        '
        'chkBox1
        '
        Me.chkBox1.AutoSize = True
        Me.chkBox1.Checked = True
        Me.chkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBox1.Location = New System.Drawing.Point(12, 93)
        Me.chkBox1.Name = "chkBox1"
        Me.chkBox1.Size = New System.Drawing.Size(223, 17)
        Me.chkBox1.TabIndex = 43
        Me.chkBox1.Text = "The Wizard of Visual Basic (29.95)"
        Me.chkBox1.UseVisualStyleBackColor = True
        '
        'frmBroad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 511)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnComputeTotal)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblTotalCosts)
        Me.Controls.Add(Me.lblServiceFees)
        Me.Controls.Add(Me.lblLDiscounts)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtBoxGrandTotal)
        Me.Controls.Add(Me.txtBoxTax)
        Me.Controls.Add(Me.txtBoxTotalCost)
        Me.Controls.Add(Me.txtBoxServiceFees)
        Me.Controls.Add(Me.txtBoxDiscounts)
        Me.Controls.Add(Me.txtBoxSubtotal)
        Me.Controls.Add(Me.txtBoxBroadway)
        Me.Controls.Add(Me.txtBoxExtension5)
        Me.Controls.Add(Me.txtBoxExtension4)
        Me.Controls.Add(Me.txtBoxExtension3)
        Me.Controls.Add(Me.txtBoxExtension2)
        Me.Controls.Add(Me.txtBoxExtension1)
        Me.Controls.Add(Me.lblExtension)
        Me.Controls.Add(Me.lblQTY)
        Me.Controls.Add(Me.txtBoxQTY5)
        Me.Controls.Add(Me.txtBoxQTY4)
        Me.Controls.Add(Me.txtBoxQTY3)
        Me.Controls.Add(Me.txtBoxQTY2)
        Me.Controls.Add(Me.txtBoxQTY1)
        Me.Controls.Add(Me.lblNameofShow)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.chkBox6)
        Me.Controls.Add(Me.chkBox5)
        Me.Controls.Add(Me.chkBox4)
        Me.Controls.Add(Me.chkBox3)
        Me.Controls.Add(Me.chkBox2)
        Me.Controls.Add(Me.chkBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBroad"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Broadway Shows Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblLine As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnComputeTotal As System.Windows.Forms.Button
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalCosts As System.Windows.Forms.Label
    Friend WithEvents lblServiceFees As System.Windows.Forms.Label
    Friend WithEvents lblLDiscounts As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtBoxGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTax As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxServiceFees As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxDiscounts As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxBroadway As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxExtension5 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxExtension4 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxExtension3 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxExtension2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxExtension1 As System.Windows.Forms.TextBox
    Friend WithEvents lblExtension As System.Windows.Forms.Label
    Friend WithEvents lblQTY As System.Windows.Forms.Label
    Friend WithEvents txtBoxQTY5 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxQTY4 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxQTY3 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxQTY2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxQTY1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNameofShow As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents chkBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox1 As System.Windows.Forms.CheckBox
End Class
