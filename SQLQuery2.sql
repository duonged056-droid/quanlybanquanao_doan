-- Xóa các object cũ nếu tồn tại
IF OBJECT_ID('ChiTietHoaDon', 'U') IS NOT NULL DROP TABLE ChiTietHoaDon;
IF OBJECT_ID('HoaDon', 'U') IS NOT NULL DROP TABLE HoaDon;
IF OBJECT_ID('KhachHang', 'U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('SanPham', 'U') IS NOT NULL DROP TABLE SanPham;
IF OBJECT_ID('NguoiDung', 'U') IS NOT NULL DROP TABLE NguoiDung;
IF OBJECT_ID('ThongKeDoanhThu', 'U') IS NOT NULL DROP TABLE ThongKeDoanhThu;
GO

-- Bảng Sản phẩm
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

-- Trigger cập nhật đơn giá
IF OBJECT_ID('trg_UpdateDonGia', 'TR') IS NOT NULL DROP TRIGGER trg_UpdateDonGia;
GO
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

-- Trigger cập nhật tổng tiền hóa đơn
IF OBJECT_ID('trg_CapNhatSoTienHoaDon', 'TR') IS NOT NULL DROP TRIGGER trg_CapNhatSoTienHoaDon;
GO
CREATE TRIGGER trg_CapNhatSoTienHoaDon
ON ChiTietHoaDon
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;
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
GO

-- Bảng người dùng
CREATE TABLE NguoiDung (
    ID INT IDENTITY PRIMARY KEY,
    TenDangNhap NVARCHAR(50) NOT NULL,
    SDT VARCHAR(15),
    MatKhau NVARCHAR(50) NOT NULL
);

-- Bảng thống kê doanh thu
CREATE TABLE ThongKeDoanhThu (
    ID INT IDENTITY PRIMARY KEY,
    TuNgay DATE NOT NULL,
    DenNgay DATE NOT NULL,
    TongDoanhThu DECIMAL(18,2) NOT NULL
);
GO

-- Thủ tục thống kê doanh thu
IF OBJECT_ID('sp_ThongKe_DoanhThu', 'P') IS NOT NULL DROP PROCEDURE sp_ThongKe_DoanhThu;
GO
CREATE PROCEDURE sp_ThongKe_DoanhThu
    @TuNgay DATE,
    @DenNgay DATE
AS
BEGIN
    DECLARE @TongDoanhThu DECIMAL(18,2);

    SELECT @TongDoanhThu = SUM(SoTien)
    FROM HoaDon
    WHERE NgayLap BETWEEN @TuNgay AND @DenNgay;

    IF @TongDoanhThu IS NULL
        SET @TongDoanhThu = 0;

    INSERT INTO ThongKeDoanhThu (TuNgay, DenNgay, TongDoanhThu)
    VALUES (@TuNgay, @DenNgay, @TongDoanhThu);

    -- Xuất dữ liệu
    SELECT HD.MaHD, KH.TenKH, HD.NgayLap, HD.SoTien
    FROM HoaDon HD
    JOIN KhachHang KH ON HD.MaKH = KH.MaKH
    WHERE HD.NgayLap BETWEEN @TuNgay AND @DenNgay;
END;
GO

-- Test dữ liệu
INSERT INTO SanPham VALUES
('SP1', N'Áo Thun Nam', 'M', N'Đen', 50, 150000),
('SP2', N'Áo Sơ Mi Nữ', 'L', N'Trắng', 30, 220000);

INSERT INTO KhachHang VALUES
('KH1', N'Nguyễn Văn Mạnh', '0901234567', N'Hà Nội');

INSERT INTO HoaDon VALUES
('HD1','KH1','2025-05-01','09:15:00',1000000);

INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
VALUES ('HD1','SP1',2,150000);

-- Gọi thủ tục
EXEC sp_ThongKe_DoanhThu '2025-05-01','2025-05-10';
SELECT * FROM ThongKeDoanhThu;
