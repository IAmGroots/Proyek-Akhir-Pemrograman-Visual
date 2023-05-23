<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminArtistCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminArtistCard))
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.pctCover = New System.Windows.Forms.PictureBox()
        Me.txtIdArtist = New System.Windows.Forms.TextBox()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblArtist.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist.ForeColor = System.Drawing.Color.Black
        Me.lblArtist.Location = New System.Drawing.Point(9, 235)
        Me.lblArtist.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArtist.MaximumSize = New System.Drawing.Size(223, 28)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(150, 28)
        Me.lblArtist.TabIndex = 31
        Me.lblArtist.Text = "Photograph"
        '
        'pctCover
        '
        Me.pctCover.BackColor = System.Drawing.Color.Transparent
        Me.pctCover.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctCover.Image = CType(resources.GetObject("pctCover.Image"), System.Drawing.Image)
        Me.pctCover.Location = New System.Drawing.Point(16, 15)
        Me.pctCover.Margin = New System.Windows.Forms.Padding(4)
        Me.pctCover.Name = "pctCover"
        Me.pctCover.Size = New System.Drawing.Size(213, 197)
        Me.pctCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCover.TabIndex = 30
        Me.pctCover.TabStop = False
        '
        'txtIdArtist
        '
        Me.txtIdArtist.Location = New System.Drawing.Point(16, 15)
        Me.txtIdArtist.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdArtist.Name = "txtIdArtist"
        Me.txtIdArtist.Size = New System.Drawing.Size(100, 22)
        Me.txtIdArtist.TabIndex = 35
        Me.txtIdArtist.Text = "id"
        Me.txtIdArtist.Visible = False
        '
        'AdminArtistCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(245, 290)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.txtIdArtist)
        Me.Controls.Add(Me.pctCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AdminArtistCard"
        Me.Text = "ArtistCard"
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArtist As Label
    Friend WithEvents pctCover As PictureBox
    Friend WithEvents txtIdArtist As TextBox
End Class
