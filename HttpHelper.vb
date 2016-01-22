Imports System.IO
Imports System.Net
Imports System.Text

Namespace HTSQuery

    ''' <summary>
    ''' Helper class which can perform HTTP GET
    ''' and HTTP POST operations.
    ''' </summary>
    Public Class HttpHelper

        ''' <summary>
        ''' Performs a Http Get operation.
        ''' </summary>
        ''' <param name="url">A valid Url.</param>
        ''' <returns>Response from server</returns>
        Public Shared Function HttpGET(url As String) As String
            Using web As New WebClient()
                Dim response As String = web.DownloadString(url)
                Return response
            End Using
        End Function


        ''' <summary>
        ''' Posts data to the specified URL.
        ''' </summary>
        ''' <param name="url">The URL.</param>
        ''' <param name="data">The data.</param>
        ''' <returns>Response from server</returns>
        ''' <remarks>Code here helped in writing this method
        ''' http://msdn.microsoft.com/en-us/library/debx8sh9.aspx
        ''' </remarks>
        Public Shared Function HttpPOST(url As String, data As String) As String
            Dim responseData As String
            Dim request As WebRequest = WebRequest.Create(url)
            request.Method = "POST"
            request.ContentType = "application/json"
            Dim byteData As Byte() = Encoding.UTF8.GetBytes(data)
            request.ContentLength = byteData.Length

            Using stream As Stream = request.GetRequestStream()
                stream.Write(byteData, 0, byteData.Length)
                stream.Close()
            End Using

            Using response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
                Using dataStream As Stream = response.GetResponseStream()
                    Using reader As New StreamReader(dataStream)
                        responseData = reader.ReadToEnd()
                    End Using
                End Using
            End Using

            Return responseData
        End Function
    End Class

End Namespace