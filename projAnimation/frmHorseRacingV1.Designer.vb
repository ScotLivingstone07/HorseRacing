<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorseRacingV1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorseRacingV1))
        Me.picHorse1 = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.tmrAutoMove = New System.Windows.Forms.Timer(Me.components)
        Me.btnClickMovement = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAuto = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        CType(Me.picHorse1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHorse1
        '
        Me.picHorse1.Image = CType(resources.GetObject("picHorse1.Image"), System.Drawing.Image)
        Me.picHorse1.InitialImage = Nothing
        Me.picHorse1.Location = New System.Drawing.Point(10, 390)
        Me.picHorse1.Name = "picHorse1"
        Me.picHorse1.Size = New System.Drawing.Size(120, 80)
        Me.picHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHorse1.TabIndex = 8
        Me.picHorse1.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(425, -65)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(100, 50)
        Me.btnRestart.TabIndex = 15
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'tmrAutoMove
        '
        Me.tmrAutoMove.Interval = 250
        '
        'btnClickMovement
        '
        Me.btnClickMovement.Location = New System.Drawing.Point(129, -65)
        Me.btnClickMovement.Name = "btnClickMovement"
        Me.btnClickMovement.Size = New System.Drawing.Size(100, 50)
        Me.btnClickMovement.TabIndex = 9
        Me.btnClickMovement.Text = "Move"
        Me.btnClickMovement.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(308, 143)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 50)
        Me.btnReset.TabIndex = 18
        Me.btnReset.Text = "Restart"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAuto
        '
        Me.btnAuto.Location = New System.Drawing.Point(162, 143)
        Me.btnAuto.Name = "btnAuto"
        Me.btnAuto.Size = New System.Drawing.Size(100, 50)
        Me.btnAuto.TabIndex = 17
        Me.btnAuto.Text = "Auto Movement"
        Me.btnAuto.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(12, 143)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(100, 50)
        Me.btnMove.TabIndex = 16
        Me.btnMove.Text = "Move"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'frmHorseRacingV1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.projAnimation.My.Resources.Resources.racecourse
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(726, 590)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAuto)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.picHorse1)
        Me.Controls.Add(Me.btnClickMovement)
        Me.Controls.Add(Me.btnRestart)
        Me.Name = "frmHorseRacingV1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHorseRacingV1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picHorse1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picHorse1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents tmrAutoMove As System.Windows.Forms.Timer
    Friend WithEvents btnClickMovement As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAuto As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
End Class
