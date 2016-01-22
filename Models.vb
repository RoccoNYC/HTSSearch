Imports Newtonsoft.Json

Namespace HTSQuery

    'Public Class Result

    '    Public Property Other As String

    '    Public Property Superior As String

    '    Public Property Indent As Integer

    '    Public Property Description As String

    '    Public Property StatisticalSuffix As String

    '    Public Property Score As Decimal

    '    Public Property Special As String

    '    Public Property HTSNo As String

    '    Public Property Footnotes As List(Of Footnote)

    '    Public Property General As String

    '    Public Property Units As List(Of String)

    'End Class

    Public Class Footnote

        Public Property Marker As String

        Public Property Columns As List(Of String)

        Public Property Value As String

    End Class

    Public Class Result

        <JsonProperty("other")>
        Public Property Other As String

        <JsonProperty("superior")>
        Public Property Superior As Object

        <JsonProperty("indent")>
        Public Property Indent As String

        <JsonProperty("description")>
        Public Property Description As String

        <JsonProperty("statisticalSuffix")>
        Public Property StatisticalSuffix As String

        <JsonProperty("score")>
        Public Property Score As String

        <JsonProperty("special")>
        Public Property Special As String

        <JsonProperty("htsno")>
        Public Property Htsno As String

        <JsonProperty("footnotes")>
        Public Property Footnotes As Object

        <JsonProperty("general")>
        Public Property General As String

        <JsonProperty("units")>
        Public Property Units As Object
    End Class

    Public Class HTSResults

        Public Property Results As Result()

    End Class

End Namespace

