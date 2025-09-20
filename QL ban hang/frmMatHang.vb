Imports System.Data.SqlClient

Public Class frmMatHang
    Private Sub frmMatHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New ThuVien()
        f.GanNguonDataGridView(dgSanPham, "Select * from SanPham")
    End Sub

    Private Sub LoadData()
        Dim f As New ThuVien()
        f.GanNguonDataGridView(dgSanPham, "SELECT * FROM SanPham")
    End Sub

    Private Sub ClearText()
        txtMaSP.Text = ""
        txtTenSP.Text = ""
        txtSize.Text = ""
        txtMauSac.Text = ""
        txtSoLuong.Text = ""
        txtDonDia.Text = ""
        txtMaSP.Focus()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        If txtMaSP.Text = "" Or txtTenSP.Text = "" Or txtSize.Text = "" Or txtMauSac.Text = "" Or txtSoLuong.Text = "" Or txtDonDia.Text = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim f As New ThuVien()
        Dim sql As String = "INSERT INTO SanPham (MaSP,TenSP, Size, MauSac, SoLuong, DonGia) VALUES (@MaSP, @TenSP, @Size, @MauSac, @SoLuong, @DonGia)"
        Using conn As SqlConnection = f.KetNoi()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            cmd.Parameters.AddWithValue("@Size", txtSize.Text)
            cmd.Parameters.AddWithValue("@MauSac", txtMauSac.Text)
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            cmd.Parameters.AddWithValue("@DonGia", txtDonDia.Text)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Thêm sản phẩm thành công.")
                LoadData()
                ClearText()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If msp.Text = "" Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.")
            Return
        End If

        Dim f As New ThuVien()
        Dim sql As String = "UPDATE SanPham SET TenSP=@TenSP, Size=@Size, MauSac=@MauSac, SoLuong=@SoLuong, DonGia=@DonGia WHERE MaSP=@MaSP"
        Using conn As SqlConnection = f.KetNoi()
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            cmd.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            cmd.Parameters.AddWithValue("@Size", txtSize.Text)
            cmd.Parameters.AddWithValue("@MauSac", txtMauSac.Text)
            cmd.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            cmd.Parameters.AddWithValue("@DonGia", txtDonDia.Text)
            Try
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cập nhật sản phẩm thành công.")
                LoadData()
                ClearText()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaSP.Text = "" Then
            MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.")
            Return
        End If

        If MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim f As New ThuVien()
            Dim sql As String = "DELETE FROM SanPham WHERE MaSP=@MaSP"
            Using conn As SqlConnection = f.KetNoi()
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
                Try
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Xóa sản phẩm thành công.")
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

    Private Sub dgSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSanPham.CellClick
        If e.RowIndex >= 0 Then
            txtMaSP.Text = dgSanPham.Rows(e.RowIndex).Cells("MaSP").Value.ToString()
            txtTenSP.Text = dgSanPham.Rows(e.RowIndex).Cells("TenSP").Value.ToString()
            txtSize.Text = dgSanPham.Rows(e.RowIndex).Cells("Size").Value.ToString()
            txtMauSac.Text = dgSanPham.Rows(e.RowIndex).Cells("MauSac").Value.ToString()
            txtSoLuong.Text = dgSanPham.Rows(e.RowIndex).Cells("SoLuong").Value.ToString()
            txtDonDia.Text = dgSanPham.Rows(e.RowIndex).Cells("DonGia").Value.ToString()
        End If
    End Sub
End Class