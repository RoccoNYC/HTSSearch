Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class HTSSearchTest

    <TestMethod()>
    Public Sub HTSSearchTest()
        Dim ws As New HTSQuery.HTSServices
        Dim results As HTSQuery.HTSResults = ws.SearchHTS("copper")
        If results IsNot Nothing AndAlso results.Results.Count > 0 Then
            Assert.IsTrue(True, String.Format("Service return {0} HTS rows.", results.Results.Count))
        Else
            Assert.IsTrue(False, "Service return 0 HTS rows.")
        End If
        Debug.Print(results.Results.Count)
    End Sub

End Class