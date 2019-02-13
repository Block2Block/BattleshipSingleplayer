<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.loadBattleshipLogo = New System.Windows.Forms.PictureBox()
        Me.lblMenuExplanation = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.pgbXP = New System.Windows.Forms.ProgressBar()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.loadBattleshipLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loadBattleshipLogo
        '
        Me.loadBattleshipLogo.Image = Global.Battleship_Singleplayer.My.Resources.Resources.Battleship_Singleplayer
        Me.loadBattleshipLogo.Location = New System.Drawing.Point(12, 12)
        Me.loadBattleshipLogo.Name = "loadBattleshipLogo"
        Me.loadBattleshipLogo.Size = New System.Drawing.Size(720, 80)
        Me.loadBattleshipLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.loadBattleshipLogo.TabIndex = 1
        Me.loadBattleshipLogo.TabStop = False
        '
        'lblMenuExplanation
        '
        Me.lblMenuExplanation.AutoSize = True
        Me.lblMenuExplanation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenuExplanation.Location = New System.Drawing.Point(241, 95)
        Me.lblMenuExplanation.Name = "lblMenuExplanation"
        Me.lblMenuExplanation.Size = New System.Drawing.Size(262, 40)
        Me.lblMenuExplanation.TabIndex = 2
        Me.lblMenuExplanation.Text = "Welcome to Battleship Singleplayer!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "To begin, select an option below!"
        Me.lblMenuExplanation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(334, 170)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(76, 28)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(334, 204)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(76, 28)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'pgbXP
        '
        Me.pgbXP.Location = New System.Drawing.Point(187, 357)
        Me.pgbXP.Name = "pgbXP"
        Me.pgbXP.Size = New System.Drawing.Size(370, 23)
        Me.pgbXP.Step = 1
        Me.pgbXP.TabIndex = 4
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(231, 334)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(281, 20)
        Me.lblLevel.TabIndex = 5
        Me.lblLevel.Text = "Log in to see your Level progress here."
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(334, 238)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(76, 28)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(334, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 28)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(744, 392)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.pgbXP)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblMenuExplanation)
        Me.Controls.Add(Me.loadBattleshipLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.loadBattleshipLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loadBattleshipLogo As PictureBox
    Friend WithEvents lblMenuExplanation As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents pgbXP As ProgressBar
    Friend WithEvents lblLevel As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
End Class
