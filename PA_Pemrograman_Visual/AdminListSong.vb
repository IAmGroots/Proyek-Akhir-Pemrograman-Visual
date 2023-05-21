Imports MySql.Data.MySqlClient

Public Class AdminListSong
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

    Private Sub AdminListSong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        borderDeactive()
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

    Private Sub btnAddSong_MouseEnter(sender As Object, e As EventArgs) Handles pctIconNewSong.MouseEnter, panelSong.MouseEnter, Label1.MouseEnter, btnAddSong.MouseEnter
        btnAddSong.BackColor = Color.Gainsboro
        pctIconNewSong.BackColor = Color.Gainsboro
        Label1.BackColor = Color.Gainsboro
    End Sub

    Private Sub btnAddSong_MouseLeave(sender As Object, e As EventArgs) Handles pctIconNewSong.MouseLeave, panelSong.MouseLeave, Label1.MouseLeave, btnAddSong.MouseLeave
        btnAddSong.BackColor = Color.White
        pctIconNewSong.BackColor = Color.White
        Label1.BackColor = Color.White
    End Sub

    Private Sub btnAddSong_Click(sender As Object, e As EventArgs) Handles pctIconNewSong.Click, Label1.Click, btnAddSong.Click
        Dim newSong = New AdminDetailSong
        newSong.txtIdSong.Text = 0
        changeContent(newSong)
    End Sub
End Class