﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class konfirmasi
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.Rp = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoPesanan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SeaShell
        Me.GroupBox1.Controls.Add(Me.dgvKeranjang)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SaddleBrown
        Me.GroupBox1.Location = New System.Drawing.Point(213, 65)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1072, 240)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keranjang Anda"
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.AllowUserToAddRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.SeaShell
        Me.dgvKeranjang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvKeranjang.BackgroundColor = System.Drawing.Color.SeaShell
        Me.dgvKeranjang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvKeranjang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvKeranjang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKeranjang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvKeranjang.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvKeranjang.Location = New System.Drawing.Point(0, 19)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.ReadOnly = True
        Me.dgvKeranjang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvKeranjang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKeranjang.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvKeranjang.RowHeadersVisible = False
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.SeaShell
        Me.dgvKeranjang.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvKeranjang.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKeranjang.Size = New System.Drawing.Size(1070, 216)
        Me.dgvKeranjang.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Silahkan periksa kembali barang belanjaan anda ;)"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RosyBrown
        Me.btnBack.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(513, 339)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(185, 48)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Kembali untuk mengubah"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.IndianRed
        Me.btnCheckout.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnCheckout.Location = New System.Drawing.Point(818, 339)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(185, 48)
        Me.btnCheckout.TabIndex = 5
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.BackColor = System.Drawing.Color.Transparent
        Me.lblharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblharga.ForeColor = System.Drawing.Color.Black
        Me.lblharga.Location = New System.Drawing.Point(310, 344)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(61, 29)
        Me.lblharga.TabIndex = 14
        Me.lblharga.Text = "........"
        '
        'Rp
        '
        Me.Rp.AutoSize = True
        Me.Rp.BackColor = System.Drawing.Color.Transparent
        Me.Rp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rp.ForeColor = System.Drawing.Color.Black
        Me.Rp.Location = New System.Drawing.Point(267, 344)
        Me.Rp.Name = "Rp"
        Me.Rp.Size = New System.Drawing.Size(50, 29)
        Me.Rp.TabIndex = 13
        Me.Rp.Text = "Rp."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 29)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "TOTAL BELANJAAN :"
        '
        'txtNoPesanan
        '
        Me.txtNoPesanan.BackColor = System.Drawing.Color.SeaShell
        Me.txtNoPesanan.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPesanan.Location = New System.Drawing.Point(1009, 32)
        Me.txtNoPesanan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoPesanan.Name = "txtNoPesanan"
        Me.txtNoPesanan.ReadOnly = True
        Me.txtNoPesanan.Size = New System.Drawing.Size(276, 27)
        Me.txtNoPesanan.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(881, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "No. Pesanan"
        '
        'konfirmasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_Visual.My.Resources.Resources.konfirmasi
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1333, 425)
        Me.Controls.Add(Me.txtNoPesanan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblharga)
        Me.Controls.Add(Me.Rp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "konfirmasi"
        Me.Text = "konfirmasi"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents lblharga As Label
    Friend WithEvents Rp As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNoPesanan As TextBox
    Friend WithEvents Label3 As Label
End Class
