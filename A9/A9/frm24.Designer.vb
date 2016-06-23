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
        Me.lblCallNumber = New System.Windows.Forms.Label()
        Me.txtCallNumber = New System.Windows.Forms.TextBox()
        Me.btnFindBook = New System.Windows.Forms.Button()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCallNumber
        '
        Me.lblCallNumber.AutoSize = True
        Me.lblCallNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblCallNumber.Name = "lblCallNumber"
        Me.lblCallNumber.Size = New System.Drawing.Size(67, 13)
        Me.lblCallNumber.TabIndex = 0
        Me.lblCallNumber.Text = "Call Number:"
        '
        'txtCallNumber
        '
        Me.txtCallNumber.Location = New System.Drawing.Point(85, 6)
        Me.txtCallNumber.Name = "txtCallNumber"
        Me.txtCallNumber.Size = New System.Drawing.Size(102, 20)
        Me.txtCallNumber.TabIndex = 1
        '
        'btnFindBook
        '
        Me.btnFindBook.Location = New System.Drawing.Point(12, 32)
        Me.btnFindBook.Name = "btnFindBook"
        Me.btnFindBook.Size = New System.Drawing.Size(175, 23)
        Me.btnFindBook.TabIndex = 2
        Me.btnFindBook.Text = "Find Book"
        Me.btnFindBook.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(85, 61)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.ReadOnly = True
        Me.txtLocation.Size = New System.Drawing.Size(102, 20)
        Me.txtLocation.TabIndex = 4
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(28, 64)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblLocation.TabIndex = 3
        Me.lblLocation.Text = "Location:"
        '
        'frm24
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 91)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.btnFindBook)
        Me.Controls.Add(Me.txtCallNumber)
        Me.Controls.Add(Me.lblCallNumber)
        Me.Name = "frm24"
        Me.Text = "Library Books"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCallNumber As System.Windows.Forms.Label
    Friend WithEvents txtCallNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnFindBook As System.Windows.Forms.Button
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblLocation As System.Windows.Forms.Label
End Class
