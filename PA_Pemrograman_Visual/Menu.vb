Public Class Menu
    Sub ActivePage(ByVal page As Button)
        page.ForeColor = Color.Red
    End Sub

    Sub DeactivePage(ByVal page)
        page.ForeColor = Color.White
    End Sub

    Private Sub btnHomePage_Click(sender As Object, e As EventArgs) Handles btnHomePage.Click
        DeactivePage(btnSearchPage)
        DeactivePage(btnPlaylistPage)
        ActivePage(btnHomePage)
        'TextBox1.Text = "Home"
    End Sub

    Private Sub btnSearchPage_Click(sender As Object, e As EventArgs) Handles btnSearchPage.Click
        DeactivePage(btnHomePage)
        DeactivePage(btnPlaylistPage)
        ActivePage(btnSearchPage)
        'TextBox1.Text = "Search"
    End Sub

    Private Sub btnPlaylistPage_Click(sender As Object, e As EventArgs) Handles btnPlaylistPage.Click
        DeactivePage(btnHomePage)
        DeactivePage(btnSearchPage)
        ActivePage(btnPlaylistPage)
        'TextBox1.Text = "Playlist"
    End Sub

End Class