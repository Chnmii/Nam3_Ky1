Create database QL_KhachSan1
go
USE [QL_KhachSan1]
GO
/****** Object:  Table [dbo].[tb_NhanVien]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_NhanVien](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[CCCD] [nvarchar](12) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](10) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TimDongHuong]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TimDongHuong] AS
SELECT MaNV,TenNV,CCCD,GioiTinh,NgaySinh,DiaChi,SoDienThoai,ChucVu FROM tb_NhanVien
WHERE DiaChi=N'Nam Định' 
GO
/****** Object:  Table [dbo].[tb_PTB]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_PTB](
	[MaTb] [nvarchar](10) NOT NULL,
	[MaPhong] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[TinhTrang] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_TB]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_TB](
	[MaTb] [nvarchar](10) NOT NULL,
	[TenTb] [nvarchar](50) NULL,
	[Gia] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_TB] PRIMARY KEY CLUSTERED 
(
	[MaTb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[KiemTra]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[KiemTra] AS
SELECT tb_PTB.MaTb,tb_TB.TenTb,tb_TB.Gia,MaPhong,SoLuong,TinhTrang
FROM   tb_PTB INNER JOIN tb_TB 
ON tb_PTB.MaTb = tb_TB.MaTb
where tb_PTB.TinhTrang=N'Hỏng'
GO
/****** Object:  Table [dbo].[tb_HoaDon]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_HoaDon](
	[SoHD] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[NgayThanhToan] [date] NULL,
	[TienPhong] [money] NULL,
	[TienDV] [money] NULL,
	[TongTien] [money] NULL,
 CONSTRAINT [PK_tb_HoaDon_1] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Cau1_1]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Cau1_1](@nam int) returns table as
return
select sum(TongTien) as Tien,count(SoHD) as SL from tb_HoaDon
where year(NgayThanhToan) = @nam
GO
/****** Object:  UserDefinedFunction [dbo].[Cau2]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[Cau2](@thang int) returns table as
return
select top(5) with ties tb_NhanVien.MaNV,TenNV,sum(TongTien) as Tien from tb_NhanVien
join tb_HoaDon on tb_HoaDon.MaNV = tb_NhanVien.MaNV
where @thang = month(tb_HoaDon.NgayThanhToan)
group by tb_NhanVien.MaNV,TenNV
order by sum(TongTien) desc
GO
/****** Object:  Table [dbo].[tb_KhachHang]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_KhachHang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[CCCD] [nvarchar](12) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nvarchar](10) NULL,
	[Note] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[Cau3]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
      create function [dbo].[Cau3](@ngay int) returns table as
     return
     select top(1) tb_KhachHang.MaKH,tb_KhachHang.TenKH,count(tb_HoaDon.SOHD) as SL from tb_KhachHang                                     
     join tb_HoaDon on tb_KhachHang.MaKH = tb_HoaDon.MaKH
     where @ngay = day(tb_HoaDon.NgayThanhToan)
     group by tb_KhachHang.MaKH,tb_KhachHang.TenKH
     order by count(tb_HoaDon.SOHD) desc
GO
/****** Object:  Table [dbo].[tb_DatPhong]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_DatPhong](
	[SoHD] [nvarchar](10) NOT NULL,
	[MaPhong] [nvarchar](10) NOT NULL,
	[SoNguoi] [int] NULL,
	[NgayDen] [date] NULL,
	[NgayDi] [date] NULL,
 CONSTRAINT [PK_tb_DatPhong] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC,
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_LoaiPhong]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_LoaiPhong](
	[MaLP] [nvarchar](10) NOT NULL,
	[LoaiPhong] [nvarchar](50) NULL,
	[SoNguoiToiDa] [int] NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_tb_LoaiPhong] PRIMARY KEY CLUSTERED 
(
	[MaLP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Phong]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Phong](
	[MaPhong] [nvarchar](10) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
	[MaLP] [nvarchar](10) NOT NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_Phong] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[cau4]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
     CREATE function [dbo].[cau4] (@TenKH nvarchar(50))
     returns table 
     as
   return select tb_DatPhong.MaPhong,TenPhong,LoaiPhong,Gia  from tb_KhachHang
   join QL_KhachSan.dbo.tb_HoaDon on tb_KhachHang.MaKH=tb_HoaDon.MaKH
join tb_DatPhong on tb_HoaDon.SoHD= tb_DatPhong.SoHD join tb_Phong on tb_DatPhong.MaPhong = tb_Phong.MaPhong join tb_LoaiPhong on tb_Phong.MaLP = tb_LoaiPhong.MaLP
GO
/****** Object:  UserDefinedFunction [dbo].[cau5]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create function [dbo].[cau5] (@nam int) returns table as
	return (select * from tb_NhanVien WHere year (NgaySinh) = @nam )
GO
/****** Object:  UserDefinedFunction [dbo].[cau6]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[cau6](@tenkh nvarchar(30), @dmy date) 
returns table as return
(
select TienPhong
from tb_HoaDon inner join tb_KhachHang on tb_HoaDon.MaKH = tb_KhachHang.MaKH
where TenKH = @tenkh and NgayThanhToan=@dmy
)
GO
/****** Object:  View [dbo].[XemHoaDon]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[XemHoaDon] as
	select * from tb_HoaDon
GO
/****** Object:  View [dbo].[KHNN]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[KHNN] as
select top 1 with ties MaKH,COUNT(SOHD) AS SoLanGheTham from tb_HoaDon group by MaKH order by Count(SoHD) desc 
GO
/****** Object:  View [dbo].[maxhd]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[maxhd] as
select top 1 with ties SoHD, TongTien from tb_HoaDon order by TongTien desc 
GO
/****** Object:  View [dbo].[NVCDTCN]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[NVCDTCN] as
select top 1 with ties tb_NhanVien.MaNV, tb_NhanVien.TenNV, Sum(TongTien) as TongHoaDon from tb_NhanVien 
join tb_HoaDon on tb_HoaDon.MaNV = tb_NhanVien.MaNV
group by tb_NhanVien.MaNV,tb_NhanVien.TenNV order by Sum(tongtien) desc
GO
/****** Object:  View [dbo].[slkhachcacthang]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[slkhachcacthang] as 
	select MONTH(NgayThanhToan)as N'Tháng' ,COUNT(SOHD) as SoLuongKhach FROM tb_HoaDon where YEAR(NgayThanhToan) = 2022 GROUP BY MONTH(NgayThanhToan)
GO
/****** Object:  View [dbo].[TCNKN]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TCNKN] as
	select top 1 with ties MONTH(NgayThanhToan)as N'Tháng' ,COUNT(SOHD) as SoLuongKhach FROM tb_HoaDon where YEAR(NgayThanhToan) = 2022 GROUP BY MONTH(NgayThanhToan) order by month(NgayThanhToan) desc
GO
/****** Object:  Table [dbo].[tb_DichVu]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_DichVu](
	[MaDV] [nvarchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[Gia] [float] NULL,
 CONSTRAINT [PK_tb_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_SDDV]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_SDDV](
	[SoHD] [nvarchar](10) NOT NULL,
	[MaDV] [nvarchar](10) NOT NULL,
	[SoLuong] [nvarchar](10) NULL,
	[NgayMua] [date] NULL,
 CONSTRAINT [PK_tb_SDDV] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tb_DatPhong] ([SoHD], [MaPhong], [SoNguoi], [NgayDen], [NgayDi]) VALUES (N'HD0001', N'MP0001', 1, CAST(N'2022-11-02' AS Date), CAST(N'2022-11-03' AS Date))
INSERT [dbo].[tb_DatPhong] ([SoHD], [MaPhong], [SoNguoi], [NgayDen], [NgayDi]) VALUES (N'HD0001', N'MP0002', 2, CAST(N'2022-11-02' AS Date), CAST(N'2022-11-03' AS Date))
INSERT [dbo].[tb_DatPhong] ([SoHD], [MaPhong], [SoNguoi], [NgayDen], [NgayDi]) VALUES (N'HD0002', N'MP0010', 3, CAST(N'2022-11-04' AS Date), CAST(N'2022-11-06' AS Date))
INSERT [dbo].[tb_DatPhong] ([SoHD], [MaPhong], [SoNguoi], [NgayDen], [NgayDi]) VALUES (N'HD0003', N'MP0005', 2, CAST(N'2022-11-04' AS Date), CAST(N'2022-11-06' AS Date))
GO
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0001', N'CoCa CoLa', 17000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0002', N'7 up', 15000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0003', N'Pepsi', 15000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0004', N'Pizza', 200000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0005', N'Phở bò', 50000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0006', N'Cơm rang đùi gà', 50000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0007', N'Vang Ngọt', 200000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0008', N'Volka', 100000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0009', N'ChiVas', 1000000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0010', N'Sting đỏ', 15000)
INSERT [dbo].[tb_DichVu] ([MaDV], [TenDV], [Gia]) VALUES (N'DV0011', N'Sting vàng', 15000)
GO
INSERT [dbo].[tb_HoaDon] ([SoHD], [MaKH], [MaNV], [NgayThanhToan], [TienPhong], [TienDV], [TongTien]) VALUES (N'HD0001', N'KH0001', N'NV0001', CAST(N'2022-11-03' AS Date), 300000.0000, 1410000.0000, 1345000.0000)
INSERT [dbo].[tb_HoaDon] ([SoHD], [MaKH], [MaNV], [NgayThanhToan], [TienPhong], [TienDV], [TongTien]) VALUES (N'HD0002', N'KH0002', N'NV0002', CAST(N'2022-11-04' AS Date), 400000.0000, 365000.0000, 600000.0000)
INSERT [dbo].[tb_HoaDon] ([SoHD], [MaKH], [MaNV], [NgayThanhToan], [TienPhong], [TienDV], [TongTien]) VALUES (N'HD0003', N'KH0002', N'NV0002', CAST(N'2022-11-04' AS Date), 300000.0000, 165000.0000, 465000.0000)
GO
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [Note]) VALUES (N'KH0001', N'Nguyễn Hoàng Điệp', N'Nữ', N'123456789001', CAST(N'2002-09-05' AS Date), N'Ninh Bình', N'0112345670', N'None')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [Note]) VALUES (N'KH0002', N'Nguyễn Thị Kim Sao', N'Nữ', N'123456789002', CAST(N'1985-05-19' AS Date), N'Thái Nguyên', N'0112345671', N'Vip')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [Note]) VALUES (N'KH0003', N'Nguyễn Công Hoàn', N'Nam', N'123456789003', CAST(N'2002-05-13' AS Date), N'Ninh Bình', N'0112345672', N'Ban quản lý')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [Note]) VALUES (N'KH0004', N'Hoàn', N'Nam', N'123332123', CAST(N'2002-10-05' AS Date), N'Ca Mau', N'113', N'None')
INSERT [dbo].[tb_KhachHang] ([MaKH], [TenKH], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [Note]) VALUES (N'KH0005', N'Nguyễn Văn A', N'Nam', N'123456789011', CAST(N'2002-05-18' AS Date), N'Hoà Bình', N'0112345675', N'None')
GO
INSERT [dbo].[tb_LoaiPhong] ([MaLP], [LoaiPhong], [SoNguoiToiDa], [Gia]) VALUES (N'DLX', N'Phòng Deluxe', 4, 250000)
INSERT [dbo].[tb_LoaiPhong] ([MaLP], [LoaiPhong], [SoNguoiToiDa], [Gia]) VALUES (N'STD', N'Phòng Standard', 2, 150000)
INSERT [dbo].[tb_LoaiPhong] ([MaLP], [LoaiPhong], [SoNguoiToiDa], [Gia]) VALUES (N'SUP', N'Phòng Superior', 3, 200000)
INSERT [dbo].[tb_LoaiPhong] ([MaLP], [LoaiPhong], [SoNguoiToiDa], [Gia]) VALUES (N'SUT', N'Phòng Suite', 5, 300000)
GO
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV0001', N'Vũ Doanh Thái', N'Nam', N'012345678901', CAST(N'2002-04-29' AS Date), N'Ninh Bình', N'0123456780', N'Quản lý')
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV0002', N'Nguyễn Hữu Bút', N'Nữ', N'012345678902', CAST(N'2002-03-10' AS Date), N'Ninh Bình', N'0123456781', N'Lễ Tân')
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV0003', N'Lê Đức Lợi', N'Nam', N'012345678903', CAST(N'2002-10-20' AS Date), N'Nam Định', N'0123456782', N'Lễ Tân')
INSERT [dbo].[tb_NhanVien] ([MaNV], [TenNV], [GioiTinh], [CCCD], [NgaySinh], [DiaChi], [SoDienThoai], [ChucVu]) VALUES (N'NV0004', N'Đỗ Đức Việt', N'Nam', N'012345678904', CAST(N'2002-11-19' AS Date), N'Hà Nội', N'0123456783', N'Lễ Tân')
GO
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0001', N'P101', N'STD', N'Đang bảo trì')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0002', N'P102', N'STD', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0003', N'P103', N'STD', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0004', N'P104', N'STD', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0005', N'P105', N'STD', N'Đã sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0006', N'P201', N'SUP', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0007', N'P202', N'SUP', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0008', N'P203', N'SUP', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0009', N'P204', N'SUP', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0010', N'P205', N'SUP', N'Đã sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0011', N'P301', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0012', N'P302', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0013', N'P303', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0014', N'P304', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0015', N'P305', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0016', N'P401', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0017', N'P402', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0018', N'P403', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0019', N'P404', N'DLX', N'Chưa sử dụng')
INSERT [dbo].[tb_Phong] ([MaPhong], [TenPhong], [MaLP], [TinhTrang]) VALUES (N'MP0020', N'P405', N'DLX', N'Chưa sử dựng')
GO
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0001', 1, N'Đã hỏng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0001', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0001', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0001', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0002', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0002', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0002', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0002', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0002', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0003', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0003', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0003', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0003', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0003', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0003', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0003', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0004', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0004', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0004', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0004', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0005', N'MP0004', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0004', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0004', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0004', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0005', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0005', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0005', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0005', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0005', N'MP0005', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0005', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0005', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0005', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0006', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0006', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0006', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0006', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0006', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0006', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0006', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0007', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0007', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0007', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0007', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0007', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0007', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0007', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0008', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0008', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0008', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0008', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0005', N'MP0008', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0008', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0008', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0008', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0009', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0009', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0009', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0009', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0009', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0009', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0009', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0010', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0010', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0010', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0005', N'MP0010', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0010', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0010', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0010', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0010', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0011', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0011', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0003', N'MP0011', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0004', N'MP0011', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0005', N'MP0011', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0011', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0011', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0011', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0007', N'MP0001', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0006', N'MP0001', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0008', N'MP0001', 6, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0001', N'MP0002', 1, N'Đang sử dụng')
INSERT [dbo].[tb_PTB] ([MaTb], [MaPhong], [SoLuong], [TinhTrang]) VALUES (N'TB0002', N'MP0002', 1, N'Đang sử dụng')
GO
INSERT [dbo].[tb_SDDV] ([SoHD], [MaDV], [SoLuong], [NgayMua]) VALUES (N'HD0001', N'DV0009', N'1', CAST(N'2022-11-02' AS Date))
INSERT [dbo].[tb_SDDV] ([SoHD], [MaDV], [SoLuong], [NgayMua]) VALUES (N'HD0001', N'DV0010', N'1', CAST(N'2022-11-02' AS Date))
INSERT [dbo].[tb_SDDV] ([SoHD], [MaDV], [SoLuong], [NgayMua]) VALUES (N'HD0001', N'DV0011', N'2', CAST(N'2022-11-02' AS Date))
INSERT [dbo].[tb_SDDV] ([SoHD], [MaDV], [SoLuong], [NgayMua]) VALUES (N'HD0002', N'DV0007', N'1', CAST(N'2022-11-04' AS Date))
INSERT [dbo].[tb_SDDV] ([SoHD], [MaDV], [SoLuong], [NgayMua]) VALUES (N'HD0003', N'DV0003', N'1', CAST(N'2022-11-04' AS Date))
INSERT [dbo].[tb_SDDV] ([SoHD], [MaDV], [SoLuong], [NgayMua]) VALUES (N'HD0003', N'DV0005', N'3', CAST(N'2022-11-04' AS Date))
GO
INSERT [dbo].[tb_TB] ([MaTb], [TenTb], [Gia]) VALUES (N'TB0001', N'Tivi', N'10000000')
INSERT [dbo].[tb_TB] ([MaTb], [TenTb], [Gia]) VALUES (N'TB0002', N'Tủ Lạnh', N'5000000')
INSERT [dbo].[tb_TB] ([MaTb], [TenTb], [Gia]) VALUES (N'TB0003', N'Điều Hoà', N'5000000')
INSERT [dbo].[tb_TB] ([MaTb], [TenTb], [Gia]) VALUES (N'TB0004', N'Nóng lạnh', N'5000000')
INSERT [dbo].[tb_TB] ([MaTb], [TenTb], [Gia]) VALUES (N'TB0005', N'Ghế massage', N'30000000')
INSERT [dbo].[tb_TB] ([MaTb], [TenTb], [Gia]) VALUES (N'TB0006', N'Ấm siêu tốc', N'200000')
INSERT [dbo].[tb_TB] ([MaTb], [TenTb], [Gia]) VALUES (N'TB0007', N'Quạt trần', N'1000000')
INSERT [dbo].[tb_TB] ([MaTb], [TenTb], [Gia]) VALUES (N'TB0008', N'Bóng điện ', N'100000')
GO
ALTER TABLE [dbo].[tb_DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_tb_DatPhong_tb_HoaDon] FOREIGN KEY([SoHD])
REFERENCES [dbo].[tb_HoaDon] ([SoHD])
GO
ALTER TABLE [dbo].[tb_DatPhong] CHECK CONSTRAINT [FK_tb_DatPhong_tb_HoaDon]
GO
ALTER TABLE [dbo].[tb_DatPhong]  WITH CHECK ADD  CONSTRAINT [FK_tb_DatPhong_tb_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tb_Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[tb_DatPhong] CHECK CONSTRAINT [FK_tb_DatPhong_tb_Phong]
GO
ALTER TABLE [dbo].[tb_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDon_tb_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tb_KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tb_HoaDon] CHECK CONSTRAINT [FK_tb_HoaDon_tb_KhachHang]
GO
ALTER TABLE [dbo].[tb_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tb_HoaDon_tb_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tb_NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tb_HoaDon] CHECK CONSTRAINT [FK_tb_HoaDon_tb_NhanVien]
GO
ALTER TABLE [dbo].[tb_Phong]  WITH CHECK ADD  CONSTRAINT [FK_tb_Phong_tb_LoaiPhong] FOREIGN KEY([MaLP])
REFERENCES [dbo].[tb_LoaiPhong] ([MaLP])
GO
ALTER TABLE [dbo].[tb_Phong] CHECK CONSTRAINT [FK_tb_Phong_tb_LoaiPhong]
GO
ALTER TABLE [dbo].[tb_PTB]  WITH CHECK ADD  CONSTRAINT [FK_tb_PTB_tb_Phong] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[tb_Phong] ([MaPhong])
GO
ALTER TABLE [dbo].[tb_PTB] CHECK CONSTRAINT [FK_tb_PTB_tb_Phong]
GO
ALTER TABLE [dbo].[tb_PTB]  WITH CHECK ADD  CONSTRAINT [FK_tb_PTB_tb_TB] FOREIGN KEY([MaTb])
REFERENCES [dbo].[tb_TB] ([MaTb])
GO
ALTER TABLE [dbo].[tb_PTB] CHECK CONSTRAINT [FK_tb_PTB_tb_TB]
GO
ALTER TABLE [dbo].[tb_SDDV]  WITH CHECK ADD  CONSTRAINT [FK_tb_SDDV_tb_DichVu1] FOREIGN KEY([MaDV])
REFERENCES [dbo].[tb_DichVu] ([MaDV])
GO
ALTER TABLE [dbo].[tb_SDDV] CHECK CONSTRAINT [FK_tb_SDDV_tb_DichVu1]
GO
ALTER TABLE [dbo].[tb_SDDV]  WITH CHECK ADD  CONSTRAINT [FK_tb_SDDV_tb_HoaDon] FOREIGN KEY([SoHD])
REFERENCES [dbo].[tb_HoaDon] ([SoHD])
GO
ALTER TABLE [dbo].[tb_SDDV] CHECK CONSTRAINT [FK_tb_SDDV_tb_HoaDon]
GO
/****** Object:  StoredProcedure [dbo].[cau1]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[cau1] @makh nvarchar(10)
as
begin
	declare @table table (tenphong nvarchar(50))
	insert  @table (tenphong) 

	select  tb_Phong.TenPhong from tb_KhachHang JOIN tb_HoaDon ON tb_KhachHang.MaKH = tb_HoaDon.MaKH
	JOIN tb_DatPhong ON tb_HoaDon.SoHD = tb_DatPhong.SoHD JOIN tb_Phong ON tb_DatPhong.MaPhong = tb_Phong.MaPhong
	and tb_KhachHang.MaKH = @makh
	select *from @table
end
GO
/****** Object:  StoredProcedure [dbo].[cau2proc]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[cau2proc] @map nvarchar(10)
as
begin
	declare @table table (tenkh nvarchar(30) , ngaythanhtoan date)
	insert @table (tenkh,ngaythanhtoan)
	select tb_KhachHang.TenKH,tb_HoaDon.NgayThanhToan from tb_KhachHang, tb_HoaDon, tb_DatPhong
	where tb_KhachHang.MaKH = tb_HoaDon.MaKH and tb_HoaDon.SoHD = tb_DatPhong.SoHD and tb_DatPhong.MaPhong = @map 
	select *from @table
end
GO
/****** Object:  StoredProcedure [dbo].[cau3proc]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cau3proc] @sohd nvarchar(10)
as
begin
declare @table table (tendv nvarchar(50),soluong int)
select tb_DichVu.TenDV, tb_SDDV.SoLuong from tb_SDDV, tb_DichVu,tb_HoaDon
where tb_HoaDon.SoHD = tb_SDDV.SoHD and tb_SDDV.MaDV = tb_DichVu.MaDV  and tb_HoaDon.SoHD = @sohd
select * from @table
end
GO
/****** Object:  StoredProcedure [dbo].[cau4proc]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cau4proc] @mahd nvarchar(20) 
as
begin
declare @table table (tenkh nvarchar(50))
insert @table (tenkh)
select TenKH
from tb_HoaDon inner join tb_KhachHang on tb_HoaDon.MaKH = tb_KhachHang.MaKH
where tb_HoaDon.SoHD= @mahd
select * from @table
end
GO
/****** Object:  StoredProcedure [dbo].[cau5proc]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[cau5proc]  @ngayden date
as begin
declare @table table (makh nvarchar(10),tenkh nvarchar(20))
select distinct tb_KhachHang.MaKH, TenKH
from tb_HoaDon join tb_KhachHang on tb_HoaDon.MaKH = tb_KhachHang.MaKH
join tb_DatPhong on tb_DatPhong.SoHD = tb_HoaDon.SoHD
where NgayDen =@ngayden
select * from @table
end
GO
/****** Object:  StoredProcedure [dbo].[cau6proc]    Script Date: 04/11/2022 8:10:27 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[cau6proc] @sohd nvarchar(20)
as begin
declare @table table(tennv nvarchar(30),ngaythanhtoan date)
insert @table (tennv,ngaythanhtoan)
select TenNV,  NgayThanhToan
from tb_HoaDon inner join tb_NhanVien on tb_HoaDon.MaNV = tb_NhanVien.MaNV
where SoHD = @sohd
select * from @table
end
GO
