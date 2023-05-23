<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.pctCoverRegister = New System.Windows.Forms.PictureBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnApple = New System.Windows.Forms.Button()
        Me.btnGoogle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.background = New System.Windows.Forms.Button()
        Me.cbxAgreement = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cbxPass = New System.Windows.Forms.CheckBox()
        CType(Me.pctCoverRegister, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctCoverRegister
        '
        Me.pctCoverRegister.Image = CType(resources.GetObject("pctCoverRegister.Image"), System.Drawing.Image)
        Me.pctCoverRegister.Location = New System.Drawing.Point(940, 128)
        Me.pctCoverRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctCoverRegister.Name = "pctCoverRegister"
        Me.pctCoverRegister.Size = New System.Drawing.Size(687, 642)
        Me.pctCoverRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCoverRegister.TabIndex = 39
        Me.pctCoverRegister.TabStop = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Gainsboro
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(244, 341)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(249, 4)
        Me.Button9.TabIndex = 38
        Me.Button9.Text = "Button9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Gainsboro
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(545, 341)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(243, 4)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "Button8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White

        'Me.btnRegister.Location = New System.Drawing.Point(491, 454)

        Me.btnRegister.Location = New System.Drawing.Point(655, 559)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(133, 39)
        Me.btnRegister.TabIndex = 35
        Me.btnRegister.Text = "REGISTER"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(389, 622)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Already have an account?"
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White

        'Me.btnLogin.Location = New System.Drawing.Point(185, 540)

        Me.btnLogin.Location = New System.Drawing.Point(247, 665)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(541, 39)
        Me.btnLogin.TabIndex = 33
        Me.btnLogin.Text = "Sign In For XtremeMusix"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(244, 497)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(543, 31)
        Me.txtPassword.TabIndex = 31
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 465)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 372)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(245, 404)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(542, 31)
        Me.txtUsername.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(501, 332)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "OR"
        '
        'btnApple
        '
        Me.btnApple.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnApple.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnApple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApple.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApple.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApple.ForeColor = System.Drawing.Color.White

        'Me.btnApple.Location = New System.Drawing.Point(184, 219)

        Me.btnApple.Location = New System.Drawing.Point(245, 270)
        Me.btnApple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        Me.btnApple.Name = "btnApple"
        Me.btnApple.Size = New System.Drawing.Size(267, 39)
        Me.btnApple.TabIndex = 26
        Me.btnApple.Text = "APPLE ID"
        Me.btnApple.UseVisualStyleBackColor = False
        '
        'btnGoogle
        '
        Me.btnGoogle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGoogle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnGoogle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGoogle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoogle.ForeColor = System.Drawing.Color.White

        'Me.btnGoogle.Location = New System.Drawing.Point(391, 219)

        Me.btnGoogle.Location = New System.Drawing.Point(521, 270)
        Me.btnGoogle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        Me.btnGoogle.Name = "btnGoogle"
        Me.btnGoogle.Size = New System.Drawing.Size(267, 39)
        Me.btnGoogle.TabIndex = 25
        Me.btnGoogle.Text = "GOOGLE"
        Me.btnGoogle.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "To continue, register to XtremeMusix"
        '
        'lblApp
        '
        Me.lblApp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblApp.AutoSize = True
        Me.lblApp.BackColor = System.Drawing.Color.White
        Me.lblApp.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.Location = New System.Drawing.Point(409, 171)
        Me.lblApp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(167, 29)
        Me.lblApp.TabIndex = 23
        Me.lblApp.Text = "XtremeMusix"
        '
        'background
        '
        Me.background.BackColor = System.Drawing.Color.White
        Me.background.Enabled = False
        Me.background.FlatAppearance.BorderSize = 0
        Me.background.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.background.Location = New System.Drawing.Point(173, 128)
        Me.background.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.background.Name = "background"
        Me.background.Size = New System.Drawing.Size(687, 642)
        Me.background.TabIndex = 36
        Me.background.UseVisualStyleBackColor = False
        '
        'cbxAgreement
        '
        Me.cbxAgreement.AutoSize = True
        Me.cbxAgreement.BackColor = System.Drawing.Color.White
        Me.cbxAgreement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxAgreement.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Me.cbxAgreement.Location = New System.Drawing.Point(183, 466)

        Me.cbxAgreement.Location = New System.Drawing.Point(244, 574)
        Me.cbxAgreement.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        Me.cbxAgreement.Name = "cbxAgreement"
        Me.cbxAgreement.Size = New System.Drawing.Size(290, 20)
        Me.cbxAgreement.TabIndex = 42
        Me.cbxAgreement.Text = "I accept the terms of the aggrement"
        Me.cbxAgreement.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cbxPass
        '
        Me.cbxPass.AutoSize = True
        Me.cbxPass.BackColor = System.Drawing.Color.White
        Me.cbxPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPass.ForeColor = System.Drawing.Color.Black

        'Me.cbxPass.Location = New System.Drawing.Point(183, 441)

        Me.cbxPass.Location = New System.Drawing.Point(244, 543)
        Me.cbxPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        Me.cbxPass.Name = "cbxPass"
        Me.cbxPass.Size = New System.Drawing.Size(129, 20)
        Me.cbxPass.TabIndex = 43
        Me.cbxPass.Text = "Show password"
        Me.cbxPass.UseVisualStyleBackColor = False
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray

        'Me.ClientSize = New System.Drawing.Size(1350, 730)

        Me.ClientSize = New System.Drawing.Size(1800, 898)

        Me.Controls.Add(Me.cbxPass)
        Me.Controls.Add(Me.cbxAgreement)
        Me.Controls.Add(Me.pctCoverRegister)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnApple)
        Me.Controls.Add(Me.btnGoogle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblApp)
        Me.Controls.Add(Me.background)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Register"
        Me.Text = "Register"
        CType(Me.pctCoverRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctCoverRegister As PictureBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnApple As Button
    Friend WithEvents btnGoogle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblApp As Label
    Friend WithEvents background As Button
    Friend WithEvents cbxAgreement As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cbxPass As CheckBox
End Class
