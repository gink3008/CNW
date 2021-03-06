USE [master]
GO
/****** Object:  Database [CNW]    Script Date: 5/30/2019 12:29:10 AM ******/
CREATE DATABASE [CNW]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CNW', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.GINK\MSSQL\DATA\CNW.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CNW_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.GINK\MSSQL\DATA\CNW_log.ldf' , SIZE = 3904KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CNW] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CNW].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CNW] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CNW] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CNW] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CNW] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CNW] SET ARITHABORT OFF 
GO
ALTER DATABASE [CNW] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CNW] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CNW] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CNW] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CNW] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CNW] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CNW] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CNW] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CNW] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CNW] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CNW] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CNW] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CNW] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CNW] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CNW] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CNW] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CNW] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CNW] SET RECOVERY FULL 
GO
ALTER DATABASE [CNW] SET  MULTI_USER 
GO
ALTER DATABASE [CNW] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CNW] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CNW] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CNW] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CNW] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CNW', N'ON'
GO
USE [CNW]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin](
	[id] [varchar](10) NOT NULL,
	[nameAdmin] [char](10) NULL,
	[positionID] [varchar](50) NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bill](
	[id] [varchar](50) NOT NULL,
	[customerID] [char](20) NULL,
	[paymentMethod] [char](10) NULL,
	[Date] [datetime] NULL,
	[CustomerNameOnline] [nvarchar](50) NULL,
	[CustomerDateOnline] [date] NULL,
	[CustomerGenerOnline] [bit] NULL,
	[CustomerPhoneOnline] [int] NULL,
	[CustomerAddressOnline] [nvarchar](max) NULL,
	[TotalOnBill] [int] NULL,
 CONSTRAINT [PK__Bill__3213E83F7B8DB9F2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Color]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Color](
	[ID] [varchar](10) NOT NULL,
	[Name] [nchar](10) NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[id] [char](20) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DateofBirth] [date] NULL,
	[password] [char](20) NULL,
	[Sex] [bit] NULL,
	[Phone] [int] NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK__Customer__3213E83FA63243D6] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DetailBill]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetailBill](
	[BiLLID] [varchar](50) NOT NULL,
	[ProductID] [varchar](10) NOT NULL,
	[totalPrice] [int] NULL,
	[quality] [int] NULL,
	[size] [char](4) NULL,
	[color] [nchar](10) NULL,
 CONSTRAINT [PK__ChiTietH__39074E961A648461] PRIMARY KEY CLUSTERED 
(
	[BiLLID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Images]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Images](
	[id] [varchar](10) NOT NULL,
	[url] [varchar](200) NULL,
	[ProductID] [varchar](10) NOT NULL,
	[Official] [bit] NULL,
 CONSTRAINT [PK__Images__3213E83F809495F1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Posision]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Posision](
	[id] [varchar](50) NOT NULL,
	[Name] [nchar](10) NULL,
 CONSTRAINT [PK_ChucVU] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[speciesID] [varchar](10) NOT NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductColor]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductColor](
	[ProductID] [varchar](10) NOT NULL,
	[ColorID] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ProductColor] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductDetail]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductDetail](
	[ProductID] [varchar](10) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Overview] [nvarchar](max) NULL,
	[Quality] [int] NULL,
	[Advertise] [bit] NULL,
	[Id] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ProductDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductSize]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductSize](
	[ProductID] [varchar](10) NOT NULL,
	[SizeID] [char](3) NOT NULL,
 CONSTRAINT [PK_ProductSize] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[SizeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Size]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Size](
	[id] [char](3) NOT NULL,
	[characters] [char](4) NULL,
	[speciesID] [varchar](50) NULL,
 CONSTRAINT [PK_Size] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Species]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Species](
	[id] [varchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[categoryID] [varchar](10) NULL,
 CONSTRAINT [PK__Species__3213E83F3DBD80A7] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[speciesSize]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[speciesSize](
	[id] [varchar](50) NOT NULL,
	[name] [nvarchar](30) NULL,
 CONSTRAINT [PK_speciesSize] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserAdmin]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserAdmin](
	[id] [varchar](50) NOT NULL,
	[AdminID] [varchar](10) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserAdmin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Bill] ([id], [customerID], [paymentMethod], [Date], [CustomerNameOnline], [CustomerDateOnline], [CustomerGenerOnline], [CustomerPhoneOnline], [CustomerAddressOnline], [TotalOnBill]) VALUES (N'201952917579                  ', NULL, NULL, CAST(N'2019-05-29 17:57:09.807' AS DateTime), N'[IDEA] New job - Painting', NULL, NULL, 1234009643, N'Ba Dinh, Ha Noi, Viet Nam', NULL)
INSERT [dbo].[Category] ([id], [Name]) VALUES (N'001', N'THỜI TRANG NAM')
INSERT [dbo].[Category] ([id], [Name]) VALUES (N'002', N'THỜI TRANG NỮ')
INSERT [dbo].[Customer] ([id], [Name], [DateofBirth], [password], [Sex], [Phone], [Address]) VALUES (N'admin               ', N'Le Hoang Hiep', CAST(N'1996-08-30' AS Date), N'admin               ', 1, 834009643, N'fasdf')
INSERT [dbo].[Customer] ([id], [Name], [DateofBirth], [password], [Sex], [Phone], [Address]) VALUES (N'admin2              ', N'hiep', NULL, N'admin2              ', 1, NULL, NULL)
INSERT [dbo].[DetailBill] ([BiLLID], [ProductID], [totalPrice], [quality], [size], [color]) VALUES (N'201952917579                  ', N'001       ', NULL, 1, NULL, NULL)
INSERT [dbo].[Images] ([id], [url], [ProductID], [Official]) VALUES (N'001', N'product/1.jpg', N'001', 1)
INSERT [dbo].[Images] ([id], [url], [ProductID], [Official]) VALUES (N'002', N'product/2.jpg', N'002', 1)
INSERT [dbo].[Images] ([id], [url], [ProductID], [Official]) VALUES (N'003', N'product/2.jpg', N'001', 0)
INSERT [dbo].[Images] ([id], [url], [ProductID], [Official]) VALUES (N'004', N'product/2.jpg', N'003', 1)
INSERT [dbo].[Product] ([id], [Name], [speciesID], [Price]) VALUES (N'001', N'VAY LUA NU', N'N005', 1500000)
INSERT [dbo].[Product] ([id], [Name], [speciesID], [Price]) VALUES (N'002', N'VAY CHAN NGAN', N'N005', 1200000)
INSERT [dbo].[Product] ([id], [Name], [speciesID], [Price]) VALUES (N'003', N'aaaa', N'N005', 1111000)
INSERT [dbo].[Product] ([id], [Name], [speciesID], [Price]) VALUES (N'123', N'ádf', N'N002', 235)
INSERT [dbo].[ProductDetail] ([ProductID], [Description], [Overview], [Quality], [Advertise], [Id]) VALUES (N'001', N'fasdf', N'fasdf', 14, 1, N'001')
INSERT [dbo].[ProductDetail] ([ProductID], [Description], [Overview], [Quality], [Advertise], [Id]) VALUES (N'002', N'fasdf', N'fasdf', 13, 1, N'002')
INSERT [dbo].[ProductDetail] ([ProductID], [Description], [Overview], [Quality], [Advertise], [Id]) VALUES (N'003', N'fas', N'fasd', 2, NULL, N'003')
INSERT [dbo].[Species] ([id], [Name], [categoryID]) VALUES (N'N001', N'ĐỒNG HỒ NAM', N'001')
INSERT [dbo].[Species] ([id], [Name], [categoryID]) VALUES (N'N002', N'JEAN NAM', N'001')
INSERT [dbo].[Species] ([id], [Name], [categoryID]) VALUES (N'N003', N'SOMI NAM', N'001')
INSERT [dbo].[Species] ([id], [Name], [categoryID]) VALUES (N'N004', N'AO THUN NAM', N'001')
INSERT [dbo].[Species] ([id], [Name], [categoryID]) VALUES (N'N005', N'VAY ', N'002')
INSERT [dbo].[Species] ([id], [Name], [categoryID]) VALUES (N'N006', N'JEAN NU', N'002')
INSERT [dbo].[Species] ([id], [Name], [categoryID]) VALUES (N'N007', N'LAC TAY', N'002')
INSERT [dbo].[Species] ([id], [Name], [categoryID]) VALUES (N'N008', N'TUI XACH', N'002')
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Posision] FOREIGN KEY([positionID])
REFERENCES [dbo].[Posision] ([id])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Posision]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Customer] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customer] ([id])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Customer]
GO
ALTER TABLE [dbo].[DetailBill]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHD_HoaDon] FOREIGN KEY([BiLLID])
REFERENCES [dbo].[Bill] ([id])
GO
ALTER TABLE [dbo].[DetailBill] CHECK CONSTRAINT [FK_ChiTietHD_HoaDon]
GO
ALTER TABLE [dbo].[DetailBill]  WITH CHECK ADD  CONSTRAINT [FK_DetailBill_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[DetailBill] CHECK CONSTRAINT [FK_DetailBill_Product]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_ProductDetail] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductDetail] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_ProductDetail]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Species] FOREIGN KEY([speciesID])
REFERENCES [dbo].[Species] ([id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Species]
GO
ALTER TABLE [dbo].[ProductColor]  WITH CHECK ADD  CONSTRAINT [FK_ProductColor_Color] FOREIGN KEY([ColorID])
REFERENCES [dbo].[Color] ([ID])
GO
ALTER TABLE [dbo].[ProductColor] CHECK CONSTRAINT [FK_ProductColor_Color]
GO
ALTER TABLE [dbo].[ProductColor]  WITH CHECK ADD  CONSTRAINT [FK_ProductColor_ProductDetail1] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductDetail] ([Id])
GO
ALTER TABLE [dbo].[ProductColor] CHECK CONSTRAINT [FK_ProductColor_ProductDetail1]
GO
ALTER TABLE [dbo].[ProductDetail]  WITH CHECK ADD  CONSTRAINT [FK_ProductDetail_Product1] FOREIGN KEY([Id])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[ProductDetail] CHECK CONSTRAINT [FK_ProductDetail_Product1]
GO
ALTER TABLE [dbo].[ProductSize]  WITH CHECK ADD  CONSTRAINT [FK_ProductSize_ProductDetail] FOREIGN KEY([ProductID])
REFERENCES [dbo].[ProductDetail] ([Id])
GO
ALTER TABLE [dbo].[ProductSize] CHECK CONSTRAINT [FK_ProductSize_ProductDetail]
GO
ALTER TABLE [dbo].[ProductSize]  WITH CHECK ADD  CONSTRAINT [FK_ProductSize_Size] FOREIGN KEY([SizeID])
REFERENCES [dbo].[Size] ([id])
GO
ALTER TABLE [dbo].[ProductSize] CHECK CONSTRAINT [FK_ProductSize_Size]
GO
ALTER TABLE [dbo].[Size]  WITH CHECK ADD  CONSTRAINT [FK_Size_speciesSize] FOREIGN KEY([speciesID])
REFERENCES [dbo].[speciesSize] ([id])
GO
ALTER TABLE [dbo].[Size] CHECK CONSTRAINT [FK_Size_speciesSize]
GO
ALTER TABLE [dbo].[Species]  WITH CHECK ADD  CONSTRAINT [FK_Loaisp_Category] FOREIGN KEY([categoryID])
REFERENCES [dbo].[Category] ([id])
GO
ALTER TABLE [dbo].[Species] CHECK CONSTRAINT [FK_Loaisp_Category]
GO
ALTER TABLE [dbo].[UserAdmin]  WITH CHECK ADD  CONSTRAINT [FK_UserAdmin_Admin] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Admin] ([id])
GO
ALTER TABLE [dbo].[UserAdmin] CHECK CONSTRAINT [FK_UserAdmin_Admin]
GO
/****** Object:  StoredProcedure [dbo].[users_login]    Script Date: 5/30/2019 12:29:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[users_login](
							@username varchar(50),
                            @password varchar(50)
							)
  as
  begin
	declare @count int
	declare @ret int
	select @count = count(*) from Customer where id = @username and [password] = @password
	if 0< @count and @count <= 1
		set @ret = 1
	if @count > 1 
		set @ret = 2
	if @count <= 0
		set @ret = 0
	select @ret
  end

GO
USE [master]
GO
ALTER DATABASE [CNW] SET  READ_WRITE 
GO
