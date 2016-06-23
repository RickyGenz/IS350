Public Class frmGuessRight
    Sub IsInput(ByRef Result As Boolean)
        Dim Controls = From c In Me.Controls Order By c.TabIndex
        For Each c In Controls
            If c.AccessibleRole = Windows.Forms.AccessibleRole.Text Then
                If Len(Trim(c.Text)) <= 0 Then
                    MsgBox(c.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                    c.Focus()
                    Result = False
                    Exit Sub
                End If
            End If
            If c.AccessibleName Like "Zip Code" Then
                If Not c.Text Like "#####" Then
                    MsgBox(c.AccessibleName & " is not valid.", MsgBoxStyle.Critical, "Error")
                    c.Focus()
                    Result = False
                    Exit Sub
                End If
            ElseIf c.AccessibleName Like "Phone Number" Then
                If Not c.Text Like "(###) ###-####" Then
                    MsgBox(c.AccessibleName & " is not valid.", MsgBoxStyle.Critical, "Error")
                    c.Focus()
                    Result = False
                    Exit Sub
                End If
            End If
        Next
        Result = True
    End Sub
    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Dim A As Boolean
        Call IsInput(A)
        If A = True Then txtValid.Text = "All inputs are valid."
        If A = False Then txtValid.Text = "The currently selected input is invalid."
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub
End Class