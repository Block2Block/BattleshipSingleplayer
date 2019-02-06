Public Class LoginRegister
    Private Sub btnGotAccount_Click(sender As Object, e As EventArgs) Handles btnGotAccount.Click

        'First disable visibility for buttons and text on the form already.
        lblRegister.Visible = False
        btnGotAccount.Visible = False
        btnRegister.Visible = False
        txtRegisterConfirmation.Visible = False
        txtRegisterPassword.Visible = False
        txtRegisterUsername.Visible = False

        'Now enable visibility for the login buttons.
        lblLogin.Visible = True
        btnNoAccount.Visible = True
        btnLogin.Visible = True
        txtLoginUser.Visible = True
        txtLoginPassword.Visible = True

        'Now change the title of the form
        My.Forms.LoginRegister.Text = "Login"

    End Sub

    Private Sub btnNoAccount_Click(sender As Object, e As EventArgs) Handles btnNoAccount.Click

        'Now enable visibility for the login buttons.
        lblLogin.Visible = False
        btnNoAccount.Visible = False
        btnLogin.Visible = False
        txtLoginUser.Visible = False
        txtLoginPassword.Visible = False

        'First disable visibility for buttons and text on the form already.
        lblRegister.Visible = True
        btnGotAccount.Visible = True
        btnRegister.Visible = True
        txtRegisterConfirmation.Visible = True
        txtRegisterPassword.Visible = True
        txtRegisterUsername.Visible = True

        'Now change the title of the form
        My.Forms.LoginRegister.Text = "Register"

    End Sub

    'When the login password text box is given focus by the user
    Private Sub txtLoginPassword_GotFocus(sender As Object, e As EventArgs) Handles txtLoginPassword.GotFocus
        'If it contains default text
        If txtLoginPassword.Text = "Password" Then
            'Clear the text box and set the password char to a star.
            txtLoginPassword.Text = ""
            txtLoginPassword.PasswordChar = "*"c
        End If
    End Sub

    'When the login password text box has lost focus from the user
    Private Sub txtLoginPassword_LostFocus(sender As Object, e As EventArgs) Handles txtLoginPassword.LostFocus
        'If it does not contain any text
        If txtLoginPassword.Text = "" Then
            'Set the text to password and clear the password char.
            txtLoginPassword.Text = "Password"
            txtLoginPassword.PasswordChar = ""
        End If
    End Sub

    'When the login username text box is given focus by the user
    Private Sub txtLoginUser_GotFocus(sender As Object, e As EventArgs) Handles txtLoginUser.GotFocus
        'If the username box has default text in, clear the text.
        If txtLoginUser.Text = "Username" Then
            txtLoginUser.Text = ""
        End If
    End Sub

    'When the login username text box has lost focus from the user
    Private Sub txtLoginUser_LostFocus(sender As Object, e As EventArgs) Handles txtLoginUser.LostFocus
        'If the username box has no text in, add in default text
        If txtLoginUser.Text = "" Then
            txtLoginUser.Text = "Username"
        End If
    End Sub

    'When the register username text box is given focus by the user
    Private Sub txtRegisterUsername_GotFocus(sender As Object, e As EventArgs) Handles txtRegisterUsername.GotFocus
        'If the username box has default text in, clear the text.
        If txtRegisterUsername.Text = "Username" Then
            txtRegisterUsername.Text = ""
        End If
    End Sub

    'When the register username text box has lost focus from the user
    Private Sub txtRegisterUsername_LostFocus(sender As Object, e As EventArgs) Handles txtRegisterUsername.LostFocus
        'If the username box has no text in, add in default text
        If txtRegisterUsername.Text = "" Then
            txtRegisterUsername.Text = "Username"
        End If
    End Sub

    'When the register password text box is given focus by the user
    Private Sub txtRegisterPassword_GotFocus(sender As Object, e As EventArgs) Handles txtRegisterPassword.GotFocus
        'If it contains default text
        If txtRegisterPassword.Text = "Password" Then
            'Clear the text box and set the password char to a star.
            txtRegisterPassword.Text = ""
            txtRegisterPassword.PasswordChar = "*"c
        End If
    End Sub

    'When the register password text box has lost focus from the user
    Private Sub txtRegisterPassword_LostFocus(sender As Object, e As EventArgs) Handles txtRegisterPassword.LostFocus
        'If it does not contain any text
        If txtRegisterPassword.Text = "" Then
            'Set the text to password and clear the password char.
            txtRegisterPassword.Text = "Password"
            txtRegisterPassword.PasswordChar = ""
        End If
    End Sub

    'When the register confirmation password text box is given focus by the user
    Private Sub txtRegisterConfirmation_GotFocus(sender As Object, e As EventArgs) Handles txtRegisterConfirmation.GotFocus
        'If it contains default text
        If txtRegisterConfirmation.Text = "Confirmation" Then
            'Clear the text box and set the password char to a star.
            txtRegisterConfirmation.Text = ""
            txtRegisterConfirmation.PasswordChar = "*"c
        End If
    End Sub

    'When the register confirmation password text box has lost focus from the user
    Private Sub txtRegisterConfirmation_LostFocus(sender As Object, e As EventArgs) Handles txtRegisterConfirmation.LostFocus
        'If it does not contain any text
        If txtRegisterConfirmation.Text = "" Then
            'Set the text to password and clear the password char.
            txtRegisterConfirmation.Text = "Confirmation"
            txtRegisterConfirmation.PasswordChar = ""
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If login(txtLoginUser.Text, txtLoginPassword.Text) Then
            MsgBox("You have been successfully logged in.")
            Me.Close()
        Else
            MessageBox.Show("Your username or password was incorrect. Please try again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Select Case registerAccount(txtRegisterUsername.Text, txtRegisterPassword.Text, txtRegisterConfirmation.Text, Nothing)
            Case "NotFilled"
                MessageBox.Show("You have not filled out all of the required fields.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Case "PWNotLongEnough"
                MessageBox.Show("Your password must be at least 7 characters.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Case "PWMeetCriteria"
                MessageBox.Show("Your password must contain at least 1 number, 1 lowercase and 1 uppercase letter.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Case "PWNotMatch"
                MessageBox.Show("Your password and confirmation password do not match.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Case "UNNotAlphaNumeric"
                MessageBox.Show("Your username must be alphanumeric (most only contain letters or numbers).", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Case "DBFail"
                MessageBox.Show("That Username is already taken. Please choose another one.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Case "?"
                MessageBox.Show("Apparently I'm an idiot and something went drastically wrong. Even I don't know what happened. Please contact me.", "FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Case Else
                If MessageBox.Show("Your account has been successfully created. Would you like to log in now?", "Registration Successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
                    If login(txtRegisterUsername.Text, txtRegisterPassword.Text) Then
                        MsgBox("You have been successfully logged in.")
                        Me.Close()
                    Else
                        MessageBox.Show("There has been a database error. Please try logging in manually.", "FATAL", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    End If
                Else
                    Me.Close()
                End If
        End Select

    End Sub
End Class