Public Class frmTest
    Public Function IsInput() As Boolean
        Dim Controls = From c In Me.Controls Order By c.TabIndex
        For Each c In Controls
            If c.AccessibleRole = Windows.Forms.AccessibleRole.Text Then
                If Len(Trim(c.Text)) <= 0 Then
                    MsgBox(c.AccessibleName & " is missing required info.", MsgBoxStyle.Information, "Error")
                    Return False
                End If
            End If
            If c.AccessibleName Like "State" Then
                If Not c.Text Like "[A-Z][A-Z]" Then
                    MsgBox(c.AccessibleName & " is not valid.", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
            ElseIf c.AccessibleName Like "Zip Code" Then
                If Not c.Text Like "#####" Then
                    MsgBox(c.AccessibleName & " is not valid.", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        IsInput()
    End Sub
End Class