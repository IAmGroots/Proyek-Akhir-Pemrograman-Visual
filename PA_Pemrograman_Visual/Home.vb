Public Class Home
    Sub changePanel(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        MenuPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub songPanel(ByVal panel As Form)
        panel.TopLevel = False
        panelSong.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changePanel(New Menu)

        Dim i As Integer
        For i = 0 To 20
            songPanel(New SongCard)
        Next
    End Sub
End Class