<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPercentage
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
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.txtDecimal = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(12, 9)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(62, 13)
        Me.lblPercentage.TabIndex = 0
        Me.lblPercentage.Text = "Percentage"
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.Location = New System.Drawing.Point(29, 77)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(45, 13)
        Me.lblDecimal.TabIndex = 1
        Me.lblDecimal.Text = "Decimal"
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(80, 6)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentage.TabIndex = 2
        '
        'txtDecimal
        '
        Me.txtDecimal.Location = New System.Drawing.Point(80, 77)
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.ReadOnly = True
        Me.txtDecimal.Size = New System.Drawing.Size(100, 20)
        Me.txtDecimal.TabIndex = 3
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(54, 41)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'frmPercentage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 114)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtDecimal)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.lblDecimal)
        Me.Controls.Add(Me.lblPercentage)
        Me.Name = "frmPercentage"
        Me.Text = "Percentage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPercentage As System.Windows.Forms.Label
    Friend WithEvents lblDecimal As System.Windows.Forms.Label
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox
    Friend WithEvents txtDecimal As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
End Class
