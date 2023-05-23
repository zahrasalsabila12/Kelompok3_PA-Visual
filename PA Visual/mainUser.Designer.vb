<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTambahSkincare = New System.Windows.Forms.Button()
        Me.dgvDaftarSkincare = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTambahMakeup = New System.Windows.Forms.Button()
        Me.dgvDaftarMakeup = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtTotalPesanan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvDaftarSkincare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDaftarMakeup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label1.Location = New System.Drawing.Point(13, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Pesanan"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.SeaShell
        Me.TextBox1.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(141, 172)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 32)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox1.Controls.Add(Me.btnTambahSkincare)
        Me.GroupBox1.Controls.Add(Me.dgvDaftarSkincare)
        Me.GroupBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Location = New System.Drawing.Point(53, 220)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(620, 272)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Skincare"
        '
        'btnTambahSkincare
        '
        Me.btnTambahSkincare.BackColor = System.Drawing.Color.RosyBrown
        Me.btnTambahSkincare.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahSkincare.ForeColor = System.Drawing.Color.SeaShell
        Me.btnTambahSkincare.Location = New System.Drawing.Point(257, 228)
        Me.btnTambahSkincare.Name = "btnTambahSkincare"
        Me.btnTambahSkincare.Size = New System.Drawing.Size(107, 32)
        Me.btnTambahSkincare.TabIndex = 2
        Me.btnTambahSkincare.Text = "TAMBAH"
        Me.btnTambahSkincare.UseVisualStyleBackColor = False
        '
        'dgvDaftarSkincare
        '
        Me.dgvDaftarSkincare.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvDaftarSkincare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftarSkincare.Location = New System.Drawing.Point(19, 27)
        Me.dgvDaftarSkincare.MultiSelect = False
        Me.dgvDaftarSkincare.Name = "dgvDaftarSkincare"
        Me.dgvDaftarSkincare.ReadOnly = True
        Me.dgvDaftarSkincare.RowHeadersVisible = False
        Me.dgvDaftarSkincare.RowHeadersWidth = 51
        Me.dgvDaftarSkincare.RowTemplate.Height = 24
        Me.dgvDaftarSkincare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDaftarSkincare.Size = New System.Drawing.Size(571, 195)
        Me.dgvDaftarSkincare.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox2.Controls.Add(Me.btnTambahMakeup)
        Me.GroupBox2.Controls.Add(Me.dgvDaftarMakeup)
        Me.GroupBox2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox2.Location = New System.Drawing.Point(728, 220)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(603, 272)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Makeup"
        '
        'btnTambahMakeup
        '
        Me.btnTambahMakeup.BackColor = System.Drawing.Color.RosyBrown
        Me.btnTambahMakeup.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahMakeup.ForeColor = System.Drawing.Color.SeaShell
        Me.btnTambahMakeup.Location = New System.Drawing.Point(243, 228)
        Me.btnTambahMakeup.Name = "btnTambahMakeup"
        Me.btnTambahMakeup.Size = New System.Drawing.Size(107, 32)
        Me.btnTambahMakeup.TabIndex = 2
        Me.btnTambahMakeup.Text = "TAMBAH"
        Me.btnTambahMakeup.UseVisualStyleBackColor = False
        '
        'dgvDaftarMakeup
        '
        Me.dgvDaftarMakeup.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvDaftarMakeup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftarMakeup.Location = New System.Drawing.Point(19, 27)
        Me.dgvDaftarMakeup.MultiSelect = False
        Me.dgvDaftarMakeup.Name = "dgvDaftarMakeup"
        Me.dgvDaftarMakeup.ReadOnly = True
        Me.dgvDaftarMakeup.RowHeadersVisible = False
        Me.dgvDaftarMakeup.RowHeadersWidth = 51
        Me.dgvDaftarMakeup.RowTemplate.Height = 24
        Me.dgvDaftarMakeup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDaftarMakeup.Size = New System.Drawing.Size(559, 195)
        Me.dgvDaftarMakeup.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox3.Controls.Add(Me.btnHapus)
        Me.GroupBox3.Controls.Add(Me.txtTotalPesanan)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnCheckout)
        Me.GroupBox3.Controls.Add(Me.dgvKeranjang)
        Me.GroupBox3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox3.Location = New System.Drawing.Point(72, 521)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1194, 199)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Keranjang Anda"
        '
        'btnHapus
        '
        Me.btnHapus.BackColor = System.Drawing.Color.RosyBrown
        Me.btnHapus.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.SeaShell
        Me.btnHapus.Location = New System.Drawing.Point(872, 124)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(88, 48)
        Me.btnHapus.TabIndex = 5
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = False
        '
        'txtTotalPesanan
        '
        Me.txtTotalPesanan.BackColor = System.Drawing.Color.RosyBrown
        Me.txtTotalPesanan.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPesanan.Location = New System.Drawing.Point(872, 64)
        Me.txtTotalPesanan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPesanan.Name = "txtTotalPesanan"
        Me.txtTotalPesanan.Size = New System.Drawing.Size(276, 32)
        Me.txtTotalPesanan.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label2.Location = New System.Drawing.Point(869, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Pesanan"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.RosyBrown
        Me.btnCheckout.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.SeaShell
        Me.btnCheckout.Location = New System.Drawing.Point(1035, 124)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(113, 48)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "CHECKOUT >>"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.AllowUserToAddRows = False
        Me.dgvKeranjang.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Location = New System.Drawing.Point(19, 27)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.RowHeadersVisible = False
        Me.dgvKeranjang.RowHeadersWidth = 51
        Me.dgvKeranjang.RowTemplate.Height = 24
        Me.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKeranjang.Size = New System.Drawing.Size(819, 145)
        Me.dgvKeranjang.TabIndex = 0
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.RosyBrown
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.SeaShell
        Me.btnLogout.Location = New System.Drawing.Point(1199, 169)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(107, 32)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LOG OUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'mainUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_Visual.My.Resources.Resources.mainUser
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 733)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mainUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainUser"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvDaftarSkincare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDaftarMakeup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTambahSkincare As Button
    Friend WithEvents dgvDaftarSkincare As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTambahMakeup As Button
    Friend WithEvents dgvDaftarMakeup As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalPesanan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnHapus As Button
End Class
