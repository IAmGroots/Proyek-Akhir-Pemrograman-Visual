Public Class SongCard
    Dim PATH_PLAY As String = CurDir() & "/gambar/Play.png"
    Dim PATH_PAUSE As String = CurDir() & "/gambar/Pause.png"
    Dim lastPosition As Double
    Private Sub SongCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles pctCover.Click
        If ID_PREVIOUS_PLAYING <> txtIdSong.Text Then
            playing = True
            Home.MediaPlayers.URL = PATH_SONG & txtSourceSong.Text
            Home.MediaPlayers.Ctlcontrols.play()
            ID_PLAYING = txtIdSong.Text
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            PictureBox1.ImageLocation = PATH_PLAY
            Home.txtTitleMediaPlayer.Text = lblTitle.Text & " - " & lblArtist.Text
            Home.AudioPanel.Visible = True

        ElseIf ID_PREVIOUS_PLAYING = txtIdSong.Text And playing = False Then
            playing = True
            Home.MediaPlayers.Ctlcontrols.currentPosition = lastPosition
            Home.MediaPlayers.Ctlcontrols.play()
            ID_PLAYING = txtIdSong.Text
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            PictureBox1.ImageLocation = PATH_PLAY
            Home.txtTitleMediaPlayer.Text = lblTitle.Text & " - " & lblArtist.Text
            Home.AudioPanel.Visible = True

        ElseIf ID_PREVIOUS_PLAYING = txtIdSong.Text And playing = True Then
            playing = False
            lastPosition = Home.MediaPlayers.Ctlcontrols.currentPosition
            Home.MediaPlayers.Ctlcontrols.pause()
            ID_PLAYING = 0
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            PictureBox1.ImageLocation = PATH_PAUSE
            Home.AudioPanel.Visible = False

        End If
    End Sub

    Private Sub timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ID_PLAYING = txtIdSong.Text Then
            PictureBox1.ImageLocation = PATH_PAUSE
        Else
            PictureBox1.ImageLocation = PATH_PLAY
        End If
    End Sub

    Private Sub pctCover_MouseEnter(sender As Object, e As EventArgs) Handles pctCover.MouseEnter
        PictureBox1.Visible = True
    End Sub

    Private Sub pctCover_MouseLeave(sender As Object, e As EventArgs) Handles pctCover.MouseLeave
        PictureBox1.Visible = False
    End Sub
End Class