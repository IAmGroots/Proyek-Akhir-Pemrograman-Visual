Imports MySql.Data.MySqlClient

Public Class ForgotPassword
    Private Sub btnNewPassword_Click(sender As Object, e As EventArgs) Handles btnNewPassword.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim confirm As String = txtConfirm.Text

        If username = "" Then
            txtUsername.Focus()
            Return
        ElseIf password = "" Then
            txtPassword.Focus()
            Return
        ElseIf confirm = "" Then
            txtConfirm.Focus()
            Return
        ElseIf password <> confirm Then
            MsgBox("Password tidak sama", MsgBoxStyle.Critical, "Error")
            txtUsername.Focus()
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtConfirm.Text = ""
            Return
        End If

        'SELECT * FROM tbuser WHERE username = "asep" AND password = "00"
        CMD = New MySqlCommand("SELECT * From tbuser WHERE tbuser.username = '" & username.ToLower & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If Not RD.HasRows Then
            RD.Close()

            'MessageBox.Show("Username tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            MessageBox.Show("Username tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtUsername.Focus()
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtConfirm.Text = ""
            Return
        End If

        RD.Close()
        'UPDATE `tbuser` SET `password` = '1' WHERE `tbuser`.`uid` = 6;
        Dim query As String = "UPDATE tbuser SET password = '" & password & "' WHERE tbuser.username = '" & username.ToLower & "'"
        CMD = New MySqlCommand(query, CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Ubah password berhasil", MsgBoxStyle.Information, "Pemberitahuan")
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub cbxPass_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPass.CheckedChanged
        If cbxPass.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            txtConfirm.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
            txtConfirm.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress, txtPassword.KeyPress, txtConfirm.KeyPress
        If Not Char.IsLetterOrDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(Keys.Back) AndAlso e.KeyChar <> " " Then
            e.Handled = True ' Mengabaikan karakter selain huruf, angka, spasi, dan backspace
        End If
    End Sub

End Class