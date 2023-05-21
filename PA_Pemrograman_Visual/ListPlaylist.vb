Imports MySql.Data.MySqlClient

Public Class ListPlaylist
    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        Home.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub ListPlaylist_MouseEnter(sender As Object, e As EventArgs) Handles txtTitle.MouseEnter, pctCover.MouseEnter, MyBase.MouseEnter
        Me.BackColor = Color.MediumSeaGreen
    End Sub

    Private Sub ListPlaylist_MouseLeave(sender As Object, e As EventArgs) Handles txtTitle.MouseLeave, pctCover.MouseLeave, MyBase.MouseLeave
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub ListPlaylist_Click(sender As Object, e As EventArgs) Handles txtTitle.Click, pctCover.Click, MyBase.Click
        'INSERT INTO tbplaylist_song (id_playlist, id_song) VALUES (1, 6)
        Dim id_playlist As String = txtIdPlaylist.Text
        Dim id_song As String = txtIdSong.Text

        CMD = New MySqlCommand("SELECT * FROM tbplaylist_song WHERE id_playlist = " & id_playlist & " AND id_song = " & id_song, CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()
            MsgBox("Lagu sudah ada didalam PLaylist tersebut")
        Else
            RD.Close()
            Dim query As String = "INSERT INTO tbplaylist_song (id_playlist, id_song) VALUES (" & id_playlist & ", " & id_song & ")"
            CMD = New MySqlCommand(query, CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Ditambah")
        End If
        Dim detail = New DetailSong
        detail.txtIdSong.Text = txtIdSong.Text
        changeContent(detail)
    End Sub

    Private Sub ListPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class