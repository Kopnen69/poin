Imports System.Data.SqlClient
Imports System.Globalization
Public Class FormKasir

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        Text_CariProduk_Barcode.Focus()
        total()
        ButtonBayar.Enabled = False
        load_diskon()
        textNoTagihan.Text = Getnotagihan()
    End Sub

    Public Sub ADDLIST()
        Dim exist As Boolean = False, numrow As Integer = 0, numtext As Integer
        For Each item As DataGridViewRow In DataGridView1.Rows
            If item.Cells(0).Value IsNot Nothing Then
                If item.Cells(1).Value.ToString = Text_CariProduk_Barcode.Text Then
                    exist = True
                    numrow = item.Index
                    numtext = CInt(item.Cells(8).Value)
                    Exit For

                End If
            End If
        Next
        If exist = False Then
            Try
                conn.Open()
                cmd = New SqlCommand("select * from tabel_produk where kode_produk = '" & Text_CariProduk_Barcode.Text & "'", conn)
                dr = cmd.ExecuteReader
                While dr.Read()
                    If Text_CariProduk_Barcode.Text = String.Empty Then
                        Return
                    Else
                        'buat baris baru
                        'kode_produk, nama_produk, jenis_produk, satuan, lokasi, harga, pajak, total_harga
                        Dim kode_produk As String = dr("kode_produk")
                        Dim nama_produk As String = dr("nama_produk")
                        Dim jenis_produk As String = dr("jenis_produk")
                        Dim satuan As String = dr("satuan")
                        Dim harga As Decimal = dr("harga")
                        Dim pajak As Decimal = dr("pajak")
                        Dim total_harga As Decimal = dr("total_harga")

                        Dim totalhargaqty As Double
                        totalhargaqty = harga * pajak / 100 + harga

                        DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, kode_produk, nama_produk, jenis_produk, satuan, harga, pajak, total_harga, 1, totalhargaqty)

                        Text_CariProduk_Barcode.Clear()
                        Text_CariProduk_Barcode.Focus()

                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            DataGridView1.Rows(numrow).Cells(8).Value = CInt("1") + numtext
            DataGridView1.Rows(numrow).Cells(9).Value = DataGridView1.Rows(numrow).Cells(7).Value * DataGridView1.Rows(numrow).Cells(8).Value
        End If
    End Sub

    Private Sub Text_CariProduk_Barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles Text_CariProduk_Barcode.KeyDown
        If Text_CariProduk_Barcode.Text = Nothing Then
        Else
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True
                ADDLIST()

                Text_CariProduk_Barcode.Clear()
                Text_CariProduk_Barcode.Focus()
            End If
        End If
    End Sub

    Public Sub total()
        LabelJumlahBarang.Text = DataGridView1.Rows.Count - 1 + 1

        Dim jumlahsum As Double = 0
        Dim subtotal As Double = 0
        Dim pajaktax As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            jumlahsum = jumlahsum + DataGridView1.Rows(i).Cells(9).Value
            pajaktax = pajaktax + DataGridView1.Rows(i).Cells(5).Value * DataGridView1.Rows(i).Cells(6).Value / 100 * DataGridView1.Rows(i).Cells(8).Value
            subtotal = subtotal + DataGridView1.Rows(i).Cells(5).Value * DataGridView1.Rows(i).Cells(8).Value
        Next
        Try
            LabelSubtotal.Text = CDec(subtotal).ToString("N2")
            LabelTotalHarga.Text = CDec(subtotal + pajaktax).ToString("N2")
            LabelTotalPajak.Text = CDec(pajaktax).ToString("N2")
            'LabelDiskon.Text = CDec(textDiskon.Text * LabelTotalHarga.Text / 100).ToString("N2")
            Dim diskonValue As Double = 0
            If Not String.IsNullOrEmpty(textDiskon.Text) AndAlso Double.TryParse(textDiskon.Text, diskonValue) Then
                LabelDiskon.Text = CDec(diskonValue * CDec(LabelTotalHarga.Text) / 100).ToString("N2")
            Else
                LabelDiskon.Text = "0.00"
            End If
            LabelTotalKeseluruhan.Text = CDec(LabelTotalHarga.Text - LabelDiskon.Text).ToString("N2")
            LabelHitungKeseluruhan.Text = CDec(LabelTotalKeseluruhan.Text).ToString("N2")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        total()
    End Sub

    Private Sub textJmlDiterima_TextChanged(sender As Object, e As EventArgs) Handles textJmlDiterima.TextChanged
        Dim totalKeseluruhan As Double
        Dim jmlDiterima As Double
        Dim kembalian As Double

        If Double.TryParse(LabelTotalKeseluruhan.Text, totalKeseluruhan) AndAlso Double.TryParse(textJmlDiterima.Text, jmlDiterima) Then
            kembalian = jmlDiterima - totalKeseluruhan
            LabelKembalian.Text = kembalian.ToString("N2")
        Else
            ' Penanganan error jika terjadi kesalahan konversi
            LabelKembalian.Text = "0.00"
        End If
        ButtonBayar.Enabled = True
    End Sub

    Public Sub load_diskon()
        Try
            conn.Open()
            cmd = New SqlCommand("select * from tabel_diskon", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                textDiskon.Text = dr.Item("diskon")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dr.Close()
            conn.Close()
        End Try
    End Sub

    Private Sub ButtonDiskon_Click(sender As Object, e As EventArgs) Handles ButtonDiskon.Click
        FormDiskon.ShowDialog()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim culture As New CultureInfo("id-ID")
        LabelWaktu.Text = DateTime.Now.ToString("HH:mm:ss")
        LabelTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy", culture)
    End Sub

    Sub simpan_tagihan()
        If ComboPembayaran.Text = String.Empty Then
            MsgBox("Silahkan Pilih Metode Pembayaran !", vbInformation)
            Return
        ElseIf textJmlDiterima.Text = String.Empty Then
            MsgBox("Silahkan Masukkan Nominal yang Dibayarkan !", vbInformation)
            Return
        ElseIf Decimal.Parse(LabelTotalKeseluruhan.Text) > Decimal.Parse(textJmlDiterima.Text) Then
            MsgBox("Jumlah Pembayaran Tidak Mencukupi !", vbExclamation)
            Return
        End If

        Try
            conn.Open()
            Dim i As Integer = 0 ' Tambahkan variabel i sebelum loop For
            Dim culture As New CultureInfo("id-ID")

            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                cmd = New SqlCommand("INSERT INTO tabel_pos (notagihan, tanggaltagihan, bulan, bulantahun, kodeproduk, namaproduk, jenisproduk, satuan, harga, pajak, totalhargaproduk, qty, totalhargaqty, subtotal, totalpajak, totalharga, diskon, totalkeseluruhan, carapembayaran, uangditerima, neracabalance) VALUES (@notagihan, @tanggaltagihan, @bulan, @bulantahun, @kodeproduk, @namaproduk, @jenisproduk, @satuan, @harga, @pajak, @totalhargaproduk, @qty, @totalhargaqty, @subtotal, @totalpajak, @totalharga, @diskon, @totalkeseluruhan, @carapembayaran, @uangditerima, @neracabalance);", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@notagihan", textNoTagihan.Text)
                cmd.Parameters.AddWithValue("@tanggaltagihan", CDate(WaktuTanggal.Text))
                'cmd.Parameters.AddWithValue("@tanggaltagihan", WaktuTanggal.Value.ToString("dd-MM-yyyy", culture))
                cmd.Parameters.AddWithValue("@bulan", Date.Now.ToString("MM", culture))
                cmd.Parameters.AddWithValue("@bulantahun", Date.Now.ToString("MMMM-yyyy", culture))

                cmd.Parameters.AddWithValue("@kodeproduk", DataGridView1.Rows(j).Cells(1).Value)
                cmd.Parameters.AddWithValue("@namaproduk", DataGridView1.Rows(j).Cells(2).Value)
                cmd.Parameters.AddWithValue("@jenisproduk", DataGridView1.Rows(j).Cells(3).Value)
                cmd.Parameters.AddWithValue("@satuan", DataGridView1.Rows(j).Cells(4).Value)
                cmd.Parameters.AddWithValue("@harga", Decimal.Parse(DataGridView1.Rows(j).Cells(5).Value))
                cmd.Parameters.AddWithValue("@pajak", Decimal.Parse(DataGridView1.Rows(j).Cells(6).Value))
                cmd.Parameters.AddWithValue("@totalhargaproduk", Decimal.Parse(DataGridView1.Rows(j).Cells(7).Value))
                cmd.Parameters.AddWithValue("@qty", Decimal.Parse(DataGridView1.Rows(j).Cells(8).Value))
                cmd.Parameters.AddWithValue("@totalhargaqty", Decimal.Parse(DataGridView1.Rows(j).Cells(9).Value))

                cmd.Parameters.AddWithValue("@subtotal", Decimal.Parse(LabelSubtotal.Text))
                cmd.Parameters.AddWithValue("@totalpajak", Decimal.Parse(LabelTotalPajak.Text))
                cmd.Parameters.AddWithValue("@totalharga", Decimal.Parse(LabelTotalHarga.Text))
                cmd.Parameters.AddWithValue("@diskon", Decimal.Parse(LabelDiskon.Text))
                cmd.Parameters.AddWithValue("@totalkeseluruhan", Decimal.Parse(LabelTotalKeseluruhan.Text))
                cmd.Parameters.AddWithValue("@carapembayaran", ComboPembayaran.Text)
                cmd.Parameters.AddWithValue("@uangditerima", Decimal.Parse(textJmlDiterima.Text))
                cmd.Parameters.AddWithValue("@neracabalance", Decimal.Parse(LabelKembalian.Text))

                i = cmd.ExecuteNonQuery
            Next

            If i > 0 Then
                MsgBox("Transaksi Baru Sukses Disimpan !" & Environment.NewLine & "Nomor Tagihan : " & textNoTagihan.Text, vbInformation)

            Else
                MsgBox("Transaksi Terakhir Gagal !", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
            textNoTagihan.Text = Getnotagihan()
            Clear()
        End Try
    End Sub

    Private Sub ButtonBayar_Click(sender As Object, e As EventArgs) Handles ButtonBayar.Click
        simpan_tagihan()
        'FormPrintTagihan.ShowDialog()
        Clear()
        textNoTagihan.Text = Getnotagihan()
        Text_CariProduk_Barcode.Focus()
    End Sub

    Sub Clear()

        WaktuTanggal.Text = Now
        Text_CariProduk_Barcode.Clear()
        DataGridView1.Rows.Clear()
        LabelKembalian.Text = "0.00"
        LabelDiskon.Text = "0.00"
        LabelTotalKeseluruhan.Text = "0.00"
        LabelJumlahBarang.Text = "0"
        LabelHitungKeseluruhan.Text = "0.00"
        LabelSubtotal.Text = "0.00"
        LabelTotalHarga.Text = "0.00"
        LabelTotalPajak.Text = "0.00"
        ComboPembayaran.SelectedIndex = -1
        textJmlDiterima.Clear()


    End Sub

    Private Sub ButtonBaru_Click(sender As Object, e As EventArgs) Handles ButtonBaru.Click
        Clear()
        textNoTagihan.Text = Getnotagihan()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            DataGridView1.Rows.Remove(selectedRow)
        Else
            MsgBox("Pilih baris yang ingin dihapus.", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub ButtonUbahPassword_Click(sender As Object, e As EventArgs) Handles ButtonUbahPassword.Click
        FormUbahPassword.ShowDialog()
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        FormBatalPesan.ShowDialog()
    End Sub
    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        If MsgBox("Yakin Ingin Keluar ?", vbInformation + vbYesNo) = vbYes Then
            Me.Hide()
        Else
            Return
        End If
        FormLogin.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Memastikan hanya baris yang diklik yang dipilih
        If e.RowIndex >= 0 Then
            DataGridView1.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub ButtonLaporan_Click(sender As Object, e As EventArgs) Handles ButtonLaporan.Click
        FormLaporan.ShowDialog()
    End Sub
End Class