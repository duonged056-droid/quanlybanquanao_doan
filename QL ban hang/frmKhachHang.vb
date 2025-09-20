Imports System.Data.SqlClient
Public Class frmKhachHang
    Private Sub frmKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New ThuVien()
        f.GanNguonDataGridView(dgKhachHang, "Select * from KhachHang")
    End Sub
    Private Sub LoadData()
        Dim f As New ThuVien()
        f.GanNguonDataGridView(dgKhachHang, "SELECT * FROM KhachHang")
    End Sub


    ' Xóa trắng các TextBox
    Private Sub ClearText()
        txtMaKhach.Text = ""
        txtTenKhach.Text = ""
        txtSoDienThoai.Text = ""
        txtDiaChi.Text = ""
        txtMaKhach.Focus()
    End Sub
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtMaKhach.Text = "" Or txtTenKhach.Text = "" Or txtSoDienThoai.Text = "" Or txtDiaChi.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim f As New ThuVien()
        Dim sql As String = "INSERT INTO KhachHang (MaKH, TenKH, SDT, DiaChi) VALUES (@MaKH, @TenKH, @SDT, @DiaChi)"
        Using conn As SqlConnection = f.KetNoi()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaKH", txtMaKhach.Text)
            cmd.Parameters.AddWithValue("@TenKH", txtTenKhach.Text)
            cmd.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text)
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Thêm khách hàng thành công.")
                LoadData()
                ClearText()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtMaKhach.Text = "" Then
            MessageBox.Show("Vui lòng chọn khách hàng cần sửa.")
            Return
        End If

        Dim sql As String = "UPDATE KhachHang SET TenKH=@TenKH, SDT=@SDT,DiaChi=@DiaChi  WHERE MaKH=@MaKH"
        Dim f As New ThuVien()
        Using conn As SqlConnection = f.KetNoi()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaKH", txtMaKhach.Text)
            cmd.Parameters.AddWithValue("@TenKH", txtTenKhach.Text)
            cmd.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text)
            cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cập nhật thành công.")
                LoadData()
                ClearText()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaKhach.Text = "" Then
            MessageBox.Show("Vui lòng chọn khách hàng cần xóa.")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim sql As String = "DELETE FROM KhachHang WHERE MaKH=@MaKH"
            Dim f As New ThuVien()
            Using conn As SqlConnection = f.KetNoi()
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaKH", txtMaKhach.Text)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Đã xóa thành công.")
                    LoadData()
                    ClearText()
                Catch ex As Exception
                    MessageBox.Show("Lỗi: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearText()
    End Sub

    Private Sub dgKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKhachHang.CellClick
        If e.RowIndex >= 0 Then
            txtMaKhach.Text = dgKhachHang.Rows(e.RowIndex).Cells("MaKH").Value.ToString()
            txtTenKhach.Text = dgKhachHang.Rows(e.RowIndex).Cells("TenKH").Value.ToString()
            txtSoDienThoai.Text = dgKhachHang.Rows(e.RowIndex).Cells("SDT").Value.ToString()
            txtDiaChi.Text = dgKhachHang.Rows(e.RowIndex).Cells("DiaChi").Value.ToString()
        End If
    End Sub

    Private Sub dgKhachHang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKhachHang.CellContentClick

    End Sub
End Class