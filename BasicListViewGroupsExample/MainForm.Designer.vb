<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ProductListView = New System.Windows.Forms.ListView()
        Me.ProductColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SupplierColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PhoneColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UnitPriceColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.UnitsInStockColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.IterateListViewGroupsButton = New System.Windows.Forms.Button()
        Me.GetGroupProductsButton = New System.Windows.Forms.Button()
        Me.GroupsComboBox = New System.Windows.Forms.ComboBox()
        Me.HoverSelectionCheckBox = New System.Windows.Forms.CheckBox()
        Me.SelectionChangedLabel = New System.Windows.Forms.Label()
        Me.ItemCheckedLabel = New System.Windows.Forms.Label()
        Me.SelectedProductsButton = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductListView
        '
        Me.ProductListView.CheckBoxes = True
        Me.ProductListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ProductColumn, Me.SupplierColumn, Me.PhoneColumn, Me.UnitPriceColumn, Me.UnitsInStockColumn})
        Me.ProductListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductListView.FullRowSelect = True
        Me.ProductListView.HoverSelection = True
        Me.ProductListView.Location = New System.Drawing.Point(0, 0)
        Me.ProductListView.MultiSelect = False
        Me.ProductListView.Name = "ProductListView"
        Me.ProductListView.Size = New System.Drawing.Size(631, 470)
        Me.ProductListView.TabIndex = 5
        Me.ProductListView.UseCompatibleStateImageBehavior = False
        Me.ProductListView.View = System.Windows.Forms.View.Details
        '
        'ProductColumn
        '
        Me.ProductColumn.Text = "Product"
        Me.ProductColumn.Width = 180
        '
        'SupplierColumn
        '
        Me.SupplierColumn.Text = "Supplier"
        Me.SupplierColumn.Width = 210
        '
        'PhoneColumn
        '
        Me.PhoneColumn.Text = "Phone"
        Me.PhoneColumn.Width = 85
        '
        'UnitPriceColumn
        '
        Me.UnitPriceColumn.Text = "Unit price"
        '
        'UnitsInStockColumn
        '
        Me.UnitsInStockColumn.Text = "In stock"
        Me.UnitsInStockColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.IterateListViewGroupsButton)
        Me.panel1.Controls.Add(Me.GetGroupProductsButton)
        Me.panel1.Controls.Add(Me.GroupsComboBox)
        Me.panel1.Controls.Add(Me.HoverSelectionCheckBox)
        Me.panel1.Controls.Add(Me.SelectionChangedLabel)
        Me.panel1.Controls.Add(Me.ItemCheckedLabel)
        Me.panel1.Controls.Add(Me.SelectedProductsButton)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 470)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(631, 119)
        Me.panel1.TabIndex = 6
        '
        'IterateListViewGroupsButton
        '
        Me.IterateListViewGroupsButton.Location = New System.Drawing.Point(495, 46)
        Me.IterateListViewGroupsButton.Name = "IterateListViewGroupsButton"
        Me.IterateListViewGroupsButton.Size = New System.Drawing.Size(124, 23)
        Me.IterateListViewGroupsButton.TabIndex = 9
        Me.IterateListViewGroupsButton.Text = "Iterate Groups"
        Me.IterateListViewGroupsButton.UseVisualStyleBackColor = True
        '
        'GetGroupProductsButton
        '
        Me.GetGroupProductsButton.Location = New System.Drawing.Point(495, 12)
        Me.GetGroupProductsButton.Name = "GetGroupProductsButton"
        Me.GetGroupProductsButton.Size = New System.Drawing.Size(124, 23)
        Me.GetGroupProductsButton.TabIndex = 8
        Me.GetGroupProductsButton.Text = "Get Products"
        Me.GetGroupProductsButton.UseVisualStyleBackColor = True
        '
        'GroupsComboBox
        '
        Me.GroupsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GroupsComboBox.FormattingEnabled = True
        Me.GroupsComboBox.Location = New System.Drawing.Point(339, 14)
        Me.GroupsComboBox.Name = "GroupsComboBox"
        Me.GroupsComboBox.Size = New System.Drawing.Size(150, 21)
        Me.GroupsComboBox.TabIndex = 5
        '
        'HoverSelectionCheckBox
        '
        Me.HoverSelectionCheckBox.AutoSize = True
        Me.HoverSelectionCheckBox.Checked = True
        Me.HoverSelectionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HoverSelectionCheckBox.Location = New System.Drawing.Point(15, 46)
        Me.HoverSelectionCheckBox.Name = "HoverSelectionCheckBox"
        Me.HoverSelectionCheckBox.Size = New System.Drawing.Size(102, 17)
        Me.HoverSelectionCheckBox.TabIndex = 5
        Me.HoverSelectionCheckBox.Text = "Hover Selection"
        Me.HoverSelectionCheckBox.UseVisualStyleBackColor = True
        '
        'SelectionChangedLabel
        '
        Me.SelectionChangedLabel.AutoSize = True
        Me.SelectionChangedLabel.Location = New System.Drawing.Point(12, 95)
        Me.SelectionChangedLabel.Name = "SelectionChangedLabel"
        Me.SelectionChangedLabel.Size = New System.Drawing.Size(96, 13)
        Me.SelectionChangedLabel.TabIndex = 7
        Me.SelectionChangedLabel.Text = "Selection changed"
        '
        'ItemCheckedLabel
        '
        Me.ItemCheckedLabel.AutoSize = True
        Me.ItemCheckedLabel.Location = New System.Drawing.Point(12, 73)
        Me.ItemCheckedLabel.Name = "ItemCheckedLabel"
        Me.ItemCheckedLabel.Size = New System.Drawing.Size(73, 13)
        Me.ItemCheckedLabel.TabIndex = 6
        Me.ItemCheckedLabel.Text = "Item Checked"
        '
        'SelectedProductsButton
        '
        Me.SelectedProductsButton.Location = New System.Drawing.Point(12, 12)
        Me.SelectedProductsButton.Name = "SelectedProductsButton"
        Me.SelectedProductsButton.Size = New System.Drawing.Size(124, 23)
        Me.SelectedProductsButton.TabIndex = 5
        Me.SelectedProductsButton.Text = "Selected products"
        Me.SelectedProductsButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 589)
        Me.Controls.Add(Me.ProductListView)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group products by category"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ProductListView As ListView
    Private WithEvents ProductColumn As ColumnHeader
    Private WithEvents SupplierColumn As ColumnHeader
    Private WithEvents PhoneColumn As ColumnHeader
    Private WithEvents UnitPriceColumn As ColumnHeader
    Private WithEvents UnitsInStockColumn As ColumnHeader
    Private WithEvents panel1 As Panel
    Private WithEvents IterateListViewGroupsButton As Button
    Private WithEvents GetGroupProductsButton As Button
    Private WithEvents GroupsComboBox As ComboBox
    Private WithEvents HoverSelectionCheckBox As CheckBox
    Private WithEvents SelectionChangedLabel As Label
    Private WithEvents ItemCheckedLabel As Label
    Private WithEvents SelectedProductsButton As Button
End Class
