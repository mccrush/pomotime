Public Class Form2
    'Обработка события нажатия на кнопку Сохранить и выйти
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        My.Settings.pt = Val(NumericUpDown1.Text)
        My.Settings.st = Val(NumericUpDown2.Text)
        My.Settings.lt = Val(NumericUpDown3.Text)
        My.Settings.sn = CheckBox1.Checked
        My.Settings.ss = CheckBox2.Checked
        My.Settings.hw = CheckBox3.Checked
        Me.Close()
        Form1.Show()
    End Sub

    'Действия при загрузки окна настроек
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Text = My.Settings.pt
        NumericUpDown2.Text = My.Settings.st
        NumericUpDown3.Text = My.Settings.lt
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
    End Sub

    Private Sub ButtonSaveReset_Click(sender As Object, e As EventArgs) Handles ButtonSaveReset.Click
        My.Settings.pt = Val(NumericUpDown1.Text)
        My.Settings.st = Val(NumericUpDown2.Text)
        My.Settings.lt = Val(NumericUpDown3.Text)
        My.Settings.sn = CheckBox1.Checked
        My.Settings.ss = CheckBox2.Checked
        My.Settings.hw = CheckBox3.Checked
        Me.Close()
        Form1.Reset()
        Form1.Show()
    End Sub
End Class