Imports MySql.Data.MySqlClient

Public Class Playlist
    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        Home.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Playlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SELECT * FROM tbplaylist WHERE uid = 1
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
                lblKeterangan.Visible = False
                For j As Integer = 0 To jmlKolom - 1
                    array(i, j) = dt.Rows(i).Item(j).ToString()
                Next
                Dim data As New PlaylistCard
                With data
                    .txtIdPlaylist.Text = array(i, 0)
                    .lblTitle.Text = array(i, 2)
                    .txtSourceCover.Text = array(i, 4)
                End With
                data.TopLevel = False
                panelPlaylist.Controls.Add(data)
                data.Show()
            Next
        Else
            RD.Close()
            lblKeterangan.Visible = True
        End If
    End Sub

    Private Sub pctIconNewPlaylist_Click(sender As Object, e As EventArgs) Handles pctIconNewPlaylist.Click, Label1.Click, btnAddPlaylist.Click
        Dim id_user As Integer = UID
        Dim name As String = "New Playlist"
        Dim desc As String = "New Description"
        Dim cover As String = "defaultPlaylist.png"

        'INSERT INTO tbplaylist(id_playlist, uid, name, description, cover) VALUES (NULL, '1', 'New Playlist', 'This Is Description', 'default.jpg')
        Dim query As String = "INSERT INTO tbplaylist(id_playlist, uid, name, description, cover) VALUES (NULL, '" & id_user & "', '" & name & "', '" & desc & "', '" & cover & "')"
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Berhasil Membuat Playlist", MsgBoxStyle.Information, "Pemberitahuan")
        changeContent(New Playlist)
    End Sub
End Class