Imports BasicListViewDetailViewExample.LanguageExtensions
Imports SqlServerOperations
Imports SqlServerOperations.Classes

Public Class ContactForm
    Private Sub ContactForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Dim dataOperations = New SqlInformation()
        Dim contacts = dataOperations.GetOwnerContacts()

        ownerContactListView.BeginUpdate()

        For Each contact In contacts

            ownerContactListView.Items.Add(
                New ListViewItem(contact.ItemArray) With
                    {
                        .Tag = contact.CustomerIdentifier
                    })

        Next

        ownerContactListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        ownerContactListView.EndUpdate()

        ownerContactListView.FocusedItem = ownerContactListView.Items(0)
        ownerContactListView.Items(0).Selected = True
        ActiveControl = ownerContactListView

    End Sub

    Private Sub ownerContactListView_MouseDoubleClick(sender As Object, e As MouseEventArgs) _
        Handles ownerContactListView.MouseDoubleClick

        MessageBox.Show(
            $"Call {ownerContactListView.SelectedItems(0).Text} at " &
            $"{ownerContactListView.SelectedItems(0).SubItems(3).Text}")

    End Sub
    ''' <summary>
    ''' Shows how to remove selected rows with a prompt.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RemoveSelectedButton_Click(sender As Object, e As EventArgs) Handles RemoveSelectedButton.Click
        DeleteSelectedListViewRows()
    End Sub

    ''' <summary>
    ''' Shows how to remove selected rows with a prompt when pressing
    ''' the DEL key.
    ''' </summary>
    ''' <param name="msg"></param>
    ''' <param name="keyData"></param>
    ''' <returns></returns>
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData <> Keys.Delete Then
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If

        DeleteSelectedListViewRows()
        Return True

    End Function
    ''' <summary>
    ''' Used to prompt for deleting rows from button click or pressing
    ''' the DEL key.
    ''' </summary>
    Private Sub DeleteSelectedListViewRows()

        Dim selectedRows = ownerContactListView.Items.SelectedRows()

        If My.Dialogs.Question($"Remove {selectedRows.Count} rows?") Then

            For Each listViewItem As ListViewItem In selectedRows
                ownerContactListView.Items.Remove(listViewItem)
            Next

        End If
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub IterateRowsButton_Click(sender As Object, e As EventArgs) Handles IterateRowsButton.Click
        Dim contactList As New List(Of Contact)

        For Each listViewItem As ListViewItem In ownerContactListView.Items

            Dim contact As New Contact With {
                    .CompanyName = listViewItem.Text,
                    .FirstName = listViewItem.SubItems(0).Text,
                    .LastName = listViewItem.SubItems(2).Text,
                    .PhoneNumber = listViewItem.SubItems(3).Text,
                    .CountryName = listViewItem.SubItems(4).Text}

            contactList.Add(contact)

        Next

        Dim dataOperations = New SqlInformation()
        dataOperations.AddContacts(contactList)


    End Sub
End Class

