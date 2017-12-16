Public Class Form1

    Public pomoTime As Single
    Public breakTime As Single
    Public longPause As Single
    Public statusShow As Boolean = True
    Public tipeTime As Int32

    'Загрузка формы
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pomoTime = My.Settings.pt * 60
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        tipeTime = 1

        Label1.Show()
        Label2.Show()
        Button2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (tipeTime = 1) Then
            Timer1.Stop()

            Button1.Show()
        Else
            Timer2.Stop()

            Button3.Show()
            Button4.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim minuts, seconds As Integer
        Dim nullSec As String
        pomoTime = pomoTime - 1
        Label7.Text = pomoTime
        If (Int(pomoTime) < 1) Then
            Label7.Text = "Yes, minimal!"
            Timer1.Stop()

            Label5.Show()
            Button3.Show()
            Button4.Show()
        End If

        minuts = Int(pomoTime / 60)
        seconds = pomoTime Mod 60
        nullSec = If(pomoTime Mod 60 >= 10, "", "0")

        Label1.Text = minuts & ":" & nullSec & seconds & " m"
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim minuts, seconds As Integer
        Dim nullSec As String
        breakTime = breakTime - 1

        If (breakTime < 1) Then
            Timer2.Stop()

            Label6.Show()
            Button1.Show()
        End If

        minuts = Int(breakTime / 60)
        seconds = breakTime Mod 60
        nullSec = If(breakTime Mod 60 >= 10, "", "0")

        Label4.Text = minuts & ":" & nullSec & seconds & " m"
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        breakTime = My.Settings.st * 60
        Timer2.Start()
        tipeTime = 2

        Button2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button3.Click
        breakTime = My.Settings.lt * 60
        Timer2.Start()
        tipeTime = 2

        Button2.Show()
    End Sub

End Class
