Public Class FormLapPenjualan

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        CRV.ReportSource = "..\..\crv_lapjual.rpt"
    End Sub
    'CRV.ReportSource = "..\..\crv_lapjual.rpt"
End Class