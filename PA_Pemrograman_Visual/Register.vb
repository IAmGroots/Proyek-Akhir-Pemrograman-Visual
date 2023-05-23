Imports MySql.Data.MySqlClient

Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        btnRegister.Visible = False
    End Sub

    Private Sub btnApple_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click, btnApple.Click
        MsgBox("Sistem masih dalam tahap pengembangan", MsgBoxStyle.Information, "Pemberitahuan")
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = "user"

        If username = "" Then
            txtUsername.Focus()
            Return
        ElseIf password = "" Then
            txtPassword.Focus()
            Return
        End If

        'SELECT * From tbuser
        DA = New MySqlDataAdapter("SELECT * From tbuser", CONN)
        DS = New DataSet
        DA.Fill(DS, "user")
        Dim dt As DataTable = DS.Tables("user")
        Dim jmlBaris As Integer = dt.Rows.Count
        Dim jmlKolom As Integer = dt.Columns.Count
        Dim array(jmlBaris - 1, jmlKolom - 1) As String
        For i As Integer = 0 To jmlBaris - 1
            For j As Integer = 0 To jmlKolom - 1
                array(i, j) = dt.Rows(i).Item(j).ToString()
            Next
            If username = array(i, 1) Then
                MsgBox("Username telah digunakan", MsgBoxStyle.Critical, "Error")
                Return
            End If
        Next

        'INSERT INTO `tbuser` (`uid`, `username`, `password`, `role`) VALUES (NULL, 'a', 'a', 'user');
        Dim query As String = "INSERT INTO tbuser(uid, username, password, role) VALUES (NULL, '" & username.ToLower & "', '" & password & "', '" & role & "')"
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Register berhasil", MsgBoxStyle.Information, "Pemberitahuan")
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cbxAgreement.Checked = False Then
            btnRegister.Visible = False
        Else
            btnRegister.Visible = True
        End If
    End Sub

    Private Sub cbxPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPass.CheckedChanged
        If cbxPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress, txtPassword.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub
End Class