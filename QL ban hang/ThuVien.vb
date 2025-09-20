Imports System.Data.SqlClient
Imports System.Data

Public Class ThuVien

    ' 1. Hàm Kết Nối - Trả về một SqlConnection đang mở
    Public Function KetNoi() As SqlConnection
        Dim duongDan As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\QLBanQuanAo1.mdf;Integrated Security=True;Connect Timeout=30"
        Dim conn As New SqlConnection(duongDan)
        Try
            conn.Open()
            ' MessageBox.Show("OK")
        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối: " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return conn
    End Function

    ' 2. Hàm lấy dữ liệu - Trả về DataTable từ câu truy vấn
    Public Function LayDuLieu(cauTruyVan As String) As DataTable
        Dim dt As New DataTable()
        Using conn As SqlConnection = KetNoi()
            Try
                Dim cmd As New SqlCommand(cauTruyVan, conn)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            Catch ex As Exception
                MessageBox.Show("Lỗi lấy dữ liệu: " & ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
        Return dt
    End Function

    ' 3. Hàm gán nguồn cho DataGridView
    Public Sub GanNguonDataGridView(dgv As DataGridView, cauTruyVan As String)
        Dim dt As DataTable = LayDuLieu(cauTruyVan)
        dgv.DataSource = dt
    End Sub

End Class
