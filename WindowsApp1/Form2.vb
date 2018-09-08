Public Class Form2
    'Обработка события нажатия на кнопку Сохранить
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        My.Settings.pt = Val(NumericUpDown1.Text)
        My.Settings.st = Val(NumericUpDown2.Text)
        My.Settings.lt = Val(NumericUpDown3.Text)
        My.Settings.sn = CheckBox1.Checked
        My.Settings.ss = CheckBox2.Checked
        My.Settings.hw = CheckBox3.Checked
        My.Settings.rn = ComboBox1.Text
        Me.Close()
        If (Form1.statusFormView) Then
            Form1.Show()
            'Form1.statusFormView = True
        End If
    End Sub

    'Действия при загрузки окна настроек
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Text = My.Settings.pt
        NumericUpDown2.Text = My.Settings.st
        NumericUpDown3.Text = My.Settings.lt
        ComboBox1.Text = My.Settings.rn
        If (My.Settings.sn) Then
            CheckBox1.Checked = True
        End If
        If (My.Settings.ss) Then
            CheckBox2.Checked = True
        End If
        If (My.Settings.hw) Then
            CheckBox3.Checked = True
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
        If (Form1.statusFormView) Then
            Form1.Show()
            'Form1.statusFormView = True
        End If
    End Sub

    'Обработка события нажатия на кнопку Сохранить и Сбросить таймер
    Private Sub ButtonSaveReset_Click(sender As Object, e As EventArgs) Handles ButtonSaveReset.Click
        My.Settings.pt = Val(NumericUpDown1.Text)
        My.Settings.st = Val(NumericUpDown2.Text)
        My.Settings.lt = Val(NumericUpDown3.Text)
        My.Settings.sn = CheckBox1.Checked
        My.Settings.ss = CheckBox2.Checked
        My.Settings.hw = CheckBox3.Checked
        My.Settings.rn = ComboBox1.Text
        Me.Close()
        Form1.Reset()
        If (Form1.statusFormView) Then
            Form1.Show()
            'Form1.statusFormView = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.rn = ComboBox1.Text
        'Label4.Text = My.Settings.rn
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()
    End Sub
End Class