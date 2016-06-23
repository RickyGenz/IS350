<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm28
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnAnalyze = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sentence:"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(74, 6)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(198, 20)
        Me.txtInput.TabIndex = 1
        Me.txtInput.Text = "I wish life had an Undo function."
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(15, 61)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(257, 20)
        Me.txtOutput.TabIndex = 2
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Location = New System.Drawing.Point(15, 32)
        Me.btnAnalyze.Name = "btnAnalyze"
        Me.btnAnalyze.Size = New System.Drawing.Size(257, 23)
        Me.btnAnalyze.TabIndex = 3
        Me.btnAnalyze.Text = "Analyze Sentence for Sibilants"
        Me.btnAnalyze.UseVisualStyleBackColor = True
        '
        'frm28
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 91)
        Me.Controls.Add(Me.btnAnalyze)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm28"
        Me.Text = "Sibilants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnAnalyze As System.Windows.Forms.Button
End Class
