Imports MySql.Data.MySqlClient

Public Class Testing
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    'DA = New MySqlDataAdapter("SELECT * From tbsong S Join tbartist A ON S.id_artist = A.id_artist WHERE id_song = " & target, CONN)
    '    DS = New DataSet
    '    DA.Fill(DS, "lagu")
    '    Dim dt As DataTable = DS.Tables("lagu")
    'Dim jmlBaris As Integer = dt.Rows.Count
    'Dim jmlKolom As Integer = dt.Columns.Count
    'Dim array(jmlBaris - 1, jmlKolom - 1) As String
    'For i As Integer = 0 To jmlBaris - 1
    'For j As Integer = 0 To jmlKolom - 1
    '            array(i, j) = dt.Rows(i).Item(j).ToString()
    '        Next
    '        pctIconDelete.Visible = True
    '        txtTitle.Text = array(i, 2)
    '        txtArtist.Text = array(i, 9)
    '        txtGenre.Text = array(i, 3)
    '        txtDescription.Text = array(i, 4)
    '        txtSourceSong.Text = array(i, 6)
    '        fileSource.Text = array(i, 6)
    '        pctCover.ImageLocation = PATH_COVER & array(i, 5)
    '        'txtCover.Text = array(i, 5)
    '        fileCover.Text = array(i, 5)
    '    Next

    Function getIDArtist(ByVal name As String)
        DA = New MySqlDataAdapter("SELECT * FROM tbartist A WHERE A.name = '" & name & "'", CONN)
        DS = New DataSet
        DA.Fill(DS, "artist")
        Dim dt As DataTable = DS.Tables("artist")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        Dim id As Integer
        For i As Integer = 0 To jmlBaris - 1
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            id = array(i, 0)
        Next
        Return id
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'DA = New MySqlDataAdapter("SELECT * From tbsong S Join tbartist A ON S.id_artist = A.id_artist", CONN)
        'DS = New DataSet
        'DA.Fill(DS, "lagu")
        'Dim dt As DataTable = DS.Tables("lagu")
        koneksi()
        'SELECT * FROM tbartist A WHERE A.name = 'One Direction'
        DA = New MySqlDataAdapter("SELECT * FROM tbartist A WHERE A.name = '" & TextBox1.Text & "'", CONN)
        DS = New DataSet
        DA.Fill(DS, "artist")
        Dim dt As DataTable = DS.Tables("artist")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        Dim id As Integer
        For i As Integer = 0 To jmlBaris - 1
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            id = array(i, 0)
        Next

        Dim dateNow As DateTime = DateTime.Now
        Dim update_at As String = dateNow.ToString("dd/MM/yyyy")
        TextBox2.Text = update_at
    End Sub

    Private Sub Testing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class