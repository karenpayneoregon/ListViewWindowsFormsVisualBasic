<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.RelatedTableColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ForeignKeyColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrimaryKeyColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IdentityColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AllowNullsColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ScaleColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.label1 = New System.Windows.Forms.Label()
        Me.PrecisionColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataTypeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FieldOrderColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FieldColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.LenthColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GetInformationButton = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.tableInformationComboBox = New System.Windows.Forms.ComboBox()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.BackColor = System.Drawing.Color.White
        Me.DescriptionTextBox.Location = New System.Drawing.Point(78, 363)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.Size = New System.Drawing.Size(665, 20)
        Me.DescriptionTextBox.TabIndex = 8
        '
        'RelatedTableColumn
        '
        Me.RelatedTableColumn.Tag = "RelatedTableColumn"
        Me.RelatedTableColumn.Text = "Related Table"
        '
        'ForeignKeyColumn
        '
        Me.ForeignKeyColumn.Tag = "ForeignKeyColumn"
        Me.ForeignKeyColumn.Text = "ForeignKey"
        '
        'PrimaryKeyColumn
        '
        Me.PrimaryKeyColumn.Tag = "PrimaryKeyColumn"
        Me.PrimaryKeyColumn.Text = "PrimaryKey"
        '
        'IdentityColumn
        '
        Me.IdentityColumn.Tag = "IdentityColumn"
        Me.IdentityColumn.Text = "Identity"
        '
        'AllowNullsColumn
        '
        Me.AllowNullsColumn.Tag = "AllowNullsColumn"
        Me.AllowNullsColumn.Text = "Allow Nulls"
        '
        'ScaleColumn
        '
        Me.ScaleColumn.Tag = "ScaleColumn"
        Me.ScaleColumn.Text = "Scale"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 366)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 13)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Description"
        '
        'PrecisionColumn
        '
        Me.PrecisionColumn.Tag = "PrecisionColumn"
        Me.PrecisionColumn.Text = "Precision"
        '
        'DataTypeColumn
        '
        Me.DataTypeColumn.Tag = "DataTypeColumn"
        Me.DataTypeColumn.Text = "Data type"
        Me.DataTypeColumn.Width = 80
        '
        'FieldOrderColumn
        '
        Me.FieldOrderColumn.Tag = "FieldOrderColumn"
        Me.FieldOrderColumn.Text = "Field Order"
        Me.FieldOrderColumn.Width = 120
        '
        'FieldColumn
        '
        Me.FieldColumn.Tag = "FieldColumn"
        Me.FieldColumn.Text = "Field"
        Me.FieldColumn.Width = 50
        '
        'listView1
        '
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.FieldColumn, Me.FieldOrderColumn, Me.DataTypeColumn, Me.LenthColumn, Me.PrecisionColumn, Me.ScaleColumn, Me.AllowNullsColumn, Me.IdentityColumn, Me.PrimaryKeyColumn, Me.ForeignKeyColumn, Me.RelatedTableColumn})
        Me.listView1.FullRowSelect = True
        Me.listView1.Location = New System.Drawing.Point(0, 0)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(743, 357)
        Me.listView1.TabIndex = 6
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'LenthColumn
        '
        Me.LenthColumn.Tag = "LenthColumn"
        Me.LenthColumn.Text = "Length"
        '
        'GetInformationButton
        '
        Me.GetInformationButton.Location = New System.Drawing.Point(221, 19)
        Me.GetInformationButton.Name = "GetInformationButton"
        Me.GetInformationButton.Size = New System.Drawing.Size(75, 23)
        Me.GetInformationButton.TabIndex = 0
        Me.GetInformationButton.Text = "Populate"
        Me.GetInformationButton.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.GetInformationButton)
        Me.panel1.Controls.Add(Me.tableInformationComboBox)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 394)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(744, 56)
        Me.panel1.TabIndex = 5
        '
        'tableInformationComboBox
        '
        Me.tableInformationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tableInformationComboBox.FormattingEnabled = True
        Me.tableInformationComboBox.Location = New System.Drawing.Point(12, 21)
        Me.tableInformationComboBox.Name = "tableInformationComboBox"
        Me.tableInformationComboBox.Size = New System.Drawing.Size(193, 21)
        Me.tableInformationComboBox.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 450)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.listView1)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View table information in specific database"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents DescriptionTextBox As TextBox
    Private WithEvents RelatedTableColumn As ColumnHeader
    Private WithEvents ForeignKeyColumn As ColumnHeader
    Private WithEvents PrimaryKeyColumn As ColumnHeader
    Private WithEvents IdentityColumn As ColumnHeader
    Private WithEvents AllowNullsColumn As ColumnHeader
    Private WithEvents ScaleColumn As ColumnHeader
    Private WithEvents label1 As Label
    Private WithEvents PrecisionColumn As ColumnHeader
    Private WithEvents DataTypeColumn As ColumnHeader
    Private WithEvents FieldOrderColumn As ColumnHeader
    Private WithEvents FieldColumn As ColumnHeader
    Private WithEvents listView1 As ListView
    Private WithEvents LenthColumn As ColumnHeader
    Private WithEvents GetInformationButton As Button
    Private WithEvents panel1 As Panel
    Private WithEvents tableInformationComboBox As ComboBox
End Class
