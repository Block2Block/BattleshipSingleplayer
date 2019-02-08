Imports System.Runtime.InteropServices

Public Class OptionsMenu

    <DllImport("winmm.dll")>
    Public Shared Function waveOutSetVolume(ByVal hwo As IntPtr, ByVal dwVolume As UInteger) As Integer
    End Function


    Private Sub btnDarkMode_Click(sender As Object, e As EventArgs) Handles btnDarkMode.Click
        'If it is already in dark mode, disable it. If it is not, then disable it.
        If optionDarkMode Then
            btnDarkMode.Text = "Dark Mode: Disabled"
            optionDarkMode = False
        Else
            btnDarkMode.Text = "Dark Mode: Enabled"
            optionDarkMode = True
        End If

        For Each x In My.Application.OpenForms
            x.activate()
        Next

        Me.Select()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Update dark mode button if activated
        If optionDarkMode Then
            btnDarkMode.Text = "Dark Mode: Enabled"
        End If

        'Sets the volume slider
        tbrVolume.Value = optionSoundVolume

        'Set's the AI Level Button
        Select Case optionAILevel
            Case "Normal"
                btnAILevel.Text = "AI Level: Normal"
            Case "Hard"
                btnAILevel.Text = "AI Level: Hard"
            Case "Impossible"
                btnAILevel.Text = "AI Level: Impossible"
        End Select

        If Not optionLevelOpt Then
            btnLevelOpt.Text = "Level Opt: Off"
        End If
    End Sub

    Private Sub OptionsMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If optionDarkMode Then
            'Change the background colour.
            BackColor = Color.FromArgb(255, 54, 57, 66)

            'Change the text colour.
            lblGraphicsOptions.ForeColor = Color.FromArgb(255, 255, 255, 255)
            lblOptionsExplanation.ForeColor = Color.FromArgb(255, 255, 255, 255)
            lblVolume.ForeColor = Color.FromArgb(255, 255, 255, 255)
            lblGameOptions.ForeColor = Color.FromArgb(255, 255, 255, 255)

            'Change the button text colours.
            btnLevelOpt.ForeColor = Color.FromArgb(255, 255, 255, 255)
            btnDarkMode.ForeColor = Color.FromArgb(255, 255, 255, 255)
            btnClose.ForeColor = Color.FromArgb(255, 255, 255, 255)
            btnAILevel.ForeColor = Color.FromArgb(255, 255, 255, 255)

            'Change the button background colour.
            btnLevelOpt.BackColor = Color.FromArgb(255, 74, 77, 82)
            btnDarkMode.BackColor = Color.FromArgb(255, 74, 77, 82)
            btnClose.BackColor = Color.FromArgb(255, 74, 77, 82)
            btnAILevel.BackColor = Color.FromArgb(255, 74, 77, 82)

            'Disable border of the text boxes.
            btnLevelOpt.FlatStyle = FlatStyle.Flat
            btnLevelOpt.FlatAppearance.BorderColor = Color.FromArgb(255, 74, 77, 82)
            btnLevelOpt.FlatAppearance.BorderSize = 0

            btnDarkMode.FlatStyle = FlatStyle.Flat
            btnDarkMode.FlatAppearance.BorderColor = Color.FromArgb(255, 74, 77, 82)
            btnDarkMode.FlatAppearance.BorderSize = 0

            btnClose.FlatStyle = FlatStyle.Flat
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(255, 74, 77, 82)
            btnClose.FlatAppearance.BorderSize = 0

            btnAILevel.FlatStyle = FlatStyle.Flat
            btnAILevel.FlatAppearance.BorderColor = Color.FromArgb(255, 74, 77, 82)
            btnAILevel.FlatAppearance.BorderSize = 0
        Else
            'Change the background colour.
            BackColor = SystemColors.Control

            'Change the text colour.
            lblGraphicsOptions.ForeColor = SystemColors.ControlText
            lblOptionsExplanation.ForeColor = SystemColors.ControlText
            lblVolume.ForeColor = SystemColors.ControlText
            lblGameOptions.ForeColor = SystemColors.ControlText

            'Change the button text colours.
            btnLevelOpt.ForeColor = SystemColors.ControlText
            btnDarkMode.ForeColor = SystemColors.ControlText
            btnClose.ForeColor = SystemColors.ControlText
            btnAILevel.ForeColor = SystemColors.ControlText

            'Change the button background colour.
            btnLevelOpt.BackColor = SystemColors.Control
            btnDarkMode.BackColor = SystemColors.Control
            btnClose.BackColor = SystemColors.Control
            btnAILevel.BackColor = SystemColors.Control

            'Disable border of the text boxes.
            btnLevelOpt.FlatStyle = FlatStyle.Standard
            btnDarkMode.FlatStyle = FlatStyle.Standard
            btnClose.FlatStyle = FlatStyle.Standard
            btnAILevel.FlatStyle = FlatStyle.Standard
        End If
    End Sub

    Private Sub tbrVolume_ValueChanged(sender As Object, e As EventArgs) Handles tbrVolume.Scroll

        'Get's the volume and timesing it by the max value devided by 100 (or 1111 1111 1111 1111 in binary devided by 10)
        Dim NewVolume As Integer = ((UShort.MaxValue / 100) * tbrVolume.Value)
        ' Set the same volume for both the left and the right channels (setting the binary to repeat using Bitwise operations).
        Dim NewVolumeAllChannels As UInteger = ((CUInt(NewVolume) And &HFFFF) Or (CUInt(NewVolume) << 16))
        ' Set the volume of the program
        waveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels)

        'Updates the value in options.
        optionSoundVolume = tbrVolume.Value

    End Sub

    Private Sub btnAILevel_Click(sender As Object, e As EventArgs) Handles btnAILevel.Click

        'Depending on the value of optionAILevel, change the AI level in a cycle.
        Select Case optionAILevel
            Case "Easy"
                optionAILevel = "Normal"
                btnAILevel.Text = "AI Level: Normal"
            Case "Normal"
                optionAILevel = "Hard"
                btnAILevel.Text = "AI Level: Hard"
            Case "Hard"
                optionAILevel = "Impossible"
                btnAILevel.Text = "AI Level: Impossible"
            Case "Impossible"
                optionAILevel = "Easy"
                btnAILevel.Text = "AI Level: Easy"
        End Select
    End Sub

    Private Sub btnLevelOpt_Click(sender As Object, e As EventArgs) Handles btnLevelOpt.Click

        'Toggle level opt to be the opposite and update the button.
        If optionLevelOpt Then
            btnLevelOpt.Text = "Level Opt: Off"
            optionLevelOpt = False
        Else
            btnLevelOpt.Text = "Level Opt: On"
            optionLevelOpt = True
        End If
    End Sub
End Class