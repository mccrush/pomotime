Public Class Form1

    Public pomoTime As Single
    Public shortPause As Single
    Public longPause As Single
    Public statusShow As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Hide()
        Button2.Show()
        NotifyIcon1.BalloonTipTitle = "Title message"
        NotifyIcon1.BalloonTipText = "Time is start"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button2.Hide()
        Button1.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim minuts, seconds As Integer
        Dim nullSec As String
        pomoTime = pomoTime - 1
        If (pomoTime > 1) Then
            minuts = Int(pomoTime / 60)
            seconds = pomoTime Mod 60
            nullSec = If(pomoTime Mod 60 >= 10, "", "0")

            Label1.Text = minuts & ":" & nullSec & seconds
        Else
            Timer1.Stop()
            Label1.Hide()
            Label2.show()
            Button1.Hide()
            Button2.Hide()
            Button3.Show()
            Button4.Show()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pomoTime = My.Settings.tp * 60
        Button2.Hide()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If (e.Button = MouseButtons.Left) Then
            If (statusShow) Then
                Me.Hide()
                statusShow = False
            Else
                Me.Show()
                statusShow = True
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub
End Class
