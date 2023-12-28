-- 1. Them truong ThanhTien cho bang tchitietHDB, tao trigger cap nhat tu dong cho truong nay
-- biet ThanhTien = SLBan * DonGiaBan
Alter table tchitietHDB
add ThanhTien money

Create trigger ThanhTien on [dbo].[tchitietHDB]
for insert, update as
begin
	declare @sohdb nvarchar(10), @dongia money, @thanhtien money, @masach nvarchar(10)
	Select @sohdb = SoHDB, @masach = masach from inserted
	Select @dongia = dongiaban from tsach where masach = @masach
	update tChiTietHDB set ThanhTien = SLBan*@dongia where SoHDB= @sohdb and masach = @masach
end

insert into tChiTietHDB(SoHDB, MaSach, SLBan) values ('HDB01', 'S03', 10)

insert into tChiTietHDB(SoHDB, MaSach, SLBan) values ('HDB01', 'S05', 10)


-- 2. Them truong DonGia cho bang tchitietHDB, cap nhat du lieu cho truong moi khi them
-- sua ban ghi vao bang tchitietHDB
Alter table tChitietHDB
add DonGia money

Create trigger DonGia on [dbo].[tchitietHDB]
for insert, update as
begin
	declare @sohdb nvarchar(10), @dongia money, @masach nvarchar(10)
	Select @sohdb = SoHDB, @masach = masach from inserted
	Select @dongia = dongiaban from tsach where masach = @masach
	update tChiTietHDB set DonGia = @dongia where SoHDB= @sohdb and masach = @masach

end


-- 3. them truong tong hoa don vao bang khach hang va cap nhat tu dong cho truong nay moi khi them hdon
Alter table tKhachHang
add TongHD int

Update tKhachHang
set TongHD = (	Select isnull(count(SoHDB), 0)
				from	tKhachHang a left join tHoaDonBan
				on		a.MaKH = tHoaDonBan.MaKH
				where	a.MaKH = tKhachHang.MaKH
				group by a.MaKH )

Create trigger Cau3TG on [dbo].[tHoaDonBan]
for insert as
begin
	declare @makh nvarchar(10)
	Select	@makh = MaKH from inserted
	update	tKhachHang set TongHD = TongHD + 1
	where	@makh = MaKH
end


-- 4. them truong tong hoa don vao bang khach hang va cap nhat tu dong cho truong nay moi khi 
-- them, sua, xoa hoa don
Alter table tKhachHang
add	SoLuong int

Create trigger Cau4trigger on [dbo].[tHoaDonBan]
for insert, update, delete as 
begin
	declare @MaKH1 nvarchar(10), @MaKH2 nvarchar(10), @in int, @de int
	select @MaKH1 = MaKH, @in = 1 from inserted
	select @MaKH2 = MaKH, @de = 1 from deleted
	update tKhachHang set SoLuong = isnull(soluong, 0) + isnull(@in, 0) where MaKH = @MaKH1
	update tKhachHang set SoLuong = isnull(soluong, 0) - isnull(@de, 0) where MaKH = @MaKH2
end

select * from tKhachHang where MaKH = 'KH01'
insert into tHoaDonBan values('HDB34','NV06','2014-05-10','KH01',NULL)

select * from tKhachHang where MaKH = 'KH01'
update tHoaDonBan set MaNV = 'NV06' where SoHDB = 'HDB34'

select * from tKhachHang where MaKH = 'KH01'
update tHoaDonBan set MaKH = 'KH02' where SoHDB = 'HDB34'

select * from tKhachHang where MaKH = 'KH01'
select * from tKhachHang where MaKH = 'KH02'

select * from tKhachHang where MaKH = 'KH02'
delete from tHoaDonBan where SoHDB = 'HDB34'
select * from tKhachHang where MaKH = 'KH02'

select * from tHoaDonBan where SoHDB = 'HDB34'


-- 5. Thêm trường tổng tiền cho hóa đơn bán, cập nhật tự động cho trường này mỗi khi thêm, 
-- xóa, sửa chi tiết hóa đơn
Alter table tHoaDonBan
add SoSP int

