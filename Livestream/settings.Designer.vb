<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.nupInterval = New System.Windows.Forms.NumericUpDown()
        Me.lnlInterval = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblAuth = New System.Windows.Forms.Label()
        Me.lblLivestreamer = New System.Windows.Forms.Label()
        Me.txtLivestreamer = New System.Windows.Forms.TextBox()
        Me.ofdLivestreamer = New System.Windows.Forms.OpenFileDialog()
        Me.btnLivestreamer = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbVLC = New System.Windows.Forms.RadioButton()
        Me.rbBrowser = New System.Windows.Forms.RadioButton()
        CType(Me.nupInterval, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Location = New System.Drawing.Point(100, 174)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(181, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'nupInterval
        '
        Me.nupInterval.Location = New System.Drawing.Point(110, 106)
        Me.nupInterval.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nupInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupInterval.Name = "nupInterval"
        Me.nupInterval.Size = New System.Drawing.Size(120, 20)
        Me.nupInterval.TabIndex = 2
        Me.nupInterval.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lnlInterval
        '
        Me.lnlInterval.AutoSize = True
        Me.lnlInterval.Location = New System.Drawing.Point(19, 113)
        Me.lnlInterval.Name = "lnlInterval"
        Me.lnlInterval.Size = New System.Drawing.Size(85, 13)
        Me.lnlInterval.TabIndex = 3
        Me.lnlInterval.Text = "Refresh Interval:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(46, 9)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username:"
        '
        'lblAuth
        '
        Me.lblAuth.AutoSize = True
        Me.lblAuth.Location = New System.Drawing.Point(38, 35)
        Me.lblAuth.Name = "lblAuth"
        Me.lblAuth.Size = New System.Drawing.Size(66, 13)
        Me.lblAuth.TabIndex = 5
        Me.lblAuth.Text = "Auth Token:"
        '
        'lblLivestreamer
        '
        Me.lblLivestreamer.AutoSize = True
        Me.lblLivestreamer.Location = New System.Drawing.Point(9, 61)
        Me.lblLivestreamer.Name = "lblLivestreamer"
        Me.lblLivestreamer.Size = New System.Drawing.Size(95, 13)
        Me.lblLivestreamer.TabIndex = 6
        Me.lblLivestreamer.Text = "Livestreamer Path:"
        '
        'txtLivestreamer
        '
        Me.txtLivestreamer.Location = New System.Drawing.Point(110, 58)
        Me.txtLivestreamer.Name = "txtLivestreamer"
        Me.txtLivestreamer.ReadOnly = True
        Me.txtLivestreamer.Size = New System.Drawing.Size(154, 20)
        Me.txtLivestreamer.TabIndex = 7
        '
        'ofdLivestreamer
        '
        Me.ofdLivestreamer.FileName = "livestreamer.exe"
        Me.ofdLivestreamer.Filter = "livestreamer.exe|livestreamer.exe"
        '
        'btnLivestreamer
        '
        Me.btnLivestreamer.Location = New System.Drawing.Point(270, 56)
        Me.btnLivestreamer.Name = "btnLivestreamer"
        Me.btnLivestreamer.Size = New System.Drawing.Size(75, 23)
        Me.btnLivestreamer.TabIndex = 8
        Me.btnLivestreamer.Text = "Browse..."
        Me.btnLivestreamer.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(112, 132)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Default Viewer:"
        '
        'rbVLC
        '
        Me.rbVLC.AutoSize = True
        Me.rbVLC.Location = New System.Drawing.Point(110, 85)
        Me.rbVLC.Name = "rbVLC"
        Me.rbVLC.Size = New System.Drawing.Size(77, 17)
        Me.rbVLC.TabIndex = 11
        Me.rbVLC.TabStop = True
        Me.rbVLC.Text = "VLC Player"
        Me.rbVLC.UseVisualStyleBackColor = True
        '
        'rbBrowser
        '
        Me.rbBrowser.AutoSize = True
        Me.rbBrowser.Location = New System.Drawing.Point(193, 85)
        Me.rbBrowser.Name = "rbBrowser"
        Me.rbBrowser.Size = New System.Drawing.Size(63, 17)
        Me.rbBrowser.TabIndex = 12
        Me.rbBrowser.TabStop = True
        Me.rbBrowser.Text = "Browser"
        Me.rbBrowser.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 211)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbBrowser)
        Me.Controls.Add(Me.rbVLC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnLivestreamer)
        Me.Controls.Add(Me.txtLivestreamer)
        Me.Controls.Add(Me.lblLivestreamer)
        Me.Controls.Add(Me.lblAuth)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lnlInterval)
        Me.Controls.Add(Me.nupInterval)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "settings"
        Me.Text = "Settings"
        CType(Me.nupInterval, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents nupInterval As System.Windows.Forms.NumericUpDown
    Friend WithEvents lnlInterval As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblAuth As System.Windows.Forms.Label
    Friend WithEvents lblLivestreamer As System.Windows.Forms.Label
    Friend WithEvents txtLivestreamer As System.Windows.Forms.TextBox
    Friend WithEvents ofdLivestreamer As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnLivestreamer As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbVLC As System.Windows.Forms.RadioButton
    Friend WithEvents rbBrowser As System.Windows.Forms.RadioButton
End Class
