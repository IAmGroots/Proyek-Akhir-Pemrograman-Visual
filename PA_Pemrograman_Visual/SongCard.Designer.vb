<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SongCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SongCard))
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.txtSourceSong = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pctIconPlayNPause = New System.Windows.Forms.PictureBox()
        Me.txtIdSong = New System.Windows.Forms.TextBox()
        Me.bawah = New System.Windows.Forms.Panel()
        Me.kanan = New System.Windows.Forms.Panel()
        Me.kiri = New System.Windows.Forms.Panel()
        Me.atas = New System.Windows.Forms.Panel()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctIconPlayNPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctCover
        '
        Me.pctCover.BackColor = System.Drawing.Color.Transparent
        Me.pctCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctCover.Image = CType(resources.GetObject("pctCover.Image"), System.Drawing.Image)
        Me.pctCover.Location = New System.Drawing.Point(12, 12)
        Me.pctCover.Name = "pctCover"
        Me.pctCover.Size = New System.Drawing.Size(160, 160)
        Me.pctCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCover.TabIndex = 0
        Me.pctCover.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(7, 180)
        Me.lblTitle.MaximumSize = New System.Drawing.Size(167, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(101, 18)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Photograph"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist.Location = New System.Drawing.Point(8, 206)
        Me.lblArtist.MaximumSize = New System.Drawing.Size(165, 18)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(100, 18)
        Me.lblArtist.TabIndex = 2
        Me.lblArtist.Text = "Ed Sheeran"
        '
        'txtSourceSong
        '
        Me.txtSourceSong.Location = New System.Drawing.Point(12, 38)
        Me.txtSourceSong.Name = "txtSourceSong"
        Me.txtSourceSong.Size = New System.Drawing.Size(76, 20)
        Me.txtSourceSong.TabIndex = 5
        Me.txtSourceSong.Text = "source"
        Me.txtSourceSong.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'pctIconPlayNPause
        '
        Me.pctIconPlayNPause.Image = CType(resources.GetObject("pctIconPlayNPause.Image"), System.Drawing.Image)
        Me.pctIconPlayNPause.Location = New System.Drawing.Point(122, 122)
        Me.pctIconPlayNPause.Name = "pctIconPlayNPause"
        Me.pctIconPlayNPause.Size = New System.Drawing.Size(50, 50)
        Me.pctIconPlayNPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconPlayNPause.TabIndex = 6
        Me.pctIconPlayNPause.TabStop = False
        '
        'txtIdSong
        '
        Me.txtIdSong.Location = New System.Drawing.Point(12, 12)
        Me.txtIdSong.Name = "txtIdSong"
        Me.txtIdSong.Size = New System.Drawing.Size(76, 20)
        Me.txtIdSong.TabIndex = 7
        Me.txtIdSong.Text = "id"
        Me.txtIdSong.Visible = False
        '
        'bawah
        '
        Me.bawah.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.bawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bawah.Location = New System.Drawing.Point(2, 234)
        Me.bawah.Name = "bawah"
        Me.bawah.Size = New System.Drawing.Size(180, 2)
        Me.bawah.TabIndex = 19
        '
        'kanan
        '
        Me.kanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.kanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.kanan.Location = New System.Drawing.Point(182, 2)
        Me.kanan.Name = "kanan"
        Me.kanan.Size = New System.Drawing.Size(2, 234)
        Me.kanan.TabIndex = 18
        '
        'kiri
        '
        Me.kiri.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.kiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.kiri.Location = New System.Drawing.Point(0, 2)
        Me.kiri.Name = "kiri"
        Me.kiri.Size = New System.Drawing.Size(2, 234)
        Me.kiri.TabIndex = 17
        '
        'atas
        '
        Me.atas.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.atas.Dock = System.Windows.Forms.DockStyle.Top
        Me.atas.Location = New System.Drawing.Point(0, 0)
        Me.atas.Name = "atas"
        Me.atas.Size = New System.Drawing.Size(184, 2)
        Me.atas.TabIndex = 16
        '
        'SongCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(184, 236)
        Me.Controls.Add(Me.bawah)
        Me.Controls.Add(Me.kanan)
        Me.Controls.Add(Me.kiri)
        Me.Controls.Add(Me.atas)
        Me.Controls.Add(Me.txtIdSong)
        Me.Controls.Add(Me.pctIconPlayNPause)
        Me.Controls.Add(Me.txtSourceSong)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pctCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SongCard"
        Me.Text = "SongCard"
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctIconPlayNPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctCover As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents txtSourceSong As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pctIconPlayNPause As PictureBox
    Friend WithEvents txtIdSong As TextBox
    Friend WithEvents bawah As Panel
    Friend WithEvents kanan As Panel
    Friend WithEvents kiri As Panel
    Friend WithEvents atas As Panel
End Class
