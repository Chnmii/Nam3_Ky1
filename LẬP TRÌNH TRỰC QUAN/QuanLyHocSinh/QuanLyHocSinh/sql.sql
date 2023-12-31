CREATE DATABASE QLHSWINFORM
GO
USE [QLHSWINFORM]
GO
/****** Object:  Table [dbo].[HOCSINH]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOCSINH](
	[MaHS] [nvarchar](10) NOT NULL,
	[TenHS] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Diachi] [nvarchar](100) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Malop] [nvarchar](10) NULL,
	[Namhoc] [nvarchar](10) NULL,
	[Hanhkiem] [nvarchar](50) NULL,
	[Ghichu] [nvarchar](50) NULL,
	[DiemTB] [float] NULL,
 CONSTRAINT [PK__HOCSINH__2725A6EF37CFDF45] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_chart]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   view [dbo].[view_chart] as
select ISNULL(Hanhkiem, 1) as Hanhkiem , count(Hanhkiem) as SL
from HOCSINH
GROUP BY Hanhkiem
GO
/****** Object:  Table [dbo].[GIAOVIEN]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOVIEN](
	[MaGV] [nvarchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NULL,
	[Malop] [nvarchar](10) NOT NULL,
	[Diachi] [nvarchar](100) NULL,
	[SDT] [nvarchar](10) NULL,
	[MonDay] [nvarchar](50) NULL,
	[Ngaysinh] [date] NULL,
	[Gioitinh] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_chart2]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   view [dbo].[view_chart2] as
select MonDay , count(MonDay) as SL
from GIAOVIEN
GROUP BY MonDay
GO
/****** Object:  Table [dbo].[BANGDIEMHK1]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGDIEMHK1](
	[MaBDHK1] [nvarchar](20) NOT NULL,
	[Toan] [float] NULL,
	[Van] [float] NULL,
	[Anh] [float] NULL,
	[Ly] [float] NULL,
	[Hoa] [float] NULL,
	[Sinh] [float] NULL,
	[Dialy] [float] NULL,
	[Congdan] [float] NULL,
	[Congnghe] [float] NULL,
	[Tinhoc] [float] NULL,
	[Theduc] [nvarchar](10) NULL,
	[Lichsu] [float] NULL,
	[MaHS] [nvarchar](10) NULL,
	[DiemTB] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBDHK1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BANGDIEMHK2]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGDIEMHK2](
	[MaBDHK2] [nvarchar](20) NOT NULL,
	[Toan] [float] NULL,
	[Van] [float] NULL,
	[Anh] [float] NULL,
	[Ly] [float] NULL,
	[Hoa] [float] NULL,
	[Sinh] [float] NULL,
	[Dialy] [float] NULL,
	[Congdan] [float] NULL,
	[Congnghe] [float] NULL,
	[Tinhoc] [float] NULL,
	[Theduc] [nvarchar](10) NULL,
	[Lichsu] [float] NULL,
	[MaHS] [nvarchar](10) NULL,
	[DiemTB] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBDHK2] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chart]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chart](
	[X] [nvarchar](10) NULL,
	[Y] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOPHOC]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOPHOC](
	[Malop] [nvarchar](10) NOT NULL,
	[Siso] [int] NULL,
	[GVCN] [nvarchar](50) NOT NULL,
	[KHOI] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tUSER]    Script Date: 11/24/2022 10:58:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tUSER](
	[username] [nvarchar](30) NOT NULL,
	[password] [nvarchar](30) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0001', 9, 7.8, 8.1, 8.6, 7.9, 8, 7, 7, 8.2, 9, N'Đạt', 8, N'HS0001', 8.05)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0002', 9.1, 8, 7, 8.6, 8, 8, 7.5, 7, 8.2, 9, N'Đạt', 8.1, N'HS0002', 8.05)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0003', 8.8, 7, 7.9, 8, 7.9, 8, 7, 6, 8.2, 9, N'Đạt', 8, N'HS0003', 7.8)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0004', 8.1, 7.8, 8, 8.6, 9, 8, 7.1, 6.5, 8.2, 9, N'Đạt', 8.9, N'HS0004', 8.11)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0005', 9, 8, 8, 9, 9, 8, 9, 9, 8, 8, N'Đạt', 9, N'HS0005', 8.55)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0006', 9.8, 7, 8, 8.1, 7.9, 7.1, 8.1, 9, 8.9, 10, N'Đạt', 6.7, N'HS0006', 8.24)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0007', 10, 10, 9, 8, 7, 6, 10, 10, 7, 7, N'Đạt', 7, N'HS0007', 8.27)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0008', 6, 8, 8, 7, 6, 6, 7, 8, 6, 7, N'Đạt', 5, N'HS0008', 6.73)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0009', 9, 7, 6.1, 5, 8, 7, 7, 9, 7.8, 8.5, N'Đạt', 6, N'HS0009', 7.31)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0010', 6, 7, 6.5, 6.8, 7, 7.1, 6.8, 7.6, 7.6, 8, N'Đạt', 8, N'HS0010', 7.13)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0011', 8, 6, 7.5, 7.3, 8.1, 6.8, 8.1, 7.8, 8.5, 7, N'Đạt', 7.6, N'HS0011', 7.52)
INSERT [dbo].[BANGDIEMHK1] ([MaBDHK1], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0012', 8, 7.8, 9, 8.7, 8.8, 7.8, 8.6, 7.5, 7, 7.8, N'Đạt', 7.6, N'HS0012', 8.05)
GO
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0001', 9, 7.8, 8.1, 8.6, 7.9, 8, 7, 7, 8.2, 9, N'Đạt', 8, N'HS0001', 8.05)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0002', 9.1, 8, 7, 8.6, 8, 8, 7.5, 7, 8.2, 9, N'Đạt', 8.1, N'HS0002', 8.05)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0003', 8.8, 7, 7.9, 8, 7.9, 8, 7, 6, 8.2, 9, N'Đạt', 8, N'HS0003', 7.8)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_1_HS0004', 10, 8, 8, 8.6, 9, 8, 10, 9, 8.2, 9, N'Đạt', 8.9, N'HS0004', 8.79)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_2_HS0005', 10, 8, 9, 10, 7, 7, 8, 8, 9, 10, N'Đạt', 7, N'HS0005', 8.45)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_2_HS0006', 10, 9, 7, 7, 7, 8, 7, 7.8, 7, 10, N'Đạt', 8, N'HS0006', 7.98)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_2_HS0007', 10, 9, 7, 8, 8, 7, 8, 8, 9, 10, N'Đạt', 8, N'HS0007', 8.36)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_2_HS0008', 8, 9, 8, 7.1, 6, 8, 8, 7, 10, 10, N'Đạt', 6, N'HS0008', 7.92)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_2_HS0009', 8, 6, 7.5, 8, 8.7, 7.8, 7.3, 8.2, 9.7, 7.9, N'Đạt', 6.9, N'HS0009', 7.82)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_2_HS0010', 6, 7, 6, 5, 6.8, 6, 6, 7, 6, 6.5, N'Đạt', 7.8, N'HS0010', 6.37)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_2_HS0011', 6.5, 7.5, 8.1, 7.8, 9, 8.5, 7.8, 7, 10, 7.9, N'Đạt', 6.5, N'HS0011', 7.87)
INSERT [dbo].[BANGDIEMHK2] ([MaBDHK2], [Toan], [Van], [Anh], [Ly], [Hoa], [Sinh], [Dialy], [Congdan], [Congnghe], [Tinhoc], [Theduc], [Lichsu], [MaHS], [DiemTB]) VALUES (N'2022_2023_2_HS0012', 6, 6.5, 7, 7.5, 6.8, 6.6, 7.3, 7.2, 7, 6.5, N'Đạt', 7.1, N'HS0012', 6.86)
GO
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'0-1', 0)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'1-2', 0)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'2-3', 0)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'3-4', 0)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'4-5', 0)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'6-7', 1)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'7-8', 5)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'8-9', 6)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'9-10', 0)
INSERT [dbo].[Chart] ([X], [Y]) VALUES (N'Chưa sắp', 0)
GO
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV001', N'Narutobaco', N'10A-A', N'Nam Định', N'098765241', N'Giải tích', CAST(N'2000-10-11' AS Date), N'Nam')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV002', N'Kakashi', N'10B-A1', N'Hà Giang', N'098761234', N'Vật lý', CAST(N'1997-09-11' AS Date), N'Nam')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV003', N'Uchihaha', N'10C-B', N'Nam Định', N'098798789', N'Sinh học', CAST(N'1990-01-07' AS Date), N'Nam')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV004', N'Saringan nhiễm mỡ', N'10D-C', N'Hà Nội', N'098766667', N'Ngữ Văn', CAST(N'1999-07-11' AS Date), N'Nữ')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV005', N'Master Chief', N'10A-A', N'Việt Nam', N'0987458371', N'Giải tích', CAST(N'1997-07-19' AS Date), N'Nam')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV006', N'Elon Musk', N'10C-B', N'Nghệ An', N'0987121789', N'Sinh học', CAST(N'1988-01-07' AS Date), N'Nam')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV007', N'Low G', N'10D-C', N'Hà Nội', N'0987879166', N'Thể dục', CAST(N'1989-06-10' AS Date), N'Nam')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV008', N'Caitlyn', N'10C-B', N'Hải Dương', N'0987912319', N'Thể dục', CAST(N'1997-02-13' AS Date), N'Nữ')
INSERT [dbo].[GIAOVIEN] ([MaGV], [TenGV], [Malop], [Diachi], [SDT], [MonDay], [Ngaysinh], [Gioitinh]) VALUES (N'GV009', N'Chí Phèo', N'10D-C', N'Hà Nội', N'0983263661', N'Ngữ Văn', CAST(N'1981-01-11' AS Date), N'Nam')
GO
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0001', N'Jvevermind', CAST(N'2007-10-11' AS Date), N'Vietnam', N'Nam', N'10A-A', N'2022-2025', N'Tốt', N'Nghèo', 8.05)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0002', N'Trần Đức Nam', CAST(N'2007-09-01' AS Date), N'Vietnam', N'Nam', N'10A-A', N'2022-2025', N'Tốt', N'', 8.05)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0003', N'Trần Đức Việt', CAST(N'2007-05-19' AS Date), N'Vietnam', N'Nam', N'10B-A1', N'2022-2025', N'Khá', N'', 7.8)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0004', N'Thùy Tiên', CAST(N'2007-01-28' AS Date), N'Vietnam', N'Nữ', N'10D-C', N'2022-2025', N'Khá', N'', 8.56)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0005', N'OGGY', CAST(N'2007-11-18' AS Date), N'Vietnam', N'Nữ', N'10B-A1', N'2022-2025', N'Tốt', N'Cận nghèo', 8.48)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0006', N'SARO', CAST(N'2007-11-19' AS Date), N'Vietnam', N'Nam', N'10D-C', N'2022-2025', N'Tốt', N'', 8.07)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0007', N'RYTHMIND', CAST(N'2010-09-15' AS Date), N'Vietnam', N'Nam', N'10A-A', N'2022-2025', N'Tốt', N'', 8.3)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0008', N'SYML', CAST(N'2007-11-20' AS Date), N'Vietnam', N'Nam', N'11A-A', N'2021-2024', N'Khá', N'', 7.52)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0009', N'JACK', CAST(N'2007-10-01' AS Date), N'Vietnam', N'Nam', N'10C-B', N'2022-2025', N'Tốt', N'', 7.65)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0010', N'RUSY', CAST(N'2007-08-20' AS Date), N'Vietnam', N'Nữ', N'11B-A1', N'2021-2024', N'Khá', N'', 6.62)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0011', N'SOSO', CAST(N'2006-07-01' AS Date), N'Vietnam', N'Nữ', N'11C-B', N'2021-2024', N'Tốt', N'Cận nghèo', 7.75)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0012', N'YOLO', CAST(N'2006-11-20' AS Date), N'Vietnam', N'Nam', N'11D-C', N'2021-2024', N'Tốt', N'', 7.26)
INSERT [dbo].[HOCSINH] ([MaHS], [TenHS], [Ngaysinh], [Diachi], [Gioitinh], [Malop], [Namhoc], [Hanhkiem], [Ghichu], [DiemTB]) VALUES (N'HS0013', N'HELLO', CAST(N'2022-11-22' AS Date), N'Vietnam', N'Nam', N'10B-A1', N'2022-2025', N'', N'', NULL)
GO
INSERT [dbo].[LOPHOC] ([Malop], [Siso], [GVCN], [KHOI]) VALUES (N'10A-A', 30, N'Narutobaco', N'A')
INSERT [dbo].[LOPHOC] ([Malop], [Siso], [GVCN], [KHOI]) VALUES (N'10B-A1', 32, N'Uchiahahaha', N'A1')
INSERT [dbo].[LOPHOC] ([Malop], [Siso], [GVCN], [KHOI]) VALUES (N'10C-B', 34, N'Kakashi', N'B')
INSERT [dbo].[LOPHOC] ([Malop], [Siso], [GVCN], [KHOI]) VALUES (N'10D-C', 30, N'Sharingan nhiễm mỡ', N'C')
INSERT [dbo].[LOPHOC] ([Malop], [Siso], [GVCN], [KHOI]) VALUES (N'11A-A', 29, N'Elon Musk', N'A')
INSERT [dbo].[LOPHOC] ([Malop], [Siso], [GVCN], [KHOI]) VALUES (N'11B-A1', 35, N'Low G', N'A1')
INSERT [dbo].[LOPHOC] ([Malop], [Siso], [GVCN], [KHOI]) VALUES (N'11C-B', 32, N'Master Chief', N'B')
INSERT [dbo].[LOPHOC] ([Malop], [Siso], [GVCN], [KHOI]) VALUES (N'11D-C', 30, N'Caitlyn', N'C')
GO
INSERT [dbo].[tUSER] ([username], [password]) VALUES (N'admin', N'1234')
INSERT [dbo].[tUSER] ([username], [password]) VALUES (N'manager', N'1234')
GO
ALTER TABLE [dbo].[BANGDIEMHK1]  WITH CHECK ADD FOREIGN KEY([MaHS])
REFERENCES [dbo].[HOCSINH] ([MaHS])
GO
ALTER TABLE [dbo].[BANGDIEMHK2]  WITH CHECK ADD FOREIGN KEY([MaHS])
REFERENCES [dbo].[HOCSINH] ([MaHS])
GO
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK ADD FOREIGN KEY([Malop])
REFERENCES [dbo].[LOPHOC] ([Malop])
GO
ALTER TABLE [dbo].[HOCSINH]  WITH CHECK ADD  CONSTRAINT [FK__HOCSINH__Malop__2B3F6F97] FOREIGN KEY([Malop])
REFERENCES [dbo].[LOPHOC] ([Malop])
GO
ALTER TABLE [dbo].[HOCSINH] CHECK CONSTRAINT [FK__HOCSINH__Malop__2B3F6F97]
GO
