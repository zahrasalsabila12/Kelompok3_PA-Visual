Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset

Public Class mainUser
    Private Sub UpdateTotalPembayaranKonfirmasi()
        If konfirmasi.dgvKeranjang IsNot Nothing Then
            Dim totalPembayaran As Double = 0
            Dim indeks As Integer
            While (indeks <= konfirmasi.dgvKeranjang.Rows.Count - 1)
                totalPembayaran = totalPembayaran + konfirmasi.dgvKeranjang.Rows(indeks).Cells(6).Value
                indeks = indeks + 1
            End While
            konfirmasi.lblharga.Text = totalPembayaran
        Else
            konfirmasi.lblharga.Text = 0
        End If
    End Sub
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Dim dt2 As New DataTable
        dt2.Columns.Add("NO")
        dt2.Columns.Add("NAMA")
        dt2.Columns.Add("MERK")
        dt2.Columns.Add("JENIS")
        dt2.Columns.Add("HARGA SATUAN")
        dt2.Columns.Add("JUMLAH BARANG")
        dt2.Columns.Add("TOTAL")
        For Each row As DataGridViewRow In dgvKeranjang.Rows
            dt2.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value)
        Next
        Me.Visible = False
        konfirmasi.Show()
        konfirmasi.dgvKeranjang.DataSource = dt2
        Penomoran(konfirmasi.dgvKeranjang)
        UpdateTotalPembayaranKonfirmasi()
        konfirmasi.dgvKeranjang.Columns(0).Width = 60
        konfirmasi.dgvKeranjang.Columns(1).Width = 200
        konfirmasi.dgvKeranjang.Columns(2).Width = 125
        konfirmasi.dgvKeranjang.Columns(3).Width = 185
        konfirmasi.dgvKeranjang.Columns(4).Width = 200
        konfirmasi.dgvKeranjang.Columns(5).Width = 150
        konfirmasi.dgvKeranjang.Columns(6).Width = 150
    End Sub

    Sub displayMakeup()
        DA = New MySqlDataAdapter("Select * From tbmakeup", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbmakeup")
        dgvDaftarMakeup.DataSource = DS.Tables("tbmakeup")
        dgvDaftarMakeup.Refresh()
    End Sub

    Sub displaySkincare()
        DA = New MySqlDataAdapter("Select * From tbskincare", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbskincare")
        dgvDaftarSkincare.DataSource = DS.Tables("tbskincare")
        dgvDaftarSkincare.Refresh()
    End Sub

    Private Sub Penomoran(ByRef data As DataGridView)
        If data IsNot Nothing Then
            Dim JmlhKolom As Integer = 0
            While (JmlhKolom <= (data.Rows.Count - 1))
                data.Rows(JmlhKolom).Cells(0).Value = String.Format((JmlhKolom + 1).ToString(), "0")
                JmlhKolom = JmlhKolom + 1
            End While
        End If
    End Sub

    Private Sub mainUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call displayMakeup()
        dgvDaftarMakeup.Columns(0).Width = 50
        dgvDaftarMakeup.Columns(1).Width = 120
        dgvDaftarMakeup.Columns(2).Width = 120
        dgvDaftarMakeup.Columns(3).Width = 100
        dgvDaftarMakeup.Columns(4).Width = 100
        dgvDaftarMakeup.Columns(5).Width = 80
        dgvDaftarMakeup.Columns(0).HeaderText = "ID"
        dgvDaftarMakeup.Columns(1).HeaderText = "NAMA"
        dgvDaftarMakeup.Columns(2).HeaderText = "MERK"
        dgvDaftarMakeup.Columns(3).HeaderText = "JENIS"
        dgvDaftarMakeup.Columns(4).HeaderText = "HARGA"
        dgvDaftarMakeup.Columns(5).HeaderText = "STOK"

        Call displaySkincare()
        dgvDaftarSkincare.Columns(0).Width = 50
        dgvDaftarSkincare.Columns(1).Width = 120
        dgvDaftarSkincare.Columns(2).Width = 120
        dgvDaftarSkincare.Columns(3).Width = 100
        dgvDaftarSkincare.Columns(4).Width = 100
        dgvDaftarSkincare.Columns(5).Width = 80
        dgvDaftarSkincare.Columns(0).HeaderText = "ID"
        dgvDaftarSkincare.Columns(1).HeaderText = "NAMA"
        dgvDaftarSkincare.Columns(2).HeaderText = "MERK"
        dgvDaftarSkincare.Columns(3).HeaderText = "JENIS"
        dgvDaftarSkincare.Columns(4).HeaderText = "HARGA"
        dgvDaftarSkincare.Columns(5).HeaderText = "STOK"

        dgvKeranjang.ColumnCount = 7
        dgvKeranjang.Columns(0).Width = 50
        dgvKeranjang.Columns(1).Width = 150
        dgvKeranjang.Columns(2).Width = 140
        dgvKeranjang.Columns(3).Width = 110
        dgvKeranjang.Columns(4).Width = 120
        dgvKeranjang.Columns(5).Width = 120
        dgvKeranjang.Columns(6).Width = 125
        dgvKeranjang.Columns(0).HeaderText = "NO"
        dgvKeranjang.Columns(1).HeaderText = "NAMA"
        dgvKeranjang.Columns(2).HeaderText = "MERK"
        dgvKeranjang.Columns(3).HeaderText = "JENIS"
        dgvKeranjang.Columns(4).HeaderText = "HARGA SATUAN"
        dgvKeranjang.Columns(5).HeaderText = "JUMLAH BARANG"
        dgvKeranjang.Columns(6).HeaderText = "TOTAL"
        Penomoran(dgvKeranjang)
    End Sub

    Private Sub UpdateTotalPembayaran()
        If dgvKeranjang IsNot Nothing Then
            Dim totalPembayaran As Double = 0
            Dim indeks As Integer
            While (indeks <= dgvKeranjang.Rows.Count - 1)
                totalPembayaran = totalPembayaran + dgvKeranjang.Rows(indeks).Cells(6).Value
                indeks = indeks + 1
            End While
            txtTotalPesanan.Text = totalPembayaran
        Else
            txtTotalPesanan.Text = 0
        End If
    End Sub

    Private Sub dgvKeranjang_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvKeranjang.CurrentCellDirtyStateChanged
        Try
            If dgvKeranjang.CurrentRow.Cells(5).Value = 0 Then
                dgvKeranjang.Rows.RemoveAt(dgvKeranjang.CurrentRow.Index)
                Penomoran(dgvKeranjang)
                UpdateTotalPembayaran()
            End If
            Dim Total As Integer = Val(dgvKeranjang.CurrentRow.Cells(5).Value) * Val(dgvKeranjang.CurrentRow.Cells(4).Value)
            dgvKeranjang.CurrentRow.Cells(6).Value = Total

            'query cek stok dari nama yg ada di cell 1
            'q = SELECT stok FROM `tbmakeup` where nama = "&dgvKeranjang.CurrentRow.Cells(5).Value&";
            'cek jika dgvKeranjang.CurrentRow.Cells(5).Value > q
            'pop up error kalau lebih b
            UpdateTotalPembayaran()
        Catch ex As Exception
            MessageBox.Show("Masukkan Angka!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dgvKeranjang.CurrentRow.Cells(5).Value = 1
            Dim Total As Integer = Val(dgvKeranjang.CurrentRow.Cells(5).Value) * Val(dgvKeranjang.CurrentRow.Cells(4).Value)
            dgvKeranjang.CurrentRow.Cells(6).Value = Total
        End Try
    End Sub

    Private Sub btnTambahSkincare_Click(sender As Object, e As EventArgs) Handles btnTambahSkincare.Click
        Dim jumlahRowsTerpilih As Integer = dgvDaftarSkincare.SelectedRows.Count
        If jumlahRowsTerpilih > 0 Then
            Dim i As Integer
            For i = 0 To jumlahRowsTerpilih - 1
                Dim indeks As Integer = dgvDaftarSkincare.SelectedCells(i).RowIndex
                Dim namaSkincare As String = dgvDaftarSkincare.Rows(indeks).Cells(1).Value
                Dim merkSkincare As String = dgvDaftarSkincare.Rows(indeks).Cells(2).Value
                Dim jenisSkincare As String = dgvDaftarSkincare.Rows(indeks).Cells(3).Value
                Dim hargaSatuan As String = dgvDaftarSkincare.Rows(indeks).Cells(4).Value
                dgvKeranjang.Rows.Add("", namaSkincare, merkSkincare, jenisSkincare, hargaSatuan, "1", hargaSatuan)
            Next
        Else
            MessageBox.Show("Silahkan Pilih Menu Yang Tersedia!!!", "Warning")
        End If
        Penomoran(dgvKeranjang)
        UpdateTotalPembayaran()
    End Sub

    Private Sub btnTambahMakeup_Click(sender As Object, e As EventArgs) Handles btnTambahMakeup.Click
        Dim jumlahRowsTerpilih As Integer = dgvDaftarMakeup.SelectedRows.Count
        If jumlahRowsTerpilih > 0 Then
            Dim i As Integer
            For i = 0 To jumlahRowsTerpilih - 1
                Dim indeks As Integer = dgvDaftarMakeup.SelectedCells(i).RowIndex
                Dim namaMakeup As String = dgvDaftarMakeup.Rows(indeks).Cells(1).Value
                Dim merkMakeup As String = dgvDaftarMakeup.Rows(indeks).Cells(2).Value
                Dim jenisMakeup As String = dgvDaftarMakeup.Rows(indeks).Cells(3).Value
                Dim hargaSatuan As String = dgvDaftarMakeup.Rows(indeks).Cells(4).Value
                dgvKeranjang.Rows.Add("", namaMakeup, merkMakeup, jenisMakeup, hargaSatuan, "1", hargaSatuan)

            Next
        Else
            MessageBox.Show("Silahkan Pilih Menu Yang Tersedia!!!", "Warning")
        End If
        Penomoran(dgvKeranjang)
        UpdateTotalPembayaran()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Form1.Show()
    End Sub

End Class