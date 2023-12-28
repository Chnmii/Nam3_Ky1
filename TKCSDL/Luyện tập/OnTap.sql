--Câu 1: Tạo hàm đưa ra danh sách các nhân viên có địa chỉ cho trước với địa chỉ là 
--tham số đầu vào.
Create function ltc1 (@diachi nvarchar(30))
returns table
as return
	select	*
	from	tNhanVien
	where	@diachi = DiaChi
Go

Select * from ltc1(N'Hà Nội')
Go

--Câu 2: Tạo thủ tục có đầu vào là tỉnh (thành phố) đầu ra là số nhân viên nam, số nhân 
--viên nữ của tỉnh (thành phố) đó.
Create or alter proc ltc2 @tinh nvarchar(30), @nvnam int out, @nvnu int out
as 
begin
	Select	@nvnam = COUNT(MaNV)
	from	tNhanVien
	where	@tinh = DiaChi and GioiTinh = N'Nam'

	Select	@nvnam = COUNT(MaNV)
	from	tNhanVien
	where	@tinh = DiaChi and GioiTinh = N'Nữ'
end
Go

Declare	@sonam int, @sonu int
Exec	ltc2 N'Hà Nội', @sonam out, @sonu out
print	N'So nhan vien nam' + str(@sonam)
print	N'So nhan vien nu' + str(@sonu)
go

--Câu 3: Tạo view đưa ra thông tin các nhân viên và hóa đơn bán, hóa đơn nhập họ đã 
--xử lý của các nhân viên ở HN trong năm 2014
Create or alter view ltc3 as
	Select	tNhanVien.MaNV, TenNV, GioiTinh, SoHDN as SoHD
	from	tNhanVien join tHoaDonNhap
	on		tNhanVien.MaNV = tHoaDonNhap.MaNV
	where	DiaChi = N'Hà Nội' and YEAR(NgayNhap) = 2014
	Union
	Select	tNhanVien.MaNV, TenNV, GioiTinh, SoHDB as SoHD
	from	tNhanVien join tHoaDonBan
	on		tNhanVien.MaNV = tHoaDonBan.MaNV
	where	DiaChi = N'Hà Nội' and YEAR(NgayBan) = 2014

Select * from ltc3

--Câu 4: Tạo view đưa ra những nhân viên có tổng tiền hóa đơn cao nhất và cao nhì 
--trong năm 2014
Create view ltc4 as
	SELECT tHoaDonBan.MaNV, TenNV, SUM(SoLuong * DonGiaBan) AS TongTienBanDuoc
	FROM dbo.tSach JOIN dbo.tChiTietHDB ON tChiTietHDB.MaSach = tSach.MaSach
		JOIN dbo.tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
		JOIN dbo.tNhanVien ON tNhanVien.MaNV = tHoaDonBan.MaNV
	WHERE YEAR(NgayBan) = 2014
	GROUP BY tHoaDonBan.MaNV, TenNV
	HAVING SUM(SoLuong * DonGiaBan) IN 
			(	SELECT DISTINCT TOP(2) SUM(SoLuong * DonGiaBan) AS TongTienBan
				FROM dbo.tSach JOIN dbo.tChiTietHDB	ON tChiTietHDB.MaSach = tSach.MaSach
								JOIN dbo.tHoaDonBan ON tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
								JOIN dbo.tNhanVien ON tNhanVien.MaNV = tHoaDonBan.MaNV
				WHERE YEAR(NgayBan) = 2014
				GROUP BY tHoaDonBan.MaNV, TenNV
				ORDER BY TongTienBan DESC )

Select * from ltc4
Go

--Câu 6: Thêm trường Tổng tiền vào bảng nhân viên, cập nhật tự động cho trường này 
--mỗi khi thêm một chi tiết hóa đơn bán
Alter table tNhanVien
add TongTien_1 money

