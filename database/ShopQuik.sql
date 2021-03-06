USE [master]
GO
/****** Object:  Database [ShopQuik]    Script Date: 23-04-2020 06:29:00 ******/
CREATE DATABASE [ShopQuik]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopQuik', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.GIRI\MSSQL\DATA\ShopQuik.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShopQuik_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.GIRI\MSSQL\DATA\ShopQuik_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ShopQuik] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopQuik].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopQuik] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopQuik] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopQuik] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopQuik] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopQuik] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopQuik] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShopQuik] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopQuik] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopQuik] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopQuik] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopQuik] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopQuik] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopQuik] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopQuik] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopQuik] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopQuik] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopQuik] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopQuik] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopQuik] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopQuik] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopQuik] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopQuik] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopQuik] SET RECOVERY FULL 
GO
ALTER DATABASE [ShopQuik] SET  MULTI_USER 
GO
ALTER DATABASE [ShopQuik] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopQuik] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopQuik] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopQuik] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ShopQuik] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ShopQuik', N'ON'
GO
ALTER DATABASE [ShopQuik] SET QUERY_STORE = OFF
GO
USE [ShopQuik]
GO
/****** Object:  Table [dbo].[AdminDetails]    Script Date: 23-04-2020 06:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminDetails](
	[AdminID] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_AdminDetails] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartDetails]    Script Date: 23-04-2020 06:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartDetails](
	[MobileNumber] [bigint] NOT NULL,
	[ProductID] [nvarchar](10) NOT NULL,
	[Quantity] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[feedback]    Script Date: 23-04-2020 06:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[feedback](
	[MobileNumber] [bigint] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[feedback] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MainCartDetails]    Script Date: 23-04-2020 06:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MainCartDetails](
	[MobileNumber] [bigint] NOT NULL,
	[CartItems] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 23-04-2020 06:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [nvarchar](10) NOT NULL,
	[ProductID] [nvarchar](10) NOT NULL,
	[MobileNumber] [bigint] NOT NULL,
	[ProductPrice] [real] NOT NULL,
	[Quantity] [int] NOT NULL,
	[TotalAmount] [real] NOT NULL,
	[ProductName] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentDetails]    Script Date: 23-04-2020 06:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentDetails](
	[MobileNumber] [bigint] NOT NULL,
	[PaymentType] [nvarchar](50) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[TotalAmount] [real] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 23-04-2020 06:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[ProductID] [nvarchar](10) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductPrice] [float] NOT NULL,
	[Specifications] [nvarchar](200) NULL,
	[Quantity] [int] NOT NULL,
	[ProductType] [nvarchar](50) NOT NULL,
	[ProductImage] [image] NOT NULL,
 CONSTRAINT [PK_ProductDetails] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserDetails]    Script Date: 23-04-2020 06:29:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserDetails](
	[Name] [nvarchar](50) NOT NULL,
	[MobileNumber] [bigint] NOT NULL,
	[EmailID] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[PINCode] [bigint] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[UserImage] [image] NOT NULL,
 CONSTRAINT [PK_UserDetails1] PRIMARY KEY CLUSTERED 
(
	[MobileNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[AdminDetails]  WITH CHECK ADD  CONSTRAINT [FK_AdminDetails_AdminDetails] FOREIGN KEY([AdminID])
REFERENCES [dbo].[AdminDetails] ([AdminID])
GO
ALTER TABLE [dbo].[AdminDetails] CHECK CONSTRAINT [FK_AdminDetails_AdminDetails]
GO
USE [master]
GO
ALTER DATABASE [ShopQuik] SET  READ_WRITE 
GO
