Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call DisplaySkincare()
        Call Clean()

        dgvSkinCare.ColumnCount = 7
        dgvSkinCare.Columns(0).HeaderText = "ID"
        dgvSkinCare.Columns(1).HeaderText = "NAMA"
        dgvSkinCare.Columns(2).HeaderText = "MERK"
        dgvSkinCare.Columns(3).HeaderText = "JENIS"
        dgvSkinCare.Columns(4).HeaderText = "HARGA"
        dgvSkinCare.Columns(5).HeaderText = "STOK"
        Dim colGambar As New DataGridViewImageColumn
        colGambar.HeaderText = "GAMBAR"
        colGambar.ImageLayout = DataGridViewImageCellLayout.Stretch
        dgvSkinCare.Columns.Insert(6, colGambar)

        dgvMakeUp.Columns(0).HeaderText = "ID"
        dgvMakeUp.Columns(1).HeaderText = "NAMA"
        dgvMakeUp.Columns(2).HeaderText = "MERK"
        dgvMakeUp.Columns(3).HeaderText = "JENIS"
        dgvMakeUp.Columns(4).HeaderText = "HARGA"
        dgvMakeUp.Columns(5).HeaderText = "STOK"
        dgvMakeUp.Columns(6).HeaderText = "GAMBAR"

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
        DA = New MySqlDataAdapter("Select * From tbskincare ORDER BY 'id' ASC", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "skincare")
        dgvMakeUp.DataSource = DS.Tables("skincare")
        dgvSkinCare.RowTemplate.Height = 50
        dgvMakeUp.Refresh()
    End Sub
    'melihat data make up
    Sub DisplayMakeup()
        DA = New MySqlDataAdapter("Select * From tbmakeup ORDER BY 'id' ASC", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "makeup")
        dgvMakeUp.DataSource = DS.Tables("makeup")
        dgvMakeUp.RowTemplate.Height = 50
        dgvMakeUp.Refresh()
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
        ElseIf pbAdmin.Image Is Nothing Then
            MsgBox("Data belum lengkap")
            btnBrowse.Focus()
        Else
            If (cbJenis.Text = "Skin Care") Then
                CMD = New MySqlCommand("Select * From tbskincare where id='" & txtID.Text & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                If Not RD.HasRows Then
                    RD.Close()
                    Dim dataGambar As Byte() = Nothing
                    Dim simpan As String = "insert into tbskincare(id, nama, merk, jenis, harga, stok, gambar) values (@id, @nama, @merk, @jenis, @harga, @stok, @image)"
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