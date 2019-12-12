Public Class UtilityViewerForm
    Private Sub UtilityViewerForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        textBox1.Text = _selectedData
    End Sub
    Private _selectedData As String
    Public Sub New(selectedData As String)
        InitializeComponent()
        _selectedData = selectedData
        AddHandler Shown, AddressOf UtilityViewerForm_Shown
    End Sub
End Class