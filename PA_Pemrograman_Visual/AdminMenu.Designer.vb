<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenu
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
        Me.btnArtistPage = New System.Windows.Forms.Button()
        Me.btnSongPage = New System.Windows.Forms.Button()
        Me.btnBrandPage = New System.Windows.Forms.Button()
        Me.btnLoginAndLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnArtistPage
        '
        Me.btnArtistPage.BackColor = System.Drawing.Color.Transparent
        Me.btnArtistPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArtistPage.FlatAppearance.BorderSize = 0
        Me.btnArtistPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnArtistPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnArtistPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArtistPage.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArtistPage.ForeColor = System.Drawing.Color.White
        Me.btnArtistPage.Location = New System.Drawing.Point(639, 12)
        Me.btnArtistPage.Name = "btnArtistPage"
        Me.btnArtistPage.Size = New System.Drawing.Size(100, 40)
        Me.btnArtistPage.TabIndex = 8
        Me.btnArtistPage.Text = "Artist"
        Me.btnArtistPage.UseVisualStyleBackColor = False
        '
        'btnSongPage
        '
        Me.btnSongPage.BackColor = System.Drawing.Color.Transparent
        Me.btnSongPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSongPage.FlatAppearance.BorderSize = 0
        Me.btnSongPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSongPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSongPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSongPage.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSongPage.ForeColor = System.Drawing.Color.White
        Me.btnSongPage.Location = New System.Drawing.Point(499, 12)
        Me.btnSongPage.Name = "btnSongPage"
        Me.btnSongPage.Size = New System.Drawing.Size(100, 40)
        Me.btnSongPage.TabIndex = 7
        Me.btnSongPage.Text = "Song"
        Me.btnSongPage.UseVisualStyleBackColor = False
        '
        'btnBrandPage
        '
        Me.btnBrandPage.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBrandPage.FlatAppearance.BorderSize = 0
        Me.btnBrandPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrandPage.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrandPage.ForeColor = System.Drawing.Color.White
        Me.btnBrandPage.Location = New System.Drawing.Point(12, 12)
        Me.btnBrandPage.Name = "btnBrandPage"
        Me.btnBrandPage.Size = New System.Drawing.Size(175, 40)
        Me.btnBrandPage.TabIndex = 10
        Me.btnBrandPage.Text = "XtremeMusix"
        Me.btnBrandPage.UseVisualStyleBackColor = False
        '
        'btnLoginAndLogout
        '
        Me.btnLoginAndLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginAndLogout.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginAndLogout.ForeColor = System.Drawing.Color.White
        Me.btnLoginAndLogout.Location = New System.Drawing.Point(1239, 12)
        Me.btnLoginAndLogout.Name = "btnLoginAndLogout"
        Me.btnLoginAndLogout.Size = New System.Drawing.Size(100, 40)
        Me.btnLoginAndLogout.TabIndex = 11
        Me.btnLoginAndLogout.Text = "Login"
        Me.btnLoginAndLogout.UseVisualStyleBackColor = True
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1350, 64)
        Me.Controls.Add(Me.btnArtistPage)
        Me.Controls.Add(Me.btnSongPage)
        Me.Controls.Add(Me.btnBrandPage)
        Me.Controls.Add(Me.btnLoginAndLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminMenu"
        Me.Text = "AdminMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArtistPage As Button
    Friend WithEvents btnSongPage As Button
    Friend WithEvents btnBrandPage As Button
    Friend WithEvents btnLoginAndLogout As Button
End Class
