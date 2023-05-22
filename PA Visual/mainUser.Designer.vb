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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvDaftarSkincare = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTambahMakeup = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvDaftarMakeup = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotalPesanan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDaftarSkincare, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(24, 204)
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
        Me.TextBox1.Location = New System.Drawing.Point(152, 196)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(276, 32)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox1.Controls.Add(Me.btnTambahSkincare)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.dgvDaftarSkincare)
        Me.GroupBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Location = New System.Drawing.Point(53, 258)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(712, 346)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Skincare"
        '
        'btnTambahSkincare
        '
        Me.btnTambahSkincare.BackColor = System.Drawing.Color.RosyBrown
        Me.btnTambahSkincare.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahSkincare.ForeColor = System.Drawing.Color.SeaShell
        Me.btnTambahSkincare.Location = New System.Drawing.Point(516, 255)
        Me.btnTambahSkincare.Name = "btnTambahSkincare"
        Me.btnTambahSkincare.Size = New System.Drawing.Size(107, 32)
        Me.btnTambahSkincare.TabIndex = 2
        Me.btnTambahSkincare.Text = "TAMBAH"
        Me.btnTambahSkincare.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.RosyBrown
        Me.PictureBox1.Location = New System.Drawing.Point(476, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 172)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'dgvDaftarSkincare
        '
        Me.dgvDaftarSkincare.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvDaftarSkincare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftarSkincare.Location = New System.Drawing.Point(19, 27)
        Me.dgvDaftarSkincare.Name = "dgvDaftarSkincare"
        Me.dgvDaftarSkincare.RowHeadersWidth = 51
        Me.dgvDaftarSkincare.RowTemplate.Height = 24
        Me.dgvDaftarSkincare.Size = New System.Drawing.Size(408, 298)
        Me.dgvDaftarSkincare.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox2.Controls.Add(Me.btnTambahMakeup)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.dgvDaftarMakeup)
        Me.GroupBox2.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox2.Location = New System.Drawing.Point(846, 258)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(712, 346)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Makeup"
        '
        'btnTambahMakeup
        '
        Me.btnTambahMakeup.BackColor = System.Drawing.Color.RosyBrown
        Me.btnTambahMakeup.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahMakeup.ForeColor = System.Drawing.Color.SeaShell
        Me.btnTambahMakeup.Location = New System.Drawing.Point(516, 255)
        Me.btnTambahMakeup.Name = "btnTambahMakeup"
        Me.btnTambahMakeup.Size = New System.Drawing.Size(107, 32)
        Me.btnTambahMakeup.TabIndex = 2
        Me.btnTambahMakeup.Text = "TAMBAH"
        Me.btnTambahMakeup.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.RosyBrown
        Me.PictureBox2.Location = New System.Drawing.Point(476, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(181, 172)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'dgvDaftarMakeup
        '
        Me.dgvDaftarMakeup.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvDaftarMakeup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDaftarMakeup.Location = New System.Drawing.Point(19, 27)
        Me.dgvDaftarMakeup.Name = "dgvDaftarMakeup"
        Me.dgvDaftarMakeup.RowHeadersWidth = 51
        Me.dgvDaftarMakeup.RowTemplate.Height = 24
        Me.dgvDaftarMakeup.Size = New System.Drawing.Size(408, 298)
        Me.dgvDaftarMakeup.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox3.Controls.Add(Me.txtTotalPesanan)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnCheckout)
        Me.GroupBox3.Controls.Add(Me.dgvKeranjang)
        Me.GroupBox3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox3.Location = New System.Drawing.Point(280, 622)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1068, 346)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Keranjang Anda"
        '
        'txtTotalPesanan
        '
        Me.txtTotalPesanan.BackColor = System.Drawing.Color.RosyBrown
        Me.txtTotalPesanan.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPesanan.Location = New System.Drawing.Point(754, 168)
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
        Me.Label2.Location = New System.Drawing.Point(751, 146)
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
        Me.btnCheckout.Location = New System.Drawing.Point(820, 277)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(151, 48)
        Me.btnCheckout.TabIndex = 2
        Me.btnCheckout.Text = "CHECKOUT >>"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.BackgroundColor = System.Drawing.Color.RosyBrown
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Location = New System.Drawing.Point(19, 27)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.RowHeadersWidth = 51
        Me.dgvKeranjang.RowTemplate.Height = 24
        Me.dgvKeranjang.Size = New System.Drawing.Size(675, 298)
        Me.dgvKeranjang.TabIndex = 0
        '
        'mainUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_Visual.My.Resources.Resources.mainUser
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1575, 1015)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mainUser"
        Me.Text = "mainUser"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDaftarSkincare, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvDaftarSkincare As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTambahMakeup As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvDaftarMakeup As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotalPesanan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents dgvKeranjang As DataGridView
End Class
