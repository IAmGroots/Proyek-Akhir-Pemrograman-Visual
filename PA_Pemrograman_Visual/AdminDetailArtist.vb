Imports System.IO
Imports MySql.Data.MySqlClient

Public Class AdminDetailArtist
    Dim PATH_ICON_TRUE As String = CurDir() & "/gambar/True.png"
    Dim PATH_ICON_FALSE As String = CurDir() & "/gambar/False.png"

    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        AdminHome.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub getArtist()
        Dim target As Integer = txtIdArtist.Text
        If target = 0 Then
            txtName.Text = "New Artist"
            txtCountry.Text = ""
            txtDescription.Text = ""
            pctCover.ImageLocation = PATH_ARTIST & "defaultPerson.png"
            fileCover.Text = "defaultPerson.png"
            LabelUpdateAt.Visible = False
            txtUpdate_at.Visible = False
            pctIconDelete.Visible = False
            Return
        End If
        'SELECT * From tbsong S Join tbartist A ON S.id_artist = A.id_artist WHERE id_song = 1
        DA = New MySqlDataAdapter("SELECT * From tbartist WHERE id_artist = " & target, CONN)
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
            txtName.Text = array(i, 1)
            txtCountry.Text = array(i, 2)
            txtDescription.Text = array(i, 4)
            pctCover.ImageLocation = PATH_ARTIST & array(i, 3)
            fileCover.Text = array(i, 3)
            Dim update_at As DateTime = array(i, 5)
            txtUpdate_at.Text = update_at.ToString("yyyy/MM/dd")
        Next
    End Sub

    Sub getSongArtist()
        Dim target As String = txtIdArtist.Text
        DA = New MySqlDataAdapter("SELECT * FROM tbsong S JOIN tbartist A ON S.id_artist = A.id_artist WHERE A.id_artist = " & target, CONN)
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

    Private Sub AdminDetailArtist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getArtist()
        getSongArtist()
        pctIconSave.Focus()
        'txtName.BorderStyle = BorderStyle.None
        'txtCountry.BorderStyle = BorderStyle.None
        'txtDescription.BorderStyle = BorderStyle.None
        'fileCover.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtName.Text = "" Then
            iconName.ImageLocation = PATH_ICON_FALSE
        Else
            iconName.ImageLocation = PATH_ICON_TRUE
        End If

        If txtCountry.Text = "" Then
            iconCountry.ImageLocation = PATH_ICON_FALSE
        Else
            iconCountry.ImageLocation = PATH_ICON_TRUE
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
    End Sub

    Private Sub btnFileCover_Click(sender As Object, e As EventArgs) Handles btnFileCover.Click
        OpenFileDialogCover.FileName = ""
        OpenFileDialogCover.Filter = "JPG Files (*.jpg)|*.jpg|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png"
        If OpenFileDialogCover.ShowDialog = DialogResult.OK Then
            Dim lokasiAsal As String = OpenFileDialogCover.FileName
            Dim namaFile As String = Path.GetFileName(lokasiAsal)
            Dim lokasiTujuan As String = Path.Combine(PATH_ARTIST, namaFile)
            pctCover.Image = Image.FromFile(lokasiAsal)
            File.Copy(lokasiAsal, lokasiTujuan, True)
            fileCover.Text = namaFile
        End If
    End Sub

    Private Sub pctIconSave_Click(sender As Object, e As EventArgs) Handles pctIconSave.Click
        If txtName.Text = "" Or txtCountry.Text = "" Or txtDescription.Text = "" Then
            Return
        End If

        If txtIdArtist.Text = 0 Then
            Dim name As String = txtName.Text
            Dim country As String = txtCountry.Text
            Dim desc As String = txtDescription.Text
            Dim photo As String = fileCover.Text
            Dim dateNow As DateTime = DateTime.Now
            Dim update_at As String = dateNow.ToString("yyyy/MM/dd")

            'INSERT INTO `tbartist` (`id_artist`, `name`, `country`, `photo`, `description`, `update_at`) VALUES (NULL, 'Artist 1', 'Indonesia', 'artist.jpg', 'a', '2023-05-04')
            Dim query As String = "INSERT INTO tbartist(id_artist, name, country, photo, description, update_at) VALUES (NULL, '" & name & "', '" & country & "', '" & photo & "', '" & desc & "', '" & update_at & "')"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Berhasil Menambahkan Artis", MsgBoxStyle.Information, "Pemberitahuan")
            changeContent(New AdminListArtist)

        Else
            Dim id_artist As Integer = txtIdArtist.Text
            Dim name As String = txtName.Text
            Dim country As String = txtCountry.Text
            Dim desc As String = txtDescription.Text
            Dim photo As String = fileCover.Text
            Dim dateNow As DateTime = DateTime.Now
            Dim update_at As String = dateNow.ToString("yyyy/MM/dd")

            'UPDATE `tbartist` SET `name` = 'Artist 11', `country` = 'Indonesia1', `photo` = 'artist1.jpg', `description` = 'a1', `join_at` = '2023-05-02' WHERE `tbartist`.`id_artist` = 4
            Dim query As String = "UPDATE tbartist SET name = '" & name & "', country = '" & country & "', photo = '" & photo & "', description = '" & desc & "', update_at = '" & update_at & "' WHERE id_artist = " & id_artist
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Berhasil Mengubah Data Artis", MsgBoxStyle.Information, "Pemberitahuan")
            Dim detail = New AdminDetailArtist
            detail.txtIdArtist.Text = txtIdArtist.Text
            changeContent(detail)
        End If
    End Sub

    Private Sub pctIconDelete_Click(sender As Object, e As EventArgs) Handles pctIconDelete.Click
        'DELETE FROM tbartist WHERE id_artist = 1
        Dim query As String = "DELETE FROM tbartist WHERE id_artist = " & txtIdArtist.Text
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Berhasil Menghapus Artis", MsgBoxStyle.Information, "Pemberitahuan")
        changeContent(New AdminListArtist)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If LAST_MENU_ADMIN = "Song" Then
            changeContent(New AdminListSong)
        ElseIf LAST_MENU_ADMIN = "Artist" Then
            changeContent(New AdminListArtist)
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress, txtDescription.KeyPress, txtCountry.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> " " Then
            e.Handled = True
        End If
    End Sub

    'Private Sub txtName_MouseEnter(sender As Object, e As EventArgs) Handles txtName.MouseEnter
    '    txtName.BorderStyle = BorderStyle.FixedSingle
    'End Sub

    'Private Sub txtName_MouseLeave(sender As Object, e As EventArgs) Handles txtName.MouseLeave
    '    txtName.BorderStyle = BorderStyle.None
    'End Sub

    'Private Sub txtCountry_MouseEnter(sender As Object, e As EventArgs) Handles txtCountry.MouseEnter
    '    txtCountry.BorderStyle = BorderStyle.FixedSingle
    'End Sub

    'Private Sub txtCountry_MouseLeave(sender As Object, e As EventArgs) Handles txtCountry.MouseLeave
    '    txtCountry.BorderStyle = BorderStyle.None
    'End Sub

    'Private Sub txtDescription_MouseEnter(sender As Object, e As EventArgs) Handles txtDescription.MouseEnter
    '    txtDescription.BorderStyle = BorderStyle.FixedSingle
    'End Sub

    'Private Sub txtDescription_MouseLeave(sender As Object, e As EventArgs) Handles txtDescription.MouseLeave
    '    txtDescription.BorderStyle = BorderStyle.None
    'End Sub
End Class