Namespace Classes
    Public Class Product
        Public Property ProductId() As Integer
        Public Property ProductName() As String
        Public Property SupplierId() As Integer
        Public Property Supplier() As String
        Public Property Phone() As String
        Public Property CategoryId() As Integer
        Public Property UnitPrice() As Decimal?
        Public Property UnitsInStock() As Integer
        ''' <summary>
        ''' Container for ListView item to store primary keys
        ''' </summary>
        Public ReadOnly Property IdentifiersTag() As ProductTag
            Get
                Return New ProductTag() With
                    {
                        .CategoryId = CategoryId,
                        .SupplierId = SupplierId,
                        .ProductId = ProductId
                    }
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return $"{ProductName}"
        End Function
    End Class
End Namespace
