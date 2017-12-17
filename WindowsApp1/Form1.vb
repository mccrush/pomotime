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
        Dim minuts, seconds, tecTime As Integer
        Dim nullSec As String

        Label6.Text = "pomoTime = " & pomoTime
        Label8.Text = "shortBreakTime = " & shortBreakTime
        Label9.Text = "longBreakTime = " & longBreakTime
        Label10.Text = "typeTime = " & typeTime

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

        If (tecTime < 1) Then
            Me.Show()
            statusFormView = True


            pomoTime = My.Settings.pt * 60
            shortBreakTime = My.Settings.st * 60
            longBreakTime = My.Settings.lt * 60




            If (typeTime = 1) Then
                Timer1.Stop()
                Button2.Hide()
                Label2.Hide()
                Label3.Hide()

                Label4.Show()
                Button3.Show()
                Button4.Show()
            Else
                Timer1.Stop()
                Button2.Hide()
                Label3.Hide()
                Label5.Hide()

                Label1.Show()
                Button1.Text = "Start pomo time"
                Button1.Show()
            End If

        Else
            minuts = Int(tecTime / 60) + 1
            seconds = tecTime Mod 60
            nullSec = If(tecTime Mod 60 >= 10, "", "0")
            Label7.Text = minuts & ":" & nullSec & seconds
            Label3.Text = minuts & " m"
        End If
    End Sub


    'События по нажатию на каждую из кнопок
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        statusFormView = False

        typeTime = 1
        Timer1.Start()
        Button1.Hide()
        Label1.Hide()

        Button2.Text = "Pause pomo time"
        Button2.Show()
        Label2.Show()
        Label3.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Button2.Hide()
        Select Case (typeTime)
            Case 1
                Button1.Text = "Continue pomo time"
                Button1.Show()
            Case 2
                Button3.Text = "Continue short break"
                Button3.Show()
            Case 3
                Button4.Text = "Continue long break"
                Button4.Show()
            Case Else
                Button1.Text = "Continue pomo time"
                Button1.Show()
        End Select
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        statusFormView = False

        typeTime = 2
        Timer1.Start()
        Button3.Hide()
        Button4.Hide()
        Label4.Hide()

        Button2.Text = "Pause short break"
        Button2.Show()
        Label5.Show()
        Label3.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        statusFormView = False

        typeTime = 3
        Timer1.Start()
        Button3.Hide()
        Button4.Hide()
        Label4.Hide()

        Button2.Text = "Pause long break"
        Button2.Show()
        Label5.Show()
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
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
