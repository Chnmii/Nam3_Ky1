-- 1. Tạo thủ tục có đầu vào là tên Nhân viên, năm, đầu ra là số tiền và số lượng hoá đơn bán
-- mà nhân viên đó xử lý
Create proc Cau1PR @TenNV nvarchar(30), @nam int, @SoTien int output, @SLHDB int output
as
begin
	Select	@SoTien = sum(SLBan * DonGiaBan), @SLHDB = count(distinct tHoaDonBan.SoHDB)
	from	tHoaDonBan, tNhanVien, tChiTietHDB, tSach
	where	tHoaDonBan.MaNV = tNhanVien.MaNV and tHoaDonBan.SoHDB = tChiTietHDB.SoHDB
			and	tChiTietHDB.MaSach = tSach.MaSach and @TenNV = TenNV and @nam = year(NgayBan)
	group by tChiTietHDB.SLBan, tSach.DonGiaBan
end

Declare	@Tien int, @SoLuong int
exec	Cau1PR N'Trần Huy', 2014, @Tien output, @SoLuong output
print	@Tien
print	@SoLuong


-- 2. Thêm trường số SLSachMua vao bang khách hàng, cập nhật tự động số lượng sách khách hàng mua
-- tại cửa hàng cho trường này mỗi khi thêm 1 bản ghi vào bảng chi tiết hoá đơn bán
Alter table tKhachHang
add SLSachMua int

Create or alter trigger Cau2TG on tChiTietHDB
for insert
as
begin
	Declare	@SoHDB nvarchar(20), @MaKH nvarchar(10), @SLBan int
	Select	@SoHDB = tHoaDonBan.SoHDB, @MaKH = MaKH, @SLBan = tChiTietHDB.SLBan
	from	inserted join tHoaDonBan on tHoaDonBan.SoHDB = inserted.SoHDB
					join tChiTietHDB on tChiTietHDB.SoHDB = inserted.SoHDB
	update	tKhachHang set SLSachMua = isnull(SLSachMua, 0) + isnull(@SLBan, 0)
	where	@MaKH = MaKH
end


-- cach 2
Create or alter trigger Cau2TGg on tChiTietHDB
for insert
as
begin
	Declare	@SoHDB nvarchar(20), @MaK nvarchar(10), @SLgBan int
	Select	@SoHDB = SoHDB, @SLgBan = SLBan from inserted
	Select	@MaK = tKhachHang.MaKH from tKhachHang, tHoaDonBan 
	where	tKhachHang.MaKH = tHoaDonBan.MaKH and tHoaDonBan.SoHDB = @SoHDB
	update	tKhachHang set SLSachMua = isnull(SLSachMua, 0) + @SLgBan  where MaKH = @MaK
end

select * from tKhachHang where MaKH = 'KH01'
insert into tChiTietHDB values ('HDB01', 'S12', 9, Null)
select * from tKhachHang where MaKH = 'KH01'



-- 3. Tạo login NguyenBinhAn, tạo user NguyenBinhAn cho NguyenBinhAn trên CSDL QLBanSach
Create login NguyenBinhAn
	with password = '123'

Create user NguyenBinhAn for login NguyenBinhAn 

-- Phân quyền Select, update trên bảng tSach cho NguyenBinhAn và NguyenBinhAn được phép phân quyền
-- cho người khác
Grant Select, update on tSach to NguyenBinhAn with grant option

-- Đăng nhập NguyenBinhAn để kiểm tra


-- Tạo login NguyenDucAnh, tạo user NguyenDucAnh cho NguyenDucAnh trên CSDL QLBanSach
Create login NguyenDucAnh
	with password = '123'

Create user NguyenDucAnh for login NguyenDucAnh 


-- Từ login NguyenBinhAn, phân quyền Select trên bảng tSach cho NguyenDucAnh
Grant Select on tSach to NguyenDucAnh

-- Đăng nhập NguyenDucAnh để kiểm tra


-- 4. Tạo hàm có đầu vào là tháng, đầu ra là danh sách các ngày trong tháng đó có nhiều hoá đơn bán
-- nhất và số lượng hoá đơn là bao nhiêu
Create function Cau4FT(@Thang int)
returns table
as return
(	
	Select	top 1 with ties NgayBan, COUNT(SoHDB) as SoLuong
	from	tHoaDonBan
	where	@Thang = MONTH(NgayBan)
	group by tHoaDonBan.NgayBan
	order by SoLuong desc
)

Select * from Cau4FT(5)