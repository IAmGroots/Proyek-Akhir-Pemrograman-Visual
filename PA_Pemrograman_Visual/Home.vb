Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Home
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

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        panelMenu(New Menu)
        MediaPlayers.settings.autoStart = True
        AudioPanel.Visible = False
        changeContent(New ListSong)
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        MediaPlayers.Ctlcontrols.stop()
        ID_PLAYING = 0
        ID_PREVIOUS_PLAYING = 0
        AudioPanel.Visible = False
    End Sub
End Class