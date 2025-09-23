Imports System.Data.SqlClient
Imports System.Data

Public Class ThuVien

    ' 1. Hàm Kết Nối - Trả về một SqlConnection đang mở
    Public Function KetNoi() As SqlConnection
        ' Sử dụng đường dẫn tuyệt đối tới file .mdf thực tế
        Dim duongDan As String =
            "Data Source=(LocalDB)\MSSQLLocalDB;" &
            "AttachDbFilename=C:\Users\Admin\Downloads\QL BAN HANG\QL BAN HANG\bin\Debug\QLBANQUANAO1.mdf;" &
            "Integrated Security=True;Connect Timeout=30"

        Dim conn As New SqlConnection(duongDan)

        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối CSDL: " & ex.Message,
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return conn
    End Function

    ' 2. Hàm lấy dữ liệu - Trả về DataTable từ câu truy vấn
    Public Function LayDuLieu(cauTruyVan As String,
                              Optional thamSo As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn As SqlConnection = KetNoi()
            Try
                Using cmd As New SqlCommand(cauTruyVan, conn)
                    ' Nếu có tham số thì add vào
                    If thamSo IsNot Nothing Then
                        cmd.Parameters.AddRange(thamSo.ToArray())
                    End If

                    Dim da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi lấy dữ liệu: " & ex.Message,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return dt
    End Function

    ' 3. Hàm thực thi lệnh INSERT, UPDATE, DELETE - trả về số dòng ảnh hưởng
    Public Function ThucThi(cauLenh As String,
                            Optional thamSo As List(Of SqlParameter) = Nothing) As Integer
        Dim ketQua As Integer = 0
        Using conn As SqlConnection = KetNoi()
            Try
                Using cmd As New SqlCommand(cauLenh, conn)
                    If thamSo IsNot Nothing Then
                        cmd.Parameters.AddRange(thamSo.ToArray())
                    End If
                    ketQua = cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("Lỗi thực thi SQL: " & ex.Message,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return ketQua
    End Function

    ' 4. Hàm gán dữ liệu vào DataGridView
    Public Sub GanNguonDataGridView(dgv As DataGridView, cauTruyVan As String,
                                    Optional thamSo As List(Of SqlParameter) = Nothing)
        Dim dt As DataTable = LayDuLieu(cauTruyVan, thamSo)
        dgv.DataSource = dt
    End Sub

End Class
