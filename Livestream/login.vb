Imports System.Web

Public Class login

    Public ReadOnly Property authToken As String
        Get
            Return access_token
        End Get
    End Property

    Dim access_token As String = ""

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim authUrl As String = "https://api.twitch.tv/kraken/oauth2/authorize?response_type=token&client_id=rt8pansev8rj82ka6vb3i3x6q4229tx&redirect_uri=http://localhost&scope=user_read"

        WebBrowser1.Navigate(authUrl)

    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated

        Dim url As String = WebBrowser1.Url.AbsoluteUri.ToString

        If url.Contains("access_token") Then

            access_token = url.Remove(0, url.IndexOf("=") + 1)
            access_token = access_token.Remove(access_token.IndexOf("&"), access_token.Length - access_token.IndexOf("&"))
            WebBrowser1.Stop()
            Me.Close()

        End If

    End Sub

End Class