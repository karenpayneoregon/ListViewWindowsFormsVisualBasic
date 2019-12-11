
Imports SqlServerOperations.Classes

Namespace LanguageExtensions
    ''' <summary>
    ''' Contains project specific extension methods
    ''' </summary>
    Public Module ListViewExtensions
        ''' <summary>
        ''' Get primary and foreign keys for a product
        ''' within a ListView
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <System.Runtime.CompilerServices.Extension>
        Public Function ProductTag(sender As ListViewItem) As ProductTag
            Return DirectCast(sender.Tag, ProductTag)
        End Function
    End Module
End Namespace
