USE [PBL3]
GO
ALTER TABLE [TakeOut] DROP CONSTRAINT [FK_XuatKho_HangHoa]
GO
ALTER TABLE [Table] DROP CONSTRAINT [FK_Ban_KhuVuc]
GO
ALTER TABLE [Order] DROP CONSTRAINT [FK_DatMon_DoAn]
GO
ALTER TABLE [Menu] DROP CONSTRAINT [FK_Menu_DishGroup]
GO
ALTER TABLE [Income] DROP CONSTRAINT [FK_ThongKeDoanhThu_NhanVien]
GO
ALTER TABLE [Income] DROP CONSTRAINT [FK_Income_Table]
GO
ALTER TABLE [Data] DROP CONSTRAINT [FK_Data_Bill]
GO
ALTER TABLE [Bill] DROP CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [Bill] DROP CONSTRAINT [FK_Bill_Discount]
GO
ALTER TABLE [Account] DROP CONSTRAINT [FK_Account_Staff]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[WorkShift]') AND type in (N'U'))
DROP TABLE [WorkShift]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[TakeOut]') AND type in (N'U'))
DROP TABLE [TakeOut]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Table]') AND type in (N'U'))
DROP TABLE [Table]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Storage]') AND type in (N'U'))
DROP TABLE [Storage]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Staff]') AND type in (N'U'))
DROP TABLE [Staff]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Order]') AND type in (N'U'))
DROP TABLE [Order]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Menu]') AND type in (N'U'))
DROP TABLE [Menu]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Income]') AND type in (N'U'))
DROP TABLE [Income]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[DishGroup]') AND type in (N'U'))
DROP TABLE [DishGroup]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Discount]') AND type in (N'U'))
DROP TABLE [Discount]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data]') AND type in (N'U'))
DROP TABLE [Data]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Bill]') AND type in (N'U'))
DROP TABLE [Bill]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Area]') AND type in (N'U'))
DROP TABLE [Area]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Account]') AND type in (N'U'))
DROP TABLE [Account]
GO
USE [master]
GO
DROP DATABASE [PBL3]
GO
CREATE DATABASE [PBL3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PBL3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PBL3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PBL3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PBL3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PBL3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PBL3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PBL3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PBL3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PBL3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PBL3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PBL3] SET ARITHABORT OFF 
GO
ALTER DATABASE [PBL3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PBL3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PBL3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PBL3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PBL3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PBL3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PBL3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PBL3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PBL3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PBL3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PBL3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PBL3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PBL3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PBL3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PBL3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PBL3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PBL3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PBL3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PBL3] SET  MULTI_USER 
GO
ALTER DATABASE [PBL3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PBL3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PBL3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PBL3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PBL3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PBL3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PBL3] SET QUERY_STORE = OFF
GO
USE [PBL3]
GO
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Area](
	[AreaID] [nvarchar](4) NOT NULL,
	[AreaName] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[AreaNameInEng] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[AreaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Data](
	[BillID] [nchar](10) NOT NULL,
	[DishName] [nchar](30) NOT NULL,
	[Quantity] [int] NULL,
	[Time] [date] NOT NULL,
	[Price] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Discount](
	[DiscountID] [nchar](10) NOT NULL,
	[DiscountName] [nvarchar](max) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
	[DiscountNameInEng] [nvarchar](max) NOT NULL,
	[Percent] [bit] NOT NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [DishGroup](
	[GroupID] [nchar](4) NOT NULL,
	[GroupName] [nvarchar](max) NULL,
	[Value] [nvarchar](max) NULL,
	[GroupNameInEng] [nvarchar](max) NULL,
 CONSTRAINT [PK_DishGroup] PRIMARY KEY CLUSTERED 
(
	[GroupID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Menu](
	[DishID] [nchar](10) NOT NULL,
	[DishName] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[GroupID] [nchar](4) NOT NULL,
	[DishNameEng] [nvarchar](50) NULL,
 CONSTRAINT [PK_DoAn] PRIMARY KEY CLUSTERED 
(
	[DishID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
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
	[Sex] [bit] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Storage](
	[GrocID] [nchar](10) NOT NULL,
	[GrocName] [nvarchar](50) NOT NULL,
	[Quantity] [nchar](10) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[TimeCheckIn] [datetime] NOT NULL,
	[GrocNameInEng] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[GrocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
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
	[TableNameInEng] [nvarchar](50) NULL,
 CONSTRAINT [PK_Ban] PRIMARY KEY CLUSTERED 
(
	[TableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [WorkShift](
	[ShiftID] [nchar](10) NOT NULL,
	[ShiftName] [nvarchar](max) NOT NULL,
	[TimeStart] [nvarchar](50) NOT NULL,
	[TimeEnd] [nvarchar](50) NOT NULL,
	[ShiftNameInEng] [nvarchar](max) NULL,
 CONSTRAINT [PK_CaLamViec] PRIMARY KEY CLUSTERED 
(
	[ShiftID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [Account] ([StaffID], [Account], [Password], [Role]) VALUES (N'0001      ', N'admin', N'admin', 1)
INSERT [Account] ([StaffID], [Account], [Password], [Role]) VALUES (N'0002      ', N'duc', N'1234', 0)
GO
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0001', N'Khu A     ', 0, N'Zone A')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0002', N'Khu B     ', 0, N'Zone B')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0003', N'Khu C     ', 0, N'Zone C')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0004', N'Khu D     ', 0, N'Zone D')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0005', N'Khu E     ', 0, N'Zone E')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0006', N'Khu F     ', 0, N'Zone F')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0007', N'Khu G     ', 0, N'Zone G')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0008', N'KHU VIP', 0, N'V.I.P Zone')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0009', N'Tầng 2', 0, N'2nd Floor')
INSERT [Area] ([AreaID], [AreaName], [TrangThai], [AreaNameInEng]) VALUES (N'0010', N'Khu vực VIP', 0, N'Area VIP')
GO
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0001      ', CAST(N'2022-06-01T22:35:56.000' AS DateTime), 29000, N'000       ', 0, N'BA02', N'0001      ')
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0002      ', CAST(N'2022-06-01T22:35:56.000' AS DateTime), 19000, N'004       ', 0, N'BA01', N'0001      ')
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0003      ', CAST(N'2022-06-02T11:50:48.000' AS DateTime), 521000, N'006       ', 0, N'BA02', N'0001      ')
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0004      ', CAST(N'2022-06-02T11:51:02.000' AS DateTime), 138000, N'003       ', 0, N'BA03', N'0001      ')
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0005      ', CAST(N'2022-06-02T11:52:36.000' AS DateTime), 26100, N'001       ', 0, N'BA03', N'0001      ')
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0006      ', CAST(N'2022-06-02T11:53:15.000' AS DateTime), 29000, N'000       ', 0, N'BA03', N'0001      ')
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0007      ', CAST(N'2022-06-02T11:53:41.000' AS DateTime), 33750, N'002       ', 0, N'BA03', N'0001      ')
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0008      ', CAST(N'2022-06-02T11:54:03.000' AS DateTime), 58000, N'000       ', 0, N'BA02', N'0001      ')
INSERT [Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0009      ', CAST(N'2022-06-02T11:55:44.000' AS DateTime), 162000, N'000       ', 0, N'BA03', N'0001      ')
GO
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0001      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-06-01' AS Date), 29000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0003      ', N'CAPPUCCINO/LATTE    Lớn       ', 9, CAST(N'2022-06-02' AS Date), 69000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0004      ', N'CAPPUCCINO/LATTE    Lớn       ', 4, CAST(N'2022-06-02' AS Date), 69000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0005      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-06-02' AS Date), 29000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0006      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-06-02' AS Date), 29000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0007      ', N'PHINDI HẠNH NHÂN    Vừa       ', 1, CAST(N'2022-06-02' AS Date), 45000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0008      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-06-02' AS Date), 29000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0001      ', N'PHIN SỮA ĐÁ    Lớn            ', 1, CAST(N'2022-06-01' AS Date), 39000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0002      ', N'ESPRESSO/AMERICANO            ', 7, CAST(N'2022-06-01' AS Date), 35000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0009      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Nhỏ   ', 2, CAST(N'2022-06-02' AS Date), 39000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0009      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-06-02' AS Date), 29000)
INSERT [Data] ([BillID], [DishName], [Quantity], [Time], [Price]) VALUES (N'0009      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Nhỏ ', 1, CAST(N'2022-06-02' AS Date), 55000)
GO
INSERT [Discount] ([DiscountID], [DiscountName], [Value], [DiscountNameInEng], [Percent], [Active]) VALUES (N'000       ', N'Không khuyến mãi', N'0', N'No discount', 0, 1)
INSERT [Discount] ([DiscountID], [DiscountName], [Value], [DiscountNameInEng], [Percent], [Active]) VALUES (N'001       ', N'Khuyến mãi 10%', N'10', N'10% discount', 1, 1)
INSERT [Discount] ([DiscountID], [DiscountName], [Value], [DiscountNameInEng], [Percent], [Active]) VALUES (N'002       ', N'Khuyến mãi 25%', N'25', N'25% discount', 1, 1)
INSERT [Discount] ([DiscountID], [DiscountName], [Value], [DiscountNameInEng], [Percent], [Active]) VALUES (N'003       ', N'Khuyến mãi 50%', N'50', N'50% discount', 1, 1)
INSERT [Discount] ([DiscountID], [DiscountName], [Value], [DiscountNameInEng], [Percent], [Active]) VALUES (N'004       ', N'Khuyến mãi 10k', N'10000', N'10k discount', 0, 1)
INSERT [Discount] ([DiscountID], [DiscountName], [Value], [DiscountNameInEng], [Percent], [Active]) VALUES (N'005       ', N'Khuyến mãi 20k', N'20000', N'20k discount', 0, 0)
INSERT [Discount] ([DiscountID], [DiscountName], [Value], [DiscountNameInEng], [Percent], [Active]) VALUES (N'006       ', N'Khuyến mãi 100k', N'100000', N'100k discount', 0, 1)
GO
INSERT [DishGroup] ([GroupID], [GroupName], [Value], [GroupNameInEng]) VALUES (N'G001', N'Cà Phê Phin', NULL, N'Vietnamese PHIN coffee')
INSERT [DishGroup] ([GroupID], [GroupName], [Value], [GroupNameInEng]) VALUES (N'G002', N'Trà', NULL, N'Tea')
INSERT [DishGroup] ([GroupID], [GroupName], [Value], [GroupNameInEng]) VALUES (N'G003', N'Freeze', NULL, N'Iced blended')
INSERT [DishGroup] ([GroupID], [GroupName], [Value], [GroupNameInEng]) VALUES (N'G004', N'Phindi', NULL, N'Phindi')
INSERT [DishGroup] ([GroupID], [GroupName], [Value], [GroupNameInEng]) VALUES (N'G005', N'Cà phê Espresso', NULL, N'Espresso coffee')
INSERT [DishGroup] ([GroupID], [GroupName], [Value], [GroupNameInEng]) VALUES (N'G006', N'Bánh', NULL, N'Pastry')
INSERT [DishGroup] ([GroupID], [GroupName], [Value], [GroupNameInEng]) VALUES (N'G007', N'Thức uống khác', NULL, N'Other drinks')
GO
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA01      ', N'TIRAMISU', 29000, N'G006', N'TIRAMISU CAKE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA02      ', N'BÁNH CHUỐI', 29000, N'G006', N'BANANA CAKE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA03      ', N'MAOUSSE ĐÀO', 29000, N'G006', N'PEACH MAOUSSE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA04      ', N'MOUSSE CACAO', 29000, N'G006', N'CACOA MAOUSSE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA05      ', N'PHÔ MAI TRÀ XANH', 29000, N'G006', N'GREEN TEA CHEESE CAKE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA06      ', N'PHÔ MAI CHANH DÂY', 29000, N'G006', N'PASSION FRUIT CHEESE CAKE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA07      ', N'PHÔ MAI CÀ PHÊ', 29000, N'G006', N'COFFE CHEESE CAKE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA08      ', N'PHÔ MAI CARAMEL', 29000, N'G006', N'CARAMEL CHEESE CAKE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'BA09      ', N'SÔ-CÔ-LA HIGHLANDS', 29000, N'G006', N'CHOCOLATE HIGHLANDS CAKE')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE01      ', N'ESPRESSO/AMERICANO ', 35000, N'G005', N'ESPRESSO/AMERICANO SMALL')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE02      ', N'ESPRESSO/AMERICANO', 39000, N'G005', N'ESPRESSO/AMERICANO NORMAL')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE03      ', N'ESPRESSO/AMERICANO', 45000, N'G005', N'ESPRESSO/AMERICANO BIG')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE04      ', N'CAPPUCCINO/LATTE    Nhỏ', 55000, N'G005', N'CAPPUCCINO/LATTE SMALL')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE05      ', N'CAPPUCCINO/LATTE    Vừa', 65000, N'G005', N'CAPPUCCINO/LATTE NORMAL')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE06      ', N'CAPPUCCINO/LATTE    Lớn', 69000, N'G005', N'CAPPUCCINO/LATTE BBIG')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE07      ', N'MOCHA/CARAMEL MACCHIATO    Nhỏ', 59000, N'G005', N'MOCHA/CARAMEL MACCHIATO SMALL')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE08      ', N'MOCHA/CARAMEL MACCHIATO    Vừa', 69000, N'G005', N'MOCHA/CARAMEL MACCHIATO NORMAL')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CE09      ', N'MOCHA/CARAMEL MACCHIATO    Lớn', 75000, N'G005', N'MOCHA/CARAMEL MACCHIATO BIG')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CF01      ', N'PHIN SỮA ĐÁ    Nhỏ', 29000, N'G001', N'PHIN COFFE & CONDENSED MILK 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CF02      ', N'PHIN SỮA ĐÁ    Vừa', 35000, N'G001', N'PHIN COFFE & CONDENSED MILK 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CF03      ', N'PHIN SỮA ĐÁ    Lớn', 39000, N'G001', N'PHIN COFFE & CONDENSED MILK 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CF04      ', N'PHIN ĐEN ĐÁ    Nhỏ', 29000, N'G001', N'PHIN COFFEE 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CF05      ', N'PHIN ĐEN ĐÁ    Vừa', 35000, N'G001', N'PHIN COFFEE 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CF07      ', N'BẠC XỈU ĐÁ ĐÁ    Nhỏ', 29000, N'G001', N'WHITE PHIN COFFEE & CONDENSED MILK 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CF08      ', N'BẠC XỈU ĐÁ ĐÁ    Vừa', 35000, N'G001', N'WHITE PHIN COFFEE & CONDENSED MILK 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'CF09      ', N'BẠC XỈU ĐÁ ĐÁ    Lớn', 39000, N'G001', N'WHITE PHIN COFFEE & CONDENSED MILK 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR01      ', N'FREEZE TRÀ XANH    Nhỏ', 49000, N'G003', N'GREEN TEA FREEZE 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR02      ', N'FREEZE TRÀ XANH    Vừa', 59000, N'G003', N'GREEN TEA FREEZE 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR03      ', N'FREEZE TRÀ XANH    Lớn', 65000, N'G003', N'GREEN TEA FREEZE 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR04      ', N'FREEZE SÔ-CÔ-LA    Nhỏ', 49000, N'G003', N'CHOCOLATE FREEZE 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR05      ', N'FREEZE SÔ-CÔ-LA    Vừa', 59000, N'G003', N'CHOCOLATE FREEZE 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR06      ', N'FREEZE SÔ-CÔ-LA    Lớn', 65000, N'G003', N'CHOCOLATE FREEZE 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR07      ', N'FREEZE COOKIES & CREAM    Nhỏ', 49000, N'G003', N'COOKIES & CREAMS FREEZE 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR08      ', N'FREEZE COOKIES & CREAM    Vừa', 59000, N'G003', N'COOKIES & CREAMS FREEZE 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR09      ', N'FREEZE COOKIES & CREAM    Lớn', 65000, N'G003', N'COOKIES & CREAMS FREEZE 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR10      ', N'FREEZE CARAMEL PHIN FREEZE    Nhỏ', 49000, N'G003', N'CARAMEL PHIN FREEZE SMALL 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR11      ', N'FREEZE CARAMEL PHIN FREEZE    Vừa', 59000, N'G003', N'CARAMEL PHIN FREEZE SMALL 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR12      ', N'FREEZE CARAMEL PHIN FREEZE    Lớn', 65000, N'G003', N'CARAMEL PHIN FREEZE SMALL 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR13      ', N'CLASSIC CARAMEL PHIN FREEZE    Nhỏ', 49000, N'G003', N'CLASSIC CARAMEL PHIN FREEZE 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR14      ', N'CLASSIC CARAMEL PHIN FREEZE    Vừa', 59000, N'G003', N'CLASSIC CARAMEL PHIN FREEZE 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'FR15      ', N'CLASSIC CARAMEL PHIN FREEZE    Lớn', 65000, N'G003', N'CLASSIC CARAMEL PHIN FREEZE 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT01      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Nhỏ', 39000, N'G007', N'LIME ICE BLENDED/ICED 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT02      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Vừa', 49000, N'G007', N'LIME ICE BLENDED/ICED 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT03      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Lớn', 55000, N'G007', N'LIME ICE BLENDED/ICED 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT04      ', N'CHANH DÂY ĐÁ VIÊN    Nhỏ', 39000, N'G007', N'ICED PASSION FRUIT 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT05      ', N'CHANH DÂY ĐÁ VIÊN    Vừa', 49000, N'G007', N'ICED PASSION FRUIT 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT06      ', N'CHANH DÂY ĐÁ VIÊN    Lớn', 55000, N'G007', N'ICED PASSION FRUIT 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT07      ', N'TẮT/QUẤT ĐÁ VIÊN    Nhỏ', 39000, N'G007', N'ICED KUMQUAT 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT08      ', N'TẮT/QUẤT ĐÁ VIÊN    Vừa', 49000, N'G007', N'ICED KUMQUAT 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT09      ', N'TẮT/QUẤT ĐÁ VIÊN    Lớn', 55000, N'G007', N'ICED KUMQUAT 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT10      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Nhỏ', 55000, N'G007', N'CHOCOLATE(HOT OR ICED) 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT11      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Vừa', 59000, N'G007', N'CHOCOLATE(HOT OR ICED) 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'OT12      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Lớn', 65000, N'G007', N'CHOCOLATE(HOT OR ICED) 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH01      ', N'PHINDI KEM SỮA    Nhỏ', 39000, N'G004', N'ICED COFFEE WITH MILK FOAM 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH02      ', N'PHINDI KEM SỮA    Vừa', 45000, N'G004', N'ICED COFFEE WITH MILK FOAM 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH03      ', N'PHINDI KEM SỮA    Lớn', 49000, N'G004', N'ICED COFFEE WITH MILK FOAM 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH04      ', N'PHINDI HẠNH NHÂN    Nhỏ', 39000, N'G004', N'ICED COFFEE WITH ALMOND & FRESH MILK 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH05      ', N'PHINDI HẠNH NHÂN    Vừa', 45000, N'G004', N'ICED COFFEE WITH ALMOND & FRESH MILK 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH06      ', N'PHINDI HẠNH NHÂN    Lớn', 49000, N'G004', N'ICED COFFEE WITH ALMOND & FRESH MILK 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH07      ', N'PHINDI CHOCO    Nhỏ', 39000, N'G004', N'ICED COFFEE WITH CHOCOLATE 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH08      ', N'PHINDI CHOCO    Vừa', 45000, N'G004', N'ICED COFFEE WITH CHOCOLATE 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'PH09      ', N'PHINDI CHOCO    Lớn', 49000, N'G004', N'ICED COFFEE WITH CHOCOLATE 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR01      ', N'TRÀ SEN VÀNG    Nhỏ', 39000, N'G002', N'TEA WITH LOTUS SEEDS 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR02      ', N'TRÀ SEN VÀNG    Vừa', 49000, N'G002', N'TEA WITH LOTUS SEEDS 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR03      ', N'TRÀ SEN VÀNG    Lớn', 55000, N'G002', N'TEA WITH LOTUS SEEDS 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR04      ', N'TRÀ THẠCH ĐÀO    Nhỏ', 39000, N'G002', N'TEA WITH PEACH JELLY 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR05      ', N'TRÀ THẠCH ĐÀO    Vừa', 49000, N'G002', N'TEA WITH PEACH JELLY 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR06      ', N'TRÀ THẠCH ĐÀO    Lớn', 55000, N'G002', N'TEA WITH PEACH JELLY 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR07      ', N'TRÀ THANH ĐÀO    Nhỏ', 39000, N'G002', N'PEACH TEA WITH LEMONGRASS 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR08      ', N'TRÀ THANH ĐÀO    Vừa', 49000, N'G002', N'PEACH TEA WITH LEMONGRASS 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR09      ', N'TRÀ THANH ĐÀO    Lớn', 55000, N'G002', N'PEACH TEA WITH LEMONGRASS 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR10      ', N'TRÀ THẠCH VẢI    Nhỏ', 39000, N'G002', N'TEA WITH LYCHEE JELLY 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR11      ', N'TRÀ THẠCH VẢI    Vừa', 49000, N'G002', N'TEA WITH LYCHEE JELLY 12OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR12      ', N'TRÀ THẠCH VẢI    Lớn', 55000, N'G002', N'TEA WITH LYCHEE JELLY 16OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR13      ', N'TRÀ XANH ĐẬU ĐỎ    Nhỏ', 39000, N'G002', N'GREEN TEA & RED BEANS 10OZ')
INSERT [Menu] ([DishID], [DishName], [Price], [GroupID], [DishNameEng]) VALUES (N'TR14      ', N'TRÀ XANH ĐẬU ĐỎ    Vừa', 49000, N'G002', N'GREEN TEA & RED BEANS 12OZ')
GO
INSERT [Order] ([TableID], [DishID], [Quantity]) VALUES (N'BA01', N'CF01      ', 1)
GO
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0001      ', N'Linh', 934894000, N'123 ABC   ', CAST(N'2022-10-04' AS Date), 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0002      ', N'Đức', 123456789, N'111 AAA   ', CAST(N'2022-04-10' AS Date), 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0003      ', N'Nhâm', 111111111, N'211 AAB   ', CAST(N'2022-04-10' AS Date), 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0004      ', N'Minh', 111111112, N'333 CAA   ', CAST(N'2022-04-10' AS Date), 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0005      ', N'Nhi', 111111222, N'333 NNN   ', CAST(N'2022-04-10' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0006      ', N'Như', 111111333, N'78 ABBBBU ', CAST(N'2022-04-10' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0007      ', N'Nhã', 111111234, N'89 HHU    ', CAST(N'2022-04-10' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0008      ', N'Nhiên', 112111232, N'90 A      ', CAST(N'2022-04-01' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0009      ', N'Nhữ', 112222223, NULL, CAST(N'2022-04-02' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0010      ', N'Nha', 111112233, NULL, CAST(N'2022-04-02' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0011      ', N'Lan', 123232322, N'91 TCC    ', CAST(N'2022-04-02' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0012      ', N'Lãng', 122222333, N'99 KKKKI  ', CAST(N'2022-04-03' AS Date), 1)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0013      ', N'Liên', 898922322, N'901 IIDKD ', CAST(N'2022-04-04' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0014      ', N'Liễu', 981273823, N'1222 A    ', CAST(N'2022-04-01' AS Date), 0)
INSERT [Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [Sex]) VALUES (N'0015      ', N'Linh', 123987822, N'2 B       ', CAST(N'2022-04-01' AS Date), 0)
GO
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn], [GrocNameInEng]) VALUES (N'CF01      ', N'Hạt cà phê', N'10        ', N'Kg', 60000, CAST(N'2022-04-16T00:00:00.000' AS DateTime), N'Coffee beans')
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn], [GrocNameInEng]) VALUES (N'CF03      ', N'Đường trắng', N'19        ', N'Kg', 80000, CAST(N'2022-04-13T00:00:00.000' AS DateTime), N'White sugar')
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn], [GrocNameInEng]) VALUES (N'CF04      ', N'Đường nâu', N'40        ', N'Kg', 89000, CAST(N'2022-04-13T00:00:00.000' AS DateTime), N'Coffee ')
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn], [GrocNameInEng]) VALUES (N'CF06      ', N'Sữa La Roseé', N'1         ', N'Thùng', 564000, CAST(N'2022-04-13T00:00:00.000' AS DateTime), N'Condensed milk')
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn], [GrocNameInEng]) VALUES (N'DA02      ', N'Trứng', N'50        ', N'Quả', 7000, CAST(N'2022-04-16T00:00:00.000' AS DateTime), N'Eggs')
INSERT [Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn], [GrocNameInEng]) VALUES (N'TS01      ', N'Bột trà sữa', N'0         ', N'Bao', 100000, CAST(N'2022-04-14T00:00:00.000' AS DateTime), N'Milk Tea Powder')
GO
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA01', N'0001', N'Bàn 1     ', 1, N'BA01', N'Table 1')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA02', N'0001', N'Bàn 2     ', 0, N'BA02', N'Table 2')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA03', N'0001', N'Bàn 3     ', 0, N'BA03', N'Table 3')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA04', N'0002', N'Bàn 4     ', 0, N'BA04,BA01', N'Table 4')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA05', N'0002', N'Bàn 5     ', 0, N'BA05', N'Table 5')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA06', N'0002', N'Bàn 6     ', 0, N'BA06', N'Table 6')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA08', N'0004', N'Bàn 8     ', 0, N'BA08', N'Table 8')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA09', N'0004', N'Bàn 9     ', 0, N'BA09', N'Table 9')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA10', N'0004', N'Bàn 10    ', 0, N'BA10', N'Table 10')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA11', N'0005', N'Bàn 11    ', 0, N'BA11', N'Table 11')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA12', N'0005', N'Bàn 12    ', 0, N'BA12', N'Table 12')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA13', N'0006', N'Bàn 13    ', 0, N'BA13', N'Table 13')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA14', N'0006', N'Bàn 14    ', 0, N'BA14', N'Table 14')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA15', N'0007', N'Bàn 15    ', 0, N'BA15', N'Table 15')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA17', N'0008', N'VIP 1', 0, N'BA17', N'V.I.P table')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA18', N'0001', N'Bảng xx', 0, N'BA18', N'Table xx')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA19', N'0001', N'Bàn xx', 0, N'BA19', N'Table xx')
INSERT [Table] ([TableID], [AreaID], [TableName], [Status], [MergeList], [TableNameInEng]) VALUES (N'BA20', N'0009', N'Bàn 1', 0, N'BA20', N'Table 1')
GO
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd], [ShiftNameInEng]) VALUES (N'CH01      ', N'Chiều 1', N'Jan  1 1900  1:30PM', N'Jan  1 1900  4:00PM', N'Afternoon 1')
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd], [ShiftNameInEng]) VALUES (N'CH02      ', N'Chiều 2', N'Jan  1 1900  4:00PM', N'Jan  1 1900  7:00PM', N'Afternoon 2')
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd], [ShiftNameInEng]) VALUES (N'SA01      ', N'Sáng 1', N'Jan  1 1900  5:00AM', N'Jan  1 1900  9:30AM', N'Day 1')
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd], [ShiftNameInEng]) VALUES (N'SA02      ', N'Sáng 2', N'Jan  1 1900  9:30AM', N'Jan  1 1900  1:30PM', N'Day 2')
INSERT [WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd], [ShiftNameInEng]) VALUES (N'TO01      ', N'Tối 1', N'Jan  1 1900  7:00PM', N'Jan  1 1900 11:00PM', NULL)
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
ALTER TABLE [Bill]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([StaffID])
REFERENCES [Staff] ([StaffID])
GO
ALTER TABLE [Bill] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [Data]  WITH CHECK ADD  CONSTRAINT [FK_Data_Bill] FOREIGN KEY([BillID])
REFERENCES [Bill] ([BillID])
GO
ALTER TABLE [Data] CHECK CONSTRAINT [FK_Data_Bill]
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
ALTER TABLE [Order]  WITH CHECK ADD  CONSTRAINT [FK_DatMon_DoAn] FOREIGN KEY([DishID])
REFERENCES [Menu] ([DishID])
GO
ALTER TABLE [Order] CHECK CONSTRAINT [FK_DatMon_DoAn]
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
USE [master]
GO
ALTER DATABASE [PBL3] SET  READ_WRITE 
GO