Create trigger Cau5trigger on tChiTietHDB
for insert, update, delete
as begin
	update tHoaDonBan set SoSP = isnull(soSP, 0) + SLB
	from (select SoHDB, sum(SLBan) as SLB from inserted group by inserted.SoHDB) A
	where tHoaDonBan.SoHDB = A.SoHDB

	update tHoaDonBan set SoSP = isnull(soSP, 0) - SLB
	from (select SoHDB, sum(SLBan) as SLB from deleted group by deleted.SoHDB) A
	where tHoaDonBan.SoHDB = A.SoHDB
end

select * from tChiTietHDB where SoHDB = 'HDB01'
delete from tChiTietHDB where SoHDB = 'HDB01' and MaSach like 'S1%'


-- 6. Số lượng trong bảng Sách là số lượng tồn kho, cập nhật tự động dữ liệu cho trường này
-- mỗi khi nhập hay bán sách
-- 7. Thêm trường Tổng tiền tiêu dùng cho bảng khách hàng, cập nhật thông tin cho trường này.
-- 8. Thêm trường Số đầu sách cho bảng nhà cung cấp, cập nhật tự động số đầu sách nhà cung 
-- cấp cung cấp cho cửa hàng 
Alter table tNhaCungCap
add SoDauSach int

Create or alter trigger cau8 on tNhaCungCap
for update as
begin
	Declare @mancc nvarchar(10)
	Select	@mancc = MaNCC from inserted
	update	tNhaCungCap set SoDauSach = isnull(SoDauSach, 0) + 1 where MaNCC = @mancc
end

Select * from tNhaCungCap


-- 9. Thêm trường Số lượng sách và Tổng tiền hàng vào bảng nhà cung cấp, cập nhật dữ liệu 
-- cho trường này mỗi khi nhập hàng


-- 11. Tạo trigger trên bảng tHoaDonBan thực hiện xoá các chi tiết hoá đơn mỗi khi xoá hoá đơn
Create trigger cau11 on  tHoaDonBan
instead of delete
as
begin
	delete tChiTietHDB where SoHDB in (Select SoHDB from deleted)
	delete tHoaDonBan where SoHDB in (Select SoHDB from deleted)
end

-- Thêm trường số sản phẩm vào bảng hoá đơn bán, cập nhật tự động cho trường này mỗi khi 
-- thêm chi tiết hoá đơn
Alter table tHoaDonBan
Add	SoSanPham int

Create trigger UD_HD on tChiTietHDB
for	insert 
as begin
	Declare @SoHDB nvarchar(10), @SL int
	Select	@SoHDB = SoHDB, @SL = SLBan from inserted
	update	tHoaDonBan set SoSanPham = SoSanPham + @SL where @SoHDB = SoHDB
end


-- Thêm trường số sản phẩm vào bảng hoá đơn bán, cập nhật tự động cho trường này mỗi khi 
-- xoa chi tiết hoá đơn
Create trigger UD_HD_TG on tChiTietHDB
for	insert 
as begin
	Declare @SoHDB nvarchar(10), @SL int
	Select	@SoHDB = SoHDB, @SL = SLBan from inserted
	update	tHoaDonBan set SoSanPham = SoSanPham - @SL where @SoHDB = SoHDB
end


-- Thêm trường số sản phẩm vào bảng hoá đơn bán, cập nhật tự động cho trường này mỗi khi 
-- them, sua, xoa chi tiết hoá đơn
Create trigger UD_HD3 on tChiTietHDB
for	delete, insert, update
as begin
	Declare	@SoHDBin nvarchar(255), @SLBin int,
			@SoHDBde nvarchar(255), @SLBde int
	Select	@SoHDBin = SoHDB, @SLBin = SLBan from inserted
	Select	@SoHDBde = SoHDB, @SLBde = SLBan from deleted

	update	tHoaDonBan
	set		SoSanPham = ISNULL(SoSanPham, 0) + @SLBin
	where	SoHDB = @SoHDBin

	update	tHoaDonBan
	set		SoSanPham = ISNULL(SoSanPham, 0) - @SLBin
	where	SoHDB = @SLBde

-- cach 2
--	update	tHoaDonBan
--	set		SoSanPham = ISNULL(SoSanPham, 0) + @SLBin - @SLBde
--	where	SoHDB = isnull(@SoHDBin, @SLBde)
end



