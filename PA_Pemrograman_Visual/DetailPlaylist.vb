Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.ConstrainedExecution
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class DetailPlaylist
    Dim PATH_ICON_TRUE As String = CurDir() & "/gambar/True.png"
    Dim PATH_ICON_FALSE As String = CurDir() & "/gambar/False.png"

    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        Home.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub getDetailPlaylist()
        Dim target As Integer = UID
        Dim id As Integer = txtIdPlaylist.Text
        DA = New MySqlDataAdapter("SELECT * FROM tbplaylist WHERE uid = " & target & " AND id_playlist = " & id, CONN)
        DS = New DataSet
        DA.Fill(DS, "playlist")

        Dim dt As DataTable = DS.Tables("playlist")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        For i As Integer = 0 To jmlBaris - 1
            lblKeterangan.Visible = False
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            txtIdPlaylist.Text = array(i, 0)
            txtTitle.Text = array(i, 2)
            txtDescription.Text = array(i, 3)
            pctCover.ImageLocation = PATH_COVER & array(i, 4)
            txtCover.Text = array(i, 4)
        Next
    End Sub

    Sub getOtherSong()
        'SELECT * FROM tbplaylist_song PS JOIN tbsong S ON PS.id_song = S.id_song JOIN tbartist A ON S.id_artist = A.id_artist WHERE PS.id_playlist = 1
        Dim target As Integer = txtIdPlaylist.Text
        DA = New MySqlDataAdapter("SELECT * FROM tbplaylist_song PS JOIN tbsong S ON PS.id_song = S.id_song JOIN tbartist A ON S.id_artist = A.id_artist WHERE PS.id_playlist = " & target, CONN)
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
                .txtIdSong.Text = array(i, 1)
                .txtIdPlaylist.Text = array(i, 0)
                .lblTitle.Text = array(i, 4)
                .lblArtist.Text = array(i, 11)
                .txtSourceSong.Text = array(i, 8)
                .pctCover.ImageLocation = PATH_COVER & array(i, 7)
            End With
            data.TopLevel = False
            panelListSong.Controls.Add(data)
            data.Show()
        Next
    End Sub

    Private Sub DetailPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pctIconSave.Focus()
        txtTitle.BorderStyle = BorderStyle.None
        txtDescription.BorderStyle = BorderStyle.None
        iconTitle.Visible = False
        getDetailPlaylist()
        getOtherSong()
    End Sub

    Private Sub pctIconSave_Click(sender As Object, e As EventArgs) Handles pctIconSave.Click
        If txtTitle.Text = "" Then
            Return
        End If
        Dim id_playlist As Integer = txtIdPlaylist.Text
        Dim newName As String = txtTitle.Text
        Dim newDescription As String = txtDescription.Text
        Dim newCover As String = txtCover.Text '"defaultPlaylist.png"
        Dim query As String = "UPDATE tbplaylist SET name = '" & newName & "', description = '" & newDescription & "', cover = '" & newCover & "' WHERE id_playlist = " & id_playlist
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Berhasil Mengubah Data Playlist", MsgBoxStyle.Information, "Pemberitahuan")
        Dim detail = New DetailPlaylist
        detail.txtIdPlaylist.Text = txtIdPlaylist.Text
        changeContent(detail)
    End Sub

    Private Sub pctIconDelete_Click(sender As Object, e As EventArgs) Handles pctIconDelete.Click
        Dim id_playlist As Integer = txtIdPlaylist.Text
        Dim query As String = "DELETE FROM tbplaylist WHERE id_playlist = " & id_playlist
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Playlist", MsgBoxStyle.Information, "Pemberitahuan")
        changeContent(New Playlist)
        Home.AudioPanel.Visible = False
        Home.MediaPlayers.Ctlcontrols.stop()
    End Sub

    Private Sub pctCover_Click(sender As Object, e As EventArgs) Handles pctCover.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim lokasiAsal As String = OpenFileDialog1.FileName
            Dim namaFile As String = Path.GetFileName(lokasiAsal)
            Dim lokasiTujuan As String = Path.Combine(PATH_COVER, namaFile)

            'Jika ingin tidak ada cover yang sama/duplikat cukup aktifkan code dibawah ini saja
            'DA = New MySqlDataAdapter("Select * From tbPlaylist", CONN)
            'DS = New DataSet
            'DA.Fill(DS, "playlist")

            'Dim dt As DataTable = DS.Tables("playlist")
            'Dim jmlBaris As Integer = dt.Rows.Count
            'Dim jmlKolom As Integer = dt.Columns.Count
            'Dim array(jmlBaris - 1, jmlKolom - 1) As String
            'For i As Integer = 0 To jmlBaris - 1
            '    For j As Integer = 0 To jmlKolom - 1
            '        array(i, j) = dt.Rows(i).Item(j).ToString()
            '    Next
            '    If array(i, 4) = namaFile Then
            '        MsgBox("Gambar sudah tersedia", MsgBoxStyle.Information, "Pemberitahuan")
            '        'clickMe.Visible = True
            '        Return
            '    End If
            'Next

            pctCover.Image = Image.FromFile(lokasiAsal)
            File.Copy(lokasiAsal, lokasiTujuan, True)
            txtCover.Text = namaFile
        End If
    End Sub

    Private Sub txtTitle_MouseEnter(sender As Object, e As EventArgs) Handles txtTitle.MouseEnter
        txtTitle.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtTitle_MouseLeave(sender As Object, e As EventArgs) Handles txtTitle.MouseLeave
        txtTitle.BorderStyle = BorderStyle.None
    End Sub

    Private Sub txtDescription_MouseEnter(sender As Object, e As EventArgs) Handles txtDescription.MouseEnter
        txtDescription.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub txtDescription_MouseLeave(sender As Object, e As EventArgs) Handles txtDescription.MouseLeave
        txtDescription.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        changeContent(New Playlist)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtTitle.Text = "" Then
            iconTitle.ImageLocation = PATH_ICON_FALSE
        Else
            iconTitle.ImageLocation = PATH_ICON_TRUE
        End If
    End Sub

    Private Sub txtTitle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTitle.KeyPress, txtDescription.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub
End Class