USE [master]
GO
/****** Object:  Database [BillingSystem]    Script Date: 1/25/2019 9:49:45 PM ******/
CREATE DATABASE [BillingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BillingSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BillingSystem.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BillingSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\BillingSystem_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BillingSystem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BillingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BillingSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BillingSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BillingSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BillingSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BillingSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [BillingSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BillingSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BillingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BillingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BillingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BillingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BillingSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BillingSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BillingSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BillingSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BillingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BillingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BillingSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BillingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BillingSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BillingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BillingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BillingSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BillingSystem] SET  MULTI_USER 
GO
ALTER DATABASE [BillingSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BillingSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BillingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BillingSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [BillingSystem]
GO
/****** Object:  Table [dbo].[tbl_Bills]    Script Date: 1/25/2019 9:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Bills](
	[invoice] [int] NOT NULL,
	[date] [date] NULL,
	[customerName] [varchar](50) NOT NULL,
	[customerAddress] [text] NULL,
	[brokerName] [varchar](50) NULL,
	[truckNumber] [int] NULL,
	[driverName] [varchar](50) NULL,
	[licenseNumber] [varchar](50) NULL,
	[driverNumber] [int] NULL,
	[transport] [text] NULL,
	[insurance] [text] NULL,
	[policyNumber] [text] NULL,
	[insuranceValue] [decimal](18, 2) NULL,
	[totalQtl] [decimal](18, 2) NULL,
	[totalPkg] [decimal](18, 2) NULL,
	[totalWeight] [decimal](18, 2) NULL,
	[totalAmount] [decimal](18, 2) NULL,
	[RsWords] [text] NULL,
	[freightRate] [decimal](18, 2) NULL,
	[freightAmount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tbl_Bills] PRIMARY KEY CLUSTERED 
(
	[invoice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_orders]    Script Date: 1/25/2019 9:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_orders](
	[bill_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[serialNumber] [int] NULL,
	[goodsDescription] [text] NULL,
	[Qtl] [decimal](18, 2) NULL,
	[Pkg] [decimal](18, 2) NULL,
	[weight] [decimal](18, 2) NULL,
	[ratePerQtl] [decimal](18, 2) NULL,
	[amount] [decimal](18, 2) NULL,
 CONSTRAINT [PK_tbl_orders] PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Products]    Script Date: 1/25/2019 9:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [text] NOT NULL,
 CONSTRAINT [PK_tbl_Products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[InsertNewBill]    Script Date: 1/25/2019 9:49:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertNewBill]
	-- Add the parameters for the stored procedure here
	@invoice int,
	@date date,
	@customerName varchar(50),
	@customerAddress text,
	@brokerName varchar(50),
	@truckNumber int,
	@driverName varchar(50),
	@licenseNumber varchar(50),
	@driverNumber int, 
	@transport text,
	@insurance text,
	@policyNumber text,
	@insuranceValue decimal(18, 2),
	@totalQtl decimal(18, 2),
	@totalPkg decimal(18, 2),
	@totalWeight decimal(18, 2),
	@totalAmount decimal(18, 2),
	@RsWords text,
	@freightRate decimal(18, 2),
	@freightAmount decimal(18, 2)
AS
BEGIN
INSERT INTO tbl_Bills(invoice, date, customerName, customerAddress, brokerName, truckNumber, driverName, licenseNumber, driverNumber, transport, insurance, 
			policyNumber, insuranceValue, totalQtl, totalPkg, totalWeight, totalAmount, RsWords, freightRate, freightAmount)

Values (@invoice, @date, @customerName, @customerAddress, @brokerName, @truckNumber, @driverName, @licenseNumber, @driverNumber, @transport, @insurance, 
		@policyNumber, @insuranceValue, @totalQtl, @totalPkg, @totalWeight, @totalAmount, @RsWords, @freightRate, @freightAmount)
END

GO
USE [master]
GO
ALTER DATABASE [BillingSystem] SET  READ_WRITE 
GO
