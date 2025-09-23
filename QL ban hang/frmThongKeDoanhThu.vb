Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmThongKeDoanhThu

    ' ✅ Chuỗi kết nối trỏ về đúng file .mdf chứa bảng HoaDon
    Private ReadOnly connectionString As String =
        "Data Source=(LocalDB)\MSSQLLocalDB;" &
        "AttachDbFilename=C:\Users\Admin\Downloads\QL BAN HANG\QL BAN HANG\bin\Debug\QLBANQUANAO1.mdf;" &
        "Integrated Security=True;Connect Timeout=30"

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim tuNgay As Date = dtpTuNgay.Value.Date
        Dim denNgay As Date = dtpDenNgay.Value.Date

        Dim tongDoanhThu As Decimal = 0

        Dim query As String = "SELECT HD.MaHD, KH.TenKH, HD.NgayLap, HD.SoTien " &
                              "FROM HoaDon HD " &
                              "JOIN KhachHang KH ON HD.MaKH = KH.MaKH " &
                              "WHERE HD.NgayLap BETWEEN @TuNgay AND @DenNgay"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay)
                cmd.Parameters.AddWithValue("@DenNgay", denNgay)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()

                Try
                    conn.Open()
                    adapter.Fill(table)
                    dgvThongKe.DataSource = table

                    ' Tính tổng doanh thu
                    For Each row As DataRow In table.Rows
                        If Not IsDBNull(row("SoTien")) Then
                            tongDoanhThu += Convert.ToDecimal(row("SoTien"))
                        End If
                    Next

                    iblTongDoanhThu.Text = "Tổng doanh thu: " & tongDoanhThu.ToString("N0") & " VND"
                Catch ex As Exception
                    MessageBox.Show("Lỗi khi thống kê: " & ex.Message,
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub frmThongKeDoanhTHu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New ThuVien()
        f.GanNguonDataGridView(dgvThongKe, "SELECT * FROM HoaDon") ' ✅ Dùng HoaDon chứ không phải ThongKeDoanhThu
    End Sub

    Private Sub btnXuatExcel_Click(sender As Object, e As EventArgs) Handles btnXuatExcel.Click
        ' Khởi tạo Excel
        Dim excelApp As New Excel.Application
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add(Type.Missing)
        Dim worksheet As Excel.Worksheet = workbook.ActiveSheet
        worksheet.Name = "ThongKeDoanhThu"

        ' Xuất tiêu đề cột
        For i As Integer = 1 To dgvThongKe.Columns.Count
            worksheet.Cells(1, i) = dgvThongKe.Columns(i - 1).HeaderText
        Next

        ' Xuất nội dung dữ liệu
        For i As Integer = 0 To dgvThongKe.Rows.Count - 1
            For j As Integer = 0 To dgvThongKe.Columns.Count - 1
                worksheet.Cells(i + 2, j + 1) = dgvThongKe.Rows(i).Cells(j).Value?.ToString()
            Next
        Next

        ' Hiển thị Excel
        excelApp.Visible = True


    End Sub

End Class
