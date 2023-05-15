<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnHomePage = New System.Windows.Forms.Button()
        Me.btnSearchPage = New System.Windows.Forms.Button()
        Me.btnPlaylistPage = New System.Windows.Forms.Button()
        Me.btnBrandPage = New System.Windows.Forms.Button()
        Me.btnLoginAndLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHomePage
        '
        Me.btnHomePage.BackColor = System.Drawing.Color.Transparent
        Me.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHomePage.FlatAppearance.BorderSize = 0
        Me.btnHomePage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHomePage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHomePage.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomePage.ForeColor = System.Drawing.Color.White
        Me.btnHomePage.Location = New System.Drawing.Point(498, 12)
        Me.btnHomePage.Name = "btnHomePage"
        Me.btnHomePage.Size = New System.Drawing.Size(100, 40)
        Me.btnHomePage.TabIndex = 0
        Me.btnHomePage.Text = "Home"
        Me.btnHomePage.UseVisualStyleBackColor = False
        '
        'btnSearchPage
        '
        Me.btnSearchPage.BackColor = System.Drawing.Color.Transparent
        Me.btnSearchPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchPage.FlatAppearance.BorderSize = 0
        Me.btnSearchPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSearchPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSearchPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchPage.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPage.ForeColor = System.Drawing.Color.White
        Me.btnSearchPage.Location = New System.Drawing.Point(638, 12)
        Me.btnSearchPage.Name = "btnSearchPage"
        Me.btnSearchPage.Size = New System.Drawing.Size(100, 40)
        Me.btnSearchPage.TabIndex = 1
        Me.btnSearchPage.Text = "Search"
        Me.btnSearchPage.UseVisualStyleBackColor = False
        '
        'btnPlaylistPage
        '
        Me.btnPlaylistPage.BackColor = System.Drawing.Color.Transparent
        Me.btnPlaylistPage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlaylistPage.FlatAppearance.BorderSize = 0
        Me.btnPlaylistPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPlaylistPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPlaylistPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlaylistPage.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlaylistPage.ForeColor = System.Drawing.Color.White
        Me.btnPlaylistPage.Location = New System.Drawing.Point(778, 12)
        Me.btnPlaylistPage.Name = "btnPlaylistPage"
        Me.btnPlaylistPage.Size = New System.Drawing.Size(100, 40)
        Me.btnPlaylistPage.TabIndex = 2
        Me.btnPlaylistPage.Text = "Playlist"
        Me.btnPlaylistPage.UseVisualStyleBackColor = False
        '
        'btnBrandPage
        '
        Me.btnBrandPage.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBrandPage.FlatAppearance.BorderSize = 0
        Me.btnBrandPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrandPage.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrandPage.ForeColor = System.Drawing.Color.White
        Me.btnBrandPage.Location = New System.Drawing.Point(11, 12)
        Me.btnBrandPage.Name = "btnBrandPage"
        Me.btnBrandPage.Size = New System.Drawing.Size(175, 40)
        Me.btnBrandPage.TabIndex = 3
        Me.btnBrandPage.Text = "XtremeMusix"
        Me.btnBrandPage.UseVisualStyleBackColor = False
        '
        'btnLoginAndLogout
        '
        Me.btnLoginAndLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoginAndLogout.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginAndLogout.ForeColor = System.Drawing.Color.White
        Me.btnLoginAndLogout.Location = New System.Drawing.Point(1238, 12)
        Me.btnLoginAndLogout.Name = "btnLoginAndLogout"
        Me.btnLoginAndLogout.Size = New System.Drawing.Size(100, 40)
        Me.btnLoginAndLogout.TabIndex = 6
        Me.btnLoginAndLogout.Text = "Login"
        Me.btnLoginAndLogout.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1350, 64)
        Me.Controls.Add(Me.btnPlaylistPage)
        Me.Controls.Add(Me.btnSearchPage)
        Me.Controls.Add(Me.btnHomePage)
        Me.Controls.Add(Me.btnBrandPage)
        Me.Controls.Add(Me.btnLoginAndLogout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnHomePage As Button
    Friend WithEvents btnSearchPage As Button
    Friend WithEvents btnPlaylistPage As Button
    Friend WithEvents btnBrandPage As Button
    Friend WithEvents btnLoginAndLogout As Button
End Class
