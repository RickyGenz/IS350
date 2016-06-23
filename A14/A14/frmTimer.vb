Public Class frmTimer

    Dim Minutes, Seconds As Integer

    Sub SyncTime(ByVal Minutes, ByVal Seconds)
        txtMinutes.Text = Minutes
        txtSeconds.Text = Seconds
    End Sub

    Private Sub frmTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SyncTime(Minutes, Seconds)
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If Seconds <= 0 And Minutes <= 0 Then End
        If Seconds <= 0 And Minutes > 0 Then Minutes += -1 : Seconds = 60
        If Seconds > 60 Then Minutes += Int(Seconds / 60) : Seconds = Seconds - (60 * Int(Seconds / 60))
        Seconds += -1
        SyncTime(Minutes, Seconds)
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Timer.Enabled = False
        Minutes = 0 : Seconds = 0
        SyncTime(Minutes, Seconds)
    End Sub

    Private Sub btnAddMinute_Click(sender As Object, e As EventArgs) Handles btnAddMinute.Click
        If txtMinutes.Text = "" Then Minutes = 1 Else Minutes += 1
        SyncTime(Minutes, Seconds)
    End Sub

    Private Sub btnAddSecond_Click(sender As Object, e As EventArgs) Handles btnAddSecond.Click
        If txtSeconds.Text = "" Then Seconds = 1 Else Seconds += 1
        If Seconds > 59 Then Minutes += 1 : Seconds = 0
        SyncTime(Minutes, Seconds)
    End Sub

    Private Sub txtMinutes_txtSeconds_Enter(sender As Object, e As EventArgs) Handles txtMinutes.Enter, txtSeconds.Enter
        Timer.Enabled = False
    End Sub

    Private Sub txtMinutes_txtSeconds_Leave(sender As Object, e As EventArgs) Handles txtMinutes.Leave, txtSeconds.Leave
        If txtMinutes.Text = "" Then Minutes = 0 Else Minutes = txtMinutes.Text
        If txtSeconds.Text = "" Then Seconds = 0 Else Seconds = txtSeconds.Text
        SyncTime(Minutes, Seconds)
        Timer.Enabled = True
    End Sub

End Class