Imports MySql.Data.MySqlClient

Public Class Form1
    Sub clean()
        txtUser.Clear()
        txtPass.Clear()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUser.Text.Trim()
        Dim password As String = txtPass.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Mohon isi semua field.")

        ElseIf txtUser.Text = "admin" And txtPass.Text = "admin123" Then
            Me.Visible = False
            Call clean()
            MenuAdmin.Show()
        Else
            CMD = New MySqlCommand("Select * From tbakun where username= @username and password= @password", CONN)
            CMD.Parameters.AddWithValue("username", username)
            CMD.Parameters.AddWithValue("password", password)
            RD = CMD.ExecuteReader
            If RD.Read Then
                MessageBox.Show("Login berhasil.")
                Me.Visible = False
                Call clean()
                homeUser.ShowDialog()
            Else
                MessageBox.Show("Username atau password salah.")
            End If
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Visible = False
        Dim Register As New Register()
        Register.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call clean()
        Call Connect()
    End Sub
End Class
