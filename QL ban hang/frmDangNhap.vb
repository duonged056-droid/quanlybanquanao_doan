Imports System.Data.SqlClient

Public Class frmDangNhap
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        Dim user As String = txtTenDangNhap.Text.Trim()
        Dim pass As String = txtMatKhau.Text.Trim()

        If user = "" Or pass = "" Then
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Kết nối DB
        Dim f As New ThuVien() ' Class kết nối bạn đã tạo

        Try
            Using conn As SqlConnection = f.KetNoi()
                Dim sql As String = "SELECT COUNT(*) FROM NguoiDung WHERE TenDangNhap=@user AND MatKhau=@pass"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.Parameters.AddWithValue("@pass", pass)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Đánh dấu trạng thái đã đăng nhập
                        Form1.IsLoggedIn = True

                        ' Ẩn form đăng nhập
                        Me.Hide()

                        ' Mở form chính
                        Form1.Show()
                    Else
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối CSDL: " & ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

    Private Sub frmDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMatKhau.UseSystemPasswordChar = True
    End Sub

    Private Sub txtDangKi_Click(sender As Object, e As EventArgs) Handles txtDangKi.Click
        Dim f As New frmDangKi
        f.Show()
    End Sub
End Class
