Imports System.Linq

Public Class Main_Menu
    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.LoginRegister.Show()
    End Sub

End Class