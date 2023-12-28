/*Câu 1: Tạo hàm có đầu vào là tháng đầu ra là thông tin các hóa đơn trong tháng đó.*/
CREATE OR ALTER FUNCTION DTM2_C1(@Thang int, @Nam int)
RETURNS TABLE AS
RETURN
(
	SELECT SoHDB AS SoHD, NgayBan AS NgayLapHoaDon, 'HDB' AS LoaiHD
	FROM tHoaDonBan
	WHERE YEAR(NgayBan) = @Nam AND MONTH(NgayBan) = @Thang
	UNION
	SELECT SoHDN, NgayNhap, 'HDN'
	FROM tHoaDonNhap
	WHERE YEAR(NgayNhap) = @Nam AND MONTH(NgayNhap) = @Thang
)
GO 
SELECT * FROM DTM2_C1(6, 2014)
GO

/*Câu 2: Tạo thủ tục có đầu vào là mã nhân viên, đầu ra là số lượng hóa đơn nhập, số
lượng hóa đơn bán mà nhân viên đó xử lý.*/
CREATE OR ALTER PROCEDURE DTM2_C2 @MaNV nvarchar(10), @SLHDN int OUTPUT, @SLHDB int OUTPUT
AS
BEGIN
	SELECT @SLHDN = COUNT(SoHDN) FROM tHoaDonNhap WHERE MaNV = @MaNV
	SELECT @SLHDB = COUNT(SoHDB) FROM tHoaDonBan WHERE MaNV = @MaNV
END
GO
DECLARE @SLHDN int, @SLHDB int
EXEC DTM2_C2 'NV027', @SLHDN OUTPUT, @SLHDB OUTPUT
PRINT N'Số Hóa đơn nhập: ' + CAST(@SLHDN AS nvarchar(10))
PRINT N'Số Hóa đơn bán: ' + CAST(@SLHDB AS nvarchar(10))
GO

/*Câu 3: Tạo view đưa ra thông tin các khách hàng và thông tin hóa đơn, trị giá hóa đơn
họ đã mua trong năm 2014*/
CREATE OR ALTER VIEW DTM2_C3
AS
SELECT tKhachHang.MaKH, TenKH, tHoaDonBan.SoHDB, NgayBan, SUM(SLBan * DonGiaBan) TriGiaHoaDon
FROM tKhachHang JOIN tHoaDonBan 
ON tKhachHang.MaKH = tHoaDonBan.MaKH JOIN tChiTietHDB
ON tChiTietHDB.SoHDB = tHoaDonBan.SoHDB JOIN tSach
ON tSach.MaSach = tChiTietHDB.MaSach
WHERE YEAR(NgayBan) = 2014
GROUP BY tKhachHang.MaKH, TenKH, tHoaDonBan.SoHDB, NgayBan
GO
SELECT * FROM DTM2_C3

/*Câu 4: Thêm trường Tổng số đầu sách vào bảng thể loại, cập nhật tự động cho trường
này mỗi khi thêm, sửa, xóa một bản ghi sách*/
ALTER TABLE tTheLoai
ADD TongDauSach int
GO 

/*UPDATE tTheLoai
SET TongDauSach = ISNULL((SELECT COUNT(MaSach)
						 FROM tSach
						 WHERE tTheLoai.MaTheLoai = A.MaTheLoai), 0)
SELECT * FROM tTheLoai*/
CREATE OR ALTER TRIGGER DTM2_C4 ON tSach
FOR INSERT, UPDATE, DELETE AS
BEGIN
	DECLARE @MaTheLoaiIn nvarchar(10), @MaTheLoaiDe nvarchar(10)
	SELECT @MaTheLoaiIn = MaTheLoai FROM inserted
	SELECT @MaTheLoaiDe = MaTheLoai FROM deleted
	UPDATE tTheLoai SET TongDauSach = ISNULL(TongDauSach, 0) + 1 WHERE MaTheLoai = @MaTheLoaiIn
	UPDATE tTheLoai SET TongDauSach = ISNULL(TongDauSach, 0) - 1 WHERE MaTheLoai = @MaTheLoaiDe
END
SELECT * FROM tTheLoai
/*Câu 5: Tạo login TranThanhPhong, tạo user TranThanhPhong cho TranThanhPhong
trên CSDL QLBanSach
Phân quyền Select, update trên bảng tSach cho TranThanhPhong và TranThanhPhong
được phép phân quyền cho người khác
Đăng nhập TranThanhPhong để kiểm tra
Tạo login PhamVanNam, tạo PhamVanNam cho PhamVanNam trên CSDL QLBanSach
Đăng nhập PhamVanNam để kiểm tra
Từ login TranThanhPhong, phân quyền Select trên bảng tSach cho PhamVanNam
Đăng nhập PhamVanNam để kiểm tra*/

/*Câu 6: Tạo view đưa ra những khách hàng có tổng số lượng hóa đơn cao nhất và cao
nhì trong năm 2014*/
CREATE OR ALTER VIEW DTM2_C6
AS
SELECT TOP 2 tKhachHang.MaKH, TenKH, COUNT(SoHDB) TongSoHoaDon
FROM tKhachHang JOIN tHoaDonBan
ON tKhachHang.MaKH = tHoaDonBan.MaKH
WHERE YEAR(NgayBan) = 2014
GROUP BY tKhachHang.MaKH, TenKH
HAVING COUNT(SoHDB) IN (SELECT DISTINCT TOP 2 COUNT(SoHDB)
						FROM tHoaDonBan
						WHERE YEAR(NgayBan) = 2014
						GROUP BY MaKH
						ORDER BY 1 DESC)
GO
SELECT * FROM DTM2_C6 ORDER BY 3 DESC



