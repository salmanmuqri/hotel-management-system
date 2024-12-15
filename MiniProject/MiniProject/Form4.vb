Public Class Form4
    Private Sub ButtonCheckID_Click(sender As Object, e As EventArgs) Handles ButtonCheckID.Click
        Dim inputID As String = TextBoxID.Text
        Dim charge As Decimal = 0
        Dim days As Integer

        ' Validate days input
        If Not Integer.TryParse(TextBoxDays.Text, days) Or days <= 0 Then
            MsgBox("Please enter a valid number of days.")
            Return
        End If

        ' Loop through the Rooms array to find the ID
        For i As Integer = 0 To Form3.Ro - 1
            If Form3.Rooms(i).ID = inputID Then
                charge = CalculateCharge(Form3.Rooms(i).Condition) * days
                LabelCharge.Text = $"Total Charge for ID {inputID}: {charge:C}"
                Return
            End If
        Next

        MsgBox("ID not found.")
    End Sub

    Private Function CalculateCharge(condition As Integer) As Decimal
        Select Case condition
            Case 1 ' Deluxe room with Restaurant Access
                Return 100
            Case 2 ' Deluxe room with Pool Access
                Return 120
            Case 3 ' Deluxe room with All Access
                Return 150
            Case 4 ' Super Deluxe room with Restaurant Access
                Return 200
            Case 5 ' Super Deluxe room with Pool Access
                Return 220
            Case 6 ' Super Deluxe room with All Access
                Return 250
            Case Else
                Return 0 ' Invalid condition
        End Select
    End Function

    Private Sub ButtonPay_Click(sender As Object, e As EventArgs) Handles ButtonPay.Click
        Dim inputID = TextBoxID.Text

        ' Loop through the Rooms array to find the ID
        For i = 0 To Form3.Ro - 1
            If Form3.Rooms(i).ID = inputID Then
                ' Clear the room details and decrement counts
                Form3.Rooms(i) = New RoomInfo ' Clear room details
                Form3.Ro -= 1 ' Decrease occupied room count
                Form3.Ra += 1 ' Increase available room count

                MsgBox($"Thanks for staying with us! Room with ID {inputID} has been checked out.")

                ' Clear input fields
                TextBoxID.Clear()
                TextBoxDays.Clear()
                LabelCharge.Text = String.Empty
                Return
            End If
        Next

        MsgBox("ID not found for checkout.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide() ' Hide the current form
        Form2.Show() ' Show the main form
    End Sub
End Class
