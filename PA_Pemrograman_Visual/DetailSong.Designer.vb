<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetailSong
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailSong))
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.panelBackground = New System.Windows.Forms.Panel()
        Me.pctIconPlayNPause = New System.Windows.Forms.PictureBox()
        Me.panelListPlaylist = New System.Windows.Forms.Panel()
        Me.lblListPlaylist = New System.Windows.Forms.Label()
        Me.btnBackgroundListPlaylist = New System.Windows.Forms.Button()
        Me.panelWrapper = New System.Windows.Forms.FlowLayoutPanel()
        Me.listKosong = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtDescription = New System.Windows.Forms.Label()
        Me.txtGenre = New System.Windows.Forms.Label()
        Me.txtArtist = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.txtSourceSong = New System.Windows.Forms.TextBox()
        Me.txtIdSong = New System.Windows.Forms.TextBox()
        Me.pctIconAddPlaylist = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.panelListSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.panelBackgroundSection = New System.Windows.Forms.Panel()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBackground.SuspendLayout()
        CType(Me.pctIconPlayNPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelListPlaylist.SuspendLayout()
        Me.panelWrapper.SuspendLayout()
        CType(Me.pctIconAddPlaylist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelListSong.SuspendLayout()
        Me.panelBackgroundSection.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctCover
        '
        Me.pctCover.Image = CType(resources.GetObject("pctCover.Image"), System.Drawing.Image)
        Me.pctCover.Location = New System.Drawing.Point(12, 12)
        Me.pctCover.Name = "pctCover"
        Me.pctCover.Size = New System.Drawing.Size(250, 250)
        Me.pctCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCover.TabIndex = 0
        Me.pctCover.TabStop = False
        '
        'panelBackground
        '
        Me.panelBackground.BackColor = System.Drawing.Color.White
        Me.panelBackground.Controls.Add(Me.pctIconPlayNPause)
        Me.panelBackground.Controls.Add(Me.panelListPlaylist)
        Me.panelBackground.Controls.Add(Me.txtDescription)
        Me.panelBackground.Controls.Add(Me.txtGenre)
        Me.panelBackground.Controls.Add(Me.txtArtist)
        Me.panelBackground.Controls.Add(Me.txtTitle)
        Me.panelBackground.Controls.Add(Me.txtSourceSong)
        Me.panelBackground.Controls.Add(Me.txtIdSong)
        Me.panelBackground.Controls.Add(Me.pctIconAddPlaylist)
        Me.panelBackground.Controls.Add(Me.pctCover)
        Me.panelBackground.Location = New System.Drawing.Point(12, 48)
        Me.panelBackground.Name = "panelBackground"
        Me.panelBackground.Size = New System.Drawing.Size(1326, 275)
        Me.panelBackground.TabIndex = 5
        '
        'pctIconPlayNPause
        '
        Me.pctIconPlayNPause.Image = CType(resources.GetObject("pctIconPlayNPause.Image"), System.Drawing.Image)
        Me.pctIconPlayNPause.Location = New System.Drawing.Point(187, 187)
        Me.pctIconPlayNPause.Name = "pctIconPlayNPause"
        Me.pctIconPlayNPause.Size = New System.Drawing.Size(75, 75)
        Me.pctIconPlayNPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconPlayNPause.TabIndex = 25
        Me.pctIconPlayNPause.TabStop = False
        '
        'panelListPlaylist
        '
        Me.panelListPlaylist.Controls.Add(Me.lblListPlaylist)
        Me.panelListPlaylist.Controls.Add(Me.btnBackgroundListPlaylist)
        Me.panelListPlaylist.Controls.Add(Me.panelWrapper)
        Me.panelListPlaylist.Controls.Add(Me.btnCancel)
        Me.panelListPlaylist.Location = New System.Drawing.Point(1116, 12)
        Me.panelListPlaylist.Name = "panelListPlaylist"
        Me.panelListPlaylist.Size = New System.Drawing.Size(197, 197)
        Me.panelListPlaylist.TabIndex = 24
        '
        'lblListPlaylist
        '
        Me.lblListPlaylist.AutoSize = True
        Me.lblListPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListPlaylist.Location = New System.Drawing.Point(64, 4)
        Me.lblListPlaylist.Name = "lblListPlaylist"
        Me.lblListPlaylist.Size = New System.Drawing.Size(66, 24)
        Me.lblListPlaylist.TabIndex = 26
        Me.lblListPlaylist.Text = "Playlist"
        '
        'btnBackgroundListPlaylist
        '
        Me.btnBackgroundListPlaylist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBackgroundListPlaylist.Enabled = False
        Me.btnBackgroundListPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackgroundListPlaylist.Location = New System.Drawing.Point(0, 0)
        Me.btnBackgroundListPlaylist.Name = "btnBackgroundListPlaylist"
        Me.btnBackgroundListPlaylist.Size = New System.Drawing.Size(197, 32)
        Me.btnBackgroundListPlaylist.TabIndex = 27
        Me.btnBackgroundListPlaylist.UseVisualStyleBackColor = True
        '
        'panelWrapper
        '
        Me.panelWrapper.AutoScroll = True
        Me.panelWrapper.Controls.Add(Me.listKosong)
        Me.panelWrapper.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelWrapper.Location = New System.Drawing.Point(0, 32)
        Me.panelWrapper.Name = "panelWrapper"
        Me.panelWrapper.Size = New System.Drawing.Size(197, 133)
        Me.panelWrapper.TabIndex = 25
        '
        'listKosong
        '
        Me.listKosong.AutoSize = True
        Me.listKosong.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listKosong.Location = New System.Drawing.Point(33, 55)
        Me.listKosong.Margin = New System.Windows.Forms.Padding(33, 55, 0, 0)
        Me.listKosong.Name = "listKosong"
        Me.listKosong.Size = New System.Drawing.Size(133, 18)
        Me.listKosong.TabIndex = 25
        Me.listKosong.Text = "Playlist Kosong"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(0, 165)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(197, 32)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.AutoSize = True
        Me.txtDescription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(270, 170)
        Me.txtDescription.MaximumSize = New System.Drawing.Size(800, 117)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 18)
        Me.txtDescription.TabIndex = 22
        Me.txtDescription.Text = "Description"
        '
        'txtGenre
        '
        Me.txtGenre.AutoSize = True
        Me.txtGenre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre.Location = New System.Drawing.Point(270, 140)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(56, 18)
        Me.txtGenre.TabIndex = 21
        Me.txtGenre.Text = "Genre"
        '
        'txtArtist
        '
        Me.txtArtist.AutoSize = True
        Me.txtArtist.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArtist.Location = New System.Drawing.Point(270, 105)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(61, 23)
        Me.txtArtist.TabIndex = 20
        Me.txtArtist.Text = "Artist"
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(270, 70)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(58, 25)
        Me.txtTitle.TabIndex = 19
        Me.txtTitle.Text = "Title"
        '
        'txtSourceSong
        '
        Me.txtSourceSong.Location = New System.Drawing.Point(350, 12)
        Me.txtSourceSong.Name = "txtSourceSong"
        Me.txtSourceSong.Size = New System.Drawing.Size(76, 20)
        Me.txtSourceSong.TabIndex = 17
        Me.txtSourceSong.Text = "source"
        Me.txtSourceSong.Visible = False
        '
        'txtIdSong
        '
        Me.txtIdSong.Location = New System.Drawing.Point(268, 12)
        Me.txtIdSong.Name = "txtIdSong"
        Me.txtIdSong.Size = New System.Drawing.Size(76, 20)
        Me.txtIdSong.TabIndex = 10
        Me.txtIdSong.Text = "id"
        Me.txtIdSong.Visible = False
        '
        'pctIconAddPlaylist
        '
        Me.pctIconAddPlaylist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconAddPlaylist.Image = CType(resources.GetObject("pctIconAddPlaylist.Image"), System.Drawing.Image)
        Me.pctIconAddPlaylist.Location = New System.Drawing.Point(1273, 222)
        Me.pctIconAddPlaylist.Name = "pctIconAddPlaylist"
        Me.pctIconAddPlaylist.Size = New System.Drawing.Size(40, 40)
        Me.pctIconAddPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconAddPlaylist.TabIndex = 13
        Me.pctIconAddPlaylist.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 30)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 4
        Me.btnBack.TabStop = False
        '
        'panelListSong
        '
        Me.panelListSong.AutoScroll = True
        Me.panelListSong.Controls.Add(Me.lblKeterangan)
        Me.panelListSong.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelListSong.Location = New System.Drawing.Point(0, 375)
        Me.panelListSong.Name = "panelListSong"
        Me.panelListSong.Size = New System.Drawing.Size(1350, 290)
        Me.panelListSong.TabIndex = 6
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(30, 30)
        Me.lblKeterangan.Margin = New System.Windows.Forms.Padding(30, 30, 0, 0)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(385, 25)
        Me.lblKeterangan.TabIndex = 2
        Me.lblKeterangan.Text = "Oops, saat ini tidak ada daftar lagu"
        '
        'panelBackgroundSection
        '
        Me.panelBackgroundSection.BackColor = System.Drawing.Color.White
        Me.panelBackgroundSection.Controls.Add(Me.lblSection)
        Me.panelBackgroundSection.Location = New System.Drawing.Point(0, 335)
        Me.panelBackgroundSection.Name = "panelBackgroundSection"
        Me.panelBackgroundSection.Size = New System.Drawing.Size(1350, 40)
        Me.panelBackgroundSection.TabIndex = 11
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.White
        Me.lblSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSection.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(12, 8)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(150, 23)
        Me.lblSection.TabIndex = 11
        Me.lblSection.Text = "Recommended"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DetailSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 665)
        Me.Controls.Add(Me.panelBackgroundSection)
        Me.Controls.Add(Me.panelBackground)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.panelListSong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DetailSong"
        Me.Text = "DetailSong"
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBackground.ResumeLayout(False)
        Me.panelBackground.PerformLayout()
        CType(Me.pctIconPlayNPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelListPlaylist.ResumeLayout(False)
        Me.panelListPlaylist.PerformLayout()
        Me.panelWrapper.ResumeLayout(False)
        Me.panelWrapper.PerformLayout()
        CType(Me.pctIconAddPlaylist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelListSong.ResumeLayout(False)
        Me.panelListSong.PerformLayout()
        Me.panelBackgroundSection.ResumeLayout(False)
        Me.panelBackgroundSection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctCover As PictureBox
    Friend WithEvents panelBackground As Panel
    Friend WithEvents txtIdSong As TextBox
    Friend WithEvents pctIconAddPlaylist As PictureBox
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents panelListSong As FlowLayoutPanel
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents txtSourceSong As TextBox
    Friend WithEvents txtDescription As Label
    Friend WithEvents txtGenre As Label
    Friend WithEvents txtArtist As Label
    Friend WithEvents txtTitle As Label
    Friend WithEvents panelBackgroundSection As Panel
    Friend WithEvents lblSection As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents panelListPlaylist As Panel
    Friend WithEvents panelWrapper As FlowLayoutPanel
    Friend WithEvents lblListPlaylist As Label
    Friend WithEvents btnBackgroundListPlaylist As Button
    Friend WithEvents listKosong As Label
    Friend WithEvents pctIconPlayNPause As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
