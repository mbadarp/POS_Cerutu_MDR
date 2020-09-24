Imports System.Data.Odbc
Public Class FormTransBeli
    Dim TglMySQL As String
    Sub KondisiAwal()
        LBLNamaSup.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLLabel4.Text
        LBLKembali.Text = ""
        TextBox2.Text = ""
        LBLNamaBarang.Text = ""
        LBLHargaBarang.Text = ""
        TextBox3.Text = ""
        TextBox3.Enabled = False
        LBLItem.Text = ""
        Call MunculKodeSupplier()
        Call NomorOtomatis()
        Call BuatKolom()
        Label10.Text = "0"
        TextBox1.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Private Sub FormTransBeli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()

    End Sub
    Sub MunculKodeSupplier()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_supplier", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_supplier where kodesupplier ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaSup.Text = Rd!nama_supplier
            LBLAlamat.Text = Rd!alamat
            LBLTelepon.Text = Rd!telepon
        End If
    End Sub

    Sub NomorOtomatis()
        Call Koneksi()
        Cmd = New OdbcCommand("Select * from tbl_beli where nobeli in (select max(nobeli) from tbl_beli)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "B" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "B" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoBeli.Text = UrutanKode
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Harga", "Harga")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("Select * From tbl_barangbeli where kodebarang= '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode barang tidak ada")
            Else
                TextBox2.Text = Rd.Item("kodebarang")
                LBLNamaBarang.Text = Rd.Item("nama_barang")
                LBLHargaBarang.Text = Rd.Item("harga_barang")
                TextBox3.Enabled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If LBLNamaBarang.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Silahkan Masukkan Kode Barang dan tekan ENTER")
        Else
            DataGridView1.Rows.Add(New String() {TextBox2.Text, LBLNamaBarang.Text, LBLHargaBarang.Text, TextBox3.Text, Val(LBLHargaBarang.Text) * Val(TextBox3.Text)})
            Call RumusSubtotal()
            TextBox2.Text = ""
            LBLNamaBarang.Text = ""
            LBLHargaBarang.Text = ""
            TextBox3.Text = ""
            TextBox3.Enabled = False
            Call RumusCariItem()

        End If
    End Sub

    Sub RumusSubtotal()
        Dim Hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Hitung = Hitung + DataGridView1.Rows(i).Cells(4).Value
            Label10.Text = Hitung
        Next
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(Label10.Text) Then
                MsgBox("Pembayaran Kurang!")
            ElseIf Val(TextBox1.Text) = Val(Label10.Text) Then
                LBLKembali.Text = 0
            ElseIf Val(TextBox1.Text) > Val(Label10.Text) Then
                LBLKembali.Text = Val(TextBox1.Text) - Val(Label10.Text)
                Button1.Focus()
            End If
        End If
    End Sub

  

    Sub RumusCariItem()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(3).Value
            LBLItem.Text = HitungItem
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If LBLKembali.Text = "" Or LBLNamaSup.Text = "" Or Label10.Text = "" Then
            MsgBox("Transaksi Tidak Ada, silahkan lakukan transaksi terlebih dahulu")
        Else
            TglMySQL = Format(Today, "yyyy-MM-dd")
            Dim SimpanBeli As String = "insert into tbl_beli values('" & LBLNoBeli.Text & "','" & TglMySQL & "','" & LBLJam.Text & "','" & Label10.Text & "','" & TextBox1.Text & "','" & LBLKembali.Text & "','" & ComboBox1.Text & "','" & FormMenuUtama.STLLabel2.Text & "')"
            Cmd = New OdbcCommand(SimpanBeli, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetailBeli As String = "insert into tbl_detailbeli values('" & LBLNoBeli.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "', '" & DataGridView1.Rows(Baris).Cells(1).Value & "', '" & DataGridView1.Rows(Baris).Cells(2).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New OdbcCommand(SimpanDetailBeli, Conn)
                Cmd.ExecuteNonQuery()

                Cmd = New OdbcCommand("select * from tbl_barangbeli where kodebarang='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
            Next
            Call KondisiAwal()
            MsgBox("Transaksi Berhasil Disimpan")

        End If
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class