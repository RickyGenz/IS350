<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm4
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
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnSL = New System.Windows.Forms.Button()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDDB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 14
        Me.lstOutput.Location = New System.Drawing.Point(15, 100)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(360, 382)
        Me.lstOutput.TabIndex = 17
        '
        'btnSL
        '
        Me.btnSL.Location = New System.Drawing.Point(12, 71)
        Me.btnSL.Name = "btnSL"
        Me.btnSL.Size = New System.Drawing.Size(136, 23)
        Me.btnSL.TabIndex = 14
        Me.btnSL.Text = "Straight-Line Method"
        Me.btnSL.UseVisualStyleBackColor = True
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(306, 6)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(69, 20)
        Me.txtCost.TabIndex = 12
        Me.txtCost.Text = "1500"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(48, 6)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 20)
        Me.txtItem.TabIndex = 11
        Me.txtItem.Text = "computer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Item:"
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(339, 40)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(36, 20)
        Me.txtYears.TabIndex = 21
        Me.txtYears.Text = "5"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(110, 40)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(38, 20)
        Me.txtYear.TabIndex = 20
        Me.txtYear.Text = "2012"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Estimated life of item (years):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Year of Purchase:"
        '
        'btnDDB
        '
        Me.btnDDB.Location = New System.Drawing.Point(196, 71)
        Me.btnDDB.Name = "btnDDB"
        Me.btnDDB.Size = New System.Drawing.Size(179, 23)
        Me.btnDDB.TabIndex = 22
        Me.btnDDB.Text = "Double-Declining-Balance Method"
        Me.btnDDB.UseVisualStyleBackColor = True
        '
        'frm4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 497)
        Me.Controls.Add(Me.btnDDB)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnSL)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm4"
        Me.Text = "Depreciation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnSL As System.Windows.Forms.Button
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDDB As System.Windows.Forms.Button
End Class
