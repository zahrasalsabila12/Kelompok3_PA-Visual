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
        Me.dgvSkinCare = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMakeUp = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSkinCare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMakeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(32, 139)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(20, 16)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(35, 158)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(274, 23)
        Me.txtID.TabIndex = 1
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.BackColor = System.Drawing.Color.Transparent
        Me.lblNama.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(32, 184)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(47, 16)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(35, 203)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(274, 23)
        Me.txtNama.TabIndex = 3
        '
        'lblMerk
        '
        Me.lblMerk.AutoSize = True
        Me.lblMerk.BackColor = System.Drawing.Color.Transparent
        Me.lblMerk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMerk.Location = New System.Drawing.Point(32, 229)
        Me.lblMerk.Name = "lblMerk"
        Me.lblMerk.Size = New System.Drawing.Size(40, 16)
        Me.lblMerk.TabIndex = 4
        Me.lblMerk.Text = "Merk"
        '
        'txtMerk
        '
        Me.txtMerk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMerk.Location = New System.Drawing.Point(35, 248)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(274, 23)
        Me.txtMerk.TabIndex = 5
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.BackColor = System.Drawing.Color.Transparent
        Me.lblJenis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJenis.Location = New System.Drawing.Point(32, 274)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(39, 16)
        Me.lblJenis.TabIndex = 6
        Me.lblJenis.Text = "Jenis"
        '
        'cbJenis
        '
        Me.cbJenis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"Skin Care", "Make Up"})
        Me.cbJenis.Location = New System.Drawing.Point(35, 293)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(274, 25)
        Me.cbJenis.TabIndex = 7
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.BackColor = System.Drawing.Color.Transparent
        Me.lblHarga.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(33, 321)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(48, 16)
        Me.lblHarga.TabIndex = 8
        Me.lblHarga.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(35, 340)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(274, 23)
        Me.txtHarga.TabIndex = 9
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.BackColor = System.Drawing.Color.Transparent
        Me.lblStok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStok.Location = New System.Drawing.Point(33, 366)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(34, 16)
        Me.lblStok.TabIndex = 10
        Me.lblStok.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(35, 385)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(274, 23)
        Me.txtStok.TabIndex = 11
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.LimeGreen
        Me.btnTambah.FlatAppearance.BorderSize = 0
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(34, 427)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
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
        Me.btnUbah.Location = New System.Drawing.Point(136, 427)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 16
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Salmon
        Me.btnHapus.FlatAppearance.BorderSize = 0
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(233, 427)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
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
        Me.btnCari.Location = New System.Drawing.Point(612, 23)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(75, 23)
        Me.btnCari.TabIndex = 18
        Me.btnCari.Text = "Cari"
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(376, 23)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(230, 23)
        Me.txtCari.TabIndex = 20
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'dgvSkinCare
        '
        Me.dgvSkinCare.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvSkinCare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSkinCare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSkinCare.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvSkinCare.Location = New System.Drawing.Point(376, 52)
        Me.dgvSkinCare.Name = "dgvSkinCare"
        Me.dgvSkinCare.ReadOnly = True
        Me.dgvSkinCare.Size = New System.Drawing.Size(538, 219)
        Me.dgvSkinCare.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAMA"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "MERK"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "JENIS"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "HARGA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "STOK"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
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
        '
        'Column8
        '
        Me.Column8.HeaderText = "NAMA"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "MERK"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "JENIS"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "HARGA"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "STOK"
        Me.Column12.Name = "Column12"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_Visual.My.Resources.Resources.Admin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(936, 591)
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
End Class
