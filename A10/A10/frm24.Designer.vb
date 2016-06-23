<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm24
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
        Me.grpFColor = New System.Windows.Forms.GroupBox()
        Me.rdoFBlue = New System.Windows.Forms.RadioButton()
        Me.rdoFRed = New System.Windows.Forms.RadioButton()
        Me.rdoFYellow = New System.Windows.Forms.RadioButton()
        Me.rdoFWhite = New System.Windows.Forms.RadioButton()
        Me.grpBColor = New System.Windows.Forms.GroupBox()
        Me.rdoBBlue = New System.Windows.Forms.RadioButton()
        Me.rdoBRed = New System.Windows.Forms.RadioButton()
        Me.rdoBYellow = New System.Windows.Forms.RadioButton()
        Me.rdoBWhite = New System.Windows.Forms.RadioButton()
        Me.lblVB = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.grpFColor.SuspendLayout()
        Me.grpBColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFColor
        '
        Me.grpFColor.Controls.Add(Me.rdoFBlue)
        Me.grpFColor.Controls.Add(Me.rdoFRed)
        Me.grpFColor.Controls.Add(Me.rdoFYellow)
        Me.grpFColor.Controls.Add(Me.rdoFWhite)
        Me.grpFColor.Location = New System.Drawing.Point(12, 12)
        Me.grpFColor.Name = "grpFColor"
        Me.grpFColor.Size = New System.Drawing.Size(109, 114)
        Me.grpFColor.TabIndex = 0
        Me.grpFColor.TabStop = False
        Me.grpFColor.Text = "Foreground Color"
        '
        'rdoFBlue
        '
        Me.rdoFBlue.AutoSize = True
        Me.rdoFBlue.Location = New System.Drawing.Point(6, 91)
        Me.rdoFBlue.Name = "rdoFBlue"
        Me.rdoFBlue.Size = New System.Drawing.Size(46, 17)
        Me.rdoFBlue.TabIndex = 3
        Me.rdoFBlue.TabStop = True
        Me.rdoFBlue.Text = "Blue"
        Me.rdoFBlue.UseVisualStyleBackColor = True
        '
        'rdoFRed
        '
        Me.rdoFRed.AutoSize = True
        Me.rdoFRed.Location = New System.Drawing.Point(6, 67)
        Me.rdoFRed.Name = "rdoFRed"
        Me.rdoFRed.Size = New System.Drawing.Size(45, 17)
        Me.rdoFRed.TabIndex = 2
        Me.rdoFRed.TabStop = True
        Me.rdoFRed.Text = "Red"
        Me.rdoFRed.UseVisualStyleBackColor = True
        '
        'rdoFYellow
        '
        Me.rdoFYellow.AutoSize = True
        Me.rdoFYellow.Location = New System.Drawing.Point(6, 44)
        Me.rdoFYellow.Name = "rdoFYellow"
        Me.rdoFYellow.Size = New System.Drawing.Size(56, 17)
        Me.rdoFYellow.TabIndex = 1
        Me.rdoFYellow.TabStop = True
        Me.rdoFYellow.Text = "Yellow"
        Me.rdoFYellow.UseVisualStyleBackColor = True
        '
        'rdoFWhite
        '
        Me.rdoFWhite.AutoCheck = False
        Me.rdoFWhite.AutoSize = True
        Me.rdoFWhite.Location = New System.Drawing.Point(6, 19)
        Me.rdoFWhite.Name = "rdoFWhite"
        Me.rdoFWhite.Size = New System.Drawing.Size(53, 17)
        Me.rdoFWhite.TabIndex = 0
        Me.rdoFWhite.TabStop = True
        Me.rdoFWhite.Text = "White"
        Me.rdoFWhite.UseVisualStyleBackColor = True
        '
        'grpBColor
        '
        Me.grpBColor.Controls.Add(Me.rdoBBlue)
        Me.grpBColor.Controls.Add(Me.rdoBRed)
        Me.grpBColor.Controls.Add(Me.rdoBYellow)
        Me.grpBColor.Controls.Add(Me.rdoBWhite)
        Me.grpBColor.Location = New System.Drawing.Point(135, 12)
        Me.grpBColor.Name = "grpBColor"
        Me.grpBColor.Size = New System.Drawing.Size(109, 114)
        Me.grpBColor.TabIndex = 1
        Me.grpBColor.TabStop = False
        Me.grpBColor.Text = "Background Color"
        '
        'rdoBBlue
        '
        Me.rdoBBlue.AutoSize = True
        Me.rdoBBlue.Location = New System.Drawing.Point(8, 88)
        Me.rdoBBlue.Name = "rdoBBlue"
        Me.rdoBBlue.Size = New System.Drawing.Size(46, 17)
        Me.rdoBBlue.TabIndex = 3
        Me.rdoBBlue.TabStop = True
        Me.rdoBBlue.Text = "Blue"
        Me.rdoBBlue.UseVisualStyleBackColor = True
        '
        'rdoBRed
        '
        Me.rdoBRed.AutoSize = True
        Me.rdoBRed.Location = New System.Drawing.Point(8, 65)
        Me.rdoBRed.Name = "rdoBRed"
        Me.rdoBRed.Size = New System.Drawing.Size(45, 17)
        Me.rdoBRed.TabIndex = 2
        Me.rdoBRed.TabStop = True
        Me.rdoBRed.Text = "Red"
        Me.rdoBRed.UseVisualStyleBackColor = True
        '
        'rdoBYellow
        '
        Me.rdoBYellow.AutoSize = True
        Me.rdoBYellow.Location = New System.Drawing.Point(8, 42)
        Me.rdoBYellow.Name = "rdoBYellow"
        Me.rdoBYellow.Size = New System.Drawing.Size(56, 17)
        Me.rdoBYellow.TabIndex = 1
        Me.rdoBYellow.TabStop = True
        Me.rdoBYellow.Text = "Yellow"
        Me.rdoBYellow.UseVisualStyleBackColor = True
        '
        'rdoBWhite
        '
        Me.rdoBWhite.AutoSize = True
        Me.rdoBWhite.Location = New System.Drawing.Point(8, 19)
        Me.rdoBWhite.Name = "rdoBWhite"
        Me.rdoBWhite.Size = New System.Drawing.Size(53, 17)
        Me.rdoBWhite.TabIndex = 0
        Me.rdoBWhite.TabStop = True
        Me.rdoBWhite.Text = "White"
        Me.rdoBWhite.UseVisualStyleBackColor = True
        '
        'lblVB
        '
        Me.lblVB.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVB.Location = New System.Drawing.Point(30, 167)
        Me.lblVB.Name = "lblVB"
        Me.lblVB.Size = New System.Drawing.Size(203, 34)
        Me.lblVB.TabIndex = 0
        Me.lblVB.Text = "VISUAL BASIC"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(12, 132)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(232, 23)
        Me.btnApply.TabIndex = 2
        Me.btnApply.Text = "Apply Colors"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'frm24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 212)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lblVB)
        Me.Controls.Add(Me.grpBColor)
        Me.Controls.Add(Me.grpFColor)
        Me.Name = "frm24"
        Me.Text = "Colors"
        Me.grpFColor.ResumeLayout(False)
        Me.grpFColor.PerformLayout()
        Me.grpBColor.ResumeLayout(False)
        Me.grpBColor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpFColor As System.Windows.Forms.GroupBox
    Friend WithEvents grpBColor As System.Windows.Forms.GroupBox
    Friend WithEvents lblVB As System.Windows.Forms.Label
    Friend WithEvents rdoFBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFRed As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFYellow As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFWhite As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBBlue As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBRed As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBYellow As System.Windows.Forms.RadioButton
    Friend WithEvents rdoBWhite As System.Windows.Forms.RadioButton
    Friend WithEvents btnApply As System.Windows.Forms.Button
End Class
