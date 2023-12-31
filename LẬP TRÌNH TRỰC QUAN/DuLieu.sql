CREATE DATABASE DuLieu
GO
USE [DuLieu]
GO
/****** Object:  Table [dbo].[tblChatLieu]    Script Date: 07/10/2022 9:04:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChatLieu](
	[MaChatLieu] [nvarchar](50) NOT NULL,
	[TenChatLieu] [ntext] NULL,
 CONSTRAINT [PK__tblChatL__453995BCB38C7B89] PRIMARY KEY CLUSTERED 
(
	[MaChatLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietHDBan]    Script Date: 07/10/2022 9:04:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHDBan](
	[MaHDBan] [nvarchar](50) NOT NULL,
	[MaHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
	[GiamGia] [nvarchar](50) NULL,
	[ThanhTien] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC,
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHang]    Script Date: 07/10/2022 9:04:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHang](
	[Mahang] [nvarchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[MaChatLieu] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGiaNhap] [float] NULL,
	[DonGiaBan] [float] NULL,
	[Anh] [ntext] NULL,
	[GhiChu] [ntext] NULL,
PRIMARY KEY CLUSTERED 
(
	[Mahang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHDBan]    Script Date: 07/10/2022 9:04:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHDBan](
	[MaHDBan] [nvarchar](50) NOT NULL,
	[MaNhanVien] [nvarchar](50) NULL,
	[NgayBan] [date] NULL,
	[MaKhach] [nvarchar](50) NULL,
	[TongTien] [nvarchar](50) NULL,
 CONSTRAINT [PK__tblHDBan__43106E2A98FCB947] PRIMARY KEY CLUSTERED 
(
	[MaHDBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhach]    Script Date: 07/10/2022 9:04:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhach](
	[Makhach] [nvarchar](50) NOT NULL,
	[TenKhach] [nvarchar](50) NULL,
	[DiaChi] [ntext] NULL,
	[DienThoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Makhach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 07/10/2022 9:04:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[Manhanvien] [nvarchar](50) NOT NULL,
	[Tennhanvien] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[GioiTinh] [nchar](10) NULL,
	[DiaChi] [ntext] NULL,
	[Dienthoai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 07/10/2022 9:04:27 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [ntext] NULL,
	[Quyen] [ntext] NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CL123', N'Mỹ ký cao cấp')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CL125', N'Đá xanh')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLG', N'Giấy      ')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLKK', N'Kim cương')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLM', N'Đá đỏ 1')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLMK', N'Mỹ ký thường')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLNew', N'Lụa cao cấp')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLNK', N'Nguyên liệu nhân tạo')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLV', N'Vải cao cấp')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLVG', N'Mỹ ký cao cấp')
INSERT [dbo].[tblChatLieu] ([MaChatLieu], [TenChatLieu]) VALUES (N'CLVT', N'Vải thường')
GO
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD181020160', N'H02', 5, N'10', N'585000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD181020160', N'H03', 5, N'10', N'675000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD181020160', N'H04', 1, N'5', N'114000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD281020153', N'H01', 3, N'10', N'324000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD281020154', N'H01', 4, N'10', N'432000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD281020155', N'H01', 10, N'20', N'960000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD281020155', N'H02', 7, N'5', N'864500')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120150', N'H01', 3, N'10', N'324000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120150', N'H02', 4, N'5', N'494000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120151', N'H02', 10, N'10', N'1170000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120152', N'H01', 2, N'4', N'230400')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120152', N'H02', 5, N'10', N'585000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120153', N'H01', 1, N'10', N'108000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120153', N'H02', 20, N'10', N'2340000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120154', N'H02', 10, N'5', N'1235000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD31120154', N'H03', 6, N'5', N'855000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD41120150', N'H03', 90, N'10', N'12150000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD41120150', N'H04', 5, N'10', N'540000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD41120151', N'H03', 4, N'10', N'540000')
INSERT [dbo].[tblChiTietHDBan] ([MaHDBan], [MaHang], [SoLuong], [GiamGia], [ThanhTien]) VALUES (N'HD41120151', N'H04', 5, N'10', N'540000')
GO
INSERT [dbo].[tblHang] ([Mahang], [TenHang], [MaChatLieu], [SoLuong], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu]) VALUES (N'H01', N'Gấu', N'CLV', 300, 120000, 500000, N'H04.jpg', N'')
INSERT [dbo].[tblHang] ([Mahang], [TenHang], [MaChatLieu], [SoLuong], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu]) VALUES (N'H02', N'Hoa cưới', N'CLV', 300, 120000, 1000000, N'Codau1.jpg', N'')
INSERT [dbo].[tblHang] ([Mahang], [TenHang], [MaChatLieu], [SoLuong], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu]) VALUES (N'H03', N'Đồng Hồ', N'CL125', 300, 90000, 300000, N'H03.jpg', N'')
INSERT [dbo].[tblHang] ([Mahang], [TenHang], [MaChatLieu], [SoLuong], [DonGiaNhap], [DonGiaBan], [Anh], [GhiChu]) VALUES (N'H04', N'Hoa hội nghị', N'CLNew', 300, 120000, 1000000, N'Gio5.jpg', N'')
GO
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD181020160', N'Nv        ', CAST(N'2016-10-18' AS Date), N'KH02', N'1374000')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD281020153', N'NV02      ', CAST(N'2015-10-28' AS Date), N'K01', N'324000')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD281020154', N'NV01      ', CAST(N'2015-10-28' AS Date), N'K01', N'432000')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD281020155', N'NV02      ', CAST(N'2015-10-28' AS Date), N'K01', N'1824500')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD31120150', N'NV02      ', CAST(N'2015-11-03' AS Date), N'KH02', N'818000')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD31120151', N'NV02      ', CAST(N'2015-11-03' AS Date), N'KH02', N'1170000')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD31120152', N'NV01      ', CAST(N'2015-11-03' AS Date), N'K01', N'815400')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD31120153', N'NV02      ', CAST(N'2015-11-03' AS Date), N'K01', N'2448000')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD31120154', N'NV01      ', CAST(N'2015-11-03' AS Date), N'KH02', N'2090000')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD41120150', N'NV02      ', CAST(N'2015-11-04' AS Date), N'K01', N'12690000')
INSERT [dbo].[tblHDBan] ([MaHDBan], [MaNhanVien], [NgayBan], [MaKhach], [TongTien]) VALUES (N'HD41120151', N'NV01      ', CAST(N'2015-11-04' AS Date), N'K01', N'1080000')
GO
INSERT [dbo].[tblKhach] ([Makhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'K01', N'Hoa', N'Hà Nội', N'098765443')
INSERT [dbo].[tblKhach] ([Makhach], [TenKhach], [DiaChi], [DienThoai]) VALUES (N'KH02', N'Lan', N'Nam Định', N'098765544')
GO
INSERT [dbo].[tblNhanVien] ([Manhanvien], [Tennhanvien], [ngaysinh], [GioiTinh], [DiaChi], [Dienthoai]) VALUES (N'Nv', N'Nguyễn Văn Anh', CAST(N'1988-10-10' AS Date), N'Nữ        ', N'A', N'0966045896')
INSERT [dbo].[tblNhanVien] ([Manhanvien], [Tennhanvien], [ngaysinh], [GioiTinh], [DiaChi], [Dienthoai]) VALUES (N'NV01', N'Nguyễn Thu Hường', CAST(N'1988-12-12' AS Date), N'Nữ        ', N'Động Anh - Hà Nội', N'0966047698')
INSERT [dbo].[tblNhanVien] ([Manhanvien], [Tennhanvien], [ngaysinh], [GioiTinh], [DiaChi], [Dienthoai]) VALUES (N'NV0123', N'Lan Anh', CAST(N'1988-06-06' AS Date), N'Nữ        ', N'A', N'0987654')
INSERT [dbo].[tblNhanVien] ([Manhanvien], [Tennhanvien], [ngaysinh], [GioiTinh], [DiaChi], [Dienthoai]) VALUES (N'NV0987', N'Công Anh', CAST(N'1990-12-23' AS Date), N'Nam       ', N'A', N'0987433')
INSERT [dbo].[tblNhanVien] ([Manhanvien], [Tennhanvien], [ngaysinh], [GioiTinh], [DiaChi], [Dienthoai]) VALUES (N'NV345676', N'Nguyễn Quốc Viêth', CAST(N'1988-12-30' AS Date), N'Nữ        ', N'A', N'34345')
GO
ALTER TABLE [dbo].[tblChiTietHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDBan_tblHang] FOREIGN KEY([MaHang])
REFERENCES [dbo].[tblHang] ([Mahang])
GO
ALTER TABLE [dbo].[tblChiTietHDBan] CHECK CONSTRAINT [FK_tblChiTietHDBan_tblHang]
GO
ALTER TABLE [dbo].[tblChiTietHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHDBan_tblHDBan] FOREIGN KEY([MaHDBan])
REFERENCES [dbo].[tblHDBan] ([MaHDBan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHDBan] CHECK CONSTRAINT [FK_tblChiTietHDBan_tblHDBan]
GO
ALTER TABLE [dbo].[tblHang]  WITH CHECK ADD  CONSTRAINT [FK_tblHang_tblChatLieu] FOREIGN KEY([MaChatLieu])
REFERENCES [dbo].[tblChatLieu] ([MaChatLieu])
GO
ALTER TABLE [dbo].[tblHang] CHECK CONSTRAINT [FK_tblHang_tblChatLieu]
GO
ALTER TABLE [dbo].[tblHDBan]  WITH CHECK ADD  CONSTRAINT [FK_tblHDBan_tblKhach] FOREIGN KEY([MaKhach])
REFERENCES [dbo].[tblKhach] ([Makhach])
GO
ALTER TABLE [dbo].[tblHDBan] CHECK CONSTRAINT [FK_tblHDBan_tblKhach]
GO
