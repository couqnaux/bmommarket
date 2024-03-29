USE [master]
GO
/****** Object:  Database [BMomMarket]    Script Date: 08/01/2024 8:46:28 PM ******/
CREATE DATABASE [BMomMarket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SieuThiMini', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SieuThiMini.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SieuThiMini_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\SieuThiMini_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BMomMarket] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BMomMarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BMomMarket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BMomMarket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BMomMarket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BMomMarket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BMomMarket] SET ARITHABORT OFF 
GO
ALTER DATABASE [BMomMarket] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BMomMarket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BMomMarket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BMomMarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BMomMarket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BMomMarket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BMomMarket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BMomMarket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BMomMarket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BMomMarket] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BMomMarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BMomMarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BMomMarket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BMomMarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BMomMarket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BMomMarket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BMomMarket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BMomMarket] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BMomMarket] SET  MULTI_USER 
GO
ALTER DATABASE [BMomMarket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BMomMarket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BMomMarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BMomMarket] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BMomMarket] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BMomMarket]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 08/01/2024 8:46:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 08/01/2024 8:46:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [bigint] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Address] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 08/01/2024 8:46:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [bigint] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 08/01/2024 8:46:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime] NULL,
	[CustomerID] [bigint] NULL,
	[EmployeeID] [bigint] NULL,
	[TotalPrice] [bigint] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 08/01/2024 8:46:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderID] [bigint] NULL,
	[ProductID] [bigint] NULL,
	[Quantity] [bigint] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 08/01/2024 8:46:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [bigint] NULL,
	[Quantity] [bigint] NULL,
	[CategoryID] [bigint] NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Sữa bột')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Bỉm tã')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Sữa tươi')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (4, N'Ăn dặm')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (5, N'Vitamin')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (6, N'Đồ dùng mẹ & bé')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (7, N'Thời trang & phụ kiện')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (8, N'Đồ chơi')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (1, N'Quoc', N'0992348395', N'Hue')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (4, N'Hoang', N'0945766385', N'Hanoi')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (5, N'Hieu', N'0457365748', N'Hue')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (7, N'Huy', N'0458694576', N'Hue')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (8, N'Cuong', N'0945762222', N'Hue')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (9, N'Tam', N'0945766123', N'Hue')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (10007, N'Thang', N'0485736583', N'Hue')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (20007, N'Nga', N'0935548749', N'Hue')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (30007, N'adasd', N'012312', N'qwe')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (30008, N'abc', N'123', N'123')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (30009, N'le van a', N'012312', N'Hue')
