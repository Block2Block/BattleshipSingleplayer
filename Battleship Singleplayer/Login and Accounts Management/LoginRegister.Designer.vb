<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginRegister
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.imgLoginTitle = New System.Windows.Forms.PictureBox()
        Me.lblExplanation = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.txtLoginUser = New System.Windows.Forms.TextBox()
        Me.txtLoginPassword = New System.Windows.Forms.TextBox()
        Me.txtRegisterUsername = New System.Windows.Forms.TextBox()
        Me.txtRegisterPassword = New System.Windows.Forms.TextBox()
        Me.txtRegisterConfirmation = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnNoAccount = New System.Windows.Forms.Button()
        Me.btnGotAccount = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.imgLoginTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgLoginTitle
        '
        Me.imgLoginTitle.Image = Global.Battleship_Singleplayer.My.Resources.Resources.cooltext314369820897921
        Me.imgLoginTitle.Location = New System.Drawing.Point(12, 12)
        Me.imgLoginTitle.Name = "imgLoginTitle"
        Me.imgLoginTitle.Size = New System.Drawing.Size(550, 90)
        Me.imgLoginTitle.TabIndex = 0
        Me.imgLoginTitle.TabStop = False
        '
        'lblExplanation
        '
        Me.lblExplanation.AutoSize = True
        Me.lblExplanation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanation.Location = New System.Drawing.Point(84, 105)
        Me.lblExplanation.Name = "lblExplanation"
        Me.lblExplanation.Size = New System.Drawing.Size(405, 40)
        Me.lblExplanation.TabIndex = 1
        Me.lblExplanation.Text = "Use this system in order to save games played and wins," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and to participate in le" &
    "aderboards, Leveling and XP."
        Me.lblExplanation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.Location = New System.Drawing.Point(260, 172)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(53, 20)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Login"
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.Location = New System.Drawing.Point(248, 172)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(77, 20)
        Me.lblRegister.TabIndex = 3
        Me.lblRegister.Text = "Register"
        Me.lblRegister.Visible = False
        '
        'txtLoginUser
        '
        Me.txtLoginUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginUser.Location = New System.Drawing.Point(215, 195)
        Me.txtLoginUser.MaxLength = 16
        Me.txtLoginUser.Name = "txtLoginUser"
        Me.txtLoginUser.Size = New System.Drawing.Size(144, 26)
        Me.txtLoginUser.TabIndex = 1
        Me.txtLoginUser.Text = "Username"
        '
        'txtLoginPassword
        '
        Me.txtLoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoginPassword.Location = New System.Drawing.Point(215, 227)
        Me.txtLoginPassword.MaxLength = 32768
        Me.txtLoginPassword.Name = "txtLoginPassword"
        Me.txtLoginPassword.Size = New System.Drawing.Size(144, 26)
        Me.txtLoginPassword.TabIndex = 2
        Me.txtLoginPassword.Text = "Password"
        '
        'txtRegisterUsername
        '
        Me.txtRegisterUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterUsername.Location = New System.Drawing.Point(215, 195)
        Me.txtRegisterUsername.MaxLength = 16
        Me.txtRegisterUsername.Name = "txtRegisterUsername"
        Me.txtRegisterUsername.Size = New System.Drawing.Size(144, 26)
        Me.txtRegisterUsername.TabIndex = 1
        Me.txtRegisterUsername.Text = "Username"
        Me.txtRegisterUsername.Visible = False
        '
        'txtRegisterPassword
        '
        Me.txtRegisterPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterPassword.Location = New System.Drawing.Point(215, 227)
        Me.txtRegisterPassword.MaxLength = 32768
        Me.txtRegisterPassword.Name = "txtRegisterPassword"
        Me.txtRegisterPassword.Size = New System.Drawing.Size(144, 26)
        Me.txtRegisterPassword.TabIndex = 2
        Me.txtRegisterPassword.Text = "Password"
        Me.txtRegisterPassword.Visible = False
        '
        'txtRegisterConfirmation
        '
        Me.txtRegisterConfirmation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegisterConfirmation.Location = New System.Drawing.Point(215, 259)
        Me.txtRegisterConfirmation.MaxLength = 32768
        Me.txtRegisterConfirmation.Name = "txtRegisterConfirmation"
        Me.txtRegisterConfirmation.Size = New System.Drawing.Size(144, 26)
        Me.txtRegisterConfirmation.TabIndex = 3
        Me.txtRegisterConfirmation.Text = "Confirmation"
        Me.txtRegisterConfirmation.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(249, 259)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(76, 28)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(248, 291)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(78, 29)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        Me.btnRegister.Visible = False
        '
        'btnNoAccount
        '
        Me.btnNoAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoAccount.Location = New System.Drawing.Point(182, 343)
        Me.btnNoAccount.Name = "btnNoAccount"
        Me.btnNoAccount.Size = New System.Drawing.Size(210, 29)
        Me.btnNoAccount.TabIndex = 8
        Me.btnNoAccount.Text = "No Account? Register now!"
        Me.btnNoAccount.UseVisualStyleBackColor = True
        '
        'btnGotAccount
        '
        Me.btnGotAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGotAccount.Location = New System.Drawing.Point(182, 343)
        Me.btnGotAccount.Name = "btnGotAccount"
        Me.btnGotAccount.Size = New System.Drawing.Size(210, 29)
        Me.btnGotAccount.TabIndex = 5
        Me.btnGotAccount.Text = "Got an account? Login!"
        Me.btnGotAccount.UseVisualStyleBackColor = True
        Me.btnGotAccount.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(257, 378)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 29)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        Me.btnClose.Visible = False
        '
        'LoginRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(574, 419)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnGotAccount)
        Me.Controls.Add(Me.btnNoAccount)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtRegisterConfirmation)
        Me.Controls.Add(Me.txtRegisterPassword)
        Me.Controls.Add(Me.txtRegisterUsername)
        Me.Controls.Add(Me.txtLoginPassword)
        Me.Controls.Add(Me.txtLoginUser)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblExplanation)
        Me.Controls.Add(Me.imgLoginTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginRegister"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TopMost = True
        CType(Me.imgLoginTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imgLoginTitle As PictureBox
    Friend WithEvents lblExplanation As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblRegister As Label
    Friend WithEvents txtLoginUser As TextBox
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents txtRegisterUsername As TextBox
    Friend WithEvents txtRegisterPassword As TextBox
    Friend WithEvents txtRegisterConfirmation As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnNoAccount As Button
    Friend WithEvents btnGotAccount As Button
    Friend WithEvents btnClose As Button
End Class
