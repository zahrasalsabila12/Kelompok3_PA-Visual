Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Admin
    Dim arrImg() As Byte

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call DisplaySkincare()
        Call DisplayMakeup()
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
        pbAdmin.Image = Nothing
        txtCari.Clear()
    End Sub
    'melihat data skin care
    Sub DisplaySkincare()
        DA = New MySqlDataAdapter("Select id,nama,merk,jenis,harga,stok,gambar From tbskincare ORDER BY 'id' ASC", CONN)
        Dim dt As New DataTable
        DA.Fill(dt)
        dgvSkinCare.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgvSkinCare.Rows.Add()
            Dim pic As Image = Image.FromStream(getImageSkincare(dt.Rows(i).Item(0).ToString))
            dgvSkinCare.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
            dgvSkinCare.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
            dgvSkinCare.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
            dgvSkinCare.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
            dgvSkinCare.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
            dgvSkinCare.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString
            dgvSkinCare.Rows(i).Cells(6).Value = pic
        Next
        dgvSkinCare.Refresh()
    End Sub
    'melihat data make up
    Sub DisplayMakeup()
        DA = New MySqlDataAdapter("Select id,nama,merk,jenis,harga,stok,gambar From tbmakeup ORDER BY 'id' ASC", CONN)
        Dim dt As New DataTable
        DA.Fill(dt)
        dgvMakeUp.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgvSkinCare.Rows.Add()
            Dim pic As Image = Image.FromStream(getImageMakeup(dt.Rows(i).Item(0).ToString))
            dgvMakeUp.Rows(i).Cells(0).Value = dt.Rows(i).Item(0).ToString
            dgvMakeUp.Rows(i).Cells(1).Value = dt.Rows(i).Item(1).ToString
            dgvMakeUp.Rows(i).Cells(2).Value = dt.Rows(i).Item(2).ToString
            dgvMakeUp.Rows(i).Cells(3).Value = dt.Rows(i).Item(3).ToString
            dgvMakeUp.Rows(i).Cells(4).Value = dt.Rows(i).Item(4).ToString
            dgvMakeUp.Rows(i).Cells(5).Value = dt.Rows(i).Item(5).ToString
            dgvMakeUp.Rows(i).Cells(6).Value = pic
        Next
        dgvMakeUp.Refresh()
    End Sub

    Private Function getImageSkincare(ByVal id As String) As System.IO.MemoryStream
        CMD = New MySqlCommand("Select gambar From tbskincare where id = @id", CONN)
        CMD.Parameters.AddWithValue("@id", id)
        RD = CMD.ExecuteReader
        RD.Read()
        Dim dtImage() As Byte = RD.Item("gambar")
        MS = New System.IO.MemoryStream(dtImage)
        CMD.Dispose()
        RD.Close()

        Return MS
    End Function

    Private Function getImageMakeup(ByVal id As String) As System.IO.MemoryStream
        CMD = New MySqlCommand("Select gambar From tbmakeup where id = @id", CONN)
        CMD.Parameters.AddWithValue("@id", id)
        RD = CMD.ExecuteReader
        RD.Read()
        Dim dtImage() As Byte = RD.Item("gambar")
        MS = New System.IO.MemoryStream(dtImage)
        CMD.Dispose()
        RD.Close()

        Return MS
    End Function

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
        ElseIf pbAdmin.Image Is Nothing Then
            MsgBox("Data belum lengkap")
            btnBrowse.Focus()
        Else
            If (cbJenis.Text = "Skin Care") Then
                CMD = New MySqlCommand("Select * From tbskincare where id='" & txtID.Text & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                If Not RD.HasRows Then
                    Try
                        RD.Close()
                        MS = New System.IO.MemoryStream()
                        pbAdmin.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                        arrImg = MS.GetBuffer
                        Dim fileSize As UInt32
                        fileSize = MS.Length
                        MS.Close()

                        Dim simpan As String = "insert into tbskincare(id, nama, merk, jenis, harga, stok, gambar) values (@id, @nama, @merk, @jenis, @harga, @stok, @image)"
                        CMD = New MySqlCommand(simpan, CONN)
                        CMD.Parameters.AddWithValue("@id", txtID.Text)
                        CMD.Parameters.AddWithValue("@nama", txtNama.Text)
                        CMD.Parameters.AddWithValue("@merk", txtMerk.Text)
                        CMD.Parameters.AddWithValue("@jenis", cbJenis.Text)
                        CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
                        CMD.Parameters.AddWithValue("@stok", txtStok.Text)
                        CMD.Parameters.AddWithValue("@gambar", arrImg)
                        CMD.ExecuteNonQuery()
                        MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                Else
                    MsgBox("Terjasi kesalahan", MsgBoxStyle.Exclamation)
                End If
            ElseIf (cbJenis.Text = "Make Up") Then
                CMD = New MySqlCommand("Select * From tbmakeup where id='" & txtID.Text & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                If Not RD.HasRows Then
                    RD.Close()
                    Dim simpan As String = "insert into tbmakeup(id, nama, merk, jenis, harga, stok, gambar) values (@id, @nama, @merk, @jenis, @harga, @stok, @gambar)"
                    CMD = New MySqlCommand(simpan, CONN)
                    CMD.Parameters.AddWithValue("id", txtID.Text)
                    CMD.Parameters.AddWithValue("nama", txtNama.Text)
                    CMD.Parameters.AddWithValue("merk", txtMerk.Text)
                    CMD.Parameters.AddWithValue("jenis", cbJenis.Text)
                    CMD.Parameters.AddWithValue("harga", txtHarga.Text)
                    CMD.Parameters.AddWithValue("stok", txtStok.Text)

                    MS = New MemoryStream
                    Dim gambar As New Bitmap(pbAdmin.Image)
                    gambar.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim dt As Byte() = MS.GetBuffer
                    Dim img As New MySqlParameter("gambar", MySqlDbType.Blob)
                    img.Value = dt
                    CMD.Parameters.Add(img)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data berhasil disimpan!", MsgBoxStyle.Information, "Info")
                Else
                    MsgBox("Terjasi kesalahan", MsgBoxStyle.Exclamation)
                End If
            End If
            RD.Close()
            Call DisplaySkincare()
            Call DisplayMakeup()
            Call Clean()
            txtID.Focus()
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg;*.png;*.jfif)|*.jpg;*.png;*.jfif"

        If opf.ShowDialog = DialogResult.OK Then
            pbAdmin.Image = Image.FromFile(opf.FileName)
        End If
    End Sub
End Class