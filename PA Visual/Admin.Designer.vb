<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblMerk = New System.Windows.Forms.Label()
        Me.txtMerk = New System.Windows.Forms.TextBox()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
<<<<<<< HEAD
        Me.dgvMakeUp = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
=======
>>>>>>> 15052e1a9ea5e590e68670e8869307d7032c169b
        Me.dgvSkinCare = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
<<<<<<< HEAD
        CType(Me.dgvMakeUp, System.ComponentModel.ISupportInitialize).BeginInit()
=======
        Me.dgvMakeUp = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
<<<<<<< HEAD
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
=======
>>>>>>> 15052e1a9ea5e590e68670e8869307d7032c169b
>>>>>>> 44b9c2d4a531120d6dc4789e56af2634ef7c314c
        CType(Me.dgvSkinCare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMakeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(43, 171)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 19)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.AcceptsReturn = True
        Me.txtID.AcceptsTab = True
        Me.txtID.AllowDrop = True
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(47, 194)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(364, 27)
        Me.txtID.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(43, 226)
        Me.lblNama.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(60, 19)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.AllowDrop = True
        Me.txtNama.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(47, 250)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(364, 27)
        Me.txtNama.TabIndex = 3
        '
        'lblMerk
        '
        Me.lblMerk.AutoSize = True
        Me.lblMerk.BackColor = System.Drawing.Color.Transparent
        Me.lblMerk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerk.Location = New System.Drawing.Point(43, 282)
        Me.lblMerk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMerk.Name = "lblMerk"
        Me.lblMerk.Size = New System.Drawing.Size(50, 19)
        Me.lblMerk.TabIndex = 4
        Me.lblMerk.Text = "Merk"
        '
        'txtMerk
        '
        Me.txtMerk.AllowDrop = True
        Me.txtMerk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMerk.Location = New System.Drawing.Point(47, 305)
        Me.txtMerk.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(364, 27)
        Me.txtMerk.TabIndex = 5
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.BackColor = System.Drawing.Color.Transparent
        Me.lblJenis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(43, 337)
        Me.lblJenis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(50, 19)
        Me.lblJenis.TabIndex = 6
        Me.lblJenis.Text = "Jenis"
        '
        'cbJenis
        '
        Me.cbJenis.AllowDrop = True
        Me.cbJenis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"Skin Care", "Make Up"})
        Me.cbJenis.Location = New System.Drawing.Point(47, 361)
        Me.cbJenis.Margin = New System.Windows.Forms.Padding(4)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(364, 29)
        Me.cbJenis.TabIndex = 7
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.BackColor = System.Drawing.Color.Transparent
        Me.lblHarga.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(44, 395)
        Me.lblHarga.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(59, 19)
        Me.lblHarga.TabIndex = 8
        Me.lblHarga.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.AllowDrop = True
        Me.txtHarga.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(47, 418)
        Me.txtHarga.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(364, 27)
        Me.txtHarga.TabIndex = 9
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.BackColor = System.Drawing.Color.Transparent
        Me.lblStok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStok.Location = New System.Drawing.Point(44, 450)
        Me.lblStok.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(43, 19)
        Me.lblStok.TabIndex = 10
        Me.lblStok.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.AllowDrop = True
        Me.txtStok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(47, 474)
        Me.txtStok.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(364, 27)
        Me.txtStok.TabIndex = 11
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.LimeGreen
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.btnTambah.Location = New System.Drawing.Point(21, 430)
=======
        Me.btnTambah.Location = New System.Drawing.Point(45, 526)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> 44b9c2d4a531120d6dc4789e56af2634ef7c314c
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(100, 28)
        Me.btnTambah.TabIndex = 15
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUbah.FlatAppearance.BorderSize = 0
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.btnUbah.Location = New System.Drawing.Point(102, 430)
=======
        Me.btnUbah.Location = New System.Drawing.Point(181, 526)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> 44b9c2d4a531120d6dc4789e56af2634ef7c314c
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(100, 28)
        Me.btnUbah.TabIndex = 16
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.btnHapus.Location = New System.Drawing.Point(264, 430)
=======
        Me.btnHapus.Location = New System.Drawing.Point(311, 526)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4)
