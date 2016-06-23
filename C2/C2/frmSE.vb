Public Class frmSE

    Public Function IsInputInvalid() As Boolean
        'Tests if any input is invalid
        Dim Controls = From c In Me.Controls Order By c.TabIndex
        For Each c In Controls
            If c.AccessibleDescription = "Required" Then
                Dim num = CZer(c.Text)
                If IsNegative(num) Then
                    MsgBox(c.AccessibleName & " is not valid. Must be positive.", MsgBoxStyle.Critical, "Error")
                    c.Focus()
                    Return True
                End If
            End If
            If c.Name = "txtAName" Then
                If Not IsBlank(c) Then
                    If IsBlank(txtARent) Then
                        MsgBox(txtARent.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                        c.Focus()
                        Return True
                    End If
                End If
            ElseIf c.Name = "txtBName" Then
                If Not IsBlank(c) Then
                    If IsBlank(txtBRent) Then
                        MsgBox(txtBRent.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                        c.Focus()
                        Return True
                    End If
                End If
            ElseIf c.Name = "txtCName" Then
                If Not IsBlank(c) Then
                    If IsBlank(txtCRent) Then
                        MsgBox(txtCRent.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                        c.Focus()
                        Return True
                    End If
                End If
            End If
        Next
        Return False
    End Function

    Private Sub UtilityButtons(sender As Object, e As EventArgs) Handles btnReturn.Click, btnExit.Click
        'Returns to the main form
        If sender Is btnReturn Then Close()
        'Ends execution
        If sender Is btnExit Then End
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Runs invalid input test
        If IsInputInvalid() Then Exit Sub
        'For Property A stores amounts in local variables and formats as currency
        Dim AR = CZer(txtARent.Text)
        txtARent.Text = FormatCurrency(AR)
        Dim AA = CZer(txtAAds.Text)
        txtAAds.Text = FormatCurrency(AA)
        Dim AT = CZer(txtATravel.Text)
        txtATravel.Text = FormatCurrency(AT)
        Dim AC = CZer(txtACleaning.Text)
        txtACleaning.Text = FormatCurrency(AC)
        Dim AM = CZer(txtAInterest.Text)
        txtAInterest.Text = FormatCurrency(AM)
        Dim AO = CZer(txtAOther.Text)
        txtAOther.Text = FormatCurrency(AO)
        'For Property A calculates the total and then formats as currency
        Dim AB = AR - (AA + AT + AC + AM + AO)
        txtASub.Text = FormatCurrency(AB)
        Dim AD = CZer(txtADep.Text)
        txtADep.Text = FormatCurrency(AD)
        Dim AG = AB - AD
        txtATotal.Text = FormatCurrency(AG)
        'For Property B stores amounts in local variables and formats as currency
        Dim BR = CZer(txtBRent.Text)
        txtBRent.Text = FormatCurrency(BR)
        Dim BA = CZer(txtBAds.Text)
        txtBAds.Text = FormatCurrency(BA)
        Dim BT = CZer(txtBTravel.Text)
        txtBTravel.Text = FormatCurrency(BT)
        Dim BC = CZer(txtBCleaning.Text)
        txtBCleaning.Text = FormatCurrency(BC)
        Dim BM = CZer(txtBInterest.Text)
        txtBInterest.Text = FormatCurrency(BM)
        Dim BO = CZer(txtBOther.Text)
        txtBOther.Text = FormatCurrency(BO)
        'For Property B calculates the total and then formats as currency
        Dim BB = BR - (BA + BT + BC + BM + BO)
        txtBSub.Text = FormatCurrency(BB)
        Dim BD = CZer(txtBDep.Text)
        txtBDep.Text = FormatCurrency(BD)
        Dim BG = BB - BD
        txtBTotal.Text = FormatCurrency(BG)
        'For Property C stores amounts in local variables and formats as currency
        Dim CR = CZer(txtCRent.Text)
        txtCRent.Text = FormatCurrency(CR)
        Dim CA = CZer(txtCAds.Text)
        txtCAds.Text = FormatCurrency(CA)
        Dim CT = CZer(txtCTravel.Text)
        txtCTravel.Text = FormatCurrency(CT)
        Dim CC = CZer(txtCCleaning.Text)
        txtCCleaning.Text = FormatCurrency(CC)
        Dim CM = CZer(txtCInterest.Text)
        txtCInterest.Text = FormatCurrency(CM)
        Dim CO = CZer(txtCOther.Text)
        txtCOther.Text = FormatCurrency(CO)
        'For Property C calculates the total and then formats as currency
        Dim CB = CR - (CA + CT + CC + CM + CO)
        txtCSub.Text = FormatCurrency(CB)
        Dim CD = CZer(txtCDep.Text)
        txtCDep.Text = FormatCurrency(CD)
        Dim CG = CB - CD
        txtCTotal.Text = FormatCurrency(CG)
        'Determines positive and negative total amounts
        Dim PT, NT As Decimal
        If AG > 0 Then PT += AG Else NT += AG
        If BG > 0 Then PT += BG Else NT += BG
        If CG > 0 Then PT += CG Else NT += CG
        txtPositiveTotal.Text = FormatCurrency(PT)
        txtNegativeTotal.Text = FormatCurrency(NT)
        'Calculates the total, saves in global variable, and then formats as currency
        SETotal = PT + NT
        txtGrandTotal.Text = FormatCurrency(SETotal)
    End Sub

End Class