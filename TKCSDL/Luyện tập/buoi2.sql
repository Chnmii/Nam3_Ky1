-- 1. Tạo thủ tục có đầu vào là matheloai, năm, đầu ra là số tiền và số lượng dau sach bán dc
-- trong the loai do
Create proc cau1 @maTL nvarchar(10), @nam int, @sotien money out, @sldausach int out
as
begin
	Select	@sotien = sum(SLBan * DonGiaBan), @sldausach = COUNT(distinct tSach.MaSach)
	from	tTheLoai join tSach on tTheLoai.MaTheLoai = tSach.MaTheLoai
			join tChiTietHDB on tSach.MaSach = tChiTietHDB.MaSach
			join tHoaDonBan on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
	where	tTheLoai.MaTheLoai = @maTL and YEAR(NgayBan) = @nam
end

Declare @Tien money, @SL int
exec	cau1 'TL01', 2014, @Tien out, @SL out
print	@Tien
print	@SL

-- 2. Them truong SLDauSach vao bang The loai, cap nhat tu dong so luong dau sach cua the loai do
Alter table tTheLoai
add SLDauSach int

Create or alter trigger TG_DauSach on tSach
for insert
as
begin
	Declare	@MaTL nvarchar(20)
	Select	@MaTL = MaTheLoai from inserted
	update	tTheLoai set SLDauSach = isnull(SLDauSach, 0) + 1
	where	MaTheLoai = @MaTL
end

Select * from tTheLoai
insert into tSach(MaSach, MaTheLoai) values ('S22', 'TL01')
Select * from tTheLoai
Go

-- Tạo hàm có đầu vào là tháng đầu ra là thông tin các hóa đơn trong tháng đó.
-- hoa don nhap va hoa don ban
Create or alter function TTHD_F (@thang int) 
returns table
as return
	Select	SoHDB as SoHD, MaNV, NgayBan, 'HDB' as LoaiHD
	from	tHoaDonBan
	where	@thang = MONTH(NgayBan)
	Union
	Select	SoHDN, MaNV, NgayNhap, 'HDN'
	from	tHoaDonNhap

Select * from TTHD_F(4)
Go

-- Tạo thủ tục có đầu vào là mã nhân viên, đầu ra là số lượng hóa đơn nhập, số
-- lượng hóa đơn bán mà nhân viên đó xử lý
Create or alter proc SLHD_P @Manv nvarchar(15), @SLN int out, @SLB int out
as
begin
	Select	@SLN = COUNT(SoHDN)	from tHoaDonNhap where MaNV = @Manv
	Select	@SLB = COUNT(SoHDB)	from tHoaDonBan where MaNV = @Manv
end

Declare	@SLHDN int, @SLHDB int
Exec	SLHD_P N'NV01', @SLHDN out, @SLHDB out
print	@SLHDN
print	@SLHDB
Go

-- Tạo view đưa ra thông tin các khách hàng và thông tin hóa đơn, trị giá hóa đơn 
-- họ đã mua trong năm 2014
Create or alter view ThongTin 
as
Select	tKhachHang.MaKH, TenKH, DiaChi, DienThoai, tHoaDonBan.SoHDB, MaNV, sum(SLBan * DonGiaBan) as TriGiaHD 
from	tKhachHang, tHoaDonBan, tChiTietHDB, tSach
where	tKhachHang.MaKH = tHoaDonBan.MaKH and tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
		and tChiTietHDB.MaSach = tSach.MaSach and YEAR(NgayBan) = 2014
group by tKhachHang.MaKH, TenKH, DiaChi, DienThoai, tHoaDonBan.SoHDB, MaNV

Select * from ThongTin