Imports System.Windows.Forms

Public Module ListViewExtensions
    ''' <summary>
    ''' Move row up or down dependent on direction parameter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="moveDirection">Up or Down</param>
    <Runtime.CompilerServices.Extension>
    Public Sub MoveListViewItems(sender As ListView, moveDirection As MoveDirection)

        Dim direction As Integer = moveDirection

        Dim valid As Boolean = sender.SelectedItems.Count > 0 AndAlso
                               ((moveDirection = MoveDirection.Down AndAlso
                                 (sender.SelectedItems(sender.SelectedItems.Count - 1).Index < sender.Items.Count - 1)) OrElse
                                (moveDirection = MoveDirection.Up AndAlso (sender.SelectedItems(0).Index > 0)))

        If valid Then

            sender.SuspendLayout()

            Try
                For Each item As ListViewItem In sender.SelectedItems

                    Dim index = item.Index + direction
                    sender.Items.RemoveAt(item.Index)
                    sender.Items.Insert(index, item)
                    sender.Items(index).Selected = True
                    sender.Focus()

                Next
            Finally

                sender.ResumeLayout()

            End Try
        End If
    End Sub
End Module