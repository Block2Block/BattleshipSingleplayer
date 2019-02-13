Module XP_Management

    'Creates the generator for use by the XP selection class. We do not create this object during the subroutine so it does not keep generating the same seed each time.
    Private Generator As Random = New Random()

    Public Function giveXP(ByVal win As Boolean) As Integer
        'Generatrs a random number
        Dim xp As Integer = Generator.Next(10, 50)

        'Changes the multiplier based on the AI Level
        Select Case optionAILevel
            Case "Easy"
                If win Then
                    xp *= 1.5
                End If
            Case "Normal"
                If win Then
                    xp *= 3
                Else
                    xp *= 1.5
                End If
            Case "Hard"
                If win Then
                    xp *= 5.5
                Else
                    xp *= 2
                End If
            Case "Impossible"
                If win Then
                    xp *= 10
                Else
                    xp *= 2.5
                End If
        End Select
        Return xp
    End Function

    'This function updates the main menu items which show the XP and Level.
    Sub updateXPVisual()
        My.Forms.Main_Menu.pgbXP.Maximum = calculateXP(playerLevel)
        My.Forms.Main_Menu.pgbXP.Value = playerXPIntoLevel
        My.Forms.Main_Menu.lblLevel.Text = "Level " & playerLevel & " - " & playerXPIntoLevel & "/" & calculateXP(playerLevel)
        My.Forms.Main_Menu.lblLevel.Location = New Point((My.Forms.Main_Menu.Size.Width - My.Forms.Main_Menu.lblLevel.Width) / 2, My.Forms.Main_Menu.lblLevel.Location.Y)
    End Sub
End Module
