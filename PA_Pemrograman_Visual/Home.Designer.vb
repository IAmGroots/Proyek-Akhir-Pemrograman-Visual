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
        Me.AudioPanel.SuspendLayout()
        CType(Me.MediaPlayers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AudioPanel
        '
        Me.AudioPanel.Controls.Add(Me.MediaPlayers)
        Me.AudioPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AudioPanel.Location = New System.Drawing.Point(0, 634)
        Me.AudioPanel.Name = "AudioPanel"
        Me.AudioPanel.Size = New System.Drawing.Size(1350, 95)
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
        Me.MediaPlayers.Enabled = True
        Me.MediaPlayers.Location = New System.Drawing.Point(12, 8)
        Me.MediaPlayers.Name = "MediaPlayers"
        Me.MediaPlayers.OcxState = CType(resources.GetObject("MediaPlayers.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayers.Size = New System.Drawing.Size(538, 84)
        Me.MediaPlayers.TabIndex = 3
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.Text = "Home"
        Me.AudioPanel.ResumeLayout(False)
        CType(Me.MediaPlayers, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
