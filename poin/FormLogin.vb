Imports System.Data.SqlClient
Imports MessagingToolkit.Barcode.OneD

Public Class FormLogin
    Dim nama As String
    Dim username As String
    Dim password As String
    Dim tugas As String

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        If MsgBox("Yakin Ingin Keluar ?", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
        Else
            Return
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Try
            conn.Open()
            Dim found As Boolean = False
            cmd = New SqlCommand("SELECT * FROM tabel_user WHERE username = @username AND password = @password", conn)
            cmd.Parameters.AddWithValue("@username", TextBoxUser.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxPass.Text)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                nama = dr.Item("nama").ToString
                username = dr.Item("username").ToString
                password = dr.Item("password").ToString
                tugas = dr.Item("tugas").ToString
            Else
                found = False
                nama = ""
                username = ""
                password = ""
                tugas = ""
            End If
            If found = True Then
                If StrComp(TextBoxUser.Text, username, CompareMethod.Binary) Or StrComp(TextBoxPass.Text, password, CompareMethod.Binary) Then
                    MsgBox("Warning: username atau password salah !", vbExclamation)
                    Return
                Else
                    If tugas = "Admin" Then
                        Me.Hide()
                        conn.Close()
                        FormAdmin.Show()
                    ElseIf tugas = "Kasir" Then
                        Me.Hide()
                        conn.Close()
                        FormKasir.Show()
                    End If
                End If
            Else
                MsgBox("Warning: username atau password salah !", vbExclamation)
            End If
            TextBoxUser.Clear()
            TextBoxPass.Clear()
        Catch ex As Exception

            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs)
        FormAdmin.Show()
    End Sub

    Private Sub TextBoxPass_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPass.TextChanged
        TextBoxPass.UseSystemPasswordChar = True
    End Sub

    Private Sub btnShowHidePassword_Click(sender As Object, e As EventArgs) Handles btnShowHidePassword.Click
        If TextBoxPass.UseSystemPasswordChar = True Then
            TextBoxPass.UseSystemPasswordChar = False
            btnShowHidePassword.Text = "Show"
        ElseIf TextBoxPass.UseSystemPasswordChar = False Then
            TextBoxPass.UseSystemPasswordChar = True
            btnShowHidePassword.Text = "Hide"
        End If
    End Sub

End Class
