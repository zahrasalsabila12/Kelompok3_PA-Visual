Public Class konfirmasi
    Private Sub Penomoran(ByRef data As DataGridView)
        If data IsNot Nothing Then
            Dim JmlhKolom As Integer = 0
            While (JmlhKolom <= (data.Rows.Count - 1))
                data.Rows(JmlhKolom).Cells(0).Value = String.Format((JmlhKolom + 1).ToString(), "0")
                JmlhKolom = JmlhKolom + 1
            End While
        End If
    End Sub
    Private Sub konfirmasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        If dgvKeranjang.RowCount > 0 Then
            dgvKeranjang.Columns(0).HeaderText = "NO"
            dgvKeranjang.Columns(1).HeaderText = "NAMA"
            dgvKeranjang.Columns(2).HeaderText = "MERK"
            dgvKeranjang.Columns(3).HeaderText = "JENIS"
            dgvKeranjang.Columns(4).HeaderText = "HARGA SATUAN"
            dgvKeranjang.Columns(5).HeaderText = "JUMLAH BARANG"
            dgvKeranjang.Columns(6).HeaderText = "TOTAL"
            dgvKeranjang.Columns(7).HeaderText = "GAMBAR"
            dgvKeranjang.Columns(7).Visible = False
        End If
        Penomoran(dgvKeranjang)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        mainUser.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        struk.ShowDialog()
    End Sub
End Class