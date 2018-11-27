Public Class frmHorseRacingV1

    Private Sub btnClickMovement_Click(sender As Object, e As EventArgs) Handles btnMove.Click

        Dim Xcoord As Integer
        Dim Ycoord As Integer
        'Find the location of the image
        Xcoord = picHorse1.Location.X
        Ycoord = picHorse1.Location.Y
        'Move the image on by 10 pixels
        picHorse1.Location = New Point(Xcoord + 30, Ycoord)

    End Sub

    Private Sub btnAutoMovement_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        If tmrAutoMove.Enabled Then
            tmrAutoMove.Enabled = False

        Else

            tmrAutoMove.Enabled = True

        End If
    End Sub

    Private Sub tmrAutoMove_Tick(sender As Object, e As EventArgs) Handles tmrAutoMove.Tick

        ' Declare a variable holding the X co-ordinate of the image
        Dim Xcoord1, Ycoord1 As Integer

        'Find the location of the image
        Xcoord1 = picHorse1.Location.X
        Ycoord1 = picHorse1.Location.Y

        picHorse1.Location = New Point(Xcoord1 + 30, Ycoord1)
      

        If picHorse1.Location.X > (Me.Size.Width - 120) Then
            tmrAutoMove.Enabled = False

        End If

       
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'stop the timer
        tmrAutoMove.Enabled = False


        'Set the starting positions for images
        picHorse1.Location = New Point(10, 490)




    End Sub
End Class