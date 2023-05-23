Imports MySql.Data.MySqlClient

Public Class AdminListArtist
    Sub changeContent(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        AdminHome.Content.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub AdminListArtist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SELECT * From tbartist
        DA = New MySqlDataAdapter("SELECT * From tbartist", CONN)
        DS = New DataSet
        DA.Fill(DS, "artist")
        Dim dt As DataTable = DS.Tables("artist")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        If jmlBaris = 0 Then
            lblKosong.Visible = True
        End If
        For i As Integer = 0 To jmlBaris - 1
            lblKosong.Visible = False
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            Dim artist As New AdminArtistCard
            With artist
                .txtIdArtist.Text = array(i, 0)
                .lblArtist.Text = array(i, 1)
                .pctCover.ImageLocation = PATH_ARTIST & array(i, 3)
            End With
            artist.TopLevel = False
            panelArtist.Controls.Add(artist)
            artist.Show()
        Next
    End Sub

    Private Sub btnAddArtist_Click(sender As Object, e As EventArgs) Handles pctIconNewArtist.Click, Label1.Click, btnAddArtist.Click
        Dim newArtist = New AdminDetailArtist
        newArtist.txtIdArtist.Text = 0
        changeContent(newArtist)
    End Sub
End Class