Imports System.Text
Imports BasicListViewGroupsExample.LanguageExtensions
Imports SqlServerOperations

Public Class MainForm
    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim dataOperations = New SqlInformation()
        Dim categories = dataOperations.Categories()

        Dim categoryIndex = 1

        ' ReSharper disable once TooWideLocalVariableScope
        Dim groupName = ""

        For Each category In categories
            Dim products = dataOperations.Products(category.CategoryId)

            '                
            '                 * Some category names have unwanted characters and/or whitespace, remove these chars.
            '                 
            groupName = category.Name.Replace("/", "").Replace(" ", "")

            Dim currentGroup = New ListViewGroup(category.Name, HorizontalAlignment.Left) With {
                    .Header = category.Name,
                    .Name = $"{groupName}Group{categoryIndex}"
                }

            categoryIndex += 1

            ProductListView.Groups.Add(currentGroup)

            For Each product In products
                Dim listViewProductItem = New ListViewItem(
                    {
                        product.ProductName,
                        product.Supplier,
                        product.Phone,
                        product.UnitPrice.ToString(),
                        product.UnitsInStock.ToString()
                    }, -1)

                listViewProductItem.Group = currentGroup
                listViewProductItem.Tag = product.IdentifiersTag
                listViewProductItem.UseItemStyleForSubItems = False


                If product.UnitsInStock = 0 Then
                    listViewProductItem.SubItems(4).ForeColor = Color.Red
                    listViewProductItem.SubItems(4).Font = New Font(listViewProductItem.SubItems(4).Font.FontFamily, listViewProductItem.SubItems(4).Font.Size, FontStyle.Bold)
                End If

                ProductListView.Items.Add(listViewProductItem)
            Next
        Next

        ProductListView.FocusedItem = ProductListView.Items(0)
        ProductListView.Items(0).Selected = True

        ActiveControl = ProductListView

        'ProductListView.ItemSelectionChanged += ProductListView_ItemSelectionChanged
        'ProductListView.ItemCheck += ProductListView_ItemCheck

        AddHandler ProductListView.ItemSelectionChanged, AddressOf ProductListView_ItemSelectionChanged
        AddHandler ProductListView.ItemCheck, AddressOf ProductListView_ItemCheck
        GroupsComboBox.DataSource = ProductListView.Groups.Cast(Of ListViewGroup)().Select(Function(lvg) lvg.Name).ToList()

    End Sub

    Private Sub ProductListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs)
        If e.IsSelected Then
            Dim primaryKeys = e.Item.ProductTag()
            SelectionChangedLabel.Text = $"product: {primaryKeys.ProductId} " & $"{ProductListView.Items(e.ItemIndex).Text}"
        End If
    End Sub

    Private Sub ProductListView_ItemCheck(sender As Object, e As ItemCheckEventArgs)
        Dim primaryKeys = ProductListView.Items(e.Index).ProductTag()

        If e.NewValue = CheckState.Checked Then
            ItemCheckedLabel.Text = $"Current checked: product: {primaryKeys.ProductId} category: {primaryKeys.CategoryId} " & $"supplier: {primaryKeys.SupplierId}"
        Else
            ItemCheckedLabel.Text = $"Current un-checked: product: {primaryKeys.ProductId} category: {primaryKeys.CategoryId} " & $"supplier: {primaryKeys.SupplierId}"
        End If

    End Sub

    Private Sub SelectedProductsButton_Click(sender As Object, e As EventArgs) Handles SelectedProductsButton.Click
        Dim checkedItems = ProductListView.CheckedItems

        If checkedItems.Count > 0 Then
            Dim sb = New StringBuilder()

            For index As Integer = 0 To checkedItems.Count - 1
                Dim keys = checkedItems(index).ProductTag()

                sb.AppendLine($"{keys.CategoryId}," & $"{checkedItems(index).Group.Header}," & $"{keys.ProductId}," & $"{checkedItems(index).Text}," & $"{keys.SupplierId}," & $"{checkedItems(index).SubItems(0).Text}")
            Next

            '                
            '                 * Show selected products, in a real application this data
            '                 * would be sent to a method to process the products
            '                 

            Dim f = New SelectedProductsForm(sb.ToString())

            Try
                f.ShowDialog()
            Finally
                f.Dispose()
            End Try
        Else
            MessageBox.Show("No product(s) selected")
        End If

    End Sub

    Private Sub HoverSelectionCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HoverSelectionCheckBox.CheckedChanged
        ProductListView.HoverSelection = HoverSelectionCheckBox.Checked
    End Sub

    Private Sub GetGroupProductsButton_Click(sender As Object, e As EventArgs) Handles GetGroupProductsButton.Click
        Dim specificGroup = ProductListView.Groups.Cast(Of ListViewGroup)().FirstOrDefault(Function(lvg) lvg.Name = GroupsComboBox.Text)

        For index As Integer = 0 To specificGroup.Items.Count - 1
            Dim productTag = specificGroup.Items(index).ProductTag()
            Console.WriteLine($"Id: {productTag.ProductId} Product: {specificGroup.Items(index).Text}")
        Next

    End Sub

    Private Sub IterateListViewGroupsButton_Click(sender As Object, e As EventArgs) Handles IterateListViewGroupsButton.Click
        For index As Integer = 0 To ProductListView.Groups.Count - 1
            Console.WriteLine(ProductListView.Groups(index).Header)
            Console.WriteLine()
            Console.WriteLine("Product id  Supplier id")
            Dim itemsIndex As Integer = 0
            Do While itemsIndex < ProductListView.Groups(index).Items.Count
                Dim keys = ProductListView.Groups(index).Items(itemsIndex).ProductTag()
                Console.WriteLine($"{keys.ProductId,5} {keys.SupplierId,12}")
                itemsIndex += 1
            Loop

            Console.WriteLine()
        Next
    End Sub
End Class
