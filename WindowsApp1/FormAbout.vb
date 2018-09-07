Public Class FormAbout

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
        'If (Form1.statusFormView) Then
        'Form1.Show()
        'End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://mccrush.ru")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://mccrush.ru/app/pomotime/")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ButtonPayPal.Text = "PayPal $" & TrackBar1.Value
        If (TrackBar1.Value * 70 < 100) Then
            ButtonYandex.Text = "Yandex " & TrackBar1.Value * 70 & " "
        Else
            ButtonYandex.Text = "Yandex " & TrackBar1.Value * 70
        End If
    End Sub

    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonPayPal.BackColor = Color.FromArgb(31, 155, 222)
        ButtonYandex.BackColor = Color.FromArgb(255, 219, 77)
        ButtonYandex.Text = "Yandex " & TrackBar1.Value * 70 & " "
    End Sub

    Private Sub ButtonYandex_Click(sender As Object, e As EventArgs) Handles ButtonYandex.Click
        Process.Start("https://money.yandex.ru/to/410011471476350/" & TrackBar1.Value * 70)
    End Sub

    Private Sub ButtonPayPal_Click(sender As Object, e As EventArgs) Handles ButtonPayPal.Click
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=mccrush@mail.ru&item_name=Development+PomoTime&item_number=mccrush%2Eru&amount=" & TrackBar1.Value & "%2e00&currency_code=USD")
    End Sub
End Class