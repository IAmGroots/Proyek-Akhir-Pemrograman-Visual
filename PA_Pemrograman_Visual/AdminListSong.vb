Imports MySql.Data.MySqlClient

Public Class AdminListSong
    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        AdminHome.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub AdminListSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SELECT * From tbsong S Join tbartist A ON S.id_artist = A.id_artist
        DA = New MySqlDataAdapter("SELECT * From tbsong S Join tbartist A ON S.id_artist = A.id_artist", CONN)
        DS = New DataSet
        DA.Fill(DS, "lagu")
        Dim dt As DataTable = DS.Tables("lagu")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        If jmlBaris = 0 Then
            lblKosong.Visible = True
        End If
        For i As Integer = 0 To jmlBaris - 1
            lblKosong.Visible = False
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            Dim song As New AdminSongCard
            With song
                .txtIdSong.Text = array(i, 0)
                .lblTitle.Text = array(i, 2)
                .lblArtist.Text = array(i, 9)
                .txtSourceSong.Text = array(i, 6)
                .pctCover.ImageLocation = PATH_COVER & array(i, 5)
            End With
            song.TopLevel = False
            panelSong.Controls.Add(song)
            song.Show()
        Next
    End Sub

    Private Sub btnAddSong_Click(sender As Object, e As EventArgs) Handles pctIconNewSong.Click, Label1.Click, btnAddSong.Click
        Dim newSong = New AdminDetailSong
        newSong.txtIdSong.Text = 0
        changeContent(newSong)
    End Sub

End Class