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
        Me.pctIconNewArtist = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddArtist = New System.Windows.Forms.Panel()
        Me.lblKosong = New System.Windows.Forms.Label()
        Me.panelArtist = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.pctIconNewArtist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnAddArtist.SuspendLayout()
        Me.panelArtist.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctIconNewArtist
        '
        Me.pctIconNewArtist.BackColor = System.Drawing.Color.White
        Me.pctIconNewArtist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconNewArtist.Image = CType(resources.GetObject("pctIconNewArtist.Image"), System.Drawing.Image)
        Me.pctIconNewArtist.Location = New System.Drawing.Point(799, 10)
        Me.pctIconNewArtist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctIconNewArtist.Name = "pctIconNewArtist"
        Me.pctIconNewArtist.Size = New System.Drawing.Size(47, 43)
        Me.pctIconNewArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconNewArtist.TabIndex = 8
        Me.pctIconNewArtist.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Me.Label1.Location = New System.Drawing.Point(853, 17)
        'Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        'Me.Label1.Name = "Label1"
        'Me.Label1.Size = New System.Drawing.Size(136, 29)

        Me.Label1.Location = New System.Drawing.Point(640, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)

        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New Artist"
        '
        'btnAddArtist
        '
        Me.btnAddArtist.BackColor = System.Drawing.Color.White
        Me.btnAddArtist.Controls.Add(Me.Label1)
        Me.btnAddArtist.Controls.Add(Me.pctIconNewArtist)
        Me.btnAddArtist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddArtist.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddArtist.Location = New System.Drawing.Point(0, 0)

        'Me.btnAddArtist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        'Me.btnAddArtist.Name = "btnAddArtist"
        'Me.btnAddArtist.Size = New System.Drawing.Size(1800, 62)

        Me.btnAddArtist.Name = "btnAddArtist"
        Me.btnAddArtist.Size = New System.Drawing.Size(1350, 50)

        Me.btnAddArtist.TabIndex = 9
        '
        'lblKosong
        '
        Me.lblKosong.AutoSize = True
        Me.lblKosong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Me.lblKosong.Location = New System.Drawing.Point(40, 37)
        'Me.lblKosong.Margin = New System.Windows.Forms.Padding(40, 37, 0, 0)
        'Me.lblKosong.Name = "lblKosong"
        'Me.lblKosong.Size = New System.Drawing.Size(509, 32)

        Me.lblKosong.Location = New System.Drawing.Point(30, 30)
        Me.lblKosong.Margin = New System.Windows.Forms.Padding(30, 30, 0, 0)
        Me.lblKosong.Name = "lblKosong"
        Me.lblKosong.Size = New System.Drawing.Size(395, 25)

        Me.lblKosong.TabIndex = 0
        Me.lblKosong.Text = "Oops, saat ini tidak ada daftar artist"
        '
        'panelArtist
        '
        Me.panelArtist.AutoScroll = True
        Me.panelArtist.BackColor = System.Drawing.Color.LightGray
        Me.panelArtist.Controls.Add(Me.lblKosong)
        Me.panelArtist.Dock = System.Windows.Forms.DockStyle.Bottom

        'Me.panelArtist.Location = New System.Drawing.Point(0, 61)
        'Me.panelArtist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        'Me.panelArtist.Name = "panelArtist"
        'Me.panelArtist.Size = New System.Drawing.Size(1800, 757)

        Me.panelArtist.Location = New System.Drawing.Point(0, 50)
        Me.panelArtist.Name = "panelArtist"
        Me.panelArtist.Size = New System.Drawing.Size(1350, 615)

        Me.panelArtist.TabIndex = 8
        '
        'AdminListArtist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1800, 818)
        Me.Controls.Add(Me.panelArtist)
        Me.Controls.Add(Me.btnAddArtist)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminListArtist"
        Me.Text = "AdminReadArtist"
        CType(Me.pctIconNewArtist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnAddArtist.ResumeLayout(False)
        Me.btnAddArtist.PerformLayout()
        Me.panelArtist.ResumeLayout(False)
        Me.panelArtist.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctIconNewArtist As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddArtist As Panel
    Friend WithEvents lblKosong As Label
    Friend WithEvents panelArtist As FlowLayoutPanel
End Class
