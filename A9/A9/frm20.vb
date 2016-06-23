Public Class frm20
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        lstOutputOld.Items.Clear()
        lstOutputNew.Items.Clear()
        Dim a As Integer
        a = CInt(InputBox("Please provide an input value.", "Input Box"))
        'Old Test Method
        If a = 1 Then
            lstOutputOld.Items.Add("lambs")
        End If
        If ((a <= 3) And (a < 4)) Then
            lstOutputOld.Items.Add("eat")
        End If
        If ((a = 5) Or (a > 7)) Then
            lstOutputOld.Items.Add("ivy")
        End If
        'New Test Method
        Select Case a
            Case 1
                lstOutputNew.Items.Add("lambs")
                lstOutputNew.Items.Add("eat")
            Case Is <= 3, Is < 4
                lstOutputNew.Items.Add("eat")
            Case 5, Is > 7
                lstOutputNew.Items.Add("ivy")
        End Select
    End Sub
End Class