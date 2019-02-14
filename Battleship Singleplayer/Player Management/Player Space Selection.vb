Public Class Player_Space_Selection

    Dim board As Game_Board

    Private Sub Player_Space_Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Creates new game board and hides the main menu.
        board = New Game_Board(Me, True, True)
        flpSelection.Controls.Add(board)
        My.Forms.Main_Menu.Hide()

        'Resets all of the game variables to default values.
        shipsBattleshipToPlace = 1
        shipsCarrierToPlace = 1
        shipsCruiseToPlace = 2
        shipsDestoryerToPlace = 1
        playerShipLocations.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        My.Forms.Main_Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        flpSelection.Controls.Remove(board)
        My.Forms.Ingame_Board.Show()
        board.setSelection(False)
        For Each x As Space In board.getSpaces
            x.getButton.Enabled = False
        Next
        My.Forms.Ingame_Board.flpGame.Controls.Add(board)

        Close()
    End Sub
End Class