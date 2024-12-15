Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Structure Room
    Public ID As String
    Public Condition As Integer
End Structure

Public Class Form3
    Private Const TotalRooms As Integer = 10
    Public Rooms(TotalRooms - 1) As RoomInfo
    Public Cond As Integer
    Public Ro As Integer = 0 ' Initialize occupied rooms count
    Public Ra As Integer = TotalRooms ' Total available rooms

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rooms(Form2.Ro) = New RoomInfo(TextBox2.Text, Cond) ' Store ID and condition
        Form2.Ro += 1 ' Increment occupied room count
        Form2.Ra -= 1 ' Decrement available room count
        ' Validate inputs
        If Not ValidateInput(TextBox1.Text, AddressOf IsAllLetters, "Dessert must contain only letters.") Then Return
        If Not ValidateInput(TextBox2.Text, Function(s) s.Length = 4 AndAlso IsAllDigits(s), "TextBox2 must contain exactly 4 digits.") Then Return
        If Not ValidateInput(TextBox3.Text, Function(s) s.Length = 10 AndAlso IsAllDigits(s), "TextBox5 must contain exactly 10 digits.") Then Return

        ' Validate ComboBoxes
        If String.IsNullOrEmpty(ComboBox1.Text) Or String.IsNullOrEmpty(ComboBox2.Text) Then
            MsgBox("Please select an option from both ComboBoxes.")
            Return
        End If

        ' Set Cond based on selections
        SetConditionBasedOnSelections()

        ' Store the ID and condition in the room array if there's an available room
        If Form2.Ro < 10 Then ' Check if there's an available room
            Rooms(Form2.Ro) = New RoomInfo() ' Instantiate the RoomInfo object
            Rooms(Form2.Ro).ID = TextBox2.Text ' Set the ID
            Rooms(Form2.Ro).Condition = Cond ' Set the condition

            Form2.Ro += 1 ' Increment occupied room count
            Form2.Ra -= 1 ' Decrement available room count
            MsgBox("Check-in Successful")
        Else
            MsgBox("No rooms available.")
        End If

        Me.Hide()
        Form2.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.ResetText()
        ComboBox2.ResetText()
    End Sub

    ' Helper methods for validation
    Private Function IsAllLetters(str As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(str) AndAlso str.All(AddressOf Char.IsLetter)
    End Function

    Private Function IsAllDigits(str As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(str) AndAlso str.All(AddressOf Char.IsDigit)
    End Function

    Private Function ValidateInput(input As String, validator As Func(Of String, Boolean), errorMessage As String) As Boolean
        If Not validator(input) Then
            MsgBox("Invalid Customer details: " & errorMessage)
            Return False
        End If
        Return True
    End Function

    Private Sub SetConditionBasedOnSelections()
        Select Case True
            Case ComboBox1.Text = "Deluxe" And ComboBox2.Text = "Restaurant Access"
                Cond = 1
            Case ComboBox1.Text = "Deluxe" And ComboBox2.Text = "Pool Access"
                Cond = 2
            Case ComboBox1.Text = "Deluxe" And ComboBox2.Text = "All Access"
                Cond = 3
            Case ComboBox1.Text = "Super Deluxe" And ComboBox2.Text = "Restaurant Access"
                Cond = 4
            Case ComboBox1.Text = "Super Deluxe" And ComboBox2.Text = "Pool Access"
                Cond = 5
            Case ComboBox1.Text = "Super Deluxe" And ComboBox2.Text = "All Access"
                Cond = 6
            Case Else
                Cond = 0 ' Invalid condition
        End Select
    End Sub

    ' Method to display room data (can be called from another button or event)
    Private Sub ShowRoomData()
        Dim roomInfo As String = "Room Details:" & Environment.NewLine
        For i As Integer = 0 To Form2.Ro - 1
            roomInfo &= $"Room {i + 1}: ID = {Rooms(i).ID}, Condition = {Rooms(i).Condition}" & Environment.NewLine
        Next
        MsgBox(roomInfo)
    End Sub

End Class
