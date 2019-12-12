Imports System.IO
Imports JsonLibrary
Imports LanguageExtensions

Public Class ListViewJsonExampleForm

    Private ReadOnly _fileOperations As New FileOperations()

    Private ReadOnly _fileName As String =
                         Path.Combine(
                             AppDomain.CurrentDomain.BaseDirectory,
                             "applications.json")

    Private Sub ListViewJsonExampleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Shown, AddressOf ListViewJsonExampleForm_Shown
    End Sub

    Private Sub ListViewJsonExampleForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        listView1.View = View.Details

        listView1.GridLines = True
        listView1.OwnerDraw = False
        listView1.FullRowSelect = True

        'Add column header
        listView1.Columns.Add("NameColumn", 200)
        listView1.Columns.Add("VersionColumn", 130)
        listView1.Columns.Add("KeyColumn", 160)

        listView1.Columns(0).Text = "Name"
        listView1.Columns(1).Text = "Version"
        listView1.Columns(2).Text = "Key"

        Dim applicationList = _fileOperations.LoadApplicationData(_fileName)

        '            
        ' * Add each item from json and set the identifier using the tag property
        ' * where the identifier is used to save item positions in SavePositionsButton.
        '             
        For Each app In applicationList
            Dim item = New ListViewItem(app.ItemArray()) With {.Tag = app.id}
            listView1.Items.Add(item)
        Next

        listView1.Items(0).Selected = True
        listView1.Select()

    End Sub
    ''' <summary>
    ''' Move current row unless first item
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub upButton1_Click(sender As Object, e As EventArgs) Handles upButton1.Click
        listView1.MoveListViewItems(MoveDirection.Up)
    End Sub
    ''' <summary>
    ''' Move row down unless last item.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub downButton1_Click(sender As Object, e As EventArgs) Handles downButton1.Click
        listView1.MoveListViewItems(MoveDirection.Down)
    End Sub
    ''' <summary>
    ''' Iterate each ListView item and store in a List of
    ''' Application, pass the list off to a save method to
    ''' save back to the file we read in on form shown event.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SavePositionsButton_Click(sender As Object, e As EventArgs) Handles SavePositionsButton.Click
        Dim appList = New List(Of JsonLibrary.Application)()

        For index As Integer = 0 To listView1.Items.Count - 1

            appList.Add(New Application() With {
                               .id = Convert.ToInt32(listView1.Items(index).Tag),
                               .ApplicationName = listView1.Items(index).SubItems(0).Text,
                               .ApplicationVersion = listView1.Items(index).SubItems(1).Text,
                               .ApplicationKey = listView1.Items(index).SubItems(2).Text
                           })

        Next

        _fileOperations.SaveApplicationData(appList, _fileName)

        Close()

    End Sub
End Class
