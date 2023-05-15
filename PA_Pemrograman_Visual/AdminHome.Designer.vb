<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
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
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.AudioPanel = New System.Windows.Forms.Panel()
        Me.Content = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(1350, 64)
        Me.MenuPanel.TabIndex = 0
        '
        'AudioPanel
        '
        Me.AudioPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AudioPanel.Location = New System.Drawing.Point(0, 666)
        Me.AudioPanel.Name = "AudioPanel"
        Me.AudioPanel.Size = New System.Drawing.Size(1350, 64)
        Me.AudioPanel.TabIndex = 1
        '
        'Content
        '
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Location = New System.Drawing.Point(0, 64)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(1350, 602)
        Me.Content.TabIndex = 2
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1350, 730)
        Me.Controls.Add(Me.Content)
        Me.Controls.Add(Me.AudioPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminHome"
        Me.Text = "AdminHome"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents AudioPanel As Panel
    Friend WithEvents Content As Panel
End Class
