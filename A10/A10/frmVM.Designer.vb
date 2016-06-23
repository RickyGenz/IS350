<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVM
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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.grpInputs = New System.Windows.Forms.GroupBox()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.txtPurchase = New System.Windows.Forms.TextBox()
        Me.lstMessages = New System.Windows.Forms.ListBox()
        Me.lblMessages = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblPurchase = New System.Windows.Forms.Label()
        Me.grpOutputs = New System.Windows.Forms.GroupBox()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.txtNickles = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.txtOnes = New System.Windows.Forms.TextBox()
        Me.txtFives = New System.Windows.Forms.TextBox()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblNickles = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblOnes = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.grpInputs.SuspendLayout()
        Me.grpOutputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(12, 244)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(100, 40)
        Me.btnCompute.TabIndex = 16
        Me.btnCompute.Text = "Compute Change"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(145, 244)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 40)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear Entries"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(278, 244)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(100, 40)
        Me.btnQuit.TabIndex = 18
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'grpInputs
        '
        Me.grpInputs.Controls.Add(Me.txtChange)
        Me.grpInputs.Controls.Add(Me.txtPayment)
        Me.grpInputs.Controls.Add(Me.txtPurchase)
        Me.grpInputs.Controls.Add(Me.lstMessages)
        Me.grpInputs.Controls.Add(Me.lblMessages)
        Me.grpInputs.Controls.Add(Me.lblChange)
        Me.grpInputs.Controls.Add(Me.lblPayment)
        Me.grpInputs.Controls.Add(Me.lblPurchase)
        Me.grpInputs.Location = New System.Drawing.Point(12, 12)
        Me.grpInputs.Name = "grpInputs"
        Me.grpInputs.Size = New System.Drawing.Size(233, 218)
        Me.grpInputs.TabIndex = 25
        Me.grpInputs.TabStop = False
        Me.grpInputs.Text = "Inputs"
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(114, 85)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.ReadOnly = True
        Me.txtChange.Size = New System.Drawing.Size(100, 20)
        Me.txtChange.TabIndex = 17
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(114, 52)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtPayment.TabIndex = 16
        Me.txtPayment.Text = "20.00"
        Me.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPurchase
        '
        Me.txtPurchase.Location = New System.Drawing.Point(114, 19)
        Me.txtPurchase.Name = "txtPurchase"
        Me.txtPurchase.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchase.TabIndex = 15
        Me.txtPurchase.Text = "2.27"
        Me.txtPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lstMessages
        '
        Me.lstMessages.FormattingEnabled = True
        Me.lstMessages.Location = New System.Drawing.Point(17, 151)
        Me.lstMessages.Name = "lstMessages"
        Me.lstMessages.Size = New System.Drawing.Size(197, 43)
        Me.lstMessages.TabIndex = 14
        '
        'lblMessages
        '
        Me.lblMessages.AutoSize = True
        Me.lblMessages.Location = New System.Drawing.Point(86, 121)
        Me.lblMessages.Name = "lblMessages"
        Me.lblMessages.Size = New System.Drawing.Size(58, 13)
        Me.lblMessages.TabIndex = 13
        Me.lblMessages.Text = "Messages:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(61, 88)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(47, 13)
        Me.lblChange.TabIndex = 12
        Me.lblChange.Text = "Change:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(18, 55)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(90, 13)
        Me.lblPayment.TabIndex = 11
        Me.lblPayment.Text = "Payment Amount:"
        '
        'lblPurchase
        '
        Me.lblPurchase.AutoSize = True
        Me.lblPurchase.Location = New System.Drawing.Point(14, 22)
        Me.lblPurchase.Name = "lblPurchase"
        Me.lblPurchase.Size = New System.Drawing.Size(94, 13)
        Me.lblPurchase.TabIndex = 10
        Me.lblPurchase.Text = "Purchase Amount:"
        '
        'grpOutputs
        '
        Me.grpOutputs.Controls.Add(Me.txtPennies)
        Me.grpOutputs.Controls.Add(Me.txtNickles)
        Me.grpOutputs.Controls.Add(Me.txtDimes)
        Me.grpOutputs.Controls.Add(Me.txtQuarters)
        Me.grpOutputs.Controls.Add(Me.txtOnes)
        Me.grpOutputs.Controls.Add(Me.txtFives)
        Me.grpOutputs.Controls.Add(Me.lblPennies)
        Me.grpOutputs.Controls.Add(Me.lblNickles)
        Me.grpOutputs.Controls.Add(Me.lblDimes)
        Me.grpOutputs.Controls.Add(Me.lblQuarters)
        Me.grpOutputs.Controls.Add(Me.lblOnes)
        Me.grpOutputs.Controls.Add(Me.lblFive)
        Me.grpOutputs.Location = New System.Drawing.Point(251, 12)
        Me.grpOutputs.Name = "grpOutputs"
        Me.grpOutputs.Size = New System.Drawing.Size(127, 218)
        Me.grpOutputs.TabIndex = 18
        Me.grpOutputs.TabStop = False
        Me.grpOutputs.Text = "Outputs"
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(70, 184)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.ReadOnly = True
        Me.txtPennies.Size = New System.Drawing.Size(37, 20)
        Me.txtPennies.TabIndex = 36
        Me.txtPennies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNickles
        '
        Me.txtNickles.Location = New System.Drawing.Point(70, 151)
        Me.txtNickles.Name = "txtNickles"
        Me.txtNickles.ReadOnly = True
        Me.txtNickles.Size = New System.Drawing.Size(37, 20)
        Me.txtNickles.TabIndex = 35
        Me.txtNickles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDimes
        '
        Me.txtDimes.Location = New System.Drawing.Point(70, 118)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.ReadOnly = True
        Me.txtDimes.Size = New System.Drawing.Size(37, 20)
        Me.txtDimes.TabIndex = 34
        Me.txtDimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuarters
        '
        Me.txtQuarters.Location = New System.Drawing.Point(70, 85)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.ReadOnly = True
        Me.txtQuarters.Size = New System.Drawing.Size(37, 20)
        Me.txtQuarters.TabIndex = 33
        Me.txtQuarters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOnes
        '
        Me.txtOnes.Location = New System.Drawing.Point(70, 52)
        Me.txtOnes.Name = "txtOnes"
        Me.txtOnes.ReadOnly = True
        Me.txtOnes.Size = New System.Drawing.Size(37, 20)
        Me.txtOnes.TabIndex = 32
        Me.txtOnes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFives
        '
        Me.txtFives.Location = New System.Drawing.Point(70, 19)
        Me.txtFives.Name = "txtFives"
        Me.txtFives.ReadOnly = True
        Me.txtFives.Size = New System.Drawing.Size(37, 20)
        Me.txtFives.TabIndex = 31
        Me.txtFives.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(16, 187)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 13)
        Me.lblPennies.TabIndex = 30
        Me.lblPennies.Text = "Pennies:"
        '
        'lblNickles
        '
        Me.lblNickles.AutoSize = True
        Me.lblNickles.Location = New System.Drawing.Point(19, 154)
        Me.lblNickles.Name = "lblNickles"
        Me.lblNickles.Size = New System.Drawing.Size(45, 13)
        Me.lblNickles.TabIndex = 29
        Me.lblNickles.Text = "Nickles:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(25, 121)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(39, 13)
        Me.lblDimes.TabIndex = 28
        Me.lblDimes.Text = "Dimes:"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(14, 88)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(50, 13)
        Me.lblQuarters.TabIndex = 27
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblOnes
        '
        Me.lblOnes.AutoSize = True
        Me.lblOnes.Location = New System.Drawing.Point(29, 55)
        Me.lblOnes.Name = "lblOnes"
        Me.lblOnes.Size = New System.Drawing.Size(35, 13)
        Me.lblOnes.TabIndex = 26
        Me.lblOnes.Text = "Ones:"
        '
        'lblFive
        '
        Me.lblFive.AutoSize = True
        Me.lblFive.Location = New System.Drawing.Point(29, 22)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(35, 13)
        Me.lblFive.TabIndex = 25
        Me.lblFive.Text = "Fives:"
        '
        'frmVM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 299)
        Me.Controls.Add(Me.grpOutputs)
        Me.Controls.Add(Me.grpInputs)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Name = "frmVM"
        Me.Text = "Vending Machine"
        Me.grpInputs.ResumeLayout(False)
        Me.grpInputs.PerformLayout()
        Me.grpOutputs.ResumeLayout(False)
        Me.grpOutputs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents grpInputs As System.Windows.Forms.GroupBox
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchase As System.Windows.Forms.TextBox
    Friend WithEvents lstMessages As System.Windows.Forms.ListBox
    Friend WithEvents lblMessages As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblPurchase As System.Windows.Forms.Label
    Friend WithEvents grpOutputs As System.Windows.Forms.GroupBox
    Friend WithEvents txtPennies As System.Windows.Forms.TextBox
    Friend WithEvents txtNickles As System.Windows.Forms.TextBox
    Friend WithEvents txtDimes As System.Windows.Forms.TextBox
    Friend WithEvents txtQuarters As System.Windows.Forms.TextBox
    Friend WithEvents txtOnes As System.Windows.Forms.TextBox
    Friend WithEvents txtFives As System.Windows.Forms.TextBox
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents lblNickles As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblOnes As System.Windows.Forms.Label
    Friend WithEvents lblFive As System.Windows.Forms.Label
End Class
