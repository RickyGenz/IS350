Public Class frmCC

    Dim Month As Integer

    Public Function IsInputInvalid() As Boolean
        'Tests if any input is invalid
        Dim Controls = From c In Me.Controls Order By c.TabIndex
        For Each c In Controls
            If c.AccessibleDescription = "Required" Then
                If IsBlank(c) Then
                    MsgBox(c.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                    c.Focus()
                    Return True
                End If
            End If
            If c.Name = "txtNumber" Then
                If Not c.Text Like "####-####-####-####" Then
                    MsgBox(c.AccessibleName & " is not valid. Must be in ####-####-####-#### format.", MsgBoxStyle.Critical, "Error")
                    Return True
                End If
            ElseIf c.Name = "txtDate" Then
                If Not c.Text Like "##/##" Then
                    MsgBox(c.AccessibleName & " is not valid. Must be in ##/## format.", MsgBoxStyle.Critical, "Error")
                    Return True
                Else
                    Dim Index As Integer = c.Text.ToString.IndexOf("/")
                    Month = c.Text.ToString.Substring(0, Index)
                    If Month < 1 Or Month > 12 Then
                        MsgBox(c.AccessibleName & " is not valid. Must be between 01 and 12.", MsgBoxStyle.Critical, "Error")
                        Return True
                    End If
                End If
            End If
        Next
        Return False
    End Function

    Private Sub UtilityButtons(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the window
        If sender Is btnExit Then Close()
    End Sub

    Private Sub OK(sender As Object, e As EventArgs) Handles btnOk.Click
        'Runs invalid input test
        If IsInputInvalid() Then Exit Sub
        'Determine if credit card information is invalid
        Dim J, CheckNum As Integer
        Dim NextChar As String
        For J = 0 To txtNumber.Text.Length - 1
            NextChar = txtNumber.Text.Substring(J, 1)
            If NextChar Like "#" Then CheckNum = CheckNum + NextChar
        Next
        CheckNum = CheckNum.ToString.Substring(CheckNum.ToString.Length - 1, 1)
        Select Case Month
            Case 10 : Month = 1
            Case 11 : Month = 2
            Case 12 : Month = 3
        End Select
        If CheckNum <> Month Then MsgBox("The month code of " & Month & " does not match the check digit of " & CheckNum & ".", MsgBoxStyle.Critical, "Error") Else Close()
    End Sub

End Class