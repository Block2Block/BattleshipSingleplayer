<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player_Ship_Length_Selection
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
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.btnCarrier = New System.Windows.Forms.Button()
        Me.btnBattleship = New System.Windows.Forms.Button()
        Me.btnCruise = New System.Windows.Forms.Button()
        Me.btnDestroyer = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.Location = New System.Drawing.Point(12, 9)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(179, 20)
        Me.lblChoose.TabIndex = 0
        Me.lblChoose.Text = "Please choose a ship"
        '
        'btnCarrier
        '
        Me.btnCarrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarrier.Location = New System.Drawing.Point(58, 49)
        Me.btnCarrier.Name = "btnCarrier"
        Me.btnCarrier.Size = New System.Drawing.Size(87, 28)
        Me.btnCarrier.TabIndex = 1
        Me.btnCarrier.Text = "Carrier (5)"
        Me.btnCarrier.UseVisualStyleBackColor = True
        '
        'btnBattleship
        '
        Me.btnBattleship.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBattleship.Location = New System.Drawing.Point(46, 83)
        Me.btnBattleship.Name = "btnBattleship"
        Me.btnBattleship.Size = New System.Drawing.Size(111, 28)
        Me.btnBattleship.TabIndex = 1
        Me.btnBattleship.Text = "Battleship (4)"
        Me.btnBattleship.UseVisualStyleBackColor = True
        '
        'btnCruise
        '
        Me.btnCruise.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCruise.Location = New System.Drawing.Point(58, 117)
        Me.btnCruise.Name = "btnCruise"
        Me.btnCruise.Size = New System.Drawing.Size(87, 28)
        Me.btnCruise.TabIndex = 1
        Me.btnCruise.Text = "Cruise (3)"
        Me.btnCruise.UseVisualStyleBackColor = True
        '
        'btnDestroyer
        '
        Me.btnDestroyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDestroyer.Location = New System.Drawing.Point(46, 151)
        Me.btnDestroyer.Name = "btnDestroyer"
        Me.btnDestroyer.Size = New System.Drawing.Size(111, 28)
        Me.btnDestroyer.TabIndex = 1
        Me.btnDestroyer.Text = "Destroyer (2)"
        Me.btnDestroyer.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(58, 215)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Player_Ship_Length_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 255)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDestroyer)
        Me.Controls.Add(Me.btnCruise)
        Me.Controls.Add(Me.btnBattleship)
        Me.Controls.Add(Me.btnCarrier)
        Me.Controls.Add(Me.lblChoose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Player_Ship_Length_Selection"
        Me.Text = "Ship Length Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChoose As Label
    Friend WithEvents btnCarrier As Button
    Friend WithEvents btnBattleship As Button
    Friend WithEvents btnCruise As Button
    Friend WithEvents btnDestroyer As Button
    Friend WithEvents btnCancel As Button
End Class
