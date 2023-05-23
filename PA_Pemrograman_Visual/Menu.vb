Public Class Menu
    Sub ActivePage(ByVal page As Button)
        page.ForeColor = Color.Red
    End Sub

    Sub DeactivePage(ByVal page)
        page.ForeColor = Color.White
    End Sub

    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        Home.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnBrandPage_Click(sender As Object, e As EventArgs) Handles btnBrandPage.Click
        changeContent(New ListSong)
        LAST_MENU_USER = "Home"
    End Sub

    Private Sub btnHomePage_Click(sender As Object, e As EventArgs) Handles btnHomePage.Click
        DeactivePage(btnSearchPage)
        DeactivePage(btnPlaylistPage)
        ActivePage(btnHomePage)
        changeContent(New ListSong)
        LAST_MENU_USER = "Home"
        'TextBox1.Text = "Home"
    End Sub

    Private Sub btnSearchPage_Click(sender As Object, e As EventArgs) Handles btnSearchPage.Click
        Search.lblSection.Text = "Trending"
        Search.lblKeterangan.Text = "Oops, saat ini tidak ada daftar lagu"
        DeactivePage(btnHomePage)
        DeactivePage(btnPlaylistPage)
        ActivePage(btnSearchPage)
        changeContent(New Search)
        LAST_MENU_USER = "Search"
        'TextBox1.Text = "Search"
    End Sub

    Private Sub btnPlaylistPage_Click(sender As Object, e As EventArgs) Handles btnPlaylistPage.Click
        DeactivePage(btnHomePage)
        DeactivePage(btnSearchPage)
        ActivePage(btnPlaylistPage)
        changeContent(New Playlist)
        LAST_MENU_USER = "Playlist"
        'TextBox1.Text = "Playlist"
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DeactivePage(btnSearchPage)
        DeactivePage(btnPlaylistPage)
        ActivePage(btnHomePage)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Home.MediaPlayers.Ctlcontrols.stop()
        Login.Show()
        Home.Hide()
    End Sub
End Class