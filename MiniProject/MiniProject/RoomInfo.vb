Public Class RoomInfo
    Public Property ID As String
    Public Property Condition As Integer

    ' Default constructor
    Public Sub New()
        ID = String.Empty
        Condition = 0
    End Sub

    ' Constructor with parameters
    Public Sub New(id As String, condition As Integer)
        Me.ID = id
        Me.Condition = condition
    End Sub

End Class
