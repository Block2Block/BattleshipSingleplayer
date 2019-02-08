Imports System.Linq

Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.LoginRegister.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.OptionsMenu.Show()
    End Sub

    Private Sub Main_Menu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\User\Music\personal music stuff\Jump Up, Super Star! Remix- Super Mario Odyssey- The Living Tombstone.wav", AudioPlayMode.BackgroundLoop)
    End Sub
End Class