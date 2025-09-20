<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatHang
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
        Me.msp = New System.Windows.Forms.Label()
        Me.sp = New System.Windows.Forms.Label()
        Me.sa = New System.Windows.Forms.Label()
        Me.ms = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMauSac = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgSanPham = New System.Windows.Forms.DataGridView()
        Me.txt = New System.Windows.Forms.Label()
        Me.slg = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtDonDia = New System.Windows.Forms.TextBox()
        CType(Me.dgSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NHẬP THÔNG TIN MẶT HÀNG"
        '
        'msp
        '
        Me.msp.AutoSize = True
        Me.msp.Location = New System.Drawing.Point(12, 276)
        Me.msp.Name = "msp"
        Me.msp.Size = New System.Drawing.Size(128, 24)
        Me.msp.TabIndex = 1
        Me.msp.Text = "Mã Sản Phẩm"
        '
        'sp
        '
        Me.sp.AutoSize = True
        Me.sp.Location = New System.Drawing.Point(12, 316)
        Me.sp.Name = "sp"
        Me.sp.Size = New System.Drawing.Size(136, 24)
        Me.sp.TabIndex = 1
        Me.sp.Text = "Tên Sản Phẩm"
        '
        'sa
        '
        Me.sa.AutoSize = True
        Me.sa.Location = New System.Drawing.Point(12, 349)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(46, 24)
        Me.sa.TabIndex = 1
        Me.sa.Text = "Size"
        '
        'ms
        '
        Me.ms.AutoSize = True
        Me.ms.Location = New System.Drawing.Point(12, 384)
        Me.ms.Name = "ms"
        Me.ms.Size = New System.Drawing.Size(84, 24)
        Me.ms.TabIndex = 1
        Me.ms.Text = "Màu Sắc"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(157, 273)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(220, 29)
        Me.txtMaSP.TabIndex = 2
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(157, 311)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(220, 29)
        Me.txtTenSP.TabIndex = 2
        '
        'txtMauSac
        '
        Me.txtMauSac.Location = New System.Drawing.Point(157, 381)
        Me.txtMauSac.Name = "txtMauSac"
        Me.txtMauSac.Size = New System.Drawing.Size(220, 29)
        Me.txtMauSac.TabIndex = 2
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(426, 271)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(116, 29)
        Me.btnThem.TabIndex = 4
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(426, 333)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(116, 29)
        Me.btnSua.TabIndex = 4
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(426, 398)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(116, 29)
        Me.btnXoa.TabIndex = 4
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(426, 452)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(116, 29)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'dgSanPham
        '
        Me.dgSanPham.BackgroundColor = System.Drawing.Color.Plum
        Me.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSanPham.Location = New System.Drawing.Point(31, 55)
        Me.dgSanPham.Name = "dgSanPham"
        Me.dgSanPham.Size = New System.Drawing.Size(639, 190)
        Me.dgSanPham.TabIndex = 5
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Location = New System.Drawing.Point(12, 423)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(92, 24)
        Me.txt.TabIndex = 1
        Me.txt.Text = "Số Lượng"
        '
        'slg
        '
        Me.slg.AutoSize = True
        Me.slg.Location = New System.Drawing.Point(12, 458)
        Me.slg.Name = "slg"
        Me.slg.Size = New System.Drawing.Size(78, 24)
        Me.slg.TabIndex = 1
        Me.slg.Text = "Đơn Giá"
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(157, 346)
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(220, 29)
        Me.txtSize.TabIndex = 2
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(157, 422)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(220, 29)
        Me.txtSoLuong.TabIndex = 2
        '
        'txtDonDia
        '
        Me.txtDonDia.Location = New System.Drawing.Point(157, 460)
        Me.txtDonDia.Name = "txtDonDia"
        Me.txtDonDia.Size = New System.Drawing.Size(220, 29)
        Me.txtDonDia.TabIndex = 2
        '
        'frmMatHang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(687, 493)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtMauSac)
        Me.Controls.Add(Me.txtDonDia)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.slg)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.ms)
        Me.Controls.Add(Me.sa)
        Me.Controls.Add(Me.sp)
        Me.Controls.Add(Me.msp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgSanPham)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmMatHang"
        Me.Text = "frmMatHang"
        CType(Me.dgSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents msp As Label
    Friend WithEvents sp As Label
    Friend WithEvents sa As Label
    Friend WithEvents ms As Label
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents txtTenSP As TextBox
    Friend WithEvents txtMauSac As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents dgSanPham As DataGridView
    Friend WithEvents txt As Label
    Friend WithEvents slg As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtDonDia As TextBox
End Class
