Public Class AdminSongCard
    Dim PATH_PLAY As String = CurDir() & "/gambar/Play.png"
    Dim PATH_PAUSE As String = CurDir() & "/gambar/Pause.png"
    Dim lastPosition As Double

    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        AdminHome.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub borderActive()
        atas.Visible = True
        kanan.Visible = True
        bawah.Visible = True
        kiri.Visible = True
    End Sub

    Sub borderDeactive()
        atas.Visible = False
        kanan.Visible = False
        bawah.Visible = False
        kiri.Visible = False
    End Sub

    Private Sub SongCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pctIconPlayNPause.Visible = False
        borderDeactive()
    End Sub

    Private Sub timer1_tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ID_PLAYING = txtIdSong.Text Then
            pctIconPlayNPause.ImageLocation = PATH_PAUSE
            borderActive()
        Else
            pctIconPlayNPause.ImageLocation = PATH_PLAY
            borderDeactive()
        End If
    End Sub

    Private Sub pctCover_MouseEnter(sender As Object, e As EventArgs) Handles pctCover.MouseEnter
        pctIconPlayNPause.Visible = True
    End Sub

    Private Sub pctCover_MouseLeave(sender As Object, e As EventArgs) Handles pctCover.MouseLeave
        pctIconPlayNPause.Visible = False
    End Sub

    Private Sub pctCover_Click(sender As Object, e As EventArgs) Handles pctCover.Click
        If ID_PREVIOUS_PLAYING <> txtIdSong.Text Then
            playing = True
            AdminHome.MediaPlayers.URL = PATH_SONG & txtSourceSong.Text
            AdminHome.MediaPlayers.Ctlcontrols.play()
            ID_PLAYING = txtIdSong.Text
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            AdminHome.txtTitleMediaPlayer.Text = lblTitle.Text & " - " & lblArtist.Text
            AdminHome.AudioPanel.Visible = True

        ElseIf ID_PREVIOUS_PLAYING = txtIdSong.Text And playing = False Then
            playing = True
            AdminHome.MediaPlayers.Ctlcontrols.currentPosition = lastPosition
            AdminHome.MediaPlayers.Ctlcontrols.play()
            ID_PLAYING = txtIdSong.Text
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            AdminHome.txtTitleMediaPlayer.Text = lblTitle.Text & " - " & lblArtist.Text
            AdminHome.AudioPanel.Visible = True

        ElseIf ID_PREVIOUS_PLAYING = txtIdSong.Text And playing = True Then
            playing = False
            lastPosition = AdminHome.MediaPlayers.Ctlcontrols.currentPosition
            AdminHome.MediaPlayers.Ctlcontrols.pause()
            ID_PLAYING = 0
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            AdminHome.AudioPanel.Visible = False

        End If
    End Sub

    Private Sub lblTitle_MouseEnter(sender As Object, e As EventArgs) Handles lblTitle.MouseEnter
        lblTitle.ForeColor = Color.Blue
    End Sub

    Private Sub lblTitle_MouseLeave(sender As Object, e As EventArgs) Handles lblTitle.MouseLeave
        lblTitle.ForeColor = Color.Black
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        Dim detail = New AdminDetailSong
        detail.txtIdSong.Text = txtIdSong.Text
        changeContent(detail)
    End Sub
End Class