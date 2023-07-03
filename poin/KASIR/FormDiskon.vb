Imports System.Data.SqlClient
Public Class FormDiskon
    Private Sub FormDiskon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        FormKasir.load_diskon()
    End Sub

    Private Sub ButtonUpdateDiskon_Click(sender As Object, e As EventArgs) Handles ButtonUpdateDiskon.Click
        Try
            conn.Open()
            cmd = New SqlCommand("update tabel_diskon set diskon = @diskon where disid=@disid", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@diskon", TextDiskon.Text)
            cmd.Parameters.AddWithValue("@disid", "1001")
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Diskon Berhasil Diperbarui !", vbInformation)
            Else
                MsgBox("Diskon Gagal Diperbarui !", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        TextDiskon.Clear()
        FormKasir.load_diskon()
    End Sub
End Class