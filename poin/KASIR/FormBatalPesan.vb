Imports System.Data.SqlClient
Public Class FormBatalPesan
    Private Sub FormBatalPesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_batalkanPesanan()
    End Sub

    Sub load_batalkanPesanan()
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            cmd = New SqlCommand("select notagihan, tanggaltagihan, totalkeseluruhan from tabel_pos group by notagihan, tanggaltagihan, totalkeseluruhan", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("totalkeseluruhan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub TextCari_TextChanged(sender As Object, e As EventArgs) Handles TextCari.TextChanged
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim searchText As String = TextCari.Text
            cmd = New SqlCommand("SELECT notagihan, tanggaltagihan, totalkeseluruhan " &
                                 "FROM tabel_pos " &
                                 "WHERE notagihan LIKE '%' + @searchText + '%' " &
                                 "GROUP BY notagihan, tanggaltagihan, totalkeseluruhan", conn)
            cmd.Parameters.AddWithValue("@searchText", searchText)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("totalkeseluruhan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim namaKolom As String = DataGridView1.Columns(e.ColumnIndex).Name
        If namaKolom = "kolHapus" Then
            If MsgBox("Yakin Ingin Hapus ?", vbQuestion + vbYesNo) = vbYes Then
                Try
                    conn.Open()
                    cmd = New SqlCommand("delete from tabel_pos where notagihan = '" & DataGridView1.CurrentRow.Cells(1).Value & "'", conn)
                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Tagihan Berhasil Dihapus !", vbInformation)
                    Else
                        MsgBox("Tagihan Gagal Dihapus !", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                conn.Close()
            Else
                Return
            End If

        End If
        load_batalkanPesanan()
    End Sub
End Class