<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.panelBackgroundSearchBar = New System.Windows.Forms.Panel()
        Me.iconRefresh = New System.Windows.Forms.PictureBox()
        Me.iconSearch = New System.Windows.Forms.PictureBox()
        Me.panelResult = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.panelBackgroundSection = New System.Windows.Forms.Panel()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.panelBackgroundSearchBar.SuspendLayout()
        CType(Me.iconRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelResult.SuspendLayout()
        Me.panelBackgroundSection.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(465, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(390, 33)
        Me.txtSearch.TabIndex = 7
        '
        'panelBackgroundSearchBar
        '
        Me.panelBackgroundSearchBar.BackColor = System.Drawing.Color.White
        Me.panelBackgroundSearchBar.Controls.Add(Me.iconRefresh)
        Me.panelBackgroundSearchBar.Controls.Add(Me.iconSearch)
        Me.panelBackgroundSearchBar.Controls.Add(Me.txtSearch)
        Me.panelBackgroundSearchBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBackgroundSearchBar.Location = New System.Drawing.Point(0, 0)
        Me.panelBackgroundSearchBar.Name = "panelBackgroundSearchBar"
        Me.panelBackgroundSearchBar.Size = New System.Drawing.Size(1350, 58)
        Me.panelBackgroundSearchBar.TabIndex = 8
        '
        'iconRefresh
        '
        Me.iconRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconRefresh.Image = CType(resources.GetObject("iconRefresh.Image"), System.Drawing.Image)
        Me.iconRefresh.Location = New System.Drawing.Point(900, 12)
        Me.iconRefresh.Name = "iconRefresh"
        Me.iconRefresh.Size = New System.Drawing.Size(33, 33)
        Me.iconRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconRefresh.TabIndex = 9
        Me.iconRefresh.TabStop = False
        '
        'iconSearch
        '
        Me.iconSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconSearch.Image = CType(resources.GetObject("iconSearch.Image"), System.Drawing.Image)
        Me.iconSearch.Location = New System.Drawing.Point(861, 12)
        Me.iconSearch.Name = "iconSearch"
        Me.iconSearch.Size = New System.Drawing.Size(33, 33)
        Me.iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.iconSearch.TabIndex = 8
        Me.iconSearch.TabStop = False
        '
        'panelResult
        '
        Me.panelResult.AutoScroll = True
        Me.panelResult.Controls.Add(Me.lblKeterangan)
        Me.panelResult.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelResult.Location = New System.Drawing.Point(0, 98)
        Me.panelResult.Name = "panelResult"
        Me.panelResult.Size = New System.Drawing.Size(1350, 567)
        Me.panelResult.TabIndex = 9
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeterangan.Location = New System.Drawing.Point(30, 30)
        Me.lblKeterangan.Margin = New System.Windows.Forms.Padding(30, 30, 0, 0)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(385, 25)
        Me.lblKeterangan.TabIndex = 1
        Me.lblKeterangan.Text = "Oops, saat ini tidak ada daftar lagu"
        '
        'panelBackgroundSection
        '
        Me.panelBackgroundSection.BackColor = System.Drawing.Color.LightGray
        Me.panelBackgroundSection.Controls.Add(Me.lblSection)
        Me.panelBackgroundSection.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBackgroundSection.Location = New System.Drawing.Point(0, 58)
        Me.panelBackgroundSection.Name = "panelBackgroundSection"
        Me.panelBackgroundSection.Size = New System.Drawing.Size(1350, 40)
        Me.panelBackgroundSection.TabIndex = 10
        '
        'lblSection
        '
        Me.lblSection.AutoSize = True
        Me.lblSection.BackColor = System.Drawing.Color.LightGray
        Me.lblSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSection.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(12, 8)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(93, 23)
        Me.lblSection.TabIndex = 11
        Me.lblSection.Text = "Trending"
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 665)
        Me.Controls.Add(Me.panelBackgroundSection)
        Me.Controls.Add(Me.panelResult)
        Me.Controls.Add(Me.panelBackgroundSearchBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Search"
        Me.Text = "Search"
        Me.panelBackgroundSearchBar.ResumeLayout(False)
        Me.panelBackgroundSearchBar.PerformLayout()
        CType(Me.iconRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelResult.ResumeLayout(False)
        Me.panelResult.PerformLayout()
        Me.panelBackgroundSection.ResumeLayout(False)
        Me.panelBackgroundSection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents panelBackgroundSearchBar As Panel
    Friend WithEvents iconSearch As PictureBox
    Friend WithEvents panelResult As FlowLayoutPanel
    Friend WithEvents panelBackgroundSection As Panel
    Friend WithEvents lblSection As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents iconRefresh As PictureBox
End Class
