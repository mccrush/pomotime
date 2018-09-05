﻿Public Class Form2
    'Обработка события нажатия на кнопку Сохранить и выйти
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.pt = Val(TextBox1.Text)
        My.Settings.st = Val(TextBox2.Text)
        My.Settings.lt = Val(TextBox3.Text)
        My.Settings.sn = CheckBox1.Checked
        Me.Close()
    End Sub

    'Обработка события нажатия на кнопку Выйти
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    'Действия при загрузки окна настроек
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.pt
        TextBox2.Text = My.Settings.st
        TextBox3.Text = My.Settings.lt
        If (My.Settings.sn) Then
            CheckBox1.Checked = True
        End If

    End Sub
End Class