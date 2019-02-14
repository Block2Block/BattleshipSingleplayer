Public Module Game_Variables

    'Game variables required throughout the program.
    Public playerShipLocations As List(Of Ship) = {New Ship(Nothing, Nothing, Nothing)}.ToList
    Public aiShipLocations As List(Of Ship) = {New Ship(Nothing, Nothing, Nothing)}.ToList
    Public shipsCarrierToPlace As Byte
    Public shipsBattleshipToPlace As Byte
    Public shipsCruiseToPlace As Byte
    Public shipsDestoryerToPlace As Byte

End Module
