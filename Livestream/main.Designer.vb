<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.cmbQuality = New System.Windows.Forms.ComboBox()
        Me.lblQuality = New System.Windows.Forms.Label()
        Me.getStreams = New System.ComponentModel.BackgroundWorker()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtStreamer = New System.Windows.Forms.TextBox()
        Me.lblOStreamer = New System.Windows.Forms.Label()
        Me.btnOpenStreamer = New System.Windows.Forms.Button()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbSettings = New System.Windows.Forms.ToolStripButton()
        Me.checkInformation = New System.ComponentModel.BackgroundWorker()
        Me.lvFollowed = New System.Windows.Forms.ListView()
        Me.streamerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Stream = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Game = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Views = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerAutoRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.cbAutoRefresh = New System.Windows.Forms.CheckBox()
        Me.lblRefresh = New System.Windows.Forms.Label()
        Me.tsMenu.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbQuality
        '
        Me.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuality.FormattingEnabled = True
        Me.cmbQuality.Items.AddRange(New Object() {"Source", "High", "Medium", "Low"})
        Me.cmbQuality.Location = New System.Drawing.Point(60, 29)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Size = New System.Drawing.Size(121, 21)
        Me.cmbQuality.TabIndex = 1
        '
        'lblQuality
        '
        Me.lblQuality.AutoSize = True
        Me.lblQuality.Location = New System.Drawing.Point(12, 32)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(42, 13)
        Me.lblQuality.TabIndex = 7
        Me.lblQuality.Text = "Quality:"
        '
        'getStreams
        '
        '
        'btnRefresh
        '
        Me.btnRefresh.Enabled = False
        Me.btnRefresh.Location = New System.Drawing.Point(322, 27)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtStreamer
        '
        Me.txtStreamer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtStreamer.Location = New System.Drawing.Point(70, 238)
        Me.txtStreamer.Name = "txtStreamer"
        Me.txtStreamer.Size = New System.Drawing.Size(100, 20)
        Me.txtStreamer.TabIndex = 10
        '
        'lblOStreamer
        '
        Me.lblOStreamer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOStreamer.AutoSize = True
        Me.lblOStreamer.Location = New System.Drawing.Point(12, 241)
        Me.lblOStreamer.Name = "lblOStreamer"
        Me.lblOStreamer.Size = New System.Drawing.Size(52, 13)
        Me.lblOStreamer.TabIndex = 11
        Me.lblOStreamer.Text = "twitch.tv/"
        '
        'btnOpenStreamer
        '
        Me.btnOpenStreamer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOpenStreamer.Location = New System.Drawing.Point(176, 236)
        Me.btnOpenStreamer.Name = "btnOpenStreamer"
        Me.btnOpenStreamer.Size = New System.Drawing.Size(93, 23)
        Me.btnOpenStreamer.TabIndex = 12
        Me.btnOpenStreamer.Text = "Open Broadcast"
        Me.btnOpenStreamer.UseVisualStyleBackColor = True
        '
        'tsMenu
        '
        Me.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbSettings})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Padding = New System.Windows.Forms.Padding(0)
        Me.tsMenu.Size = New System.Drawing.Size(409, 25)
        Me.tsMenu.TabIndex = 13
        '
        'tsbSettings
        '
        Me.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbSettings.Image = CType(resources.GetObject("tsbSettings.Image"), System.Drawing.Image)
        Me.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSettings.Name = "tsbSettings"
        Me.tsbSettings.Size = New System.Drawing.Size(53, 22)
        Me.tsbSettings.Text = "Settings"
        '
        'checkInformation
        '
        '
        'lvFollowed
        '
        Me.lvFollowed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lvFollowed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.streamerName, Me.Stream, Me.Game, Me.Views})
        Me.lvFollowed.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lvFollowed.FullRowSelect = True
        Me.lvFollowed.HideSelection = False
        Me.lvFollowed.Location = New System.Drawing.Point(12, 57)
        Me.lvFollowed.MultiSelect = False
        Me.lvFollowed.Name = "lvFollowed"
        Me.lvFollowed.Size = New System.Drawing.Size(385, 173)
        Me.lvFollowed.TabIndex = 0
        Me.lvFollowed.UseCompatibleStateImageBehavior = False
        Me.lvFollowed.View = System.Windows.Forms.View.Details
        '
        'streamerName
        '
        Me.streamerName.Text = ""
        Me.streamerName.Width = 0
        '
        'Stream
        '
        Me.Stream.Text = "Stream"
        Me.Stream.Width = 80
        '
        'Game
        '
        Me.Game.Text = "Game"
        Me.Game.Width = 141
        '
        'Views
        '
        Me.Views.Text = "Viewers"
        Me.Views.Width = 69
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem1.Text = "In VLC Player"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem2.Text = "In Browser"
        '
        'timerAutoRefresh
        '
        Me.timerAutoRefresh.Interval = 300000
        '
        'cbAutoRefresh
        '
        Me.cbAutoRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbAutoRefresh.AutoSize = True
        Me.cbAutoRefresh.Location = New System.Drawing.Point(309, 240)
        Me.cbAutoRefresh.Name = "cbAutoRefresh"
        Me.cbAutoRefresh.Size = New System.Drawing.Size(88, 17)
        Me.cbAutoRefresh.TabIndex = 15
        Me.cbAutoRefresh.Text = "Auto-Refresh"
        Me.cbAutoRefresh.UseVisualStyleBackColor = True
        '
        'lblRefresh
        '
        Me.lblRefresh.AutoSize = True
        Me.lblRefresh.Image = Global.Livestream.My.Resources.Resources.refreshing
        Me.lblRefresh.Location = New System.Drawing.Point(303, 32)
        Me.lblRefresh.Name = "lblRefresh"
        Me.lblRefresh.Size = New System.Drawing.Size(13, 13)
        Me.lblRefresh.TabIndex = 14
        Me.lblRefresh.Text = "  "
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 269)
        Me.Controls.Add(Me.cbAutoRefresh)
        Me.Controls.Add(Me.lblRefresh)
        Me.Controls.Add(Me.lvFollowed)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.btnOpenStreamer)
        Me.Controls.Add(Me.lblOStreamer)
        Me.Controls.Add(Me.txtStreamer)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblQuality)
        Me.Controls.Add(Me.cmbQuality)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(425, 600)
        Me.MinimumSize = New System.Drawing.Size(425, 308)
        Me.Name = "main"
        Me.Text = "Livestream Launcher"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbQuality As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuality As System.Windows.Forms.Label
    Friend WithEvents getStreams As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtStreamer As System.Windows.Forms.TextBox
    Friend WithEvents lblOStreamer As System.Windows.Forms.Label
    Friend WithEvents btnOpenStreamer As System.Windows.Forms.Button
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents checkInformation As System.ComponentModel.BackgroundWorker
    Friend WithEvents lvFollowed As System.Windows.Forms.ListView
    Friend WithEvents Stream As System.Windows.Forms.ColumnHeader
    Friend WithEvents Game As System.Windows.Forms.ColumnHeader
    Friend WithEvents Views As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblRefresh As System.Windows.Forms.Label
    Friend WithEvents timerAutoRefresh As System.Windows.Forms.Timer
    Friend WithEvents cbAutoRefresh As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbSettings As System.Windows.Forms.ToolStripButton

End Class
