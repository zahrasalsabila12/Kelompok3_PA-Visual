<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class struk
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(761, 655)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(290, 58)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Download Gambar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RosyBrown
        Me.Button1.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(375, 655)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(290, 58)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Kembali"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvKeranjang
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell
        Me.dgvKeranjang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvKeranjang.BackgroundColor = System.Drawing.Color.SeaShell
        Me.dgvKeranjang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvKeranjang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvKeranjang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKeranjang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKeranjang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvKeranjang.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvKeranjang.Location = New System.Drawing.Point(170, 145)
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dgvKeranjang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvKeranjang.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvKeranjang.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaShell
        Me.dgvKeranjang.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvKeranjang.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKeranjang.Size = New System.Drawing.Size(1070, 487)
        Me.dgvKeranjang.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "NO"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NAMA"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "MEREK"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 120
        '
        'Column4
        '
        Me.Column4.HeaderText = "JENIS"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "HARGA SATUAN"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "JUMLAH BARANG"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 200
        '
        'Column7
        '
        Me.Column7.HeaderText = "TOTAL"
        Me.Column7.Name = "Column7"
        '
        'struk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_Visual.My.Resources.Resources.struk
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.dgvKeranjang)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "struk"
        Me.Text = "struk"
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvKeranjang As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
