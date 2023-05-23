<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.pctCoverRegister = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.background = New System.Windows.Forms.Button()
        Me.btnNewPassword = New System.Windows.Forms.Button()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.pctCoverRegister.TabIndex = 58
        Me.pctCoverRegister.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(389, 608)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"

        'Me.Label6.Size = New System.Drawing.Size(252, 20)

        Me.Label6.Size = New System.Drawing.Size(195, 16)

        Me.Label6.TabIndex = 53
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
        Me.btnLogin.Location = New System.Drawing.Point(247, 651)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(541, 39)
        Me.btnLogin.TabIndex = 52
        Me.btnLogin.Text = "Sign In For XtremeMusix"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(244, 370)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"

        'Me.txtPassword.Size = New System.Drawing.Size(543, 36)

        Me.txtPassword.Size = New System.Drawing.Size(543, 31)

        Me.txtPassword.TabIndex = 51
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(241, 338)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"

        'Me.Label4.Size = New System.Drawing.Size(149, 20)

        Me.Label4.Size = New System.Drawing.Size(112, 16)

        Me.Label4.TabIndex = 50
        Me.Label4.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 245)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"

        'Me.Label3.Size = New System.Drawing.Size(104, 20)

        Me.Label3.Size = New System.Drawing.Size(81, 16)

        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(245, 277)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsername.Name = "txtUsername"

        'Me.txtUsername.Size = New System.Drawing.Size(542, 36)

        Me.txtUsername.Size = New System.Drawing.Size(542, 31)

        Me.txtUsername.TabIndex = 48
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

        'Me.lblApp.Size = New System.Drawing.Size(213, 36)

        Me.lblApp.Size = New System.Drawing.Size(167, 29)

        Me.lblApp.TabIndex = 43
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
        Me.background.TabIndex = 55
        Me.background.UseVisualStyleBackColor = False
        '
        'btnNewPassword
        '
        Me.btnNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNewPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnNewPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPassword.ForeColor = System.Drawing.Color.White
        Me.btnNewPassword.Location = New System.Drawing.Point(244, 546)
        Me.btnNewPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewPassword.Name = "btnNewPassword"
        Me.btnNewPassword.Size = New System.Drawing.Size(544, 39)
        Me.btnNewPassword.TabIndex = 59
        Me.btnNewPassword.Text = "Change Password"
        Me.btnNewPassword.UseVisualStyleBackColor = False
        '
        'txtConfirm
        '
        Me.txtConfirm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtConfirm.BackColor = System.Drawing.Color.White
        Me.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirm.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(244, 466)
        Me.txtConfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirm.Name = "txtConfirm"

        'Me.txtConfirm.Size = New System.Drawing.Size(543, 36)

        Me.txtConfirm.Size = New System.Drawing.Size(543, 31)

        Me.txtConfirm.TabIndex = 61
        Me.txtConfirm.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(241, 434)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"

        'Me.Label1.Size = New System.Drawing.Size(182, 20)

        Me.Label1.Size = New System.Drawing.Size(138, 16)

        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Confirm Password"
        '
        'cbxPass
        '
        Me.cbxPass.AutoSize = True
        Me.cbxPass.BackColor = System.Drawing.Color.White
        Me.cbxPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbxPass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPass.ForeColor = System.Drawing.Color.Black
        Me.cbxPass.Location = New System.Drawing.Point(244, 514)
        Me.cbxPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxPass.Name = "cbxPass"

        'Me.cbxPass.Size = New System.Drawing.Size(165, 24)

        Me.cbxPass.Size = New System.Drawing.Size(129, 20)

        Me.cbxPass.TabIndex = 62
        Me.cbxPass.Text = "Show password"
        Me.cbxPass.UseVisualStyleBackColor = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1800, 898)
        Me.Controls.Add(Me.cbxPass)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewPassword)
        Me.Controls.Add(Me.pctCoverRegister)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblApp)
        Me.Controls.Add(Me.background)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)

        Me.MaximizeBox = False

        Me.Name = "ForgotPassword"
        Me.Text = "Forgot Password"
        CType(Me.pctCoverRegister, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctCoverRegister As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblApp As Label
    Friend WithEvents background As Button
    Friend WithEvents btnNewPassword As Button
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbxPass As CheckBox
End Class
