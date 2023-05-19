Imports MySql.Data.MySqlClient

Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call Clean()
        dgvAdmin.Columns(0).HeaderText = "ID"
        dgvAdmin.Columns(1).HeaderText = "Nama"
        dgvAdmin.Columns(2).HeaderText = "Merk"
        dgvAdmin.Columns(3).HeaderText = "Jenis"
        dgvAdmin.Columns(4).HeaderText = "Harga"
        dgvAdmin.Columns(5).HeaderText = "Stok"
        dgvAdmin.Columns(6).HeaderText = "Cari"
    End Sub
    Sub Clean()
        txtID.Clear()
        txtNama.Clear()
        txtMerk.Clear()
        cbJenis.Text = ""
        txtHarga.Clear()
        txtStok.Clear()
        txtCari.Clear()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

    End Sub
End Class