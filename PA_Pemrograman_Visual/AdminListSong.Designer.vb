<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminListSong
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminListSong))
        Me.lblKosong = New System.Windows.Forms.Label()
        Me.panelSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.pctIconNewSong = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddSong = New System.Windows.Forms.Panel()
        Me.panelSong.SuspendLayout()
        CType(Me.pctIconNewSong, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnAddSong.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblKosong
        '
        Me.lblKosong.AutoSize = True
        Me.lblKosong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKosong.Location = New System.Drawing.Point(40, 37)
        Me.lblKosong.Margin = New System.Windows.Forms.Padding(40, 37, 0, 0)
        Me.lblKosong.Name = "lblKosong"
        Me.lblKosong.Size = New System.Drawing.Size(495, 32)
        Me.lblKosong.TabIndex = 0
        Me.lblKosong.Text = "Oops, saat ini tidak ada daftar lagu"
        '
        'panelSong
        '
        Me.panelSong.AutoScroll = True
        Me.panelSong.BackColor = System.Drawing.Color.LightGray
        Me.panelSong.Controls.Add(Me.lblKosong)
        Me.panelSong.Dock = System.Windows.Forms.DockStyle.Bottom

        'Me.panelSong.Location = New System.Drawing.Point(0, 61)
        'Me.panelSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        'Me.panelSong.Name = "panelsong"
        'Me.panelSong.Size = New System.Drawing.Size(1800, 757)

        Me.panelSong.Location = New System.Drawing.Point(0, 50)
        Me.panelSong.Name = "panelSong"
        Me.panelSong.Size = New System.Drawing.Size(1350, 615)

        Me.panelSong.TabIndex = 2
        '
        'pctIconNewSong
        '
        Me.pctIconNewSong.BackColor = System.Drawing.Color.White
        Me.pctIconNewSong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctIconNewSong.Image = CType(resources.GetObject("pctIconNewSong.Image"), System.Drawing.Image)
        Me.pctIconNewSong.Location = New System.Drawing.Point(799, 10)
        Me.pctIconNewSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pctIconNewSong.Name = "pctIconNewSong"
        Me.pctIconNewSong.Size = New System.Drawing.Size(47, 43)
        Me.pctIconNewSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctIconNewSong.TabIndex = 8
        Me.pctIconNewSong.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Me.Label1.Location = New System.Drawing.Point(853, 17)
        'Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        'Me.Label1.Name = "Label1"
        'Me.Label1.Size = New System.Drawing.Size(134, 29)

        Me.Label1.Location = New System.Drawing.Point(640, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)

        Me.Label1.TabIndex = 4
        Me.Label1.Text = "New Song"
        '
        'btnAddSong
        '
        Me.btnAddSong.BackColor = System.Drawing.Color.White
        Me.btnAddSong.Controls.Add(Me.Label1)
        Me.btnAddSong.Controls.Add(Me.pctIconNewSong)
        Me.btnAddSong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddSong.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAddSong.Location = New System.Drawing.Point(0, 0)

        'Me.btnAddSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        'Me.btnAddSong.Name = "btnAddSong"
        'Me.btnAddSong.Size = New System.Drawing.Size(1800, 62)

        Me.btnAddSong.Name = "btnAddSong"
        Me.btnAddSong.Size = New System.Drawing.Size(1350, 50)

        Me.btnAddSong.TabIndex = 7
        '
        'AdminListSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1800, 818)
        Me.Controls.Add(Me.btnAddSong)
        Me.Controls.Add(Me.panelSong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminListSong"
        Me.Text = "AdminReadSong"
        Me.panelSong.ResumeLayout(False)
        Me.panelSong.PerformLayout()
        CType(Me.pctIconNewSong, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnAddSong.ResumeLayout(False)
        Me.btnAddSong.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblKosong As Label
    Friend WithEvents panelSong As FlowLayoutPanel
    Friend WithEvents pctIconNewSong As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddSong As Panel
End Class
