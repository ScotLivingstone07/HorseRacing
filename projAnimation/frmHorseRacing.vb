Public Class frmHorseRacing
    Dim myPlayer As New System.Media.SoundPlayer()
    Dim bolUp As Boolean

    Private Sub frmHorseRacing_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim width As New System.Drawing.Point(Me.Size.Width, 370)
        Panel1.Size = width
        lblWinner.Location = New System.Drawing.Point((Panel1.Size.Width / 2) - 180, (Panel1.Size.Height / 2) - 20)

    End Sub

    Private Sub btnClickMovement_Click(sender As Object, e As EventArgs) Handles btnClickMovement.Click

        Dim Xcoord As Integer
        Dim Ycoord As Integer
        'Find the location of the image
        Xcoord = picHorse1.Location.X
        Ycoord = picHorse1.Location.Y
        'Move the image on by 10 pixels
        picHorse1.Location = New Point(Xcoord + 30, Ycoord)

    End Sub

    Private Sub btnAutoMovement_Click(sender As Object, e As EventArgs) Handles btnAutoMovement.Click
        If tmrAutoMove.Enabled Then
            tmrAutoMove.Enabled = False
            myPlayer.Stop()
        Else
            lblWinner.Visible = False
            tmrStartingPost.Enabled = True
            playStartingPost()
            bolUp = False
        End If

    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click

        'stop the media player
        myPlayer.Stop()
        'stop the timer
        tmrAutoMove.Enabled = False
        'Set the starting positions for images
        picHorse1.Location = New Point(10, 10)
        picHorse2.Location = New Point(10, 100)
        picHorse3.Location = New Point(10, 190)
        picHorse4.Location = New Point(10, 280)
        'Hide winner label
        lblWinner.Visible = False

    End Sub

    Private Sub rdoSoundOff_Click(sender As Object, e As EventArgs) Handles rdoSoundOff.Click

        myPlayer.Stop()

    End Sub

    Private Sub rdoSoundOn_Click(sender As Object, e As EventArgs) Handles rdoSoundOn.Click

        myPlayer.Play()

    End Sub

    Private Sub tmrStartingPost_Tick(sender As Object, e As EventArgs) Handles tmrStartingPost.Tick

        myPlayer.Stop()
        tmrAutoMove.Enabled = True
        tmrStartingPost.Enabled = False
        playGallop()

    End Sub

    Private Sub tmrAutoMove_Tick(sender As Object, e As EventArgs) Handles tmrAutoMove.Tick

        ' Declare a variable holding the X co-ordinate of the image
        Dim Xcoord, Ycoord As Integer

        'Find the location of the image
        Xcoord = picHorse1.Location.X
        Ycoord = picHorse1.Location.Y

        If rdoSoundOff.Checked Then
            myPlayer.Stop()
        End If

        picHorse1.Location = New Point(Xcoord + GetRndNum(), Ycoord + Gallop())
        If picHorse1.Location.X > (Panel1.Size.Width - 172) Then
            tmrAutoMove.Enabled = False
            lblWinner.Text = "The Black Horse Wins!!"
            lblWinner.Visible = True
            playEnd()
        End If

        'Find the location of the image
        Xcoord = picHorse2.Location.X
        Ycoord = picHorse2.Location.Y

        picHorse2.Location = New Point(Xcoord + GetRndNum(), Ycoord + Gallop())

        If picHorse2.Location.X > (Panel1.Size.Width - 172) Then
            tmrAutoMove.Enabled = False
            lblWinner.Text = "The Blue Horse Wins!!"
            lblWinner.Visible = True
            playEnd()
        End If

        'Find the location of the image
        Xcoord = picHorse3.Location.X
        Ycoord = picHorse3.Location.Y

        picHorse3.Location = New Point(Xcoord + GetRndNum(), Ycoord - Gallop())

        If picHorse3.Location.X > (Panel1.Size.Width - 172) Then
            tmrAutoMove.Enabled = False
            lblWinner.Text = "The Yellow Horse Wins!!"
            lblWinner.Visible = True
            playEnd()
        End If

        'Find the location of the image
        Xcoord = picHorse4.Location.X
        Ycoord = picHorse4.Location.Y
        picHorse4.Location = New Point(Xcoord + GetRndNum(), Ycoord + Gallop())

        If picHorse4.Location.X > (Panel1.Size.Width - 172) Then
            tmrAutoMove.Enabled = False
            lblWinner.Text = "The Red Horse Wins!!"
            lblWinner.Visible = True
            playEnd()
        End If

        If bolUp Then
            bolUp = False
        Else
            bolUp = True
        End If
    End Sub

    Private Sub playGallop()

        myPlayer = New System.Media.SoundPlayer(My.Resources.horsegallop)
        If rdoSoundOn.Checked Then
            myPlayer.PlayLooping()
        End If

    End Sub
    Private Sub playStartingPost()

        myPlayer = New System.Media.SoundPlayer(My.Resources.StartingPost)
        If rdoSoundOn.Checked Then
            myPlayer.Play()
        End If

    End Sub
    Private Sub playEnd()

        myPlayer = New System.Media.SoundPlayer(My.Resources.endOfHorseRace)
        If rdoSoundOn.Checked Then
            myPlayer.Play()
        End If

    End Sub

    Public Function GetRndNum()
        Dim intRandom As Integer
        'Initialise the random number generator
        Randomize()
        'To output a random number within a range, use the following formulae:
        'randomvalue = CInt(Int((upperbound - lowerbound + 1) * Rnd() + lowerbound))
        intRandom = Int((50 - 5 + 1) * Rnd() + 5)
        Return intRandom
    End Function
    Private Function Gallop() As Integer
        If bolUp Then
            Return -5
        Else
            Return 5
        End If
    End Function

End Class
