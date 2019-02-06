<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash_Screen
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
        Me.loadBattleshipLogo = New System.Windows.Forms.PictureBox()
        Me.loadLabel = New System.Windows.Forms.Label()
        CType(Me.loadBattleshipLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loadBattleshipLogo
        '
        Me.loadBattleshipLogo.Image = Global.Battleship_Singleplayer.My.Resources.Resources.Battleship_Singleplayer
        Me.loadBattleshipLogo.Location = New System.Drawing.Point(40, 185)
        Me.loadBattleshipLogo.Name = "loadBattleshipLogo"
        Me.loadBattleshipLogo.Size = New System.Drawing.Size(720, 80)
        Me.loadBattleshipLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.loadBattleshipLogo.TabIndex = 0
        Me.loadBattleshipLogo.TabStop = False
        '
        'loadLabel
        '
        Me.loadLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.loadLabel.AutoSize = True
        Me.loadLabel.Location = New System.Drawing.Point(373, 287)
        Me.loadLabel.Name = "loadLabel"
        Me.loadLabel.Size = New System.Drawing.Size(54, 13)
        Me.loadLabel.TabIndex = 2
        Me.loadLabel.Text = "Loading..."
        Me.loadLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Splash_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.loadLabel)
        Me.Controls.Add(Me.loadBattleshipLogo)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash_Screen"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash Screen"
        Me.TopMost = True
        CType(Me.loadBattleshipLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loadBattleshipLogo As PictureBox
    Friend WithEvents loadLabel As Label
End Class
