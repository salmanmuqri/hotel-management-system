Public Class Form2
    Public Ra As Integer
    Public Ro As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Ro < 10 Then
            Me.Hide()
            Form3.Show()

            Label2.Text = Ra.ToString()
            Label4.Text = Ro.ToString()

            ' Check if Ro reaches 10 and disable the button
            If Ro = 10 Then
                Button1.Enabled = False
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Ra < 10 Then
            Ro -= 1
            Ra += 1
            Label2.Text = Ra.ToString()
            Label4.Text = Ro.ToString()
            Me.Hide()
            Form4.Show()

            ' Check if Ra reaches 10 and disable the button
            If Ra = 10 Then
                Button2.Enabled = False
            End If
        End If
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