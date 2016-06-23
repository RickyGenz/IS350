<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtZip
        '
        Me.txtZip.AccessibleDescription = ""
        Me.txtZip.AccessibleName = "Zip Code"
        Me.txtZip.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtZip.Location = New System.Drawing.Point(12, 12)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(166, 20)
        Me.txtZip.TabIndex = 0
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(12, 64)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(166, 23)
        Me.btnTest.TabIndex = 2
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtState
        '
        Me.txtState.AccessibleDescription = ""
        Me.txtState.AccessibleName = "State"
        Me.txtState.AccessibleRole = System.Windows.Forms.AccessibleRole.Text
        Me.txtState.Location = New System.Drawing.Point(12, 38)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(166, 20)
        Me.txtState.TabIndex = 1
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 98)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmTest"
        Me.Text = "Test Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents txtState As System.Windows.Forms.TextBox
End Class