INSERT [dbo].[Customer] ([CustomerID], [FullName], [PhoneNumber], [Address]) VALUES (30010, N'Nguyen Van An', N'0123112311', N'Hue')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeID], [FullName], [Position], [UserName], [Password], [PhoneNumber], [Email]) VALUES (1, N'Xuân Quốc', N'Quản lý', N'admin', N'admin', N'123', N'quoc@gmail.com')
INSERT [dbo].[Employee] ([EmployeeID], [FullName], [Position], [UserName], [Password], [PhoneNumber], [Email]) VALUES (2, N'abc', N'Nhân viên', N'nv1', N'123', N'1233', N'nv1@gmail.com')
INSERT [dbo].[Employee] ([EmployeeID], [FullName], [Position], [UserName], [Password], [PhoneNumber], [Email]) VALUES (3, N'bcd', N'Nhân viên', N'nv2', N'123', N'13', N'nv2@gmail.com')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (1, CAST(N'2023-12-16T00:00:00.000' AS DateTime), 1, 2, 1900000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (3, CAST(N'2023-12-14T17:47:16.173' AS DateTime), 1, 1, 2700000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (4, CAST(N'2023-12-11T17:50:25.923' AS DateTime), 1, 1, 1560000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (5, CAST(N'2023-12-10T18:06:38.913' AS DateTime), 1, 2, 5400000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (6, CAST(N'2023-12-16T18:15:42.707' AS DateTime), 1, 1, 6800000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (7, CAST(N'2023-12-17T18:16:35.503' AS DateTime), 1, 1, 4340000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (8, CAST(N'2023-12-17T18:18:16.710' AS DateTime), 1, 1, 5690000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (9, CAST(N'2023-12-17T18:18:23.083' AS DateTime), 1, 1, 6750000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (10, CAST(N'2023-12-18T16:38:19.180' AS DateTime), 1, 1, 1100000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (11, CAST(N'2023-12-18T16:44:21.743' AS DateTime), 1, 1, 4900000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (12, CAST(N'2023-12-19T16:20:51.667' AS DateTime), 7, 1, 1304000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (13, CAST(N'2023-12-19T16:24:23.133' AS DateTime), 7, 1, 1349000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (14, CAST(N'2023-12-19T17:23:04.830' AS DateTime), 1, 1, 2668000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (15, CAST(N'2023-12-19T17:24:13.630' AS DateTime), 7, 1, 475000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (16, CAST(N'2023-12-19T17:27:06.683' AS DateTime), 5, 1, 10109000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (10012, CAST(N'2023-12-19T21:10:27.240' AS DateTime), 1, 1, 1150550)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (10013, CAST(N'2023-12-20T02:55:53.960' AS DateTime), 10007, 1, 3536000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (20013, CAST(N'2023-12-20T15:39:41.503' AS DateTime), 9, 1, 979000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (20014, CAST(N'2023-12-21T00:00:52.097' AS DateTime), 1, 1, 1845000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (20015, CAST(N'2023-12-21T00:02:53.913' AS DateTime), 1, 1, 1845000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (20016, CAST(N'2023-12-21T00:11:58.533' AS DateTime), 1, 1, 1845000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (20017, CAST(N'2023-12-21T13:33:40.517' AS DateTime), 8, 2, 1845000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (20018, CAST(N'2023-12-21T13:40:01.383' AS DateTime), 1, 1, 3690000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (20019, CAST(N'2023-12-21T13:58:34.257' AS DateTime), 1, 1, 369000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (30013, CAST(N'2023-12-21T22:58:39.273' AS DateTime), 20007, 1, 3535200)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (40013, CAST(N'2023-12-27T13:50:39.473' AS DateTime), 5, 1, 2131000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (50013, CAST(N'2023-12-30T17:00:04.640' AS DateTime), 1, 1, 325000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (50014, CAST(N'2024-01-07T20:47:33.223' AS DateTime), 30009, 1, 2149000)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (60014, CAST(N'2024-01-08T07:23:02.600' AS DateTime), 7, 1, 4812550)
INSERT [dbo].[Order] ([OrderID], [OrderDate], [CustomerID], [EmployeeID], [TotalPrice]) VALUES (60015, CAST(N'2024-01-08T09:00:00.223' AS DateTime), 1, 1, 2653000)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderDetail] ON 

INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (1, 1, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (2, 3, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (3, 3, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (4, 3, 3, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (5, 4, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (6, 4, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (7, 4, 3, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (8, 5, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (9, 5, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10, 5, 3, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (11, 6, 1, 9)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (12, 7, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (13, 8, 1, 100)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (14, 9, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (15, 9, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (16, 10, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (17, 11, 26, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (18, 12, 26, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (19, 12, 21, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20, 12, 22, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (21, 12, 17, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (22, 13, 3, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (23, 13, 7, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (24, 13, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (25, 14, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (26, 14, 8, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (27, 14, 9, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (28, 14, 10, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (29, 15, 7, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (30, 16, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (31, 16, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (32, 16, 3, 5)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (33, 16, 8, 10)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (34, 16, 9, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (35, 16, 18, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (36, 16, 22, 10)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10018, 10012, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10019, 10012, 22, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10020, 10012, 25, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10021, 10012, 19, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10022, 10012, 14, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10023, 10013, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10024, 10013, 8, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10025, 10013, 9, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10026, 10013, 3, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10027, 10013, 10, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10028, 10013, 15, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20023, 20013, 21, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20024, 20013, 22, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20025, 20013, 26, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20026, 20015, 1, 5)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20027, 20016, 1, 5)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20028, 20017, 1, 5)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20029, 20018, 1, 10)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20030, 20019, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (30027, 30013, 8, 3)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (30028, 30013, 14, 2)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (30029, 30013, 16, 2)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (30030, 30013, 25, 4)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (30031, 30013, 26, 2)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (40027, 40013, 26, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (40028, 40013, 21, 3)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (50027, 50013, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (50028, 50014, 22, 5)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (50029, 50014, 15, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (50030, 50014, 13, 2)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60028, 60014, 25, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60029, 60014, 22, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60030, 60014, 9, 5)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60031, 60015, 1, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60032, 60015, 2, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60033, 60015, 3, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60034, 60015, 7, 1)
INSERT [dbo].[OrderDetail] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60035, 60015, 9, 1)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (1, N'Vinamilk Optimum Gold 2, 800g (6 - 12 tháng)
', N'Vinamilk Optimum Gold 2, 800g, 6 - 12 tháng tuổi là sữa bột công thức dành riêng cho bé 6 - 12 tháng tuổi.', 369000, 78, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s1.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (2, N'Sữa Dielac Alpha Gold IQ 2, 800g (6-12 tháng)
', N'﻿﻿﻿﻿Dielac Alpha Gold IQ 2 là sữa công thức đặc chế dành cho trẻ từ 6-12 tháng. Được sản xuất theo công nghệ hiện đại và được chứng minh lâm sàng về tính hiệu quả và an toàn, sản phẩm sẽ là sự lựa chọn rất tốt ba mẹ nên dành cho trẻ trong giai đoạn 6-12 tháng. ', 325000, 98, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s2.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (3, N'Sữa Meiji Infant Formula 800g (0-12 tháng)
', N'Sữa Meiji Infant Formula 800g (0-12 tháng) là sữa bột công thức được nhập khẩu chính hãng từ Nhật Bản. Sản phẩm dành cho trẻ sơ sinh từ 0 - 12 tháng tuổi.', 549000, 99, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s3.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (7, N'Sữa Meiji Growing up Formula 800g (12-36 tháng)
', N'Sữa Meiji Growing up Formula 800g (12-36 tháng) thuộc thương hiệu Meiji nổi tiếng hàng đầu Nhật Bản.', 475000, 99, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s4.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (8, N'Sữa Glico Icreo số 1 820g (9-36 tháng)
', N'Sữa Glico Icreo số 1 820g (9-36 tháng) là dòng sữa bột công thức dành cho trẻ từ 9 đến 36 tháng tuổi. Sữa được đóng gói hộp giấy, số lượng 10 thanh/ hộp, mỗi thanh có trọng lượng 13.6g.', 469000, 97, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s5.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (9, N'Sữa Enfagrow A+ số 3 1700g (1-3 tuổi) 2Flex', N'Enfamil A+ số 3 là sữa bột công thức dành riêng cho trẻ từ 1 đến 3 tuổi.', 935000, 94, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s6.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (10, N'Sữa Enfagrow A+ số 4 1700g (2-6 tuổi) 2Flex', N'﻿﻿Sữa Enfamil A+ số 4 dành cho bé từ 2 đến 6 tuổi, với mong muốn đồng hành cùng ba mẹ nuôi dưỡng con thông minh, tình cảm.', 895000, 100, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s7.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (11, N'Sữa Frisolac Gold số 2 850g (6-12 tháng)', N'﻿﻿Sữa Frisolac Gold là sản phẩm dành cho bé từ 6 đến 12 tháng tuổi.', 539000, 100, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s8.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (12, N'Sữa Frisolac Gold số 1 850g (0-6 tháng)
', N'﻿Sữa Frisolac Gold là sản phẩm dành cho bé từ 0 đến 6 tháng tuổi.', 539000, 100, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s9.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (13, N'Sữa Friso Gold số 4 1400g (2-6 tuổi)
', N'Sữa Frisolac Gold 4 là sản phẩm dành cho bé từ 2 đến 6 tuổi, cung cấp các dưỡng chất quan trọng giúp bé khỏe mạnh hơn từ bên trong.', 735000, 98, 1, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\s10.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (14, N'Bỉm tã quần Bobby size XL 62 miếng (12-17kg)', N'Bỉm tã quần Bobby size XL 62 miếng là sản phẩm bỉm tã dành cho bé từ 12-17kg thuộc thương hiệu Bobby đến từ tập đoàn Unicharm Nhật Bản. Sản phẩm là sự lựa chọn tốt nhất mà mẹ dành cho bé yêu trong những tháng năm đầu đời.', 319000, 98, 2, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\b1.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (15, N'Bỉm tã quần Bobby size XXL 56 miếng (trên 16kg)', N'Bỉm tã quần Bobby size XXL 56 miếng là sản phẩm bỉm tã dành cho bé từ 15-25kg thuộc thương hiệu Bobby đến từ tập đoàn Unicharm Nhật Bản. Sản phẩm là sự lựa chọn tốt nhất mà mẹ dành cho bé yêu trong những tháng năm đầu đời.', 319000, 99, 2, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\b2.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (16, N'Bỉm tã quần Bobby size L 68 miếng (9-13kg)', N'Bỉm tã quần Bobby size L 68 miếng là sản phẩm bỉm tã dành cho bé từ 9-13kg thuộc thương hiệu Bobby đến từ tập đoàn Unicharm Nhật Bản. Sản phẩm là sự lựa chọn tốt nhất mà mẹ dành cho bé yêu trong những tháng năm đầu đời.', 319000, 98, 2, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\b3.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (17, N'Tã quần Huggies Skincare gói cực đại (XL, 12-17kg, 60 miếng)
', N'Tã quần Huggies Skincare size XL phù hợp với bé từ 12-17 kg. Sản phẩm bổ sung tinh chất tràm trà tự nhiên, giúp mang đến cảm giác thoải mái, dễ chịu và ngừa hăm tã cho bé. ', 325000, 100, 2, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\b4.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (18, N'Tã quần Huggies Skincare gói cực đại (XXL, >15kg, 54 miếng)
', N'﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿Tã quần Huggies Skincare size XXL phù hợp với bé trên 15 kg. Sản phẩm bổ sung tinh chất tràm trà tự nhiên, giúp mang đến cảm giác thoải mái, dễ chịu và ngừa hăm tã cho bé. ', 325000, 100, 2, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\b5.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (19, N'Tã quần Huggies Skincare gói cực đại (L, 9-14kg, 68 miếng)
', N'Tã quần Huggies Skincare size L phù hợp với bé từ 9-14 kg. Sản phẩm bổ sung tinh chất tràm trà tự nhiên, giúp mang đến cảm giác thoải mái, dễ chịu và ngừa hăm tã cho bé. ', 325000, 100, 2, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\b6.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (20, N'Sữa Abbott Grow Gold hương vani 110ML - Lốc 4 (Từ 1 tuổi)
', N'Sữa nước Abbott Grow Gold Hương Vani 110ml là thức uống dinh dưỡng dành cho bé từ 1 tuổi trở lên. Sản phẩm cung cấp nguồn dinh dưỡng hỗ trợ bé phát triển chiều cao, trí não cũng như tăng cường sức đề kháng. ', 51000, 100, 3, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\st1.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (21, N'Thùng sữa Abbott Grow Gold hương vani 110ml (Lốc 4 hộp)
', N'Combo 12 lốc Abbott Grow Gold hương vani 110ml (Lốc 4 hộp) là thức uống dinh dưỡng dành cho bé từ 1 tuổi trở lên. Sản phẩm cung cấp nguồn dinh dưỡng hỗ trợ bé phát triển chiều cao, trí não cũng như tăng cường sức đề kháng. ', 612000, 97, 3, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\st2.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (22, N'Sữa Abbott Grow Gold hương vani 180ML - Lốc 4 (Từ 1 tuổi)
', N'Sữa nước Abbott Grow Gold Hương Vani 180ml là thức uống dinh dưỡng dành cho bé từ 1 tuổi trở lên. Sản phẩm cung cấp nguồn dinh dưỡng hỗ trợ bé phát triển chiều cao, trí não cũng như tăng cường sức đề kháng. ', 72000, 94, 3, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\st3.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (23, N'Thùng thực phẩm bổ sung Abbott Grow Gold hương vani 180ml (Lốc 4 hộp) - 12 lốc', N'﻿﻿﻿﻿﻿﻿Thực phẩm bổ sung Abbott Grow Gold hương vani 180ml là thức uống dinh dưỡng dành cho bé từ Abbott Hoa Kỳ. Sản phẩm cung cấp nguồn dinh dưỡng hỗ trợ bé phát triển chiều cao, trí não cũng như tăng sức đề kháng.', 864000, 100, 3, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\st4.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (24, N'Thực phẩm bổ sung bánh xốp ăn dặm vị dâu và củ cải đường Happy Baby', N'Sản phẩm này là thức ăn bổ sung và được ăn thêm cùng với sữa mẹ dùng cho trẻ trên 06 tháng tuổi', 129000, 100, 4, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\ad1.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (25, N'﻿﻿Bột ăn dặm Ridielac Gold heo bó xôi HG 200gr', N'﻿﻿Bột ăn dặm Ridielac Gold heo bó xôi HG 200gr ﻿dành cho bé từ 7 đến 24 tháng tuổi, chứa các vitamin và khoáng chất giúp bé ăn toàn khỏe mạnh, cứng cáp và phát triển trí não.', 65550, 95, 4, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\ad2.png')
INSERT [dbo].[Product] ([ProductID], [ProductName], [Description], [Price], [Quantity], [CategoryID], [Image]) VALUES (26, N'Vitamin D3 giúp tăng chiều cao cho bé Lineabon K2+D3
', N'﻿﻿﻿﻿﻿﻿LineaBon K2+D3 là sản phẩm giúp bổ sung Vitamin tăng chiều cao cho bé, giúp xương dài ra nhanh chóng, phát triển chiều cao tối đa. Sản phẩm được làm từ thành phần an toàn, sản xuất trên dây chuyền hiện đại nên đảm bảo không gây bất kì tác dụng phụ nào, phù hợp với cả trẻ sơ sinh. ', 295000, 97, 5, N'E:\.Net\QuanLySieuThi\BMomMarket\Image\vtm1.png')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Employee]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category]
GO
USE [master]
GO
ALTER DATABASE [BMomMarket] SET  READ_WRITE 
GO
