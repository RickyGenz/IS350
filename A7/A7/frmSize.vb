Public Class frmSize
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        SCS = txtSCS.Text
        SCW = txtSCW.Text
        SCC = txtSCC.Text

        FDS = txtFDS.Text
        FDW = txtFDW.Text
        FDC = txtFDC.Text

        CCS = txtCCS.Text
        CCW = txtCCW.Text
        CCC = txtCCC.Text

        HHS = txtHHS.Text
        HHW = txtHHW.Text
        HHC = txtHHC.Text

        Me.Close()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSCS.Clear()
        txtSCW.Clear()
        txtSCC.Clear()

        txtFDS.Clear()
        txtFDW.Clear()
        txtFDC.Clear()

        txtCCS.Clear()
        txtCCW.Clear()
        txtCCC.Clear()

        txtHHS.Clear()
        txtHHW.Clear()
        txtHHC.Clear()
    End Sub
End Class