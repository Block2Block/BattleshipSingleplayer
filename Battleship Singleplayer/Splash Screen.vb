Imports MySql.Data.MySqlClient

Public Class Splash_Screen

    'Handles Initialisation of the program - initiating a connection to the database and sending a test query to check the connection worked.
    Private Sub Splash_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Shown

        'Attempt to close any active connections in the case that the program crashed and/or failed to close a connection on program quit.
        Try
            Database_Management.dbConnection.Close()
        Catch ex As Exception
        End Try

        'Updates the label with information about what the program is trying to do.
        loadLabel.Text &= vbNewLine & "Connecting to database..."

        'Attempts to open the database connection, otherwise it disables online functionality.
        Try
            Database_Management.dbConnection.Open()
            loadLabel.Text &= vbNewLine & "Connection Successful!"
        Catch ex As Exception
            loadLabel.Text &= vbNewLine & "Connection failed, disabling online features!"
            Database_Management.dbEnabled = False

            'The program does not need to send a test query if the connection failed, so returns so as not to send a test query for no reason.
            Return
        End Try

        'Attempts to retrieve some information from the database to ensure that the connection is active, working and is able to see information
        loadLabel.Text &= vbNewLine & "Sending test query..."
        Try
            'Variables required in order to send a query to a MySQL database.
            Dim loadQuery As New MySqlCommand("SELECT * FROM `accounts`", Database_Management.dbConnection)
            Dim loadDataAdapter As New MySqlDataAdapter(loadQuery)

            'Dataset to be populated when the query has been executed
            Dim loadDataSet As New DataSet
            'Clears the datatable ready to be populated.
            loadDataSet.Clear()

            'Fills the datatable with the information retrieved information from the executed query
            loadDataAdapter.Fill(loadDataSet, "accounts")

            'If there is any data at all (which will come in the form of a record/row), the query was successful. Otherwise, it failed and it disables online functionality.
            If loadDataSet.Tables(0).Rows.Count > 0 Then
                loadLabel.Text &= vbNewLine & "Test query successful!"
            Else
                loadLabel.Text &= vbNewLine & "Test query failed, disabling online features!"
                Database_Management.dbEnabled = False
            End If
        Catch ex As Exception
            loadLabel.Text &= vbNewLine & "Test query failed, disabling online features!"
            Database_Management.dbEnabled = False
        End Try
    End Sub
End Class
