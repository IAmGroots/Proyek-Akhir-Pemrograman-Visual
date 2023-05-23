<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListPlaylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListPlaylist))
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.txtIdPlaylist = New System.Windows.Forms.TextBox()
        Me.txtIdSong = New System.Windows.Forms.TextBox()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(47, 12)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(53, 25)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = "Title"
        '
        'pctCover
        '
        Me.pctCover.BackColor = System.Drawing.Color.Transparent
        Me.pctCover.Image = CType(resources.GetObject("pctCover.Image"), System.Drawing.Image)
        Me.pctCover.Location = New System.Drawing.Point(5, 5)
        Me.pctCover.Name = "pctCover"
        Me.pctCover.Size = New System.Drawing.Size(40, 40)
        Me.pctCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCover.TabIndex = 1
        Me.pctCover.TabStop = False
        '
        'txtIdPlaylist
        '
        Me.txtIdPlaylist.Location = New System.Drawing.Point(117, 5)
        Me.txtIdPlaylist.Name = "txtIdPlaylist"
        Me.txtIdPlaylist.Size = New System.Drawing.Size(45, 20)
        Me.txtIdPlaylist.TabIndex = 10
        Me.txtIdPlaylist.Text = "idPlaylist"
        Me.txtIdPlaylist.Visible = False
        '
        'txtIdSong
        '
        Me.txtIdSong.Location = New System.Drawing.Point(117, 25)
        Me.txtIdSong.Name = "txtIdSong"
        Me.txtIdSong.Size = New System.Drawing.Size(45, 20)
        Me.txtIdSong.TabIndex = 11
        Me.txtIdSong.Text = "idSong"
        Me.txtIdSong.Visible = False
        '
        'ListPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(174, 50)
        Me.Controls.Add(Me.txtIdSong)
        Me.Controls.Add(Me.txtIdPlaylist)
        Me.Controls.Add(Me.pctCover)
        Me.Controls.Add(Me.txtTitle)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListPlaylist"
        Me.Text = "ListPlaylist"
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTitle As Label
    Friend WithEvents pctCover As PictureBox
    Friend WithEvents txtIdPlaylist As TextBox
    Friend WithEvents txtIdSong As TextBox
End Class
