Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Admin" And TextBox2.Text = "Shaggy" Then
            MsgBox("Login Sucessful")
            Me.Hide()
            Form2.Show()
            TextBox1.Clear()
            TextBox2.Clear()

        Else
            MsgBox("Incorrect Details")
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
