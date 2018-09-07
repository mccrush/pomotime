Public Class FormAbout
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        If (Form1.statusFormView) Then
            Form1.Show()
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
        If (Form1.statusFormView) Then
            Form1.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://mccrush.ru")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://mccrush.ru/app/pomotime/")
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        ButtonPayPal.Text = "PayPal $" & TrackBar1.Value
        ButtonYandex.Text = "Yandex " & TrackBar1.Value * 70 & "p"
    End Sub

    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButtonPayPal.BackColor = Color.FromArgb(31, 155, 222)
        ButtonYandex.BackColor = Color.FromArgb(255, 219, 77)
    End Sub
End Class