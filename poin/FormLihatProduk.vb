Imports System.Data.SqlClient
Imports VisioForge.Shared.MediaFoundation.OPM

Public Class FormLihatProduk
    Private Sub FormLihatProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_produk()
    End Sub

    Sub load_produk()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT notagihan, kodeproduk, namaproduk, jenisproduk, satuan, harga, pajak, totalhargaproduk, qty, totalhargaqty, carapembayaran FROM tabel_pos WHERE notagihan = '" & FormLaporan.DataGridView1.CurrentRow.Cells(1).Value & "'", conn)
            dr = cmd.ExecuteReader
            While dr.Read()
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr("notagihan"), dr("kodeproduk"), dr("namaproduk"), dr("jenisproduk"), dr("satuan"), dr("harga"), dr("pajak"), dr("totalhargaproduk"), dr("qty"), dr("totalhargaqty"), dr("carapembayaran"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub
End Class