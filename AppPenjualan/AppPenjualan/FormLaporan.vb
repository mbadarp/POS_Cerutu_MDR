Public Class FormLaporan

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataPelanggan.ReportSource = "..\..\CRPel.rpt"
    End Sub


    Private Sub FormLaporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserControl2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPelanggan.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Text = "Tutup"
        Me.Close()
    End Sub
End Class