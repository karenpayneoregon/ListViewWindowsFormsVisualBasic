Namespace Classes
    Public Class Contact
        Public Property CustomerIdentifier() As Integer
        Public Property CompanyName() As String
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property PhoneTypeDescription() As String
        Public Property PhoneNumber() As String
        Public Property CountryName() As String

        Public ReadOnly Property ItemArray() As String()
            Get
                Return {CompanyName, FirstName, LastName, PhoneNumber, CountryName}
            End Get
        End Property

    End Class
End Namespace
