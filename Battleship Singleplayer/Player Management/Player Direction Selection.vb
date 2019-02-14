Public Class Player_Direction_Selection

    Private letters() As Char = {"A"c, "B"c, "C"c, "D"c, "E"c, "F"c, "G"c, "H"c, "I"c, "J"c}

    Private shipSize As Byte
    Private spaceSelected As Space
    Private parentBoard As Game_Board

    Public Sub New(ByVal parent As Game_Board, ByVal space As Space, ByVal ship As Byte)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        parentBoard = parent
        spaceSelected = space
        shipSize = ship
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        parentBoard.ParentForm.Show()
        Close()
    End Sub

    Private Sub Player_Direction_Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        directionValidation(spaceSelected, shipSize)
    End Sub

    Private Sub directionValidation(ByVal space As Space, ByVal length As Byte)
        Dim spaceName As String = space.getSpaceName

        Dim x As Byte
        If spaceName.ToCharArray.Length = 3 Then
            x = 10
        Else
            x = Byte.Parse(spaceName.ToCharArray()(1))
        End If

        Dim y As Char = spaceName.ToCharArray()(0)

        'If the space is occupied, return - This should never happen.
        If space.getStatus = Space.Status.Occupied Then
            Return
        End If

        Select Case length
            Case 5
                'If the ship is a carrier, then perform these validations.

                'Checking the y direction.
                Select Case y
                    'if it is too far right or too far left, disable those buttons.
                    Case "A"c, "B"c, "C"c, "D"c
                        btnUp.Enabled = False
                    Case "G"c, "H"c, "I"c, "J"c
                        btnDown.Enabled = False
                End Select

                'Checking the x direction.
                Select Case x
                    'if it is too far up or too far down, disable those buttons.
                    Case 1, 2, 3, 4
                        btnLeft.Enabled = False
                    Case 7, 8, 9, 10
                        btnRight.Enabled = False
                End Select

            Case 4
                'If the ship is a battleship, then perform these validations.

                'Checking the y direction.
                Select Case y
                    'if it is too far right or too far left, disable those buttons.
                    Case "A"c, "B"c, "C"c
                        btnUp.Enabled = False
                    Case "H"c, "I"c, "J"c
                        btnDown.Enabled = False
                End Select

                'Checking the x direction.
                Select Case x
                    'if it is too far up or too far down, disable those buttons.
                    Case 1, 2, 3
                        btnLeft.Enabled = False
                    Case 8, 9, 10
                        btnRight.Enabled = False
                End Select


            Case 3
                'If the ship is a battleship, then perform these validations.

                'Checking the y direction.
                Select Case y
                    'if it is too far right or too far left, disable those buttons.
                    Case "A"c, "B"c
                        btnUp.Enabled = False
                    Case "I"c, "J"c
                        btnDown.Enabled = False
                End Select

                'Checking the x direction.
                Select Case x
                    'if it is too far up or too far down, disable those buttons.
                    Case 1, 2
                        btnLeft.Enabled = False
                    Case 9, 10
                        btnRight.Enabled = False
                End Select


            Case 2
                'If the ship is a battleship, then perform these validations.

                'Checking the y direction.
                Select Case y
                    'if it is too far right or too far left, disable those buttons.
                    Case "A"c
                        btnUp.Enabled = False
                    Case "J"c
                        btnDown.Enabled = False
                End Select

                'Checking the x direction.
                Select Case x
                    'if it is too far up or too far down, disable those buttons.
                    Case 1
                        btnLeft.Enabled = False
                    Case 10
                        btnRight.Enabled = False
                End Select

        End Select

        'Checking each individual space to see if they are occupied or not (and if they have similar spaces near them).
        For w = 1 To length - 1
            Try
                'Checking upward if the button has not already been disabled.
                If btnUp.Enabled Then
                    For Each z As Space In parentBoard.getSpaces()
                        If z.getSpaceName.Equals(letters(Array.IndexOf(letters, y) - w) & x) Then
                            If z.getStatus = Space.Status.Occupied Or z.getButton.Text = "-" Then
                                btnUp.Enabled = False
                            Else
                                If Not parentBoard.checkRadius(z) Then
                                    btnUp.Enabled = False
                                End If
                            End If
                        End If
                    Next
                End If

            Catch ex As Exception

            End Try


            Try
                'Checking downward if the button has not already been disabled.
                If btnDown.Enabled Then
                    For Each z As Space In parentBoard.getSpaces()
                        If z.getSpaceName.Equals(letters(Array.IndexOf(letters, y) + w) & x) Then
                            If z.getStatus = Space.Status.Occupied Or z.getButton.Text = "-" Then
                                btnDown.Enabled = False
                            Else
                                If Not parentBoard.checkRadius(z) Then
                                    btnDown.Enabled = False
                                End If
                            End If
                        End If
                    Next
                End If
            Catch ex As Exception

            End Try


            Try
                'Checking leftward if the button has not already been disabled.
                If btnLeft.Enabled Then
                    For Each z As Space In parentBoard.getSpaces()
                        If z.getSpaceName.Equals(y & (x - w)) Then
                            If z.getStatus = Space.Status.Occupied Or z.getButton.Text = "-" Then
                                btnLeft.Enabled = False
                            Else
                                If Not parentBoard.checkRadius(z) Then
                                    btnLeft.Enabled = False
                                End If
                            End If
                        End If
                    Next
                End If
            Catch ex As Exception

            End Try
            Try
                'Checking rightward if the button has not already been disabled.
                If btnRight.Enabled Then
                    For Each z As Space In parentBoard.getSpaces()
                        If z.getSpaceName.Equals(y & (x + w)) Then
                            If z.getStatus = Space.Status.Occupied Or z.getButton.Text = "-" Then
                                btnRight.Enabled = False
                            Else
                                If Not parentBoard.checkRadius(z) Then
                                    btnRight.Enabled = False
                                End If
                            End If
                        End If
                    Next
                End If
            Catch ex As Exception

            End Try
        Next

        Return
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        parentBoard.placeShip(spaceSelected, shipSize, "U")
        My.Forms.Player_Space_Selection.Show()
        Close()
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        parentBoard.placeShip(spaceSelected, shipSize, "L")
        My.Forms.Player_Space_Selection.Show()
        Close()
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        parentBoard.placeShip(spaceSelected, shipSize, "R")
        My.Forms.Player_Space_Selection.Show()
        Close()
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        parentBoard.placeShip(spaceSelected, shipSize, "D")
        My.Forms.Player_Space_Selection.Show()
        Close()
    End Sub
End Class