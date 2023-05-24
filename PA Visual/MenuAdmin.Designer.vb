<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAdmin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtMerk = New System.Windows.Forms.TextBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.dgvSkinCare = New System.Windows.Forms.DataGridView()
        Me.btnCariSC = New System.Windows.Forms.Button()
        Me.txtCariSC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvMakeUp = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.txtCariMU = New System.Windows.Forms.TextBox()
        Me.btnCariMU = New System.Windows.Forms.Button()
        CType(Me.dgvSkinCare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMakeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Merk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Harga"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stok"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(15, 187)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(319, 21)
        Me.txtNama.TabIndex = 6
        '
        'txtMerk
        '
        Me.txtMerk.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMerk.Location = New System.Drawing.Point(15, 247)
        Me.txtMerk.Name = "txtMerk"
        Me.txtMerk.Size = New System.Drawing.Size(319, 21)
        Me.txtMerk.TabIndex = 7
        '
        'cbJenis
        '
        Me.cbJenis.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"Skin Care", "Make Up"})
        Me.cbJenis.Location = New System.Drawing.Point(15, 307)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(319, 24)
        Me.cbJenis.TabIndex = 8
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(15, 363)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(319, 21)
        Me.txtHarga.TabIndex = 9
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(15, 414)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(319, 21)
        Me.txtStok.TabIndex = 10
        '
        'btnTambah
        '
        Me.btnTambah.BackColor = System.Drawing.Color.LimeGreen
        Me.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambah.Location = New System.Drawing.Point(16, 486)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 26)
        Me.btnTambah.TabIndex = 11
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = False
        '
        'btnUbah
        '
        Me.btnUbah.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUbah.Location = New System.Drawing.Point(97, 486)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 26)
        Me.btnUbah.TabIndex = 12
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = False
        '
        'btnBatal
        '
        Me.btnBatal.BackColor = System.Drawing.Color.Violet
        Me.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatal.Location = New System.Drawing.Point(178, 486)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 26)
        Me.btnBatal.TabIndex = 13
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = False
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.Red
        Me.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapus.Location = New System.Drawing.Point(259, 486)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 26)
        Me.btnHapus.TabIndex = 14
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'dgvSkinCare
        '
        Me.dgvSkinCare.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSkinCare.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSkinCare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSkinCare.Location = New System.Drawing.Point(375, 44)
        Me.dgvSkinCare.Name = "dgvSkinCare"
        Me.dgvSkinCare.RowHeadersWidth = 51
        Me.dgvSkinCare.Size = New System.Drawing.Size(546, 218)
        Me.dgvSkinCare.TabIndex = 15
        '
        'btnCariSC
        '
        Me.btnCariSC.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCariSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariSC.Location = New System.Drawing.Point(819, 13)
        Me.btnCariSC.Name = "btnCariSC"
        Me.btnCariSC.Size = New System.Drawing.Size(102, 25)
        Me.btnCariSC.TabIndex = 16
        Me.btnCariSC.Text = "Cari Skincare"
        Me.btnCariSC.UseVisualStyleBackColor = False
        '
        'txtCariSC
        '
        Me.txtCariSC.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariSC.Location = New System.Drawing.Point(588, 15)
        Me.txtCariSC.Name = "txtCariSC"
        Me.txtCariSC.Size = New System.Drawing.Size(225, 21)
        Me.txtCariSC.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Data Skin Care"
        '
        'dgvMakeUp
        '
        Me.dgvMakeUp.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvMakeUp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMakeUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMakeUp.Location = New System.Drawing.Point(375, 300)
        Me.dgvMakeUp.Name = "dgvMakeUp"
        Me.dgvMakeUp.RowHeadersWidth = 51
        Me.dgvMakeUp.Size = New System.Drawing.Size(546, 242)
        Me.dgvMakeUp.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(371, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 19)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Data Make Up"
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.Salmon
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Location = New System.Drawing.Point(250, 11)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(94, 23)
        Me.btnKeluar.TabIndex = 23
        Me.btnKeluar.Text = "<<< Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'txtCariMU
        '
        Me.txtCariMU.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariMU.Location = New System.Drawing.Point(588, 273)
        Me.txtCariMU.Name = "txtCariMU"
        Me.txtCariMU.Size = New System.Drawing.Size(225, 21)
        Me.txtCariMU.TabIndex = 25
        '
        'btnCariMU
        '
        Me.btnCariMU.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCariMU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariMU.Location = New System.Drawing.Point(819, 271)
        Me.btnCariMU.Name = "btnCariMU"
        Me.btnCariMU.Size = New System.Drawing.Size(102, 25)
        Me.btnCariMU.TabIndex = 24
        Me.btnCariMU.Text = "Cari Make Up"
        Me.btnCariMU.UseVisualStyleBackColor = False
        '
        'MenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_Visual.My.Resources.Resources.Admin
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(933, 554)
        Me.Controls.Add(Me.txtCariMU)
        Me.Controls.Add(Me.btnCariMU)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvMakeUp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCariSC)
        Me.Controls.Add(Me.btnCariSC)
        Me.Controls.Add(Me.dgvSkinCare)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.cbJenis)
        Me.Controls.Add(Me.txtMerk)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuAdmin"
        Me.Text = "MenuAdmin"
        CType(Me.dgvSkinCare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMakeUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents cbJenis As ComboBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtStok As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents dgvSkinCare As DataGridView
    Friend WithEvents btnCariSC As Button
    Friend WithEvents txtCariSC As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvMakeUp As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents btnKeluar As Button
    Friend WithEvents txtCariMU As TextBox
    Friend WithEvents btnCariMU As Button
End Class
