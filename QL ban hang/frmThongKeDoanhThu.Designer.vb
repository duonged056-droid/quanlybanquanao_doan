<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongKeDoanhThu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTuNgay = New System.Windows.Forms.DateTimePicker()
        Me.dtpDenNgay = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvThongKe = New System.Windows.Forms.DataGridView()
        Me.iblTongDoanhThu = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnThongKe = New System.Windows.Forms.Button()
        Me.btnXuatExcel = New System.Windows.Forms.Button()
        CType(Me.dgvThongKe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thống Kê Doanh Thu"
        '
        'dtpTuNgay
        '
        Me.dtpTuNgay.Location = New System.Drawing.Point(32, 77)
        Me.dtpTuNgay.Name = "dtpTuNgay"
        Me.dtpTuNgay.Size = New System.Drawing.Size(200, 20)
        Me.dtpTuNgay.TabIndex = 1
        '
        'dtpDenNgay
        '
        Me.dtpDenNgay.Location = New System.Drawing.Point(268, 77)
        Me.dtpDenNgay.Name = "dtpDenNgay"
        Me.dtpDenNgay.Size = New System.Drawing.Size(200, 20)
        Me.dtpDenNgay.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Từ ngày"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(247, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Đến ngày"
        '
        'dgvThongKe
        '
        Me.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvThongKe.Location = New System.Drawing.Point(12, 133)
        Me.dgvThongKe.Name = "dgvThongKe"
        Me.dgvThongKe.Size = New System.Drawing.Size(456, 150)
        Me.dgvThongKe.TabIndex = 3
        '
        'iblTongDoanhThu
        '
        Me.iblTongDoanhThu.AutoSize = True
        Me.iblTongDoanhThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.iblTongDoanhThu.Location = New System.Drawing.Point(315, 315)
        Me.iblTongDoanhThu.Name = "iblTongDoanhThu"
        Me.iblTongDoanhThu.Size = New System.Drawing.Size(13, 13)
        Me.iblTongDoanhThu.TabIndex = 2
        Me.iblTongDoanhThu.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(29, 315)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tổng Doanh Thu"
        '
        'btnThongKe
        '
        Me.btnThongKe.Location = New System.Drawing.Point(139, 389)
        Me.btnThongKe.Name = "btnThongKe"
        Me.btnThongKe.Size = New System.Drawing.Size(75, 23)
        Me.btnThongKe.TabIndex = 4
        Me.btnThongKe.Text = "Thống Kê"
        Me.btnThongKe.UseVisualStyleBackColor = True
        '
        'btnXuatExcel
        '
        Me.btnXuatExcel.Location = New System.Drawing.Point(292, 389)
        Me.btnXuatExcel.Name = "btnXuatExcel"
        Me.btnXuatExcel.Size = New System.Drawing.Size(75, 23)
        Me.btnXuatExcel.TabIndex = 4
        Me.btnXuatExcel.Text = "Xuất Excel"
        Me.btnXuatExcel.UseVisualStyleBackColor = True
        '
        'frmThongKeDoanhThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.btnXuatExcel)
        Me.Controls.Add(Me.btnThongKe)
        Me.Controls.Add(Me.dgvThongKe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.iblTongDoanhThu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDenNgay)
        Me.Controls.Add(Me.dtpTuNgay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmThongKeDoanhThu"
        Me.Text = "frmThongKeDoanhThu"
        CType(Me.dgvThongKe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTuNgay As DateTimePicker
    Friend WithEvents dtpDenNgay As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvThongKe As DataGridView
    Friend WithEvents iblTongDoanhThu As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnThongKe As Button
    Friend WithEvents btnXuatExcel As Button
End Class
