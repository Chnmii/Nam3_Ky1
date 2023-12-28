-- cau 1
Create or alter view TTHDon as
Select	tHoaDonBan.SoHDB, NgayBan, sum(SLBan * DonGiaBan) as TongTien
from	tHoaDonBan, tChiTietHDB, tSach
where	tHoaDonBan.SoHDB = tChiTietHDB.SoHDB and tChiTietHDB.MaSach = tSach.MaSach
		and	MONTH(NgayBan) = MONTH(getdate()) and 	year(NgayBan) = year(getdate())
group by tHoaDonBan.SoHDB, NgayBan

Select * from TTHDon


-- cau 2
create or alter proc HDon @thang int, @nam int, @sotien money out, @SLHD int out
as
begin
	Select	@SoTien = sum(SLBan * DonGiaBan), @SLHD = COUNT(distinct tHoaDonBan.SoHDB)
	from	tHoaDonBan, tChiTietHDB, tSach
	where	tHoaDonBan.SoHDB = tChiTietHDB.SoHDB and tChiTietHDB.MaSach = tSach.MaSach
			and @Thang = MONTH(NgayBan) and @nam = YEAR(NgayBan)
end

Declare	@Tien int, @SL int
exec	HDon 4, 2014, @Tien output, @SL output
print	@Tien
print	@SL


-- cau 3
Create login PhanQuocAn
	with password = 'abc'

Create user PhanQuocAn for login PhanQuocAn

-- Phân quyen Select trên view cau 1 cho PhanQuocAn và PhanQuocAn duoc phép phan quyen cho nguoi khác
Grant Select on TTHDon to PhanQuocAn with grant option

Create login PhamVanAnh
	with password = '123'

Create user PhamVanAnh for login PhamVanAnh


-- cau 4
Alter table tNhanVien
add SLHoaDon int

Create or alter trigger SLHD on tHoaDonBan
for insert 
as
begin
	Declare	@SoHDB nvarchar(20), @MaNv nvarchar(10), @SLgHD int
	Select	@SoHDB = SoHDB, @SLgHD = count(SoHDB) from inserted group by SoHDB
	Select	@MaNv = tNhanVien.MaNV from tNhanVien , tHoaDonBan 
	where	tNhanVien.MaNV = tHoaDonBan.MaNV and tHoaDonBan.SoHDB = @SoHDB
	update	tNhanVien set SLHoaDon = isnull(SLHoaDon, 0) + @SLgHD  where MaNV = @MaNv
end

Select * from tNhanVien where MaNV = 'NV01'
insert into tHoaDonBan (SoHDB, MaNV, NgayBan, MaKH) values ('HDB189', N'NV01', CAST(N'2014-04-11T00:00:00.000' AS DateTime), N'KH05')
Select * from tNhanVien where MaNV = 'NV01'



