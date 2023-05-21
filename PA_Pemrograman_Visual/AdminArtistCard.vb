Public Class AdminArtistCard
    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        AdminHome.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub lblArtist_MouseEnter(sender As Object, e As EventArgs) Handles lblArtist.MouseEnter
        lblArtist.ForeColor = Color.Blue
    End Sub

    Private Sub lblArtist_MouseLeave(sender As Object, e As EventArgs) Handles lblArtist.MouseLeave
        lblArtist.ForeColor = Color.Black
    End Sub

    Private Sub lblArtist_Click(sender As Object, e As EventArgs) Handles lblArtist.Click
        Dim detail = New AdminDetailArtist
        detail.txtIdArtist.Text = txtIdArtist.Text
        changeContent(detail)
    End Sub
End Class