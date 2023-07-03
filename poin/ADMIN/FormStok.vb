Imports System.Data.SqlClient
Public Class FormStok
    Dim j As New Integer
    Private Sub FormStok_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        DataGridView1.RowTemplate.Height = 30
        load_stok()
    End Sub

    Sub load_stok()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("select kode_produk, nama_produk, jenis_produk, satuan, lokasi, harga, pajak, total_harga, stok from tabel_produk", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("kode_produk"), dr.Item("nama_produk"), dr.Item("jenis_produk"), dr.Item("satuan"), dr.Item("lokasi"), dr.Item("harga"), dr.Item("pajak"), dr.Item("total_harga"), dr.Item("stok"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Text_Cari_TextChanged(sender As Object, e As EventArgs) Handles Text_Cari.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("select kode_produk, nama_produk, jenis_produk, satuan, lokasi, harga, pajak, total_harga, stok from tabel_produk where kode_produk like '%" & Text_Cari.Text & "%' or nama_produk like '%" & Text_Cari.Text & "%' or jenis_produk like '%" & Text_Cari.Text & "%' or lokasi like '%" & Text_Cari.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("kode_produk"), dr.Item("nama_produk"), dr.Item("jenis_produk"), dr.Item("satuan"), dr.Item("lokasi"), dr.Item("harga"), dr.Item("pajak"), dr.Item("total_harga"), dr.Item("stok"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    'Private Sub ButtonUpdateStok_Click(sender As Object, e As EventArgs) Handles ButtonUpdateStok.Click
    '        For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
    '    Try
    '        conn.Open()
    '            cmd = New SqlCommand("update tabel_produk set stok=@stok where kode_produk = @kode_produk", conn)
    '            cmd.Parameters.Clear()
    '            cmd.Parameters.AddWithValue("@stok", DataGridView1.Rows(j).Cells(9).Value.ToString)
    '            cmd.Parameters.AddWithValue("@kode_produk", DataGridView1.Rows(j).Cells(1).Value.ToString)
    '            i = cmd.ExecuteNonQuery
    '        Next
    '        If i > 0 Then
    '            MsgBox("Berhasil Update Stok !", vbInformation)
    '        Else
    '            MsgBox("Gagal Update Stok !", vbCritical)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    conn.Close()
    '    load_stok()
    'End Sub

    Private Sub ButtonUpdateStok_Click(sender As Object, e As EventArgs) Handles ButtonUpdateStok.Click
        Try
            conn.Open()
            For j As Integer = 0 To DataGridView1.Rows.Count - 1 Step +1
                Dim stokValue As String = DataGridView1.Rows(j).Cells(9).Value.ToString()
                Dim stokNumeric As Decimal

                If Decimal.TryParse(stokValue, stokNumeric) Then
                    cmd = New SqlCommand("UPDATE tabel_produk SET stok = @stok WHERE kode_produk = @kode_produk", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@stok", stokNumeric)
                    cmd.Parameters.AddWithValue("@kode_produk", DataGridView1.Rows(j).Cells(1).Value.ToString())
                    i = cmd.ExecuteNonQuery()
                Else
                    ' Tangani nilai yang tidak valid di Cells(9)
                    MsgBox("Nilai stok tidak valid pada baris " & (j + 1).ToString(), vbExclamation)
                End If
            Next

            If i > 0 Then
                MsgBox("Berhasil Update Stok!", vbInformation)
            Else
                MsgBox("Gagal Update Stok!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

        load_stok()
    End Sub

End Class