Imports System.Data.SqlClient

Public Class FormUbahPassword

    Private Sub FormUbahPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub
    Private Sub ButtonUbahPass_Click(sender As Object, e As EventArgs) Handles ButtonUbahPass.Click
        If TextBoxPassLama.Text = String.Empty Then
            MsgBox("Silahkan Masukkan Password Lama Anda !", vbExclamation)
            Return
        ElseIf TextBoxPassBaru.Text = String.Empty Then
            MsgBox("Silahkan Masukkan Password Baru Anda !", vbExclamation)
            Return
        ElseIf StrComp(TextBoxPassBaru.Text, TextBoxPassKon.Text, CompareMethod.Binary) Then
            MsgBox("Password Tidak Sesuai !", vbExclamation)
            Return
        Else
            Try
                conn.Open()
                cmd = New SqlCommand("UPDATE tabel_user SET password = @password WHERE password = @PasswordLama and username=@Username", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@password", TextBoxPassKon.Text)
                cmd.Parameters.AddWithValue("@passwordLama", TextBoxPassLama.Text)
                cmd.Parameters.AddWithValue("@Username", textuser.Text)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password Berhasil Diubah !", vbInformation)
                Else
                    MsgBox("Password Gagal Diubah !", vbExclamation)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
        TextBoxPassBaru.Clear()
        TextBoxPassLama.Clear()
        TextBoxPassKon.Clear()
    End Sub

End Class