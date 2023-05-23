Public Class AdminHome
    Sub panelMenu(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        MenuPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        panelMenu(New AdminMenu)
        MediaPlayers.settings.autoStart = True
        AudioPanel.Visible = False
        changeContent(New AdminListSong)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        MediaPlayers.Ctlcontrols.stop()
        ID_PLAYING = 0
        ID_PREVIOUS_PLAYING = 0
        AudioPanel.Visible = False
    End Sub

End Class