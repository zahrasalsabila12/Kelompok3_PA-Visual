Imports System.Drawing.Imaging
Imports MySql.Data.MySqlClient

Public Class struk
    Sub displayStruk()
        DA = New MySqlDataAdapter("Select nama,merk,jenis,harga_satuan,jumlah_barang,total From tbkeranjang", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbkeranjang")
        dgvStruk.DataSource = DS.Tables("tbkeranjang")
        dgvStruk.Refresh()
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        mainUser.Show()
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        Dim screenBounds As Rectangle = Screen.PrimaryScreen.Bounds
        Dim numScreenshots As Integer = 1
        For i As Integer = 1 To numScreenshots
            Dim screenshot As New Bitmap(screenBounds.Width, screenBounds.Height, PixelFormat.Format32bppArgb)
            Using g As Graphics = Graphics.FromImage(screenshot)
                g.CopyFromScreen(screenBounds.Location, Point.Empty, screenBounds.Size)
            End Using
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PNG Files (*.png)|*.png"
            saveFileDialog.FileName = "Struk_" & i.ToString()

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                screenshot.Save(saveFileDialog.FileName, ImageFormat.Png)
            End If

            screenshot.Dispose()
        Next i
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
    Private Sub UpdateTotalPembayaran()
        If dgvStruk IsNot Nothing Then
            Dim totalPembayaran As Double = 0
            Dim indeks As Integer
            While (indeks <= dgvStruk.Rows.Count - 1)
                totalPembayaran = totalPembayaran + dgvStruk.Rows(indeks).Cells(6).Value
                indeks = indeks + 1
            End While
            lblharga.Text = totalPembayaran
        Else
            lblharga.Text = 0
        End If
    End Sub
    Private Sub struk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Connect()
        Call displayStruk()
        If dgvStruk.ColumnCount >= 7 Then
            dgvStruk.Columns(0).Width = 50
            dgvStruk.Columns(1).Width = 150
            dgvStruk.Columns(2).Width = 150
            dgvStruk.Columns(3).Width = 130
            dgvStruk.Columns(4).Width = 200
            dgvStruk.Columns(5).Width = 200
            dgvStruk.Columns(6).Width = 188
            dgvStruk.Columns(0).HeaderText = "NO"
            dgvStruk.Columns(1).HeaderText = "NAMA"
            dgvStruk.Columns(2).HeaderText = "MERK"
            dgvStruk.Columns(3).HeaderText = "JENIS"
            dgvStruk.Columns(4).HeaderText = "HARGA SATUAN"
            dgvStruk.Columns(5).HeaderText = "JUMLAH BARANG"
            dgvStruk.Columns(6).HeaderText = "TOTAL"
        Else
            MessageBox.Show("Kolom tidak cukup di DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Penomoran(dgvStruk)
        UpdateTotalPembayaran()


    End Sub
End Class