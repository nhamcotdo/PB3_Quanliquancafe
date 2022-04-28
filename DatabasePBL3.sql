Create Database PBL3;
GO
USE [PBL3]
GO
/****** Object:  Table [Account]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Account](
	[StaffID] [nchar](10) NOT NULL,
	[Account] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Role] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Area]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Area](
	[AreaID] [nvarchar](4) NOT NULL,
	[AreaName] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Bill]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Bill](
	[BillID] [nchar](10) NOT NULL,
	[TimeCheckOut] [datetime] NOT NULL,
	[TotalBill] [int] NOT NULL,
	[DiscountID] [nchar](10) NULL,
	[OtherFee] [int] NULL,
	[TableID] [nvarchar](4) NOT NULL,
	[StaffID] [nchar](10) NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Discount]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Discount](
	[DiscountID] [nchar](10) NOT NULL,
	[DisCountName] [nchar](10) NOT NULL,
	[Discount] [int] NOT NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [DishGroup]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DishGroup](
	[GroupID] [nchar](4) NOT NULL,
	[GroupName] [nvarchar](max) NULL,
 CONSTRAINT [PK_DishGroup] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Income]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Income](
	[TableID] [nvarchar](4) NOT NULL,
	[TimeCheckOut] [datetime] NOT NULL,
	[TotalBill] [nchar](10) NOT NULL,
	[StaffID] [nchar](10) NOT NULL,
	[Note] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Menu]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Menu](
	[DishID] [nchar](10) NOT NULL,
	[DishName] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[GroupID] [nchar](4) NOT NULL,
	[SizeID] [nchar](2) NOT NULL,
 CONSTRAINT [PK_DoAn] PRIMARY KEY CLUSTERED 
(
	[DishID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Order]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Order](
	[TableID] [nvarchar](4) NOT NULL,
	[DishID] [nchar](10) NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [Size]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Size](
	[SizeID] [nchar](2) NOT NULL,
	[SizeName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Size] PRIMARY KEY CLUSTERED 
(
	[SizeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Staff]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Staff](
	[StaffID] [nchar](10) NOT NULL,
	[StaffName] [nvarchar](max) NOT NULL,
	[PhoneNumber] [int] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[DateIn] [date] NOT NULL,
	[ShiftID] [nchar](10) NOT NULL,
	[Sex] [bit] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Storage]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Storage](
	[GrocID] [nchar](10) NOT NULL,
	[GrocName] [nvarchar](50) NOT NULL,
	[Quantity] [nchar](10) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Price] [nvarchar](50) NOT NULL,
	[TimeCheckIn] [datetime] NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[GrocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Table]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Table](
	[TableID] [nvarchar](4) NOT NULL,
	[AreaID] [nvarchar](4) NOT NULL,
	[TableName] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
	[MergeList] [nvarchar](max) NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[TableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [TakeOut]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [TakeOut](
	[GrocID] [nchar](10) NOT NULL,
	[GrocName] [nvarchar](50) NOT NULL,
	[QuantityOut] [int] NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[TimeCheckOut] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [WorkShift]    Script Date: 4/28/2022 11:30:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [WorkShift](
	[ShiftID] [nchar](10) NOT NULL,
	[ShiftName] [nvarchar](max) NOT NULL,
	[TimeStart] [nvarchar](50) NOT NULL,
	[TimeEnd] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CaLamViec] PRIMARY KEY CLUSTERED 
(
	[ShiftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0001', N'Khu A     ', 0)
INSERT [Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0002', N'Khu B     ', 0)
INSERT [Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0003', N'Khu C     ', 0)
INSERT [Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0004', N'Khu D     ', 0)
INSERT [Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0005', N'Khu E     ', 0)
INSERT [Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0006', N'Khu F     ', 0)
INSERT [Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0007', N'Khu G     ', 0)
INSERT [Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0008', N'KHU VIP', 0)
GO
INSERT [DishGroup] ([GroupID], [GroupName]) VALUES (N'G001', N'Cà Phê Phin')
INSERT [DishGroup] ([GroupID], [GroupName]) VALUES (N'G002', N'Trà')
INSERT [DishGroup] ([GroupID], [GroupName]) VALUES (N'G003', N'Freeze')
INSERT [DishGroup] ([GroupID], [GroupName]) VALUES (N'G004', N'Phindi')
INSERT [DishGroup] ([GroupID], [GroupName]) VALUES (N'G005', N'Cà phê Espresso')
INSERT [DishGroup] ([GroupID], [GroupName]) VALUES (N'G006', N'Bánh')
INSERT [DishGroup] ([GroupID], [GroupName]) VALUES (N'G007', N'Thức uống khác')
GO
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA01      ', N'TIRAMISU', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA02      ', N'BÁNH CHUỐI', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA03      ', N'MAOUSSE ĐÀO', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA04      ', N'MOUSSE CACAO', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA05      ', N'PHÔ MAI TRÀ XANH', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA06      ', N'PHÔ MAI CHANH DÂY', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA07      ', N'PHÔ MAI CÀ PHÊ', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA08      ', N'PHÔ MAI CARAMEL', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'BA09      ', N'SÔ-CÔ-LA HIGHLANDS', 29000, N'G006', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE01      ', N'ESPRESSO/AMERICANO', 35000, N'G005', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE02      ', N'ESPRESSO/AMERICANO', 39000, N'G005', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE03      ', N'ESPRESSO/AMERICANO', 45000, N'G005', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE04      ', N'CAPPUCCINO/LATTE', 55000, N'G005', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE05      ', N'CAPPUCCINO/LATTE', 65000, N'G005', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE06      ', N'CAPPUCCINO/LATTE', 69000, N'G005', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE07      ', N'MOCHA/CARAMEL MACCHIATO', 59000, N'G005', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE08      ', N'MOCHA/CARAMEL MACCHIATO', 69000, N'G005', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CE09      ', N'MOCHA/CARAMEL MACCHIATO', 75000, N'G005', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF01      ', N'PHIN SỮA ĐÁ', 29000, N'G001', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF02      ', N'PHIN SỮA ĐÁ', 35000, N'G001', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF03      ', N'PHIN SỮA ĐÁ', 39000, N'G001', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF04      ', N'PHIN ĐEN ĐÁ', 29000, N'G001', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF05      ', N'PHIN ĐEN ĐÁ', 35000, N'G001', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF06      ', N'PHIN ĐEN ĐÁ', 39000, N'G001', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF07      ', N'BẠC XỈU ĐÁ ĐÁ', 29000, N'G001', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF08      ', N'BẠC XỈU ĐÁ ĐÁ', 35000, N'G001', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'CF09      ', N'BẠC XỈU ĐÁ ĐÁ', 39000, N'G001', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR01      ', N'FREEZE TRÀ XANH', 49000, N'G003', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR02      ', N'FREEZE TRÀ XANH', 59000, N'G003', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR03      ', N'FREEZE TRÀ XANH', 65000, N'G003', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR04      ', N'FREEZE SÔ-CÔ-LA', 49000, N'G003', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR05      ', N'FREEZE SÔ-CÔ-LA', 59000, N'G003', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR06      ', N'FREEZE SÔ-CÔ-LA', 65000, N'G003', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR07      ', N'FREEZE COOKIES & CREAM', 49000, N'G003', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR08      ', N'FREEZE COOKIES & CREAM', 59000, N'G003', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR09      ', N'FREEZE COOKIES & CREAM', 65000, N'G003', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR10      ', N'FREEZE CARAMEL PHIN FREEZE', 49000, N'G003', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR11      ', N'FREEZE CARAMEL PHIN FREEZE', 59000, N'G003', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR12      ', N'FREEZE CARAMEL PHIN FREEZE', 65000, N'G003', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR13      ', N'CLASSIC CARAMEL PHIN FREEZE', 49000, N'G003', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR14      ', N'CLASSIC CARAMEL PHIN FREEZE', 59000, N'G003', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'FR15      ', N'CLASSIC CARAMEL PHIN FREEZE', 65000, N'G003', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT01      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN', 39000, N'G007', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT02      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN', 49000, N'G007', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT03      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN', 55000, N'G007', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT04      ', N'CHANH DÂY ĐÁ VIÊN', 39000, N'G007', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT05      ', N'CHANH DÂY ĐÁ VIÊN', 49000, N'G007', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT06      ', N'CHANH DÂY ĐÁ VIÊN', 55000, N'G007', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT07      ', N'CHTẮT/QUẤT ĐÁ VIÊN', 39000, N'G007', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT08      ', N'CHTẮT/QUẤT ĐÁ VIÊN', 49000, N'G007', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT09      ', N'CHTẮT/QUẤT ĐÁ VIÊN', 55000, N'G007', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT10      ', N'SÔ-CÔ-LA(nóng hoặc đá)', 55000, N'G007', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT11      ', N'SÔ-CÔ-LA(nóng hoặc đá)', 59000, N'G007', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'OT12      ', N'SÔ-CÔ-LA(nóng hoặc đá)', 65000, N'G007', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH01      ', N'PHINDI KEM SỮA', 39000, N'G004', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH02      ', N'PHINDI KEM SỮA', 45000, N'G004', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH03      ', N'PHINDI KEM SỮA', 49000, N'G004', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH04      ', N'PHINDI HẠNH NHÂN', 39000, N'G004', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH05      ', N'PHINDI HẠNH NHÂN', 45000, N'G004', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH06      ', N'PHINDI HẠNH NHÂN', 49000, N'G004', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH07      ', N'PHINDI CHOCO', 39000, N'G004', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH08      ', N'PHINDI CHOCO', 45000, N'G004', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'PH09      ', N'PHINDI CHOCO', 49000, N'G004', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR01      ', N'TRÀ SEN VÀNG', 39000, N'G002', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR02      ', N'TRÀ SEN VÀNG', 49000, N'G002', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR03      ', N'TRÀ SEN VÀNG', 55000, N'G002', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR04      ', N'TRÀ THẠCH ĐÀO', 39000, N'G002', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR05      ', N'TRÀ THẠCH ĐÀO', 49000, N'G002', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR06      ', N'TRÀ THẠCH ĐÀO', 55000, N'G002', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR07      ', N'TRÀ THANH ĐÀO', 39000, N'G002', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR08      ', N'TRÀ THANH ĐÀO', 49000, N'G002', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR09      ', N'TRÀ THANH ĐÀO', 55000, N'G002', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR10      ', N'TRÀ THẠCH VẢI', 39000, N'G002', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR11      ', N'TRÀ THẠCH VẢI', 49000, N'G002', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR12      ', N'TRÀ THẠCH VẢI', 55000, N'G002', N'S3')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR13      ', N'TRÀ XANH ĐẬU ĐỎ', 39000, N'G002', N'S1')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR14      ', N'TRÀ XANH ĐẬU ĐỎ', 49000, N'G002', N'S2')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [SizeID]) VALUES (N'TR15      ', N'TRÀ XANH ĐẬU ĐỎ', 55000, N'G002', N'S3')
GO
INSERT [Size] ([SizeID], [SizeName]) VALUES (N'S1', N'Nhỏ')
INSERT [Size] ([SizeID], [SizeName]) VALUES (N'S2', N'Vừa')
INSERT [Size] ([SizeID], [SizeName]) VALUES (N'S3', N'Lớn')
GO
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0001      ', N'Linh', 934894000, N'123 ABC   ', CAST(N'2022-10-04' AS Date), N'SA01      ', 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0002      ', N'Đức', 123456789, N'111 AAA   ', CAST(N'2022-04-10' AS Date), N'SA01      ', 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0003      ', N'Nhâm', 111111111, N'211 AAB   ', CAST(N'2022-04-10' AS Date), N'SA02      ', 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0004      ', N'Minh', 111111112, N'333 CAA   ', CAST(N'2022-04-10' AS Date), N'SA02      ', 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0005      ', N'Nhi', 111111222, N'333 NNN   ', CAST(N'2022-04-10' AS Date), N'CH01      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0006      ', N'Như', 111111333, N'78 ABBBBU ', CAST(N'2022-04-10' AS Date), N'CH01      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0007      ', N'Nhã', 111111234, N'89 HHU    ', CAST(N'2022-04-10' AS Date), N'CH02      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0008      ', N'Nhiên', 112111232, N'90 A      ', CAST(N'2022-04-01' AS Date), N'CH02      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0009      ', N'Nhữ', 112222223, NULL, CAST(N'2022-04-02' AS Date), N'CH02      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0010      ', N'Nha', 111112233, NULL, CAST(N'2022-04-02' AS Date), N'CH02      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0011      ', N'Lan', 123232322, N'91 TCC    ', CAST(N'2022-04-02' AS Date), N'TO01      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0012      ', N'Lãng', 122222333, N'99 KKKKI  ', CAST(N'2022-04-03' AS Date), N'TO01      ', 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0013      ', N'Liên', 898922322, N'901 IIDKD ', CAST(N'2022-04-04' AS Date), N'TO01      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0014      ', N'Liễu', 981273823, N'1222 A    ', CAST(N'2022-04-01' AS Date), N'TO01      ', 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0015      ', N'Linh', 123987822, N'2 B       ', CAST(N'2022-04-01' AS Date), N'TO01      ', 0)
GO
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF01      ', N'Hạt cà phê', N'10        ', N'Kg', N'60 000 VNĐ/1 Kg', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF02      ', N'Cà phê gói', N'8         ', N'Bịch', N'55 000 VNĐ/1 Bịch', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF03      ', N'Sữa ông Thọ', N'1         ', N'Thùng', N'365 000 VNĐ/1 Thùng', CAST(N'2022-04-17T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF04      ', N'Đường nâu', N'40        ', N'Kg', N'89 000 VNĐ/1 Kg', CAST(N'2022-04-13T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF05      ', N'Đường trắng', N'20        ', N'Kg', N'80 000 VNĐ/1 Kg', CAST(N'2022-04-13T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF06      ', N'Sữa La Roseé', N'1         ', N'Thùng', N'564 000 VNĐ/1 Thùng', CAST(N'2022-04-13T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA01      ', N'Mỳ miliket', N'10        ', N'Thùng', N'295 000 VNĐ/1 Thùng', CAST(N'2022-04-14T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA02      ', N'Trứng', N'50        ', N'Quả', N'7 000 VNĐ/1 Quả', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA03      ', N'Thịt bò bằm', N'5         ', N'Kg', N'80 000 VNĐ/1 Kg', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA04      ', N'Tôm đất', N'5         ', N'Kg', N'80 000 VNĐ/1 Kg', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA05      ', N'Khoai tây chiên', N'10        ', N'Kg', N'134 000 VNĐ/1 Kg', CAST(N'2022-04-12T00:00:00.000' AS DateTime))
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'TS01      ', N'Bột trà sữa', N'20        ', N'Kg', N'100 000 VNĐ/20 Kg', CAST(N'2022-04-14T00:00:00.000' AS DateTime))
GO
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA01', N'0001', N'Bàn 1     ', 1, N'BA01')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA02', N'0001', N'Bàn 2     ', 1, N'BA02,BA01')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA03', N'0001', N'Bàn 3     ', 0, N'BA03')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA04', N'0002', N'Bàn 4     ', 0, N'BA04')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA05', N'0002', N'Bàn 5     ', 0, N'BA05')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA06', N'0002', N'Bàn 6     ', 0, N'BA06')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA07', N'0003', N'Bàn 7     ', 0, N'BA07')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA08', N'0004', N'Bàn 8     ', 0, N'BA08')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA09', N'0004', N'Bàn 9     ', 1, N'BA09')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA10', N'0004', N'Bàn 10    ', 0, N'BA10')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA11', N'0005', N'Bàn 11    ', 0, N'BA11')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA12', N'0005', N'Bàn 12    ', 0, N'BA12')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA13', N'0006', N'Bàn 13    ', 0, N'BA13')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA14', N'0006', N'Bàn 14    ', 0, N'BA14')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA15', N'0007', N'Bàn 15    ', 0, N'BA15')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA16', N'0001', N'Bàn x', 0, N'BA16')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA17', N'0008', N'VIP 1', 0, N'BA17')
GO
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'CH01      ', N'Chiều 1', N'Jan  1 1900  1:30PM', N'Jan  1 1900  4:00PM')
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'CH02      ', N'Chiều 2', N'Jan  1 1900  4:00PM', N'Jan  1 1900  7:00PM')
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'SA01      ', N'Sáng 1', N'Jan  1 1900  5:00AM', N'Jan  1 1900  9:30AM')
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'SA02      ', N'Sáng 2', N'Jan  1 1900  9:30AM', N'Jan  1 1900  1:30PM')
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'TO01      ', N'Tối 1', N'Jan  1 1900  7:00PM', N'Jan  1 1900 11:00PM')
GO
ALTER TABLE [Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Staff] FOREIGN KEY([StaffID])
REFERENCES [Staff] ([StaffID])
GO
ALTER TABLE [Account] CHECK CONSTRAINT [FK_Account_Staff]
GO
ALTER TABLE [Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Discount] FOREIGN KEY([DiscountID])
REFERENCES [Discount] ([DiscountID])
GO
ALTER TABLE [Bill] CHECK CONSTRAINT [FK_Bill_Discount]
GO
ALTER TABLE [Bill]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Ban] FOREIGN KEY([TableID])
REFERENCES [Table] ([TableID])
GO
ALTER TABLE [Bill] CHECK CONSTRAINT [FK_HoaDon_Ban]
GO
ALTER TABLE [Bill]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([StaffID])
REFERENCES [Staff] ([StaffID])
GO
ALTER TABLE [Bill] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [Income]  WITH CHECK ADD  CONSTRAINT [FK_Income_Table] FOREIGN KEY([TableID])
REFERENCES [Table] ([TableID])
GO
ALTER TABLE [Income] CHECK CONSTRAINT [FK_Income_Table]
GO
ALTER TABLE [Income]  WITH CHECK ADD  CONSTRAINT [FK_ThongKeDoanhThu_NhanVien] FOREIGN KEY([StaffID])
REFERENCES [Staff] ([StaffID])
GO
ALTER TABLE [Income] CHECK CONSTRAINT [FK_ThongKeDoanhThu_NhanVien]
GO
ALTER TABLE [Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_DishGroup] FOREIGN KEY([GroupID])
REFERENCES [DishGroup] ([GroupID])
GO
ALTER TABLE [Menu] CHECK CONSTRAINT [FK_Menu_DishGroup]
GO
ALTER TABLE [Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Size] FOREIGN KEY([SizeID])
REFERENCES [Size] ([SizeID])
GO
ALTER TABLE [Menu] CHECK CONSTRAINT [FK_Menu_Size]
GO
ALTER TABLE [Order]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_Ban] FOREIGN KEY([TableID])
REFERENCES [Table] ([TableID])
GO
ALTER TABLE [Order] CHECK CONSTRAINT [FK_DatMon_Ban]
GO
ALTER TABLE [Order]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_DoAn] FOREIGN KEY([DishID])
REFERENCES [Menu] ([DishID])
GO
ALTER TABLE [Order] CHECK CONSTRAINT [FK_DatMon_DoAn]
GO
ALTER TABLE [Staff]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_CaLamViec] FOREIGN KEY([ShiftID])
REFERENCES [WorkShift] ([ShiftID])
GO
ALTER TABLE [Staff] CHECK CONSTRAINT [FK_NhanVien_CaLamViec]
GO
ALTER TABLE [Table]  WITH CHECK ADD  CONSTRAINT [FK_Ban_KhuVuc] FOREIGN KEY([AreaID])
REFERENCES [Area] ([AreaID])
GO
ALTER TABLE [Table] CHECK CONSTRAINT [FK_Ban_KhuVuc]
GO
ALTER TABLE [TakeOut]  WITH CHECK ADD  CONSTRAINT [FK_XuatKho_HangHoa] FOREIGN KEY([GrocID])
REFERENCES [Storage] ([GrocID])
GO
ALTER TABLE [TakeOut] CHECK CONSTRAINT [FK_XuatKho_HangHoa]
GO
