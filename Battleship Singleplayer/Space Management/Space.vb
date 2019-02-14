Public Class Space

    'An enum which can be used to track the individual space's status.
    Enum Status
        Empty
        Occupied
        Hit
        Miss
    End Enum

    'Variables which will be stores in each object.
    Private spaceName As String
    Private spaceButtonReference As Button
    Private spaceStatus As Status

    'When a new object is created, set the needed variables.
    Public Sub New(ByVal x As String, ByVal y As String, ByVal buttonReference As Button)
        spaceName = y & x
        spaceButtonReference = buttonReference
        spaceStatus = Status.Empty
    End Sub

    'Returns the name of a space object.
    Public Function getSpaceName() As String
        Return spaceName
    End Function

    'Gets the instance of the button.
    Public Function getButton() As Button
        Return spaceButtonReference
    End Function

    'Returns the status of the space
    Public Function getStatus() As Status
        Return spaceStatus
    End Function

    'Sets the status of the space.
    Public Sub setStatus(ByVal status As Status)
        spaceStatus = status
    End Sub

End Class
