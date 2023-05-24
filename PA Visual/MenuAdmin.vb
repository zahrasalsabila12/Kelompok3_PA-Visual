
Imports MySql.Data.MySqlClient

Public Class MenuAdmin
    Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call DisplaySkincare()
        Call DisplayMakeup()
        Call Clean()
        Call dgvSC()
        Call dgvMU()
    End Sub

    Sub dgvSC()
        dgvSkinCare.Columns(0).HeaderText = "ID"
        dgvSkinCare.Columns(1).HeaderText = "NAMA"
        dgvSkinCare.Columns(2).HeaderText = "MERK"
        dgvSkinCare.Columns(3).HeaderText = "JENIS"
        dgvSkinCare.Columns(4).HeaderText = "HARGA"
        dgvSkinCare.Columns(5).HeaderText = "STOK"
        dgvSkinCare.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub dgvMU()
        dgvMakeUp.Columns(0).HeaderText = "ID"
        dgvMakeUp.Columns(1).HeaderText = "NAMA"
        dgvMakeUp.Columns(2).HeaderText = "MERK"
        dgvMakeUp.Columns(3).HeaderText = "JENIS"
        dgvMakeUp.Columns(4).HeaderText = "HARGA"
        dgvMakeUp.Columns(5).HeaderText = "STOK"
        dgvMakeUp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Sub Clean()
        txtNama.Clear()
        txtNama.ReadOnly = False
        txtMerk.Clear()
        cbJenis.Text = ""
        txtHarga.Clear()
        txtStok.Clear()
        txtCariSC.Clear()
    End Sub
    'melihat data make up
    Sub DisplayMakeup()
        DA = New MySqlDataAdapter("Select * From tbmakeup ORDER By 'id' ASC", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "makeup")
        dgvMakeUp.DataSource = DS.Tables("makeup")
        dgvMakeUp.Refresh()
    End Sub
    'melihat data skin care
    Sub DisplaySkincare()
        DA = New MySqlDataAdapter("Select * From tbskincare ORDER By 'id' ASC", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "skincare")
        dgvSkinCare.DataSource = DS.Tables("skincare")
        dgvSkinCare.Refresh()
    End Sub
    'tambah data skincare
    Sub addSC()
        Try
            CMD = New MySqlCommand("Select * From tbskincare where nama='" & txtNama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("Insert into tbskincare (nama, merk, jenis, harga, stok) values (@nama, @merk, @jenis, @harga, @stok)", CONN)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text)
                CMD.Parameters.AddWithValue("@merk", txtMerk.Text)
                CMD.Parameters.AddWithValue("@jenis", cbJenis.Text)
                CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
                CMD.Parameters.AddWithValue("@stok", txtStok.Text)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
            Else
                MsgBox("Terjasi kesalahan. Nama Skincare Telah Digunakan!", MsgBoxStyle.Exclamation)
            End If
            RD.Close()
            CMD.Parameters.Clear()
            Call DisplaySkincare()
            Call Clean()
            txtNama.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'tambah data make up
    Sub addMU()
        Try
            CMD = New MySqlCommand("Select * From tbmakeup where nama='" & txtNama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If Not RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("Insert into tbmakeup (nama, merk, jenis, harga, stok) values (@nama, @merk, @jenis, @harga, @stok)", CONN)
                CMD.Parameters.AddWithValue("@nama", txtNama.Text)
                CMD.Parameters.AddWithValue("@merk", txtMerk.Text)
                CMD.Parameters.AddWithValue("@jenis", cbJenis.Text)
                CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
                CMD.Parameters.AddWithValue("@stok", txtStok.Text)
                CMD.ExecuteNonQuery()
                MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
            Else
                MsgBox("Terjasi kesalahan. Nama Make Up Telah Digunakan!", MsgBoxStyle.Exclamation)
            End If
            RD.Close()
            CMD.Parameters.Clear()
            Call DisplayMakeup()
            Call Clean()
            txtNama.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'ubah data skicare
    Sub updateSC()
        Try
            CMD = New MySqlCommand("Select * From tbskincare where nama='" & txtNama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("Update tbskincare set merk='" & txtMerk.Text & "', jenis='" & cbJenis.Text & "', harga='" & txtHarga.Text & "', stok='" & txtStok.Text & "' where nama='" & txtNama.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Terjadi kesalahan!", MsgBoxStyle.Exclamation)
            End If
            RD.Close()
            Call DisplaySkincare()
            Call Clean()
            txtMerk.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'ubah data make up
    Sub updateMU()
        Try
            CMD = New MySqlCommand("Select * From tbmakeup where nama='" & txtNama.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                CMD = New MySqlCommand("Update tbmakeup set merk='" & txtMerk.Text & "', jenis='" & cbJenis.Text & "', harga='" & txtHarga.Text & "', stok='" & txtStok.Text & "' where nama='" & txtNama.Text & "'", CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data berhasil diubah", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox("Terjadi kesalahan!", MsgBoxStyle.Exclamation)
            End If
            RD.Close()
            Call DisplayMakeup()
            Call Clean()
            txtMerk.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'button menambahkan data
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If (cbJenis.Text = "") Then
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
        ElseIf (Convert.ToInt32(txtHarga.Text) < 0) Then
            MsgBox("Data harga harus bernilai positif")
            txtHarga.Focus()
        ElseIf (txtStok.Text = "") Then
            MsgBox("Data belum lengkap")
            txtStok.Focus()
        ElseIf (Convert.ToInt32(txtStok.Text) <= 0) Then
            MsgBox("Data stok harus bernilai positif")
            txtStok.Focus()
        Else
            If (cbJenis.Text = "Skin Care") Then
                Call addSC()
                dgvSkinCare.Refresh()
            ElseIf (cbJenis.Text = "Make Up") Then
                Call addMU()
            End If
        End If
    End Sub
    'display klik konten dari datagridview skin care
    Private Sub dgvSkinCare_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSkinCare.CellContentClick, dgvSkinCare.CellClick
        txtNama.Text = dgvSkinCare.SelectedCells.Item(1).Value
        txtNama.ReadOnly = True
        txtMerk.Text = dgvSkinCare.SelectedCells.Item(2).Value
        cbJenis.Text = dgvSkinCare.SelectedCells.Item(3).Value
        txtHarga.Text = dgvSkinCare.SelectedCells.Item(4).Value.ToString
        txtStok.Text = dgvSkinCare.SelectedCells.Item(5).Value.ToString
    End Sub
    'display klik konten dari datagridview make up
    Private Sub dgvMakeUp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMakeUp.CellContentClick, dgvMakeUp.CellClick
        txtNama.Text = dgvMakeUp.SelectedCells.Item(1).Value.ToString
        txtNama.ReadOnly = True
        txtMerk.Text = dgvMakeUp.SelectedCells.Item(2).Value.ToString
        cbJenis.Text = dgvMakeUp.SelectedCells.Item(3).Value.ToString
        txtHarga.Text = dgvMakeUp.SelectedCells.Item(4).Value.ToString
        txtStok.Text = dgvMakeUp.SelectedCells.Item(5).Value.ToString
    End Sub
    'button mengubah data
    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        If (cbJenis.Text = "") Then
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
        ElseIf (Convert.ToInt32(txtHarga.Text) < 0) Then
            MsgBox("Data harga harus bernilai positif")
            txtHarga.Focus()
        ElseIf (txtStok.Text = "") Then
            MsgBox("Data belum lengkap")
            txtStok.Focus()
        ElseIf (Convert.ToInt32(txtStok.Text) < 0) Then
            MsgBox("Data stok harus bernilai positif")
            txtStok.Focus()
        Else
            If cbJenis.Text = "Skin Care" Then
                Call updateSC()
            ElseIf cbJenis.Text = "Make Up" Then
                Call updateMU()
            Else
                MsgBox("Terjadi kesalahan!", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    'button batal input
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        dgvMakeUp.Refresh()
        dgvSkinCare.Refresh()
        Call Clean()
    End Sub
    'button Hapus
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If (cbJenis.Text = "") Then
            MsgBox("Silahkan pilih data yang ingin Anda hapus sesuai dengan tabel data")
            cbJenis.Focus()
        ElseIf (txtNama.Text = "") Then
            MsgBox("Silahkan pilih data yang ingin Anda hapus sesuai dengan tabel data")
            txtNama.Focus()
        ElseIf (txtMerk.Text = "") Then
            MsgBox("Silahkan pilih data yang ingin Anda hapus sesuai dengan tabel data")
            txtMerk.Focus()
        ElseIf (cbJenis.Text = "") Then
            MsgBox("Silahkan pilih data yang ingin Anda hapus sesuai dengan tabel data")
            cbJenis.Focus()
        ElseIf (txtHarga.Text = "") Then
            MsgBox("Silahkan pilih data yang ingin Anda hapus sesuai dengan tabel data")
            txtHarga.Focus()
        ElseIf (txtStok.Text = "") Then
            MsgBox("Silahkan pilih data yang ingin Anda hapus sesuai dengan tabel data")
            txtStok.Focus()
        Else
            If cbJenis.Text = "Skin Care" Then
                If MessageBox.Show("Anda yakin ingin menghapus data skin care?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    CMD = New MySqlCommand("Delete From tbskincare where nama='" & txtNama.Text & "'", CONN)
                    CMD.ExecuteNonQuery()
                    Call Clean()
                    Call DisplaySkincare()
                Else
                    Call Clean()
                End If
            ElseIf cbJenis.Text = "Make Up" Then
                If MessageBox.Show("Anda yakin ingin menghapus data make up?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    CMD = New MySqlCommand("Delete From tbmakeup where nama='" & txtNama.Text & "'", CONN)
                    CMD.ExecuteNonQuery()
                    Call Clean()
                    Call DisplayMakeup()
                Else
                    Call Clean()
                End If
            End If
        End If
    End Sub
    'button keluar
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Hide()
        Form1.Show()
    End Sub
    'button cari skincare
    Private Sub btnCariSC_Click(sender As Object, e As EventArgs) Handles btnCariSC.Click
        CMD = New MySqlCommand("Select * From tbskincare where nama like '%" & txtCariSC.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("Select * From tbskincare where nama like '%" & txtCariSC.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "skincare")
            dgvSkinCare.DataSource = DS.Tables("skincare")
            dgvSkinCare.ReadOnly = True
            MsgBox("Data yang Anda cari berhasil ditemukan")
        Else
            RD.Close()
            MsgBox("Data yang Anda cari tidak ditemukan. Mohon cari berdasarkan nama skincare")
        End If
    End Sub
    'button cari makeup
    Private Sub btnCariMU_Click(sender As Object, e As EventArgs) Handles btnCariMU.Click
        CMD = New MySqlCommand("Select * From tbmakeup where nama like '%" & txtCariMU.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("Select * From tbmakeup where nama like '%" & txtCariMU.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "makeup")
            dgvMakeUp.DataSource = DS.Tables("makeup")
            dgvMakeUp.ReadOnly = True
            MsgBox("Data yang Anda cari berhasil ditemukan")
        Else
            RD.Close()
            MsgBox("Data yang Anda cari tidak ditemukan. Mohon cari berdasarkan nama make up")
        End If
    End Sub
End Class