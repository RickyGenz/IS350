Public Class frm22
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInputOld.Click
        txtOutputOld.Clear()
        Dim a As Integer
        a = CInt(InputBox("Please provide an input value.", "Input Box"))
        If a = 3 Then
            a = 1
        End If
        If a = 2 Then
            a = 3
        End If
        If a = 1 Then
            a = 2
        End If
        txtOutputOld.Text = a
    End Sub
    Private Sub btnInputNew_Click(sender As Object, e As EventArgs) Handles btnInputNew.Click
        txtOutputNew.Clear()
        Dim a As Integer
        a = CInt(InputBox("Please provide an input value.", "Input Box"))
        Select Case a
            Case 1, 3
                a = 2
            Case 2
                a = 3
        End Select
        txtOutputNew.Text = a
    End Sub
End Class