Imports MySql.Data.MySqlClient

Public Class mainUser
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        konfirmasi.ShowDialog()
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
        dgvDaftarMakeup.DataSource = DS.Tables("tbskincare")
        dgvDaftarMakeup.Refresh()
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
        dgvDaftarMakeup.Columns(0).HeaderText = "ID"
        dgvDaftarMakeup.Columns(1).HeaderText = "NAMA"
        dgvDaftarMakeup.Columns(2).HeaderText = "MERK"
        dgvDaftarMakeup.Columns(3).HeaderText = "JENIS"
        dgvDaftarMakeup.Columns(4).HeaderText = "HARGA"
        dgvDaftarMakeup.Columns(5).HeaderText = "STOK"
        dgvDaftarMakeup.Columns(6).HeaderText = "FOTO"
        dgvDaftarMakeup.Columns(6).Visible = False

        Call displaySkincare()
        dgvDaftarSkincare.Columns(0).HeaderText = "ID"
        dgvDaftarSkincare.Columns(1).HeaderText = "NAMA"
        dgvDaftarSkincare.Columns(2).HeaderText = "MERK"
        dgvDaftarSkincare.Columns(3).HeaderText = "JENIS"
        dgvDaftarSkincare.Columns(4).HeaderText = "HARGA"
        dgvDaftarSkincare.Columns(5).HeaderText = "STOK"
        dgvDaftarSkincare.Columns(6).HeaderText = "GAMBAR"
        dgvDaftarSkincare.Columns(6).Visible = False

        dgvKeranjang.Columns(0).HeaderText = "NO"
        dgvKeranjang.Columns(1).HeaderText = "NAMA"
        dgvKeranjang.Columns(2).HeaderText = "MERK"
        dgvKeranjang.Columns(3).HeaderText = "JENIS"
        dgvKeranjang.Columns(4).HeaderText = "HARGA SATUAN"
        dgvKeranjang.Columns(5).HeaderText = "JUMLAH BARANG"
        dgvKeranjang.Columns(6).HeaderText = "TOTAL"
        dgvKeranjang.Columns(7).HeaderText = "GAMBAR"
        dgvKeranjang.Columns(7).Visible = False
        Penomoran(dgvKeranjang)
    End Sub

    Private Sub UpdateTotalPembayaran()
        If dgvKeranjang IsNot Nothing Then
            Dim totalPembayaran As Double = 0
            Dim indeks As Integer
            While (indeks <= dgvKeranjang.Rows.Count - 1)
                totalPembayaran = totalPembayaran + dgvKeranjang.Rows(indeks).Cells(4).Value
                indeks = indeks + 1
            End While
            txtTotalPesanan.Text = totalPembayaran
        Else
            txtTotalPesanan.Text = 0
        End If
    End Sub

    Private Sub btnTambahSkincare_Click(sender As Object, e As EventArgs) Handles btnTambahSkincare.Click
        Dim jumlahCellsTerpilih As Integer = dgvDaftarSkincare.GetCellCount(DataGridViewElementStates.Selected)
        If jumlahCellsTerpilih > 0 Then
            Dim i As Integer
            For i = 0 To jumlahCellsTerpilih - 1
                Dim indeks As Integer = dgvDaftarSkincare.SelectedCells(i).RowIndex
                Dim namaSkincare As String = dgvDaftarSkincare.Rows(indeks).Cells(1).Value
                Dim hargaSatuan As String = dgvDaftarSkincare.Rows(indeks).Cells(2).Value
                If dgvKeranjang IsNot Nothing Then
                    Dim j As Integer = 0
                    Dim sama As Boolean = False
                    While (j <= (dgvKeranjang.Rows.Count - 1))
                        If dgvKeranjang.Rows(j).Cells(1).Value.Equals(namaSkincare) Then
                            sama = True
                            MessageBox.Show("Kosmetik Sudah Dipesan, Silahkan Ganti Jumlah Kosmetik Pada Baris Jumlah!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit While
                        End If
                        j = j + 1
                    End While
                    If sama = False Then
                        dgvKeranjang.Rows.Add("", namaSkincare, "1", hargaSatuan, hargaSatuan)
                    End If
                End If
            Next
        Else
            MessageBox.Show("Silahkan Pilih Menu Yang Tersedia!!!", "Warning")
        End If
        Penomoran(dgvKeranjang)
        UpdateTotalPembayaran()
    End Sub

    Private Sub btnTambahMakeup_Click(sender As Object, e As EventArgs) Handles btnTambahMakeup.Click
        Dim jumlahCellsTerpilih As Integer = dgvDaftarMakeup.GetCellCount(DataGridViewElementStates.Selected)
        If jumlahCellsTerpilih > 0 Then
            Dim i As Integer
            For i = 0 To jumlahCellsTerpilih - 1
                Dim indeks As Integer = dgvDaftarMakeup.SelectedCells(i).RowIndex
                Dim namaMakeup As String = dgvDaftarMakeup.Rows(indeks).Cells(1).Value
                Dim hargaSatuan As String = dgvDaftarMakeup.Rows(indeks).Cells(2).Value
                If dgvKeranjang IsNot Nothing Then
                    Dim j As Integer = 0
                    Dim sama As Boolean = False
                    While (j <= (dgvKeranjang.Rows.Count - 1))
                        If dgvKeranjang.Rows(j).Cells(1).Value.Equals(namaMakeup) Then
                            sama = True
                            MessageBox.Show("Kosmetik Sudah Dipesan, Silahkan Ganti Jumlah Kosmetik Pada Baris Jumlah!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Exit While
                        End If
                        j = j + 1
                    End While
                    If sama = False Then
                        dgvKeranjang.Rows.Add("", namaMakeup, "1", hargaSatuan, hargaSatuan)
                    End If
                End If
            Next
        Else
            MessageBox.Show("Silahkan Pilih Menu Yang Tersedia!!!", "Warning")
        End If
        Penomoran(dgvKeranjang)
        UpdateTotalPembayaran()
    End Sub
End Class