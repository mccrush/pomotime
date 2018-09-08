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
    Public statusSettingsView As Boolean = False
    Public showSeconds As Boolean = My.Settings.ss
    Public hideAfterStart As Boolean = My.Settings.hw
    Public countPomodoros As Integer = 0
    Public typeTime As Int32 = 1

    'Функция обновления значений параметров
    Public Function UpdateParameters()
        pomoTime = My.Settings.pt * 60
        shortBreakTime = My.Settings.st * 60
        longBreakTime = My.Settings.lt * 60
        showSeconds = My.Settings.ss
        hideAfterStart = My.Settings.hw
        Return True
    End Function


    'Функция получения текущего значения времени
    Private Function GetTecTime()
        Dim tecTime As Integer

        Select Case (typeTime)
            Case 1
                pomoTime = pomoTime - 1
                'pomoTime = pomoTime
                tecTime = pomoTime
            Case 2
                shortBreakTime = shortBreakTime - 1
                tecTime = shortBreakTime
            Case 3
                longBreakTime = longBreakTime - 1
                tecTime = longBreakTime
            Case Else
                pomoTime = pomoTime - 1
                'pomoTime = pomoTime
                tecTime = pomoTime
        End Select

        Return tecTime
    End Function

    'Функция отображения текущего значения времени на форме
    Public Function ShowTime(tecTime As Integer)
        'Dim tecTime As Integer = GetTecTime() 'pomoTime
        Dim minuts, seconds As Integer
        Dim nullSec As String
        'ListBox1.Items.Add("2. ShowTime is start")
        minuts = Int(tecTime / 60)
        seconds = tecTime Mod 60
        nullSec = If(tecTime Mod 60 >= 10, "", "0")
        If (showSeconds) Then
            LabelTime.Text = minuts & ":" & nullSec & seconds
            'ListBox1.Items.Add("3. time: " & minuts & ":" & nullSec & seconds)
        Else
            LabelTime.Text = minuts
        End If
        Return True
    End Function

    'Загрузка формы при запуске программы
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackgroundImage = My.Resources.bg_red
        'Me.BackColor = Color.Red
        Me.BackColor = Color.FromArgb(255, 189, 33, 48)
        ButtonStart.Text = "Start timer"
        ButtonStart.Show()
        'ListBox1.Items.Add("1. typeTime:" & typeTime)
        ShowTime(pomoTime)
    End Sub


    'Таймер в ктором происходит самое главное каждую секунду
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tecTime As Integer = GetTecTime()

        If (tecTime < 1) Then
            ' Это что-то на подобии сброса значений...
            'pomoTime = My.Settings.pt * 60
            'shortBreakTime = My.Settings.st * 60
            'longBreakTime = My.Settings.lt * 60

            UpdateParameters()

            If (My.Settings.sn) Then
                Select Case (My.Settings.rn)
                    Case "Ring_1"
                        My.Computer.Audio.Play(My.Resources.Ring_1, AudioPlayMode.BackgroundLoop)
                    Case "Ring_2"
                        My.Computer.Audio.Play(My.Resources.Ring_2, AudioPlayMode.BackgroundLoop)
                    Case "Ring_3"
                        My.Computer.Audio.Play(My.Resources.Ring_3, AudioPlayMode.BackgroundLoop)
                    Case "Ring_4"
                        My.Computer.Audio.Play(My.Resources.Ring_4, AudioPlayMode.BackgroundLoop)
                    Case "Ring_5"
                        My.Computer.Audio.Play(My.Resources.Ring_5, AudioPlayMode.BackgroundLoop)
                End Select

            End If

            Timer1.Stop()
            ButtonPause.Hide()
            'LabelTime.Hide()

            ButtonShortBreak.Width = 76
            ButtonShortBreak.Location = New Point(8, 76)
            ButtonShortBreak.Text = "Short break"


            ButtonLongBreak.Width = 76
            ButtonLongBreak.Location = New Point(92, 76)
            ButtonLongBreak.Text = "Long break"


            If (typeTime = 1) Then
                countPomodoros += 1
                'Me.BackgroundImage = My.Resources.bg_green
                Me.BackColor = Color.FromArgb(255, 30, 126, 52)

                If (countPomodoros Mod My.Settings.pl = 0) Then
                    ButtonLongBreak.ForeColor = Color.FromArgb(255, 30, 126, 52)
                    ButtonShortBreak.ForeColor = Color.FromArgb(255, 0, 0, 0)
                Else
                    ButtonLongBreak.ForeColor = Color.FromArgb(255, 0, 0, 0)
                    ButtonShortBreak.ForeColor = Color.FromArgb(255, 30, 126, 52)
                End If

                ButtonShortBreak.Show()
                ButtonLongBreak.Show()

                LabelTime.Text = "Break!"
            Else
                'Me.BackgroundImage = My.Resources.bg_red
                Me.BackColor = Color.FromArgb(255, 189, 33, 48)

                'LabelTime.Text = "Pomodoro time!"

                ShowTime(My.Settings.pt * 60) 'Отобразить время помидора или перерыва
                ButtonStart.Text = "Start timer"
                ButtonStart.Show()
            End If


            Me.Show()
            statusFormView = True

        Else
            ShowTime(tecTime)
        End If
    End Sub


    'Обработка события по нажатию на кнопку Start timer
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If (hideAfterStart) Then
            Me.Hide()
            statusFormView = False
        End If

        My.Computer.Audio.Stop()

        typeTime = 1
        Timer1.Start()
        ButtonStart.Hide()

        ButtonPause.Text = "Pause timer"
        ButtonPause.Show()

        'LabelTime.Show()
    End Sub


    'Обработка события нажатия на кнопку Pause
    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click
        Timer1.Stop()
        ButtonPause.Hide()
        Select Case (typeTime)
            Case 1
                ButtonStart.Text = "Continue timer"
                ' Красный
                Me.BackColor = Color.FromArgb(255, 189, 33, 48)
                ButtonStart.Show()
            Case 2
                ButtonShortBreak.Width = 160
                ButtonShortBreak.Text = "Continue break"
                ButtonShortBreak.Show()
            Case 3
                ButtonLongBreak.Width = 160
                ButtonLongBreak.Location = New Point(8, 76)
                ButtonLongBreak.Text = "Continue break"
                ButtonLongBreak.Show()
            Case Else
                ButtonStart.Text = "Continue timer"
                Me.BackColor = Color.FromArgb(255, 189, 33, 48)
                ButtonStart.Show()
        End Select
    End Sub

    'Обработка события нажатия на кнопку Короткий перерыв
    Private Sub ButtonShortBreak_Click(sender As Object, e As EventArgs) Handles ButtonShortBreak.Click
        If (hideAfterStart) Then
            Me.Hide()
            statusFormView = False
        End If

        My.Computer.Audio.Stop()

        'shortBreakTime = My.Settings.st * 60
        typeTime = 2
        Timer1.Start()
        ButtonShortBreak.Hide()
        ButtonLongBreak.Hide()

        ButtonPause.Text = "Pause break"
        ButtonPause.Show()

        'LabelTime.Show()
    End Sub

    'Обработка события нажатия на кнопку Длинный перерыв
    Private Sub ButtonLongBreak_Click(sender As Object, e As EventArgs) Handles ButtonLongBreak.Click
        If (hideAfterStart) Then
            Me.Hide()
            statusFormView = False
        End If

        My.Computer.Audio.Stop()

        typeTime = 3
        Timer1.Start()
        ButtonShortBreak.Hide()
        ButtonLongBreak.Hide()

        ButtonPause.Text = "Pause break"
        ButtonPause.Show()

        'LabelTime.Show()
    End Sub


    'При клике по иконеке в трее левой кнопкой мыши
    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If (e.Button = MouseButtons.Left) Then
            If (statusFormView) Then
                Me.Hide()
                statusFormView = False
            Else
                Me.Show()
                statusFormView = True
                FormAbout.Hide()
            End If
        End If
    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Hide()
        'statusFormView = False
        Form2.Show()
        statusSettingsView = True
        FormAbout.Hide()
        'Me.Hide()
        'statusFormView = False
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        Form2.Hide()
        statusSettingsView = False
        FormAbout.Show()
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

    Public Function Reset()
        My.Computer.Audio.Stop()
        Timer1.Stop()
        UpdateParameters()
        ShowTime(pomoTime)
        ButtonPause.Hide()
        ButtonStart.Text = "Start timer"
        ButtonStart.Show()
        ButtonShortBreak.Width = 76
        ButtonLongBreak.Width = 76
        ButtonShortBreak.Hide()
        ButtonLongBreak.Hide()
        Me.BackColor = Color.FromArgb(255, 189, 33, 48)
        Return True
    End Function

    Public Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Reset()
    End Sub
End Class
