

CREATE TABLE SanPham (
    MaSP NVARCHAR(10) PRIMARY KEY,
    TenSP NVARCHAR(100) NOT NULL,
    Size NVARCHAR(10),
    MauSac NVARCHAR(50),
    SoLuong INT,
    DonGia DECIMAL(18,2)
);

-- Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKH NVARCHAR(10) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15),
    DiaChi NVARCHAR(200)
);

-- Bảng Hóa đơn
CREATE TABLE HoaDon (
    MaHD NVARCHAR(10) PRIMARY KEY,
    MaKH NVARCHAR(10) FOREIGN KEY REFERENCES KhachHang(MaKH),
    NgayLap DATE NOT NULL,
    GioLap TIME NOT NULL,
    SoTien DECIMAL(18,2)
);

-- Bảng Chi tiết hóa đơn
-- Tạo bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaHD NVARCHAR(10),
    MaSP NVARCHAR(10),
    SoLuong INT,
    DonGia DECIMAL(18,2),
    ThanhTien AS (SoLuong * DonGia) PERSISTED,
    PRIMARY KEY (MaHD, MaSP),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);
GO

-- Tạo trigger cập nhật đơn giá
CREATE TRIGGER trg_UpdateDonGia
ON ChiTietHoaDon
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE CTHD
    SET DonGia = SP.DonGia
    FROM ChiTietHoaDon CTHD
    INNER JOIN inserted i ON CTHD.MaHD = i.MaHD AND CTHD.MaSP = i.MaSP
    INNER JOIN SanPham SP ON i.MaSP = SP.MaSP;
END;
GO

CREATE TRIGGER trg_CapNhatSoTienHoaDon
ON ChiTietHoaDon
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật lại tổng tiền cho các hóa đơn bị ảnh hưởng
    UPDATE HD
    SET SoTien = (
        SELECT SUM(ThanhTien)
        FROM ChiTietHoaDon
        WHERE MaHD = HD.MaHD
    )
    FROM HoaDon HD
    WHERE HD.MaHD IN (
        SELECT DISTINCT MaHD FROM inserted
        UNION
        SELECT DISTINCT MaHD FROM deleted
    );
END;


INSERT INTO SanPham (MaSP, TenSP, Size, MauSac, SoLuong, DonGia) VALUES
('SP1', N'Áo Thun Nam', 'M', N'Đen', 50, 150000),
('SP2', N'Áo Sơ Mi Nữ', 'L', N'Trắng', 30, 220000),
('SP3', N'Quần Jeans Nam', '32', N'Xanh', 40, 350000),
('SP4', N'Váy Xòe Nữ', 'M', N'Hồng', 25, 400000),
('SP5', N'Áo Khoác Nam', 'XL', N'Xám', 20, 500000),
('SP6', N'Chân Váy Nữ', 'S', N'Be', 35, 270000);

-- Thêm khách hàng
INSERT INTO KhachHang (MaKH, TenKH, SDT, DiaChi) VALUES
('KH1', N'Nguyễn Văn Mạnh', '0901234567', N'Hà Nội'),
('KH2', N'Trần Thị Bình', '0912345678', N'TP. Hồ Chí Minh'),
('KH3', N'Lê Văn Chinh', '0923456789', N'Đà Nẵng'),
('KH4', N'Phạm Thị Duyên', '0934567890', N'Hải Phòng'),
('KH5', N'Hoàng Văn Anh', '0945678901', N'Cần Thơ'),
('KH6', N'Vũ Thị Vu', '0956789012', N'Bình Dương');

-- Thêm hóa đơn
INSERT INTO HoaDon (MaHD, MaKH, NgayLap, GioLap, SoTien) VALUES
('HD1', 'KH1', '2025-05-01', '09:15:00', 1000000),
('HD2', 'KH2', '2025-05-02', '10:30:00', 400000),
('HD3', 'KH3', '2025-05-03', '14:45:00', 440000),
('HD4', 'KH4', '2025-05-04', '16:10:00', 400000),
('HD5', 'KH5', '2025-05-05', '11:00:00', 440000),
('HD6', 'KH6', '2025-05-06', '13:25:00', 270000);

-- Thêm chi tiết hóa đơn
INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES
('HD1', 'SP5', 2, 5000000),
('HD2', 'SP4', 1, 400000),
('HD3', 'SP2', 2, 220000),
('HD4', 'SP4', 1, 400000),
('HD5', 'SP2', 2, 220000),
('HD6', 'SP6', 1, 270000);
UPDATE ChiTietHoaDon
SET MaSP = 'SP2'
WHERE MaHD = 'HD2' AND MaSP = 'SP4';
CREATE TABLE NguoiDung (
    ID INT IDENTITY PRIMARY KEY,
    
    TenDangNhap NVARCHAR(50) NOT NULL,
    SDT VARCHAR(15),
    MatKhau NVARCHAR(50) NOT NULL
);

INSERT INTO NguoiDung (TenDangNhap, SDT, MatKhau)
VALUES (N'admin','0989898131', N'123456')
CREATE TABLE ThongKeDoanhThu (
    ID INT IDENTITY PRIMARY KEY,
    TuNgay DATE NOT NULL,
    DenNgay DATE NOT NULL,
    TongDoanhThu DECIMAL(18,2) NOT NULL
);
SELECT 
    HD.MaHD,
    KH.TenKH,
    HD.NgayLap,
    HD.SoTien
FROM HoaDon HD
JOIN KhachHang KH ON HD.MaKH = KH.MaKH
WHERE HD.NgayLap BETWEEN @TuNgay AND @DenNgay

go
CREATE PROCEDURE sp_ThongKe_DoanhThu
    @TuNgay DATE,
    @DenNgay DATE
AS
BEGIN
    DECLARE @TongDoanhThu DECIMAL(18,2)

    -- Tính tổng doanh thu trong khoảng thời gian
    SELECT @TongDoanhThu = SUM(SoTien)
    FROM HoaDon
    WHERE NgayLap BETWEEN @TuNgay AND @DenNgay;

    -- Nếu không có dữ liệu thì gán 0
    IF @TongDoanhThu IS NULL
        SET @TongDoanhThu = 0;

    -- Chèn vào bảng thống kê
    INSERT INTO ThongKeDoanhThu (TuNgay, DenNgay, TongDoanhThu)
    VALUES (@TuNgay, @DenNgay, @TongDoanhThu);
END;
EXEC sp_ThongKe_DoanhThu '2025-05-01', '2025-05-10';
SELECT * FROM ThongKeDoanhThu;
SELECT 
    HD.MaHD,
    KH.TenKH,
    HD.NgayLap,
    HD.SoTien
FROM HoaDon HD
JOIN KhachHang KH ON HD.MaKH = KH.MaKH
WHERE HD.NgayLap BETWEEN @TuNgay AND @DenNgay