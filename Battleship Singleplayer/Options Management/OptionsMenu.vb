Public Class OptionsMenu

    Private Sub btnDarkMode_Click(sender As Object, e As EventArgs) Handles btnDarkMode.Click
        'If it is already in dark mode, disable it. If it is not, then disable it.
        If optionDarkMode Then
            btnDarkMode.Text = "Dark Mode: Disabled"
            optionDarkMode = False
        Else
            btnDarkMode.Text = "Dark Mode: Enabled"
            optionDarkMode = True
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class