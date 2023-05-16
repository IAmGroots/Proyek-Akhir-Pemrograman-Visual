Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module Bantuan
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public DATABASE As String

    Public PATH_COVER As String = CurDir() & "\Cover\"
    Public PATH_ARTIST As String = CurDir() & "\Artist\"
    Public PATH_SONG As String = CurDir() & "\Song\"
    Public ID_PREVIOUS_PLAYING As Integer = 0
    Public ID_PLAYING As Integer = 0
    Public playing As Boolean = False

    Public a As String = ""
    Public b As String = ""

    Sub koneksi()
        Try
            Dim DATABASE As String = "server=localhost;userid=root;password=;database=db_xtrememusix"
            CONN = New MySqlConnection(DATABASE)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
