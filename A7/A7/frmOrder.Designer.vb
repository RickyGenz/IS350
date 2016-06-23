<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblStyle = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblSC = New System.Windows.Forms.Label()
        Me.lblFD = New System.Windows.Forms.Label()
        Me.lblCC = New System.Windows.Forms.Label()
        Me.lblHH = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnSize = New System.Windows.Forms.Button()
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtSCQ = New System.Windows.Forms.TextBox()
        Me.txtFDQ = New System.Windows.Forms.TextBox()
        Me.txtCCQ = New System.Windows.Forms.TextBox()
        Me.txtHHQ = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblSCP = New System.Windows.Forms.Label()
        Me.lblFDP = New System.Windows.Forms.Label()
        Me.lblCCP = New System.Windows.Forms.Label()
        Me.lblHHP = New System.Windows.Forms.Label()
        Me.lblSCS = New System.Windows.Forms.Label()
        Me.lblFDS = New System.Windows.Forms.Label()
        Me.lblCCS = New System.Windows.Forms.Label()
        Me.lblHHS = New System.Windows.Forms.Label()
        Me.lblSCC = New System.Windows.Forms.Label()
        Me.lblFDC = New System.Windows.Forms.Label()
        Me.lblCCC = New System.Windows.Forms.Label()
        Me.lblHHC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(122, 15)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Order Boots Here:"
        '
        'lblStyle
        '
        Me.lblStyle.AutoSize = True
        Me.lblStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStyle.Location = New System.Drawing.Point(15, 35)
        Me.lblStyle.Name = "lblStyle"
        Me.lblStyle.Size = New System.Drawing.Size(35, 13)
        Me.lblStyle.TabIndex = 1
        Me.lblStyle.Text = "Style"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(105, 35)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(54, 13)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(175, 35)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(36, 13)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "Price"
        '
        'lblSize
        '
        Me.lblSize.AutoSize = True
        Me.lblSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSize.Location = New System.Drawing.Point(244, 35)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(31, 13)
        Me.lblSize.TabIndex = 4
        Me.lblSize.Text = "Size"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.Location = New System.Drawing.Point(318, 35)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(36, 13)
        Me.lblColor.TabIndex = 5
        Me.lblColor.Text = "Color"
        '
        'lblSC
        '
        Me.lblSC.AutoSize = True
        Me.lblSC.Location = New System.Drawing.Point(15, 59)
        Me.lblSC.Name = "lblSC"
        Me.lblSC.Size = New System.Drawing.Size(74, 13)
        Me.lblSC.TabIndex = 6
        Me.lblSC.Text = "Sierra Chukka"
        '
        'lblFD
        '
        Me.lblFD.AutoSize = True
        Me.lblFD.Location = New System.Drawing.Point(15, 84)
        Me.lblFD.Name = "lblFD"
        Me.lblFD.Size = New System.Drawing.Size(71, 13)
        Me.lblFD.TabIndex = 7
        Me.lblFD.Text = "Fernley Dress"
        '
        'lblCC
        '
        Me.lblCC.AutoSize = True
        Me.lblCC.Location = New System.Drawing.Point(15, 109)
        Me.lblCC.Name = "lblCC"
        Me.lblCC.Size = New System.Drawing.Size(77, 13)
        Me.lblCC.TabIndex = 8
        Me.lblCC.Text = "Carson Captoe"
        '
        'lblHH
        '
        Me.lblHH.AutoSize = True
        Me.lblHH.Location = New System.Drawing.Point(15, 134)
        Me.lblHH.Name = "lblHH"
        Me.lblHH.Size = New System.Drawing.Size(87, 13)
        Me.lblHH.TabIndex = 9
        Me.lblHH.Text = "Henderson Hiker"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(15, 171)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total:"
        '
        'btnSize
        '
        Me.btnSize.Location = New System.Drawing.Point(29, 203)
        Me.btnSize.Name = "btnSize"
        Me.btnSize.Size = New System.Drawing.Size(75, 23)
        Me.btnSize.TabIndex = 11
        Me.btnSize.Text = "Select Sizes"
        Me.btnSize.UseVisualStyleBackColor = True
        '
        'btnTotal
        '
        Me.btnTotal.Location = New System.Drawing.Point(150, 203)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(75, 23)
        Me.btnTotal.TabIndex = 12
        Me.btnTotal.Text = "Total Order"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(261, 203)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 13
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtSCQ
        '
        Me.txtSCQ.Location = New System.Drawing.Point(108, 56)
        Me.txtSCQ.Name = "txtSCQ"
        Me.txtSCQ.Size = New System.Drawing.Size(40, 20)
        Me.txtSCQ.TabIndex = 14
        Me.txtSCQ.Text = "0"
        Me.txtSCQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFDQ
        '
        Me.txtFDQ.Location = New System.Drawing.Point(108, 81)
        Me.txtFDQ.Name = "txtFDQ"
        Me.txtFDQ.Size = New System.Drawing.Size(40, 20)
        Me.txtFDQ.TabIndex = 15
        Me.txtFDQ.Text = "0"
        Me.txtFDQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCCQ
        '
        Me.txtCCQ.Location = New System.Drawing.Point(108, 106)
        Me.txtCCQ.Name = "txtCCQ"
        Me.txtCCQ.Size = New System.Drawing.Size(40, 20)
        Me.txtCCQ.TabIndex = 16
        Me.txtCCQ.Text = "0"
        Me.txtCCQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHHQ
        '
        Me.txtHHQ.Location = New System.Drawing.Point(108, 131)
        Me.txtHHQ.Name = "txtHHQ"
        Me.txtHHQ.Size = New System.Drawing.Size(40, 20)
        Me.txtHHQ.TabIndex = 17
        Me.txtHHQ.Text = "0"
        Me.txtHHQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(78, 168)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(70, 20)
        Me.txtTotal.TabIndex = 18
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSCP
        '
        Me.lblSCP.AutoSize = True
        Me.lblSCP.Location = New System.Drawing.Point(175, 59)
        Me.lblSCP.Name = "lblSCP"
        Me.lblSCP.Size = New System.Drawing.Size(34, 13)
        Me.lblSCP.TabIndex = 19
        Me.lblSCP.Text = "99.95"
        '
        'lblFDP
        '
        Me.lblFDP.AutoSize = True
        Me.lblFDP.Location = New System.Drawing.Point(169, 85)
        Me.lblFDP.Name = "lblFDP"
        Me.lblFDP.Size = New System.Drawing.Size(40, 13)
        Me.lblFDP.TabIndex = 20
        Me.lblFDP.Text = "139.95"
        '
        'lblCCP
        '
        Me.lblCCP.AutoSize = True
        Me.lblCCP.Location = New System.Drawing.Point(169, 111)
        Me.lblCCP.Name = "lblCCP"
        Me.lblCCP.Size = New System.Drawing.Size(40, 13)
        Me.lblCCP.TabIndex = 21
        Me.lblCCP.Text = "149.95"
        '
        'lblHHP
        '
        Me.lblHHP.AutoSize = True
        Me.lblHHP.Location = New System.Drawing.Point(175, 137)
        Me.lblHHP.Name = "lblHHP"
        Me.lblHHP.Size = New System.Drawing.Size(34, 13)
        Me.lblHHP.TabIndex = 22
        Me.lblHHP.Text = "89.95"
        '
        'lblSCS
        '
        Me.lblSCS.AutoSize = True
        Me.lblSCS.Location = New System.Drawing.Point(244, 59)
        Me.lblSCS.Name = "lblSCS"
        Me.lblSCS.Size = New System.Drawing.Size(0, 13)
        Me.lblSCS.TabIndex = 23
        '
        'lblFDS
        '
        Me.lblFDS.AutoSize = True
        Me.lblFDS.Location = New System.Drawing.Point(244, 84)
        Me.lblFDS.Name = "lblFDS"
        Me.lblFDS.Size = New System.Drawing.Size(0, 13)
        Me.lblFDS.TabIndex = 24
        '
        'lblCCS
        '
        Me.lblCCS.AutoSize = True
        Me.lblCCS.Location = New System.Drawing.Point(244, 109)
        Me.lblCCS.Name = "lblCCS"
        Me.lblCCS.Size = New System.Drawing.Size(0, 13)
        Me.lblCCS.TabIndex = 25
        '
        'lblHHS
        '
        Me.lblHHS.AutoSize = True
        Me.lblHHS.Location = New System.Drawing.Point(244, 134)
        Me.lblHHS.Name = "lblHHS"
        Me.lblHHS.Size = New System.Drawing.Size(0, 13)
        Me.lblHHS.TabIndex = 26
        '
        'lblSCC
        '
        Me.lblSCC.AutoSize = True
        Me.lblSCC.Location = New System.Drawing.Point(318, 59)
        Me.lblSCC.Name = "lblSCC"
        Me.lblSCC.Size = New System.Drawing.Size(0, 13)
        Me.lblSCC.TabIndex = 27
        '
        'lblFDC
        '
        Me.lblFDC.AutoSize = True
        Me.lblFDC.Location = New System.Drawing.Point(318, 84)
        Me.lblFDC.Name = "lblFDC"
        Me.lblFDC.Size = New System.Drawing.Size(0, 13)
        Me.lblFDC.TabIndex = 28
        '
        'lblCCC
        '
        Me.lblCCC.AutoSize = True
        Me.lblCCC.Location = New System.Drawing.Point(318, 109)
        Me.lblCCC.Name = "lblCCC"
        Me.lblCCC.Size = New System.Drawing.Size(0, 13)
        Me.lblCCC.TabIndex = 29
        '
        'lblHHC
        '
        Me.lblHHC.AutoSize = True
        Me.lblHHC.Location = New System.Drawing.Point(318, 134)
        Me.lblHHC.Name = "lblHHC"
        Me.lblHHC.Size = New System.Drawing.Size(0, 13)
        Me.lblHHC.TabIndex = 30
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 238)
        Me.Controls.Add(Me.lblHHC)
        Me.Controls.Add(Me.lblCCC)
        Me.Controls.Add(Me.lblFDC)
        Me.Controls.Add(Me.lblSCC)
        Me.Controls.Add(Me.lblHHS)
        Me.Controls.Add(Me.lblCCS)
        Me.Controls.Add(Me.lblFDS)
        Me.Controls.Add(Me.lblSCS)
        Me.Controls.Add(Me.lblHHP)
        Me.Controls.Add(Me.lblCCP)
        Me.Controls.Add(Me.lblFDP)
        Me.Controls.Add(Me.lblSCP)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtHHQ)
        Me.Controls.Add(Me.txtCCQ)
        Me.Controls.Add(Me.txtFDQ)
        Me.Controls.Add(Me.txtSCQ)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnTotal)
        Me.Controls.Add(Me.btnSize)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblHH)
        Me.Controls.Add(Me.lblCC)
        Me.Controls.Add(Me.lblFD)
        Me.Controls.Add(Me.lblSC)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblStyle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmOrder"
        Me.Text = "VB Boot Company"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblStyle As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblColor As System.Windows.Forms.Label
    Friend WithEvents lblSC As System.Windows.Forms.Label
    Friend WithEvents lblFD As System.Windows.Forms.Label
    Friend WithEvents lblCC As System.Windows.Forms.Label
    Friend WithEvents lblHH As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnSize As System.Windows.Forms.Button
    Friend WithEvents btnTotal As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents txtSCQ As System.Windows.Forms.TextBox
    Friend WithEvents txtFDQ As System.Windows.Forms.TextBox
    Friend WithEvents txtCCQ As System.Windows.Forms.TextBox
    Friend WithEvents txtHHQ As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSCP As System.Windows.Forms.Label
    Friend WithEvents lblFDP As System.Windows.Forms.Label
    Friend WithEvents lblCCP As System.Windows.Forms.Label
    Friend WithEvents lblHHP As System.Windows.Forms.Label
    Friend WithEvents lblSCS As System.Windows.Forms.Label
    Friend WithEvents lblFDS As System.Windows.Forms.Label
    Friend WithEvents lblCCS As System.Windows.Forms.Label
    Friend WithEvents lblHHS As System.Windows.Forms.Label
    Friend WithEvents lblSCC As System.Windows.Forms.Label
    Friend WithEvents lblFDC As System.Windows.Forms.Label
    Friend WithEvents lblCCC As System.Windows.Forms.Label
    Friend WithEvents lblHHC As System.Windows.Forms.Label
End Class
