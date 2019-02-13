Imports System.Linq

Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Not dbEnabled Or Not playerUsername Is Nothing Then
            btnLogin.Enabled = False
        End If
    End Sub

    Private Sub Main_Menu_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If optionDarkMode Then
            'Change the background colour.
            BackColor = Color.FromArgb(255, 54, 57, 66)

            'Change the text colour.
            lblLevel.ForeColor = Color.FromArgb(255, 255, 255, 255)
            lblMenuExplanation.ForeColor = Color.FromArgb(255, 255, 255, 255)

            'Change the button text colours.
            btnLogin.ForeColor = Color.FromArgb(255, 255, 255, 255)
            btnPlay.ForeColor = Color.FromArgb(255, 255, 255, 255)
            btnSettings.ForeColor = Color.FromArgb(255, 255, 255, 255)
            btnExit.ForeColor = Color.FromArgb(255, 255, 255, 255)

            'Change the button background colour.
            btnLogin.BackColor = Color.FromArgb(255, 74, 77, 82)
            btnPlay.BackColor = Color.FromArgb(255, 74, 77, 82)
            btnSettings.BackColor = Color.FromArgb(255, 74, 77, 82)
            btnExit.BackColor = Color.FromArgb(255, 74, 77, 82)

            'Disable border of the text boxes.
            btnSettings.FlatStyle = FlatStyle.Flat
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(255, 74, 77, 82)
            btnSettings.FlatAppearance.BorderSize = 0

            btnPlay.FlatStyle = FlatStyle.Flat
            btnPlay.FlatAppearance.BorderColor = Color.FromArgb(255, 74, 77, 82)
            btnPlay.FlatAppearance.BorderSize = 0

            btnLogin.FlatStyle = FlatStyle.Flat
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(255, 74, 77, 82)
            btnLogin.FlatAppearance.BorderSize = 0

            btnExit.FlatStyle = FlatStyle.Flat
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(255, 74, 77, 82)
            btnExit.FlatAppearance.BorderSize = 0

        Else
            'Change the background colour.
            BackColor = SystemColors.Control

            'Change the text colour.
            lblLevel.ForeColor = SystemColors.ControlText
            lblMenuExplanation.ForeColor = SystemColors.ControlText

            'Change the button text colours.
            btnLogin.ForeColor = SystemColors.ControlText
            btnPlay.ForeColor = SystemColors.ControlText
            btnSettings.ForeColor = SystemColors.ControlText
            btnExit.ForeColor = SystemColors.ControlText

            'Change the button background colour.
            btnLogin.BackColor = SystemColors.Control
            btnPlay.BackColor = SystemColors.Control
            btnSettings.BackColor = SystemColors.Control
            btnExit.BackColor = SystemColors.Control

            'Disable border of the text boxes.
            btnSettings.FlatStyle = FlatStyle.Standard
            btnPlay.FlatStyle = FlatStyle.Standard
            btnLogin.FlatStyle = FlatStyle.Standard
            btnExit.FlatStyle = FlatStyle.Standard
        End If

        If Not playerUsername Is Nothing Then
            btnLogin.Enabled = False
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Open login form.
        My.Forms.LoginRegister.Show()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        'Open settings form.
        My.Forms.OptionsMenu.Show()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        'TODO: Open play menu.
        MsgBox(XP_Management.giveXP(True))
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Ends the program.
        End
    End Sub
End Class