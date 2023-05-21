Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AdminDetailSong
    Dim PATH_PLAY As String = CurDir() & "/gambar/Play.png"
    Dim PATH_PAUSE As String = CurDir() & "/gambar/Pause.png"
    Dim PATH_ICON_TRUE As String = CurDir() & "/gambar/True.png"
    Dim PATH_ICON_FALSE As String = CurDir() & "/gambar/False.png"
    Dim lastPosition As Double

    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        AdminHome.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub getSong()
        Dim target As Integer = txtIdSong.Text
        If target = 0 Then
            txtTitle.Text = "New Song"
            txtArtist.Text = ""
            txtGenre.Text = ""
            txtDescription.Text = ""
            pctCover.ImageLocation = PATH_COVER & "defaultPlaylist.png"
            fileCover.Text = "defaultPlaylist.png"
            fileSource.Text = ""
            LabelUpdateAt.Visible = False
            txtUpdate_at.Visible = False
            pctIconDelete.Visible = False
            Return
        End If
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
            LabelUpdateAt.Visible = True
            txtUpdate_at.Visible = True
            pctIconDelete.Visible = True
            txtTitle.Text = array(i, 2)
            txtArtist.Text = array(i, 9)
            txtGenre.Text = array(i, 3)
            txtDescription.Text = array(i, 4)
            txtSourceSong.Text = array(i, 6)
            fileSource.Text = array(i, 6)
            pctCover.ImageLocation = PATH_COVER & array(i, 5)
            fileCover.Text = array(i, 5)
            Dim update_at As DateTime = array(i, 7)
            txtUpdate_at.Text = update_at.ToString("yyyy/MM/dd")
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
            Dim data As New AdminSongCard
            With data
                .txtIdSong.Text = array(i, 0)
                .lblTitle.Text = array(i, 2)
                .lblArtist.Text = array(i, 9)
                .txtSourceSong.Text = array(i, 6)
                .pctCover.ImageLocation = PATH_COVER & array(i, 5)
            End With
            data.TopLevel = False
            panelListSong.Controls.Add(data)
            data.Show()
        Next
    End Sub

    Sub getArtist()
        DA = New MySqlDataAdapter("SELECT * FROM tbartist", CONN)
        DS = New DataSet
        DA.Fill(DS, "listArtist")

        Dim dt As DataTable = DS.Tables("listArtist")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        For i As Integer = 0 To jmlBaris - 1
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            cmbArtist.Items.Add(array(i, 1))
        Next

        Dim targetArtist = txtArtist.Text
        Dim indexTarget As Integer = -1
        For index As Integer = 0 To cmbArtist.Items.Count - 1
            If cmbArtist.Items(index).ToString() = targetArtist Then
                indexTarget = index
                Exit For
            End If
        Next
        If indexTarget = -1 Then
            cmbArtist.SelectedIndex = 0
        Else
            cmbArtist.SelectedIndex = indexTarget
        End If
    End Sub

    Function getIDArtist(ByVal name As String)
        DA = New MySqlDataAdapter("SELECT * FROM tbartist A WHERE A.name = '" & name & "'", CONN)
        DS = New DataSet
        DA.Fill(DS, "artist")
        Dim dt As DataTable = DS.Tables("artist")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        Dim id As Integer
        For i As Integer = 0 To jmlBaris - 1
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            id = array(i, 0)
        Next
        Return id
    End Function

    Private Sub DetailSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getSong()
        getArtist()
        getOtherSong()
        pctIconSave.Focus()
        pctIconPlayNPause.Visible = False
    End Sub

    Private Sub pctCover_MouseEnter(sender As Object, e As EventArgs) Handles pctCover.MouseEnter
        If txtIdSong.Text = 0 Then
            Return
        End If
        pctIconPlayNPause.Visible = True
    End Sub

    Private Sub pctCover_MouseLeave(sender As Object, e As EventArgs) Handles pctCover.MouseLeave
        If txtIdSong.Text = 0 Then
            Return
        End If
        pctIconPlayNPause.Visible = False
    End Sub

    Private Sub pctCover_Click(sender As Object, e As EventArgs) Handles pctCover.Click
        If txtIdSong.Text = 0 Then
            Return
        End If
        If ID_PREVIOUS_PLAYING <> txtIdSong.Text Then
            playing = True
            AdminHome.MediaPlayers.URL = PATH_SONG & txtSourceSong.Text
            AdminHome.MediaPlayers.Ctlcontrols.play()
            ID_PLAYING = txtIdSong.Text
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            AdminHome.txtTitleMediaPlayer.Text = txtTitle.Text & " - " & cmbArtist.Text
            AdminHome.AudioPanel.Visible = True

        ElseIf ID_PREVIOUS_PLAYING = txtIdSong.Text And playing = False Then
            playing = True
            AdminHome.MediaPlayers.URL = PATH_SONG & txtSourceSong.Text
            AdminHome.MediaPlayers.Ctlcontrols.currentPosition = lastPosition
            AdminHome.MediaPlayers.Ctlcontrols.play()
            ID_PLAYING = txtIdSong.Text
            ID_PREVIOUS_PLAYING = txtIdSong.Text
            AdminHome.txtTitleMediaPlayer.Text = txtTitle.Text & " - " & cmbArtist.Text
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ID_PLAYING = txtIdSong.Text Then
            pctIconPlayNPause.ImageLocation = PATH_PAUSE
        Else
            pctIconPlayNPause.ImageLocation = PATH_PLAY
        End If

        If txtTitle.Text = "" Then
            iconTitle.ImageLocation = PATH_ICON_FALSE
        Else
            iconTitle.ImageLocation = PATH_ICON_TRUE
        End If

        If txtGenre.Text = "" Then
            iconGenre.ImageLocation = PATH_ICON_FALSE
        Else
            iconGenre.ImageLocation = PATH_ICON_TRUE
        End If

        If txtDescription.Text = "" Then
            iconDescription.ImageLocation = PATH_ICON_FALSE
        Else
            iconDescription.ImageLocation = PATH_ICON_TRUE
        End If

        If fileCover.Text = "" Then
            iconFileCover.ImageLocation = PATH_ICON_FALSE
        Else
            iconFileCover.ImageLocation = PATH_ICON_TRUE
        End If

        If fileSource.Text = "" Then
            iconFileSong.ImageLocation = PATH_ICON_FALSE
        Else
            iconFileSong.ImageLocation = PATH_ICON_TRUE
        End If
    End Sub

    Private Sub btnFileCover_Click(sender As Object, e As EventArgs) Handles btnFileCover.Click
        OpenFileDialogCover.FileName = ""
        OpenFileDialogCover.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png"
        If OpenFileDialogCover.ShowDialog = DialogResult.OK Then
            Dim lokasiAsal As String = OpenFileDialogCover.FileName
            Dim namaFile As String = Path.GetFileName(lokasiAsal)
            Dim lokasiTujuan As String = Path.Combine(PATH_COVER, namaFile)
            pctCover.Image = Image.FromFile(lokasiAsal)
            File.Copy(lokasiAsal, lokasiTujuan, True)
            fileCover.Text = namaFile
            MsgBox("OK")
        End If
    End Sub

    Private Sub btnFileSong_Click(sender As Object, e As EventArgs) Handles btnFileSong.Click
        OpenFileDialogSong.FileName = ""
        OpenFileDialogSong.Filter = "MP3 Files (*.mp3)|*.mp3"
        If OpenFileDialogSong.ShowDialog = DialogResult.OK Then
            Dim lokasiAsal As String = OpenFileDialogSong.FileName
            Dim namaFile As String = Path.GetFileName(lokasiAsal)
            Dim lokasiTujuan As String = Path.Combine(PATH_SONG, namaFile)
            File.Copy(lokasiAsal, lokasiTujuan, True)
            fileSource.Text = namaFile
            MsgBox("OK")
        End If
    End Sub

    Private Sub pctIconSave_Click(sender As Object, e As EventArgs) Handles pctIconSave.Click
        If txtTitle.Text = "" Or txtGenre.Text = "" Or txtDescription.Text = "" Or fileSource.Text = "" Then
            Return
        End If

        If txtIdSong.Text = 0 Then
            Dim id_artist As Integer = getIDArtist(cmbArtist.SelectedItem)
            Dim title As String = txtTitle.Text
            Dim genre As String = txtGenre.Text
            Dim desc As String = txtDescription.Text
            Dim cover As String = fileCover.Text
            Dim source As String = fileSource.Text
            Dim dateNow As DateTime = DateTime.Now
            Dim update_at As String = dateNow.ToString("yyyy/MM/dd")

            'INSERT INTO `tbsong` (`id_song`, `id_artist`, `title`, `genre`, `description`, `cover`, `source`, `update_at`) VALUES (NULL, '3', 'Test', 'test', 'test', 'test.png', 'test.mp3', '2023-05-03')
            Dim query As String = "INSERT INTO tbsong(id_song, id_artist, title, genre, description, cover, source, update_at) VALUES (NULL, '" & id_artist & "', '" & title & "', '" & genre & "', '" & desc & "', '" & cover & "', '" & source & "', '" & update_at & "')"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Ditambah")
            changeContent(New AdminListSong)

        Else
            Dim id_song As Integer = txtIdSong.Text
            Dim id_artist As Integer = getIDArtist(cmbArtist.SelectedItem)
            Dim title As String = txtTitle.Text
            Dim genre As String = txtGenre.Text
            Dim desc As String = txtDescription.Text
            Dim cover As String = fileCover.Text
            Dim source As String = fileSource.Text
            Dim dateNow As DateTime = DateTime.Now
            Dim update_at As String = dateNow.ToString("yyyy/MM/dd")

            'UPDATE `tbsong` SET `id_artist` = '2', `title` = 'Test1', `genre` = 'test1', `description` = 'test1', `cover` = 'test1.png', `source` = 'test1.mp3', `update_at` = '2023-05-04' WHERE `id_song` = 10
            Dim query As String = "UPDATE tbsong SET id_artist = '" & id_artist & "', title = '" & title & "', genre = '" & genre & "', description = '" & desc & "', cover = '" & cover & "', source = '" & source & "', update_at = '" & update_at & "' WHERE id_song = " & id_song
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Diubah")
            Dim detail = New AdminDetailSong
            detail.txtIdSong.Text = txtIdSong.Text
            changeContent(detail)
        End If
    End Sub

    Private Sub pctIconDelete_Click(sender As Object, e As EventArgs) Handles pctIconDelete.Click
        'DELETE FROM tbsong WHERE id_song = 1
        Dim query As String = "DELETE FROM tbsong WHERE id_song = " & txtIdSong.Text
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Dihapus")
        changeContent(New AdminListSong)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If LAST_MENU_ADMIN = "Song" Then
            changeContent(New AdminListSong)
        ElseIf LAST_MENU_ADMIN = "Artist" Then
            changeContent(New AdminListArtist)
        End If
    End Sub
End Class