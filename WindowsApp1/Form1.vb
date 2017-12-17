Public Class Form1

    Public pomoTime As Integer = My.Settings.pt * 60
    Public shortBreakTime As Integer = My.Settings.st * 60
    Public longBreakTime As Integer = My.Settings.lt * 60
    Public statusFormView As Boolean = True
    Public typeTime As Int32 = 1

    'Загрузка формы
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Show()
        Label1.Show()
    End Sub

    'Таймер в ктором происходит самое главное
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

    'События по нажатию на каждую из кнопок
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        typeTime = 1
        Label2.Show()
        Label3.Show()
        Button2.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (typeTime = 1) Then
            Timer1.Stop()
            Button1.Show()
        Else
            Button3.Show()
            Button4.Show()
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    'Работа со второй формой и контекстным меню
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If (e.Button = MouseButtons.Left) Then
            If (statusFormView) Then
                Me.Hide()
                statusFormView = False
            Else
                Me.Show()
                statusFormView = True
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class
