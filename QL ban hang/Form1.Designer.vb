<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HeThongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DangNhapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DangXuatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DanhMucToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KhanhHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NghiepVuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lapHoaDonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThongKeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoanhThuBanHangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Thistle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(176, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(567, 52)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ BÁN QUẦN ÁO "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeThongToolStripMenuItem, Me.DanhMucToolStripMenuItem, Me.NghiepVuToolStripMenuItem, Me.ThongKeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(882, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HeThongToolStripMenuItem
        '
        Me.HeThongToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DangNhapToolStripMenuItem, Me.DangXuatToolStripMenuItem, Me.ToolStripMenuItem1, Me.ThoatToolStripMenuItem})
        Me.HeThongToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeThongToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HeThongToolStripMenuItem.Name = "HeThongToolStripMenuItem"
        Me.HeThongToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.HeThongToolStripMenuItem.Text = "Hệ thống"
        '
        'DangNhapToolStripMenuItem
        '
        Me.DangNhapToolStripMenuItem.Name = "DangNhapToolStripMenuItem"
        Me.DangNhapToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.DangNhapToolStripMenuItem.Text = "Đăng nhập"
        '
        'DangXuatToolStripMenuItem
        '
        Me.DangXuatToolStripMenuItem.Name = "DangXuatToolStripMenuItem"
        Me.DangXuatToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.DangXuatToolStripMenuItem.Text = "Đăng xuất"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 6)
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.ThoatToolStripMenuItem.Text = "Thoát"
        '
        'DanhMucToolStripMenuItem
        '
        Me.DanhMucToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatHangToolStripMenuItem, Me.KhanhHangToolStripMenuItem})
        Me.DanhMucToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DanhMucToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DanhMucToolStripMenuItem.Name = "DanhMucToolStripMenuItem"
        Me.DanhMucToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.DanhMucToolStripMenuItem.Text = "Danh mục"
        '
        'MatHangToolStripMenuItem
        '
        Me.MatHangToolStripMenuItem.Name = "MatHangToolStripMenuItem"
        Me.MatHangToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.MatHangToolStripMenuItem.Text = "Mặt hàng"
        '
        'KhanhHangToolStripMenuItem
        '
        Me.KhanhHangToolStripMenuItem.Name = "KhanhHangToolStripMenuItem"
        Me.KhanhHangToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.KhanhHangToolStripMenuItem.Text = "Khách hàng"
        '
        'NghiepVuToolStripMenuItem
        '
        Me.NghiepVuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lapHoaDonToolStripMenuItem})
        Me.NghiepVuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NghiepVuToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NghiepVuToolStripMenuItem.Name = "NghiepVuToolStripMenuItem"
        Me.NghiepVuToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.NghiepVuToolStripMenuItem.Text = "Nghiệp vụ"
        '
        'lapHoaDonToolStripMenuItem
        '
        Me.lapHoaDonToolStripMenuItem.Name = "lapHoaDonToolStripMenuItem"
        Me.lapHoaDonToolStripMenuItem.Size = New System.Drawing.Size(178, 26)
        Me.lapHoaDonToolStripMenuItem.Text = "Lập hóa đơn"
        '
        'ThongKeToolStripMenuItem
        '
        Me.ThongKeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoanhThuBanHangToolStripMenuItem})
        Me.ThongKeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThongKeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ThongKeToolStripMenuItem.Name = "ThongKeToolStripMenuItem"
        Me.ThongKeToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.ThongKeToolStripMenuItem.Text = "Thống kê"
        '
        'DoanhThuBanHangToolStripMenuItem
        '
        Me.DoanhThuBanHangToolStripMenuItem.Name = "DoanhThuBanHangToolStripMenuItem"
        Me.DoanhThuBanHangToolStripMenuItem.Size = New System.Drawing.Size(235, 26)
        Me.DoanhThuBanHangToolStripMenuItem.Text = "Doanh thu bán hàng"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(882, 451)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HeThongToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DangNhapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DangXuatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ThoatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DanhMucToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MatHangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KhanhHangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NghiepVuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lapHoaDonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThongKeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoanhThuBanHangToolStripMenuItem As ToolStripMenuItem
End Class
