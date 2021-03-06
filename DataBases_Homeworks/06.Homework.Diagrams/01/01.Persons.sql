USE [master]
GO
/****** Object:  Database [Persons]    Script Date: 10/2/2015 8:39:56 PM ******/
CREATE DATABASE [Persons]
GO
ALTER DATABASE [Persons] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Persons].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Persons] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Persons] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Persons] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Persons] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Persons] SET ARITHABORT OFF 
GO
ALTER DATABASE [Persons] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Persons] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Persons] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Persons] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Persons] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Persons] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Persons] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Persons] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Persons] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Persons] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Persons] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Persons] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Persons] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Persons] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Persons] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Persons] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Persons] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Persons] SET RECOVERY FULL 
GO
ALTER DATABASE [Persons] SET  MULTI_USER 
GO
ALTER DATABASE [Persons] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Persons] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Persons] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Persons] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Persons', N'ON'
GO
USE [Persons]
GO
/****** Object:  Table [dbo].[ADDRESS]    Script Date: 10/2/2015 8:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADDRESS](
	[id] [int] NOT NULL,
	[adress_text] [nvarchar](500) NOT NULL,
	[town_id] [int] NOT NULL,
 CONSTRAINT [PK_ADDRESS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CONTINENT]    Script Date: 10/2/2015 8:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONTINENT](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CONTINENT] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COUNTRY]    Script Date: 10/2/2015 8:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COUNTRY](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[continent_id] [int] NOT NULL,
 CONSTRAINT [PK_COUNTRY] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PERSON]    Script Date: 10/2/2015 8:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSON](
	[id] [int] NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[adress_id] [int] NOT NULL,
 CONSTRAINT [PK_PERSON] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TOWN]    Script Date: 10/2/2015 8:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOWN](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [PK_TOWN] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ADDRESS] ([id], [adress_text], [town_id]) VALUES (1, N'ulica sezam', 1)
INSERT [dbo].[ADDRESS] ([id], [adress_text], [town_id]) VALUES (2, N'ulica 2', 2)
INSERT [dbo].[CONTINENT] ([id], [name]) VALUES (1, N'Europe')
INSERT [dbo].[CONTINENT] ([id], [name]) VALUES (2, N'Africa')
INSERT [dbo].[CONTINENT] ([id], [name]) VALUES (3, N'Asia')
INSERT [dbo].[COUNTRY] ([id], [name], [continent_id]) VALUES (1, N'Bulgaria', 1)
INSERT [dbo].[COUNTRY] ([id], [name], [continent_id]) VALUES (2, N'Germany', 1)
INSERT [dbo].[COUNTRY] ([id], [name], [continent_id]) VALUES (3, N'Egypt', 2)
INSERT [dbo].[PERSON] ([id], [first_name], [last_name], [adress_id]) VALUES (1, N'Pesho', N'Ushoto', 1)
INSERT [dbo].[PERSON] ([id], [first_name], [last_name], [adress_id]) VALUES (2, N'Gosho', N'Nosa', 2)
INSERT [dbo].[TOWN] ([id], [name], [country_id]) VALUES (1, N'Sofia', 1)
INSERT [dbo].[TOWN] ([id], [name], [country_id]) VALUES (2, N'Varna', 1)
INSERT [dbo].[TOWN] ([id], [name], [country_id]) VALUES (3, N'Berlin', 2)
ALTER TABLE [dbo].[ADDRESS]  WITH CHECK ADD  CONSTRAINT [FK_ADDRESS_TOWN1] FOREIGN KEY([town_id])
REFERENCES [dbo].[TOWN] ([id])
GO
ALTER TABLE [dbo].[ADDRESS] CHECK CONSTRAINT [FK_ADDRESS_TOWN1]
GO
ALTER TABLE [dbo].[COUNTRY]  WITH CHECK ADD  CONSTRAINT [FK_COUNTRY_CONTINENT1] FOREIGN KEY([continent_id])
REFERENCES [dbo].[CONTINENT] ([id])
GO
ALTER TABLE [dbo].[COUNTRY] CHECK CONSTRAINT [FK_COUNTRY_CONTINENT1]
GO
ALTER TABLE [dbo].[PERSON]  WITH CHECK ADD  CONSTRAINT [FK_PERSON_ADDRESS] FOREIGN KEY([adress_id])
REFERENCES [dbo].[ADDRESS] ([id])
GO
ALTER TABLE [dbo].[PERSON] CHECK CONSTRAINT [FK_PERSON_ADDRESS]
GO
ALTER TABLE [dbo].[TOWN]  WITH CHECK ADD  CONSTRAINT [FK_TOWN_COUNTRY1] FOREIGN KEY([country_id])
REFERENCES [dbo].[COUNTRY] ([id])
GO
ALTER TABLE [dbo].[TOWN] CHECK CONSTRAINT [FK_TOWN_COUNTRY1]
GO
USE [master]
GO
ALTER DATABASE [Persons] SET  READ_WRITE 
GO
