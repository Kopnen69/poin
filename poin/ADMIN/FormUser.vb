Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports MySql.Data.MySqlClient

Public Class FormUser

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Sub clear()
        TextBoxNama.Clear()
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()
        ComboBoxTugas.SelectedIndex = -1
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Me.Close() ' Menutup form Register
        ' Mengecek apakah form memiliki pemilik
        If Me.Owner IsNot Nothing Then
            Me.Owner.Show() ' Menampilkan kembali form pemiliknya
        End If
    End Sub

    Private Sub ButtonDaftar_Click(sender As Object, e As EventArgs) Handles ButtonDaftar.Click
        Try
            conn.Open()
            cmd = New SqlCommand("insert into tabel_user (nama, username, password, tugas)
            VALUES (@nama, @username, @password, @tugas)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@nama", TextBoxNama.Text)
            cmd.Parameters.AddWithValue("@username", TextBoxUsername.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text)
            cmd.Parameters.AddWithValue("@tugas", ComboBoxTugas.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("User Baru Sukses Ditambahkan !", vbInformation)
            Else
                MsgBox("User Baru Gagal Ditambahkan !", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        clear()
    End Sub
End Class