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
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.lblSolution = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.txtSolution = New System.Windows.Forms.TextBox()
        Me.btnSolution = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(12, 9)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(17, 13)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "A:"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(84, 9)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(17, 13)
        Me.lblB.TabIndex = 1
        Me.lblB.Text = "B:"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(156, 9)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(17, 13)
        Me.lblC.TabIndex = 2
        Me.lblC.Text = "C:"
        '
        'lblSolution
        '
        Me.lblSolution.AutoSize = True
        Me.lblSolution.Location = New System.Drawing.Point(12, 64)
        Me.lblSolution.Name = "lblSolution"
        Me.lblSolution.Size = New System.Drawing.Size(48, 13)
        Me.lblSolution.TabIndex = 3
        Me.lblSolution.Text = "Solution:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(35, 6)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(24, 20)
        Me.txtA.TabIndex = 4
        Me.txtA.Text = "1"
        Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(107, 6)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(24, 20)
        Me.txtB.TabIndex = 5
        Me.txtB.Text = "-11"
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(179, 6)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(24, 20)
        Me.txtC.TabIndex = 6
        Me.txtC.Text = "28"
        Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSolution
        '
        Me.txtSolution.Location = New System.Drawing.Point(66, 61)
        Me.txtSolution.Name = "txtSolution"
        Me.txtSolution.ReadOnly = True
        Me.txtSolution.Size = New System.Drawing.Size(137, 20)
        Me.txtSolution.TabIndex = 7
        Me.txtSolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSolution
        '
        Me.btnSolution.Location = New System.Drawing.Point(15, 32)
        Me.btnSolution.Name = "btnSolution"
        Me.btnSolution.Size = New System.Drawing.Size(188, 23)
        Me.btnSolution.TabIndex = 8
        Me.btnSolution.Text = "Find Solution"
        Me.btnSolution.UseVisualStyleBackColor = True
        '
        'frm4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 93)
        Me.Controls.Add(Me.btnSolution)
        Me.Controls.Add(Me.txtSolution)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblSolution)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Name = "frm4"
        Me.Text = "Quadratic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents lblSolution As System.Windows.Forms.Label
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents txtSolution As System.Windows.Forms.TextBox
    Friend WithEvents btnSolution As System.Windows.Forms.Button
End Class
