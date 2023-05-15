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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnPenutup = New System.Windows.Forms.Button()
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.panelSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.AudioPanel.SuspendLayout()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AudioPanel
        '
        Me.AudioPanel.Controls.Add(Me.Button1)
        Me.AudioPanel.Controls.Add(Me.Button2)
        Me.AudioPanel.Controls.Add(Me.btnPenutup)
        Me.AudioPanel.Controls.Add(Me.MediaPlayer)
        Me.AudioPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AudioPanel.Location = New System.Drawing.Point(0, 666)
        Me.AudioPanel.Name = "AudioPanel"
        Me.AudioPanel.Size = New System.Drawing.Size(1350, 64)
        Me.AudioPanel.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(214, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 33)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Photograph - Ed Sheeran"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(214, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(1136, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnPenutup
        '
        Me.btnPenutup.BackColor = System.Drawing.Color.White
        Me.btnPenutup.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPenutup.Enabled = False
        Me.btnPenutup.FlatAppearance.BorderSize = 0
        Me.btnPenutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenutup.Location = New System.Drawing.Point(0, 0)
        Me.btnPenutup.Name = "btnPenutup"
        Me.btnPenutup.Size = New System.Drawing.Size(1350, 20)
        Me.btnPenutup.TabIndex = 2
        Me.btnPenutup.UseVisualStyleBackColor = False
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(0, 0)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(1350, 64)
        Me.MediaPlayer.TabIndex = 2
        '
        'panelSong
        '
        Me.panelSong.AutoScroll = True
        Me.panelSong.AutoSize = True
        Me.panelSong.BackColor = System.Drawing.Color.DimGray
        Me.panelSong.Location = New System.Drawing.Point(0, 64)
        Me.panelSong.MaximumSize = New System.Drawing.Size(1351, 596)
        Me.panelSong.Name = "panelSong"
        Me.panelSong.Size = New System.Drawing.Size(1351, 596)
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
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.AudioPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.panelSong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Home"
        Me.AudioPanel.ResumeLayout(False)
        Me.AudioPanel.PerformLayout()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AudioPanel As Panel
    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnPenutup As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents panelSong As FlowLayoutPanel
    Friend WithEvents MenuPanel As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
