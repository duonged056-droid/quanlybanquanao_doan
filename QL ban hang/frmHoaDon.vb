Imports System.Data.SqlClient

Public Class frmHoaDon
    Private cbMaSP As Object

    Private Sub frmHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New ThuVien()
        f.GanNguonDataGridView(dgSanPham, "SELECT * FROM SanPham")
        f.GanNguonDataGridView(dgChiTietHoaDon, "SELECT * FROM ChiTietHoaDon")
    End Sub

    Private Sub LoadData()
        Dim f As New ThuVien()
        f.GanNguonDataGridView(dgSanPham, "SELECT * FROM SanPham")
        f.GanNguonDataGridView(dgChiTietHoaDon, "SELECT * FROM ChiTietHoaDon")
    End Sub

    Private Sub ClearText()
        txtMaHD.Text = ""
        txtMaKH.Text = ""
        txtNgayLap.Text = ""
        txtGioLap.Text = ""
        txtGioLap.Text = ""
        txtMaSP.Text = ""
        txtDonGia.Text = ""
        txtThanhTien.Text = ""
        txtMaHD.Focus()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtMaHD.Text = "" Or txtMaKH.Text = "" Or txtNgayLap.Text = "" Or txtGioLap.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim f As New ThuVien()
        Dim sqlCTHD As String = "INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)"

        Using conn As SqlConnection = f.KetNoi()


            ' 0. Kiểm tra mã khách hàng đã tồn tại chưa
            Dim sqlCheckKH As String = "SELECT COUNT(*) FROM KhachHang WHERE MaKH = @MaKH"
            Dim cmdCheckKH As New SqlCommand(sqlCheckKH, conn)
            cmdCheckKH.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
            Dim khCount As Integer = Convert.ToInt32(cmdCheckKH.ExecuteScalar())

            If khCount = 0 Then
                MessageBox.Show("Mã khách hàng '" & txtMaKH.Text & "' chưa tồn tại. Vui lòng nhập đúng mã KH có trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            Else
                ' 1. Chèn vào bảng HoaDon nếu chưa tồn tại
                Dim sqlHoaDon As String = "IF NOT EXISTS (SELECT 1 FROM HoaDon WHERE MaHD = @MaHD) " &
                                      "INSERT INTO HoaDon (MaHD, MaKH, NgayLap, GioLap) VALUES (@MaHD, @MaKH, @NgayLap, @GioLap)"
                Dim cmdHD As New SqlCommand(sqlHoaDon, conn)
                cmdHD.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
                cmdHD.Parameters.AddWithValue("@MaKH", txtMaKH.Text)
                cmdHD.Parameters.AddWithValue("@NgayLap", DateTime.Parse(txtNgayLap.Text))
                cmdHD.Parameters.AddWithValue("@GioLap", TimeSpan.Parse(txtGioLap.Text))
                cmdHD.ExecuteNonQuery()

                ' 2. Chèn vào bảng ChiTietHoaDon
                Dim cmd As New SqlCommand(sqlCTHD, conn)
                cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                cmd.Parameters.AddWithValue("@SoLuong", Integer.Parse(txtSoLuong.Text))

                Dim donGia As Decimal = Decimal.TryParse(txtDonGia.Text.Replace(",", ""), 0)
                cmd.Parameters.AddWithValue("@DonGia", donGia)

                cmd.ExecuteNonQuery()

                MessageBox.Show("Thêm hóa đơn thành công.")
                LoadData()
            End If
        End Using
    End Sub


    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaHD.Text = "" Then
            MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim f As New ThuVien()
            Dim sql As String = "DELETE FROM ChiTietHoaDon WHERE MaHD=@MaHD"
            Using conn As SqlConnection = f.KetNoi()
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Xóa hóa đơn thành công.")
                    LoadData()
                    ClearText()
                Catch ex As Exception
                    MessageBox.Show("Lỗi: " & ex.Message)
                End Try
            End Using
        End If
    End Sub
    Private Sub SinhMaHoaDonVaKhachHangTuDong()
        Dim f As New ThuVien()
        Dim conn As SqlConnection = f.KetNoi()

        '--- Sinh Mã Hóa Đơn ---
        Dim maHD As String = "HD1"
        Dim cmdHD As New SqlCommand("SELECT TOP 1 MaHD FROM HoaDon ORDER BY CAST(SUBSTRING(MaHD, 3, LEN(MaHD)) AS INT) DESC", conn)
        Dim readerHD As SqlDataReader = cmdHD.ExecuteReader()
        If readerHD.Read() Then
            Dim maCuoi As String = readerHD("MaHD").ToString()
            Dim so As Integer = Integer.Parse(maCuoi.Substring(2)) + 1
            maHD = "HD" & so.ToString("D1") ' D3 = 3 chữ số, ví dụ: HD001, HD010, HD123
        End If
        readerHD.Close()

        '--- Sinh mã khách hàng ---
        Dim cmdKH As New SqlCommand("
    SELECT TOP 1 MaKH 
    FROM KhachHang 
    ORDER BY NEWID()", conn)

        Dim readerKH As SqlDataReader = cmdKH.ExecuteReader()
        Dim maKH As String = ""
        If readerKH.Read() Then
            maKH = readerKH("MaKH").ToString()
            txtMaKH.Text = maKH
        Else
            MessageBox.Show("Không tìm thấy mã khách hàng.", "Thông báo")
            txtMaKH.Text = ""
        End If
        readerKH.Close()



        conn.Close()

        ' Gán vào TextBox
        txtMaHD.Text = maHD

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()

        ' Gọi hàm sinh mã tự động cho cả hóa đơn và khách hàng
        SinhMaHoaDonVaKhachHangTuDong()

        ' Ngày và giờ hiện tại
        txtNgayLap.Text = DateTime.Now.ToString("yyyy-MM-dd")
        txtGioLap.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub
    Private Sub dgChiTietHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgChiTietHoaDon.CellClick, dgSanPham.CellClick
        If e.RowIndex >= 0 Then
            txtMaHD.Text = dgChiTietHoaDon.Rows(e.RowIndex).Cells("MaHD").Value.ToString()
            txtMaSP.Text = dgChiTietHoaDon.Rows(e.RowIndex).Cells("MaSP").Value.ToString()
            txtSoLuong.Text = dgChiTietHoaDon.Rows(e.RowIndex).Cells("SoLuong").Value.ToString()
            txtDonGia.Text = dgChiTietHoaDon.Rows(e.RowIndex).Cells("DonGia").Value.ToString()
            txtThanhTien.Text = dgChiTietHoaDon.Rows(e.RowIndex).Cells("ThanhTien").Value.ToString()

        End If
    End Sub
    Private Sub txtMaSP_Leave(sender As Object, e As EventArgs) Handles txtMaSP.Leave
        LayDonGiaVaTinhTien()
    End Sub
    Private Sub txtSoLuong_TextChanged(sender As Object, e As EventArgs) Handles txtSoLuong.TextChanged
        LayDonGiaVaTinhTien()
    End Sub
    Private Sub LayDonGiaVaTinhTien()
        If txtMaSP.Text = "" OrElse Not IsNumeric(txtSoLuong.Text) Then
            txtDonGia.Text = ""
            txtThanhTien.Text = ""
            Return
        End If

        Dim f As New ThuVien()
        Using conn As SqlConnection = f.KetNoi()
            Dim cmd As New SqlCommand("SELECT DonGia FROM SanPham WHERE MaSP = @MaSP", conn)
            cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text)

            Try
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    If Not IsDBNull(reader("DonGia")) Then
                        Dim donGia As Decimal = Convert.ToDecimal(reader("DonGia"))
                        txtDonGia.Text = donGia.ToString("N0") ' Định dạng tiền
                        Dim soLuong As Integer
                        If Integer.TryParse(txtSoLuong.Text, soLuong) Then
                            Dim thanhTien = donGia * soLuong
                            txtThanhTien.Text = thanhTien.ToString("N0")
                        End If
                    End If
                Else
                    txtDonGia.Text = "0"
                    txtThanhTien.Text = "0"
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Lỗi khi truy vấn đơn giá: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaHD.Text = "" Or txtMaSP.Text = "" Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.")
            Return
        End If

        Dim f As New ThuVien()
        Dim sql As String = "UPDATE ChiTietHoaDon SET MaSP=@MaSP, SoLuong=@SoLuong, DonGia=@DonGia WHERE MaHD=@MaHD "

        Using conn As SqlConnection = f.KetNoi()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaHD", txtMaHD.Text)
            cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            cmd.Parameters.AddWithValue("@SoLuong", Integer.Parse(txtSoLuong.Text))
            cmd.Parameters.AddWithValue("@DonGia", Decimal.Parse(txtDonGia.Text.Replace(",", "")))

            Try
                Dim rowsAffected = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Cập nhật sản phẩm thành công.")
                Else
                    MessageBox.Show("Không tìm thấy dòng dữ liệu cần sửa.")
                End If
                LoadData()
                ClearText()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub


End Class