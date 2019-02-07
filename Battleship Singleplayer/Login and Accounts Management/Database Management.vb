Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Module Database_Management

    'These variables initialise the database connection, with all of the needed information in order for the program to connect to the database
    Private dbConnectionString As String = "server=block2block.me;user=battleship_admin;database=sfcs_cs_battleship;port=3306;password=Battleship123;"
    Public dbConnection As New MySqlConnection(dbConnectionString)

    'This can be accessed by any class to see if the database connection was successful, and therefore whether to enable online functionality.
    Public dbEnabled As Boolean = True

    'This checks whether provided login details are correct.
    Public Function checkLoginDetails(ByVal loginUsername As String, ByVal loginPassword As String) As Boolean
        'Attempts to get the inforamtion from the database.
        Try
            'Variables required in order to send a query to a MySQL database.
            Dim loginQuery As New MySqlCommand("SELECT * FROM `accounts` WHERE Username = '" & loginUsername & "'", dbConnection)
            Dim loginDataAdapter As New MySqlDataAdapter(loginQuery)

            'Dataset to be populated when the query has been executed
            Dim loginDataSet As New DataSet
            'Clears the datatable ready to be populated.
            loginDataSet.Clear()

            'Fills the datatable with the information retrieved information from the executed query
            loginDataAdapter.Fill(loginDataSet, "accounts")

            'Checks whether there are any users in the database with the specified name.
            If loginDataSet.Tables(0).Rows.Count > 0 Then
                'Checks whether the hash password matches the password stored in the database.
                If loginDataSet.Tables(0).Rows(0).Item(2).Equals(SHA.GenerateSHA512String(loginPassword)) Then
                    'Sets the login details in the Player Data module.
                    playerUserID = loginDataSet.Tables(0).Rows(0).Item(0)
                    playerUsername = loginUsername

                    'Retrieves and updates player variables.
                    retrievePlayerDetails(playerUserID)
                    Return True
                End If
            End If
        Catch ex As Exception
            'Failed to get the login details, so just return false.
            Return False
        End Try

        'The login check failed, so returns false.
        Return False
    End Function

    'Retrieves information about the user from the database.
    Public Sub retrievePlayerDetails(ByVal loginID As Integer)
        Try
            'Variables required in order to send a query to a MySQL database.
            Dim playerDetailsQuery As New MySqlCommand("SELECT * FROM `player_data` WHERE UserID = '" & loginID & "'", dbConnection)
            Dim playerDetailsDataAdapter As New MySqlDataAdapter(playerDetailsQuery)

            'Dataset to be populated when the query has been executed
            Dim playerDetailsDataSet As New DataSet
            'Clears the datatable ready to be populated.
            playerDetailsDataSet.Clear()

            'Fills the datatable with the information retrieved information from the executed query
            playerDetailsDataAdapter.Fill(playerDetailsDataSet, "player_data")

            'Checks whether there are any users in the database with the specified name.
            If playerDetailsDataSet.Tables(0).Rows.Count > 0 Then

                'Getting the specific record for the user so I don't need to keep refering to it when updating the game variables.
                Dim record As DataRow = playerDetailsDataSet.Tables(0).Rows(0)

                'Updating the game variables in the specific areas.
                updateGameVariables(Long.Parse(record.Item(3)), Int16.Parse(record.Item(2)), Int16.Parse(record.Item(4)), Int16.Parse(record.Item(1)))

            Else
                'User does not have a valid player_data record, so it creates one.
                Dim newPlayerDetailsQuery As New MySqlCommand("INSERT INTO `player_data`(UserID,Wins,Games Played,XP,Level) values (" & loginID & ", 0, 0, 0, 0")
                Dim newPlayerDetailsDataAdapter As New MySqlDataAdapter(playerDetailsQuery)

                'Updating game variables with a clean record.
                updateGameVariables(Long.Parse(0), Int16.Parse(0), Int16.Parse(0), Int16.Parse(0))
            End If

        Catch ex As Exception

        End Try
    End Sub

    'Creating a new account record in the database.
    Public Function createNewAccountRecord(ByVal username As String, ByVal password As String, ByVal nfcID As Nullable(Of UInt64)) As Boolean
        Try
            'Variables required in order to send a query to a MySQL database.
            Dim checkAccountQuery As New MySqlCommand("SELECT * FROM accounts WHERE Username = '" & username & "'", dbConnection)
            Dim checkAccountDataAdapter As New MySqlDataAdapter(checkAccountQuery)

            'Dataset to be populated when the query has been executed
            Dim checkAccountDataSet As New DataSet
            'Clears the datatable ready to be populated.
            checkAccountDataSet.Clear()

            'Fills the datatable with the information retrieved information from the executed query
            checkAccountDataAdapter.Fill(checkAccountDataSet, "accounts")

            'Checks whether there are any users in the database with the same name, and returns false if there is.
            If checkAccountDataSet.Tables(0).Rows.Count > 0 Then
                Return False
            End If

            'Inserts the username and the hashed password to the database.
            Dim insertQuery As New MySqlCommand("INSERT INTO accounts(Username,Password) VALUES ('" & username & "', '" & SHA.GenerateSHA512String(password) & "') ", dbConnection)

            'If an NFC value is specified, then add this to the database too.
            If Not (nfcID Is Nothing) And Not (nfcID.Equals("")) Then
                insertQuery = New MySqlCommand("INSERT INTO accounts(Username,Password,NFCID) VALUES ('" & username & "', '" & SHA.GenerateSHA512String(password) & "', " & nfcID & ") ", dbConnection)
            End If

            'Inserts the username and the hashed password to the database.
            Dim insertDataAdapter As New MySqlDataAdapter(insertQuery)

            'Dataset to be populated when the query has been executed
            Dim insertDataSet As New DataSet
            'Clears the datatable ready to be populated.
            insertDataSet.Clear()

            'Fills the datatable with the information retrieved information from the executed query
            insertDataAdapter.Fill(insertDataSet, "accounts")

            Return True
        Catch ex As Exception
            'Should anything fail, it will return false as a failsafe.
            Return False
            Console.WriteLine(ex.InnerException.Message)
        End Try
        Return False
    End Function

    'Updating XP with XP gained and if there has been an extra level, that is also put into the database.
    Public Sub updateXP(ByVal xp As Int64, ByVal level As Boolean)
        Try
            'Inserts the username and the hashed password to the database.
            Dim updateQuery As New MySqlCommand("UPDATE `player_data` SET XP = XP + " & xp & " WHERE UserID = " & playerUserID, dbConnection)

            If level Then
                updateQuery = New MySqlCommand("UPDATE `player_data` SET XP = XP + " & xp & ", Level = Level + 1 WHERE UserID = " & playerUserID, dbConnection)
            End If

            'Inserts the new xp and level to the database.
            Dim updateDataAdapter As New MySqlDataAdapter(updateQuery)

            'Dataset to be populated when the query has been executed
            Dim updateDataSet As New DataSet
            'Clears the datatable ready to be populated.
            updateDataSet.Clear()

            'Fills the datatable with the information retrieved information from the executed query
            updateDataAdapter.Fill(updateDataSet, "player_data")
        Catch ex As Exception
            Throw New Exception("Unable to make a successful query to the database.")
        End Try
    End Sub
End Module
