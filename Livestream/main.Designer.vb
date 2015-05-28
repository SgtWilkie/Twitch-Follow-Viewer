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
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbSettings = New System.Windows.Forms.ToolStripButton()
        Me.checkInformation = New System.ComponentModel.BackgroundWorker()
        Me.lvFollowed = New System.Windows.Forms.ListView()
        Me.streamerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Stream = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Game = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Views = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmenuFollow = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerAutoRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.cbAutoRefresh = New System.Windows.Forms.CheckBox()
        Me.lblRefresh = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpFollow = New System.Windows.Forms.TabPage()
        Me.tpTop20 = New System.Windows.Forms.TabPage()
        Me.lvTop20 = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmenuTop20 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpSearch = New System.Windows.Forms.TabPage()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lvSearch = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tsMenu.SuspendLayout()
        Me.cmenuFollow.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpFollow.SuspendLayout()
        Me.tpTop20.SuspendLayout()
        Me.cmenuTop20.SuspendLayout()
        Me.tpSearch.SuspendLayout()
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
        Me.btnRefresh.Location = New System.Drawing.Point(322, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
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
        Me.lvFollowed.ContextMenuStrip = Me.cmenuFollow
        Me.lvFollowed.FullRowSelect = True
        Me.lvFollowed.HideSelection = False
        Me.lvFollowed.Location = New System.Drawing.Point(0, 0)
        Me.lvFollowed.MultiSelect = False
        Me.lvFollowed.Name = "lvFollowed"
        Me.lvFollowed.Size = New System.Drawing.Size(376, 216)
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
        'cmenuFollow
        '
        Me.cmenuFollow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.cmenuFollow.Name = "ContextMenuStrip1"
        Me.cmenuFollow.Size = New System.Drawing.Size(104, 26)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem1.Text = "In VLC Player"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem2.Text = "In Browser"
        '
        'timerAutoRefresh
        '
        Me.timerAutoRefresh.Interval = 300000
        '
        'cbAutoRefresh
        '
        Me.cbAutoRefresh.AutoSize = True
        Me.cbAutoRefresh.Location = New System.Drawing.Point(309, 41)
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
        Me.lblRefresh.Location = New System.Drawing.Point(303, 17)
        Me.lblRefresh.Name = "lblRefresh"
        Me.lblRefresh.Size = New System.Drawing.Size(13, 13)
        Me.lblRefresh.TabIndex = 14
        Me.lblRefresh.Text = "  "
        Me.lblRefresh.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpFollow)
        Me.TabControl1.Controls.Add(Me.tpTop20)
        Me.TabControl1.Controls.Add(Me.tpSearch)
        Me.TabControl1.Location = New System.Drawing.Point(13, 56)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 242)
        Me.TabControl1.TabIndex = 16
        '
        'tpFollow
        '
        Me.tpFollow.Controls.Add(Me.lvFollowed)
        Me.tpFollow.Location = New System.Drawing.Point(4, 22)
        Me.tpFollow.Name = "tpFollow"
        Me.tpFollow.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFollow.Size = New System.Drawing.Size(376, 216)
        Me.tpFollow.TabIndex = 0
        Me.tpFollow.Text = "Following"
        Me.tpFollow.UseVisualStyleBackColor = True
        '
        'tpTop20
        '
        Me.tpTop20.Controls.Add(Me.lvTop20)
        Me.tpTop20.Location = New System.Drawing.Point(4, 22)
        Me.tpTop20.Name = "tpTop20"
        Me.tpTop20.Size = New System.Drawing.Size(376, 216)
        Me.tpTop20.TabIndex = 3
        Me.tpTop20.Text = "Top 20 Streams"
        Me.tpTop20.UseVisualStyleBackColor = True
        '
        'lvTop20
        '
        Me.lvTop20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lvTop20.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lvTop20.ContextMenuStrip = Me.cmenuTop20
        Me.lvTop20.FullRowSelect = True
        Me.lvTop20.HideSelection = False
        Me.lvTop20.Location = New System.Drawing.Point(0, 0)
        Me.lvTop20.MultiSelect = False
        Me.lvTop20.Name = "lvTop20"
        Me.lvTop20.Size = New System.Drawing.Size(376, 216)
        Me.lvTop20.TabIndex = 1
        Me.lvTop20.UseCompatibleStateImageBehavior = False
        Me.lvTop20.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = ""
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Stream"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Game"
        Me.ColumnHeader7.Width = 141
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Viewers"
        Me.ColumnHeader8.Width = 69
        '
        'cmenuTop20
        '
        Me.cmenuTop20.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.cmenuTop20.Name = "ContextMenuStrip1"
        Me.cmenuTop20.Size = New System.Drawing.Size(104, 26)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem3.Text = "Open"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem4.Text = "In VLC Player"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem5.Text = "In Browser"
        '
        'tpSearch
        '
        Me.tpSearch.Controls.Add(Me.btnSearch)
        Me.tpSearch.Controls.Add(Me.txtSearch)
        Me.tpSearch.Controls.Add(Me.lvSearch)
        Me.tpSearch.Location = New System.Drawing.Point(4, 22)
        Me.tpSearch.Name = "tpSearch"
        Me.tpSearch.Size = New System.Drawing.Size(376, 216)
        Me.tpSearch.TabIndex = 2
        Me.tpSearch.Text = "Search"
        Me.tpSearch.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(140, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(130, 20)
        Me.txtSearch.TabIndex = 2
        '
        'lvSearch
        '
        Me.lvSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lvSearch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
        Me.lvSearch.ContextMenuStrip = Me.cmenuFollow
        Me.lvSearch.FullRowSelect = True
        Me.lvSearch.HideSelection = False
        Me.lvSearch.Location = New System.Drawing.Point(0, 30)
        Me.lvSearch.MultiSelect = False
        Me.lvSearch.Name = "lvSearch"
        Me.lvSearch.Size = New System.Drawing.Size(376, 186)
        Me.lvSearch.TabIndex = 1
        Me.lvSearch.UseCompatibleStateImageBehavior = False
        Me.lvSearch.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = ""
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Stream"
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Game"
        Me.ColumnHeader11.Width = 141
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Viewers"
        Me.ColumnHeader12.Width = 69
        '
        'main
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 310)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.cbAutoRefresh)
        Me.Controls.Add(Me.lblRefresh)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.lblQuality)
        Me.Controls.Add(Me.cmbQuality)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(425, 600)
        Me.MinimumSize = New System.Drawing.Size(425, 308)
        Me.Name = "main"
        Me.Text = "Twitch Follow Viewer"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.cmenuFollow.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpFollow.ResumeLayout(False)
        Me.tpTop20.ResumeLayout(False)
        Me.cmenuTop20.ResumeLayout(False)
        Me.tpSearch.ResumeLayout(False)
        Me.tpSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbQuality As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuality As System.Windows.Forms.Label
    Friend WithEvents getStreams As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents tsMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents checkInformation As System.ComponentModel.BackgroundWorker
    Friend WithEvents lvFollowed As System.Windows.Forms.ListView
    Friend WithEvents Stream As System.Windows.Forms.ColumnHeader
    Friend WithEvents Game As System.Windows.Forms.ColumnHeader
    Friend WithEvents Views As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblRefresh As System.Windows.Forms.Label
    Friend WithEvents timerAutoRefresh As System.Windows.Forms.Timer
    Friend WithEvents cbAutoRefresh As System.Windows.Forms.CheckBox
    Friend WithEvents cmenuFollow As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpFollow As System.Windows.Forms.TabPage
    Friend WithEvents tpTop20 As System.Windows.Forms.TabPage
    Friend WithEvents tpSearch As System.Windows.Forms.TabPage
    Friend WithEvents lvTop20 As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lvSearch As System.Windows.Forms.ListView
    Private WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmenuTop20 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem

End Class
