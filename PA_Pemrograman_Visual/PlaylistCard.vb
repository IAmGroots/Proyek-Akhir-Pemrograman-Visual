Imports MySql.Data.MySqlClient

Public Class PlaylistCard
    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        Home.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        Dim detail = New DetailPlaylist
        detail.txtIdPlaylist.Text = txtIdPlaylist.Text
        changeContent(detail)
    End Sub

    Private Sub lblTitle_MouseEnter(sender As Object, e As EventArgs) Handles lblTitle.MouseEnter
        lblTitle.ForeColor = Color.Red
    End Sub

    Private Sub lblTitle_MouseLeave(sender As Object, e As EventArgs) Handles lblTitle.MouseLeave
        lblTitle.ForeColor = Color.Black
    End Sub

    Private Sub PlaylistCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pctCover.ImageLocation = PATH_COVER & txtSourceCover.Text
    End Sub
End Class