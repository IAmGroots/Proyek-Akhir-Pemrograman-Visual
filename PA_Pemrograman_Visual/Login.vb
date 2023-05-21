Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnGoogle_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click, btnApple.Click
        MsgBox("Sistem masih dalam tahap pengembangan")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If username = "" Then
            txtUsername.Focus()
            Return
        ElseIf password = "" Then
            txtPassword.Focus()
            Return
        End If

        'SELECT * FROM tbuser WHERE username = "asep" AND password = "00"
        CMD = New MySqlCommand("SELECT * From tbuser WHERE username = '" & username & "' AND password = '" & password & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            Dim role As String = RD.GetString(3)
            Dim idPengguna As String = RD.GetString(0)
            RD.Close()
            If role = "admin" Then
                UID = idPengguna
                AdminHome.Show()
                Me.Close()
            Else
                UID = idPengguna
                Home.Show()
                Me.Close()
            End If
        ElseIf Not RD.HasRows Then
            RD.Close()
            MessageBox.Show("Username dan password tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            txtUsername.Text = ""
            txtPassword.Text = ""
        End If
        'user
        'Home.Show()
        'Me.Hide()

        'admin
        'AdminHome.Show()
        'Me.Hide()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Hide()
    End Sub
End Class