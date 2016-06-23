Public Class frm24
    Structure Player
        Dim name As String
        Dim team As String
        Dim atBats As Integer
        Dim hits As Integer
    End Structure
    Dim players() As Player
    Private Sub frm24_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim stats() As String = IO.File.ReadAllLines("Baseball.txt")
        Dim n As Integer = stats.Count - 1
        ReDim players(n)
        Dim data(3) As String
        For i As Integer = 0 To n
            data = stats(i).Split(","c)
            players(i).name = data(0)
            players(i).team = data(1)
            players(i).atBats = CInt(data(2))
            players(i).hits = CInt(data(3))
        Next
    End Sub
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim query = From p In players
                    Order By p.team Ascending
                    Select p.team
                    Distinct
        lstOutput.DataSource = query.ToList
    End Sub
End Class