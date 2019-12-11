Imports SqlServerOperations
Imports SqlServerOperations.Classes

Public Class Form1
    Private ReadOnly _tableInformation As New SqlInformation()

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AddHandler listView1.ItemSelectionChanged, AddressOf ListView1_ItemSelectionChanged
        Dim items = _tableInformation.TableDependencies()
        tableInformationComboBox.DataSource = New BindingSource(items, Nothing)
        tableInformationComboBox.DisplayMember = "Key"
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
        If e.IsSelected Then
            DescriptionTextBox.Text = e.Item.Tag.ToString()
        End If
    End Sub
    ''' <summary>
    ''' Retrieve column details for selected table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GetInformationButton_Click(sender As Object, e As EventArgs) Handles GetInformationButton.Click
        listView1.Items.Clear()

        Dim detailItems = (CType(tableInformationComboBox.SelectedItem, KeyValuePair(Of String, List(Of ServerTableItem))))

        For Each serverTableItem In detailItems.Value
            Dim item = listView1.Items.Add(serverTableItem.FieldOrder.ToString())
            item.SubItems.Add(serverTableItem.Field)
            item.SubItems.Add(serverTableItem.DataType)
            item.SubItems.Add(serverTableItem.Length.ToString())
            item.SubItems.Add(serverTableItem.Precision)
            item.SubItems.Add(serverTableItem.Scale.ToString())
            item.SubItems.Add(serverTableItem.AllowNulls)
            item.SubItems.Add(serverTableItem.Identity)
            item.SubItems.Add(serverTableItem.PrimaryKey)
            item.SubItems.Add(serverTableItem.ForeignKey)
            item.SubItems.Add(serverTableItem.RelatedTable)

            item.Tag = serverTableItem.Description
        Next

        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        listView1.FocusedItem = listView1.Items(0)
        listView1.Items(0).Selected = True
        ActiveControl = listView1

        '            
        ' * Shade alternate rows
        '             
        Dim index = 0
        Dim shadedBackgroundColor = Color.FromArgb(240, 240, 240)

        For Each item As ListViewItem In listView1.Items
            If index Mod 2 <> 1 Then
                index += 1
                Continue For
            Else
                index += 1
            End If
            item.BackColor = shadedBackgroundColor
            item.UseItemStyleForSubItems = True
        Next

    End Sub
End Class
