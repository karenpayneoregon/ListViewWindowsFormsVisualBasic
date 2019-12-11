Imports System.IO
Imports System.Runtime.Serialization.Json
Imports System.Text

Public Class JSonHelper
    Public Function ConvertObjectToJSon(Of T)(ByVal obj As T) As String
        Dim ser = New DataContractJsonSerializer(GetType(T))
        Dim ms = New MemoryStream()
        ser.WriteObject(ms, obj)
        Dim jsonString As String = Encoding.UTF8.GetString(ms.ToArray())
        ms.Close()
        Return jsonString
    End Function

    Public Function ConvertJSonToObject(Of T)(ByVal jsonString As String) As T
        Dim serializer = New DataContractJsonSerializer(GetType(T))
        Dim ms = New MemoryStream(Encoding.UTF8.GetBytes(jsonString))
        Dim obj As T = DirectCast(serializer.ReadObject(ms), T)
        Return obj
    End Function
End Class