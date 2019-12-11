
Public Class Application
    Public Property id() As Integer
    Public Property ApplicationName() As String
    Public Property ApplicationVersion() As String
    Public Property ApplicationKey() As String
    ''' <summary>
    ''' Used to load ListView items in ListViewJsonExampleForm
    ''' </summary>
    ''' <returns></returns>
    Public Function ItemArray() As String()
        Return {ApplicationName, ApplicationVersion, ApplicationKey}
    End Function

End Class