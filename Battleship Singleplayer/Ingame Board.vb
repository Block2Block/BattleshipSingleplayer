Public Class Ingame_Board
    Private Sub Ingame_Board_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEndGame_Click(sender As Object, e As EventArgs) Handles btnEndGame.Click
        My.Forms.Main_Menu.Show()
        Close()
    End Sub
End Class