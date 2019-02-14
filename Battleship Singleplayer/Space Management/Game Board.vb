Public Class Game_Board

    Private letters() As Char = {"A"c, "B"c, "C"c, "D"c, "E"c, "F"c, "G"c, "H"c, "I"c, "J"c}

    'Determines whether this is a player and a selection board.
    Private playerBoard As Boolean
    Private selectionBoard As Boolean
    Private controlParent As Form

    'List of all spaces available.
    Private spaces As List(Of Space) = {New Space(Nothing, Nothing, Nothing)}.ToList


    Public Sub New(ByVal parent As Form, ByVal isPlayerBoard As Boolean, ByVal isSelectionBoard As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        spaces.Clear()

        'Fills the spaces array with the nessesary value.
        For x = 1 To 10
            For Each y In letters
                Dim space As String = y & x
                spaces.Add(New Space(x, y, DirectCast(Controls.Find(space, True)(0), Button)))
            Next
        Next

        'Sets local variables to be as needed.
        controlParent = parent
        playerBoard = isPlayerBoard
        selectionBoard = isSelectionBoard
    End Sub

    'Returns whether this is a player board or not.
    Public Function isPlayerBoard() As Boolean
        Return playerBoard
    End Function

    'Returns whether this board is meant for selection or gameplay.
    Public Function isSelectionBoard() As Boolean
        Return selectionBoard
    End Function

    'Get's a space located on this specific control.
    Public Function getSpace(ByVal space As String) As Space
        For Each x As Space In spaces
            If x.getSpaceName() = space Then
                Return x
            End If
        Next
        Return Nothing
    End Function

    'Sets whether this is a selection still (intended for transfering the same object from selection to gameplay)
    Public Sub setSelection(ByVal isSelection As Boolean)
        selectionBoard = isSelection
    End Sub

    'When a button is clicked, let them choose the direction next or handle as a gameplay move.
    Private Sub Space_Click(sender As Object, e As EventArgs) Handles A1.Click, A2.Click, A3.Click, A4.Click, A5.Click, A6.Click, A7.Click, A8.Click, A9.Click, A10.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B6.Click, B7.Click, B8.Click, B9.Click, B10.Click, C1.Click, C2.Click, C3.Click, C4.Click, C5.Click, C6.Click, C7.Click, C8.Click, C9.Click, C10.Click, D1.Click, D2.Click, D3.Click, D4.Click, D5.Click, D6.Click, D7.Click, D8.Click, D9.Click, D10.Click, E1.Click, E2.Click, E3.Click, E4.Click, E5.Click, E6.Click, E7.Click, E8.Click, E9.Click, E10.Click, F1.Click, F2.Click, F3.Click, F4.Click, F5.Click, F6.Click, F7.Click, F8.Click, F9.Click, F10.Click, G1.Click, G2.Click, G3.Click, G4.Click, G5.Click, G6.Click, G7.Click, G8.Click, G9.Click, G10.Click, H1.Click, H2.Click, H3.Click, H4.Click, H5.Click, H6.Click, H7.Click, H8.Click, H9.Click, H10.Click, I1.Click, I2.Click, I3.Click, I4.Click, I5.Click, I6.Click, I7.Click, I8.Click, I9.Click, I10.Click, J1.Click, J2.Click, J3.Click, J4.Click, J5.Click, J6.Click, J7.Click, J8.Click, J9.Click, J10.Click
        Dim btn As Button = CType(sender, Button)
        'IF a selection board, then let them choose a direction.
        If selectionBoard Then
            For Each x As Space In spaces
                If x.getSpaceName = btn.Name Then
                    If btn.Text = "" Then
                        If checkRadius(x) Then
                            Dim length As New Player_Ship_Length_Selection(Me, x)
                            length.Show()
                            controlParent.Hide()
                        End If
                    End If
                    'Stops the loop so it does not go through any more values.
                    Return
                End If
            Next
        Else
            'TODO: gameplay move.

        End If
    End Sub

    Public Function checkRadius(ByVal space As Space) As Boolean
        Dim spaceName() As Char = space.getSpaceName.ToCharArray
        Dim y As Char = spaceName(0)
        Dim x As Byte
        If spaceName.Length = 3 Then
            x = 10
        Else
            x = Byte.Parse(spaceName(1))
        End If

        For Each z As Space In spaces
            'Going right, is the space occupied.
            If z.getSpaceName.Equals(y & (x + 1)) Then
                If z.getStatus = Space.Status.Occupied Then
                    Return False
                End If
            End If

            'Going left, is the space occupied.
            If z.getSpaceName.Equals(y & (x - 1)) Then
                If z.getStatus = Space.Status.Occupied Then
                    Return False
                End If
            End If

            'Try statement incase the space being used is at the edge, this will throw an exception.
            Try
                'Going down, is the space occupied.
                If (letters(Array.IndexOf(letters, y) + 1) & x).Equals(z.getSpaceName) Then
                    If z.getStatus = Space.Status.Occupied Then
                        Return False
                    End If
                End If

            Catch ex As Exception

            End Try

            'Try statement incase the space being used is at the edge, this will throw an exception.
            Try
                'Going up, is the space occupied.
                If (letters(Array.IndexOf(letters, y) - 1) & x).Equals(z.getSpaceName) Then
                    If z.getStatus = Space.Status.Occupied Then
                        Return False
                    End If
                End If

            Catch ex As Exception

            End Try
        Next

        'It has passed all of the checks, therefore it is a valid space.
        Return True
    End Function

    Public Function getSpaces() As List(Of Space)
        Return spaces
    End Function

    Public Sub placeShip(ByVal space As Space, ByVal length As Byte, ByVal direction As String)
        'X and Y values ready for placing ships.
        Dim spaceName As String = space.getSpaceName
        Dim x As Byte = Byte.Parse(spaceName.ToCharArray()(1))
        Dim y As Byte = Array.IndexOf(letters, spaceName.ToCharArray()(0))

        Dim shipName As String

        Select Case length
            Case 5
                shipsCarrierToPlace -= 1
                shipName = "Carrier"
            Case 4
                shipsBattleshipToPlace -= 1
                shipName = "Battleship"
            Case 3
                shipsCruiseToPlace -= 1
                shipName = "Cruise"
            Case 2
                shipsDestoryerToPlace -= 1
                shipName = "Destroyer"
            Case Else
                shipName = ""
        End Select

        Dim shipLocations As List(Of Space) = {New Space(Nothing, Nothing, Nothing)}.ToList()
        shipLocations.Clear()

        'Depending on the direction, do the following.
        Select Case direction
            Case "L"

                'For each space going left
                For z = x - length To x - 1

                    'Remove it from the array.
                    Dim replace As Space = getSpace(letters(y) & z + 1)
                    spaces.Remove(replace)

                    'Set it to occupied.
                    replace.setStatus(Space.Status.Occupied)
                    replace.getButton.Text = "-"

                    shipLocations.Add(replace)

                    'Add it back to the array.
                    spaces.Add(replace)
                Next

            Case "R"
                'For each space going right.
                For z = x + 1 To x + length

                    'Remove it from the array.
                    Dim replace As Space = getSpace(letters(y) & z - 1)
                    spaces.Remove(replace)

                    'Set it to occupied.
                    replace.setStatus(Space.Status.Occupied)
                    replace.getButton.Text = "-"

                    'Add it back to the array.
                    spaces.Add(replace)
                Next
            Case "U"
                'For each space going up.
                For z = y - length To y - 1

                    'Remove it from the array.
                    Dim replace As Space = getSpace(letters(z + 1) & x)
                    spaces.Remove(replace)

                    'Set it to occupied.
                    replace.setStatus(Space.Status.Occupied)
                    replace.getButton.Text = "-"

                    'Add it back to the array.
                    spaces.Add(replace)
                Next
            Case "D"
                'For each space going down.
                For z = y + 1 To y + length

                    'Remove it from the array.
                    Dim replace As Space = getSpace(letters(z - 1) & x)
                    spaces.Remove(replace)

                    'Set it to occupied.
                    replace.setStatus(Space.Status.Occupied)
                    replace.getButton.Text = "-"

                    'Add it back to the array.
                    spaces.Add(replace)
                Next
        End Select
        Dim ship As New Ship(shipName, shipLocations, True)
        playerShipLocations.Add(ship)

        If playerShipLocations.Count = 5 Then
            My.Forms.Player_Space_Selection.btnContinue.Visible = True
            My.Forms.Player_Space_Selection.btnContinue.Enabled = True
        End If
    End Sub


End Class
