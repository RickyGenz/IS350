<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm20
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm20))
        Me.btnPrintLingo = New System.Windows.Forms.Button()
        Me.btnPreviewLingo = New System.Windows.Forms.Button()
        Me.PrintLingo = New System.Drawing.Printing.PrintDocument()
        Me.PreviewLingo = New System.Windows.Forms.PrintPreviewDialog()
        Me.SuspendLayout()
        '
        'btnPrintLingo
        '
        Me.btnPrintLingo.Location = New System.Drawing.Point(12, 12)
        Me.btnPrintLingo.Name = "btnPrintLingo"
        Me.btnPrintLingo.Size = New System.Drawing.Size(125, 23)
        Me.btnPrintLingo.TabIndex = 0
        Me.btnPrintLingo.Text = "Print Lingo"
        Me.btnPrintLingo.UseVisualStyleBackColor = True
        '
        'btnPreviewLingo
        '
        Me.btnPreviewLingo.Location = New System.Drawing.Point(12, 41)
        Me.btnPreviewLingo.Name = "btnPreviewLingo"
        Me.btnPreviewLingo.Size = New System.Drawing.Size(125, 23)
        Me.btnPreviewLingo.TabIndex = 1
        Me.btnPreviewLingo.Text = "Preview Lingo"
        Me.btnPreviewLingo.UseVisualStyleBackColor = True
        '
        'PrintLingo
        '
        '
        'PreviewLingo
        '
        Me.PreviewLingo.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreviewLingo.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreviewLingo.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreviewLingo.Enabled = True
        Me.PreviewLingo.Icon = CType(resources.GetObject("PreviewLingo.Icon"), System.Drawing.Icon)
        Me.PreviewLingo.Name = "PreviewLingo"
        Me.PreviewLingo.Visible = False
        '
        'frm20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(149, 75)
        Me.Controls.Add(Me.btnPreviewLingo)
        Me.Controls.Add(Me.btnPrintLingo)
        Me.Name = "frm20"
        Me.Text = "20"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrintLingo As System.Windows.Forms.Button
    Friend WithEvents btnPreviewLingo As System.Windows.Forms.Button
    Friend WithEvents PrintLingo As System.Drawing.Printing.PrintDocument
    Friend WithEvents PreviewLingo As System.Windows.Forms.PrintPreviewDialog
End Class
