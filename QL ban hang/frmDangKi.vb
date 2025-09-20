Imports System.Data.SqlClient

Public Class frmDangKi
    Private Sub btnDangKy_Click(sender As Object, e As EventArgs) Handles btnDangKy.Click
        Dim user As String = txtTenDangNhap.Text.Trim()
        Dim phone As String = txtSoDienThoai.Text.Trim()
        Dim pass As String = txtMatKhau.Text.Trim()

        If user = "" Or pass = "" Then
            MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim f As New ThuVien()
        Try
            Using conn As SqlConnection = f.KetNoi()
                ' Kiểm tra tài khoản đã tồn tại chưa
                Dim checkQuery As String = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap = @user"
                Using checkCmd As New SqlCommand(checkQuery, conn)
                    checkCmd.Parameters.AddWithValue("@user", user)
                    Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                    If exists > 0 Then
                        MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End Using

                ' Thêm tài khoản mới
                Dim insertQuery As String = "INSERT INTO NguoiDung (TenDangNhap, SDT, MatKhau) VALUES (@user, @phone, @pass)"
                Using insertCmd As New SqlCommand(insertQuery, conn)
                    insertCmd.Parameters.AddWithValue("@user", user)
                    insertCmd.Parameters.AddWithValue("@phone", phone)
                    insertCmd.Parameters.AddWithValue("@pass", pass)

                    Dim rowsAffected As Integer = insertCmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Hiển thị ảnh trong chính frmDangKi (giả sử ảnh là 123456 trong Resources)
                        Try
                            ' Ví dụ: PictureBox1.Image = My.Resources._123456
                        Catch ex As Exception
                            MessageBox.Show("Không thể tải ảnh từ Resources: " & ex.Message)
                        End Try

                        ' Tự động đóng form đăng ký sau khi nhấn OK
                        Me.Close()

                    Else
                        MessageBox.Show("Đăng ký thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub frmDangKy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMatKhau.UseSystemPasswordChar = True
    End Sub
End Class
