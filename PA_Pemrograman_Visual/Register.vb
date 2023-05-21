Imports MySql.Data.MySqlClient

Public Class Register
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRegister.Visible = False
    End Sub

    Private Sub btnApple_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click, btnApple.Click
        MsgBox("Sistem masih dalam tahap pengembangan")
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

        'INSERT INTO `tbuser` (`uid`, `username`, `password`, `role`) VALUES (NULL, 'a', 'a', 'user');
        Dim query As String = "INSERT INTO tbuser(uid, username, password, role) VALUES (NULL, '" & username & "', '" & password & "', '" & role & "')"
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Register berhasil")
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
End Class