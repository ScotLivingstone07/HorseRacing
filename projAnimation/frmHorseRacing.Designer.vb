<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHorseRacing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHorseRacing))
        Me.picHorse1 = New System.Windows.Forms.PictureBox()
        Me.btnClickMovement = New System.Windows.Forms.Button()
        Me.btnAutoMovement = New System.Windows.Forms.Button()
        Me.tmrAutoMove = New System.Windows.Forms.Timer(Me.components)
        Me.picHorse2 = New System.Windows.Forms.PictureBox()
        Me.picHorse3 = New System.Windows.Forms.PictureBox()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.picHorse4 = New System.Windows.Forms.PictureBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.rdoSoundOn = New System.Windows.Forms.RadioButton()
        Me.rdoSoundOff = New System.Windows.Forms.RadioButton()
        Me.tmrStartingPost = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.picHorse1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHorse2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHorse3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHorse4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picHorse1
        '
        Me.picHorse1.Image = CType(resources.GetObject("picHorse1.Image"), System.Drawing.Image)
        Me.picHorse1.InitialImage = Nothing
        Me.picHorse1.Location = New System.Drawing.Point(10, 10)
        Me.picHorse1.Name = "picHorse1"
        Me.picHorse1.Size = New System.Drawing.Size(101, 60)
        Me.picHorse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHorse1.TabIndex = 0
        Me.picHorse1.TabStop = False
        '
        'btnClickMovement
        '
        Me.btnClickMovement.Location = New System.Drawing.Point(50, 150)
        Me.btnClickMovement.Name = "btnClickMovement"
        Me.btnClickMovement.Size = New System.Drawing.Size(100, 50)
        Me.btnClickMovement.TabIndex = 1
        Me.btnClickMovement.Text = "Move"
        Me.btnClickMovement.UseVisualStyleBackColor = True
        '
        'btnAutoMovement
        '
        Me.btnAutoMovement.Location = New System.Drawing.Point(200, 150)
        Me.btnAutoMovement.Name = "btnAutoMovement"
        Me.btnAutoMovement.Size = New System.Drawing.Size(100, 50)
        Me.btnAutoMovement.TabIndex = 2
        Me.btnAutoMovement.Text = "Auto Movement"
        Me.btnAutoMovement.UseVisualStyleBackColor = True
        '
        'tmrAutoMove
        '
        Me.tmrAutoMove.Interval = 250
        '
        'picHorse2
        '
        Me.picHorse2.Image = Global.projAnimation.My.Resources.Resources.bluehorse
        Me.picHorse2.InitialImage = Nothing
        Me.picHorse2.Location = New System.Drawing.Point(10, 174)
        Me.picHorse2.Name = "picHorse2"
        Me.picHorse2.Size = New System.Drawing.Size(101, 60)
        Me.picHorse2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHorse2.TabIndex = 3
        Me.picHorse2.TabStop = False
        '
        'picHorse3
        '
        Me.picHorse3.Image = Global.projAnimation.My.Resources.Resources.yellowhorse
        Me.picHorse3.InitialImage = Nothing
        Me.picHorse3.Location = New System.Drawing.Point(10, 92)
        Me.picHorse3.Name = "picHorse3"
        Me.picHorse3.Size = New System.Drawing.Size(101, 60)
        Me.picHorse3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHorse3.TabIndex = 4
        Me.picHorse3.TabStop = False
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.BackColor = System.Drawing.Color.Transparent
        Me.lblWinner.Font = New System.Drawing.Font("Impact", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.ForeColor = System.Drawing.Color.Red
        Me.lblWinner.Location = New System.Drawing.Point(336, 160)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(135, 45)
        Me.lblWinner.TabIndex = 5
        Me.lblWinner.Text = "Winner"
        Me.lblWinner.Visible = False
        '
        'picHorse4
        '
        Me.picHorse4.Image = Global.projAnimation.My.Resources.Resources.redhorse
        Me.picHorse4.InitialImage = Nothing
        Me.picHorse4.Location = New System.Drawing.Point(10, 256)
        Me.picHorse4.Name = "picHorse4"
        Me.picHorse4.Size = New System.Drawing.Size(101, 60)
        Me.picHorse4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHorse4.TabIndex = 6
        Me.picHorse4.TabStop = False
        '
        'btnRestart
        '
        Me.btnRestart.Location = New System.Drawing.Point(346, 150)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(100, 50)
        Me.btnRestart.TabIndex = 7
        Me.btnRestart.Text = "Restart"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'rdoSoundOn
        '
        Me.rdoSoundOn.AutoSize = True
        Me.rdoSoundOn.Checked = True
        Me.rdoSoundOn.Location = New System.Drawing.Point(63, 224)
        Me.rdoSoundOn.Name = "rdoSoundOn"
        Me.rdoSoundOn.Size = New System.Drawing.Size(73, 17)
        Me.rdoSoundOn.TabIndex = 1
        Me.rdoSoundOn.TabStop = True
        Me.rdoSoundOn.Text = "Sound On"
        Me.rdoSoundOn.UseVisualStyleBackColor = True
        '
        'rdoSoundOff
        '
        Me.rdoSoundOff.AutoSize = True
        Me.rdoSoundOff.Location = New System.Drawing.Point(168, 224)
        Me.rdoSoundOff.Name = "rdoSoundOff"
        Me.rdoSoundOff.Size = New System.Drawing.Size(73, 17)
        Me.rdoSoundOff.TabIndex = 9
        Me.rdoSoundOff.Text = "Sound Off"
        Me.rdoSoundOff.UseVisualStyleBackColor = True
        '
        'tmrStartingPost
        '
        Me.tmrStartingPost.Interval = 20000
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblWinner)
        Me.Panel1.Controls.Add(Me.picHorse1)
        Me.Panel1.Controls.Add(Me.picHorse3)
        Me.Panel1.Controls.Add(Me.picHorse4)
        Me.Panel1.Controls.Add(Me.picHorse2)
        Me.Panel1.Location = New System.Drawing.Point(0, 396)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 319)
        Me.Panel1.TabIndex = 10
        '
        'frmHorseRacing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(778, 812)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rdoSoundOff)
        Me.Controls.Add(Me.rdoSoundOn)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.btnAutoMovement)
        Me.Controls.Add(Me.btnClickMovement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmHorseRacing"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horse Racing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picHorse1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHorse2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHorse3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHorse4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picHorse1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnClickMovement As System.Windows.Forms.Button
    Friend WithEvents btnAutoMovement As System.Windows.Forms.Button
    Friend WithEvents tmrAutoMove As System.Windows.Forms.Timer
    Friend WithEvents picHorse2 As System.Windows.Forms.PictureBox
    Friend WithEvents picHorse3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblWinner As System.Windows.Forms.Label
    Friend WithEvents picHorse4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents rdoSoundOn As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSoundOff As System.Windows.Forms.RadioButton
    Friend WithEvents tmrStartingPost As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