Create or alter trigger ltc6_1 on tChiTietHDB
for insert as
begin
	Declare @sohdb nvarchar(10), @masach nvarchar(10), @slban int, @dongia money, @Manv nvarchar(10)
	Select	@sohdb = SoHDB, @masach = MaSach, @slban = SLBan from inserted
	Select	@dongia = DonGiaBan from tSach where MaSach = @masach
	Select	@Manv = MaNV from tHoaDonBan where SoHDB = @sohdb
	Update	tNhanVien set TongTien_1 = ISNULL(TongTien_1, 0) + (@slban * @dongia) where MaNV = @Manv
end

-- De 2
--Câu 1: Tạo hàm có đầu vào là tháng đầu ra là thông tin các hóa đơn trong tháng đó.
Create or alter function ltc1a (@thang int, @nam int)
returns table
as return
	Select	SoHDB as SoHD, MaNV, NgayBan as Ngay
	from	tHoaDonBan
	where	@thang = MONTH(NgayBan) and YEAR(NgayBan) = @nam
	Union
	Select	SoHDN as SoHD, MaNV, NgayNhap as Ngay
	from	tHoaDonNhap
	where	@thang = MONTH(NgayNhap) and YEAR(NgayNhap) = @nam

Select * from ltc1a(6, 2014)
Go

--Câu 2: Tạo thủ tục có đầu vào là mã nhân viên, đầu ra là số lượng hóa đơn nhập, số
--lượng hóa đơn bán mà nhân viên đó xử lý.
Create or alter proc ltc2a @manv nvarchar(10), @hdn int out, @hdb int out
as
begin
	Select	@hdn = COUNT(SoHDN)
	from	tHoaDonNhap
	where	@manv = MaNV

	Select	@hdb = COUNT(SoHDB)
	from	tHoaDonBan
	where	@manv = MaNV
end

Declare	@sln int, @slb int
Exec	ltc2a 'NV001', @sln out, @slb out
print	N'So hoa don nhap:' + str(@sln)
print	N'So hoa don ban:' + str(@slb)
Go

--Câu 3: Tạo view đưa ra thông tin các khách hàng và thông tin hóa đơn, trị giá hóa đơn 
--họ đã mua trong năm 2014
Create or alter view ltc3a as
Select	tKhachHang.MaKH, TenKH, tHoaDonBan.SoHDB, NgayBan, sum(SLBan * DonGiaBan) as TongTienHD
from	tKhachHang, tHoaDonBan, tChiTietHDB, tSach
where	tKhachHang.MaKH = tHoaDonBan.MaKH and tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
		and tChiTietHDB.MaSach = tSach.MaSach and YEAR(NgayBan) = 2014
group by tKhachHang.MaKH, TenKH, tHoaDonBan.SoHDB, NgayBan

Select * from ltc3a
go

--Câu 4: Thêm trường Tổng số đầu sách và bảng thể loại, cập nhật tự động cho trường 
--này mỗi khi xóa một đầu sách
Alter table tTheLoai
add TongDauSach int

/*UPDATE tTheLoai
SET TongDauSach = ISNULL((SELECT COUNT(MaSach)
						 FROM tTheLoai A join tSach 
						 on tTheLoai.MaTheLoai = tSach.MaTheLoai
						 WHERE tTheLoai.MaTheLoai = A.MaTheLoai), 0)
SELECT * FROM tTheLoai*/

Create or alter trigger ltc4a on tSach
for insert, update, delete as
begin
	Declare @MaTLDe nvarchar(30), @MaTLIn nvarchar(30)
	Select	@MaTLIn = MaTheLoai from inserted
	Select	@MaTLDe = MaTheLoai from deleted
	update	tTheLoai set TongDauSach = ISNULL(TongDauSach, 0) + 1 where MaTheLoai = @MaTLIn
	update	tTheLoai set TongDauSach = ISNULL(TongDauSach, 0) - 1 where MaTheLoai = @MaTLDe
end

Select * from tTheLoai
Go

