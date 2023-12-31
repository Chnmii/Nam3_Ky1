CREATE DATABASE QLyKhachSan
Go
USE [QLyKhachSan]
GO
/****** Object:  Table [dbo].[BOPHANLAMVIEC]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHANLAMVIEC](
	[TenBP] [nvarchar](50) NOT NULL,
	[MaBP] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETDICHVU]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETDICHVU](
	[MaDV] [nvarchar](10) NOT NULL,
	[SLDV] [int] NOT NULL,
	[ThoigianSDDV] [datetime] NOT NULL,
	[DongiaDV] [money] NOT NULL,
	[KMDV] [float] NOT NULL,
	[MaHDDV] [nvarchar](10) NOT NULL,
	
	
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC,
	[MaHDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHONGDAT]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHONGDAT](
	[MaBooking] [nvarchar](10) NOT NULL,
	[SLPhong] [int] NOT NULL,
	[MaLP] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBooking] ASC,
	[MaLP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETVD]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETVD](
	[MaVD] [nvarchar](10) NOT NULL,
	[SLVD] [int] NOT NULL,
	[MaLP] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLP] ASC,
	[MaVD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaCV] [nvarchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDV] [nvarchar](10) NOT NULL,
	[TenDV] [nvarchar](50) NOT NULL,
	[Donvitinh] [nvarchar](10) NOT NULL,
	[MaNHOMDV] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DONGHDTT]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DONGHDTT](
	[MaDV] [nvarchar](10) NOT NULL,
	[Thoigiansudung] [datetime] NOT NULL,
	[SLDichVu] [int] NOT NULL,
	[DongiaDV] [money] NOT NULL,
	[SoPhong] [nvarchar](10) NOT NULL,
	[KMDV] [float] NOT NULL,
	[MaHDTT] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Thoigiansudung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HDDV]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HDDV](
	[MaHDDV] [nvarchar](10) NOT NULL,
	[ThoiGianLap] [datetime] NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONTT]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONTT](
	[MaHDTT] [nvarchar](10) NOT NULL,
	[Ghichu] [nvarchar](100) NULL,
	[NgayTT] [datetime] NULL,
	[NgayLapHD] [datetime] NULL,
	[PhuongthucTT] [nvarchar](50) NOT NULL,
	[MaNV] [nvarchar](10) NOT NULL,
	[MaBooking] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Dienthoai] [nvarchar](10) NOT NULL,
	[CCCD] [nvarchar](12) NULL,
	[Tuoi] [int] NULL,
	[Gioitinh] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MaLP] [nvarchar](10) NOT NULL,
	[Kieuphong] [nvarchar](10) NOT NULL,
	[Dientich] [float] NOT NULL,
	[Dongiaphong] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [nvarchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NOT NULL,
	[SoCMND] [nvarchar](12) NOT NULL,
	[SDT] [nvarchar](10) NOT NULL,
	[MaCV] [nvarchar](10) NOT NULL,
	[MaBP] [nvarchar](10) NOT NULL,
	[Gioitinh] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHOMDICHVU]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHOMDICHVU](
	[MaNHOMDV] [nvarchar](10) NOT NULL,
	[TenNHOMDV] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNHOMDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUDAT]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDAT](
	[MaBooking] [nvarchar](10) NOT NULL,
	[Tiendatcoc] [money] NOT NULL,
	[NgayDenDukien] [date] NOT NULL,
	[NgayDiDuKien] [date] NOT NULL,
	[Phuongthucdatcoc] [nvarchar](10) NULL,
	[MaKH] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBooking] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUTHUE]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTHUE](
	[MaPT] [nvarchar](10) NOT NULL,
	[ThoigianlapPT] [datetime] NOT NULL,
	[Thoigiancheckout] [datetime] NULL,
	[Thoigiancheckin] [datetime] NULL,
	[KMPhong] [float] NULL,
	[Dongiaphong] [money] NULL,
	[Maphong] [nvarchar](10) NOT NULL,
	[MaBooking] [nvarchar](10) NOT NULL,

PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[Maphong] [nvarchar](10) NOT NULL,
	[TinhTrang] [nvarchar](50) NOT NULL,
	[MaLP] [nvarchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLogin]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLogin](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VATDUNG]    Script Date: 11/10/2022 1:21:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VATDUNG](
	[MaVD] [nvarchar](10) NOT NULL,
	[TenVD] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaVD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BOPHANLAMVIEC] ([TenBP], [MaBP]) VALUES (N'Bộ phận tiền sảnh', N'BP01')
INSERT [dbo].[BOPHANLAMVIEC] ([TenBP], [MaBP]) VALUES (N'Bộ phận dịch vụ', N'BP02')
INSERT [dbo].[BOPHANLAMVIEC] ([TenBP], [MaBP]) VALUES (N'Bộ phận buồng phòng', N'BP03')
INSERT [dbo].[BOPHANLAMVIEC] ([TenBP], [MaBP]) VALUES (N'Bộ phận kế toán', N'BP04')
GO
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-01-10T00:00:00.000' AS DateTime), 100000.0000, 1, N'DV001', N'HDDV0001')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-03-14T00:00:00.000' AS DateTime), 100000.0000, 0.5, N'DV001', N'HDDV0019')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-01-10T00:00:00.000' AS DateTime), 200000.0000, 0.1, N'DV002', N'HDDV0002')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-01-19T00:00:00.000' AS DateTime), 200000.0000, 0, N'DV002', N'HDDV0003')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-01-22T00:00:00.000' AS DateTime), 200000.0000, 1, N'DV003', N'HDDV0004')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-03-13T00:00:00.000' AS DateTime), 200000.0000, 0, N'DV003', N'HDDV0018')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-02-01T00:00:00.000' AS DateTime), 500000.0000, 0, N'DV004', N'HDDV0005')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-03-10T00:00:00.000' AS DateTime), 200000.0000, 0, N'DV005', N'HDDV0017')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-02-02T00:00:00.000' AS DateTime), 250000.0000, 0, N'DV007', N'HDDV0006')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-03-02T00:00:00.000' AS DateTime), 250000.0000, 0.5, N'DV007', N'HDDV0013')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-02-03T00:00:00.000' AS DateTime), 300000.0000, 0.1, N'DV008', N'HDDV0007')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-03-04T00:00:00.000' AS DateTime), 300000.0000, 0, N'DV008', N'HDDV0014')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-03-04T00:00:00.000' AS DateTime), 300000.0000, 0.1, N'DV008', N'HDDV0016')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-02-24T00:00:00.000' AS DateTime), 200000.0000, 0, N'DV009', N'HDDV0012')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-02-16T00:00:00.000' AS DateTime), 100000.0000, 0.2, N'DV011', N'HDDV0009')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-02-22T00:00:00.000' AS DateTime), 100000.0000, 0, N'DV011', N'HDDV0010')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-02-23T00:00:00.000' AS DateTime), 100000.0000, 0, N'DV011', N'HDDV0011')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-02-09T00:00:00.000' AS DateTime), 100000.0000, 0, N'DV012', N'HDDV0008')
INSERT [dbo].[CHITIETDICHVU] ([SLDV], [ThoigianSDDV], [DongiaDV], [KMDV], [MaDV], [MaHDDV]) VALUES (1, CAST(N'2022-03-10T00:00:00.000' AS DateTime), 500000.0000, 0, N'DV014', N'HDDV0015')
GO
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0001', N'Standard01')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (1, N'PD0002', N'Standard02')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (1, N'PD0003', N'Deluxe01')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (1, N'PD0003', N'Superior01')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0004', N'Standard01')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0005', N'Suite01')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (1, N'PD0006', N'Standard01')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0006', N'Standard02')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0007', N'Standard01')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0008', N'Superior03')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0009', N'Standard01')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0010', N'Deluxe02')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (1, N'PD0010', N'Suite02')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (1, N'PD0010', N'Suite03')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0011', N'Deluxe02')
INSERT [dbo].[CHITIETPHONGDAT] ([SLPhong], [MaBooking], [MaLP]) VALUES (2, N'PD0012', N'Suite03')
GO
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Deluxe01', N'VD02')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Deluxe01', N'VD03')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (4, N'Deluxe01', N'VD04')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Deluxe02', N'VD03')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (4, N'Deluxe02', N'VD04')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (2, N'Deluxe02', N'VD05')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Standard01', N'VD02')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (2, N'Standard01', N'VD04')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Standard02', N'VD05')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Suite04', N'VD01')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (6, N'Suite04', N'VD04')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Superior01', N'VD04')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Superior02', N'VD03')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (3, N'Superior02', N'VD04')
INSERT [dbo].[CHITIETVD] ([SLVD], [MaLP], [MaVD]) VALUES (1, N'Superior02', N'VD05')
GO
INSERT [dbo].[CHUCVU] ([TenCV], [MaCV]) VALUES (N'Trưởng phòng', N'CV01')
INSERT [dbo].[CHUCVU] ([TenCV], [MaCV]) VALUES (N'Nhân viên', N'CV02')
INSERT [dbo].[CHUCVU] ([TenCV], [MaCV]) VALUES (N'Quản lý', N'CV03')
GO
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV001', N'Bữa sáng cho cặp đôi', N'Bữa', N'NDV01')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV002', N'Bữa trưa cho cặp đôi', N'Bữa', N'NDV01')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV003', N'Bữa tối cho cặp đôi', N'Bữa', N'NDV01')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV004', N'Túi gậy Golf', N'Túi', N'NDV02')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV005', N'Xe chở đến sân Golf', N'Xe', N'NDV02')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV006', N'Sân đánh golf', N'Sân', N'NDV02')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV007', N'Spa', N'Người', N'NDV03')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV008', N'Massage', N'Người', N'NDV03')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV009', N'Xe đưa đón đến sân bay', N'Xe', N'NDV04')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV010', N'Dọn phòng', N'Lần', N'NDV05')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV011', N'Dọn chăn ga gối đệm', N'Lần', N'NDV06')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV012', N'Giặt quần áo', N'Lần', N'NDV06')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV013', N'Kính bơi', N'Cặp', N'NDV07')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [Donvitinh], [MaNHOMDV]) VALUES (N'DV014', N'Đu Quay', N'Lần', N'NDV08')
GO
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-01-10T00:00:00.000' AS DateTime), 1, 100000.0000, N'P101', 0.1, N'HDTT0001', N'DV001')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-01-10T10:10:00.000' AS DateTime), 1, 200000.0000, N'P101', 1, N'HDTT0001', N'DV002')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-01-19T00:00:00.000' AS DateTime), 1, 200000.0000, N'P102', 0, N'HDTT0002', N'DV002')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-01-22T00:00:00.000' AS DateTime), 1, 200000.0000, N'P301', 1, N'HDTT0003', N'DV003')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-02-01T00:00:00.000' AS DateTime), 1, 500000.0000, N'P101', 0, N'HDTT0004', N'DV004')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-02-02T00:00:00.000' AS DateTime), 1, 250000.0000, N'P101', 0, N'HDTT0004', N'DV007')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-02-03T00:00:00.000' AS DateTime), 1, 300000.0000, N'P101', 0.1, N'HDTT0004', N'DV008')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-02-09T00:00:00.000' AS DateTime), 1, 100000.0000, N'P401', 0, N'HDTT0005', N'DV012')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-02-16T00:00:00.000' AS DateTime), 1, 100000.0000, N'P102', 0.2, N'HDTT0006', N'DV011')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-02-22T00:00:00.000' AS DateTime), 1, 100000.0000, N'P101', 0, N'HDTT0007', N'DV011')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-02-24T00:00:00.000' AS DateTime), 1, 200000.0000, N'P101', 0, N'HDTT0007', N'DV009')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-03-02T00:00:00.000' AS DateTime), 1, 250000.0000, N'P304', 0.5, N'HDTT0008', N'DV007')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-03-04T00:00:00.000' AS DateTime), 1, 300000.0000, N'P304', 0, N'HDTT0009', N'DV008')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-03-10T00:00:00.000' AS DateTime), 1, 200000.0000, N'P304', 0, N'HDTT0012', N'DV005')
INSERT [dbo].[DONGHDTT] ([Thoigiansudung], [SLDichVu], [DongiaDV], [SoPhong], [KMDV], [MaHDTT], [MaDV]) VALUES (CAST(N'2022-03-13T00:00:00.000' AS DateTime), 1, 100000.0000, N'P304', 0.5, N'HDTT0012', N'DV001')
GO
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0001', CAST(N'2022-01-10T00:00:00.000' AS DateTime), N'NV002', N'KH0001')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0002', CAST(N'2022-01-10T00:00:00.000' AS DateTime), N'NV002', N'KH0001')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0003', CAST(N'2022-01-19T00:00:00.000' AS DateTime), N'NV002', N'KH0002')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0004', CAST(N'2022-01-22T00:00:00.000' AS DateTime), N'NV002', N'KH0003')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0005', CAST(N'2022-02-01T00:00:00.000' AS DateTime), N'NV002', N'KH0004')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0006', CAST(N'2022-02-02T00:00:00.000' AS DateTime), N'NV002', N'KH0004')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0007', CAST(N'2022-02-03T00:00:00.000' AS DateTime), N'NV002', N'KH0004')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0008', CAST(N'2022-02-09T00:00:00.000' AS DateTime), N'NV002', N'KH0001')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0009', CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'NV002', N'KH0005')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0010', CAST(N'2022-02-22T00:00:00.000' AS DateTime), N'NV002', N'KH0006')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0011', CAST(N'2022-02-23T00:00:00.000' AS DateTime), N'NV002', N'KH0006')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0012', CAST(N'2022-02-24T00:00:00.000' AS DateTime), N'NV002', N'KH0006')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0013', CAST(N'2022-03-02T00:00:00.000' AS DateTime), N'NV002', N'KH0007')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0014', CAST(N'2022-03-04T00:00:00.000' AS DateTime), N'NV002', N'KH0008')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0015', CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'NV002', N'KH0009')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0016', CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'NV002', N'KH0005')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0017', CAST(N'2022-03-11T00:00:00.000' AS DateTime), N'NV002', N'KH0010')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0018', CAST(N'2022-03-13T00:00:00.000' AS DateTime), N'NV002', N'KH0010')
INSERT [dbo].[HDDV] ([MaHDDV], [ThoiGianLap], [MaNV], [MaKH]) VALUES (N'HDDV0019', CAST(N'2022-03-14T00:00:00.000' AS DateTime), N'NV002', N'KH0010')
GO
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-01-12T00:00:00.000' AS DateTime), N'HDTT0001', N'Cash', N'NV001', N'PD0001', CAST(N'2022-01-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-01-21T00:00:00.000' AS DateTime), N'HDTT0002', N'Cash', N'NV001', N'PD0002', CAST(N'2022-01-19T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-01-23T00:00:00.000' AS DateTime), N'HDTT0003', N'Cash', N'NV001', N'PD0003', CAST(N'2022-01-21T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-02-05T00:00:00.000' AS DateTime), N'HDTT0004', N'Credit Card', N'NV001', N'PD0004', CAST(N'2022-01-30T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-02-12T00:00:00.000' AS DateTime), N'HDTT0005', N'Cash', N'NV001', N'PD0005', CAST(N'2022-02-09T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-02-20T00:00:00.000' AS DateTime), N'HDTT0006', N'Credit Card', N'NV001', N'PD0006', CAST(N'2022-02-16T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-02-27T00:00:00.000' AS DateTime), N'HDTT0007', N'Cash', N'NV001', N'PD0007', CAST(N'2022-02-21T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-03-03T00:00:00.000' AS DateTime), N'HDTT0008', N'Cash', N'NV001', N'PD0008', CAST(N'2022-03-01T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-03-05T00:00:00.000' AS DateTime), N'HDTT0009', N'Credit Card', N'NV001', N'PD0009', CAST(N'2022-03-04T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-03-12T00:00:00.000' AS DateTime), N'HDTT0010', N'Cash', N'NV001', N'PD0010', CAST(N'2022-03-10T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-02-15T00:00:00.000' AS DateTime), N'HDTT0011', N'Cash', N'NV001', N'PD0011', CAST(N'2022-03-12T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, CAST(N'2022-02-15T00:00:00.000' AS DateTime), N'HDTT0012', N'Cash', N'NV001', N'PD0012', CAST(N'2022-03-12T00:00:00.000' AS DateTime))
INSERT [dbo].[HOADONTT] ([Ghichu], [NgayTT], [MaHDTT], [PhuongthucTT], [MaNV], [MaBooking], [NgayLapHD]) VALUES (NULL, NULL, N'HDTT0013', N'Cash', N'NV001', N'PD0013', CAST(N'2022-11-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Narutobaco', N'Việt Nam', N'KH0001', N'0987654321', N'030099182831', 23, 1)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Sasukehehe', N'Việt Nam', N'KH0002', N'0987654123', N'030099182112', 45, 1)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Uchihahaha', N'Việt Nam', N'KH0003', N'0987657732', N'030099182718', 44, 1)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Sharingan Nhiễm Mỡ', N'Việt Nam', N'KH0004', N'0987665471', N'897199182831', 24, 0)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Hoàng Tử Bóng Đêm', N'Việt Nam', N'KH0005', N'0987687621', N'871099182311', 28, 1)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Chiến Thần Săn Sale', N'Việt Nam', N'KH0006', N'0987688917', N'201099182871', 30, 0)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Lép Tôn Tôi', N'Việt Nam', N'KH0007', N'0987654321', N'030099175612', 21, 1)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Xuân Bắc', N'Việt Nam', N'KH0008', N'0987654777', N'987128361861', 18, 1)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Tự Long', N'Việt Nam', N'KH0009', N'0987654666', N'289374982137', 55, 1)
INSERT [dbo].[KHACHHANG] ([TenKH], [Diachi], [MaKH], [Dienthoai], [CCCD], [Tuoi], [Gioitinh]) VALUES (N'Cương Thủ', N'Việt Nam', N'KH0010', N'0987678543', N'311231413218', 60, 0)
GO
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Single', 40.1, N'Deluxe01', 7000000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Twin', 40.1, N'Deluxe02', 8000000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Single', 20.1, N'Standard01', 2000000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Twin', 20.1, N'Standard02', 3000000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Single', 40.1, N'Suite01', 9000000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Twin', 40.1, N'Suite02', 9500000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Triple', 40.1, N'Suite03', 10000000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Queen', 40.1, N'Suite04', 10500000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Single', 30.5, N'Superior01', 4000000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Twin', 30.5, N'Superior02', 4500000.0000)
INSERT [dbo].[LOAIPHONG] ([Kieuphong], [Dientich], [MaLP], [Dongiaphong]) VALUES (N'Triple', 30.5, N'Superior03', 5500000.0000)
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SoCMND], [SDT], [MaCV], [MaBP], [Gioitinh]) VALUES (N'NV001', N'Nguyễn Thùy Linh', N'030202012456', N'0321542142', N'CV01', N'BP01', 0)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SoCMND], [SDT], [MaCV], [MaBP], [Gioitinh]) VALUES (N'NV002', N'Trần Đức Nam', N'030202065432', N'0321542132', N'CV02', N'BP02', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SoCMND], [SDT], [MaCV], [MaBP], [Gioitinh]) VALUES (N'NV003', N'Xuân Dã Anh', N'030202032156', N'0321542361', N'CV02', N'BP03', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SoCMND], [SDT], [MaCV], [MaBP], [Gioitinh]) VALUES (N'NV004', N'Vũ Tri Ba Tá Trợ', N'030202123123', N'0321544142', N'CV03', N'BP04', 1)
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [SoCMND], [SDT], [MaCV], [MaBP], [Gioitinh]) VALUES (N'NV005', N'Tuyền Qua Minh Nhân', N'030202077777', N'0321495342', N'CV02', N'BP04', 1)
GO
INSERT [dbo].[NHOMDICHVU] ([TenNHOMDV], [MaNHOMDV]) VALUES (N'F&B', N'NDV01')
INSERT [dbo].[NHOMDICHVU] ([TenNHOMDV], [MaNHOMDV]) VALUES (N'Golf', N'NDV02')
INSERT [dbo].[NHOMDICHVU] ([TenNHOMDV], [MaNHOMDV]) VALUES (N'Làm đẹp', N'NDV03')
INSERT [dbo].[NHOMDICHVU] ([TenNHOMDV], [MaNHOMDV]) VALUES (N'Xe đưa đón', N'NDV04')
INSERT [dbo].[NHOMDICHVU] ([TenNHOMDV], [MaNHOMDV]) VALUES (N'Buồng phòng', N'NDV05')
INSERT [dbo].[NHOMDICHVU] ([TenNHOMDV], [MaNHOMDV]) VALUES (N'Cơ bản', N'NDV06')
INSERT [dbo].[NHOMDICHVU] ([TenNHOMDV], [MaNHOMDV]) VALUES (N'Bơi lội', N'NDV07')
INSERT [dbo].[NHOMDICHVU] ([TenNHOMDV], [MaNHOMDV]) VALUES (N'Giải trí', N'NDV08')
GO
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (6000000.0000, CAST(N'2022-01-09' AS Date), CAST(N'2022-01-12' AS Date), N'PD0001', N'KH0001', N'Online')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (4000000.0000, CAST(N'2022-01-19' AS Date), CAST(N'2022-01-21' AS Date), N'PD0002', N'KH0002', N'Online')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (4000000.0000, CAST(N'2022-01-21' AS Date), CAST(N'2022-01-23' AS Date), N'PD0003', N'KH0003', N'Online')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (10000000.0000, CAST(N'2022-01-30' AS Date), CAST(N'2022-02-05' AS Date), N'PD0004', N'KH0004', N'Offline')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (6000000.0000, CAST(N'2022-02-09' AS Date), CAST(N'2022-02-12' AS Date), N'PD0005', N'KH0001', N'Online')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (0.0000, CAST(N'2022-02-15' AS Date), CAST(N'2022-02-19' AS Date), N'PD0006', N'KH0005', N'Offline')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (12000000.0000, CAST(N'2022-02-21' AS Date), CAST(N'2022-02-27' AS Date), N'PD0007', N'KH0006', N'Online')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (0.0000, CAST(N'2022-03-01' AS Date), CAST(N'2022-03-03' AS Date), N'PD0008', N'KH0007', N'Offline')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (2000000.0000, CAST(N'2022-03-04' AS Date), CAST(N'2022-03-05' AS Date), N'PD0009', N'KH0008', N'Online')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (0.0000, CAST(N'2022-03-10' AS Date), CAST(N'2022-03-12' AS Date), N'PD0010', N'KH0009', N'Offline')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (6000000.0000, CAST(N'2022-03-12' AS Date), CAST(N'2022-03-15' AS Date), N'PD0011', N'KH0010', N'Online')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (10000000.0000, CAST(N'2022-03-10' AS Date), CAST(N'2022-03-15' AS Date), N'PD0012', N'KH0005', N'Offline')
INSERT [dbo].[PHIEUDAT] ([Tiendatcoc], [NgayDenDukien], [NgayDiDuKien], [MaBooking], [MaKH], [Phuongthucdatcoc]) VALUES (6000000.0000, CAST(N'2022-11-10' AS Date), CAST(N'2022-11-13' AS Date), N'PD0013', N'KH0001', N'Offline')
GO
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-01-09T00:00:00.000' AS DateTime), N'PT0001', CAST(N'2022-01-12T00:00:00.000' AS DateTime), CAST(N'2022-01-09T00:00:00.000' AS DateTime), N'P101', N'PD0001', 2000000.0000, 0.1)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-01-19T00:00:00.000' AS DateTime), N'PT0002', CAST(N'2022-01-21T00:00:00.000' AS DateTime), CAST(N'2022-01-19T00:00:00.000' AS DateTime), N'P102', N'PD0002', 2000000.0000, 0.1)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-01-21T00:00:00.000' AS DateTime), N'PT0003', CAST(N'2022-01-23T00:00:00.000' AS DateTime), CAST(N'2022-01-21T00:00:00.000' AS DateTime), N'P301', N'PD0003', 7000000.0000, 0)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-01-21T00:00:00.000' AS DateTime), N'PT0004', CAST(N'2022-01-23T00:00:00.000' AS DateTime), CAST(N'2022-01-21T00:00:00.000' AS DateTime), N'P201', N'PD0003', 4000000.0000, 0.1)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-01-30T00:00:00.000' AS DateTime), N'PT0005', CAST(N'2022-02-05T00:00:00.000' AS DateTime), CAST(N'2022-01-30T00:00:00.000' AS DateTime), N'P101', N'PD0004', 2000000.0000, 0)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-02-09T00:00:00.000' AS DateTime), N'PT0006', CAST(N'2022-02-12T00:00:00.000' AS DateTime), CAST(N'2022-02-09T00:00:00.000' AS DateTime), N'P401', N'PD0005', 9000000.0000, 0)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'PT0007', CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'P102', N'PD0006', 2000000.0000, 0)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'PT0008', CAST(N'2022-02-20T00:00:00.000' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'P103', N'PD0006', 3000000.0000, 0.1)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-02-21T00:00:00.000' AS DateTime), N'PT0009', CAST(N'2022-02-27T00:00:00.000' AS DateTime), CAST(N'2022-02-21T00:00:00.000' AS DateTime), N'P101', N'PD0007', 2000000.0000, 0)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-03-01T00:00:00.000' AS DateTime), N'PT0010', CAST(N'2022-03-03T00:00:00.000' AS DateTime), CAST(N'2022-03-01T00:00:00.000' AS DateTime), N'P304', N'PD0008', 8000000.0000, 0.1)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-03-04T00:00:00.000' AS DateTime), N'PT0011', CAST(N'2022-03-05T00:00:00.000' AS DateTime), CAST(N'2022-03-04T00:00:00.000' AS DateTime), N'P304', N'PD0009', 8000000.0000, 0.1)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'PT0012', CAST(N'2022-03-12T00:00:00.000' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'P303', N'PD0010', 8000000.0000, 0.1)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'PT0013', CAST(N'2022-03-12T00:00:00.000' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'P402', N'PD0010', 9500000.0000, 0.3)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'PT0014', CAST(N'2022-03-12T00:00:00.000' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'P403', N'PD0010', 10000000.0000, 0.3)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-03-12T00:00:00.000' AS DateTime), N'PT0015', CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'2022-03-12T00:00:00.000' AS DateTime), N'P304', N'PD0011', 8000000.0000, 0)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'PT0016', CAST(N'2022-03-15T00:00:00.000' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'P405', N'PD0012', 10500000.0000, 0)
INSERT [dbo].[PHIEUTHUE] ([ThoigianlapPT], [MaPT], [Thoigiancheckout], [Thoigiancheckin], [Maphong], [MaBooking], [Dongiaphong], [KMPhong]) VALUES (CAST(N'2022-11-10T00:00:00.000' AS DateTime), N'PT0017', NULL, NULL, N'P101', N'PD0013', 2000000.0000, 0)
GO
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P101', N'VCC', N'Standard01')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P102', N'VCC', N'Standard01')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P103', N'OCC', N'Standard02')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P104', N'VCC', N'Standard02')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P201', N'VCC', N'Superior01')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P202', N'VCD', N'Superior01')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P203', N'DND', N'Superior02')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P204', N'Due out', N'Superior03')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P301', N'OOD', N'Deluxe01')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P302', N'VCC', N'Deluxe01')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P303', N'VCC', N'Deluxe02')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P304', N'VC', N'Deluxe02')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P401', N'OCC', N'Suite01')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P402', N'VC', N'Suite02')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P403', N'VCC', N'Suite03')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P404', N'OCC', N'Suite03')
INSERT [dbo].[PHONG] ([Maphong], [TinhTrang], [MaLP]) VALUES (N'P405', N'VC', N'Suite04')
GO
INSERT [dbo].[tblLogin] ([username], [password]) VALUES (N'employee01', N'123456')
INSERT [dbo].[tblLogin] ([username], [password]) VALUES (N'employee02', N'654321')
INSERT [dbo].[tblLogin] ([username], [password]) VALUES (N'employee04', N'123123')
INSERT [dbo].[tblLogin] ([username], [password]) VALUES (N'employee05', N'000000')
INSERT [dbo].[tblLogin] ([username], [password]) VALUES (N'manager01', N'111111')
GO
INSERT [dbo].[VATDUNG] ([MaVD], [TenVD]) VALUES (N'VD01', N'Giường Queen')
INSERT [dbo].[VATDUNG] ([MaVD], [TenVD]) VALUES (N'VD02', N'Giường Đơn')
INSERT [dbo].[VATDUNG] ([MaVD], [TenVD]) VALUES (N'VD03', N'Vô tuyến')
INSERT [dbo].[VATDUNG] ([MaVD], [TenVD]) VALUES (N'VD04', N'Đèn ngủ đứng')
INSERT [dbo].[VATDUNG] ([MaVD], [TenVD]) VALUES (N'VD05', N'Giường đôi')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__DONGHDTT__76650C8F32165C8A]    Script Date: 11/10/2022 1:21:55 AM ******/
ALTER TABLE [dbo].[DONGHDTT] ADD UNIQUE NONCLUSTERED 
(
	[MaHDTT] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETDICHVU]  WITH CHECK ADD FOREIGN KEY([MaHDDV])
