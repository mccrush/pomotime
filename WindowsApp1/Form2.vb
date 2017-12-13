Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.tp = Val(TextBox1.Text)
        My.Settings.sp = Val(TextBox2.Text)
        My.Settings.lp = Val(TextBox3.Text)
        My.Settings.sn = CheckBox1.Checked
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.tp
        TextBox2.Text = My.Settings.sp
        TextBox3.Text = My.Settings.lp
        If (My.Settings.sn) Then
            CheckBox1.Checked = True
        End If
    End Sub
End Class