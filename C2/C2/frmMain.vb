Public Class frmMain

    Public Function IsInputInvalid() As Boolean
        'Tests if any input is invalid
        Dim Controls = From c In Me.Controls Order By c.TabIndex
        For Each c In Controls
            If c.AccessibleDescription = "Required" Then
                If Len(Trim(c.Text)) <= 0 Then
                    MsgBox(c.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                    c.Focus()
                    Return True
                End If
            End If
            If c.Name = "txtYSSN" Then
                Dim b As Boolean
                Call IsInvalidSSN(c, b)
                If b Then Return True
            ElseIf c.Name = "txtSName" Then
                Dim b As Boolean
                If IsBlank(c) = False Then Call IsInvalidSSN(txtSSSN, b)
                If b Then Return True
            ElseIf c.Name = "txtZip" Then
                If Not c.Text Like "#####" Then
                    MsgBox(c.AccessibleName & " is not valid. Must be in ##### format.", MsgBoxStyle.Critical, "Error")
                    c.Focus()
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub UtilityButtons(sender As Object, e As EventArgs) Handles btnAbout.Click, btnExit.Click
        'Opens the about form
        If sender Is btnAbout Then frmAbout.ShowDialog()
        'Ends execution
        If sender Is btnExit Then End
    End Sub

    Private Sub FormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        Title = lblTitle.Text
        Slogan = lblSlogan.Text
    End Sub

    Private Sub OpenForms(sender As Object, e As EventArgs) Handles btnIncome.Click, btnF1040.Click, btnSA.Click, btnSB.Click, btnSC.Click, btnSD.Click, btnSE.Click
        'Runs invalid input test
        If IsInputInvalid() Then Exit Sub
        'Stores name and filling status in global variables
        YName = txtYName.Text
        If rdoSingle.Checked Then FSNum = 1 : FSString = "Single"
        If rdoJointly.Checked Then FSNum = 2 : FSString = "Married Filling Jointly"
        If rdoSeperately.Checked Then FSNum = 1 : FSString = "Married Filling Seperately"
        If rdoHoH.Checked Then FSNum = 3 : FSString = "Head of Household"
        If rdoWidow.Checked Then FSNum = 3 : FSString = "Widower with Dependent Child"
        'Opens each additional form depending on which button is clicked
        If sender Is btnIncome Then frmIncome.ShowDialog()
        If sender Is btnF1040 Then frm1040.ShowDialog()
        If sender Is btnSA Then frmSA.ShowDialog()
        If sender Is btnSB Then frmSB.ShowDialog()
        If sender Is btnSC Then frmSC.ShowDialog()
        If sender Is btnSD Then frmSD.ShowDialog()
        If sender Is btnSE Then frmSE.ShowDialog()
    End Sub

End Class