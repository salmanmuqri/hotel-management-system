Public Class Form2
    Public Ra As Integer
    Public Ro As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
        Ro = Ro + 1
        Ra = Ra - 1
        Label2.Text = Ra
        Label4.Text = Ro

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ro = Ro - 1
        Ra = Ra + 1
        Label2.Text = Ra
        Label4.Text = Ro
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Ra = 10
        Ro = 0

    End Sub
End Class