Imports MySql.Data.MySqlClient

Public Class DetailSong
    Dim PATH_PLAY As String = CurDir() & "/gambar/Play.png"
    Dim PATH_PAUSE As String = CurDir() & "/gambar/Pause.png"
    Dim lastPosition As Double

    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        Home.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub getSong()
        Dim target As Integer = txtIdSong.Text
        'SELECT * From tbsong S Join tbartist A ON S.id_artist = A.id_artist WHERE id_song = 1
        DA = New MySqlDataAdapter("SELECT * From tbsong S Join tbartist A ON S.id_artist = A.id_artist WHERE id_song = " & target, CONN)
        DS = New DataSet
        DA.Fill(DS, "lagu")
        Dim dt As DataTable = DS.Tables("lagu")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        For i As Integer = 0 To jmlBaris - 1
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            txtTitle.Text = array(i, 2)
            txtArtist.Text = array(i, 9)
            txtGenre.Text = array(i, 3)
            txtDescription.Text = array(i, 4)
            txtSourceSong.Text = array(i, 6)
            pctCover.ImageLocation = PATH_COVER & array(i, 5)
        Next
    End Sub

    Sub getOtherSong()
        DA = New MySqlDataAdapter("SELECT * FROM tbsong S JOIN tbartist A ON S.id_artist = A.id_artist WHERE id_song != '" & txtIdSong.Text & "' ORDER BY RAND() LIMIT 10", CONN)
        DS = New DataSet
        DA.Fill(DS, "listSong")

        Dim dt As DataTable = DS.Tables("listSong")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        If jmlBaris = 0 Then
            lblKeterangan.Visible = True
        End If
        For i As Integer = 0 To jmlBaris - 1
            lblKeterangan.Visible = False
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            Dim data As New SongInPlaylist
            With data
                .txtIdSong.Text = array(i, 0)
                .lblTitle.Text = array(i, 2)
                .lblArtist.Text = array(i, 9)
                .txtSourceSong.Text = array(i, 6)
                .pctCover.ImageLocation = PATH_COVER & array(i, 5)
                .iconDelete.Visible = False
            End With
            data.TopLevel = False
            panelListSong.Controls.Add(data)
            data.Show()
        Next
    End Sub

    Sub enabledListPlaylist()
        panelListPlaylist.Visible = True
        pctIconAddPlaylist.Visible = False
    End Sub

    Sub disableListPlaylist()
        pctIconAddPlaylist.Visible = True
        panelListPlaylist.Visible = False
    End Sub

    Sub clearPanel()
        For i As Integer = panelWrapper.Controls.Count - 1 To 0 Step -1
            Dim control As Control = panelWrapper.Controls(i)
            If Not TypeOf control Is Label Then
                panelWrapper.Controls.Remove(control)
            End If
        Next
    End Sub

    Private Sub DetailSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSong()
        getOtherSong()
        disableListPlaylist()
        listKosong.Visible = False
    End Sub

    Private Sub pctIconAddPlaylist_Click(sender As Object, e As EventArgs) Handles pctIconAddPlaylist.Click
        clearPanel()

        Dim target As String = UID
        CMD = New MySqlCommand("SELECT * FROM tbplaylist WHERE uid = " & target, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("SELECT * FROM tbplaylist WHERE uid = " & target, CONN)
            DS = New DataSet
            DA.Fill(DS, "playlist")

            Dim dt As DataTable = DS.Tables("playlist")
            Dim jmlBaris As Integer = dt.Rows.Count
            Dim jmlKolom As Integer = dt.Columns.Count
            Dim array(jmlBaris - 1, jmlKolom - 1) As String
            For i As Integer = 0 To jmlBaris - 1
                listKosong.Visible = False
                For j As Integer = 0 To jmlKolom - 1
                    array(i, j) = dt.Rows(i).Item(j).ToString()
                Next
                Dim data As New ListPlaylist
                With data
                    .txtIdSong.Text = txtIdSong.Text
                    .txtIdPlaylist.Text = array(i, 0)
                    .txtTitle.Text = array(i, 2)
                    '.pctCover.ImageLocation = array(i, 4)
                End With
                data.TopLevel = False
                panelWrapper.Controls.Add(data)
                data.Show()
            Next
        Else
            RD.Close()
            listKosong.Visible = True
        End If

        enabledListPlaylist()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        disableListPlaylist()
    End Sub

    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.ForeColor = Color.White
        btnCancel.BackColor = Color.Tomato
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.ForeColor = Color.Black
        btnCancel.BackColor = Color.White
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
            Home.MediaPlayers.URL = PATH_SONG & txtSourceSong.Text
            Home.MediaPlayers.Ctlcontrols.play()
            ID_PLAYING = txtIdSong.Text
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            Home.txtTitleMediaPlayer.Text = txtTitle.Text & " - " & txtArtist.Text
            Home.AudioPanel.Visible = True

        ElseIf ID_PREVIOUS_PLAYING = txtIdSong.Text And playing = False Then
            playing = True
            Home.MediaPlayers.Ctlcontrols.currentPosition = lastPosition
            Home.MediaPlayers.Ctlcontrols.play()
            ID_PLAYING = txtIdSong.Text
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            Home.txtTitleMediaPlayer.Text = txtTitle.Text & " - " & txtArtist.Text
            Home.AudioPanel.Visible = True

        ElseIf ID_PREVIOUS_PLAYING = txtIdSong.Text And playing = True Then
            playing = False
            lastPosition = Home.MediaPlayers.Ctlcontrols.currentPosition
            Home.MediaPlayers.Ctlcontrols.pause()
            ID_PLAYING = 0
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            Home.AudioPanel.Visible = False

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ID_PLAYING = txtIdSong.Text Then
            pctIconPlayNPause.ImageLocation = PATH_PAUSE
        Else
            pctIconPlayNPause.ImageLocation = PATH_PLAY
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If LAST_MENU_USER = "Home" Then
            changeContent(New ListSong)
        ElseIf LAST_MENU_USER = "Search" Then
            changeContent(New Search)
        ElseIf LAST_MENU_USER = "Playlist" Then
            changeContent(New Playlist)
        End If
    End Sub
End Class