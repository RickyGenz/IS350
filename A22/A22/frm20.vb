Public Class frm20
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sr As IO.StreamReader = IO.File.OpenText("Cowboy.txt")
        Dim sw As IO.StreamWriter = IO.File.CreateText("Cowboy2.txt")
        Do While sr.Peek <> -1
            Dim Data() As String = sr.ReadLine.Split(",")
            Data(1) = CDec(Data(1)) * 0.8
            sw.WriteLine(Join(Data, ","))
        Loop
        sw.Close()
    End Sub
End Class