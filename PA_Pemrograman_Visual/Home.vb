Imports System.Media
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Home
    Sub changePanel(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        MenuPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub songPanel(ByVal panel As Form)
        panel.TopLevel = False
        panel.WindowState = FormWindowState.Maximized
        panelSong.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        changePanel(New Menu)
        MediaPlayers.settings.autoStart = True
        'MediaPlayers.URL = PATH_SONG & "Night Changes.mp3"
        'MediaPlayers.Ctlcontrols.stop()
        'MsgBox(MediaPlayer.URL)
        'Dim i As Integer
        'For i = 0 To 20
        '    Dim cardSong = New SongCard
        '    cardSong.textBox1.Text = i
        '    songPanel(cardSong)
        'Next

        DA = New MySqlDataAdapter("Select * From tbsong", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "lagu")
        Dim dt As DataTable = DS.Tables("lagu")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        For i As Integer = 0 To jmlBaris - 1
            'lblKosong.Visible = False
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            Dim produk As New SongCard
            With produk
                '.KodeProduk.Text = array(i, 0)
                '.NamaProduk.Text = array(i, 1)
                'Dim hrg As Integer = array(i, 3)
                '.HargaProduk.Text = "Rp " & FormatNumber(hrg, 0, TriState.True)
                '.pctProduk.ImageLocation = PATH_GAMBAR & array(i, 4)
                .TextBox2.Text = array(i, 0)
                .lblTitle.Text = array(i, 2)
                .textBox1.Text = array(i, 6)
            End With
            produk.TopLevel = False
            panelSong.Controls.Add(produk)
            produk.Show()

        Next
        'While True
        '    If b = "pl" Then
        '        MediaPlayer.Ctlcontrols.play()
        '    ElseIf b = "ps" Then
        '        MediaPlayer.Ctlcontrols.stop()
        '    End If
        'End While
    End Sub

    Sub test()
        If b = "pl" Then
            MediaPlayers.URL = a
            MediaPlayers.Ctlcontrols.play()
        ElseIf b = "ps" Then
            MediaPlayers.Ctlcontrols.stop()
        End If
    End Sub
End Class