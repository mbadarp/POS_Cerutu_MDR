Public Class FormCetakAdmin

    Private Sub CRAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRAdmin.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CRAdmin.ReportSource = "..\..\CRAdmin.rpt"
    End Sub
End Class