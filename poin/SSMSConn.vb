Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module SSMSConn
    Public conn As New SqlConnection
    Dim result As Boolean
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public dt As New DataTable
    Public dr As SqlDataReader
    Public i As Integer

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = ("Data Source=DESKTOP-PQPDQFQ\SULASTRI; " &
                "user id = sa; password=123456; Integrated Security=True; " & "database=pos")
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("server tidak terkoneksi !", vbExclamation)
        End Try
        Return result
    End Function

    Public Function Getnotagihan() As String
        Dim result As String = ""
        Try
            conn.Open()
            cmd = New SqlCommand("SELECT * FROM tabel_pos WHERE notagihan IS NOT NULL ORDER BY id DESC", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                result = (CLng(dr.Item("notagihan").ToString) + 1).ToString()
            Else
                result = Date.Now.ToString("yyyy") & "1"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return result
    End Function

End Module
