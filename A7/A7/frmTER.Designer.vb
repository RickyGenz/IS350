<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTER))
        Me.lblOrganization = New System.Windows.Forms.Label()
        Me.lblDates = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.lblMeals = New System.Windows.Forms.Label()
        Me.lblAirplane = New System.Windows.Forms.Label()
        Me.lblLodging = New System.Windows.Forms.Label()
        Me.lblTaxi = New System.Windows.Forms.Label()
        Me.txtOrganization = New System.Windows.Forms.TextBox()
        Me.txtDates = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.txtMeals = New System.Windows.Forms.TextBox()
        Me.txtAirplane = New System.Windows.Forms.TextBox()
        Me.txtLodging = New System.Windows.Forms.TextBox()
        Me.txtTaxi = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.PreviewTER = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintTER = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'lblOrganization
        '
        Me.lblOrganization.AutoSize = True
        Me.lblOrganization.Location = New System.Drawing.Point(30, 9)
        Me.lblOrganization.Name = "lblOrganization"
        Me.lblOrganization.Size = New System.Drawing.Size(102, 13)
        Me.lblOrganization.TabIndex = 0
        Me.lblOrganization.Text = "Organization visited:"
        '
        'lblDates
        '
        Me.lblDates.AutoSize = True
        Me.lblDates.Location = New System.Drawing.Point(94, 36)
        Me.lblDates.Name = "lblDates"
        Me.lblDates.Size = New System.Drawing.Size(38, 13)
        Me.lblDates.TabIndex = 1
        Me.lblDates.Text = "Dates:"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(81, 63)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(51, 13)
        Me.lblLocation.TabIndex = 2
        Me.lblLocation.Text = "Location:"
        '
        'lblMeals
        '
        Me.lblMeals.AutoSize = True
        Me.lblMeals.Location = New System.Drawing.Point(5, 90)
        Me.lblMeals.Name = "lblMeals"
        Me.lblMeals.Size = New System.Drawing.Size(127, 13)
        Me.lblMeals.TabIndex = 3
        Me.lblMeals.Text = "Meals and Entertainment:"
        '
        'lblAirplane
        '
        Me.lblAirplane.AutoSize = True
        Me.lblAirplane.Location = New System.Drawing.Point(60, 117)
        Me.lblAirplane.Name = "lblAirplane"
        Me.lblAirplane.Size = New System.Drawing.Size(72, 13)
        Me.lblAirplane.TabIndex = 4
        Me.lblAirplane.Text = "Airplane Fare:"
        '
        'lblLodging
        '
        Me.lblLodging.AutoSize = True
        Me.lblLodging.Location = New System.Drawing.Point(84, 144)
        Me.lblLodging.Name = "lblLodging"
        Me.lblLodging.Size = New System.Drawing.Size(48, 13)
        Me.lblLodging.TabIndex = 5
        Me.lblLodging.Text = "Lodging:"
        '
        'lblTaxi
        '
        Me.lblTaxi.AutoSize = True
        Me.lblTaxi.Location = New System.Drawing.Point(73, 171)
        Me.lblTaxi.Name = "lblTaxi"
        Me.lblTaxi.Size = New System.Drawing.Size(59, 13)
        Me.lblTaxi.TabIndex = 6
        Me.lblTaxi.Text = "Taxi Fares:"
        '
        'txtOrganization
        '
        Me.txtOrganization.Location = New System.Drawing.Point(138, 6)
        Me.txtOrganization.Name = "txtOrganization"
        Me.txtOrganization.Size = New System.Drawing.Size(121, 20)
        Me.txtOrganization.TabIndex = 7
        Me.txtOrganization.Text = "SIGCSE 2010"
        '
        'txtDates
        '
        Me.txtDates.Location = New System.Drawing.Point(138, 33)
        Me.txtDates.Name = "txtDates"
        Me.txtDates.Size = New System.Drawing.Size(121, 20)
        Me.txtDates.TabIndex = 8
        Me.txtDates.Text = "March 10-13"
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(138, 60)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(121, 20)
        Me.txtLocation.TabIndex = 9
        Me.txtLocation.Text = "Milwaukee, WI"
        '
        'txtMeals
        '
        Me.txtMeals.Location = New System.Drawing.Point(138, 87)
        Me.txtMeals.Name = "txtMeals"
        Me.txtMeals.Size = New System.Drawing.Size(121, 20)
        Me.txtMeals.TabIndex = 10
        Me.txtMeals.Text = "190.10"
        '
        'txtAirplane
        '
        Me.txtAirplane.Location = New System.Drawing.Point(138, 114)
        Me.txtAirplane.Name = "txtAirplane"
        Me.txtAirplane.Size = New System.Drawing.Size(121, 20)
        Me.txtAirplane.TabIndex = 11
        Me.txtAirplane.Text = "250.15"
        '
        'txtLodging
        '
        Me.txtLodging.Location = New System.Drawing.Point(138, 141)
        Me.txtLodging.Name = "txtLodging"
        Me.txtLodging.Size = New System.Drawing.Size(121, 20)
        Me.txtLodging.TabIndex = 12
        Me.txtLodging.Text = "675.35"
        '
        'txtTaxi
        '
        Me.txtTaxi.Location = New System.Drawing.Point(138, 168)
        Me.txtTaxi.Name = "txtTaxi"
        Me.txtTaxi.Size = New System.Drawing.Size(121, 20)
        Me.txtTaxi.TabIndex = 13
        Me.txtTaxi.Text = "45.00"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(12, 194)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(245, 23)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print Business Travel Expenses Attachment"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(12, 220)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(245, 23)
        Me.btnPreview.TabIndex = 15
        Me.btnPreview.Text = "Preview Business Travel Expenses Attachment"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'PreviewTER
        '
        Me.PreviewTER.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PreviewTER.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PreviewTER.ClientSize = New System.Drawing.Size(400, 300)
        Me.PreviewTER.Enabled = True
        Me.PreviewTER.Icon = CType(resources.GetObject("PreviewTER.Icon"), System.Drawing.Icon)
        Me.PreviewTER.Name = "PreviewTER"
        Me.PreviewTER.Visible = False
        '
        'PrintTER
        '
        '
        'frmTER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 253)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtTaxi)
        Me.Controls.Add(Me.txtLodging)
        Me.Controls.Add(Me.txtAirplane)
        Me.Controls.Add(Me.txtMeals)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.txtDates)
        Me.Controls.Add(Me.txtOrganization)
        Me.Controls.Add(Me.lblTaxi)
        Me.Controls.Add(Me.lblLodging)
        Me.Controls.Add(Me.lblAirplane)
        Me.Controls.Add(Me.lblMeals)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblDates)
        Me.Controls.Add(Me.lblOrganization)
        Me.Name = "frmTER"
        Me.Text = "Business Travel Expenses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOrganization As System.Windows.Forms.Label
    Friend WithEvents lblDates As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents lblMeals As System.Windows.Forms.Label
    Friend WithEvents lblAirplane As System.Windows.Forms.Label
    Friend WithEvents lblLodging As System.Windows.Forms.Label
    Friend WithEvents lblTaxi As System.Windows.Forms.Label
    Friend WithEvents txtOrganization As System.Windows.Forms.TextBox
    Friend WithEvents txtDates As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents txtMeals As System.Windows.Forms.TextBox
    Friend WithEvents txtAirplane As System.Windows.Forms.TextBox
    Friend WithEvents txtLodging As System.Windows.Forms.TextBox
    Friend WithEvents txtTaxi As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents PreviewTER As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintTER As System.Drawing.Printing.PrintDocument
End Class
