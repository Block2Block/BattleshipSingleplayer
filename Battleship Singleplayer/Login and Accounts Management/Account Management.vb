'Imports the library needed in order to use Regex Expressions.
Imports System.Text.RegularExpressions

Module Account_Management

    'Polymorphic Subroutines which update the varables in the Player_Data module.
    Public Sub updateGameVariables(ByVal variableXP As Long, ByVal variableGamePlayed As Boolean)
        'Updates variables in the Player_Data module with the varables supplied.
        playerXP += variableXP
        If variableGamePlayed Then
            playerGamesPlayed += 1
        End If

        'Once visual elements have been finished, I will implement these into this subroutine.
    End Sub

    Public Sub updateGameVariables(ByVal variableXP As Long, ByVal variableGamePlayed As Boolean, ByVal variableLevel As Int16)
        'Updates variables in the Player_Data module with the varables supplied.
        playerXP += variableXP
        playerLevel += 1
        If variableGamePlayed Then
            playerGamesPlayed += 1
        End If

        'Once visual elements have been finished, I will implement these into this subroutine.
    End Sub

    Public Sub updateGameVariables(ByVal variableXP As Long, ByVal variableGamePlayed As Boolean, ByVal variableLevel As Int16, ByVal variableWin As Boolean)
        'Updates variables in the Player_Data module with the varables supplied.
        playerXP += variableXP
        playerLevel += 1
        playerGamesPlayed += 1
        If variableWin Then
            playerWins += 1
        End If

        'Once visual elements have been finished, I will implement these into this subroutine.
    End Sub

    'This subroutine was for use when logging in.
    Public Sub updateGameVariables(ByVal variableXP As Long, ByVal variableGamesPlayed As Int16, ByVal variableLevel As Int16, ByVal variableWins As Int16)
        'Updates variables in the Player_Data module with the varables supplied.

        playerXP = variableXP
        playerLevel = variableLevel
        playerGamesPlayed = variableGamesPlayed
        playerWins = variableGamesPlayed

        calculateLevel(True, variableXP)

        'Once visual elements have been finished, I will implement these into this subroutine.
    End Sub

    'What happens when a user goes to register for an account
    Public Function registerAccount(ByVal registerUsername As String, ByVal registerPassword As String, ByVal registerConfirmationPassword As String, ByVal registerNFCID As Nullable(Of UInt64)) As String

        'First check to see if all of the required fields are filled out.
        If registerUsername = "" Or registerPassword = "" Or registerConfirmationPassword = "" Then
            Return "NotFilled"
        End If

        'Checks to see if the password has more than 5 characters.
        If registerPassword.Length < 6 Then
            Return "PWNotLongEnough"
        End If

        'Checks against a Regex (Regular Expression) to see if the password contains at least 1 number, 1 lowercase and 1 uppercase letter.
        If Not Regex.IsMatch(registerPassword, "(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,}") Then
            Return "PWMeetCriteria"
        End If

        'Checks to see if the password and confirmation password match.
        If Not registerPassword.Equals(registerConfirmationPassword) Then
            Return "PWNotMatch"
        End If

        'Checks to see if there are only alphanumeric characters in the name.
        If Not Regex.IsMatch(registerUsername, "^[A-Za-z0-9]+$") Then
            Return "UNNotAlphaNumeric"
        End If

        'If the creating a record succeeds, then creating an account has worked.
        If createNewAccountRecord(registerUsername, registerPassword, registerNFCID) Then
            Return Nothing
        Else
            Return "DBFail"
        End If

        'Returns a question mark when something unexpected happened.
        Return "?"
    End Function

    'The function to call when a user logs in.
    Public Function login(ByVal loginUsername As String, ByVal loginPassword As String) As Boolean

        'If their login has been successful and it has successfully updated the variables.
        If checkLoginDetails(loginUsername, loginPassword) Then
            'Return true, letting the form know that it has successfully logged in.
            Return True
        End If
        'Login failed.
        Return False
    End Function

End Module
