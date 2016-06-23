Public Class frm20
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim Index As Integer = lstBox.Items.Count - 1
        Dim words(Index) As String
        lstBox.Sorted = True
        For I As Integer = 0 To Index
            words(I) = lstBox.Items(I)
        Next
        lstBox.Items.Clear()
        lstBox.Sorted = False
        For I As Integer = Index To 0 Step -1
            lstBox.Items.Add(words(I))
        Next
    End Sub
End Class