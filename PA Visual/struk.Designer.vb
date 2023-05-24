<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class struk
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvStruk = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Rp = New System.Windows.Forms.Label()
        Me.lblharga = New System.Windows.Forms.Label()
        Me.txtNoPesanan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvStruk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.IndianRed
        Me.btnDownload.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnDownload.Location = New System.Drawing.Point(761, 655)
        Me.btnDownload.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(290, 58)
        Me.btnDownload.TabIndex = 7
        Me.btnDownload.Text = "Download Gambar"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.RosyBrown
        Me.btnBack.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnBack.Location = New System.Drawing.Point(375, 655)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(290, 58)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Kembali"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvStruk
        '
        Me.dgvStruk.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell
        Me.dgvStruk.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStruk.BackgroundColor = System.Drawing.Color.SeaShell
        Me.dgvStruk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvStruk.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStruk.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStruk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvStruk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStruk.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStruk.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvStruk.Location = New System.Drawing.Point(170, 145)
        Me.dgvStruk.Name = "dgvStruk"
        Me.dgvStruk.ReadOnly = True
        Me.dgvStruk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvStruk.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStruk.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvStruk.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaShell
        Me.dgvStruk.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStruk.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvStruk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStruk.Size = New System.Drawing.Size(1070, 419)
        Me.dgvStruk.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "NO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(834, 597)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "TOTAL BELANJAAN :"
        '
        'Rp
        '
        Me.Rp.AutoSize = True
        Me.Rp.BackColor = System.Drawing.Color.Transparent
        Me.Rp.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rp.Location = New System.Drawing.Point(1079, 597)
        Me.Rp.Name = "Rp"
        Me.Rp.Size = New System.Drawing.Size(50, 29)
        Me.Rp.TabIndex = 10
        Me.Rp.Text = "Rp."
        '
        'lblharga
        '
        Me.lblharga.AutoSize = True
        Me.lblharga.BackColor = System.Drawing.Color.Transparent
        Me.lblharga.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblharga.Location = New System.Drawing.Point(1122, 597)
        Me.lblharga.Name = "lblharga"
        Me.lblharga.Size = New System.Drawing.Size(61, 29)
        Me.lblharga.TabIndex = 11
        Me.lblharga.Text = "........"
        '
        'txtNoPesanan
        '
        Me.txtNoPesanan.BackColor = System.Drawing.Color.SeaShell
        Me.txtNoPesanan.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoPesanan.Location = New System.Drawing.Point(1022, 101)
        Me.txtNoPesanan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoPesanan.Name = "txtNoPesanan"
        Me.txtNoPesanan.ReadOnly = True
        Me.txtNoPesanan.Size = New System.Drawing.Size(276, 27)
        Me.txtNoPesanan.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Label3.Location = New System.Drawing.Point(894, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "No. Pesanan"
        '
        'struk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_Visual.My.Resources.Resources.struk
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.txtNoPesanan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblharga)
        Me.Controls.Add(Me.Rp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvStruk)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "struk"
        Me.Text = "struk"
        CType(Me.dgvStruk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDownload As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvStruk As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Rp As Label
    Friend WithEvents lblharga As Label
    Friend WithEvents txtNoPesanan As TextBox
    Friend WithEvents Label3 As Label
End Class
