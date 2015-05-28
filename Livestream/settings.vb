Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class settings

    Public ReadOnly Property interval As String

        Get
            Return nupInterval.Value
        End Get

    End Property

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUsername.Text = "Username:    " & My.Settings.username
        lblAuth.Text = "Auth Token:    " & My.Settings.authToken
        txtLivestreamer.Text = My.Settings.livestreamer
        nupInterval.Value = My.Settings.refresh

        If My.Settings.livestreamer = "" Then
            rbBrowser.Checked = True
            rbVLC.Enabled = False
        ElseIf My.Settings.defaultViewer = "browser" Then
            rbBrowser.Checked = True
        ElseIf My.Settings.defaultViewer = "livestreamer" Then
            rbVLC.Checked = True
        End If

        If My.Settings.authToken = "" Then
            btnLogout.Text = "Login"
        ElseIf My.Settings.authToken <> "" Then
            btnLogout.Text = "Logout"
        End If

    End Sub

    Private Sub btnLivestreamer_Click(sender As Object, e As EventArgs) Handles btnLivestreamer.Click

        'open file dialog to allow user to get livestreamer path
        Dim result As DialogResult = ofdLivestreamer.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then

            'save path to settings
            My.Settings.livestreamer = ofdLivestreamer.FileName
            My.Settings.Save()
            rbVLC.Enabled = True
            txtLivestreamer.Text = My.Settings.livestreamer

        Else

            My.Settings.livestreamer = ""
            My.Settings.Save()

        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If My.Settings.authToken <> "" Then

            My.Settings.authToken = ""
            My.Settings.username = ""
            My.Settings.Save()

            MsgBox("To log out of your account, you must clear your cache and cookies for Twitch in Internet Explorer." & vbNewLine & "Once the cookies and have been cleared, click log in to access another account." & vbNewLine & "If you wish to log back in to the current account, just click Login")

            btnLogout.Text = "Login"
            lblUsername.Text = "Username:"
            lblAuth.Text = "Auth Token:"

        ElseIf My.Settings.authToken = "" Then

            Dim frmLogin As New login

            frmLogin.ShowDialog(Me)

            Me.Show()

            If frmLogin.authToken <> "" Then

                My.Settings.authToken = frmLogin.authToken

                'get username
                Dim jsonString As String = "https://api.twitch.tv/kraken/user?oauth_token=" & My.Settings.authToken
                Dim json As String = New WebClient() _
                                         .DownloadString(jsonString) 'string to hold JSON from the query

                'parse the JSON from query into an object
                Dim user As JObject = JObject.Parse(json)

                Dim name As JToken = user("name")
                My.Settings.username = name.ToString

                My.Settings.Save()

                btnLogout.Text = "Logout"
                lblUsername.Text = "Username:    " & My.Settings.username
                lblAuth.Text = "Auth Token:    " & My.Settings.authToken

            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rbVLC.Checked = True Then
            My.Settings.defaultViewer = "livestreamer"
        ElseIf rbBrowser.Checked = True Then
            My.Settings.defaultViewer = "browser"
        End If

        My.Settings.Save()

    End Sub
End Class