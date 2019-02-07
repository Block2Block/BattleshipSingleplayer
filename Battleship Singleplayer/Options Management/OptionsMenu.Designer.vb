<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsMenu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblOptionsExplanation = New System.Windows.Forms.Label()
        Me.lblGraphicsOptions = New System.Windows.Forms.Label()
        Me.btnDarkMode = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAILevel = New System.Windows.Forms.Button()
        Me.tbrVolume = New System.Windows.Forms.TrackBar()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.btnLevelOpt = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Battleship_Singleplayer.My.Resources.Resources.cooltext314486333794288
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 89)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblOptionsExplanation
        '
        Me.lblOptionsExplanation.AutoSize = True
        Me.lblOptionsExplanation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionsExplanation.Location = New System.Drawing.Point(34, 104)
        Me.lblOptionsExplanation.Name = "lblOptionsExplanation"
        Me.lblOptionsExplanation.Size = New System.Drawing.Size(250, 60)
        Me.lblOptionsExplanation.TabIndex = 1
        Me.lblOptionsExplanation.Text = "Use this menu to change graphics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or game settings to tailor the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "program to your" &
    " needs."
        Me.lblOptionsExplanation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGraphicsOptions
        '
        Me.lblGraphicsOptions.AutoSize = True
        Me.lblGraphicsOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphicsOptions.Location = New System.Drawing.Point(85, 174)
        Me.lblGraphicsOptions.Name = "lblGraphicsOptions"
        Me.lblGraphicsOptions.Size = New System.Drawing.Size(148, 20)
        Me.lblGraphicsOptions.TabIndex = 1
        Me.lblGraphicsOptions.Text = "Graphics Options"
        Me.lblGraphicsOptions.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnDarkMode
        '
        Me.btnDarkMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDarkMode.Location = New System.Drawing.Point(77, 197)
        Me.btnDarkMode.Name = "btnDarkMode"
        Me.btnDarkMode.Size = New System.Drawing.Size(166, 28)
        Me.btnDarkMode.TabIndex = 2
        Me.btnDarkMode.Text = "Dark Mode: Disabled"
        Me.btnDarkMode.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Game Options"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAILevel
        '
        Me.btnAILevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAILevel.Location = New System.Drawing.Point(77, 275)
        Me.btnAILevel.Name = "btnAILevel"
        Me.btnAILevel.Size = New System.Drawing.Size(166, 28)
        Me.btnAILevel.TabIndex = 2
        Me.btnAILevel.Text = "AI Level: Easy"
        Me.btnAILevel.UseVisualStyleBackColor = True
        '
        'tbrVolume
        '
        Me.tbrVolume.LargeChange = 10
        Me.tbrVolume.Location = New System.Drawing.Point(77, 329)
        Me.tbrVolume.Maximum = 100
        Me.tbrVolume.Name = "tbrVolume"
        Me.tbrVolume.Size = New System.Drawing.Size(166, 45)
        Me.tbrVolume.SmallChange = 5
        Me.tbrVolume.TabIndex = 4
        Me.tbrVolume.TickFrequency = 10
        Me.tbrVolume.Value = 100
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.Location = New System.Drawing.Point(127, 306)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(63, 20)
        Me.lblVolume.TabIndex = 3
        Me.lblVolume.Text = "Volume"
        Me.lblVolume.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLevelOpt
        '
        Me.btnLevelOpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLevelOpt.Location = New System.Drawing.Point(77, 380)
        Me.btnLevelOpt.Name = "btnLevelOpt"
        Me.btnLevelOpt.Size = New System.Drawing.Size(166, 28)
        Me.btnLevelOpt.TabIndex = 2
        Me.btnLevelOpt.Text = "Level Opt: On"
        Me.btnLevelOpt.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(133, 446)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(58, 28)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'OptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 486)
        Me.Controls.Add(Me.tbrVolume)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLevelOpt)
        Me.Controls.Add(Me.btnAILevel)
        Me.Controls.Add(Me.btnDarkMode)
        Me.Controls.Add(Me.lblGraphicsOptions)
        Me.Controls.Add(Me.lblOptionsExplanation)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblOptionsExplanation As Label
    Friend WithEvents lblGraphicsOptions As Label
    Friend WithEvents btnDarkMode As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAILevel As Button
    Friend WithEvents tbrVolume As TrackBar
    Friend WithEvents lblVolume As Label
    Friend WithEvents btnLevelOpt As Button
    Friend WithEvents btnClose As Button
End Class
