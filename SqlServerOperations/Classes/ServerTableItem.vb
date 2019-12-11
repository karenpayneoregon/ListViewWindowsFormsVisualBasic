Namespace Classes
    Public Class ServerTableItem
        Public Property Table() As String
        Public Property Field() As String
        Public Property FieldOrder() As Int16?
        Public Property DataType() As String
        Public Property Length() As Int16?
        Public Property Precision() As String
        Public Property Scale() As Int32
        Public Property AllowNulls() As String
        Public Property Identity() As String = String.Empty
        Public Property PrimaryKey() As String
        Public Property ForeignKey() As String = String.Empty
        Public Property RelatedTable() As String
        Public Property Description() As String
        Public Overrides Function ToString() As String
            Return Field
        End Function
    End Class
End Namespace
