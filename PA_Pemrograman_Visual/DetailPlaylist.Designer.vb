<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetailPlaylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailPlaylist))
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.iconTitle = New System.Windows.Forms.PictureBox()
        Me.txtCover = New System.Windows.Forms.TextBox()
        Me.txtIdPlaylist = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.pctIconSave = New System.Windows.Forms.PictureBox()
        Me.pctIconDelete = New System.Windows.Forms.PictureBox()
        Me.panelListSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.iconTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIconSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIconDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelListSong.SuspendLayout()
        Me.SuspendLayout()
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
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(16, 15)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 37)
        Me.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnBack.TabIndex = 1
        Me.btnBack.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.iconTitle)
        Me.Panel1.Controls.Add(Me.txtCover)
        Me.Panel1.Controls.Add(Me.txtIdPlaylist)
        Me.Panel1.Controls.Add(Me.txtDescription)
        Me.Panel1.Controls.Add(Me.txtTitle)
        Me.Panel1.Controls.Add(Me.pctIconSave)
        Me.Panel1.Controls.Add(Me.pctCover)
        Me.Panel1.Controls.Add(Me.pctIconDelete)
        Me.Panel1.Location = New System.Drawing.Point(16, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1768, 338)
        Me.Panel1.TabIndex = 2
        '
        'iconTitle
        '
        Me.iconTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconTitle.Image = CType(resources.GetObject("iconTitle.Image"), System.Drawing.Image)
        Me.iconTitle.Location = New System.Drawing.Point(929, 129)
        Me.iconTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.iconTitle.Name = "iconTitle"
        Me.iconTitle.Size = New System.Drawing.Size(40, 37)
        Me.iconTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconTitle.TabIndex = 46
        Me.iconTitle.TabStop = False
        '
        'txtCover
        '
        Me.txtCover.Location = New System.Drawing.Point(357, 47)
        Me.txtCover.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCover.Name = "txtCover"
        Me.txtCover.Size = New System.Drawing.Size(100, 22)
        Me.txtCover.TabIndex = 16
        Me.txtCover.Text = "cover"
        Me.txtCover.Visible = False
        '
        'txtIdPlaylist
        '
        Me.txtIdPlaylist.Location = New System.Drawing.Point(357, 15)
        Me.txtIdPlaylist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIdPlaylist.Name = "txtIdPlaylist"
        Me.txtIdPlaylist.Size = New System.Drawing.Size(100, 22)
        Me.txtIdPlaylist.TabIndex = 10
        Me.txtIdPlaylist.Text = "id"
        Me.txtIdPlaylist.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescription.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(357, 178)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(1259, 144)
        Me.txtDescription.TabIndex = 15
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(357, 126)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(563, 45)
        Me.txtTitle.TabIndex = 14
        '
        'pctIconSave
        '
        Me.pctIconSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconSave.Image = CType(resources.GetObject("pctIconSave.Image"), System.Drawing.Image)
        Me.pctIconSave.Location = New System.Drawing.Point(1643, 286)
        Me.pctIconSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctIconSave.Name = "pctIconSave"
        Me.pctIconSave.Size = New System.Drawing.Size(40, 37)
        Me.pctIconSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconSave.TabIndex = 13
        Me.pctIconSave.TabStop = False
        '
        'pctIconDelete
        '
        Me.pctIconDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconDelete.Image = CType(resources.GetObject("pctIconDelete.Image"), System.Drawing.Image)
        Me.pctIconDelete.Location = New System.Drawing.Point(1705, 286)
        Me.pctIconDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctIconDelete.Name = "pctIconDelete"
        Me.pctIconDelete.Size = New System.Drawing.Size(40, 37)
        Me.pctIconDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconDelete.TabIndex = 12
        Me.pctIconDelete.TabStop = False
        '
        'panelListSong
        '
        Me.panelListSong.AutoScroll = True
        Me.panelListSong.Controls.Add(Me.lblKeterangan)
        Me.panelListSong.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelListSong.Location = New System.Drawing.Point(0, 408)
        Me.panelListSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelListSong.Name = "panelListSong"
        Me.panelListSong.Size = New System.Drawing.Size(1800, 410)
        Me.panelListSong.TabIndex = 3
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(40, 37)
        Me.lblKeterangan.Margin = New System.Windows.Forms.Padding(40, 37, 0, 0)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(385, 25)
        Me.lblKeterangan.TabIndex = 2
        Me.lblKeterangan.Text = "Oops, saat ini tidak ada daftar lagu"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DetailPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1800, 818)
        Me.Controls.Add(Me.panelListSong)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DetailPlaylist"
        Me.Text = "DetailPlaylist"
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.iconTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIconSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIconDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelListSong.ResumeLayout(False)
        Me.panelListSong.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctCover As PictureBox
    Friend WithEvents btnBack As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pctIconSave As PictureBox
    Friend WithEvents pctIconDelete As PictureBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtIdPlaylist As TextBox
    Friend WithEvents panelListSong As FlowLayoutPanel
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtCover As TextBox
    Friend WithEvents iconTitle As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
