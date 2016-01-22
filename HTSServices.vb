Imports System.Text
Imports System.IO
Imports System.Runtime.Serialization.Json
Imports Newtonsoft.Json

Namespace HTSQuery

    ''' <summary>
    ''' HTSServices class is used to access USITC HTS API.
    ''' This class provides one methods:
    ''' <list type="number">
    ''' <item>
    '''     <term>SearchHTS()</term>
    '''     <description>Search for tariff articles containing a given word/phrase as specified by the parameter</description>
    ''' </item>
    ''' </list>
    ''' </summary>
    Public Class HTSServices
        Private searchURL As String = "https://hts.usitc.gov/api/"

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="searchPhrase"></param>
        ''' <returns></returns>
        Public Function SearchHTS(searchPhrase As String) As HTSResults
            Dim getURL As String = searchURL & "search?query=" & searchPhrase
            Dim response As String = HttpHelper.HttpGET(getURL)

            Return DeserializeJSON(response)
        End Function

        ''' <summary>
        ''' Deserializes the JSON recieved from USITC.
        ''' </summary>
        ''' <typeparam name="T"></typeparam>
        ''' <param name="input">JSON recieved from USITC.</param>
        ''' <returns>An instance of type T</returns>
        Private Shared Function DeserializeJSON(input As String) As HTSResults
            Dim reply As HTSResults = JsonConvert.DeserializeObject(Of HTSResults)(input)
            Return reply
        End Function
    End Class

End Namespace

