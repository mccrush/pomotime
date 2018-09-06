' Цвета
' #dc3545 - красный основной фон
' #bd2130 - красный основной темный
' #721c24 - красный дополнительный темный
' #f5c6cb - красный дополнительный светлый
' #f8d7da - красный дополнительный самый светлый

' #28a745 - зеленый основной фон
' #1e7e34 - зеленый основной темный
'

' #f8f9fa - белый основной фон и текст
' #343a40 - черный основной текст
'
Public Class Form1

    Public pomoTime As Integer = My.Settings.pt * 60
    Public shortBreakTime As Integer = My.Settings.st * 60
    Public longBreakTime As Integer = My.Settings.lt * 60
    Public statusFormView As Boolean = True
    Public showSeconds As Boolean = My.Settings.ss
    Public typeTime As Int32 = 1

    'Функция обновления значений параметров
    Public Function UpdateParameters()
        pomoTime = My.Settings.pt * 60
        shortBreakTime = My.Settings.st * 60
        longBreakTime = My.Settings.lt * 60
        showSeconds = My.Settings.ss
        Return True
    End Function


    'Загрузка формы при запуске программы
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackgroundImage = My.Resources.bg_red
        'Me.BackColor = Color.Red
        Me.BackColor = Color.FromArgb(255, 189, 33, 48)
        Button1.Text = "Start pomo time"
        Button1.Show()

        Label1.Text = "Pomodoro time!"
        Label1.Show()
    End Sub

    'Функция отображения текущего значения времени на форме
    Public Function ShowTime()
        Dim tecTime As Integer = GetTecTime()
        Dim minuts, seconds As Integer
        Dim nullSec As String
        minuts = Int(tecTime / 60)
        seconds = tecTime Mod 60
        nullSec = If(tecTime Mod 60 >= 10, "", "0")
        If (showSeconds) Then
            Label3.Text = "    " & minuts & ":" & nullSec & seconds
        Else
            Label3.Text = "    " & minuts
        End If
        Return True
    End Function

    'Функция получения текущего значения времени
    Private Function GetTecTime()
        Dim tecTime As Integer

        Select Case (typeTime)
            Case 1
                pomoTime = pomoTime - 1
                tecTime = pomoTime
            Case 2
                shortBreakTime = shortBreakTime - 1
                tecTime = shortBreakTime
            Case 3
                longBreakTime = longBreakTime - 1
                tecTime = longBreakTime
            Case Else
                pomoTime = pomoTime - 1
                tecTime = pomoTime
        End Select

        Return tecTime
    End Function


    'Таймер в ктором происходит самое главное каждую секунду
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tecTime As Integer = GetTecTime()

        If (tecTime < 1) Then
            pomoTime = My.Settings.pt * 60
            shortBreakTime = My.Settings.st * 60
            longBreakTime = My.Settings.lt * 60

            If (My.Settings.sn) Then
                My.Computer.Audio.Play(My.Resources.elegant_ringtone, AudioPlayMode.BackgroundLoop)
            End If

            Timer1.Stop()
            Button2.Hide()
            Label3.Hide()

            If (typeTime = 1) Then
                'Me.BackgroundImage = My.Resources.bg_green
                Me.BackColor = Color.FromArgb(255, 30, 126, 52)


                Label1.Text = " Time to break!"
                Label1.Show()

                Button3.Height = 25
                Button3.Show()

                Button4.Height = 25
                Button4.Location = New Point(10, 80)
                Button4.Show()
            Else
                'Me.BackgroundImage = My.Resources.bg_red
                Me.BackColor = Color.FromArgb(255, 189, 33, 48)

                Label1.Text = "Pomodoro time!"
                Label1.Show()

                Button1.Text = "Start pomo time"
                Button1.Show()
            End If

            Me.Show()
            statusFormView = True

        Else
            ShowTime()
        End If
    End Sub


    'Обработка события по нажатию на кнопку Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        statusFormView = False

        My.Computer.Audio.Stop()

        'pomoTime = My.Settings.pt * 60
        typeTime = 1
        Timer1.Start()
        Button1.Hide()
        Label1.Hide()

        Button2.Text = "Pause pomo time"
        Button2.Show()

        Label3.Show()
    End Sub


    'Обработка события нажатия на кнопку Pause
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button2.Hide()
        Select Case (typeTime)
            Case 1
                Button1.Text = "Continue pomo time"
                ' Красный
                Me.BackColor = Color.FromArgb(255, 189, 33, 48)
                Button1.Show()
            Case 2
                Button3.Height = 50
                Button3.Text = "Continue short break"
                Button3.Show()
            Case 3
                Button4.Height = 50
                Button4.Location = New Point(10, 55)
                Button4.Text = "Continue long break"
                Button4.Show()
            Case Else
                Button1.Text = "Continue pomo time"
                Button1.Show()
        End Select
    End Sub

    'Обработка события нажатия на кнопку
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        statusFormView = False

        My.Computer.Audio.Stop()

        'shortBreakTime = My.Settings.st * 60
        typeTime = 2
        Timer1.Start()
        Button3.Hide()
        Button4.Hide()
        Label1.Hide()

        Button2.Text = "Pause short break"
        Button2.Show()

        Label3.Show()
    End Sub

    'Обработка события нажатия на кнопку
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        statusFormView = False

        My.Computer.Audio.Stop()

        'longBreakTime = My.Settings.lt * 60
        typeTime = 3
        Timer1.Start()
        Button3.Hide()
        Button4.Hide()
        Label1.Hide()

        Button2.Text = "Pause long break"
        Button2.Show()

        Label3.Show()
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
        Me.Hide()
        statusFormView = False
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        Me.Hide()
        statusFormView = False
    End Sub
End Class
