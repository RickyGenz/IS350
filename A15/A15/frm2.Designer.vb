﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 12)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtOutput.TabIndex = 0
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(118, 12)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'frm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 42)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.txtOutput)
        Me.Name = "frm2"
        Me.Text = "Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
End Class
