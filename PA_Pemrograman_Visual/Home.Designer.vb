<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.AudioPanel = New System.Windows.Forms.Panel()
        Me.panelSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.MediaPlayers = New AxWMPLib.AxWindowsMediaPlayer()
        Me.asasa = New System.Windows.Forms.Button()
        Me.txtTitleMediaPlayer = New System.Windows.Forms.Label()
        Me.btnDown = New System.Windows.Forms.PictureBox()
        Me.AudioPanel.SuspendLayout()
        CType(Me.MediaPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AudioPanel
        '
        Me.AudioPanel.Controls.Add(Me.btnDown)
        Me.AudioPanel.Controls.Add(Me.txtTitleMediaPlayer)
        Me.AudioPanel.Controls.Add(Me.asasa)
        Me.AudioPanel.Controls.Add(Me.MediaPlayers)
        Me.AudioPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AudioPanel.Location = New System.Drawing.Point(0, 657)
        Me.AudioPanel.Name = "AudioPanel"
        Me.AudioPanel.Size = New System.Drawing.Size(1350, 72)
        Me.AudioPanel.TabIndex = 1
        '
        'panelSong
        '
        Me.panelSong.AutoScroll = True
        Me.panelSong.AutoSize = True
        Me.panelSong.BackColor = System.Drawing.Color.DimGray
        Me.panelSong.Location = New System.Drawing.Point(0, 64)
        Me.panelSong.MaximumSize = New System.Drawing.Size(1350, 665)
        Me.panelSong.Name = "panelSong"
        Me.panelSong.Size = New System.Drawing.Size(1350, 446)
        Me.panelSong.TabIndex = 2
        '
        'MenuPanel
        '
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(1350, 64)
        Me.MenuPanel.TabIndex = 0
        '
        'MediaPlayers
        '
        Me.MediaPlayers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaPlayers.Enabled = True
        Me.MediaPlayers.Location = New System.Drawing.Point(0, 0)
        Me.MediaPlayers.Name = "MediaPlayers"
        Me.MediaPlayers.OcxState = CType(resources.GetObject("MediaPlayers.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayers.Size = New System.Drawing.Size(1350, 72)
        Me.MediaPlayers.TabIndex = 3
        '
        'asasa
        '
        Me.asasa.AutoSize = True
        Me.asasa.BackColor = System.Drawing.Color.White
        Me.asasa.Dock = System.Windows.Forms.DockStyle.Top
        Me.asasa.Enabled = False
        Me.asasa.FlatAppearance.BorderSize = 0
        Me.asasa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.asasa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.asasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.asasa.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.asasa.ForeColor = System.Drawing.Color.Black
        Me.asasa.Location = New System.Drawing.Point(0, 0)
        Me.asasa.Name = "asasa"
        Me.asasa.Size = New System.Drawing.Size(1350, 28)
        Me.asasa.TabIndex = 3
        Me.asasa.UseVisualStyleBackColor = False
        '
        'txtTitleMediaPlayer
        '
        Me.txtTitleMediaPlayer.AutoSize = True
        Me.txtTitleMediaPlayer.BackColor = System.Drawing.Color.White
        Me.txtTitleMediaPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTitleMediaPlayer.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleMediaPlayer.Location = New System.Drawing.Point(4, 1)
        Me.txtTitleMediaPlayer.Name = "txtTitleMediaPlayer"
        Me.txtTitleMediaPlayer.Size = New System.Drawing.Size(138, 25)
        Me.txtTitleMediaPlayer.TabIndex = 3
        Me.txtTitleMediaPlayer.Text = "Title - Artist"
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.White
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(1309, 3)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(25, 25)
        Me.btnDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnDown.TabIndex = 3
        Me.btnDown.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.AudioPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.panelSong)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.Text = "Home"
        Me.AudioPanel.ResumeLayout(False)
        Me.AudioPanel.PerformLayout()
        CType(Me.MediaPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AudioPanel As Panel
    Friend WithEvents panelSong As FlowLayoutPanel
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents MediaPlayers As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents asasa As Button
    Friend WithEvents txtTitleMediaPlayer As Label
    Friend WithEvents btnDown As PictureBox
End Class
