Imports System.Net
Imports Newtonsoft.Json.Linq
Imports System.Runtime.CompilerServices

Module ArrayExtension
    <Extension()> _
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        'Module to resize array as items are added

        'If array is not empty
        If arr IsNot Nothing Then
            'increase size by 1 and add item
            Array.Resize(arr, arr.Length + 1)
            arr(arr.Length - 1) = item
        Else
            'if it is, set size to 0 and add item
            ReDim arr(0)
            arr(0) = item
        End If

    End Sub
End Module

Public Class main

    'initialise global variables
    Dim FILE_NAME As String = Application.StartupPath & "\streamers.txt" 'string to hold location of streamers text file
    Dim username As String              'string to hold username
    Dim sortColumn As Integer = -1
    Dim streamerName As ColumnHeader
    Dim tab As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.authToken = "" Then

            Dim frmLogin As New login

            frmLogin.ShowDialog(Me)

            Me.Show()
            If frmLogin.authToken <> "" Then

                My.Settings.authToken = frmLogin.authToken
                My.Settings.Save()

            End If
        End If

        'Check username and livestreamer path exist
        checkInformation.RunWorkerAsync()

        'Auto resize colums to fit content
        lvFollowed.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        lvFollowed.Columns(0).Width = 0

        lvTop20.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        lvTop20.Columns(0).Width = 0

    End Sub

    Private Sub openStream(ByVal stream As String, ByVal source As String)

        'Check stream name has been entered
        If stream <> "" Then

            If source = "livestreamer" Then

                'Create livestreamer details
                Dim p As New ProcessStartInfo
                p.FileName = My.Settings.livestreamer
                p.Arguments = "twitch.tv/" & stream & " " & cmbQuality.Text

                'start livestreamer
                Process.Start(p)

            ElseIf source = "browser" Then

                Process.Start("http://www.twitch.tv/" & stream)

            End If

        End If

    End Sub

    Private Sub getListStreamer(ByVal source As String)

        Dim listview As ListView

        If TabControl1.SelectedIndex = 0 Then
            listview = lvFollowed
        ElseIf TabControl1.SelectedIndex = 1 Then
            listview = lvTop20
        Else
            listview = lvSearch
        End If

        'if a stream is selected
        If listview.SelectedItems(0).Text <> "" Then

            If Not My.Computer.FileSystem.FileExists(My.Settings.livestreamer) Then

                My.Settings.livestreamer = ""
                My.Settings.defaultViewer = "browser"
                source = "browser"

            End If

            openStream(listview.SelectedItems(0).Text, source)

        End If

    End Sub

    Private Sub getStreamsStarter(ByVal auth As Boolean)

        If tab = 2 Then
            'get search results
            getStreams.RunWorkerAsync()
        Else
            If auth <> False Then
                tab = 0
                'get followed streams
                getStreams.RunWorkerAsync()
            Else
                tab = 1
                'get top 20 streams
                getStreams.RunWorkerAsync()
            End If
        End If

    End Sub

    Private Sub getStreams_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles getStreams.DoWork

        'initialise variables
        Dim jsonString As String = ""
        Dim allOnlineComplete As Boolean = False
        Dim allStreams As Integer = 0
        Dim streams As String()

        Select Case tab
            Case 0
                jsonString = "https://api.twitch.tv/kraken/streams/followed?oauth_token=" & My.Settings.authToken & "&limit=100"
            Case 1
                jsonString = "https://api.twitch.tv/kraken/streams?limit=20"
            Case 2
                jsonString = "https://api.twitch.tv/kraken/search/streams?q=" & txtSearch.Text
        End Select

        While allOnlineComplete = False

            Dim json As String = New WebClient() _
                                 .DownloadString(jsonString) 'string to hold JSON from the query

            'parse the JSON from query into an object
            Dim online As JObject = JObject.Parse(json)

            'create list of channels
            Dim channels As IList(Of JToken) = online("streams").Children.ToList

            'iterate through the channels
            For Each channel In channels

                'get name and display name
                Dim name As JToken = channel("channel")("name")
                Dim display As JToken = channel("channel")("display_name")
                Dim game As JToken = channel("game")
                Dim viewers As JToken = channel("viewers")

                streams.Add(name.ToString & "," & display.ToString & "," & game.ToString & "," & viewers.ToString)

                allStreams += 1

            Next

            If tab = 0 Then
                Dim total As JToken = online("_total")
                If allStreams < CInt(total) Then
                    Dim nextLink As String = "https://api.twitch.tv/kraken/streams/followed?oauth_token=" & My.Settings.authToken & "&limit=100&offset=" & allStreams.ToString
                    jsonString = nextLink.ToString
                Else
                    allOnlineComplete = True
                End If
            Else
                allOnlineComplete = True
            End If

        End While

        System.IO.File.WriteAllLines(FILE_NAME, streams)

    End Sub

    Private Sub getStreams_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles getStreams.RunWorkerCompleted

        Dim listview As ListView

        If tab = 0 Then
            listview = lvFollowed
            tab = 1
            'get top 20 streams
            getStreams.RunWorkerAsync()
        ElseIf tab = 1 Then
            listview = lvTop20
        Else
            listview = lvSearch
        End If

        'clear list view
        listview.Items.Clear()

        'Load streamer database
        Dim lines() As String = System.IO.File.ReadAllLines(FILE_NAME)

        'Search through database
        For counter = 0 To lines.Length - 1

            'Split up line by comma
            Dim fields As String() = lines(counter).Split(New Char() {","c})

            Dim arr(3) As String

            arr(0) = fields(0)
            arr(1) = fields(1)
            arr(2) = fields(2)
            arr(3) = fields(3)

            listview.Items.Add(New ListViewItem(arr))

        Next

        'remove text file
        System.IO.File.Delete(FILE_NAME)

        'Auto resize colums to fit content
        listview.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
        listview.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.ColumnContent)
        listview.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize)

        'sort by viewers
        Dim sort_order As SortOrder = SortOrder.Descending
        listview.Sorting = SortOrder.Descending
        listview.Sort()
        listview.ListViewItemSorter = New ListViewComparer2(sort_order)

        'make refresh icon invisible
        lblRefresh.Visible = False

        'unlock refresh button
        btnRefresh.Enabled = True

    End Sub

    Private Sub streamersRefresh(sender As Object, e As EventArgs) Handles btnRefresh.Click

        streamersRefresh()

    End Sub

    Private Sub streamersRefresh()

        lvFollowed.Sorting = SortOrder.None
        lvTop20.Sorting = SortOrder.None

        'make refresh icon visible
        lblRefresh.Visible = True

        'lock refresh button
        btnRefresh.Enabled = False

        'begin streamer refresh
        If My.Settings.authToken <> "" Then
            getStreamsStarter(True)
        Else
            getStreamsStarter(False)
        End If

    End Sub

    Private Sub checkInformation_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles checkInformation.DoWork
    End Sub

    Private Sub checkSettings()

        'set quality settings
        cmbQuality.SelectedIndex = My.Settings.quality

        'set interval settings
        timerAutoRefresh.Interval = My.Settings.refresh * 60000

        'If livestreamer path has not been saved
        If My.Settings.livestreamer = "" Then
            'check with default path
            checkLivestreamer("C:\Program Files (x86)\Livestreamer\livestreamer.exe")
        Else
            'confirm livestreamer still exists at that path
            checkLivestreamer(My.Settings.livestreamer)

            If ToolStripMenuItem1.Enabled = False Then
                checkLivestreamer("C:\Program Files (x86)\Livestreamer\livestreamer.exe")
            End If

        End If

        If My.Settings.authToken <> "" Then

            'get username
            Dim jsonString As String = "https://api.twitch.tv/kraken/user?oauth_token=" & My.Settings.authToken
            Dim json As String = New WebClient() _
                                     .DownloadString(jsonString) 'string to hold JSON from the query

            'parse the JSON from query into an object
            Dim user As JObject = JObject.Parse(json)

            Dim name As JToken = user("name")
            My.Settings.username = name.ToString

        End If

    End Sub

    Private Sub checkLivestreamer(ByVal path As String)

        ToolStripMenuItem1.Enabled = False

        'if the file exists
        If My.Computer.FileSystem.FileExists(path) Then
            'set to that path
            My.Settings.livestreamer = path
            ToolStripMenuItem1.Enabled = True

            My.Settings.defaultViewer = "livestreamer"
        Else
            ToolStripMenuItem1.Enabled = False
            My.Settings.livestreamer = ""
            My.Settings.defaultViewer = "browser"
        End If

        My.Settings.Save()

    End Sub

    Private Sub cmbQuality_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbQuality.SelectedValueChanged

        'Set settings to current quality
        My.Settings.quality = cmbQuality.SelectedIndex
        My.Settings.Save()

    End Sub

    Private Sub checkInformation_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles checkInformation.RunWorkerCompleted

        'if auth token exists get followed streams
        If My.Settings.authToken <> "" Then

            lblRefresh.Visible = True
            getStreamsStarter(True)
            'getStreams.RunWorkerAsync()

        Else

            getStreamsStarter(False)

            lvFollowed.Items.Clear()

            Dim arr(3) As String
            arr(0) = " "
            arr(1) = "Not logged in. Please go to the settings"
            arr(2) = " "
            arr(3) = " "

            lvFollowed.Items.Add(New ListViewItem(arr))

            lvFollowed.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
            lvFollowed.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)
            lvFollowed.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize)

        End If


        'check livestreamer path exists and quality and interval settings
        checkSettings()

    End Sub

    Private Sub lvFollowed_DoubleClick(sender As Object, e As EventArgs) Handles lvFollowed.DoubleClick, lvTop20.DoubleClick, lvSearch.DoubleClick

        'Open double-clicked stream
        getListStreamer(My.Settings.defaultViewer)

    End Sub

    Private Sub lvFollowed_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvFollowed.ColumnClick

        Dim sort_order As SortOrder

        ' Determine whether the column is the same as the last column clicked.
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column

            If e.Column = 3 Then
                ' Set the sort order to descending
                sender.Sorting = SortOrder.Descending
                sort_order = SortOrder.Descending
            Else
                ' Set the sort order to ascending by default.
                sender.Sorting = SortOrder.Ascending
                sort_order = SortOrder.Ascending
            End If

        Else
            ' Determine what the last sort order was and change it.
            If sender.Sorting = SortOrder.Ascending Then
                sender.Sorting = SortOrder.Descending
                sort_order = SortOrder.Descending
            Else
                sender.Sorting = SortOrder.Ascending
                sort_order = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        sender.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        If e.Column = 3 Then
            sender.ListViewItemSorter = New ListViewComparer2(sort_order)
        Else
            sender.ListViewItemSorter = New ListViewItemComparer(e.Column, _
                                                                             sender.Sorting)
        End If


    End Sub

    Private Sub cbAutoRefresh_CheckedChanged(sender As Object, e As EventArgs) Handles cbAutoRefresh.CheckedChanged

        If cbAutoRefresh.Checked = True Then

            timerAutoRefresh.Start()

        ElseIf cbAutoRefresh.Checked = False Then

            timerAutoRefresh.Stop()

        End If

    End Sub

    Private Sub timerAutoRefresh_Tick(sender As Object, e As EventArgs) Handles timerAutoRefresh.Tick

        If btnRefresh.Enabled = True Then
            streamersRefresh()
        End If

        timerAutoRefresh.Start()

    End Sub

    Private Sub lvFollowed_MouseClick(sender As Object, e As MouseEventArgs) Handles lvFollowed.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If lvFollowed.FocusedItem.Bounds.Contains(e.Location) = True Then
                cmenuFollow.Show(Cursor.Position)
            End If
        End If

    End Sub

    Private Sub tsbSettings_Click(sender As Object, e As EventArgs) Handles tsbSettings.Click

        Dim frmSettings As New settings

        Dim result As DialogResult = frmSettings.ShowDialog(Me)

        If result = Windows.Forms.DialogResult.OK Then

            'set interval to user's input and save in settings
            If My.Settings.refresh <> frmSettings.interval Then
                My.Settings.refresh = frmSettings.interval
                My.Settings.Save()
                timerAutoRefresh.Interval = frmSettings.interval * 60000
            End If

            If My.Settings.livestreamer = "" Then
                ToolStripMenuItem1.Enabled = False
            End If

        End If

        checkInformation.RunWorkerAsync()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click, ToolStripMenuItem5.Click

        getListStreamer("browser")

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click, ToolStripMenuItem4.Click

        getListStreamer("livestreamer")

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        If txtSearch.Text <> "" Then
            tab = 2
            getStreamsStarter(False)
        End If

    End Sub
