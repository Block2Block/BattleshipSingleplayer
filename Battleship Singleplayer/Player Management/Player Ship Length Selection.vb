Public Class Player_Ship_Length_Selection

    Private parentBoard As Game_Board
    Private spaceSelected As Space

    Sub New(ByVal parent As Game_Board, ByVal space As Space)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        parentBoard = parent
        spaceSelected = space

    End Sub

    Private Sub Player_Ship_Length_Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If they don't have a battleship to place, disable the button.
        If shipsBattleshipToPlace = 0 Then
            btnBattleship.Enabled = False
        End If

        'If they don't have a carrier to place, disable the button.
        If shipsCarrierToPlace = 0 Then
            btnCarrier.Enabled = False
        End If

        'If they don't have a cruise to place, disable the button.
        If shipsCruiseToPlace = 0 Then
            btnCruise.Enabled = False
        End If

        'If they don't have a destoryer to place, disable the button.
        If shipsDestoryerToPlace = 0 Then
            btnDestroyer.Enabled = False
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        parentBoard.ParentForm.Show()
        Close()
    End Sub

    Private Sub btnCarrier_Click(sender As Object, e As EventArgs) Handles btnCarrier.Click
        Dim direction As Player_Direction_Selection
        direction = New Player_Direction_Selection(parentBoard, spaceSelected, 5)
        direction.Show()
        Close()
    End Sub

    Private Sub btnBattleship_Click(sender As Object, e As EventArgs) Handles btnBattleship.Click
        Dim direction As Player_Direction_Selection
        direction = New Player_Direction_Selection(parentBoard, spaceSelected, 4)
        direction.Show()
        Close()
    End Sub

    Private Sub btnCruise_Click(sender As Object, e As EventArgs) Handles btnCruise.Click
        Dim direction As Player_Direction_Selection
        direction = New Player_Direction_Selection(parentBoard, spaceSelected, 3)
        direction.Show()
        Close()
    End Sub

    Private Sub btnDestroyer_Click(sender As Object, e As EventArgs) Handles btnDestroyer.Click
        Dim direction As Player_Direction_Selection
        direction = New Player_Direction_Selection(parentBoard, spaceSelected, 2)
        direction.Show()
        Close()
    End Sub
End Class