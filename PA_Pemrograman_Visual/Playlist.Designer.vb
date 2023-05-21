<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Playlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Playlist))
        Me.pctIconNewPlaylist = New System.Windows.Forms.PictureBox()
        Me.panelPlaylist = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.btnAddPlaylist = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kanan = New System.Windows.Forms.Panel()
        Me.kiri = New System.Windows.Forms.Panel()
        Me.bawah = New System.Windows.Forms.Panel()
        Me.atas = New System.Windows.Forms.Panel()
        CType(Me.pctIconNewPlaylist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPlaylist.SuspendLayout()
        Me.btnAddPlaylist.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctIconNewPlaylist
        '
        Me.pctIconNewPlaylist.BackColor = System.Drawing.Color.White
        Me.pctIconNewPlaylist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconNewPlaylist.Image = CType(resources.GetObject("pctIconNewPlaylist.Image"), System.Drawing.Image)
        Me.pctIconNewPlaylist.Location = New System.Drawing.Point(599, 8)
        Me.pctIconNewPlaylist.Name = "pctIconNewPlaylist"
        Me.pctIconNewPlaylist.Size = New System.Drawing.Size(35, 35)
        Me.pctIconNewPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconNewPlaylist.TabIndex = 8
        Me.pctIconNewPlaylist.TabStop = False
        '
        'panelPlaylist
        '
        Me.panelPlaylist.AutoScroll = True
        Me.panelPlaylist.Controls.Add(Me.lblKeterangan)
        Me.panelPlaylist.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelPlaylist.Location = New System.Drawing.Point(0, 50)
        Me.panelPlaylist.Name = "panelPlaylist"
        Me.panelPlaylist.Size = New System.Drawing.Size(1350, 615)
        Me.panelPlaylist.TabIndex = 10
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(30, 30)
        Me.lblKeterangan.Margin = New System.Windows.Forms.Padding(30, 30, 0, 0)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(345, 25)
        Me.lblKeterangan.TabIndex = 3
        Me.lblKeterangan.Text = "Oops, saat ini tidak ada playlist"
        '
        'btnAddPlaylist
        '
        Me.btnAddPlaylist.BackColor = System.Drawing.Color.White
        Me.btnAddPlaylist.Controls.Add(Me.Label1)
        Me.btnAddPlaylist.Controls.Add(Me.pctIconNewPlaylist)
        Me.btnAddPlaylist.Controls.Add(Me.kanan)
        Me.btnAddPlaylist.Controls.Add(Me.kiri)
        Me.btnAddPlaylist.Controls.Add(Me.bawah)
        Me.btnAddPlaylist.Controls.Add(Me.atas)
        Me.btnAddPlaylist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddPlaylist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddPlaylist.Location = New System.Drawing.Point(0, 0)
        Me.btnAddPlaylist.Name = "btnAddPlaylist"
        Me.btnAddPlaylist.Size = New System.Drawing.Size(1350, 50)
        Me.btnAddPlaylist.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New Playlist"
        '
        'kanan
        '
        Me.kanan.BackColor = System.Drawing.Color.Cyan
        Me.kanan.Dock = System.Windows.Forms.DockStyle.Right
        Me.kanan.Location = New System.Drawing.Point(1348, 2)
        Me.kanan.Name = "kanan"
        Me.kanan.Size = New System.Drawing.Size(2, 46)
        Me.kanan.TabIndex = 3
        '
        'kiri
        '
        Me.kiri.BackColor = System.Drawing.Color.Cyan
        Me.kiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.kiri.Location = New System.Drawing.Point(0, 2)
        Me.kiri.Name = "kiri"
        Me.kiri.Size = New System.Drawing.Size(2, 46)
        Me.kiri.TabIndex = 2
        '
        'bawah
        '
        Me.bawah.BackColor = System.Drawing.Color.Cyan
        Me.bawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bawah.Location = New System.Drawing.Point(0, 48)
        Me.bawah.Name = "bawah"
        Me.bawah.Size = New System.Drawing.Size(1350, 2)
        Me.bawah.TabIndex = 1
        '
        'atas
        '
        Me.atas.BackColor = System.Drawing.Color.Cyan
        Me.atas.Dock = System.Windows.Forms.DockStyle.Top
        Me.atas.Location = New System.Drawing.Point(0, 0)
        Me.atas.Name = "atas"
        Me.atas.Size = New System.Drawing.Size(1350, 2)
        Me.atas.TabIndex = 0
        '
        'Playlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 665)
        Me.Controls.Add(Me.panelPlaylist)
        Me.Controls.Add(Me.btnAddPlaylist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Playlist"
        Me.Text = "Playlist"
        CType(Me.pctIconNewPlaylist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPlaylist.ResumeLayout(False)
        Me.panelPlaylist.PerformLayout()
        Me.btnAddPlaylist.ResumeLayout(False)
        Me.btnAddPlaylist.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctIconNewPlaylist As PictureBox
    Friend WithEvents panelPlaylist As FlowLayoutPanel
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents btnAddPlaylist As Panel
    Friend WithEvents atas As Panel
    Friend WithEvents kanan As Panel
    Friend WithEvents kiri As Panel
    Friend WithEvents bawah As Panel
    Friend WithEvents Label1 As Label
End Class
