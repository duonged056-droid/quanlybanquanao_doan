Public Class Form1

    ' Biến trạng thái đăng nhập
    Public Shared IsLoggedIn As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New ThuVien()
        f.KetNoi()
    End Sub

    ' Mặt hàng
    Private Sub MatHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MatHangToolStripMenuItem.Click
        If IsLoggedIn = False Then
            MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng chức năng này.", "Yêu cầu đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim f As New frmMatHang
        f.Show()
    End Sub

    ' Khách hàng
    Private Sub KhanhHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhanhHangToolStripMenuItem.Click
        If IsLoggedIn = False Then
            MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng chức năng này.", "Yêu cầu đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim f As New frmKhachHang
        f.Show()
    End Sub

    ' Đăng nhập
    Private Sub DangNhapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DangNhapToolStripMenuItem.Click
        Dim f As New frmDangNhap
        f.Show()
    End Sub

    ' Lập hóa đơn
    Private Sub lapHoaDonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles lapHoaDonToolStripMenuItem.Click
        If IsLoggedIn = False Then
            MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng chức năng này.", "Yêu cầu đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim f As New frmHoaDon
        f.ShowDialog()
    End Sub

    ' Thoát chương trình
    Private Sub ThoatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoatToolStripMenuItem.Click
        Application.Exit()
    End Sub

    ' Đăng xuất
    Private Sub DangXuatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DangXuatToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            IsLoggedIn = False   ' reset trạng thái đăng nhập
            Me.Hide()
            Dim frmDangNhap As New frmDangNhap()
            frmDangNhap.Show()
        End If
    End Sub

    ' Doanh thu bán hàng
    Private Sub DoanhThuBanHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoanhThuBanHangToolStripMenuItem.Click
        If IsLoggedIn = False Then
            MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng chức năng này.", "Yêu cầu đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim f As New frmThongKeDoanhThu
        f.Show()
    End Sub

    Private Sub HeThongToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeThongToolStripMenuItem.Click
        ' menu hệ thống nếu cần xử lý thêm
    End Sub

End Class
