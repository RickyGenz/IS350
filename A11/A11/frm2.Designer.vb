<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2
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
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.txtFood = New System.Windows.Forms.TextBox()
        Me.txtCalories = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblFood
        '
        Me.lblFood.AutoSize = True
        Me.lblFood.Location = New System.Drawing.Point(12, 9)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(77, 13)
        Me.lblFood.TabIndex = 0
        Me.lblFood.Text = "Name of Food:"
        '
        'lblCalories
        '
        Me.lblCalories.AutoSize = True
        Me.lblCalories.Location = New System.Drawing.Point(12, 37)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(104, 13)
        Me.lblCalories.TabIndex = 1
        Me.lblCalories.Text = "Calories per Serving:"
        '
        'lblFat
        '
        Me.lblFat.AutoSize = True
        Me.lblFat.Location = New System.Drawing.Point(12, 65)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(127, 13)
        Me.lblFat.TabIndex = 2
        Me.lblFat.Text = "Grams of Fat per Serving:"
        '
        'txtFood
        '
        Me.txtFood.Location = New System.Drawing.Point(95, 6)
        Me.txtFood.Name = "txtFood"
        Me.txtFood.Size = New System.Drawing.Size(169, 20)
        Me.txtFood.TabIndex = 3
        Me.txtFood.Text = "Lowfat Milk"
        '
        'txtCalories
        '
        Me.txtCalories.Location = New System.Drawing.Point(122, 34)
        Me.txtCalories.Name = "txtCalories"
        Me.txtCalories.Size = New System.Drawing.Size(142, 20)
        Me.txtCalories.TabIndex = 4
        Me.txtCalories.Text = "120"
        Me.txtCalories.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(145, 62)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(119, 20)
        Me.txtFat.TabIndex = 5
        Me.txtFat.Text = "5"
        Me.txtFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(15, 88)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(249, 23)
        Me.btnCompute.TabIndex = 7
        Me.btnCompute.Text = "Compute % Calories from Fat"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(15, 117)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(249, 43)
        Me.lstResult.TabIndex = 8
        '
        'frm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 172)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtCalories)
        Me.Controls.Add(Me.txtFood)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblFood)
        Me.Name = "frm2"
        Me.Text = "Nutrition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFood As System.Windows.Forms.Label
    Friend WithEvents lblCalories As System.Windows.Forms.Label
    Friend WithEvents lblFat As System.Windows.Forms.Label
    Friend WithEvents txtFood As System.Windows.Forms.TextBox
    Friend WithEvents txtCalories As System.Windows.Forms.TextBox
    Friend WithEvents txtFat As System.Windows.Forms.TextBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
End Class
