CREATE DATABASE QL_VanTai 
GO
USE QL_VanTai
GO
/****** Object:  Table [dbo].[ChiTietVanTai]    Script Date: 23/02/2017 11:58:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietVanTai](
	[MaVT] [int] NOT NULL,
	[SoXe] [nvarchar](255) NULL,
	[MaTrongTai] [nvarchar](255) NULL,
	[MaLoTrinh] [nvarchar](255) NULL,
	[SoLuongVT] [int] NULL,
	[NgayDi] [datetime] NULL,
	[NgayDen] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoTrinh]    Script Date: 23/02/2017 11:58:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoTrinh](
	[MaLoTrinh] [nvarchar](255) NOT NULL,
	[TenLoTrinh] [nvarchar](255) NULL,
	[DonGia] [int] NULL,
	[ThoiGianQD] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrongTai]    Script Date: 23/02/2017 11:58:32 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrongTai](
	[MaTrongTai] [nvarchar](255) NOT NULL,
	[TrongTaiQD] [int] NULL
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (1, N'333', N'50', N'PK', 5, CAST(N'2014-05-01T00:00:00.000' AS DateTime), CAST(N'2014-05-03T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (2, N'123', N'52', N'QN', 10, CAST(N'2014-05-03T00:00:00.000' AS DateTime), CAST(N'2014-05-04T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (3, N'444', N'50', N'NT', 2, CAST(N'2014-05-03T00:00:00.000' AS DateTime), CAST(N'2014-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (4, N'333', N'50', N'HN', 3, CAST(N'2014-05-04T00:00:00.000' AS DateTime), CAST(N'2014-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (5, N'111', N'51', N'NT', 6, CAST(N'2014-05-06T00:00:00.000' AS DateTime), CAST(N'2014-05-06T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (6, N'222', N'52', N'HN', 5, CAST(N'2014-05-10T00:00:00.000' AS DateTime), CAST(N'2014-05-16T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (7, N'444', N'50', N'HN', 3, CAST(N'2014-05-25T00:00:00.000' AS DateTime), CAST(N'2014-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (8, N'111', N'51', N'DN', 4, CAST(N'2014-05-10T00:00:00.000' AS DateTime), CAST(N'2014-05-12T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (9, N'333', N'50', N'PK', 4, CAST(N'2014-05-05T00:00:00.000' AS DateTime), CAST(N'2014-05-10T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietVanTai] ([MaVT], [SoXe], [MaTrongTai], [MaLoTrinh], [SoLuongVT], [NgayDi], [NgayDen]) VALUES (10, N'123', N'52', N'HN', 14, CAST(N'2014-05-07T00:00:00.000' AS DateTime), CAST(N'2014-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[LoTrinh] ([MaLoTrinh], [TenLoTrinh], [DonGia], [ThoiGianQD]) VALUES (N'DN', N'Đà nẵng', 5000, 3)
INSERT [dbo].[LoTrinh] ([MaLoTrinh], [TenLoTrinh], [DonGia], [ThoiGianQD]) VALUES (N'HN', N'Hà Nội', 10000, 5)
INSERT [dbo].[LoTrinh] ([MaLoTrinh], [TenLoTrinh], [DonGia], [ThoiGianQD]) VALUES (N'NT', N'Nha Trang', 3000, 1)
INSERT [dbo].[LoTrinh] ([MaLoTrinh], [TenLoTrinh], [DonGia], [ThoiGianQD]) VALUES (N'PK', N'Pleiku', 6000, 4)
INSERT [dbo].[LoTrinh] ([MaLoTrinh], [TenLoTrinh], [DonGia], [ThoiGianQD]) VALUES (N'QN', N'Quảng Nam', 4000, 2)
INSERT [dbo].[TrongTai] ([MaTrongTai], [TrongTaiQD]) VALUES (N'50', 4)
INSERT [dbo].[TrongTai] ([MaTrongTai], [TrongTaiQD]) VALUES (N'51', 8)
INSERT [dbo].[TrongTai] ([MaTrongTai], [TrongTaiQD]) VALUES (N'52', 12)



-- 1. Tạo hàm có đầu vào là lộ trình, đầu ra là số xe, mã trọng tải, số lượng vận tải, 
-- ngày đi, ngày đến (SoXe, MaTrongTai, SoLuongVT, NgayDi, NgayDen.)
Create function Cau1(@MaLoTrinh nvarchar(10))
returns table 
as return 
(
	select	SoXe, MaTrongTai, SoLuongVT, NgayDi, NgayDen
	from	ChiTietVanTai
	where	MaLoTrinh = @MaLoTrinh
)

Select * from Cau1(N'DN')


-- 2. Thiết lập hàm có đầu vào là số xe, đầu ra là thông tin về lộ trình
Create function Cau2(@Soxe char(15))
returns table
as return
(
	select	LoTrinh.MaLoTrinh, TenLoTrinh, DonGia, ThoiGianQD
	from	LoTrinh join ChiTietVanTai
	on		LoTrinh.MaLoTrinh = ChiTietVanTai.MaLoTrinh
	where	SoXe = @Soxe
)

Select * from Cau2('123')


-- 3.Tạo hàm có đầu vào là trọng tải, đầu ra là các số xe có trọng tải quy định lớn hơn 
-- hoặc bằng trọng tải đó
Alter function Cau3(@TrongTai int)
returns table
as return
(
	select	SoXe, MaLoTrinh, ChiTietVanTai.MaTrongTai, TrongTaiQD, NgayDi, NgayDen
	from	ChiTietVanTai join TrongTai
	on		ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai
	where	@TrongTai <= TrongTaiQD
)

Select * from Cau3(10)


-- 4. Tạo hàm có đầu vào là trọng tải và mã lộ trình, đầu ra là số lượng xe có trọng tải 
-- quy định lớn hơn hoặc bằng trọng tải đó và thuộc lộ trình đó.
Create function HamCau4(@trongtai int, @malotrinh nvarchar(10))
returns table
as return
(
	Select	count(SoXe) as SoLuong
	from	ChiTietVanTai join TrongTai
	on		ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai
	where	@trongtai <= TrongTaiQD and @malotrinh = MaLoTrinh
)

select * from HamCau4(10, 'HN')


-- 5. Tạo thủ tục có đầu vào Mã lộ trình đầu ra là số lượng xe thuộc lộ trình đó.
Alter procedure Cau5 @MaLT char(10), @SoLuong int output
as
begin
	Select	@SoLuong = COUNT(SoXe)
	from	ChiTietVanTai 
	where	@MaLT = MaLoTrinh
end

Declare @SL int
exec	Cau5 'HN', @SL output
print	@SL
	

-- 6. Tạo thủ tục có đầu vào là mã lộ trình, năm vận tải, đầu ra là số tiền theo mã lộ trình 
-- và năm vận tải đó
Alter procedure Cau6 @MaLT char(10), @NamVT int, @SoTien int output
as
begin
	Select	@SoTien = DonGia
	from	LoTrinh join ChiTietVanTai
	on		LoTrinh.MaLoTrinh = ChiTietVanTai.MaLoTrinh
	where	@MaLT = LoTrinh.MaLoTrinh and @NamVT = year(NgayDi)
end

Declare @Tien int
exec	Cau6 'HN', 2014, @Tien output
print	@Tien


	
-- 7. Tạo thủ tục có đầu vào là số xe, năm vận tải, đầu ra là số tiền theo số xe và năm vận tải đó 
Alter procedure Cau7 @Soxe char(10), @NamVT int, @Tien int output
as
begin
	Select	@Tien = DonGia
	from	LoTrinh join ChiTietVanTai
	on		LoTrinh.MaLoTrinh = ChiTietVanTai.MaLoTrinh
	where	@Soxe = SoXe and @NamVT = YEAR(NgayDi) 
end

Declare	@TienXe int
exec	Cau7 '123', 2014, @TienXe output
print	@TienXe


-- 8. Tạo thủ tục có đầu vào là mã trọng tải, đầu ra là số lượng xe vượt quá trọng tải quy định 
-- của mã trọng tải đó
Create procedure Cau8 @MaTT char(10), @SL int output
as
begin
	Select	@SL = count(Soxe)
	from	ChiTietVanTai join TrongTai
	on		ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai
	where	@MaTT = TrongTai.MaTrongTai and SoLuongVT > TrongTaiQD
end

Declare	@SLuong int
exec	Cau8 N'51', @SLuong output
print	@SLuong