﻿Public Class SelectedProductsForm
    Private Sub SelectedProductsForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        textBox1.Text = _selectedData
    End Sub
    Private _selectedData As String
    Public Sub New(selectedData As String)
        InitializeComponent()
        _selectedData = selectedData
        AddHandler Shown, AddressOf SelectedProductsForm_Shown
    End Sub
End Class