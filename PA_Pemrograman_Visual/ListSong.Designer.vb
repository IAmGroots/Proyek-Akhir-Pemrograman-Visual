﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListSong
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
        Me.panelSong = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblKosong = New System.Windows.Forms.Label()
        Me.panelSong.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelSong
        '
        Me.panelSong.AutoScroll = True
        Me.panelSong.BackColor = System.Drawing.Color.LightGray
        Me.panelSong.Controls.Add(Me.lblKosong)
        Me.panelSong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSong.Location = New System.Drawing.Point(0, 0)
        Me.panelSong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelSong.Name = "panelSong"
        Me.panelSong.Size = New System.Drawing.Size(1800, 818)
        Me.panelSong.TabIndex = 1
        '
        'lblKosong
        '
        Me.lblKosong.AutoSize = True
        Me.lblKosong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKosong.ForeColor = System.Drawing.Color.Black
        Me.lblKosong.Location = New System.Drawing.Point(40, 37)
        Me.lblKosong.Margin = New System.Windows.Forms.Padding(40, 37, 0, 0)
        Me.lblKosong.Name = "lblKosong"
        Me.lblKosong.Size = New System.Drawing.Size(385, 25)
        Me.lblKosong.TabIndex = 0
        Me.lblKosong.Text = "Oops, saat ini tidak ada daftar lagu"
        '
        'ListSong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1800, 818)
        Me.Controls.Add(Me.panelSong)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ListSong"
        Me.Text = "ListSong"
        Me.panelSong.ResumeLayout(False)
        Me.panelSong.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSong As FlowLayoutPanel
    Friend WithEvents lblKosong As Label
End Class
