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