>>>>>>> 44b9c2d4a531120d6dc4789e56af2634ef7c314c
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(100, 28)
        Me.btnHapus.TabIndex = 17
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.Color.Peru
        Me.btnCari.FlatAppearance.BorderSize = 0
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCari.Location = New System.Drawing.Point(816, 28)
        Me.btnCari.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(100, 28)
        Me.btnCari.TabIndex = 18
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(501, 28)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(305, 27)
        Me.txtCari.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
<<<<<<< HEAD
        'dgvMakeUp
        '
        Me.dgvMakeUp.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvMakeUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMakeUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakeUp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.dgvMakeUp.Location = New System.Drawing.Point(501, 341)
        Me.dgvMakeUp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMakeUp.Name = "dgvMakeUp"
        Me.dgvMakeUp.ReadOnly = True
        Me.dgvMakeUp.RowHeadersWidth = 51
        Me.dgvMakeUp.Size = New System.Drawing.Size(717, 327)
        Me.dgvMakeUp.TabIndex = 21
        '
        'Column8
        '
        Me.Column8.HeaderText = "ID"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 125
        '
        'Column9
        '
        Me.Column9.HeaderText = "NAMA"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 125
        '
        'Column10
        '
        Me.Column10.HeaderText = "MERK"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 125
        '
        'Column11
        '
        Me.Column11.HeaderText = "JENIS"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "HARGA"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 125
        '
        'Column13
        '
        Me.Column13.HeaderText = "STOK"
        Me.Column13.MinimumWidth = 6
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 125
        '
=======
>>>>>>> 15052e1a9ea5e590e68670e8869307d7032c169b
        'dgvSkinCare
        '
        Me.dgvSkinCare.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvSkinCare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSkinCare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSkinCare.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvSkinCare.Location = New System.Drawing.Point(501, 64)
        Me.dgvSkinCare.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSkinCare.Name = "dgvSkinCare"
        Me.dgvSkinCare.ReadOnly = True
        Me.dgvSkinCare.RowHeadersWidth = 51
        Me.dgvSkinCare.Size = New System.Drawing.Size(717, 270)
        Me.dgvSkinCare.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAMA"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "MERK"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "JENIS"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "HARGA"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "STOK"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
<<<<<<< HEAD
        Me.Column6.Width = 125
=======
        '
        'dgvMakeUp
        '
        Me.dgvMakeUp.BackgroundColor = System.Drawing.Color.SeaShell
        Me.dgvMakeUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMakeUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakeUp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dgvMakeUp.Location = New System.Drawing.Point(376, 277)
        Me.dgvMakeUp.Name = "dgvMakeUp"
        Me.dgvMakeUp.ReadOnly = True
        Me.dgvMakeUp.Size = New System.Drawing.Size(538, 288)
        Me.dgvMakeUp.TabIndex = 24
        '
        'Column7
        '
        Me.Column7.HeaderText = "ID"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "NAMA"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "MERK"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "JENIS"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "HARGA"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "STOK"
        Me.Column12.Name = "Column12"
<<<<<<< HEAD
        Me.Column12.ReadOnly = True
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(245, 23)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(97, 23)
        Me.btnKeluar.TabIndex = 25
        Me.btnKeluar.Text = "<< Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Orchid
        Me.btnBatal.FlatAppearance.BorderSize = 0
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(183, 430)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 26
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
=======
>>>>>>> 15052e1a9ea5e590e68670e8869307d7032c169b
>>>>>>> 44b9c2d4a531120d6dc4789e56af2634ef7c314c
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_Visual.My.Resources.Resources.Admin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(1248, 727)
        Me.Controls.Add(Me.dgvSkinCare)
=======
        Me.ClientSize = New System.Drawing.Size(936, 591)
<<<<<<< HEAD
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnKeluar)
=======
>>>>>>> 15052e1a9ea5e590e68670e8869307d7032c169b
>>>>>>> 44b9c2d4a531120d6dc4789e56af2634ef7c314c
        Me.Controls.Add(Me.dgvMakeUp)
        Me.Controls.Add(Me.dgvSkinCare)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.lblStok)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.lblJenis)
        Me.Controls.Add(Me.txtMerk)
        Me.Controls.Add(Me.lblMerk)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin"
        Me.Text = "Admin"
        CType(Me.dgvSkinCare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMakeUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblMerk As Label
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents lblJenis As Label
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents lblStok As Label
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnCari As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents dgvSkinCare As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents dgvMakeUp As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnBatal As Button
End Class
