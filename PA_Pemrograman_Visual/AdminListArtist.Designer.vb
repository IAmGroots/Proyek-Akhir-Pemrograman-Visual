<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminListArtist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminListArtist))
        Me.panelArtist = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblKosong = New System.Windows.Forms.Label()
        Me.btnAddArtist = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctIconNewArtist = New System.Windows.Forms.PictureBox()
        Me.kanan = New System.Windows.Forms.Panel()
        Me.kiri = New System.Windows.Forms.Panel()
        Me.bawah = New System.Windows.Forms.Panel()
        Me.atas = New System.Windows.Forms.Panel()
        Me.panelArtist.SuspendLayout()
        Me.btnAddArtist.SuspendLayout()
        CType(Me.pctIconNewArtist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelArtist
        '
        Me.panelArtist.AutoScroll = True
        Me.panelArtist.Controls.Add(Me.lblKosong)
        Me.panelArtist.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelArtist.Location = New System.Drawing.Point(0, 50)
        Me.panelArtist.Name = "panelArtist"
        Me.panelArtist.Size = New System.Drawing.Size(1350, 615)
        Me.panelArtist.TabIndex = 8
        '
        'lblKosong
        '
        Me.lblKosong.AutoSize = True
        Me.lblKosong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKosong.Location = New System.Drawing.Point(30, 30)
        Me.lblKosong.Margin = New System.Windows.Forms.Padding(30, 30, 0, 0)
        Me.lblKosong.Name = "lblKosong"
        Me.lblKosong.Size = New System.Drawing.Size(395, 25)
        Me.lblKosong.TabIndex = 0
        Me.lblKosong.Text = "Oops, saat ini tidak ada daftar artist"
        '
        'btnAddArtist
        '
        Me.btnAddArtist.BackColor = System.Drawing.Color.White
        Me.btnAddArtist.Controls.Add(Me.Label1)
        Me.btnAddArtist.Controls.Add(Me.pctIconNewArtist)
        Me.btnAddArtist.Controls.Add(Me.kanan)
        Me.btnAddArtist.Controls.Add(Me.kiri)
        Me.btnAddArtist.Controls.Add(Me.bawah)
        Me.btnAddArtist.Controls.Add(Me.atas)
        Me.btnAddArtist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddArtist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddArtist.Location = New System.Drawing.Point(0, 0)
        Me.btnAddArtist.Name = "btnAddArtist"
        Me.btnAddArtist.Size = New System.Drawing.Size(1350, 50)
        Me.btnAddArtist.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(640, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New Artist"
        '
        'pctIconNewArtist
        '
        Me.pctIconNewArtist.BackColor = System.Drawing.Color.White
        Me.pctIconNewArtist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconNewArtist.Image = CType(resources.GetObject("pctIconNewArtist.Image"), System.Drawing.Image)
        Me.pctIconNewArtist.Location = New System.Drawing.Point(599, 8)
        Me.pctIconNewArtist.Name = "pctIconNewArtist"
        Me.pctIconNewArtist.Size = New System.Drawing.Size(35, 35)
        Me.pctIconNewArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconNewArtist.TabIndex = 8
        Me.pctIconNewArtist.TabStop = False
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
        'AdminListArtist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 665)
        Me.Controls.Add(Me.panelArtist)
        Me.Controls.Add(Me.btnAddArtist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminListArtist"
        Me.Text = "AdminReadArtist"
        Me.panelArtist.ResumeLayout(False)
        Me.panelArtist.PerformLayout()
        Me.btnAddArtist.ResumeLayout(False)
        Me.btnAddArtist.PerformLayout()
        CType(Me.pctIconNewArtist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelArtist As FlowLayoutPanel
    Friend WithEvents lblKosong As Label
    Friend WithEvents btnAddArtist As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pctIconNewArtist As PictureBox
    Friend WithEvents kanan As Panel
    Friend WithEvents kiri As Panel
    Friend WithEvents bawah As Panel
    Friend WithEvents atas As Panel
End Class
