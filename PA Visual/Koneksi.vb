Imports System.IO
Imports MySql.Data.MySqlClient
Module Koneksi
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public MS As MemoryStream
    Public STR As String

    Sub Connect()
        Try
            Dim STR As String = "server=localhost;userid=root;password=;database=dbblossom"
            CONN = New MySqlConnection(STR)
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
