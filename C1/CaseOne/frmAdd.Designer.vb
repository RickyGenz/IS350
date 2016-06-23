<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Me.lblUnderline = New System.Windows.Forms.Label()
        Me.txtBoxTotalCost = New System.Windows.Forms.TextBox()
        Me.txtBoxWrap = New System.Windows.Forms.TextBox()
        Me.txtBoxTele = New System.Windows.Forms.TextBox()
        Me.txtBoxMono = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblWrapping = New System.Windows.Forms.Label()
        Me.lblTelegramming = New System.Windows.Forms.Label()
        Me.lblMonogramming = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnComputeTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnWrapping = New System.Windows.Forms.Button()
        Me.btnTelegram = New System.Windows.Forms.Button()
        Me.btnMonogram = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblUnderline
        '
        Me.lblUnderline.AutoSize = True
        Me.lblUnderline.Location = New System.Drawing.Point(132, 188)
        Me.lblUnderline.Name = "lblUnderline"
        Me.lblUnderline.Size = New System.Drawing.Size(175, 13)
        Me.lblUnderline.TabIndex = 32
        Me.lblUnderline.Text = "____________________________"
        '
        'txtBoxTotalCost
        '
        Me.txtBoxTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTotalCost.Location = New System.Drawing.Point(245, 219)
        Me.txtBoxTotalCost.Name = "txtBoxTotalCost"
        Me.txtBoxTotalCost.Size = New System.Drawing.Size(62, 20)
        Me.txtBoxTotalCost.TabIndex = 31
        Me.txtBoxTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxWrap
        '
        Me.txtBoxWrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxWrap.Location = New System.Drawing.Point(245, 151)
        Me.txtBoxWrap.Name = "txtBoxWrap"
        Me.txtBoxWrap.Size = New System.Drawing.Size(62, 20)
        Me.txtBoxWrap.TabIndex = 30
        Me.txtBoxWrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxTele
        '
        Me.txtBoxTele.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxTele.Location = New System.Drawing.Point(245, 115)
        Me.txtBoxTele.Name = "txtBoxTele"
        Me.txtBoxTele.Size = New System.Drawing.Size(62, 20)
        Me.txtBoxTele.TabIndex = 29
        Me.txtBoxTele.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBoxMono
        '
        Me.txtBoxMono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxMono.Location = New System.Drawing.Point(245, 81)
        Me.txtBoxMono.Name = "txtBoxMono"
        Me.txtBoxMono.Size = New System.Drawing.Size(62, 20)
        Me.txtBoxMono.TabIndex = 28
        Me.txtBoxMono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(133, 219)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 27
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'lblWrapping
        '
        Me.lblWrapping.AutoSize = True
        Me.lblWrapping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrapping.Location = New System.Drawing.Point(133, 158)
        Me.lblWrapping.Name = "lblWrapping"
        Me.lblWrapping.Size = New System.Drawing.Size(85, 13)
        Me.lblWrapping.TabIndex = 26
        Me.lblWrapping.Text = "Wrapping Costs:"
        '
        'lblTelegramming
        '
        Me.lblTelegramming.AutoSize = True
        Me.lblTelegramming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelegramming.Location = New System.Drawing.Point(131, 122)
        Me.lblTelegramming.Name = "lblTelegramming"
        Me.lblTelegramming.Size = New System.Drawing.Size(83, 13)
        Me.lblTelegramming.TabIndex = 25
        Me.lblTelegramming.Text = "Telegram Costs:"
        '
        'lblMonogramming
        '
        Me.lblMonogramming.AutoSize = True
        Me.lblMonogramming.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonogramming.Location = New System.Drawing.Point(132, 88)
        Me.lblMonogramming.Name = "lblMonogramming"
        Me.lblMonogramming.Size = New System.Drawing.Size(82, 13)
        Me.lblMonogramming.TabIndex = 24
        Me.lblMonogramming.Text = "Monogramming:"
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(251, 297)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 48)
        Me.btnReturn.TabIndex = 23
        Me.btnReturn.Text = "Return to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Main Form"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnComputeTotal
        '
        Me.btnComputeTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnComputeTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeTotal.Location = New System.Drawing.Point(148, 297)
        Me.btnComputeTotal.Name = "btnComputeTotal"
        Me.btnComputeTotal.Size = New System.Drawing.Size(75, 48)
        Me.btnComputeTotal.TabIndex = 22
        Me.btnComputeTotal.Text = "Compute" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Total"
        Me.btnComputeTotal.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(45, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 48)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnWrapping
        '
        Me.btnWrapping.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnWrapping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrapping.Location = New System.Drawing.Point(12, 219)
        Me.btnWrapping.Name = "btnWrapping"
        Me.btnWrapping.Size = New System.Drawing.Size(75, 57)
        Me.btnWrapping.TabIndex = 20
        Me.btnWrapping.Text = " Add Gift" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wrapping"
        Me.btnWrapping.UseVisualStyleBackColor = False
        '
        'btnTelegram
        '
        Me.btnTelegram.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnTelegram.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTelegram.Location = New System.Drawing.Point(12, 151)
        Me.btnTelegram.Name = "btnTelegram"
        Me.btnTelegram.Size = New System.Drawing.Size(75, 50)
        Me.btnTelegram.TabIndex = 19
        Me.btnTelegram.Text = "   Add a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Telegram"
        Me.btnTelegram.UseVisualStyleBackColor = False
        '
        'btnMonogram
        '
        Me.btnMonogram.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnMonogram.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMonogram.Location = New System.Drawing.Point(12, 81)
        Me.btnMonogram.Name = "btnMonogram"
        Me.btnMonogram.Size = New System.Drawing.Size(75, 52)
        Me.btnMonogram.TabIndex = 18
        Me.btnMonogram.Text = "   Add a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Monogram"
        Me.btnMonogram.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(8, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(318, 40)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "     ADD MONOGRAMMING, GIFT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WRAPPING, OR SEND A TELEGRAM:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 357)
        Me.Controls.Add(Me.lblUnderline)
        Me.Controls.Add(Me.txtBoxTotalCost)
        Me.Controls.Add(Me.txtBoxWrap)
        Me.Controls.Add(Me.txtBoxTele)
        Me.Controls.Add(Me.txtBoxMono)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblWrapping)
        Me.Controls.Add(Me.lblTelegramming)
        Me.Controls.Add(Me.lblMonogramming)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnComputeTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnWrapping)
        Me.Controls.Add(Me.btnTelegram)
        Me.Controls.Add(Me.btnMonogram)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAdd"
        Me.Text = "Additional Charges Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUnderline As System.Windows.Forms.Label
    Friend WithEvents txtBoxTotalCost As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxWrap As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxTele As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxMono As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents lblWrapping As System.Windows.Forms.Label
    Friend WithEvents lblTelegramming As System.Windows.Forms.Label
    Friend WithEvents lblMonogramming As System.Windows.Forms.Label
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnComputeTotal As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnWrapping As System.Windows.Forms.Button
    Friend WithEvents btnTelegram As System.Windows.Forms.Button
    Friend WithEvents btnMonogram As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
