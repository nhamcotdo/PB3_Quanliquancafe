USE [PBL3]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/20/2022 12:47:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[StaffID] [nchar](10) NOT NULL,
	[Account] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Role] [bit] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[AreaID] [nvarchar](4) NOT NULL,
	[AreaName] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
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
/****** Object:  Table [dbo].[Data]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Data](
	[BillID] [nchar](10) NOT NULL,
	[DishName] [nchar](30) NOT NULL,
	[Quantity] [int] NULL,
	[Time] [date] NOT NULL,
	[Price] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[DiscountID] [nchar](10) NOT NULL,
	[DisCountName] [nvarchar](max) NOT NULL,
	[Value] [int] NOT NULL,
	[Percent] [bit] NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DishGroup]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DishGroup](
	[GroupID] [nchar](4) NOT NULL,
	[GroupName] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_DishGroup] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Income]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Income](
	[TableID] [nvarchar](4) NOT NULL,
	[TimeCheckOut] [datetime] NOT NULL,
	[TotalBill] [nchar](10) NOT NULL,
	[StaffID] [nchar](10) NOT NULL,
	[Note] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[DishID] [nchar](10) NOT NULL,
	[DishName] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[GroupID] [nchar](4) NOT NULL,
 CONSTRAINT [PK_DoAn] PRIMARY KEY CLUSTERED 
(
	[DishID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[TableID] [nvarchar](4) NOT NULL,
	[DishID] [nchar](10) NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
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
/****** Object:  Table [dbo].[Storage]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
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
/****** Object:  Table [dbo].[Table]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
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
/****** Object:  Table [dbo].[TakeOut]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TakeOut](
	[GrocID] [nchar](10) NOT NULL,
	[GrocName] [nvarchar](50) NOT NULL,
	[QuantityOut] [int] NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[TimeCheckOut] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkShift]    Script Date: 5/20/2022 12:47:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkShift](
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
INSERT [dbo].[Account] ([StaffID], [Account], [Password], [Role]) VALUES (N'0001      ', N'admin', N'admin', 1)
INSERT [dbo].[Account] ([StaffID], [Account], [Password], [Role]) VALUES (N'0002      ', N'duc', N'1234', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0001', N'Khu A     ', 0)
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0002', N'Khu B     ', 0)
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0003', N'Khu C     ', 0)
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0004', N'Khu D     ', 0)
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0005', N'Khu E     ', 0)
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0006', N'Khu F     ', 0)
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0007', N'Khu G     ', 0)
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0008', N'KHU VIP', 0)
GO
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0006      ', CAST(N'2022-01-19T08:15:38.000' AS DateTime), 116000, N'000       ', 0, N'BA03', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0007      ', CAST(N'2022-01-20T08:15:38.000' AS DateTime), 408000, N'000       ', 0, N'BA04', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0008      ', CAST(N'2022-01-01T08:15:38.000' AS DateTime), 82500, N'001       ', 12300, N'BA09', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0009      ', CAST(N'2022-02-01T08:15:38.000' AS DateTime), 454000, N'000       ', 0, N'BA01', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0010      ', CAST(N'2022-02-03T08:15:38.000' AS DateTime), 140000, N'000       ', 0, N'BA03', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0011      ', CAST(N'2022-02-04T08:15:38.000' AS DateTime), 35000, N'000       ', 0, N'BA05', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0012      ', CAST(N'2022-02-09T08:15:38.000' AS DateTime), 29000, N'000       ', 0, N'BA01', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0013      ', CAST(N'2022-02-07T08:15:38.000' AS DateTime), 29000, N'000       ', 0, N'BA02', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0014      ', CAST(N'2022-03-09T09:39:51.000' AS DateTime), 200713, N'001       ', 13, N'BA01', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0015      ', CAST(N'2022-03-19T09:39:51.000' AS DateTime), 29000, N'000       ', 0, N'BA05', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0016      ', CAST(N'2022-03-13T09:39:51.000' AS DateTime), 169000, N'000       ', 0, N'BA02', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0017      ', CAST(N'2022-03-01T09:39:51.000' AS DateTime), 122000, N'000       ', 0, N'BA03', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0018      ', CAST(N'2022-03-08T09:39:51.000' AS DateTime), 29000, N'000       ', 0, N'BA05', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0019      ', CAST(N'2022-03-10T09:39:51.000' AS DateTime), 57600, N'001       ', 0, N'BA02', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0020      ', CAST(N'2022-04-09T10:02:56.000' AS DateTime), 292000, N'000       ', 0, N'BA02', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0021      ', CAST(N'2022-04-29T10:02:56.000' AS DateTime), 1130613, N'001       ', 213, N'BA04', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0022      ', CAST(N'2022-04-11T10:02:56.000' AS DateTime), 1256000, N'000       ', 0, N'BA04', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0023      ', CAST(N'2022-04-22T10:02:56.000' AS DateTime), 1256000, N'000       ', 0, N'BA04', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0024      ', CAST(N'2022-04-30T10:02:56.000' AS DateTime), 1742000, N'000       ', 0, N'BA01', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0025      ', CAST(N'2022-05-01T10:30:04.000' AS DateTime), 1131723, N'001       ', 1323, N'BA04', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0026      ', CAST(N'2022-05-01T10:44:36.000' AS DateTime), 1256000, N'000       ', 0, N'BA04', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0027      ', CAST(N'2022-05-13T10:46:08.000' AS DateTime), 116000, N'000       ', 0, N'BA01', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0028      ', CAST(N'2022-01-06T08:15:38.000' AS DateTime), 176000, N'000       ', 0, N'BA02', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0029      ', CAST(N'2022-05-19T10:46:30.000' AS DateTime), 351900, N'001       ', 0, N'BA01', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0030      ', CAST(N'2022-05-20T10:46:42.000' AS DateTime), 78000, N'000       ', 0, N'BA03', N'0001      ')
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0031      ', CAST(N'2022-05-20T11:50:59.000' AS DateTime), 164000, N'002       ', 0, N'BA01', N'0001      ')
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0014      ', N'BẠC XỈU ĐÁ ĐÁ    Lớn          ', 2, CAST(N'2022-04-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0014      ', N'BẠC XỈU ĐÁ ĐÁ    Nhỏ          ', 3, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0017      ', N'BẠC XỈU ĐÁ ĐÁ    Nhỏ          ', 2, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0009      ', N'BẠC XỈU ĐÁ ĐÁ    Vừa          ', 8, CAST(N'2022-03-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0010      ', N'BẠC XỈU ĐÁ ĐÁ    Vừa          ', 4, CAST(N'2022-02-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0011      ', N'BẠC XỈU ĐÁ ĐÁ    Vừa          ', 1, CAST(N'2022-02-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0017      ', N'BẠC XỈU ĐÁ ĐÁ    Vừa          ', 1, CAST(N'2022-01-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0007      ', N'CHTẮT/QUẤT ĐÁ VIÊN    Nhỏ     ', 6, CAST(N'2022-01-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0008      ', N'CHTẮT/QUẤT ĐÁ VIÊN    Nhỏ     ', 2, CAST(N'2022-01-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0019      ', N'ESPRESSO/AMERICANO    Nhỏ     ', 1, CAST(N'2022-05-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0024      ', N'ESPRESSO/AMERICANO    Nhỏ     ', 9, CAST(N'2022-05-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0007      ', N'PHIN ĐEN ĐÁ    Nhỏ            ', 2, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0016      ', N'PHIN ĐEN ĐÁ    Vừa            ', 4, CAST(N'2022-05-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0021      ', N'PHIN ĐEN ĐÁ    Vừa            ', 1, CAST(N'2022-04-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0022      ', N'PHIN ĐEN ĐÁ    Vừa            ', 1, CAST(N'2022-01-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0023      ', N'PHIN ĐEN ĐÁ    Vừa            ', 1, CAST(N'2022-05-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0024      ', N'PHIN ĐEN ĐÁ    Vừa            ', 1, CAST(N'2022-05-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0025      ', N'PHIN ĐEN ĐÁ    Vừa            ', 1, CAST(N'2022-05-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0006      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 4, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0007      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 4, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0009      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 6, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0012      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-01-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0013      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0014      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 2, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0015      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0016      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0017      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-01-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0018      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0021      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 6, CAST(N'2022-02-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0022      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 6, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0023      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 6, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0024      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 48, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0025      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 6, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0021      ', N'PHINDI HẠNH NHÂN    Nhỏ       ', 10, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0022      ', N'PHINDI HẠNH NHÂN    Nhỏ       ', 10, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0023      ', N'PHINDI HẠNH NHÂN    Nhỏ       ', 10, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0025      ', N'PHINDI HẠNH NHÂN    Nhỏ       ', 10, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0019      ', N'TIRAMISU    Nhỏ               ', 1, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0020      ', N'TRÀ SEN VÀNG    Lớn           ', 1, CAST(N'2022-02-19' AS Date), 55000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0020      ', N'TRÀ SEN VÀNG    Nhỏ           ', 1, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0020      ', N'TRÀ THẠCH ĐÀO    Lớn          ', 2, CAST(N'2022-02-19' AS Date), 55000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0020      ', N'TRÀ THANH ĐÀO    Nhỏ          ', 1, CAST(N'2022-04-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0020      ', N'TRÀ XANH ĐẬU ĐỎ    Vừa        ', 1, CAST(N'2022-02-19' AS Date), 49000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0026      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 6, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0026      ', N'PHIN ĐEN ĐÁ    Vừa            ', 1, CAST(N'2022-05-19' AS Date), 35000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0026      ', N'PHINDI HẠNH NHÂN    Nhỏ       ', 10, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0026      ', N'PHINDI HẠNH NHÂN    Nhỏ       ', 3, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0026      ', N'PHINDI HẠNH NHÂN    Vừa       ', 3, CAST(N'2022-05-19' AS Date), 45000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0026      ', N'PHINDI HẠNH NHÂN    Vừa       ', 9, CAST(N'2022-05-19' AS Date), 45000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0027      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0027      ', N'MOUSSE CACAO    Nhỏ           ', 3, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0028      ', N'MOUSSE CACAO    Nhỏ           ', 1, CAST(N'2022-05-19' AS Date), 29000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0028      ', N'FREEZE TRÀ XANH    Nhỏ        ', 3, CAST(N'2022-05-19' AS Date), 49000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0029      ', N'FREEZE TRÀ XANH    Nhỏ        ', 4, CAST(N'2022-05-19' AS Date), 49000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0029      ', N'PHINDI KEM SỮA    Nhỏ         ', 5, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0030      ', N'PHINDI KEM SỮA    Nhỏ         ', 2, CAST(N'2022-05-19' AS Date), 39000)
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0031      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 6, CAST(N'2022-05-20' AS Date), 29000)
GO
INSERT [dbo].[Discount] ([DiscountID], [DisCountName], [Value], [Percent]) VALUES (N'000       ', N'Không khuyển mãi ', 0, 0)
INSERT [dbo].[Discount] ([DiscountID], [DisCountName], [Value], [Percent]) VALUES (N'001       ', N'Giảm 10%', 10, 1)
INSERT [dbo].[Discount] ([DiscountID], [DisCountName], [Value], [Percent]) VALUES (N'002       ', N'Giảm 10.000', 10000, 0)
GO
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G001', N'Cà Phê Phin', NULL)
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G002', N'Trà', NULL)
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G003', N'Freeze', NULL)
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G004', N'Phindi', NULL)
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G005', N'Cà phê Espresso', NULL)
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G006', N'Bánh', NULL)
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G007', N'Thức uống khác', NULL)
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA01      ', N'TIRAMISU    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA02      ', N'BÁNH CHUỐI    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA03      ', N'MAOUSSE ĐÀO    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA04      ', N'MOUSSE CACAO    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA05      ', N'PHÔ MAI TRÀ XANH    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA06      ', N'PHÔ MAI CHANH DÂY    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA07      ', N'PHÔ MAI CÀ PHÊ    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA08      ', N'PHÔ MAI CARAMEL    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA09      ', N'SÔ-CÔ-LA HIGHLANDS    Nhỏ', 29000, N'G006')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE01      ', N'ESPRESSO/AMERICANO    Nhỏ', 35000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE02      ', N'ESPRESSO/AMERICANO    Vừa', 39000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE03      ', N'ESPRESSO/AMERICANO    Lớn', 45000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE04      ', N'CAPPUCCINO/LATTE    Nhỏ', 55000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE05      ', N'CAPPUCCINO/LATTE    Vừa', 65000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE06      ', N'CAPPUCCINO/LATTE    Lớn', 69000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE07      ', N'MOCHA/CARAMEL MACCHIATO    Nhỏ', 59000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE08      ', N'MOCHA/CARAMEL MACCHIATO    Vừa', 69000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE09      ', N'MOCHA/CARAMEL MACCHIATO    Lớn', 75000, N'G005')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF01      ', N'PHIN SỮA ĐÁ    Nhỏ', 29000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF02      ', N'PHIN SỮA ĐÁ    Vừa', 35000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF03      ', N'PHIN SỮA ĐÁ    Lớn', 39000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF04      ', N'PHIN ĐEN ĐÁ    Nhỏ', 29000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF05      ', N'PHIN ĐEN ĐÁ    Vừa', 35000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF06      ', N'PHIN ĐEN ĐÁ    Lớn', 39000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF07      ', N'BẠC XỈU ĐÁ ĐÁ    Nhỏ', 29000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF08      ', N'BẠC XỈU ĐÁ ĐÁ    Vừa', 35000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF09      ', N'BẠC XỈU ĐÁ ĐÁ    Lớn', 39000, N'G001')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR01      ', N'FREEZE TRÀ XANH    Nhỏ', 49000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR02      ', N'FREEZE TRÀ XANH    Vừa', 59000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR03      ', N'FREEZE TRÀ XANH    Lớn', 65000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR04      ', N'FREEZE SÔ-CÔ-LA    Nhỏ', 49000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR05      ', N'FREEZE SÔ-CÔ-LA    Vừa', 59000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR06      ', N'FREEZE SÔ-CÔ-LA    Lớn', 65000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR07      ', N'FREEZE COOKIES & CREAM    Nhỏ', 49000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR08      ', N'FREEZE COOKIES & CREAM    Vừa', 59000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR09      ', N'FREEZE COOKIES & CREAM    Lớn', 65000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR10      ', N'FREEZE CARAMEL PHIN FREEZE    Nhỏ', 49000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR11      ', N'FREEZE CARAMEL PHIN FREEZE    Vừa', 59000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR12      ', N'FREEZE CARAMEL PHIN FREEZE    Lớn', 65000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR13      ', N'CLASSIC CARAMEL PHIN FREEZE    Nhỏ', 49000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR14      ', N'CLASSIC CARAMEL PHIN FREEZE    Vừa', 59000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR15      ', N'CLASSIC CARAMEL PHIN FREEZE    Lớn', 65000, N'G003')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT01      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Nhỏ', 39000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT02      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Vừa', 49000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT03      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Lớn', 55000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT04      ', N'CHANH DÂY ĐÁ VIÊN    Nhỏ', 39000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT05      ', N'CHANH DÂY ĐÁ VIÊN    Vừa', 49000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT06      ', N'CHANH DÂY ĐÁ VIÊN    Lớn', 55000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT07      ', N'CHTẮT/QUẤT ĐÁ VIÊN    Nhỏ', 39000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT08      ', N'CHTẮT/QUẤT ĐÁ VIÊN    Vừa', 49000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT09      ', N'CHTẮT/QUẤT ĐÁ VIÊN    Lớn', 55000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT10      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Nhỏ', 55000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT11      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Vừa', 59000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT12      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Lớn', 65000, N'G007')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH01      ', N'PHINDI KEM SỮA    Nhỏ', 39000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH02      ', N'PHINDI KEM SỮA    Vừa', 45000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH03      ', N'PHINDI KEM SỮA    Lớn', 49000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH04      ', N'PHINDI HẠNH NHÂN    Nhỏ', 39000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH05      ', N'PHINDI HẠNH NHÂN    Vừa', 45000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH06      ', N'PHINDI HẠNH NHÂN    Lớn', 49000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH07      ', N'PHINDI CHOCO    Nhỏ', 39000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH08      ', N'PHINDI CHOCO    Vừa', 45000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH09      ', N'PHINDI CHOCO    Lớn', 49000, N'G004')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR01      ', N'TRÀ SEN VÀNG    Nhỏ', 39000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR02      ', N'TRÀ SEN VÀNG    Vừa', 49000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR03      ', N'TRÀ SEN VÀNG    Lớn', 55000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR04      ', N'TRÀ THẠCH ĐÀO    Nhỏ', 39000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR05      ', N'TRÀ THẠCH ĐÀO    Vừa', 49000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR06      ', N'TRÀ THẠCH ĐÀO    Lớn', 55000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR07      ', N'TRÀ THANH ĐÀO    Nhỏ', 39000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR08      ', N'TRÀ THANH ĐÀO    Vừa', 49000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR09      ', N'TRÀ THANH ĐÀO    Lớn', 55000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR10      ', N'TRÀ THẠCH VẢI    Nhỏ', 39000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR11      ', N'TRÀ THẠCH VẢI    Vừa', 49000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR12      ', N'TRÀ THẠCH VẢI    Lớn', 55000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR13      ', N'TRÀ XANH ĐẬU ĐỎ    Nhỏ', 39000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR14      ', N'TRÀ XANH ĐẬU ĐỎ    Vừa', 49000, N'G002')
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR15      ', N'TRÀ XANH ĐẬU ĐỎ    Lớn', 55000, N'G002')
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0001      ', N'Linh', 934894000, N'123 ABC   ', CAST(N'2022-10-04' AS Date), N'SA01      ', 1)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0002      ', N'Đức', 123456789, N'111 AAA   ', CAST(N'2022-04-10' AS Date), N'SA01      ', 1)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0003      ', N'Nhâm', 111111111, N'211 AAB   ', CAST(N'2022-04-10' AS Date), N'SA02      ', 1)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0004      ', N'Minh', 111111112, N'333 CAA   ', CAST(N'2022-04-10' AS Date), N'SA02      ', 1)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0005      ', N'Nhi', 111111222, N'333 NNN   ', CAST(N'2022-04-10' AS Date), N'CH01      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0006      ', N'Như', 111111333, N'78 ABBBBU ', CAST(N'2022-04-10' AS Date), N'CH01      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0007      ', N'Nhã', 111111234, N'89 HHU    ', CAST(N'2022-04-10' AS Date), N'CH02      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0008      ', N'Nhiên', 112111232, N'90 A      ', CAST(N'2022-04-01' AS Date), N'CH02      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0009      ', N'Nhữ', 112222223, NULL, CAST(N'2022-04-02' AS Date), N'CH02      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0010      ', N'Nha', 111112233, NULL, CAST(N'2022-04-02' AS Date), N'CH02      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0011      ', N'Lan', 123232322, N'91 TCC    ', CAST(N'2022-04-02' AS Date), N'TO01      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0012      ', N'Lãng', 122222333, N'99 KKKKI  ', CAST(N'2022-04-03' AS Date), N'TO01      ', 1)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0013      ', N'Liên', 898922322, N'901 IIDKD ', CAST(N'2022-04-04' AS Date), N'TO01      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0014      ', N'Liễu', 981273823, N'1222 A    ', CAST(N'2022-04-01' AS Date), N'TO01      ', 0)
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0015      ', N'Linh', 123987822, N'2 B       ', CAST(N'2022-04-01' AS Date), N'TO01      ', 0)
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF01      ', N'Hạt cà phê', N'10        ', N'Kg', N'60 000 VNĐ/1 Kg', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF02      ', N'Cà phê gói', N'8         ', N'Bịch', N'55 000 VNĐ/1 Bịch', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF03      ', N'Sữa ông Thọ', N'1         ', N'Thùng', N'365 000 VNĐ/1 Thùng', CAST(N'2022-04-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF04      ', N'Đường nâu', N'40        ', N'Kg', N'89 000 VNĐ/1 Kg', CAST(N'2022-04-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF05      ', N'Đường trắng', N'20        ', N'Kg', N'80 000 VNĐ/1 Kg', CAST(N'2022-04-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF06      ', N'Sữa La Roseé', N'1         ', N'Thùng', N'564 000 VNĐ/1 Thùng', CAST(N'2022-04-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA01      ', N'Mỳ miliket', N'10        ', N'Thùng', N'295 000 VNĐ/1 Thùng', CAST(N'2022-04-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA02      ', N'Trứng', N'50        ', N'Quả', N'7 000 VNĐ/1 Quả', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA03      ', N'Thịt bò bằm', N'5         ', N'Kg', N'80 000 VNĐ/1 Kg', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA04      ', N'Tôm đất', N'5         ', N'Kg', N'80 000 VNĐ/1 Kg', CAST(N'2022-04-16T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA05      ', N'Khoai tây chiên', N'10        ', N'Kg', N'134 000 VNĐ/1 Kg', CAST(N'2022-04-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'TS01      ', N'Bột trà sữa', N'20        ', N'Kg', N'100 000 VNĐ/20 Kg', CAST(N'2022-04-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA01', N'0001', N'Bàn 1     ', 0, N'BA01,BA02,BA01')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA02', N'0001', N'Bàn 2     ', 1, N'BA02,BA01')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA03', N'0001', N'Bàn 3     ', 0, N'BA03,BA02,BA01')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA04', N'0002', N'Bàn 4     ', 0, N'BA04,BA03')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA05', N'0002', N'Bàn 5     ', 0, N'BA05')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA06', N'0002', N'Bàn 6     ', 0, N'BA06')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA07', N'0003', N'Bàn 7     ', 0, N'BA07')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA08', N'0004', N'Bàn 8     ', 0, N'BA08')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA09', N'0004', N'Bàn 9     ', 0, N'BA09')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA10', N'0004', N'Bàn 10    ', 0, N'BA10')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA11', N'0005', N'Bàn 11    ', 0, N'BA11')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA12', N'0005', N'Bàn 12    ', 0, N'BA12')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA13', N'0006', N'Bàn 13    ', 0, N'BA13')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA14', N'0006', N'Bàn 14    ', 0, N'BA14')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA15', N'0007', N'Bàn 15    ', 0, N'BA15')
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA17', N'0008', N'VIP 1', 0, N'BA17')
GO
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'CH01      ', N'Chiều 1', N'Jan  1 1900  1:30PM', N'Jan  1 1900  4:00PM')
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'CH02      ', N'Chiều 2', N'Jan  1 1900  4:00PM', N'Jan  1 1900  7:00PM')
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'SA01      ', N'Sáng 1', N'Jan  1 1900  5:00AM', N'Jan  1 1900  9:30AM')
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'SA02      ', N'Sáng 2', N'Jan  1 1900  9:30AM', N'Jan  1 1900  1:30PM')
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'TO01      ', N'Tối 1', N'Jan  1 1900  7:00PM', N'Jan  1 1900 11:00PM')
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Staff]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Discount] FOREIGN KEY([DiscountID])
REFERENCES [dbo].[Discount] ([DiscountID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Discount]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Ban] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([TableID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_HoaDon_Ban]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[Income]  WITH CHECK ADD  CONSTRAINT [FK_Income_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([TableID])
GO
ALTER TABLE [dbo].[Income] CHECK CONSTRAINT [FK_Income_Table]
GO
ALTER TABLE [dbo].[Income]  WITH CHECK ADD  CONSTRAINT [FK_ThongKeDoanhThu_NhanVien] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Income] CHECK CONSTRAINT [FK_ThongKeDoanhThu_NhanVien]
GO
ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_DishGroup] FOREIGN KEY([GroupID])
REFERENCES [dbo].[DishGroup] ([GroupID])
GO
ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_DishGroup]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_Ban] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([TableID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_DatMon_Ban]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_DoAn] FOREIGN KEY([DishID])
REFERENCES [dbo].[Menu] ([DishID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_DatMon_DoAn]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_CaLamViec] FOREIGN KEY([ShiftID])
REFERENCES [dbo].[WorkShift] ([ShiftID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_NhanVien_CaLamViec]
GO
ALTER TABLE [dbo].[Table]  WITH CHECK ADD  CONSTRAINT [FK_Ban_KhuVuc] FOREIGN KEY([AreaID])
REFERENCES [dbo].[Area] ([AreaID])
GO
ALTER TABLE [dbo].[Table] CHECK CONSTRAINT [FK_Ban_KhuVuc]
GO
ALTER TABLE [dbo].[TakeOut]  WITH CHECK ADD  CONSTRAINT [FK_XuatKho_HangHoa] FOREIGN KEY([GrocID])
REFERENCES [dbo].[Storage] ([GrocID])
GO
ALTER TABLE [dbo].[TakeOut] CHECK CONSTRAINT [FK_XuatKho_HangHoa]
GO
