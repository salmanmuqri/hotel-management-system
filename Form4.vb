Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Thank you for staying with us")
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = (Date.Today)
        If Form3.Cond = 1 Then
            TextBox2.Text = ("5000")
        ElseIf Form3.Cond = 2 Then
            TextBox2.Text = ("7000")
        ElseIf Form3.Cond = 3 Then
            TextBox2.Text = ("7000")
        Else
            TextBox2.Text = ("10000")
        End If
    End Sub
End Class