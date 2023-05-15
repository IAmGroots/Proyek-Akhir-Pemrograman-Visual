
Public Class App
    Sub changePanel(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        MainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub App_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'changePanel(New Login)
        changePanel(New Home)
    End Sub
End Class