End Class

' Implements the manual sorting of items by columns.
Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(column As Integer, order As SortOrder)
        col = column
        Me.order = order
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer _
                        Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1
        returnVal = [String].Compare(CType(x,  _
                        ListViewItem).SubItems(col).Text, _
                        CType(y, ListViewItem).SubItems(col).Text)
        ' Determine whether the sort order is descending.
        If order = SortOrder.Descending Then
            ' Invert the value returned by String.Compare.
            returnVal *= -1
        End If

        Return returnVal
    End Function
End Class

Class ListViewComparer2
    Implements IComparer

    Private _ascending As SortOrder

    Public Sub New(ByVal ascend As SortOrder)
        _ascending = ascend
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim xValue, yValue As Integer
        Dim itemx, itemy As ListViewItem

        itemx = DirectCast(x, ListViewItem)
        itemy = DirectCast(y, ListViewItem)

        'you will need more conversion than cint 
        'as you have the 'KBs' to deal with
        xValue = CInt(itemx.SubItems(3).Text)
        yValue = CInt(itemy.SubItems(3).Text)

        Select Case _ascending
            Case SortOrder.Ascending
                If xValue > yValue Then Return 1
                If yValue > xValue Then Return -1
                Return 0 ' if we get here they are equal
            Case SortOrder.Descending
                'descending, do it the other way.
                If xValue > yValue Then Return -1
                If yValue > xValue Then Return 1
                Return 0 ' if we get here they are equal
            Case SortOrder.None
                Return 0 'do nothing
            Case Else
                Return 0 ' do nothing
        End Select

    End Function
End Class