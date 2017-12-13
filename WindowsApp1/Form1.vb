Public Class Form1

    Public pomoTime As Single
    Public shortPause As Single
    Public longPause As Single
    Public statusShow As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        NotifyIcon1.BalloonTipText = "Time is start"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim minuts, seconds As Integer
        Dim nullSec As String
        pomoTime = pomoTime - 1
        minuts = Int(pomoTime / 60)
        seconds = pomoTime Mod 60
        nullSec = If(pomoTime Mod 60 >= 10, "", "0")

        Label1.Text = minuts & ":" & nullSec & seconds
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        ' Me.Visible = False
        pomoTime = My.Settings.tp * 60
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
End Class
