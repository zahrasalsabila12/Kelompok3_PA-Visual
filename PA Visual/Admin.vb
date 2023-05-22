Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Admin
    Dim arrImg() As Byte

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call DisplayMakeup()
        Call DisplaySkincare()
        Call Clean()
        dgvSkinCare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
        dgvMakeUp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
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
    'melihat data skin care
    Sub DisplaySkincare()
        DA = New MySqlDataAdapter("Select * From tbskincare ORDER BY 'id' ASC", CONN)
        Dim dt As New DataTable
        DA.Fill(dt)
        dgvSkinCare.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgvSkinCare.Rows.Add()
            dgvSkinCare.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
            dgvSkinCare.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
            dgvSkinCare.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
            dgvSkinCare.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
            dgvSkinCare.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
            dgvSkinCare.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString
        Next
        dgvSkinCare.Refresh()
    End Sub
    'melihat data make up
    Sub DisplayMakeup()
        DA = New MySqlDataAdapter("Select * From tbmakeup ORDER BY 'id' ASC", CONN)
        Dim data As New DataTable
        DA.Fill(data)
        dgvMakeUp.Rows.Clear()
        For i = 0 To data.Rows.Count - 1
            dgvMakeUp.Rows.Add()
            dgvMakeUp.Rows(i).Cells(0).Value = data.Rows(i).Item(0).ToString
            dgvMakeUp.Rows(i).Cells(1).Value = data.Rows(i).Item(1).ToString
            dgvMakeUp.Rows(i).Cells(2).Value = data.Rows(i).Item(2).ToString
            dgvMakeUp.Rows(i).Cells(3).Value = data.Rows(i).Item(3).ToString
            dgvMakeUp.Rows(i).Cells(4).Value = data.Rows(i).Item(4).ToString
            dgvMakeUp.Rows(i).Cells(5).Value = data.Rows(i).Item(5).ToString
        Next
        dgvMakeUp.Refresh()
    End Sub
    'tambah data skincare
    Sub addSC()
        Try
            CMD = New MySqlCommand("Select * From tbskincare where id='" & txtID.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("Insert into tbskincare (id, nama, merk, jenis, harga, stok) values (@id, @nama, @merk, @jenis, @harga, @stok)", CONN)
                CMD.Parameters.AddWithValue("@id", txtID.Text)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text)
                CMD.Parameters.AddWithValue("@merk", txtMerk.Text)
                CMD.Parameters.AddWithValue("@jenis", cbJenis.Text)
                CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
                CMD.Parameters.AddWithValue("@stok", txtStok.Text)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
            Else
                MsgBox("Terjasi kesalahan. ID Telah Digunakan!", MsgBoxStyle.Exclamation)
            End If
            RD.Close()
            CMD.Parameters.Clear()
            Call DisplaySkincare()
            Call Clean()
            txtID.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'tambah data make up
    Sub addMU()
        Try
            CMD = New MySqlCommand("Select * From tbmakeup where id='" & txtID.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("Insert into tbmakeup (id, nama, merk, jenis, harga, stok) values (@id, @nama, @merk, @jenis, @harga, @stok)", CONN)
                CMD.Parameters.AddWithValue("@id", txtID.Text)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text)
                CMD.Parameters.AddWithValue("@merk", txtMerk.Text)
                CMD.Parameters.AddWithValue("@jenis", cbJenis.Text)
                CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
                CMD.Parameters.AddWithValue("@stok", txtStok.Text)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
            Else
                MsgBox("Terjasi kesalahan. ID Telah Digunakan!", MsgBoxStyle.Exclamation)
            End If
            RD.Close()
            CMD.Parameters.Clear()
            Call DisplaySkincare()
            Call Clean()
            txtID.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'menambahkan data
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If (txtID.Text = "") Then
            MsgBox("Data belum lengkap")
            txtID.Focus()
        ElseIf (cbJenis.Text = "") Then
            MsgBox("Data belum lengkap")
            cbJenis.Focus()
        ElseIf (txtNama.Text = "") Then
            MsgBox("Data belum lengkap")
            txtNama.Focus()
        ElseIf (txtMerk.Text = "") Then
            MsgBox("Data belum lengkap")
            txtMerk.Focus()
        ElseIf (cbJenis.Text = "") Then
            MsgBox("Data belum lengkap")
            cbJenis.Focus()
        ElseIf (txtHarga.Text = "") Then
            MsgBox("Data belum lengkap")
            txtHarga.Focus()
        ElseIf (txtStok.Text = "") Then
            MsgBox("Data belum lengkap")
            txtStok.Focus()
        Else
            If (cbJenis.Text = "Skin Care") Then
                Call addSC()
            ElseIf (cbJenis.Text = "Make Up") Then
                Call addMU()
            End If
        End If
    End Sub
End Class