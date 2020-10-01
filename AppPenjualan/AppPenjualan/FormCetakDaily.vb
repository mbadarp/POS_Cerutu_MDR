Public Class FormCetakDaily

    Private Sub CRDaily_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRDaily.Load
        CRDaily.ReportSource = "..\..\CRDaily.rpt"
    End Sub
End Class