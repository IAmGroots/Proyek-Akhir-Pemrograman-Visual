<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SongInPlaylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SongInPlaylist))
        Me.iconDelete = New System.Windows.Forms.PictureBox()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.txtIdSong = New System.Windows.Forms.TextBox()
        Me.txtSourceSong = New System.Windows.Forms.TextBox()
        Me.pctIconPlayNPause = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.atas = New System.Windows.Forms.Panel()
        Me.kiri = New System.Windows.Forms.Panel()
        Me.kanan = New System.Windows.Forms.Panel()
        Me.bawah = New System.Windows.Forms.Panel()
        Me.txtIdPlaylist = New System.Windows.Forms.TextBox()
        CType(Me.iconDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIconPlayNPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'iconDelete
        '
        Me.iconDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconDelete.Image = CType(resources.GetObject("iconDelete.Image"), System.Drawing.Image)
        Me.iconDelete.Location = New System.Drawing.Point(618, 57)
        Me.iconDelete.Name = "iconDelete"
        Me.iconDelete.Size = New System.Drawing.Size(30, 30)
        Me.iconDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconDelete.TabIndex = 7
        Me.iconDelete.TabStop = False
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist.Location = New System.Drawing.Point(102, 64)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(61, 23)
        Me.lblArtist.TabIndex = 6
        Me.lblArtist.Text = "Artist"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(102, 29)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(52, 23)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Title"
        '
        'pctCover
        '
        Me.pctCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctCover.Image = CType(resources.GetObject("pctCover.Image"), System.Drawing.Image)
        Me.pctCover.Location = New System.Drawing.Point(12, 12)
        Me.pctCover.Name = "pctCover"
        Me.pctCover.Size = New System.Drawing.Size(75, 75)
        Me.pctCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCover.TabIndex = 4
        Me.pctCover.TabStop = False
        '
        'txtIdSong
        '
        Me.txtIdSong.Location = New System.Drawing.Point(490, 12)
        Me.txtIdSong.Name = "txtIdSong"
        Me.txtIdSong.Size = New System.Drawing.Size(76, 20)
        Me.txtIdSong.TabIndex = 9
        Me.txtIdSong.Text = "id song"
        Me.txtIdSong.Visible = False
        '
        'txtSourceSong
        '
        Me.txtSourceSong.Location = New System.Drawing.Point(572, 12)
        Me.txtSourceSong.Name = "txtSourceSong"
        Me.txtSourceSong.Size = New System.Drawing.Size(76, 20)
        Me.txtSourceSong.TabIndex = 8
        Me.txtSourceSong.Text = "source"
        Me.txtSourceSong.Visible = False
        '
        'pctIconPlayNPause
        '
        Me.pctIconPlayNPause.Image = CType(resources.GetObject("pctIconPlayNPause.Image"), System.Drawing.Image)
        Me.pctIconPlayNPause.Location = New System.Drawing.Point(47, 47)
        Me.pctIconPlayNPause.Name = "pctIconPlayNPause"
        Me.pctIconPlayNPause.Size = New System.Drawing.Size(40, 40)
        Me.pctIconPlayNPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconPlayNPause.TabIndex = 10
        Me.pctIconPlayNPause.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'atas
        '
        Me.atas.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.atas.Dock = System.Windows.Forms.DockStyle.Top
        Me.atas.Location = New System.Drawing.Point(0, 0)
        Me.atas.Name = "atas"
        Me.atas.Size = New System.Drawing.Size(660, 2)
        Me.atas.TabIndex = 11
        '
        'kiri
        '
        Me.kiri.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.kiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.kiri.Location = New System.Drawing.Point(0, 2)
        Me.kiri.Name = "kiri"
        Me.kiri.Size = New System.Drawing.Size(2, 97)
        Me.kiri.TabIndex = 12
        '
        'kanan
        '
        Me.kanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.kanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.kanan.Location = New System.Drawing.Point(658, 2)
        Me.kanan.Name = "kanan"
        Me.kanan.Size = New System.Drawing.Size(2, 97)
        Me.kanan.TabIndex = 14
        '
        'bawah
        '
        Me.bawah.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.bawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bawah.Location = New System.Drawing.Point(2, 97)
        Me.bawah.Name = "bawah"
        Me.bawah.Size = New System.Drawing.Size(656, 2)
        Me.bawah.TabIndex = 15
        '
        'txtIdPlaylist
        '
        Me.txtIdPlaylist.BackColor = System.Drawing.Color.White
        Me.txtIdPlaylist.Location = New System.Drawing.Point(408, 12)
        Me.txtIdPlaylist.Name = "txtIdPlaylist"
        Me.txtIdPlaylist.Size = New System.Drawing.Size(76, 20)
        Me.txtIdPlaylist.TabIndex = 16
        Me.txtIdPlaylist.Text = "id playlist"
        Me.txtIdPlaylist.Visible = False
        '
        'SongInPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(660, 99)
        Me.Controls.Add(Me.txtIdPlaylist)
        Me.Controls.Add(Me.bawah)
        Me.Controls.Add(Me.kanan)
        Me.Controls.Add(Me.kiri)
        Me.Controls.Add(Me.atas)
        Me.Controls.Add(Me.pctIconPlayNPause)
        Me.Controls.Add(Me.txtIdSong)
        Me.Controls.Add(Me.txtSourceSong)
        Me.Controls.Add(Me.iconDelete)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pctCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SongInPlaylist"
        Me.Text = "SongInPlaylist"
        CType(Me.iconDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIconPlayNPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents iconDelete As PictureBox
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents pctCover As PictureBox
    Friend WithEvents txtIdSong As TextBox
    Friend WithEvents txtSourceSong As TextBox
    Friend WithEvents pctIconPlayNPause As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents atas As Panel
    Friend WithEvents kiri As Panel
    Friend WithEvents kanan As Panel
    Friend WithEvents bawah As Panel
    Friend WithEvents txtIdPlaylist As TextBox
End Class
