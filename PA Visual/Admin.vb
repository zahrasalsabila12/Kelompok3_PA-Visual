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
            dgvSkinCare.Rows.Add()
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
    'ubah data skicare
    Sub updateSC()
        CMD = New MySqlCommand("Update tbskincare set nama='" & txtNama.Text & "', merk='" & txtMerk.Text & "', jenis='" & cbJenis.Text & "', harga='" & txtHarga.Text & "', stok='" & txtStok.Text & "' where id='" & txtID.Text & "'", CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call DisplaySkincare()
        Call Clean()
        txtID.Focus()
    End Sub
    'ubah data make up
    Sub updateMU()
        CMD = New MySqlCommand("Update tbmakeup set nama='" & txtNama.Text & "', merk='" & txtMerk.Text & "', jenis='" & cbJenis.Text & "', harga='" & txtHarga.Text & "', stok='" & txtStok.Text & "' where id='" & txtID.Text & "'", CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Data berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call DisplaySkincare()
        Call Clean()
        txtID.Focus()
    End Sub
    'button menambahkan data
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
    'display klik konten dari datagridview skin care
    Private Sub dgvSkinCare_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSkinCare.CellContentClick, dgvSkinCare.CellClick
        txtID.Text = dgvSkinCare.SelectedCells.Item(0).Value.ToString
        txtID.ReadOnly = True
        txtNama.Text = dgvSkinCare.SelectedCells.Item(1).Value.ToString
        txtMerk.Text = dgvSkinCare.SelectedCells.Item(2).Value.ToString
        cbJenis.Text = dgvSkinCare.SelectedCells.Item(3).Value.ToString
        txtHarga.Text = dgvSkinCare.SelectedCells.Item(4).Value.ToString
        txtStok.Text = dgvSkinCare.SelectedCells.Item(5).Value.ToString
    End Sub
    'display klik konten dari datagridview make up
    Private Sub dgvMakeUp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakeUp.CellContentClick, dgvMakeUp.CellClick
        txtID.Text = dgvMakeUp.SelectedCells.Item(0).Value.ToString
        txtID.ReadOnly = True
        txtNama.Text = dgvMakeUp.SelectedCells.Item(1).Value.ToString
        txtMerk.Text = dgvMakeUp.SelectedCells.Item(2).Value.ToString
        cbJenis.Text = dgvMakeUp.SelectedCells.Item(3).Value.ToString
        txtHarga.Text = dgvMakeUp.SelectedCells.Item(4).Value.ToString
        txtStok.Text = dgvMakeUp.SelectedCells.Item(5).Value.ToString
    End Sub
    'button mengubah data
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If cbJenis.Text = "Skin Care" Then
            Call updateSC()
        ElseIf cbJenis.Text = "Make Up" Then
            Call updateMU()
        Else
            MsgBox("Terjasi kesalahan!", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class