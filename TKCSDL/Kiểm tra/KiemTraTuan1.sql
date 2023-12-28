-- 1. Tạo view đưa ra thông tin hoá đơn nhập và tổng tiền của mỗi hoá đơn trong các ngày trong tháng 4/2014
Create view TTHD as
Select	tHoaDonNhap.SoHDN, MaNV, NgayNhap, MaNCC, sum(SLNhap * DonGiaNhap) as Tongtien
from	tHoaDonNhap, tChiTietHDN, tSach
where	tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN and tChiTietHDN.MaSach = tSach.MaSach
		and MONTH(ngaynhap) = 4 and YEAR(NgayNhap) = 2014
group by tHoaDonNhap.SoHDN, MaNV, NgayNhap, MaNCC

Select * from TTHD	


-- 2.Tao thu tuc có dau vào là Tháng, dau ra là so tien và so luong hóa don nhap hàng trong tháng dó
Create procedure Cau2 @Thang int, @SoTien int output, @SoHD int output
as
begin
	Select	@SoTien = sum(SLNhap * DonGiaNhap), @SoHD = COUNT(distinct tHoaDonNhap.SoHDN)
	from	tHoaDonNhap, tChiTietHDN, tSach
	where	tHoaDonNhap.SoHDN = tChiTietHDN.SoHDN and tChiTietHDN.MaSach = tSach.MaSach
			and @Thang = MONTH(NgayNhap)
end

Declare	@Tien int, @SL int
exec	Cau2 '4', @Tien output, @SL output
print	@Tien
print	@SL


-- 3.Tao login	PhanQuocAn,	tao	user PhanQuocAn	cho	PhanQuocAn	tren CSDL QLBanSach
Create login PhanQuocAn
	with password = 'abc'

Create user PhanQuocAn for login PhanQuocAn

-- Phân quyen Select trên view cau 1 cho PhanQuocAn và PhanQuocAn duoc phép phan quyen cho nguoi khác
Grant Select on TTHD to PhanQuocAn with grant option

-- Dang nhap PhanQuocAn de kiem tra

-- Tao login TranMyLinh, tao TranMyLinh cho TranMyLinh tren CSDL QLBanSach Dang nhap TranMyLinh de kiem tra
Create login TranMyLinh
	with password = '123'

Create user TranMyLinh for login TranMyLinh

-- Tu login PhanQuocAn, phan quyen Select trên view Cau 1 cho TranMyLinh Dang nhap TranMyLinh de kiem tra
Grant Select on TTHD to TranMyLinh 


-- 4.Tao View danh sách SachHot nam 2014 bao gom các sách có tông so luong nhap và	
-- bán là cao nhat trong nam 2014
Create or alter view SachHot as
	Select	top 1 tSach.MaSach, TenSach, sum(SLBan) as SL
	from	tChiTietHDB join tSach   on tSach.MaSach = tChiTietHDB.MaSach
			join tHoaDonBan on tChiTietHDB.SoHDB = tHoaDonBan.SoHDB
	where	YEAR(NgayBan) = 2014
	group by tSach.MaSach, TenSach
	Union
	Select	top 1 tSach.MaSach, TenSach, sum(SLNhap) as SL
	from	tChiTietHDN join tSach   on tSach.MaSach = tChiTietHDN.MaSach
			join tHoaDonNhap on tChiTietHDN.SoHDN = tHoaDonNhap.SoHDN
	where	YEAR(NgayNhap) = 2014
	group by tSach.MaSach, TenSach
Go

Select * from SachHot