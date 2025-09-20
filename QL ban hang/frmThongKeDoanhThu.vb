Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmThongKeDoanhThu

    Private Sub btnThongKe_Click(sender As Object, e As EventArgs) Handles btnThongKe.Click
        Dim tuNgay As Date = dtpTuNgay.Value.Date
        Dim denNgay As Date = dtpDenNgay.Value.Date

        Dim tongDoanhThu As Decimal = 0

        Dim query As String = "SELECT HD.MaHD, KH.TenKH, HD.NgayLap, HD.SoTien " &
                              "FROM HoaDon HD " &
                              "JOIN KhachHang KH ON HD.MaKH = KH.MaKH " &
                              "WHERE HD.NgayLap BETWEEN @TuNgay AND @DenNgay"
        Using conn As New SqlConnection("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLBanQuanAo1;Integrated Security=True")
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay)
                cmd.Parameters.AddWithValue("@DenNgay", denNgay)

                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()

                adapter.Fill(table)
                dgvThongKe.DataSource = table

                ' Tính tổng doanh thu
                For Each row As DataRow In table.Rows
                    If Not IsDBNull(row("SoTien")) Then
                        tongDoanhThu += Convert.ToDecimal(row("SoTien"))
                    End If
                Next

                iblTongDoanhThu.Text = "Tổng doanh thu: " & tongDoanhThu.ToString("N0") & " VND"
            End Using
        End Using
    End Sub
    Private Sub frmThongKeDoanhTHu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New ThuVien()
        f.GanNguonDataGridView(dgvThongKe, "Select * from ThongKeDoanhThu")
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

        ' Giải phóng tài nguyên nếu không cần giữ Excel mở
        ' workbook.Close()
        ' excelApp.Quit()
    End Sub
End Class