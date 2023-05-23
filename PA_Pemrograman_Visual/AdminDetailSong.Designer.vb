<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDetailSong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDetailSong))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelBackgroundSection = New System.Windows.Forms.Panel()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.pctIconPlayNPause = New System.Windows.Forms.PictureBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.panelListSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtSourceSong = New System.Windows.Forms.TextBox()
        Me.txtIdSong = New System.Windows.Forms.TextBox()
        Me.panelBackground = New System.Windows.Forms.Panel()
        Me.txtUpdate_at = New System.Windows.Forms.Label()
        Me.LabelUpdateAt = New System.Windows.Forms.Label()
        Me.iconDescription = New System.Windows.Forms.PictureBox()
        Me.iconGenre = New System.Windows.Forms.PictureBox()
        Me.iconTitle = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.iconFileSong = New System.Windows.Forms.PictureBox()
        Me.iconFileCover = New System.Windows.Forms.PictureBox()
        Me.fileCover = New System.Windows.Forms.TextBox()
        Me.fileSource = New System.Windows.Forms.TextBox()
        Me.btnFileSong = New System.Windows.Forms.Button()
        Me.btnFileCover = New System.Windows.Forms.Button()
        Me.pctIconSave = New System.Windows.Forms.PictureBox()
        Me.pctIconDelete = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cmbArtist = New System.Windows.Forms.ComboBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialogCover = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogSong = New System.Windows.Forms.OpenFileDialog()
        Me.panelBackgroundSection.SuspendLayout()
        CType(Me.pctIconPlayNPause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelListSong.SuspendLayout()
        Me.panelBackground.SuspendLayout()
        CType(Me.iconDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconGenre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconFileSong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconFileCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIconSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIconDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'panelBackgroundSection
        '
        Me.panelBackgroundSection.BackColor = System.Drawing.Color.White
        Me.panelBackgroundSection.Controls.Add(Me.lblSection)
        Me.panelBackgroundSection.Location = New System.Drawing.Point(0, 401)
        Me.panelBackgroundSection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelBackgroundSection.Name = "panelBackgroundSection"
        Me.panelBackgroundSection.Size = New System.Drawing.Size(1800, 49)
        Me.panelBackgroundSection.TabIndex = 15
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.White
        Me.lblSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSection.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(16, 10)
        Me.lblSection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(190, 29)
        Me.lblSection.TabIndex = 11
        Me.lblSection.Text = "Recommended"
        '
        'pctIconPlayNPause
        '
        Me.pctIconPlayNPause.Image = CType(resources.GetObject("pctIconPlayNPause.Image"), System.Drawing.Image)
        Me.pctIconPlayNPause.Location = New System.Drawing.Point(249, 230)
        Me.pctIconPlayNPause.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctIconPlayNPause.Name = "pctIconPlayNPause"
        Me.pctIconPlayNPause.Size = New System.Drawing.Size(100, 92)
        Me.pctIconPlayNPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconPlayNPause.TabIndex = 25
        Me.pctIconPlayNPause.TabStop = False
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(40, 37)
        Me.lblKeterangan.Margin = New System.Windows.Forms.Padding(40, 37, 0, 0)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(495, 32)
        Me.lblKeterangan.TabIndex = 2
        Me.lblKeterangan.Text = "Oops, saat ini tidak ada daftar lagu"
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(16, 7)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 37)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 12
        Me.btnBack.TabStop = False
        '
        'panelListSong
        '
        Me.panelListSong.AutoScroll = True
        Me.panelListSong.Controls.Add(Me.lblKeterangan)
        Me.panelListSong.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelListSong.Location = New System.Drawing.Point(0, 450)
        Me.panelListSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelListSong.Name = "panelListSong"
        Me.panelListSong.Size = New System.Drawing.Size(1800, 368)
        Me.panelListSong.TabIndex = 14
        '
        'txtSourceSong
        '
        Me.txtSourceSong.Location = New System.Drawing.Point(792, 15)
        Me.txtSourceSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSourceSong.Name = "txtSourceSong"
        Me.txtSourceSong.Size = New System.Drawing.Size(100, 22)
        Me.txtSourceSong.TabIndex = 17
        Me.txtSourceSong.Text = "source"
        Me.txtSourceSong.Visible = False
        '
        'txtIdSong
        '
        Me.txtIdSong.Location = New System.Drawing.Point(683, 15)
        Me.txtIdSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdSong.Name = "txtIdSong"
        Me.txtIdSong.Size = New System.Drawing.Size(100, 22)
        Me.txtIdSong.TabIndex = 10
        Me.txtIdSong.Text = "id"
        Me.txtIdSong.Visible = False
        '
        'panelBackground
        '
        Me.panelBackground.BackColor = System.Drawing.Color.White
        Me.panelBackground.Controls.Add(Me.txtUpdate_at)
        Me.panelBackground.Controls.Add(Me.LabelUpdateAt)
        Me.panelBackground.Controls.Add(Me.iconDescription)
        Me.panelBackground.Controls.Add(Me.iconGenre)
        Me.panelBackground.Controls.Add(Me.iconTitle)
        Me.panelBackground.Controls.Add(Me.Label4)
        Me.panelBackground.Controls.Add(Me.Label3)
        Me.panelBackground.Controls.Add(Me.Label2)
        Me.panelBackground.Controls.Add(Me.Label1)
        Me.panelBackground.Controls.Add(Me.txtArtist)
        Me.panelBackground.Controls.Add(Me.iconFileSong)
        Me.panelBackground.Controls.Add(Me.iconFileCover)
        Me.panelBackground.Controls.Add(Me.fileCover)
        Me.panelBackground.Controls.Add(Me.fileSource)
        Me.panelBackground.Controls.Add(Me.btnFileSong)
        Me.panelBackground.Controls.Add(Me.btnFileCover)
        Me.panelBackground.Controls.Add(Me.pctIconSave)
        Me.panelBackground.Controls.Add(Me.pctIconDelete)
        Me.panelBackground.Controls.Add(Me.txtDescription)
        Me.panelBackground.Controls.Add(Me.cmbArtist)
        Me.panelBackground.Controls.Add(Me.txtGenre)
        Me.panelBackground.Controls.Add(Me.txtTitle)
        Me.panelBackground.Controls.Add(Me.pctIconPlayNPause)
        Me.panelBackground.Controls.Add(Me.txtSourceSong)
        Me.panelBackground.Controls.Add(Me.txtIdSong)
        Me.panelBackground.Controls.Add(Me.pctCover)
        Me.panelBackground.Location = New System.Drawing.Point(16, 52)
        Me.panelBackground.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelBackground.Name = "panelBackground"
        Me.panelBackground.Size = New System.Drawing.Size(1768, 338)
        Me.panelBackground.TabIndex = 13
        '
        'txtUpdate_at
        '
        Me.txtUpdate_at.AutoSize = True
        Me.txtUpdate_at.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdate_at.Location = New System.Drawing.Point(487, 15)
        Me.txtUpdate_at.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtUpdate_at.Name = "txtUpdate_at"

        'Me.txtUpdate_at.Size = New System.Drawing.Size(113, 20)

        Me.txtUpdate_at.Size = New System.Drawing.Size(83, 16)

        Me.txtUpdate_at.TabIndex = 49
        Me.txtUpdate_at.Text = "2023/05/21"
        '
        'LabelUpdateAt
        '
        Me.LabelUpdateAt.AutoSize = True
        Me.LabelUpdateAt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUpdateAt.Location = New System.Drawing.Point(357, 15)
        Me.LabelUpdateAt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUpdateAt.Name = "LabelUpdateAt"

        'Me.LabelUpdateAt.Size = New System.Drawing.Size(125, 20)

        Me.LabelUpdateAt.Size = New System.Drawing.Size(98, 16)

        Me.LabelUpdateAt.TabIndex = 48
        Me.LabelUpdateAt.Text = "Last Update :"
        '
        'iconDescription
        '
        Me.iconDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconDescription.Image = CType(resources.GetObject("iconDescription.Image"), System.Drawing.Image)
        Me.iconDescription.Location = New System.Drawing.Point(1632, 215)
        Me.iconDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.iconDescription.Name = "iconDescription"
        Me.iconDescription.Size = New System.Drawing.Size(40, 37)
        Me.iconDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconDescription.TabIndex = 47
        Me.iconDescription.TabStop = False
        '
        'iconGenre
        '
        Me.iconGenre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconGenre.Image = CType(resources.GetObject("iconGenre.Image"), System.Drawing.Image)
        Me.iconGenre.Location = New System.Drawing.Point(901, 137)
        Me.iconGenre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.iconGenre.Name = "iconGenre"
        Me.iconGenre.Size = New System.Drawing.Size(40, 37)
        Me.iconGenre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconGenre.TabIndex = 46
        Me.iconGenre.TabStop = False
        '
        'iconTitle
        '
        Me.iconTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconTitle.Image = CType(resources.GetObject("iconTitle.Image"), System.Drawing.Image)
        Me.iconTitle.Location = New System.Drawing.Point(901, 47)
        Me.iconTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.iconTitle.Name = "iconTitle"
        Me.iconTitle.Size = New System.Drawing.Size(40, 37)
        Me.iconTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconTitle.TabIndex = 45
        Me.iconTitle.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(352, 183)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 29)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(352, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Artist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 29)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Genre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 29)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Title"
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(901, 15)
        Me.txtArtist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(100, 22)
        Me.txtArtist.TabIndex = 40
        Me.txtArtist.Text = "artist"
        Me.txtArtist.Visible = False
        '
        'iconFileSong
        '
        Me.iconFileSong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconFileSong.Image = CType(resources.GetObject("iconFileSong.Image"), System.Drawing.Image)
        Me.iconFileSong.Location = New System.Drawing.Point(1632, 92)
        Me.iconFileSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.iconFileSong.Name = "iconFileSong"
        Me.iconFileSong.Size = New System.Drawing.Size(40, 37)
        Me.iconFileSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconFileSong.TabIndex = 39
        Me.iconFileSong.TabStop = False
        '
        'iconFileCover
        '
        Me.iconFileCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconFileCover.Image = CType(resources.GetObject("iconFileCover.Image"), System.Drawing.Image)
        Me.iconFileCover.Location = New System.Drawing.Point(1632, 47)
        Me.iconFileCover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.iconFileCover.Name = "iconFileCover"
        Me.iconFileCover.Size = New System.Drawing.Size(40, 37)
        Me.iconFileCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconFileCover.TabIndex = 38
        Me.iconFileCover.TabStop = False
        '
        'fileCover
        '
        Me.fileCover.BackColor = System.Drawing.Color.White
        Me.fileCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fileCover.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.fileCover.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileCover.Location = New System.Drawing.Point(1143, 47)
        Me.fileCover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fileCover.Multiline = True
        Me.fileCover.Name = "fileCover"
        Me.fileCover.ReadOnly = True
        Me.fileCover.Size = New System.Drawing.Size(481, 36)
        Me.fileCover.TabIndex = 37
        Me.fileCover.Text = "Cover"
        '
        'fileSource
        '
        Me.fileSource.BackColor = System.Drawing.Color.White
        Me.fileSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fileSource.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.fileSource.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fileSource.Location = New System.Drawing.Point(1143, 92)
        Me.fileSource.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fileSource.Multiline = True
        Me.fileSource.Name = "fileSource"
        Me.fileSource.ReadOnly = True
        Me.fileSource.Size = New System.Drawing.Size(481, 36)
        Me.fileSource.TabIndex = 36
        Me.fileSource.Text = "Song"
        '
        'btnFileSong
        '
        Me.btnFileSong.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnFileSong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFileSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileSong.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileSong.ForeColor = System.Drawing.Color.White
        Me.btnFileSong.Location = New System.Drawing.Point(949, 91)
        Me.btnFileSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFileSong.Name = "btnFileSong"
        Me.btnFileSong.Size = New System.Drawing.Size(185, 38)
        Me.btnFileSong.TabIndex = 34
        Me.btnFileSong.Text = "Choose Song"
        Me.btnFileSong.UseVisualStyleBackColor = False
        '
        'btnFileCover
        '
        Me.btnFileCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnFileCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFileCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileCover.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileCover.ForeColor = System.Drawing.Color.White
        Me.btnFileCover.Location = New System.Drawing.Point(949, 46)
        Me.btnFileCover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFileCover.Name = "btnFileCover"
        Me.btnFileCover.Size = New System.Drawing.Size(185, 38)
        Me.btnFileCover.TabIndex = 33
        Me.btnFileCover.Text = "Choose Cover"
        Me.btnFileCover.UseVisualStyleBackColor = False
        '
        'pctIconSave
        '
        Me.pctIconSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconSave.Image = CType(resources.GetObject("pctIconSave.Image"), System.Drawing.Image)
        Me.pctIconSave.Location = New System.Drawing.Point(1645, 286)
        Me.pctIconSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctIconSave.Name = "pctIconSave"
        Me.pctIconSave.Size = New System.Drawing.Size(40, 37)
        Me.pctIconSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconSave.TabIndex = 31
        Me.pctIconSave.TabStop = False
        '
        'pctIconDelete
        '
        Me.pctIconDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconDelete.Image = CType(resources.GetObject("pctIconDelete.Image"), System.Drawing.Image)
        Me.pctIconDelete.Location = New System.Drawing.Point(1707, 286)
        Me.pctIconDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctIconDelete.Name = "pctIconDelete"
        Me.pctIconDelete.Size = New System.Drawing.Size(40, 37)
        Me.pctIconDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconDelete.TabIndex = 30
        Me.pctIconDelete.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(357, 215)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(1266, 107)
        Me.txtDescription.TabIndex = 29
        Me.txtDescription.Text = "Description"
        '
        'cmbArtist
        '
        Me.cmbArtist.BackColor = System.Drawing.Color.White
        Me.cmbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbArtist.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbArtist.FormattingEnabled = True
        Me.cmbArtist.Location = New System.Drawing.Point(453, 91)
        Me.cmbArtist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbArtist.Name = "cmbArtist"

        'Me.cmbArtist.Size = New System.Drawing.Size(439, 37)

        Me.cmbArtist.Size = New System.Drawing.Size(439, 31)

        Me.cmbArtist.TabIndex = 28
        '
        'txtGenre
        '
        Me.txtGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenre.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenre.Location = New System.Drawing.Point(453, 137)
        Me.txtGenre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGenre.Multiline = True
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(439, 36)
        Me.txtGenre.TabIndex = 27
        Me.txtGenre.Text = "Genre"
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(453, 47)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(439, 36)
        Me.txtTitle.TabIndex = 26
        Me.txtTitle.Text = "Title"
        '
        'pctCover
        '
        Me.pctCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctCover.Image = CType(resources.GetObject("pctCover.Image"), System.Drawing.Image)
        Me.pctCover.Location = New System.Drawing.Point(16, 15)
        Me.pctCover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctCover.Name = "pctCover"
        Me.pctCover.Size = New System.Drawing.Size(333, 308)
        Me.pctCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCover.TabIndex = 0
        Me.pctCover.TabStop = False
        '
        'OpenFileDialogCover
        '
        Me.OpenFileDialogCover.FileName = "OpenFileDialog1"
        '
        'OpenFileDialogSong
        '
        Me.OpenFileDialogSong.FileName = "OpenFileDialog1"
        '
        'AdminDetailSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1800, 818)
        Me.Controls.Add(Me.panelBackgroundSection)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.panelListSong)
        Me.Controls.Add(Me.panelBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminDetailSong"
        Me.Text = "AdminUpdateSong"
        Me.panelBackgroundSection.ResumeLayout(False)
        Me.panelBackgroundSection.PerformLayout()
        CType(Me.pctIconPlayNPause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelListSong.ResumeLayout(False)
        Me.panelListSong.PerformLayout()
        Me.panelBackground.ResumeLayout(False)
        Me.panelBackground.PerformLayout()
        CType(Me.iconDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconGenre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconFileSong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconFileCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIconSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIconDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelBackgroundSection As Panel
    Friend WithEvents lblSection As Label
    Friend WithEvents pctIconPlayNPause As PictureBox
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents panelListSong As FlowLayoutPanel
    Friend WithEvents txtSourceSong As TextBox
    Friend WithEvents txtIdSong As TextBox
    Friend WithEvents panelBackground As Panel
    Friend WithEvents pctCover As PictureBox
    Friend WithEvents pctIconSave As PictureBox
    Friend WithEvents pctIconDelete As PictureBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents cmbArtist As ComboBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents OpenFileDialogCover As OpenFileDialog
    Friend WithEvents iconFileSong As PictureBox
    Friend WithEvents iconFileCover As PictureBox
    Friend WithEvents fileCover As TextBox
    Friend WithEvents fileSource As TextBox
    Friend WithEvents btnFileSong As Button
    Friend WithEvents btnFileCover As Button
    Friend WithEvents OpenFileDialogSong As OpenFileDialog
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents iconDescription As PictureBox
    Friend WithEvents iconGenre As PictureBox
    Friend WithEvents iconTitle As PictureBox
    Friend WithEvents txtUpdate_at As Label
    Friend WithEvents LabelUpdateAt As Label
End Class
