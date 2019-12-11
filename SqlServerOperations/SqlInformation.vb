Imports System.Data.SqlClient
Imports BaseConnectionLibrary.ConnectionClasses
Imports SqlServerOperations.Classes

''' <summary>
''' Class responsible for interacting with a SQL-Server instance
''' In the new constructor
'''   - DatabaseServer points to your SQL-Server e.g. .\SQLEXPRESS or a name instance
'''   - DefaultCatalog is the database catalog data is read from, do not change this unless
'''     experience with setting a default catalog for a connection.
''' </summary>
Public Class SqlInformation
    Inherits SqlServerConnection
    ''' <summary>
    ''' Setup to construct database connection string
    ''' </summary>
    Public Sub New()
        ' TODO Change this to .\SQLEXPRESS for release
        DatabaseServer = "KARENS-PC"
        DefaultCatalog = "NorthWindAzure3"
    End Sub

    Public Function TableDependencies() As Dictionary(Of String, List(Of ServerTableItem))
        mHasException = False

        Dim selectStatement =
                <SQL>
                SELECT	syso.name [Table],
		                sysc.name [Field], 
		                sysc.colorder [FieldOrder], 
		                syst.name [DataType], 
		                sysc.[length] [Length], 
		                CASE WHEN sysc.prec IS NULL THEN 'NULL' ELSE CAST(sysc.prec AS VARCHAR) END [Precision],
                CASE WHEN sysc.scale IS null THEN '-' ELSE sysc.scale END [Scale], 
                CASE WHEN sysc.isnullable = 1 THEN 'True' ELSE 'False' END [AllowNulls], 
                CASE WHEN sysc.[status] = 128 THEN 'True' ELSE 'False' END [Identity], 
                CASE WHEN sysc.colstat = 1 THEN 'True' ELSE 'False' END [PrimaryKey],
                CASE WHEN fkc.parent_object_id is NULL THEN 'False' ELSE 'True' END [ForeignKey], 
                CASE WHEN fkc.parent_object_id is null THEN '(none)' ELSE obj.name  END [RelatedTable],
                CASE WHEN ep.value is NULL THEN '(none)' ELSE CAST(ep.value as NVARCHAR(500)) END [Description]
                FROM [sys].[sysobjects] AS syso
                JOIN [sys].[syscolumns] AS sysc on syso.id = sysc.id
                LEFT JOIN [sys].[systypes] AS syst ON sysc.xtype = syst.xtype and syst.name != 'sysname'
                LEFT JOIN [sys].[foreign_key_columns] AS fkc on syso.id = fkc.parent_object_id and 
                    sysc.colid = fkc.parent_column_id    
                LEFT JOIN [sys].[objects] AS obj ON fkc.referenced_object_id = obj.[object_id]
                LEFT JOIN [sys].[extended_properties] AS ep ON syso.id = ep.major_id and sysc.colid = 
                    ep.minor_id and ep.name = 'MS_Description'
                WHERE syso.type = 'U' AND  syso.name != 'sysdiagrams'
                ORDER BY [Table], FieldOrder, Field;
             </SQL>.Value

        Dim informationTable = New DataTable()

        Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
            Using cmd = New SqlCommand() With {.Connection = cn}
                cmd.CommandText = selectStatement

                Try

                    cn.Open()

                    informationTable.Load(cmd.ExecuteReader())
                Catch e As Exception
                    mHasException = True
                    mLastException = e
                End Try

            End Using
        End Using

        Dim anonymousResult = From row In informationTable.AsEnumerable()
                              Group row By GroupKey = row.Field(Of String)("Table") Into grp = Group
                              Select New With
                    {
                        Key .TableName = GroupKey,
                        Key .Rows = grp,
                        Key .Count = grp.Count()
                    }

        Dim tableDictionary = New Dictionary(Of String, List(Of ServerTableItem))()

        For Each topItem In anonymousResult

            If Not tableDictionary.ContainsKey(topItem.TableName) Then
                tableDictionary(topItem.TableName) = New List(Of ServerTableItem)()
            End If

            For Each row In topItem.Rows
                tableDictionary(topItem.TableName).Add(
                    New ServerTableItem() With
                      {
                          .Table = topItem.TableName,
                          .Field = row.Field(Of String)("Field"),
                          .FieldOrder = row.Field(Of Short)("FieldOrder"),
                          .DataType = row.Field(Of String)("DataType"),
                          .Length = row.Field(Of Short)("Length"),
                          .Precision = row.Field(Of String)("Precision"),
                          .Scale = row.Field(Of Integer)("Scale"),
                          .AllowNulls = row.Field(Of String)("AllowNulls"),
                          .Identity = row.Field(Of String)("Identity"),
                          .PrimaryKey = row.Field(Of String)("PrimaryKey"),
                          .ForeignKey = row.Field(Of String)("ForeignKey"),
                          .RelatedTable = row.Field(Of String)("RelatedTable"),
                          .Description = row.Field(Of String)("Description")
                      })
            Next
        Next

        Return tableDictionary

    End Function

    Public Function Products(Identifier As Integer) As List(Of Product)
        mHasException = False

        Dim productList = New List(Of Product)()

        Dim selectStatement =
                <SQL>
                SELECT   P.ProductID ,
                         P.ProductName ,
                         P.SupplierID ,
                         S.CompanyName AS Supplier ,
                         S.Phone ,
                         P.CategoryID ,
                         P.UnitPrice ,
                         P.UnitsInStock
                FROM     dbo.Products AS P
                         INNER JOIN dbo.Suppliers AS S ON P.SupplierID = S.SupplierID
                WHERE    P.CategoryID = @CategoryIdentifier
                ORDER BY P.ProductName;
                </SQL>.Value

        Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
            Using cmd = New SqlCommand() With {.Connection = cn}

                cmd.CommandText = selectStatement
                cmd.Parameters.AddWithValue("@CategoryIdentifier", Identifier)

                Try
                    cn.Open()
                    Dim reader = cmd.ExecuteReader()
                    Do While reader.Read()

                        productList.Add(New Product() With
                           {
                               .ProductId = reader.GetInt32(0),
                               .ProductName = reader.GetString(1),
                               .SupplierId = reader.GetInt32(2),
                               .Supplier = reader.GetString(3),
                               .Phone = reader.GetString(4),
                               .CategoryId = reader.GetInt32(5),
                               .UnitPrice = reader.GetDecimal(6),
                               .UnitsInStock = reader.GetInt16(7)
                           })

                    Loop
                Catch e As Exception
                    mHasException = True
                    mLastException = e
                End Try
            End Using
        End Using

        Return productList
    End Function

    Public Function Categories() As List(Of Category)
        mHasException = False

        Dim categoryList = New List(Of Category)()
        Dim selectStatement = "SELECT CategoryID,CategoryName FROM dbo.Categories"

        Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
            Using cmd = New SqlCommand() With {.Connection = cn}

                cmd.CommandText = selectStatement

                Try

                    cn.Open()

                    Dim reader = cmd.ExecuteReader()

                    Do While reader.Read()
                        categoryList.Add(New Category() With
                            {
                                .CategoryId = reader.GetInt32(0),
                                .Name = reader.GetString(1)
                            })
                    Loop

                Catch e As Exception
                    mHasException = True
                    mLastException = e
                End Try
            End Using
        End Using

        Return categoryList

    End Function

    Public Function GetOwnerContacts() As List(Of Contact)
        mHasException = False

        Dim ownerContacts = New List(Of Contact)()


        Dim contactTypeIdentifier As Integer = 7

        Dim selectStatement =
                <SQL>
                SELECT   Cust.CustomerIdentifier ,
                         Cust.CompanyName ,
                         cont.FirstName ,
                         cont.LastName ,
                         PT.PhoneTypeDescription ,
                         CCD.PhoneNumber ,
                         Countries.CountryName
                FROM     Customers AS Cust
                         INNER JOIN dbo.Contact AS cont ON Cust.ContactIdentifier = 
                            cont.ContactIdentifier
                         INNER JOIN dbo.ContactContactDevices AS CCD ON cont.ContactIdentifier = 
                            CCD.ContactIdentifier
                         INNER JOIN dbo.PhoneType AS PT ON CCD.PhoneTypeIdenitfier = 
                            PT.PhoneTypeIdenitfier
                         INNER JOIN dbo.Countries ON Cust.CountryIdentfier = Countries.id
                WHERE    ( Cust.ContactTypeIdentifier = <%= contactTypeIdentifier %> )
                ORDER BY Cust.CompanyName;
                </SQL>.Value


        Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
            Using cmd = New SqlCommand() With {.Connection = cn}
                Try
                    cn.Open()

                    cmd.CommandText = selectStatement

                    Dim reader = cmd.ExecuteReader()
                    Do While reader.Read()

                        ownerContacts.Add(New Contact() With
                         {
                             .CustomerIdentifier = reader.GetInt32(0),
                             .CompanyName = reader.GetString(1),
                             .FirstName = reader.GetString(2),
                             .LastName = reader.GetString(3),
                             .PhoneTypeDescription = reader.GetString(4),
                             .PhoneNumber = reader.GetString(5),
                             .CountryName = reader.GetString(6)
                         })
                    Loop

                Catch e As Exception
                    mHasException = True
                    mLastException = e
                End Try
            End Using
        End Using

        Return ownerContacts
    End Function
    ''' <summary>
    ''' Unused, here for article informational only
    ''' </summary>
    ''' <param name="Identifier"></param>
    ''' <returns></returns>
    Public Function GetSuppliers(Identifier As Integer) As Supplier
        mHasException = False

        Dim supplier = New Supplier()

        Dim selectStatement =
                <SQL>
                    SELECT 
                        SupplierID,
                        CompanyName,
                        ContactName,
                        ContactTitle,
                        Phone,
                        [Address] AS Street,
                        City,
                        PostalCode,
                        Country 
                    FROM 
                        dbo.Suppliers 
                    WHERE 
                        SupplierID = @SupplierId
                </SQL>.Value



        Using cn = New SqlConnection() With {.ConnectionString = ConnectionString}
            Using cmd = New SqlCommand() With {.Connection = cn}

                cmd.Parameters.AddWithValue("@SupplierId", Identifier)

                Try
                    cn.Open()

                    Dim reader = cmd.ExecuteReader()

                    If reader.HasRows Then

                        reader.Read()

                        supplier.SupplierId = Identifier
                        supplier.CompanyName = reader.GetString(0)
                        supplier.ContactName = reader.GetString(1)
                        supplier.ContactTitle = reader.GetString(2)
                        supplier.Phone = reader.GetString(3)
                        supplier.Address = reader.GetString(4)
                        supplier.City = reader.GetString(5)
                        supplier.PostalCode = reader.GetString(6)
                        supplier.Country = reader.GetString(7)

                    End If
                Catch e As Exception
                    mHasException = True
                    mLastException = e
                End Try
            End Using
        End Using

        Return supplier

    End Function

End Class