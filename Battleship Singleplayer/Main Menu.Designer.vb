<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NFCID = New System.Windows.Forms.TextBox()
        Me.ConfirmationPassword = New System.Windows.Forms.TextBox()
        Me.OUTPUT = New System.Windows.Forms.Label()
        Me.loadBattleshipLogo = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.loadBattleshipLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(277, 144)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(100, 20)
        Me.Username.TabIndex = 2
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(277, 170)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 20)
        Me.Password.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(287, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NFCID
        '
        Me.NFCID.Location = New System.Drawing.Point(277, 222)
        Me.NFCID.Name = "NFCID"
        Me.NFCID.Size = New System.Drawing.Size(100, 20)
        Me.NFCID.TabIndex = 2
        '
        'ConfirmationPassword
        '
        Me.ConfirmationPassword.Location = New System.Drawing.Point(277, 196)
        Me.ConfirmationPassword.Name = "ConfirmationPassword"
        Me.ConfirmationPassword.Size = New System.Drawing.Size(100, 20)
        Me.ConfirmationPassword.TabIndex = 2
        '
        'OUTPUT
        '
        Me.OUTPUT.AutoSize = True
        Me.OUTPUT.Location = New System.Drawing.Point(522, 196)
        Me.OUTPUT.Name = "OUTPUT"
        Me.OUTPUT.Size = New System.Drawing.Size(86, 13)
        Me.OUTPUT.TabIndex = 4
        Me.OUTPUT.Text = "PLACEHOLDER"
        '
        'loadBattleshipLogo
        '
        Me.loadBattleshipLogo.Image = Global.Battleship_Singleplayer.My.Resources.Resources.Battleship_Singleplayer
        Me.loadBattleshipLogo.Location = New System.Drawing.Point(38, 12)
        Me.loadBattleshipLogo.Name = "loadBattleshipLogo"
        Me.loadBattleshipLogo.Size = New System.Drawing.Size(720, 80)
        Me.loadBattleshipLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.loadBattleshipLogo.TabIndex = 1
        Me.loadBattleshipLogo.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(418, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Test"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OUTPUT)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NFCID)
        Me.Controls.Add(Me.ConfirmationPassword)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.loadBattleshipLogo)
        Me.Name = "Main_Menu"
        Me.Text = "Main Menu"
        CType(Me.loadBattleshipLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loadBattleshipLogo As PictureBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NFCID As TextBox
    Friend WithEvents ConfirmationPassword As TextBox
    Friend WithEvents OUTPUT As Label
    Friend WithEvents Button2 As Button
End Class
