
Module Level_Management

    Sub calculateLevel(ByVal fromLogin As Boolean, ByVal playerXP As Long)
        If fromLogin Then
            'This is basically a precaution incase I decide I want to change the Exponential function in the future, changes their current level to match the new formula.
            Dim done As Boolean = False
            Dim level As Byte = 0
            Dim xpLeft As Long = playerXP

            Do While Not done
                If xpLeft >= calculateXP(level) Then

                    'Take away the XP for the level
                    xpLeft -= calculateXP(level)

                    'Add one to the level
                    level += 1

                Else
                    'Update XP into the level they are
                    playerXPIntoLevel = xpLeft
                    If playerLevel <> level Then
                        updateLevel(level)

                        'Update the players level.
                        playerLevel = level

                        'Setting the loop as finished.
                    End If
                    done = True
                End If
            Loop
        Else
            'Variables required for the loop to work efficiently.
            Dim done As Boolean = False
            Dim totalXPRemaining As Integer = playerXP + playerXPIntoLevel

            'Adds the XP to the player's data.
            Player_Data.playerXP += playerXP

            'While the loop is not done.
            Do While Not done
                'If the amount of xp they have is more than is needed for the level
                If totalXPRemaining >= calculateXP(playerLevel) Then

                    'XP left to add, and the XP that has been added to the players account this iteration (playerXPIntoLevel will already be added to the database)
                    Dim xpRemaining As Long = totalXPRemaining - calculateXP(playerLevel)
                    Dim xpAddToDB As Long = calculateXP(playerLevel) - playerXPIntoLevel

                    'Adds a level to the player data level, updates the XP left to update and sets the XPIntoLevel as 0 so this does not interfer with the above code further.
                    playerLevel += 1
                    totalXPRemaining = xpRemaining
                    playerXPIntoLevel = 0

                    'Updates the database.
                    updateXP(xpAddToDB, True)
                Else
                    'Updates the XP into the level, sets the loop as done and updates the database.
                    playerXPIntoLevel = playerXP
                    done = True
                    updateXP(totalXPRemaining, False)
                End If
            Loop
        End If

        'Updates the XP for the 
        updateXPVisual()

    End Sub


    Function calculateXP(ByVal level) As Long
        'Returns the Exponential function that defines the XP needed for each level.
        Return (1.2 ^ level) + 100
    End Function

    Function levelUnlocked() As Byte
        'Return 0, 1, 2 or 3 based on their level.
        Select Case playerLevel
            Case >= 100
                Return 3
            Case >= 50
                Return 2
            Case >= 10
                Return 1
            Case Else
                Return 0
        End Select
    End Function
End Module
