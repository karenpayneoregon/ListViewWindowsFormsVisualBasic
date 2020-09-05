<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContactForm
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
        Me.ownerContactListView = New System.Windows.Forms.ListView()
        Me.CompanyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FirstNameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LastNameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PhoneColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CountryColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.RemoveSelectedButton = New System.Windows.Forms.Button()
        Me.IterateRowsButton = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ownerContactListView
        '
        Me.ownerContactListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CompanyName, Me.FirstNameColumn, Me.LastNameColumn, Me.PhoneColumn, Me.CountryColumn})
        Me.ownerContactListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ownerContactListView.FullRowSelect = True
        Me.ownerContactListView.HideSelection = False
        Me.ownerContactListView.Location = New System.Drawing.Point(0, 0)
        Me.ownerContactListView.Name = "ownerContactListView"
        Me.ownerContactListView.Size = New System.Drawing.Size(566, 380)
        Me.ownerContactListView.TabIndex = 4
        Me.ownerContactListView.UseCompatibleStateImageBehavior = False
        Me.ownerContactListView.View = System.Windows.Forms.View.Details
        '
        'CompanyName
        '
        Me.CompanyName.Text = "Company"
        '
        'FirstNameColumn
        '
        Me.FirstNameColumn.Text = "First"
        '
        'LastNameColumn
        '
        Me.LastNameColumn.Text = "Last"
        '
        'PhoneColumn
        '
        Me.PhoneColumn.Text = "Phone"
        '
        'CountryColumn
        '
        Me.CountryColumn.Text = "Country"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(479, 23)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.IterateRowsButton)
        Me.panel1.Controls.Add(Me.RemoveSelectedButton)
        Me.panel1.Controls.Add(Me.ExitButton)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 380)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(566, 70)
        Me.panel1.TabIndex = 3
        '
        'RemoveSelectedButton
        '
        Me.RemoveSelectedButton.Location = New System.Drawing.Point(13, 25)
        Me.RemoveSelectedButton.Name = "RemoveSelectedButton"
        Me.RemoveSelectedButton.Size = New System.Drawing.Size(106, 23)
        Me.RemoveSelectedButton.TabIndex = 1
        Me.RemoveSelectedButton.Text = "Remove selected"
        Me.RemoveSelectedButton.UseVisualStyleBackColor = True
        '
        'IterateRowsButton
        '
        Me.IterateRowsButton.Location = New System.Drawing.Point(125, 25)
        Me.IterateRowsButton.Name = "IterateRowsButton"
        Me.IterateRowsButton.Size = New System.Drawing.Size(100, 23)
        Me.IterateRowsButton.TabIndex = 2
        Me.IterateRowsButton.Text = "Iterate rows"
        Me.IterateRowsButton.UseVisualStyleBackColor = True
        '
        'ContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 450)
        Me.Controls.Add(Me.ownerContactListView)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ContactForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contacts -Owners"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ownerContactListView As ListView
    Private WithEvents CompanyName As ColumnHeader
    Private WithEvents FirstNameColumn As ColumnHeader
    Private WithEvents LastNameColumn As ColumnHeader
    Private WithEvents PhoneColumn As ColumnHeader
    Private WithEvents CountryColumn As ColumnHeader
    Private WithEvents ExitButton As Button
    Private WithEvents panel1 As Panel
    Private WithEvents RemoveSelectedButton As Button
    Friend WithEvents IterateRowsButton As Button
End Class
