Imports System.Data.SqlClient
Imports System.IO
Imports MessagingToolkit.Barcode
Imports TheArtOfDevHtmlRenderer.Adapters

Public Class FormProduk

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        load_JenisProduk()
        load_produk()
    End Sub
    Private Sub ButtonTambahClick(sender As Object, e As EventArgs) Handles ButtonTambah.Click
        FormJenis.ShowDialog()
    End Sub

    Sub load_JenisProduk()
        Combo_Jenis.Items.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tabel_jenisProduk", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                Combo_Jenis.Items.Add(dr.Item("produkjenis").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub
    Sub load_produk()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("select kode_produk, nama_produk, jenis_produk, satuan, lokasi, harga, pajak, total_harga, stok, barcode from tabel_produk", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("kode_produk"), dr.Item("nama_produk"), dr.Item("jenis_produk"), dr.Item("satuan"), dr.Item("lokasi"), dr.Item("harga"), dr.Item("pajak"), dr.Item("total_harga"), dr.Item("stok"), dr.Item("barcode"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub clear()
        'Text_CariKode.Clear()
        Text_Kode.Clear()
        Text_NamaProduk.Clear()
        Combo_Jenis.SelectedIndex = -1
        Combo_Satuan.SelectedIndex = -1
        Combo_Pajak.SelectedIndex = -1
        Text_Lokasi.Clear()
        Text_Total.Clear()
        Text_Harga.Clear()
        PictureBarcode.Image = Nothing

    End Sub

    Private Sub Text_Kode_TextChanged(sender As Object, e As EventArgs) Handles Text_Kode.TextChanged
        'Membuat Barcode
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.BackColor = Color.White

        Try
            PictureBarcode.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, Text_Kode.Text))
        Catch ex As Exception
            PictureBarcode.Image = Nothing
        End Try

    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Try
            conn.Open()
            'konversi gambar ke format binary
            Dim FileSize As UInt32
            Dim mstream As New System.IO.MemoryStream
            PictureBarcode.Image.Save(mstream, Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            FileSize = mstream.Length
            mstream.Close()
            cmd = New SqlCommand("INSERT INTO tabel_produk (kode_produk
           ,nama_produk
           ,jenis_produk
           ,satuan
           ,lokasi
           ,harga
           ,pajak
           ,total_harga
           ,barcode) VALUES (@kode_produk,@nama_produk,@jenis_produk,@satuan,@lokasi,@harga,@pajak,@total_harga,@barcode) ", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode_produk", Text_Kode.Text)
            cmd.Parameters.AddWithValue("@nama_produk", Text_NamaProduk.Text)
            cmd.Parameters.AddWithValue("@jenis_produk", Combo_Jenis.Text)
            cmd.Parameters.AddWithValue("@satuan", Combo_Satuan.Text)
            cmd.Parameters.AddWithValue("@lokasi", Text_Lokasi.Text)
            cmd.Parameters.AddWithValue("@harga", CDec(Text_Harga.Text))
            cmd.Parameters.AddWithValue("@pajak", CDec(Combo_Pajak.Text))
            cmd.Parameters.AddWithValue("@total_harga", CDec(Text_Total.Text))
            cmd.Parameters.AddWithValue("@barcode", arrImage)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Produk Baru Sukses Disimpan !", vbInformation)
            Else
                MsgBox("Produk Baru Gagal Disimpan !", vbExclamation)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
    End Sub

    Private Sub Combo_Pajak_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Pajak.SelectedIndexChanged
        Try
            Text_Total.Text = CDec(Text_Harga.Text * Combo_Pajak.Text / 100) + Text_Harga.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Text_Cari_TextChanged(sender As Object, e As EventArgs) Handles Text_Cari.TextChanged
        'cari barang
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("select * from tabel_produk where kode_produk like '%" & Text_Cari.Text & "%' or nama_produk like '%" & Text_Cari.Text & "%' or jenis_produk like '%" & Text_Cari.Text & "%' ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("kode_produk"), dr.Item("nama_produk"), dr.Item("jenis_produk"), dr.Item("satuan"), dr.Item("lokasi"), dr.Item("harga"), dr.Item("pajak"), dr.Item("total_harga"), dr.Item("stok"), dr.Item("barcode"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub ButtonCari_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
        Text_Kode.ReadOnly = True

        Try
            conn.Open()
            cmd = New SqlCommand("select kode_produk, nama_produk, jenis_produk,satuan, lokasi, harga, pajak, total_harga, stok, barcode from tabel_produk where kode_produk like '%" & Text_CariKode.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                Text_Kode.Text = dr.Item("kode_produk")
                Text_NamaProduk.Text = dr.Item("nama_produk")
                Combo_Jenis.Text = dr.Item("jenis_produk")
                Combo_Satuan.Text = dr.Item("satuan")
                Text_Lokasi.Text = dr.Item("lokasi")
                Text_Harga.Text = dr.Item("harga")
                Combo_Pajak.Text = dr.Item("pajak")
                Text_Total.Text = dr.Item("total_harga")
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()

    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        Try
            conn.Open()
            cmd = New SqlCommand("update tabel_produk set kode_produk=@kode_produk, nama_produk=@nama_produk, jenis_produk=@jenis_produk,satuan=@satuan, lokasi=@lokasi, harga=@harga, pajak=@pajak, total_harga=@total_harga from tabel_produk where kode_produk like '%" & Text_CariKode.Text & "%'", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@kode_produk", Text_Kode.Text)
            cmd.Parameters.AddWithValue("@nama_produk", Text_NamaProduk.Text)
            cmd.Parameters.AddWithValue("@jenis_produk", Combo_Jenis.Text)
            cmd.Parameters.AddWithValue("@satuan", Combo_Satuan.Text)
            cmd.Parameters.AddWithValue("@lokasi", Text_Lokasi.Text)
            cmd.Parameters.AddWithValue("@harga", CDec(Text_Harga.Text))
            cmd.Parameters.AddWithValue("@pajak", CDec(Combo_Pajak.Text))
            cmd.Parameters.AddWithValue("@total_harga", CDec(Text_Total.Text))
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Update Produk Sukses !", vbInformation)
            Else
                MsgBox("Update Produk Gagal !", vbExclamation)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
        clear()
        load_produk()
    End Sub

    Private Sub ButtonHapus_Click(sender As Object, e As EventArgs) Handles ButtonHapus.Click
        If MsgBox("Yakin Ingin Hapus Produk ?", vbExclamation + vbYesNo) = vbYes Then
            Try
                conn.Open()
                cmd = New SqlCommand("delete from tabel_produk where kode_produk=@kode_produk", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@kode_produk", Text_Kode.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Hapus Produk Sukses !", vbInformation)
                Else
                    MsgBox("Hapus Produk Gagal !", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
            conn.Close()
            clear()
            load_produk()
            Text_CariKode.Clear()
        Else
            Return
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clear()
        Text_CariKode.Clear()
    End Sub

End Class