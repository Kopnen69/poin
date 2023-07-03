Imports System.Data.SqlClient
Public Class FormJenis
    Private Sub FormJenis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Try
            conn.Open()
            cmd = New SqlCommand("INSERT INTO tabel_jenisProduk (produkjenis) VALUES (@produkjenis)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@produkjenis", Text_Jenis.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Penambahan Jenis Produk Tersimpan !", vbInformation)
            Else
                MsgBox("Penambahan Jenis Produk Gagal !", vbExclamation)
            End If
            Text_Jenis.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

End Class