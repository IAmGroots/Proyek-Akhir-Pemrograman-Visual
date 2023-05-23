Imports MySql.Data.MySqlClient

Public Class Search

    Sub clearPanel()
        For i As Integer = panelResult.Controls.Count - 1 To 0 Step -1
            Dim control As Control = panelResult.Controls(i)
            If Not TypeOf control Is Label Then
                panelResult.Controls.Remove(control)
            End If
        Next
    End Sub

    Sub readSong()
        clearPanel()
        lblSection.Text = "Trending"
        lblKeterangan.Text = "Oops, saat ini tidak ada daftar lagu"

        'SELECT * From tbsong S Join tbartist A ON S.id_artist = A.id_artist
        DA = New MySqlDataAdapter("SELECT * FROM tbsong S JOIN tbartist A ON S.id_artist = A.id_artist ORDER BY RAND() LIMIT 21", CONN)
        DS = New DataSet
        DA.Fill(DS, "lagu")
        Dim dt As DataTable = DS.Tables("lagu")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        If jmlBaris = 0 Then
            lblKeterangan.Visible = True
            panelBackgroundSection.Visible = False
        End If
        For i As Integer = 0 To jmlBaris - 1
            lblKeterangan.Visible = False
            panelBackgroundSection.Visible = True
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            Dim song As New SongCard
            With song
                .txtIdSong.Text = array(i, 0)
                .lblTitle.Text = array(i, 2)
                .lblArtist.Text = array(i, 9)
                .txtSourceSong.Text = array(i, 6)
                .pctCover.ImageLocation = PATH_COVER & array(i, 5)
            End With
            song.TopLevel = False
            panelResult.Controls.Add(song)
            song.Show()
        Next
    End Sub

    Sub searchSongs()
        clearPanel()

        Dim target As String = txtSearch.Text
        If target = "" Then
            readSong()
            Return
        End If

        lblSection.Text = "Top Result"
        'SELECT * FROM tbsong S JOIN tbartist A ON S.id_artist = A.id_artist
        CMD = New MySqlCommand("SELECT * FROM tbsong S JOIN tbartist A ON S.id_artist = A.id_artist WHERE title like '%" & target & "%' OR name like '%" & target & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("SELECT * FROM tbsong S JOIN tbartist A ON S.id_artist = A.id_artist WHERE title like '%" & target & "%' OR name like '%" & target & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "song")

            Dim dt As DataTable = DS.Tables("song")
            Dim jmlBaris As Integer = dt.Rows.Count
            Dim jmlKolom As Integer = dt.Columns.Count
            Dim array(jmlBaris - 1, jmlKolom - 1) As String
            For i As Integer = 0 To jmlBaris - 1
                lblKeterangan.Visible = False
                For j As Integer = 0 To jmlKolom - 1
                    array(i, j) = dt.Rows(i).Item(j).ToString()
                Next
                Dim song As New SongCard
                With song
                    .txtIdSong.Text = array(i, 0)
                    .lblTitle.Text = array(i, 2)
                    .lblArtist.Text = array(i, 9)
                    .txtSourceSong.Text = array(i, 6)
                    .pctCover.ImageLocation = PATH_COVER & array(i, 5)
                End With
                song.TopLevel = False
                panelResult.Controls.Add(song)
                song.Show()
            Next
        Else
            RD.Close()
            lblKeterangan.Text = "Oops, lagu tidak tersedia"
            lblKeterangan.Visible = True
        End If
        txtSearch.Text = ""
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readSong()
    End Sub

    Private Sub iconSearch_Click(sender As Object, e As EventArgs) Handles iconSearch.Click
        searchSongs()
    End Sub

    Private Sub iconRefresh_Click(sender As Object, e As EventArgs) Handles iconRefresh.Click
        txtSearch.Text = ""
        lblSection.Text = "Trending"
        lblKeterangan.Text = "Oops, saat ini tidak ada daftar lagu"
        readSong()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtSearch.Text = "" Then
                readSong()
            Else
                searchSongs()
            End If
        End If
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class