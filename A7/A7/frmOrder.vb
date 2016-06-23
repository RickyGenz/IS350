Public Class frmOrder
    Private Sub btnSize_Click(sender As Object, e As EventArgs) Handles btnSize.Click
        frmSize.ShowDialog()

        lblSCS.Text = SCS & ", " & SCW
        lblSCC.Text = SCC

        lblFDS.Text = FDS & ", " & FDW
        lblFDC.Text = FDC

        lblCCS.Text = CCS & ", " & CCW
        lblCCC.Text = CCC

        lblHHS.Text = HHS & ", " & HHW
        lblHHC.Text = HHC
    End Sub
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim SCQ, SCP, SCT, FDQ, FDP, FDT, CCQ, CCP, CCT, HHQ, HHP, HHT, Total As Single

        SCQ = txtSCQ.Text
        SCP = lblSCP.Text
        SCT = SCQ * SCP

        FDQ = txtFDQ.Text
        FDP = lblFDP.Text
        FDT = FDQ * FDP

        CCQ = txtCCQ.Text
        CCP = lblCCP.Text
        CCT = CCQ * CCP

        HHQ = txtHHQ.Text
        HHP = lblHHP.Text
        HHT = HHQ * HHP

        Total = SCT + FDT + CCT + HHT
        txtTotal.Text = FormatCurrency(Total)
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class