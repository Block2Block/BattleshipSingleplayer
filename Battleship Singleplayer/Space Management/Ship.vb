Public Class Ship

    'Variable storage
    Private shipName As String
    Private shipSpaces As List(Of Space)
    Private playerShip As Boolean
    Private shipFullLength As Byte

    'Sets the variables when creating a new object.
    Sub New(ByVal shipType As String, ByVal shipLocations As List(Of Space), ByVal isPlayerShip As Boolean)
        shipName = shipType
        shipSpaces = shipLocations
        playerShip = isPlayerShip
    End Sub

    'Tells the calling class/module whether this ship contains a specified space.
    Public Function containsSpace(ByVal space As String) As Boolean
        For Each x As Space In shipSpaces
            If x.getSpaceName = space Then
                Return True
            End If
        Next
        Return False
    End Function
End Class
