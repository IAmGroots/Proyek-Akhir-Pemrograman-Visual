<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHome))
        Me.AudioPanel = New System.Windows.Forms.Panel()
        Me.btnDown = New System.Windows.Forms.PictureBox()
        Me.txtTitleMediaPlayer = New System.Windows.Forms.Label()
        Me.backgroundMediaPlayer = New System.Windows.Forms.Button()
        Me.MediaPlayers = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.Content = New System.Windows.Forms.Panel()
        Me.AudioPanel.SuspendLayout()
        CType(Me.btnDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AudioPanel
        '
        Me.AudioPanel.Controls.Add(Me.btnDown)
        Me.AudioPanel.Controls.Add(Me.txtTitleMediaPlayer)
        Me.AudioPanel.Controls.Add(Me.backgroundMediaPlayer)
        Me.AudioPanel.Controls.Add(Me.MediaPlayers)
        Me.AudioPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AudioPanel.Location = New System.Drawing.Point(0, 658)
        Me.AudioPanel.Name = "AudioPanel"
        Me.AudioPanel.Size = New System.Drawing.Size(1350, 72)
        Me.AudioPanel.TabIndex = 4
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
        'txtTitleMediaPlayer
        '
        Me.txtTitleMediaPlayer.AutoSize = True
        Me.txtTitleMediaPlayer.BackColor = System.Drawing.Color.White
        Me.txtTitleMediaPlayer.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtTitleMediaPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTitleMediaPlayer.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleMediaPlayer.Location = New System.Drawing.Point(4, 1)
        Me.txtTitleMediaPlayer.Name = "txtTitleMediaPlayer"
        Me.txtTitleMediaPlayer.Size = New System.Drawing.Size(138, 25)
        Me.txtTitleMediaPlayer.TabIndex = 3
        Me.txtTitleMediaPlayer.Text = "Title - Artist"
        '
        'backgroundMediaPlayer
        '
        Me.backgroundMediaPlayer.AutoSize = True
        Me.backgroundMediaPlayer.BackColor = System.Drawing.Color.White
        Me.backgroundMediaPlayer.Dock = System.Windows.Forms.DockStyle.Top
        Me.backgroundMediaPlayer.Enabled = False
        Me.backgroundMediaPlayer.FlatAppearance.BorderSize = 0
        Me.backgroundMediaPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.backgroundMediaPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.backgroundMediaPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backgroundMediaPlayer.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backgroundMediaPlayer.ForeColor = System.Drawing.Color.Black
        Me.backgroundMediaPlayer.Location = New System.Drawing.Point(0, 0)
        Me.backgroundMediaPlayer.Name = "backgroundMediaPlayer"
        Me.backgroundMediaPlayer.Size = New System.Drawing.Size(1350, 28)
        Me.backgroundMediaPlayer.TabIndex = 3
        Me.backgroundMediaPlayer.UseVisualStyleBackColor = False
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
        'MenuPanel
        '
        Me.MenuPanel.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(1350, 64)
        Me.MenuPanel.TabIndex = 3
        '
        'Content
        '
        Me.Content.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Content.Location = New System.Drawing.Point(0, 64)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(1350, 665)
        Me.Content.TabIndex = 5
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.AudioPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.Content)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AdminHome"
        Me.Text = "Dashboard"
        Me.AudioPanel.ResumeLayout(False)
        Me.AudioPanel.PerformLayout()
        CType(Me.btnDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaPlayers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AudioPanel As Panel
    Friend WithEvents btnDown As PictureBox
    Friend WithEvents txtTitleMediaPlayer As Label
    Friend WithEvents MediaPlayers As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents Content As Panel
    Friend WithEvents backgroundMediaPlayer As Button
End Class
