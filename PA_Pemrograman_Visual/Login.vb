Imports MySql.Data.MySqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnGoogle_Click(sender As Object, e As EventArgs) Handles btnGoogle.Click, btnApple.Click
        MsgBox("Sistem masih dalam tahap pengembangan", MsgBoxStyle.Information, "Pemberitahuan")
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
        CMD = New MySqlCommand("SELECT * From tbuser WHERE username = '" & username.ToLower & "' AND password = '" & password & "'", CONN)
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
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub forgot_MouseEnter(sender As Object, e As EventArgs) Handles forgot.MouseEnter
        forgot.ForeColor = Color.FromArgb(100, 92, 170)
    End Sub

    Private Sub forgot_MouseLeave(sender As Object, e As EventArgs) Handles forgot.MouseLeave
        forgot.ForeColor = Color.Black
    End Sub

    Private Sub forgot_Click(sender As Object, e As EventArgs) Handles forgot.Click
        ForgotPassword.Show()
        Me.Hide()
    End Sub

    Private Sub cbxPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPass.CheckedChanged
        If cbxPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress, txtPassword.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> " " Then
            e.Handled = True ' Mengabaikan karakter selain huruf, angka, spasi, dan backspace
        End If
    End Sub
End Class