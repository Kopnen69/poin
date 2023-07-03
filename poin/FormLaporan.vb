Imports System.IO
Imports System.Data.SqlClient
Public Class FormLaporan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_laporan()
        Total()
    End Sub

    Sub load_laporan()
        Try
            conn.Open()
            cmd = New SqlCommand("select notagihan, tanggaltagihan, bulan, bulantahun, totalkeseluruhan from tabel_pos group by notagihan,tanggaltagihan, bulan, bulantahun, totalkeseluruhan", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("bulan"), dr.Item("bulantahun"), dr.Item("totalkeseluruhan"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        conn.Close()
    End Sub

    Private Sub TextBoxCari_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCari.TextChanged
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim searchText As String = TextBoxCari.Text
            cmd = New SqlCommand("SELECT notagihan, tanggaltagihan, bulan, bulantahun, totalkeseluruhan " &
                                 "FROM tabel_pos " &
                                 "WHERE notagihan LIKE '%' + @searchText + '%' " &
                                 "GROUP BY notagihan, tanggaltagihan,bulan, bulantahun, totalkeseluruhan", conn)
            cmd.Parameters.AddWithValue("@searchText", searchText)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("bulan"), dr.Item("bulantahun"), dr.Item("totalkeseluruhan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub RadioButtonHariIni_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonHariIni.CheckedChanged
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim searchText As String = TextBoxCari.Text
            cmd = New SqlCommand("SELECT notagihan, tanggaltagihan, bulan, bulantahun, totalkeseluruhan " &
                                 "FROM tabel_pos " &
                                 "WHERE tanggaltagihan LIKE '%" & Date.Now.ToString("yyyy-MM-dd") & "%' " &
                                 "GROUP BY notagihan, tanggaltagihan,bulan, bulantahun, totalkeseluruhan", conn)
            cmd.Parameters.AddWithValue("@searchText", searchText)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("bulan"), dr.Item("bulantahun"), dr.Item("totalkeseluruhan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub RadioButtonBulanIni_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBulanIni.CheckedChanged
        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim searchText As String = TextBoxCari.Text
            cmd = New SqlCommand("SELECT notagihan, tanggaltagihan, bulan, bulantahun, totalkeseluruhan " &
                                 "FROM tabel_pos " &
                                 "WHERE bulan LIKE '%" & Date.Now.ToString("MM") & "%' " &
                                 "GROUP BY notagihan, tanggaltagihan,bulan, bulantahun, totalkeseluruhan", conn)
            cmd.Parameters.AddWithValue("@searchText", searchText)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("bulan"), dr.Item("bulantahun"), dr.Item("totalkeseluruhan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub ButtonFilter_Click(sender As Object, e As EventArgs) Handles ButtonFilter.Click
        Dim tanggal1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim tanggal2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()

        Try
            conn.Open()
            Dim searchText As String = TextBoxCari.Text
            cmd = New SqlCommand("SELECT notagihan, tanggaltagihan, bulan, bulantahun, totalkeseluruhan " &
                                 "FROM tabel_pos " &
                                 "WHERE tanggaltagihan BETWEEN '" & tanggal1 & "' AND '" & tanggal2 & "' " &
                                 "GROUP BY notagihan, tanggaltagihan, bulan, bulantahun, totalkeseluruhan", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("bulan"), dr.Item("bulantahun"), dr.Item("totalkeseluruhan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub Total()
        Try

            Dim sum As Double = 0
            For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                sum = sum + DataGridView1.Rows(i).Cells(5).Value

            Next
            LabelTotal.Text = Format(CDec(sum), "N2")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Total()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim namaKolom As String = DataGridView1.Columns(e.ColumnIndex).Name
        If namaKolom = "kolProduk" Then
            FormLihatProduk.ShowDialog()
        End If
    End Sub
End Class