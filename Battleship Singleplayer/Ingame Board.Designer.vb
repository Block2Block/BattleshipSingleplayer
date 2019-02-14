<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingame_Board
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
        Me.flpGame = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblYour = New System.Windows.Forms.Label()
        Me.lblAI = New System.Windows.Forms.Label()
        Me.lblExplanation = New System.Windows.Forms.Label()
        Me.btnEndGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'flpGame
        '
        Me.flpGame.Location = New System.Drawing.Point(12, 85)
        Me.flpGame.Name = "flpGame"
        Me.flpGame.Size = New System.Drawing.Size(706, 353)
        Me.flpGame.TabIndex = 1
        '
        'lblYour
        '
        Me.lblYour.AutoSize = True
        Me.lblYour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYour.Location = New System.Drawing.Point(153, 62)
        Me.lblYour.Name = "lblYour"
        Me.lblYour.Size = New System.Drawing.Size(100, 20)
        Me.lblYour.TabIndex = 2
        Me.lblYour.Text = "Your Board"
        '
        'lblAI
        '
        Me.lblAI.AutoSize = True
        Me.lblAI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAI.Location = New System.Drawing.Point(495, 62)
        Me.lblAI.Name = "lblAI"
        Me.lblAI.Size = New System.Drawing.Size(93, 20)
        Me.lblAI.TabIndex = 2
        Me.lblAI.Text = "AI's Board"
        '
        'lblExplanation
        '
        Me.lblExplanation.AutoSize = True
        Me.lblExplanation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanation.Location = New System.Drawing.Point(264, 9)
        Me.lblExplanation.Name = "lblExplanation"
        Me.lblExplanation.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblExplanation.Size = New System.Drawing.Size(202, 60)
        Me.lblExplanation.TabIndex = 3
        Me.lblExplanation.Text = "Welcome to the game!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In order to choose a space," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "simply click on it!"
        Me.lblExplanation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnEndGame
        '
        Me.btnEndGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndGame.Location = New System.Drawing.Point(623, 9)
        Me.btnEndGame.Name = "btnEndGame"
        Me.btnEndGame.Size = New System.Drawing.Size(95, 28)
        Me.btnEndGame.TabIndex = 4
        Me.btnEndGame.Text = "End Game"
        Me.btnEndGame.UseVisualStyleBackColor = True
        '
        'Ingame_Board
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 450)
        Me.Controls.Add(Me.btnEndGame)
        Me.Controls.Add(Me.lblExplanation)
        Me.Controls.Add(Me.lblAI)
        Me.Controls.Add(Me.lblYour)
        Me.Controls.Add(Me.flpGame)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ingame_Board"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Board"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flpGame As FlowLayoutPanel
    Friend WithEvents lblYour As Label
    Friend WithEvents lblAI As Label
    Friend WithEvents lblExplanation As Label
    Friend WithEvents btnEndGame As Button
End Class
