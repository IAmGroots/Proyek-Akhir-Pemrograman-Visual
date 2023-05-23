Public Class AdminMenu
    Sub ActivePage(ByVal page As Button)
        page.ForeColor = Color.Red
    End Sub

    Sub DeactivePage(ByVal page)
        page.ForeColor = Color.White
    End Sub

    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        AdminHome.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnBrandPage_Click(sender As Object, e As EventArgs) Handles btnBrandPage.Click
        changeContent(New AdminListSong)
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeactivePage(btnArtistPage)
        ActivePage(btnSongPage)
        LAST_MENU_ADMIN = "Song"
    End Sub

    Private Sub btnSongPage_Click(sender As Object, e As EventArgs) Handles btnSongPage.Click
        DeactivePage(btnArtistPage)
        ActivePage(btnSongPage)
        changeContent(New AdminListSong)
        LAST_MENU_ADMIN = "Song"
    End Sub

    Private Sub btnArtistPage_Click(sender As Object, e As EventArgs) Handles btnArtistPage.Click
        DeactivePage(btnSongPage)
        ActivePage(btnArtistPage)
        changeContent(New AdminListArtist)
        LAST_MENU_ADMIN = "Artist"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        AdminHome.MediaPlayers.Ctlcontrols.stop()
        Login.Show()
        AdminHome.Hide()
    End Sub
End Class