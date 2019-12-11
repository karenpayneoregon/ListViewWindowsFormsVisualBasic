Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace LanguageExtensions
    Public Module Extensions
        ''' <summary>
        ''' Provides the ability to remove selected rows in detail view.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function SelectedRows(sender As ListView.ListViewItemCollection) As List(Of ListViewItem)

            Return sender.Cast(Of ListViewItem)().
                Where(Function(listViewItem) listViewItem.Selected).
                Select(Function(listViewItem) listViewItem).
                ToList()

        End Function
    End Module
End Namespace
