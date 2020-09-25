Public Class FormLapPembelian

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        CRV.ReportSource = "..\..\CRV_beli.rpt"

    End Sub

    Private Sub FormLapPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class