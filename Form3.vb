Public Class Form3
    Public Cond As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Deluxe" And ComboBox2.Text = "Restraunt Access" Then
            Cond = 1
        ElseIf ComboBox1.Text = "Super Deluxe" And ComboBox2.Text = "Restraunt Access" Then
            Cond = 2
        ElseIf ComboBox1.Text = "Deluxe" And ComboBox2.Text = "Pool Access" Then
            Cond = 3
        Else
            Cond = 4
        End If
        MsgBox("Checkin Sucessful")
        Me.Hide()
        Form2.Show()

    End Sub

End Class