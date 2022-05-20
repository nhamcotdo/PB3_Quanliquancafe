USE [master]
GO
/****** Object:  Database [PBL3]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE DATABASE [PBL3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PBL3', FILENAME = N'C:\Users\Linh\PBL3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PBL3_log', FILENAME = N'C:\Users\Linh\PBL3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
ALTER DATABASE [PBL3] SET AUTO_CLOSE ON 
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
ALTER DATABASE [PBL3] SET  ENABLE_BROKER 
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
/****** Object:  Table [dbo].[Account]    Script Date: 5/20/2022 10:24:36 PM ******/
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
UPDATE STATISTICS [dbo].[Account] WITH ROWCOUNT = 2, PAGECOUNT = 1
GO
/****** Object:  Table [dbo].[Area]    Script Date: 5/20/2022 10:24:36 PM ******/
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
/****** Object:  Table [dbo].[Bill]    Script Date: 5/20/2022 10:24:36 PM ******/
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
/****** Object:  Table [dbo].[Data]    Script Date: 5/20/2022 10:24:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Data](
	[BillID] [nchar](10) NOT NULL,
	[DishName] [nchar](30) NOT NULL,
	[Quantity] [int] NULL,
	[Time] [date] NOT NULL,
 CONSTRAINT [PK__Data__A9831F3858CF57E1] PRIMARY KEY CLUSTERED 
(
	[DishName] ASC,
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 5/20/2022 10:24:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[DiscountID] [nchar](10) NOT NULL,
	[DisCountName] [nvarchar](max) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DishGroup]    Script Date: 5/20/2022 10:24:36 PM ******/
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
/****** Object:  Table [dbo].[Income]    Script Date: 5/20/2022 10:24:36 PM ******/
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
UPDATE STATISTICS [dbo].[Income] WITH ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 5/20/2022 10:24:36 PM ******/
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
/****** Object:  Table [dbo].[Order]    Script Date: 5/20/2022 10:24:36 PM ******/
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
UPDATE STATISTICS [dbo].[Order] WITH ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 5/20/2022 10:24:36 PM ******/
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
/****** Object:  Table [dbo].[Storage]    Script Date: 5/20/2022 10:24:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Storage](
	[GrocID] [nchar](10) NOT NULL,
	[GrocName] [nvarchar](50) NOT NULL,
	[Quantity] [nchar](10) NOT NULL,
	[Unit] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[TimeCheckIn] [datetime] NOT NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[GrocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 5/20/2022 10:24:36 PM ******/
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
/****** Object:  Table [dbo].[TakeOut]    Script Date: 5/20/2022 10:24:36 PM ******/
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
UPDATE STATISTICS [dbo].[TakeOut] WITH ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Table [dbo].[WorkShift]    Script Date: 5/20/2022 10:24:36 PM ******/
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
GO
INSERT [dbo].[Account] ([StaffID], [Account], [Password], [Role]) VALUES (N'0002      ', N'duc', N'1234', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0001', N'Khu A     ', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0002', N'Khu B     ', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0003', N'Khu C     ', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0004', N'Khu D     ', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0005', N'Khu E     ', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0006', N'Khu F     ', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0007', N'Khu G     ', 0)
GO
INSERT [dbo].[Area] ([AreaID], [AreaName], [TrangThai]) VALUES (N'0008', N'KHU VIP', 0)
GO
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0001      ', CAST(N'2022-11-05T23:01:18.000' AS DateTime), 204000, N'000       ', 0, N'BA01', N'0001      ')
GO
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0002      ', CAST(N'2022-11-05T23:15:29.000' AS DateTime), 70000, N'000       ', 0, N'BA04', N'0001      ')
GO
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0003      ', CAST(N'2022-05-13T08:36:05.000' AS DateTime), 255000, N'000       ', 0, N'BA01', N'0001      ')
GO
INSERT [dbo].[Bill] ([BillID], [TimeCheckOut], [TotalBill], [DiscountID], [OtherFee], [TableID], [StaffID]) VALUES (N'0004      ', CAST(N'2022-05-13T08:39:04.000' AS DateTime), 29000, N'000       ', 0, N'BA02', N'0001      ')
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time]) VALUES (N'0003      ', N'BẠC XỈU ĐÁ ĐÁ    Nhỏ          ', 2, CAST(N'2022-05-13' AS Date))
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time]) VALUES (N'0003      ', N'ESPRESSO/AMERICANO    Nhỏ     ', 1, CAST(N'2022-05-13' AS Date))
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time]) VALUES (N'0003      ', N'MOCHA/CARAMEL MACCHIATO    Lớn', 1, CAST(N'2022-05-13' AS Date))
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time]) VALUES (N'0001      ', N'PHIN S?A ÐÁ    L?n            ', 3, CAST(N'2022-11-05' AS Date))
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time]) VALUES (N'0001      ', N'PHIN S?A ÐÁ    Nh?            ', 3, CAST(N'2022-11-05' AS Date))
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time]) VALUES (N'0003      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 3, CAST(N'2022-05-13' AS Date))
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time]) VALUES (N'0004      ', N'PHIN SỮA ĐÁ    Nhỏ            ', 1, CAST(N'2022-05-13' AS Date))
GO
INSERT [dbo].[Data] ([BillID], [DishName], [Quantity], [Time]) VALUES (N'0002      ', N'PHIN SỮA ĐÁ    Vừa            ', 2, CAST(N'2022-11-05' AS Date))
GO
INSERT [dbo].[Discount] ([DiscountID], [DisCountName], [Value]) VALUES (N'000       ', N'Không khuyển mãi ', N'0')
GO
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G001', N'Cà Phê Phin', NULL)
GO
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G002', N'Trà', NULL)
GO
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G003', N'Freeze', NULL)
GO
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G004', N'Phindi', NULL)
GO
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G005', N'Cà phê Espresso', NULL)
GO
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G006', N'Bánh', NULL)
GO
INSERT [dbo].[DishGroup] ([GroupID], [GroupName], [Value]) VALUES (N'G007', N'Thức uống khác', NULL)
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA01      ', N'TIRAMISU    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA02      ', N'BÁNH CHUỐI    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA03      ', N'MAOUSSE ĐÀO    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA04      ', N'MOUSSE CACAO    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA05      ', N'PHÔ MAI TRÀ XANH    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA06      ', N'PHÔ MAI CHANH DÂY    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA07      ', N'PHÔ MAI CÀ PHÊ    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA08      ', N'PHÔ MAI CARAMEL    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'BA09      ', N'SÔ-CÔ-LA HIGHLANDS    Nhỏ', 29000, N'G006')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE01      ', N'ESPRESSO/AMERICANO    Nhỏ', 35000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE02      ', N'ESPRESSO/AMERICANO    Vừa', 39000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE03      ', N'ESPRESSO/AMERICANO    Lớn', 45000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE04      ', N'CAPPUCCINO/LATTE    Nhỏ', 55000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE05      ', N'CAPPUCCINO/LATTE    Vừa', 65000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE06      ', N'CAPPUCCINO/LATTE    Lớn', 69000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE07      ', N'MOCHA/CARAMEL MACCHIATO    Nhỏ', 59000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE08      ', N'MOCHA/CARAMEL MACCHIATO    Vừa', 69000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CE09      ', N'MOCHA/CARAMEL MACCHIATO    Lớn', 75000, N'G005')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF01      ', N'PHIN SỮA ĐÁ    Nhỏ', 29000, N'G001')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF02      ', N'PHIN SỮA ĐÁ    Vừa', 35000, N'G001')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF03      ', N'PHIN SỮA ĐÁ    Lớn', 39000, N'G001')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF04      ', N'PHIN ĐEN ĐÁ    Nhỏ', 29000, N'G001')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF05      ', N'PHIN ĐEN ĐÁ    Vừa', 35000, N'G001')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF07      ', N'BẠC XỈU ĐÁ ĐÁ    Nhỏ', 29000, N'G001')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF08      ', N'BẠC XỈU ĐÁ ĐÁ    Vừa', 35000, N'G001')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'CF09      ', N'BẠC XỈU ĐÁ ĐÁ    Lớn', 39000, N'G001')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR01      ', N'FREEZE TRÀ XANH    Nhỏ', 49000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR02      ', N'FREEZE TRÀ XANH    Vừa', 59000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR03      ', N'FREEZE TRÀ XANH    Lớn', 65000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR04      ', N'FREEZE SÔ-CÔ-LA    Nhỏ', 49000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR05      ', N'FREEZE SÔ-CÔ-LA    Vừa', 59000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR06      ', N'FREEZE SÔ-CÔ-LA    Lớn', 65000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR07      ', N'FREEZE COOKIES & CREAM    Nhỏ', 49000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR08      ', N'FREEZE COOKIES & CREAM    Vừa', 59000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR09      ', N'FREEZE COOKIES & CREAM    Lớn', 65000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR10      ', N'FREEZE CARAMEL PHIN FREEZE    Nhỏ', 49000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR11      ', N'FREEZE CARAMEL PHIN FREEZE    Vừa', 59000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR12      ', N'FREEZE CARAMEL PHIN FREEZE    Lớn', 65000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR13      ', N'CLASSIC CARAMEL PHIN FREEZE    Nhỏ', 49000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR14      ', N'CLASSIC CARAMEL PHIN FREEZE    Vừa', 59000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'FR15      ', N'CLASSIC CARAMEL PHIN FREEZE    Lớn', 65000, N'G003')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT01      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Nhỏ', 39000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT02      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Vừa', 49000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT03      ', N'CHANH ĐÁ XAY/ĐÁ VIÊN    Lớn', 55000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT04      ', N'CHANH DÂY ĐÁ VIÊN    Nhỏ', 39000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT05      ', N'CHANH DÂY ĐÁ VIÊN    Vừa', 49000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT06      ', N'CHANH DÂY ĐÁ VIÊN    Lớn', 55000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT07      ', N'CHTẮT/QUẤT ĐÁ VIÊN    Nhỏ', 39000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT08      ', N'CHTẮT/QUẤT ĐÁ VIÊN    Vừa', 49000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT09      ', N'CHTẮT/QUẤT ĐÁ VIÊN    Lớn', 55000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT10      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Nhỏ', 55000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT11      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Vừa', 59000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'OT12      ', N'SÔ-CÔ-LA(nóng hoặc đá)    Lớn', 65000, N'G007')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH01      ', N'PHINDI KEM SỮA    Nhỏ', 39000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH02      ', N'PHINDI KEM SỮA    Vừa', 45000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH03      ', N'PHINDI KEM SỮA    Lớn', 49000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH04      ', N'PHINDI HẠNH NHÂN    Nhỏ', 39000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH05      ', N'PHINDI HẠNH NHÂN    Vừa', 45000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH06      ', N'PHINDI HẠNH NHÂN    Lớn', 49000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH07      ', N'PHINDI CHOCO    Nhỏ', 39000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH08      ', N'PHINDI CHOCO    Vừa', 45000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'PH09      ', N'PHINDI CHOCO    Lớn', 49000, N'G004')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR01      ', N'TRÀ SEN VÀNG    Nhỏ', 39000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR02      ', N'TRÀ SEN VÀNG    Vừa', 49000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR03      ', N'TRÀ SEN VÀNG    Lớn', 55000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR04      ', N'TRÀ THẠCH ĐÀO    Nhỏ', 39000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR05      ', N'TRÀ THẠCH ĐÀO    Vừa', 49000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR06      ', N'TRÀ THẠCH ĐÀO    Lớn', 55000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR07      ', N'TRÀ THANH ĐÀO    Nhỏ', 39000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR08      ', N'TRÀ THANH ĐÀO    Vừa', 49000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR09      ', N'TRÀ THANH ĐÀO    Lớn', 55000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR10      ', N'TRÀ THẠCH VẢI    Nhỏ', 39000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR11      ', N'TRÀ THẠCH VẢI    Vừa', 49000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR12      ', N'TRÀ THẠCH VẢI    Lớn', 55000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR13      ', N'TRÀ XANH ĐẬU ĐỎ    Nhỏ', 39000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR14      ', N'TRÀ XANH ĐẬU ĐỎ    Vừa', 49000, N'G002')
GO
INSERT [dbo].[Menu] ([DishID], [DishName], [Price], [GroupID]) VALUES (N'TR15      ', N'TRÀ XANH ĐẬU ĐỎ    Lớn', 55000, N'G002')
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0001      ', N'Linh', 934894000, N'123 ABC   ', CAST(N'2022-10-04' AS Date), N'SA01      ', 1)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0002      ', N'Đức', 123456789, N'111 AAA   ', CAST(N'2022-04-10' AS Date), N'SA01      ', 1)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0003      ', N'Nhâm', 111111111, N'211 AAB   ', CAST(N'2022-04-10' AS Date), N'SA02      ', 1)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0004      ', N'Minh', 111111112, N'333 CAA   ', CAST(N'2022-04-10' AS Date), N'SA02      ', 1)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0005      ', N'Nhi', 111111222, N'333 NNN   ', CAST(N'2022-04-10' AS Date), N'CH01      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0006      ', N'Như', 111111333, N'78 ABBBBU ', CAST(N'2022-04-10' AS Date), N'CH01      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0007      ', N'Nhã', 111111234, N'89 HHU    ', CAST(N'2022-04-10' AS Date), N'CH02      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0008      ', N'Nhiên', 112111232, N'90 A      ', CAST(N'2022-04-01' AS Date), N'CH02      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0009      ', N'Nhữ', 112222223, NULL, CAST(N'2022-04-02' AS Date), N'CH02      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0010      ', N'Nha', 111112233, NULL, CAST(N'2022-04-02' AS Date), N'CH02      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0011      ', N'Lan', 123232322, N'91 TCC    ', CAST(N'2022-04-02' AS Date), N'TO01      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0012      ', N'Lãng', 122222333, N'99 KKKKI  ', CAST(N'2022-04-03' AS Date), N'TO01      ', 1)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0013      ', N'Liên', 898922322, N'901 IIDKD ', CAST(N'2022-04-04' AS Date), N'TO01      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0014      ', N'Liễu', 981273823, N'1222 A    ', CAST(N'2022-04-01' AS Date), N'TO01      ', 0)
GO
INSERT [dbo].[Staff] ([StaffID], [StaffName], [PhoneNumber], [Address], [DateIn], [ShiftID], [Sex]) VALUES (N'0015      ', N'Linh', 123987822, N'2 B       ', CAST(N'2022-04-01' AS Date), N'TO01      ', 0)
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF01      ', N'Hạt cà phê', N'10        ', N'Kg', 60000, CAST(N'2022-04-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF02      ', N'Cà phê gói', N'8         ', N'Bịch', 55000, CAST(N'2022-04-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF03      ', N'Sữa ông Thọ', N'1         ', N'Thùng', 365000, CAST(N'2022-04-17T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF04      ', N'Đường nâu', N'40        ', N'Kg', 89000, CAST(N'2022-04-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF05      ', N'Đường trắng', N'19        ', N'Kg', 80000, CAST(N'2022-04-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'CF06      ', N'Sữa La Roseé', N'1         ', N'Thùng', 564000, CAST(N'2022-04-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA01      ', N'Mỳ miliket', N'10        ', N'Thùng', 295000, CAST(N'2022-04-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA02      ', N'Trứng', N'50        ', N'Quả', 7000, CAST(N'2022-04-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA03      ', N'Thịt bò bằm', N'5         ', N'Kg', 80000, CAST(N'2022-04-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA04      ', N'Tôm đất', N'5         ', N'Kg', 80000, CAST(N'2022-04-16T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'DA05      ', N'Khoai tây chiên', N'10        ', N'Kg', 134000, CAST(N'2022-04-12T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Storage] ([GrocID], [GrocName], [Quantity], [Unit], [Price], [TimeCheckIn]) VALUES (N'TS01      ', N'Bột trà sữa', N'0         ', N'Bao', 100000, CAST(N'2022-04-14T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA01', N'0001', N'Bàn 1     ', 0, N'BA01')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA02', N'0001', N'Bàn 2     ', 0, N'BA02,BA01')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA03', N'0001', N'Bàn 3     ', 1, N'BA03')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA04', N'0002', N'Bàn 4     ', 1, N'BA04,BA01')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA05', N'0002', N'Bàn 5     ', 0, N'BA05')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA06', N'0002', N'Bàn 6     ', 0, N'BA06')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA07', N'0003', N'Bàn 7     ', 0, N'BA07')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA08', N'0004', N'Bàn 8     ', 0, N'BA08')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA09', N'0004', N'Bàn 9     ', 1, N'BA09')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA10', N'0004', N'Bàn 10    ', 0, N'BA10')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA11', N'0005', N'Bàn 11    ', 0, N'BA11')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA12', N'0005', N'Bàn 12    ', 0, N'BA12')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA13', N'0006', N'Bàn 13    ', 0, N'BA13')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA14', N'0006', N'Bàn 14    ', 0, N'BA14')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA15', N'0007', N'Bàn 15    ', 0, N'BA15')
GO
INSERT [dbo].[Table] ([TableID], [AreaID], [TableName], [Status], [MergeList]) VALUES (N'BA17', N'0008', N'VIP 1', 0, N'BA17')
GO
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'CH01      ', N'Chiều 1', N'Jan  1 1900  1:30PM', N'Jan  1 1900  4:00PM')
GO
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'CH02      ', N'Chiều 2', N'Jan  1 1900  4:00PM', N'Jan  1 1900  7:00PM')
GO
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'SA01      ', N'Sáng 1', N'Jan  1 1900  5:00AM', N'Jan  1 1900  9:30AM')
GO
INSERT [dbo].[WorkShift] ([ShiftID], [ShiftName], [TimeStart], [TimeEnd]) VALUES (N'SA02      ', N'Sáng 2', N'Jan  1 1900  9:30AM', N'Jan  1 1900  1:30PM')
GO
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
/****** Object:  Statistic [_WA_Sys_00000001_22AA2996]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000001_22AA2996] ON [dbo].[Account]([StaffID]) WITH STATS_STREAM = 0x010000000100000000000000000000008F6D81F50000000082020000000000004202000000000000EF030000EF000000140000000000000008D000340000000007000000074F910094AE000002000000000000000200000000000000000000000000003F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000200000001000000240000000000A04100000040000000000000A0410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130400000000000000000000000000005E00000000000000BE00000000000000C600000000000000CE0000000000000010000000000000003700000000000000100024000000803F000000000000803F3000300030003100200020002000200020002000040000100024000000803F000000000000803F3000300030003200200020002000200020002000040000FF010000000000000002000000020000002800000028000000000000000000000011000000300030003000310020002000200020002000200032002000200020002000200020000400000040000000004003000000810703000001070A00000002000000000000000000000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000002_22AA2996]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000002_22AA2996] ON [dbo].[Account]([Account]) WITH STATS_STREAM = 0x0100000001000000000000000000000013BEF81D000000005B020000000000001B02000000000000E7030000E7000000FFFF00000000000008D00034BE01000007000000E751960094AE000002000000000000000200000000000000000000000000003F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000020000000100000010000000000000410000004000000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130400000000000000000000000000004E0000000000000097000000000000009F00000000000000A70000000000000010000000000000003100000000000000300010000000803F000000000000803F04000001002100610064006D0069006E00300010000000803F000000000000803F04000001001D00640075006300FF010000000000000002000000020000002800000028000000000000000000000008000000610064006D0069006E00640075006300030000004000000000810500000001030500000002000000000000000000000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000003_22AA2996]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000003_22AA2996] ON [dbo].[Account]([Password]) WITH STATS_STREAM = 0x010000000100000000000000000000008F58C77C000000005F020000000000001F02000000000000E7030000E7000000FFFF00000000000008D00034BE01000007000000E751960094AE000002000000000000000200000000000000000000000000003F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000200000001000000100000000000104100000040000000000000104100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001304000000000000000000000000000050000000000000009B00000000000000A300000000000000AB0000000000000010000000000000002F00000000000000300010000000803F000000000000803F04000001001F003100320033003400300010000000803F000000000000803F04000001002100610064006D0069006E00FF0100000000000000020000000200000028000000280000000000000000000000090000003100320033003400610064006D0069006E00030000004000000000810400000001050400000002000000000000000000000000000000
GO
/****** Object:  Statistic [PK_KhuVuc]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[Area]([PK_KhuVuc]) WITH STATS_STREAM = 0x01000000010000000000000000000000210E4C4800000000F902000000000000B902000000000000E7030000E7000000080000000000000008D0003400000000070000000E4F910094AE0000080000000000000008000000000000000000803F0000003E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000500000005000000010000001000000000000041000000410000000000000041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013040000000000000000000000000000C30000000000000035010000000000003D0100000000000045010000000000002800000000000000470000000000000066000000000000008500000000000000A400000000000000300010000000803F000000000000803F04000001001F003000300030003100300010000000803F0000803F0000803F04000001001F003000300030003300300010000000803F0000803F0000803F04000001001F003000300030003500300010000000803F0000803F0000803F04000001001F003000300030003700300010000000803F000000000000803F04000001001F003000300030003800FF01000000000000000800000008000000280000002800000000000000000000000B000000300030003000310032003300340035003600370038000A00000040000000004003000000810103000081010400008101050000810106000081010700008101080000810109000001010A00000008000000000000000000000000000000, ROWCOUNT = 8, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000004_25869641]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000004_25869641] ON [dbo].[Bill]([DiscountID]) WITH STATS_STREAM = 0x01000000010000000000000000000000908F3199000000003B02000000000000FB01000000000000EF023500EF000000140000000000000008D000340300000007000000084F910094AE000004000000000000000400000000000000000000000000803F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000100000001000000240000000000A04100008040000000000000A0410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130400000000000000000000000000002F0000000000000077000000000000007F00000000000000870000000000000008000000000000001000240000008040000000000000803F3000300030002000200020002000200020002000040000FF01000000000000000400000001000000280000002800000000000000000000000A0000003000300030002000200020002000200020002000020000004000000000040A0000000004000000000000000000000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000006_25869641]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000006_25869641] ON [dbo].[Bill]([TableID]) WITH STATS_STREAM = 0x010000000100000000000000000000009486C6DB0000000088020000000000004802000000000000E7030000E7000000080000000000000008D000340000000007000000094F910094AE00000400000000000000040000000000000000000000ABAAAA3E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000003000000030000000100000010000000000000410000804000000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130400000000000000000000000000007500000000000000C400000000000000CC00000000000000D4000000000000001800000000000000370000000000000056000000000000003000100000000040000000000000803F04000001001F004200410030003100300010000000803F000000000000803F04000001001F004200410030003200300010000000803F000000000000803F04000001001F004200410030003400FF01000000000000000400000003000000280000002800000000000000000000000600000042004100300031003200340005000000400000000040030000008201030000810104000001010500000004000000000000000000000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000007_25869641]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000007_25869641] ON [dbo].[Bill]([StaffID]) WITH STATS_STREAM = 0x01000000010000000000000000000000C2671F46000000003B02000000000000FB01000000000000EF03BFDCEF000000140000000000000008D0003400000000070000000A4F910094AE000004000000000000000400000000000000000000000000803F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000100000001000000240000000000A04100008040000000000000A0410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130400000000000000000000000000002F0000000000000077000000000000007F00000000000000870000000000000008000000000000001000240000008040000000000000803F3000300030003100200020002000200020002000040000FF01000000000000000400000001000000280000002800000000000000000000000A0000003000300030003100200020002000200020002000020000004000000000040A0000000004000000000000000000000000000000
GO
/****** Object:  Statistic [PK_HoaDon]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[Bill]([PK_HoaDon]) WITH STATS_STREAM = 0x010000000100000000000000000000000E3930660000000040000000000000000000000000000000EF03803FEF000000140000000000000008D0003420002000, ROWCOUNT = 4, PAGECOUNT = 1
GO
/****** Object:  Statistic [PK__Data__A9831F3858CF57E1]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[Data]([PK__Data__A9831F3858CF57E1]) WITH STATS_STREAM = 0x01000000020000000000000000000000580412010000000058000000000000000000000000000000EF030000EF0000003C0000000000000008D00034BE010000EF030000EF000000140000000000000008D0003400000000, ROWCOUNT = 8, PAGECOUNT = 1
GO
/****** Object:  Statistic [PK_Discount]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[Discount]([PK_Discount]) WITH STATS_STREAM = 0x010000000100000000000000000000001D139124000000003B02000000000000FB01000000000000EF030061EF000000140000000000000008D000340000000007000000084F910094AE000001000000000000000100000000000000000000000000803F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000100000001000000240000000000A0410000803F000000000000A0410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130400000000000000000000000000002F0000000000000077000000000000007F0000000000000087000000000000000800000000000000100024000000803F000000000000803F3000300030002000200020002000200020002000040000FF01000000000000000100000001000000280000002800000000000000000000000A0000003000300030002000200020002000200020002000020000004000000000010A0000000001000000000000000000000000000000, ROWCOUNT = 1, PAGECOUNT = 1
GO
/****** Object:  Statistic [PK_DishGroup]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[DishGroup]([PK_DishGroup]) WITH STATS_STREAM = 0x01000000010000000000000000000000BD7432A000000000BB020000000000007B02000000000000EF030000EF000000080000000000000008D0003400000000070000000B4F910094AE0000070000000000000007000000000000000000803F2549123E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004000000040000000100000018000000000000410000E04000000000000000410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130400000000000000000000000000008C00000000000000F700000000000000FF00000000000000070100000000000020000000000000003B0000000000000056000000000000007100000000000000100018000000803F000000000000803F4700300030003100040000100018000000803F0000803F0000803F4700300030003300040000100018000000803F0000803F0000803F4700300030003500040000100018000000803F0000803F0000803F4700300030003700040000FF01000000000000000700000007000000280000002800000000000000000000000A0000004700300030003100320033003400350036003700090000004000000000400300000081010300008101040000810105000081010600008101070000810108000001010900000007000000000000000000000000000000, ROWCOUNT = 7, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000004_2E1BDC42]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000004_2E1BDC42] ON [dbo].[Menu]([GroupID]) WITH STATS_STREAM = 0x0100000001000000000000000000000084A743F700000000DE020000000000009E02000000000000EF030000EF000000080000000000000008D00034BE010000070000000B4F910094AE00004E000000000000004E00000000000000ABAAAA3D2549123E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000050000000500000001000000180000000000004100009C420000000000000041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013040000000000000000000000000000AF000000000000001A0100000000000022010000000000002A01000000000000280000000000000043000000000000005E00000000000000790000000000000094000000000000001000180000001041000000000000803F47003000300031000400001000180000007041000070410000704147003000300033000400001000180000001041000010410000104147003000300035000400001000180000001041000000000000803F47003000300036000400001000180000004041000000000000803F4700300030003700040000FF01000000000000000D00000007000000280000002800000000000000000000000A000000470030003000310032003300340035003600370009000000400000000040030000008201030000820104000083010500008101060000820107000081010800000201090000004E000000000000000000000000000000
GO
/****** Object:  Statistic [PK_DoAn]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[Menu]([PK_DoAn]) WITH STATS_STREAM = 0x010000000100000000000000000000008184505E0000000040000000000000000000000000000000EF030000EF000000140000000000000008D0003410001800, ROWCOUNT = 77, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000006_30F848ED]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000006_30F848ED] ON [dbo].[Staff]([ShiftID]) WITH STATS_STREAM = 0x010000000100000000000000000000007F631FA0000000004B030000000000000B03000000000000EF030000EF000000140000000000000008D0003400000000070000000D4F910094AE00000F000000000000000F0000000000000000000000CDCC4C3E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000050000000500000001000000240000000000A04100007041000000000000A041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013040000000000000000000000000000EB0000000000000087010000000000008F01000000000000970100000000000028000000000000004F0000000000000076000000000000009D00000000000000C4000000000000001000240000000040000000000000803F43004800300031002000200020002000200020000400001000240000008040000000000000803F43004800300032002000200020002000200020000400001000240000000040000000000000803F53004100300031002000200020002000200020000400001000240000000040000000000000803F5300410030003200200020002000200020002000040000100024000000A040000000000000803F54004F0030003100200020002000200020002000040000FF01000000000000000A00000005000000280000002800000000000000000000002500000043004800300031002000200020002000200020003200200020002000200020002000530041003000310020002000200020002000200054004F0030003100200020002000200020002000080000004000000000C003000000810703000003070A0000C003110000810714000002070A0000030A1B0000000F000000000000000000000000000000
GO
/****** Object:  Statistic [PK_NhanVien]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[Staff]([PK_NhanVien]) WITH STATS_STREAM = 0x010000000100000000000000000000008610B7BB0000000061040000000000002104000000000000EF030000EF000000140000000000000008D000349701000007000000074F910094AE00000F000000000000000F000000000000000000803F8988883D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000090000000900000001000000240000000000A04100007041000000000000A041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013040000000000000000000000000000A7010000000000009D02000000000000A502000000000000AD0200000000000048000000000000006F000000000000009600000000000000BD00000000000000E4000000000000000B01000000000000320100000000000059010000000000008001000000000000100024000000803F000000000000803F3000300030003100200020002000200020002000040000100024000000803F0000803F0000803F3000300030003300200020002000200020002000040000100024000000803F0000803F0000803F3000300030003500200020002000200020002000040000100024000000803F0000803F0000803F3000300030003700200020002000200020002000040000100024000000803F0000803F0000803F3000300030003900200020002000200020002000040000100024000000803F000000000000803F3000300031003000200020002000200020002000040000100024000000803F000000000000803F3000300031003100200020002000200020002000040000100024000000803F0000803F0000803F3000300031003300200020002000200020002000040000100024000000803F0000803F0000803F3000300031003500200020002000200020002000040000FF01000000000000000A0000000A000000280000002800000000000000000000004300000030003000300031002000200020002000200020003300200020002000200020002000340020002000200020002000200036002000200020002000200020003700200020002000200020002000390020002000200020002000200031003000200020002000200020002000320020002000200020002000200035002000200020002000200020000E00000040000000004002000000C001020000810703000081070A00008107110000810718000081071F0000010726000040012D000081072E0000810735000081070A000001073C0000000F000000000000000000000000000000, ROWCOUNT = 15, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000006_5AEE82B9]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000006_5AEE82B9] ON [dbo].[Storage]([TimeCheckIn]) WITH STATS_STREAM = 0x01000000010000000000000000000000D6134508000000006B020000000000002B020000000000003D0300203D000000080017030000000000000000803F0000070000006ED0D6009AAE00000C000000000000000C0000000000000000000000CDCC4C3E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000500000005000000010000001800000000000041000040410000000000000041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011040000000000000000000000000000AF00000000000000B700000000000000BF00000000000000280000000000000043000000000000005E0000000000000079000000000000009400000000000000100018000000803F000000000000803F0000000075AE00000400001000180000004040000000000000803F0000000076AE00000400001000180000000040000000000000803F0000000077AE0000040000100018000000A040000000000000803F0000000079AE0000040000100018000000803F000000000000803F000000007AAE00000400000C000000000000000000000000000000
GO
/****** Object:  Statistic [PK_HangHoa]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[Storage]([PK_HangHoa]) WITH STATS_STREAM = 0x0100000001000000000000000000000043A6E163000000001B04000000000000DB03000000000000EF0300A0EF000000140000000000000008D00034000400000700000086D9950094AE00000C000000000000000C000000000000000000803FABAAAA3D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000080000000800000001000000240000000000A04100004041000000000000A041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013040000000000000000000000000000780100000000000057020000000000005F020000000000006702000000000000400000000000000067000000000000008E00000000000000B500000000000000DC0000000000000003010000000000002A010000000000005101000000000000100024000000803F000000000000803F4300460030003100200020002000200020002000040000100024000000803F0000803F0000803F4300460030003300200020002000200020002000040000100024000000803F0000803F0000803F4300460030003500200020002000200020002000040000100024000000803F000000000000803F4300460030003600200020002000200020002000040000100024000000803F000000000000803F4400410030003100200020002000200020002000040000100024000000803F0000803F0000803F4400410030003300200020002000200020002000040000100024000000803F0000803F0000803F4400410030003500200020002000200020002000040000100024000000803F000000000000803F5400530030003100200020002000200020002000040000FF01000000000000000A0000000A000000280000002800000000000000000000003A00000043004600300031002000200020002000200020003300200020002000200020002000340020002000200020002000200035002000200020002000200020003600200020002000200020002000440041003000310020002000200020002000200054005300300031002000200020002000200020000D0000004000000000C003000000810703000081070A00008107110000810718000001071F0000C003260000810729000081070A000081071100000107180000010A300000000C000000000000000000000000000000, ROWCOUNT = 12, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000002_34C8D9D1]    Script Date: 5/20/2022 10:24:36 PM ******/
CREATE STATISTICS [_WA_Sys_00000002_34C8D9D1] ON [dbo].[Table]([AreaID]) WITH STATS_STREAM = 0x010000000100000000000000000000002C0BD139000000001203000000000000D202000000000000E7030020E7000000080000000000000008D0003400440041070000000E4F910094AE000010000000000000001000000000000000ABAA2A3F0000003E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000600000006000000010000001000000000000041000080410000000000000041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013040000000000000000000000000000EA000000000000004E0100000000000056010000000000005E0100000000000030000000000000004F000000000000006E000000000000008D00000000000000AC00000000000000CB000000000000003000100000004040000000000000803F04000001001F0030003000300031003000100000004040000000000000803F04000001001F003000300030003200300010000000803F000000000000803F04000001001F0030003000300033003000100000004040000000000000803F04000001001F0030003000300034003000100000000040000000400000004004000001001F003000300030003600300010000000803F0000803F0000803F04000001001F003000300030003800FF01000000000000000A00000006000000280000002800000000000000000000000900000030003000300031003200340035003600380008000000400000000040030000008201030000820104000082010500008101060000820107000001010800000010000000000000000000000000000000
GO
/****** Object:  Statistic [PK_Ban]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[Table]([PK_Ban]) WITH STATS_STREAM = 0x01000000010000000000000000000000ED0693FA00000000D4030000000000009403000000000000E7030000E7000000080000000000000008D000340000000007000000094F910094AE0000100000000000000010000000000000000000803F0000803D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A0000000A000000010000001000000000000041000080410000000000000041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013040000000000000000000000000000860100000000000010020000000000001802000000000000200200000000000050000000000000006F000000000000008E00000000000000AD00000000000000CC00000000000000EB000000000000000A01000000000000290100000000000048010000000000006701000000000000300010000000803F000000000000803F04000001001F004200410030003100300010000000803F0000803F0000803F04000001001F004200410030003300300010000000803F0000803F0000803F04000001001F004200410030003500300010000000803F0000803F0000803F04000001001F004200410030003700300010000000803F0000803F0000803F04000001001F004200410030003900300010000000803F000000000000803F04000001001F004200410031003000300010000000803F000000000000803F04000001001F004200410031003100300010000000803F0000803F0000803F04000001001F004200410031003300300010000000803F0000803F0000803F04000001001F004200410031003500300010000000803F000000000000803F04000001001F004200410031003700FF01000000000000000A0000000A000000280000002800000000000000000000000D00000042004100300031003300350036003800390031003100340037000E00000040000000004002000000C001020000810103000081010400008101050000810106000081010700000101080000400109000081010A0000810104000081010B000001010C00000010000000000000000000000000000000, ROWCOUNT = 16, PAGECOUNT = 1
GO
/****** Object:  Statistic [PK_CaLamViec]    Script Date: 5/20/2022 10:24:36 PM ******/
UPDATE STATISTICS [dbo].[WorkShift]([PK_CaLamViec]) WITH STATS_STREAM = 0x010000000100000000000000000000005A020E70000000004B030000000000000B03000000000000EF030000EF000000140000000000000008D00034BE010000070000000D4F910094AE00000500000000000000050000000000000000000000CDCC4C3E0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000050000000500000001000000240000000000A0410000A040000000000000A041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013040000000000000000000000000000EB0000000000000087010000000000008F01000000000000970100000000000028000000000000004F0000000000000076000000000000009D00000000000000C400000000000000100024000000803F000000000000803F4300480030003100200020002000200020002000040000100024000000803F000000000000803F4300480030003200200020002000200020002000040000100024000000803F000000000000803F5300410030003100200020002000200020002000040000100024000000803F000000000000803F5300410030003200200020002000200020002000040000100024000000803F000000000000803F54004F0030003100200020002000200020002000040000FF01000000000000000500000005000000280000002800000000000000000000002500000043004800300031002000200020002000200020003200200020002000200020002000530041003000310020002000200020002000200054004F0030003100200020002000200020002000080000004000000000C003000000810703000001070A0000C003110000810714000001070A0000010A1B00000005000000000000000000000000000000, ROWCOUNT = 5, PAGECOUNT = 1
GO
USE [master]
GO
ALTER DATABASE [PBL3] SET  READ_WRITE 
GO
