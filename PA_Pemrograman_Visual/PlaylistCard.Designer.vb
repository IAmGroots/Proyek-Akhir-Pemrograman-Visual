<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlaylistCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlaylistCard))
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.txtIdPlaylist = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtSourceCover = New System.Windows.Forms.TextBox()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctCover
        '
        Me.pctCover.BackColor = System.Drawing.Color.Transparent
        Me.pctCover.Image = CType(resources.GetObject("pctCover.Image"), System.Drawing.Image)
        Me.pctCover.Location = New System.Drawing.Point(12, 12)
        Me.pctCover.Name = "pctCover"
        Me.pctCover.Size = New System.Drawing.Size(160, 160)
        Me.pctCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCover.TabIndex = 7
        Me.pctCover.TabStop = False
        '
        'txtIdPlaylist
        '
        Me.txtIdPlaylist.Location = New System.Drawing.Point(12, 12)
        Me.txtIdPlaylist.Name = "txtIdPlaylist"
        Me.txtIdPlaylist.Size = New System.Drawing.Size(76, 20)
        Me.txtIdPlaylist.TabIndex = 9
        Me.txtIdPlaylist.Text = "id"
        Me.txtIdPlaylist.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(7, 182)
        Me.lblTitle.MaximumSize = New System.Drawing.Size(167, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(98, 23)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "Indo Hits"
        '
        'txtSourceCover
        '
        Me.txtSourceCover.Location = New System.Drawing.Point(12, 38)
        Me.txtSourceCover.Name = "txtSourceCover"
        Me.txtSourceCover.Size = New System.Drawing.Size(76, 20)
        Me.txtSourceCover.TabIndex = 13
        Me.txtSourceCover.Text = "source cover"
        Me.txtSourceCover.Visible = False
        '
        'PlaylistCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(184, 217)
        Me.Controls.Add(Me.txtSourceCover)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtIdPlaylist)
        Me.Controls.Add(Me.pctCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PlaylistCard"
        Me.Text = "PlaylistCard"
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctCover As PictureBox
    Friend WithEvents txtIdPlaylist As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtSourceCover As TextBox
End Class
