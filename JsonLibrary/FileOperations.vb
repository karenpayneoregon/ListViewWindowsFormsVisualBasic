Imports System.IO
Imports Newtonsoft.Json

''' <summary>
''' Responsible, using JsonNet to read and write json
''' from a json file to and from a concrete class
''' </summary>
Public Class FileOperations
    ''' <summary>
    ''' Read json file into a list which will be passed to
    ''' a form to load into a ListView
    ''' </summary>
    ''' <param name="FileName">File to read json from</param>
    ''' <returns></returns>
    Public Function LoadApplicationData(FileName As String) As List(Of Application)

        Using streamReader = New StreamReader(FileName)
            Dim json = streamReader.ReadToEnd()
            Return JsonConvert.DeserializeObject(Of List(Of Application))(json)
        End Using

    End Function
    ''' <summary>
    ''' Takes a list of application stored in a ListView and save the
    ''' data to a json file.
    ''' </summary>
    ''' <param name="Applications">List of Application</param>
    ''' <param name="FileName">Path and file name to save the list oo</param>
    Public Sub SaveApplicationData(Applications As List(Of Application), FileName As String)

        Using streamWriter = File.CreateText(FileName)

            Dim serializer = New JsonSerializer With {.Formatting = Formatting.Indented}
            serializer.Serialize(streamWriter, Applications)

        End Using

    End Sub

End Class