REFERENCES [dbo].[HDDV] ([MaHDDV])
GO
ALTER TABLE [dbo].[CHITIETDICHVU]  WITH CHECK ADD FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
GO
ALTER TABLE [dbo].[CHITIETPHONGDAT]  WITH CHECK ADD FOREIGN KEY([MaLP])
REFERENCES [dbo].[LOAIPHONG] ([MaLP])
GO
ALTER TABLE [dbo].[CHITIETPHONGDAT]  WITH CHECK ADD FOREIGN KEY([MaBooking])
REFERENCES [dbo].[PHIEUDAT] ([MaBooking])
GO
ALTER TABLE [dbo].[CHITIETVD]  WITH CHECK ADD FOREIGN KEY([MaLP])
REFERENCES [dbo].[LOAIPHONG] ([MaLP])
GO
ALTER TABLE [dbo].[CHITIETVD]  WITH CHECK ADD FOREIGN KEY([MaVD])
REFERENCES [dbo].[VATDUNG] ([MaVD])
GO
ALTER TABLE [dbo].[DICHVU]  WITH CHECK ADD FOREIGN KEY([MaNHOMDV])
REFERENCES [dbo].[NHOMDICHVU] ([MaNHOMDV])
GO
ALTER TABLE [dbo].[DONGHDTT]  WITH CHECK ADD FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
GO
ALTER TABLE [dbo].[DONGHDTT]  WITH CHECK ADD FOREIGN KEY([MaHDTT])
REFERENCES [dbo].[HOADONTT] ([MaHDTT])
GO
ALTER TABLE [dbo].[HDDV]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HDDV]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADONTT]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADONTT]  WITH CHECK ADD FOREIGN KEY([MaBooking])
REFERENCES [dbo].[PHIEUDAT] ([MaBooking])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaBP])
REFERENCES [dbo].[BOPHANLAMVIEC] ([MaBP])
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[CHUCVU] ([MaCV])
GO
ALTER TABLE [dbo].[PHIEUDAT]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHUE]  WITH CHECK ADD FOREIGN KEY([MaBooking])
REFERENCES [dbo].[PHIEUDAT] ([MaBooking])
GO
ALTER TABLE [dbo].[PHIEUTHUE]  WITH CHECK ADD FOREIGN KEY([Maphong])
REFERENCES [dbo].[PHONG] ([Maphong])
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD FOREIGN KEY([MaLP])
REFERENCES [dbo].[LOAIPHONG] ([MaLP])
GO








