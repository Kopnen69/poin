Imports System.Data.SqlClient
Imports System.Globalization

Public Class FormAdmin

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        load_jualhariini()
        load_jualbulanini()
        load_semuadata()
        loadjumlahproduk()
    End Sub
    Private Sub btnKelolaProduk_Click(sender As Object, e As EventArgs) Handles btnKelolaProduk.Click
        FormProduk.ShowDialog()
    End Sub

    Private Sub btnKelolaStok_Click(sender As Object, e As EventArgs) Handles btnKelolaStok.Click
        FormStok.ShowDialog()
    End Sub

    Private Sub btnKelolaUsers_Click(sender As Object, e As EventArgs) Handles btnKelolaUsers.Click
        Dim userForm As New FormUser()
        userForm.Owner = Me ' Mengatur form Register memiliki pemilik form Admin
        userForm.ShowDialog()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        FormLaporan.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Yakin Ingin Keluar ?", vbInformation + vbYesNo) = vbYes Then
            Me.Hide()
        Else
            Return
        End If
        FormLogin.Show()
    End Sub

    Sub load_semuadata()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tabel_pos", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("bulan"), dr.Item("totalkeseluruhan"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub load_jualhariini()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT notagihan, tanggaltagihan, bulan, totalkeseluruhan FROM tabel_pos WHERE tanggaltagihan = '" & Date.Now.ToString("yyyy-MM-dd") & "' group by notagihan,tanggaltagihan, bulan, totalkeseluruhan", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("bulan"), dr.Item("totalkeseluruhan"))
                Dim sum As Double = 0
                For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    sum = sum + DataGridView1.Rows(i).Cells(3).Value
                Next
                LabelHariIni.Text = Format(sum, "N2")
                LabelJumlahHari.Text = DataGridView1.Rows.Count - 1 + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Sub load_jualbulanini()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT notagihan, tanggaltagihan, bulan, totalkeseluruhan FROM tabel_pos WHERE bulan = '" & Date.Now.ToString("MM") & "' group by notagihan,tanggaltagihan, bulan, totalkeseluruhan", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("notagihan"), dr.Item("tanggaltagihan"), dr.Item("bulan"), dr.Item("totalkeseluruhan"))
                Dim sum As Double = 0
                For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
                    sum = sum + DataGridView1.Rows(i).Cells(3).Value
                Next
                LabelBulanIni.Text = Format(sum, "N2")
                LabelJumlahBulan.Text = DataGridView1.Rows.Count - 1 + 1
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub
    Sub loadjumlahproduk()
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT COUNT(namaproduk) FROM tabel_pos", conn)
            LabelJumlahTransaksi.Text = cmd.ExecuteScalar().ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Class