<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHoaDon
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
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.txtGioLap = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNgayLap = New System.Windows.Forms.DateTimePicker()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgChiTietHoaDon = New System.Windows.Forms.DataGridView()
        Me.txtMaHD = New System.Windows.Forms.TextBox()
        Me.dgSanPham = New System.Windows.Forms.DataGridView()
        CType(Me.dgChiTietHoaDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSanPham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(312, 100)
        Me.txtMaKH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(100, 20)
        Me.txtMaKH.TabIndex = 1
        '
        'txtGioLap
        '
        Me.txtGioLap.Location = New System.Drawing.Point(312, 155)
        Me.txtGioLap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtGioLap.Name = "txtGioLap"
        Me.txtGioLap.Size = New System.Drawing.Size(100, 20)
        Me.txtGioLap.TabIndex = 1
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(449, 650)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 26)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(168, 650)
        Me.btnSua.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(94, 26)
        Me.btnSua.TabIndex = 2
        Me.btnSua.Text = "Sửa hóa đơn"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(26, 650)
        Me.btnThem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(111, 26)
        Me.btnThem.TabIndex = 2
        Me.btnThem.Text = "Lưu hóa đơn "
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 560)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tổng Thành Tiền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Hóa Đơn"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mã hóa đơn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(165, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mã khách hàng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 14)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ngày lập"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 14)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Giờ lập"
        '
        'txtNgayLap
        '
        Me.txtNgayLap.Location = New System.Drawing.Point(312, 130)
        Me.txtNgayLap.Name = "txtNgayLap"
        Me.txtNgayLap.Size = New System.Drawing.Size(200, 20)
        Me.txtNgayLap.TabIndex = 6
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(298, 650)
        Me.btnXoa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(93, 26)
        Me.btnXoa.TabIndex = 2
        Me.btnXoa.Text = "Xóa hóa đơn"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(312, 187)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(99, 20)
        Me.txtMaSP.TabIndex = 7
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(312, 213)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(99, 20)
        Me.txtSoLuong.TabIndex = 7
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(413, 504)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(99, 20)
        Me.txtDonGia.TabIndex = 7
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Location = New System.Drawing.Point(413, 560)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(99, 20)
        Me.txtThanhTien.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(165, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Mã sản phẩm"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(165, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 14)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Số lượng"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 510)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 14)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Đơn giá"
        '
        'dgChiTietHoaDon
        '
        Me.dgChiTietHoaDon.BackgroundColor = System.Drawing.Color.Plum
        Me.dgChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgChiTietHoaDon.Location = New System.Drawing.Point(26, 238)
        Me.dgChiTietHoaDon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgChiTietHoaDon.Name = "dgChiTietHoaDon"
        Me.dgChiTietHoaDon.Size = New System.Drawing.Size(539, 118)
        Me.dgChiTietHoaDon.TabIndex = 3
        '
        'txtMaHD
        '
        Me.txtMaHD.Location = New System.Drawing.Point(312, 71)
        Me.txtMaHD.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaHD.Name = "txtMaHD"
        Me.txtMaHD.Size = New System.Drawing.Size(100, 20)
        Me.txtMaHD.TabIndex = 1
        '
        'dgSanPham
        '
        Me.dgSanPham.BackgroundColor = System.Drawing.Color.Plum
        Me.dgSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSanPham.Location = New System.Drawing.Point(26, 356)
        Me.dgSanPham.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgSanPham.Name = "dgSanPham"
        Me.dgSanPham.Size = New System.Drawing.Size(539, 118)
        Me.dgSanPham.TabIndex = 3
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(590, 882)
        Me.Controls.Add(Me.txtThanhTien)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.txtNgayLap)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgSanPham)
        Me.Controls.Add(Me.dgChiTietHoaDon)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.txtGioLap)
        Me.Controls.Add(Me.txtMaHD)
        Me.Controls.Add(Me.txtMaKH)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmHoaDon"
        Me.Text = "A"
        CType(Me.dgChiTietHoaDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSanPham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents txtGioLap As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNgayLap As DateTimePicker
    Friend WithEvents btnXoa As Button
    Friend WithEvents txtMaSP As TextBox
    Friend WithEvents txtSoLuong As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtThanhTien As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgChiTietHoaDon As DataGridView
    Friend WithEvents txtMaHD As TextBox
    Friend WithEvents dgSanPham As DataGridView
End Class