--Câu 6: Tạo view đưa ra những khách hàng có tổng số lượng hóa đơn cao nhất và cao 
--nhì trong năm 2014
Create or alter view ltc6b as
Select	tKhachHang.MaKH, TenKH, COUNT(SoHDB) as TongSoHD
from	tKhachHang join tHoaDonBan
on		tKhachHang.MaKH = tHoaDonBan.MaKH
where	year(NgayBan) = 2014
group by tKhachHang.MaKH, TenKH
Having COUNT(SoHDB) in (Select	distinct top 2 COUNT(SoHDB) 
						from	tHoaDonBan
						where	YEAR(NgayBan) = 2014
						group by MaKH
						order by 1 desc )

Select * from ltc6b


-- De 3
-- Câu 1: Tạo hàm có đầu vào là tên thể loại đầu ra là thông tin các sách thuộc 
-- thể loại đó.
Create or alter function Cau1_F(@Ten nvarchar(50)) 
returns table 
as return
	Select	MaSach, TenSach, TacGia, MaNXB, DonGiaNhap, DonGiaBan, SoLuong
	from	tSach join tTheLoai
	on		tSach.MaTheLoai = tTheLoai.MaTheLoai
	where	@Ten = tTheLoai.TenTheLoai

Select * from Cau1_F('Trinh thám')
Go

-- Câu 2: Tạo thủ tục có đầu vào là mã nhà xuất bản, đầu ra là số lượng đầu sách, 
-- số lượng tiền nhập hàng mà cửa hàng đã nhập của nhà xuất bản đó.
Create or alter proc Cau2_P @MaNXB nvarchar(20), @SL int out, @Tien money out
as
begin
	Select	@SL = COUNT(distinct tSach.MaSach), @Tien = SUM(DonGiaNhap * SLNhap)
	from	tSach join tChiTietHDN
	on		tSach.MaSach = tChiTietHDN.MaSach
	where	@MaNXB = MaNXB
end

Declare	@SLg int, @SoTien money
Exec	Cau2_P N'NXB01', @SLg out, @SoTien out
print	@SLg
print	@SoTien
Go

-- Câu 3: Tạo view đưa ra thông tin các nhà cung cấp và thông tin hóa đơn nhập, 
-- trị giá  hóa đơn cửa hàng đã nhập trong năm 2014
Create or alter view Cau3_V
as
Select	MaNCC, tHoaDonNhap.SoHDN, MaNV, NgayNhap, SUM(SLNhap * DonGiaNhap) as TriGiaHoaDon
from	tHoaDonNhap, tChiTietHDN, tSach
where	tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN and tChiTietHDN.MaSach = tSach.MaSach
Group by MaNCC, tHoaDonNhap.SoHDN, MaNV, NgayNhap

Select * from Cau3_V


--Câu 4: Thêm trường Tổng số đầu sách vào bảng tNhaXuatBan, cập nhật tự động 
--cho trường này mỗi khi thêm, sửa, xóa một cuốn sách
Alter table tNhaXuatBan
add TongDauSach int

Create trigger Cau4_TG on tSach
for	insert, update, delete as
begin
	Declare @MaNXBDe nvarchar(10), @MaNXBIn nvarchar(10)
	Select	@MaNXBDe = MaNXB from deleted
	Select	@MaNXBIn = MaNXB from inserted
	update	tNhaXuatBan set TongDauSach = ISNULL(TongDauSach, 0) + 1 where @MaNXBIn = MaNXB
	update	tNhaXuatBan set TongDauSach = ISNULL(TongDauSach, 0) - 1 where @MaNXBDe = MaNXB
end

Select * from tNhaXuatBan

--Câu 6: Tạo thủ tục thống kê số lượng hóa đơn bán mà không tồn tại chi tiết 
--hóa đơn bán, đồng thời xóa những bản ghi mồ côi này
Create proc ltc6a @slhdb int out as
begin
	Select	COUNT(SoHDB) as SoLuongHDB
	from	tHoaDonBan
	where	SoHDB not in (Select SoHDB from tChiTietHDB)

	delete  from tHoaDonBan
	where	SoHDB not in (Select SoHDB from tChiTietHDB)
end

Declare @Sl int
Exec	ltc6a @Sl out
print	@Sl




