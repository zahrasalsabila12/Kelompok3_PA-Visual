Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class Register
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Call Connect()
        Dim username As String = txtNewUser.Text.Trim()
        Dim password As String = txtNewPass.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Mohon isi semua field.")
        Else
            Dim query As String = "INSERT INTO tbakun (usename, password) VALUES ('" & txtNewUser.Text & "','" & txtNewPass.Text & "')"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue(txtNewUser.Text, username)
            CMD.Parameters.AddWithValue(txtNewPass.Text, password)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Registrasi berhasil.")
                Me.Visible = False
                Form1.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Registrasi gagal: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Visible = False
        Form1.ShowDialog()
    End Sub


End Class