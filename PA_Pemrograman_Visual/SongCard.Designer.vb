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
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pctCover.TabIndex = 0
        Me.pctCover.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(8, 175)
        Me.lblTitle.MaximumSize = New System.Drawing.Size(167, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(119, 23)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Photograph"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtist.Location = New System.Drawing.Point(9, 203)
        Me.lblArtist.MaximumSize = New System.Drawing.Size(165, 18)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(100, 18)
        Me.lblArtist.TabIndex = 2
        Me.lblArtist.Text = "Ed Sheeran"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(9, 228)
        Me.lblDescription.MaximumSize = New System.Drawing.Size(165, 16)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(165, 16)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "This is a simple descript"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(12, 12)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(76, 20)
        Me.textBox1.TabIndex = 5
        Me.textBox1.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(122, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(42, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(76, 20)
        Me.TextBox2.TabIndex = 7
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(54, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(76, 20)
        Me.TextBox3.TabIndex = 8
        Me.TextBox3.Text = "currentposition"
        Me.TextBox3.Visible = False
        '
        'SongCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(184, 253)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.pctCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SongCard"
        Me.Text = "SongCard"
        CType(Me.pctCover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctCover As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents textBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
