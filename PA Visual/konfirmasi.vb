Imports MySql.Data.MySqlClient

Public Class konfirmasi

    Private Sub konfirmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        mainUser.Show()
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        If CONN.State = ConnectionState.Closed Then
            CONN.Open()
        End If
        Dim clearCommand As New MySqlCommand("TRUNCATE TABLE tbkeranjang", CONN)
        clearCommand.ExecuteNonQuery()
        For Each row As DataGridViewRow In dgvKeranjang.Rows
            Dim nama As String = row.Cells("NAMA").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(row.Cells("JUMLAH BARANG").Value)
            CMD = New MySqlCommand("Insert into tbkeranjang (nama, merk, jenis, harga_satuan, jumlah_barang, total) values (@nama, @merk, @jenis, @harga_satuan, @jumlah_barang, @total)", CONN)
            CMD.Parameters.AddWithValue("nama", row.Cells("NAMA").Value)
            CMD.Parameters.AddWithValue("merk", row.Cells("MERK").Value)
            CMD.Parameters.AddWithValue("jenis", row.Cells("JENIS").Value)
            CMD.Parameters.AddWithValue("harga_satuan", row.Cells("HARGA SATUAN").Value)
            CMD.Parameters.AddWithValue("jumlah_barang", row.Cells("JUMLAH BARANG").Value)
            CMD.Parameters.AddWithValue("total", row.Cells("TOTAL").Value)
            CMD.ExecuteNonQuery()
            Dim updateCommandMakeup As New MySqlCommand("UPDATE tbmakeup SET stok = stok - @jumlah_barang WHERE nama = @nama", CONN)
            Dim updateCommandSkincare As New MySqlCommand("UPDATE tbskincare SET stok = stok - @jumlah_barang WHERE nama = @nama", CONN)
            updateCommandMakeup.Parameters.AddWithValue("jumlah_barang", quantity)
            updateCommandMakeup.Parameters.AddWithValue("nama", nama)
            updateCommandSkincare.Parameters.AddWithValue("jumlah_barang", quantity)
            updateCommandSkincare.Parameters.AddWithValue("nama", nama)
            updateCommandMakeup.ExecuteNonQuery()
            updateCommandSkincare.ExecuteNonQuery()
        Next
        CONN.Close()
        mainUser.dgvDaftarMakeup.Refresh()
        mainUser.dgvDaftarSkincare.Refresh()
        MessageBox.Show("Pesanan telah berhasil")
        mainUser.dgvKeranjang.Rows.Clear()
        mainUser.txtTotalPesanan.Clear()
        Me.Visible = False
        struk.ShowDialog()
    End Sub

End Class