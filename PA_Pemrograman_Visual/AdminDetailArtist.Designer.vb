<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDetailArtist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminDetailArtist))
        Me.txtUpdate_at = New System.Windows.Forms.Label()
        Me.OpenFileDialogCover = New System.Windows.Forms.OpenFileDialog()
        Me.LabelUpdateAt = New System.Windows.Forms.Label()
        Me.iconDescription = New System.Windows.Forms.PictureBox()
        Me.iconCountry = New System.Windows.Forms.PictureBox()
        Me.iconName = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelBackgroundSection = New System.Windows.Forms.Panel()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.panelBackground = New System.Windows.Forms.Panel()
        Me.iconFileCover = New System.Windows.Forms.PictureBox()
        Me.fileCover = New System.Windows.Forms.TextBox()
        Me.btnFileCover = New System.Windows.Forms.Button()
        Me.pctIconSave = New System.Windows.Forms.PictureBox()
        Me.pctIconDelete = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtIdArtist = New System.Windows.Forms.TextBox()
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.panelListSong = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.iconDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBackgroundSection.SuspendLayout()
        Me.panelBackground.SuspendLayout()
        CType(Me.iconFileCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIconSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIconDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelListSong.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUpdate_at
        '
        Me.txtUpdate_at.AutoSize = True
        Me.txtUpdate_at.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdate_at.Location = New System.Drawing.Point(365, 12)
        Me.txtUpdate_at.Name = "txtUpdate_at"
        Me.txtUpdate_at.Size = New System.Drawing.Size(83, 16)
        Me.txtUpdate_at.TabIndex = 49
        Me.txtUpdate_at.Text = "2023/05/21"
        '
        'OpenFileDialogCover
        '
        Me.OpenFileDialogCover.FileName = "OpenFileDialog1"
        '
        'LabelUpdateAt
        '
        Me.LabelUpdateAt.AutoSize = True
        Me.LabelUpdateAt.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUpdateAt.Location = New System.Drawing.Point(268, 12)
        Me.LabelUpdateAt.Name = "LabelUpdateAt"
        Me.LabelUpdateAt.Size = New System.Drawing.Size(98, 16)
        Me.LabelUpdateAt.TabIndex = 48
        Me.LabelUpdateAt.Text = "Last Update :"
        '
        'iconDescription
        '
        Me.iconDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconDescription.Image = CType(resources.GetObject("iconDescription.Image"), System.Drawing.Image)
        Me.iconDescription.Location = New System.Drawing.Point(1224, 175)
        Me.iconDescription.Name = "iconDescription"
        Me.iconDescription.Size = New System.Drawing.Size(30, 30)
        Me.iconDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconDescription.TabIndex = 47
        Me.iconDescription.TabStop = False
        '
        'iconCountry
        '
        Me.iconCountry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconCountry.Image = CType(resources.GetObject("iconCountry.Image"), System.Drawing.Image)
        Me.iconCountry.Location = New System.Drawing.Point(669, 111)
        Me.iconCountry.Name = "iconCountry"
        Me.iconCountry.Size = New System.Drawing.Size(30, 30)
        Me.iconCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconCountry.TabIndex = 46
        Me.iconCountry.TabStop = False
        '
        'iconName
        '
        Me.iconName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconName.Image = CType(resources.GetObject("iconName.Image"), System.Drawing.Image)
        Me.iconName.Location = New System.Drawing.Point(669, 74)
        Me.iconName.Name = "iconName"
        Me.iconName.Size = New System.Drawing.Size(30, 30)
        Me.iconName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconName.TabIndex = 45
        Me.iconName.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 23)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(264, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 23)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Country"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(264, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Name"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'panelBackgroundSection
        '
        Me.panelBackgroundSection.BackColor = System.Drawing.Color.White
        Me.panelBackgroundSection.Controls.Add(Me.lblSection)
        Me.panelBackgroundSection.Location = New System.Drawing.Point(0, 326)
        Me.panelBackgroundSection.Name = "panelBackgroundSection"
        Me.panelBackgroundSection.Size = New System.Drawing.Size(1350, 40)
        Me.panelBackgroundSection.TabIndex = 19
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.White
        Me.lblSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSection.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(12, 8)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(59, 23)
        Me.lblSection.TabIndex = 11
        Me.lblSection.Text = "Song"
        '
        'panelBackground
        '
        Me.panelBackground.BackColor = System.Drawing.Color.White
        Me.panelBackground.Controls.Add(Me.txtUpdate_at)
        Me.panelBackground.Controls.Add(Me.LabelUpdateAt)
        Me.panelBackground.Controls.Add(Me.iconDescription)
        Me.panelBackground.Controls.Add(Me.iconCountry)
        Me.panelBackground.Controls.Add(Me.iconName)
        Me.panelBackground.Controls.Add(Me.Label4)
        Me.panelBackground.Controls.Add(Me.Label2)
        Me.panelBackground.Controls.Add(Me.Label1)
        Me.panelBackground.Controls.Add(Me.iconFileCover)
        Me.panelBackground.Controls.Add(Me.fileCover)
        Me.panelBackground.Controls.Add(Me.btnFileCover)
        Me.panelBackground.Controls.Add(Me.pctIconSave)
        Me.panelBackground.Controls.Add(Me.pctIconDelete)
        Me.panelBackground.Controls.Add(Me.txtDescription)
        Me.panelBackground.Controls.Add(Me.txtCountry)
        Me.panelBackground.Controls.Add(Me.txtName)
        Me.panelBackground.Controls.Add(Me.txtIdArtist)
        Me.panelBackground.Controls.Add(Me.pctCover)
        Me.panelBackground.Location = New System.Drawing.Point(12, 42)
        Me.panelBackground.Name = "panelBackground"
        Me.panelBackground.Size = New System.Drawing.Size(1326, 275)
        Me.panelBackground.TabIndex = 17
        '
        'iconFileCover
        '
        Me.iconFileCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconFileCover.Image = CType(resources.GetObject("iconFileCover.Image"), System.Drawing.Image)
        Me.iconFileCover.Location = New System.Drawing.Point(1224, 94)
        Me.iconFileCover.Name = "iconFileCover"
        Me.iconFileCover.Size = New System.Drawing.Size(30, 30)
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
        Me.fileCover.Location = New System.Drawing.Point(850, 94)
        Me.fileCover.Multiline = True
        Me.fileCover.Name = "fileCover"
        Me.fileCover.ReadOnly = True
        Me.fileCover.Size = New System.Drawing.Size(368, 30)
        Me.fileCover.TabIndex = 37
        Me.fileCover.Text = "Cover"
        '
        'btnFileCover
        '
        Me.btnFileCover.BackColor = System.Drawing.Color.Moccasin
        Me.btnFileCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFileCover.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileCover.ForeColor = System.Drawing.Color.Black
        Me.btnFileCover.Location = New System.Drawing.Point(705, 93)
        Me.btnFileCover.Name = "btnFileCover"
        Me.btnFileCover.Size = New System.Drawing.Size(139, 31)
        Me.btnFileCover.TabIndex = 33
        Me.btnFileCover.Text = "Choose Cover"
        Me.btnFileCover.UseVisualStyleBackColor = False
        '
        'pctIconSave
        '
        Me.pctIconSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconSave.Image = CType(resources.GetObject("pctIconSave.Image"), System.Drawing.Image)
        Me.pctIconSave.Location = New System.Drawing.Point(1234, 232)
        Me.pctIconSave.Name = "pctIconSave"
        Me.pctIconSave.Size = New System.Drawing.Size(30, 30)
        Me.pctIconSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconSave.TabIndex = 31
        Me.pctIconSave.TabStop = False
        '
        'pctIconDelete
        '
        Me.pctIconDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconDelete.Image = CType(resources.GetObject("pctIconDelete.Image"), System.Drawing.Image)
        Me.pctIconDelete.Location = New System.Drawing.Point(1280, 232)
        Me.pctIconDelete.Name = "pctIconDelete"
        Me.pctIconDelete.Size = New System.Drawing.Size(30, 30)
        Me.pctIconDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconDelete.TabIndex = 30
        Me.pctIconDelete.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(268, 175)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(950, 87)
        Me.txtDescription.TabIndex = 29
        Me.txtDescription.Text = "Description"
        '
        'txtCountry
        '
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(363, 111)
        Me.txtCountry.Multiline = True
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(300, 30)
        Me.txtCountry.TabIndex = 27
        Me.txtCountry.Text = "Country"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(363, 74)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(300, 30)
        Me.txtName.TabIndex = 26
        Me.txtName.Text = "Title"
        '
        'txtIdArtist
        '
        Me.txtIdArtist.Location = New System.Drawing.Point(512, 12)
        Me.txtIdArtist.Name = "txtIdArtist"
        Me.txtIdArtist.Size = New System.Drawing.Size(76, 20)
        Me.txtIdArtist.TabIndex = 10
        Me.txtIdArtist.Text = "id"
        Me.txtIdArtist.Visible = False
        '
        'pctCover
        '
        Me.pctCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctCover.Image = CType(resources.GetObject("pctCover.Image"), System.Drawing.Image)
        Me.pctCover.Location = New System.Drawing.Point(12, 12)
        Me.pctCover.Name = "pctCover"
        Me.pctCover.Size = New System.Drawing.Size(250, 250)
        Me.pctCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCover.TabIndex = 0
        Me.pctCover.TabStop = False
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
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(12, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(30, 30)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 16
        Me.btnBack.TabStop = False
        '
        'panelListSong
        '
        Me.panelListSong.AutoScroll = True
        Me.panelListSong.Controls.Add(Me.lblKeterangan)
        Me.panelListSong.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelListSong.Location = New System.Drawing.Point(0, 366)
        Me.panelListSong.Name = "panelListSong"
        Me.panelListSong.Size = New System.Drawing.Size(1350, 299)
        Me.panelListSong.TabIndex = 18
        '
        'AdminDetailArtist
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
        Me.Name = "AdminDetailArtist"
        Me.Text = "AdminUpdateArtist"
        CType(Me.iconDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBackgroundSection.ResumeLayout(False)
        Me.panelBackgroundSection.PerformLayout()
        Me.panelBackground.ResumeLayout(False)
        Me.panelBackground.PerformLayout()
        CType(Me.iconFileCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIconSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIconDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelListSong.ResumeLayout(False)
        Me.panelListSong.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtUpdate_at As Label
    Friend WithEvents OpenFileDialogCover As OpenFileDialog
    Friend WithEvents LabelUpdateAt As Label
    Friend WithEvents iconDescription As PictureBox
    Friend WithEvents iconCountry As PictureBox
    Friend WithEvents iconName As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents panelBackgroundSection As Panel
    Friend WithEvents lblSection As Label
    Friend WithEvents panelBackground As Panel
    Friend WithEvents iconFileCover As PictureBox
    Friend WithEvents fileCover As TextBox
    Friend WithEvents btnFileCover As Button
    Friend WithEvents pctIconSave As PictureBox
    Friend WithEvents pctIconDelete As PictureBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtIdArtist As TextBox
    Friend WithEvents pctCover As PictureBox
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents panelListSong As FlowLayoutPanel
End Class
