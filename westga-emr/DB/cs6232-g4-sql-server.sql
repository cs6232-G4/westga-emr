USE [master]
GO
/****** Object:  Database [cs6232-g4]    Script Date: 3/9/2021 4:26:35 PM ******/
CREATE DATABASE [cs6232-g4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cs6232-g4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cs6232-g4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-g4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g4] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cs6232-g4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g4] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g4] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g4', N'ON'
GO
ALTER DATABASE [cs6232-g4] SET QUERY_STORE = OFF
GO
USE [cs6232-g4]
GO
/****** Object:  Table [dbo].[Address]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[street] [varchar](45) NOT NULL,
	[city] [varchar](45) NOT NULL,
	[state] [char](2) NOT NULL,
	[zip] [char](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[appointmentDateTime] [datetime2](0) NOT NULL,
	[reasonForVisit] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clinical_Administrator]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinical_Administrator](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor_has_Specialties]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_has_Specialties](
	[doctorID] [int] NOT NULL,
	[specialtyName] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC,
	[specialtyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_Order]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_Order](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[visitID] [bigint] NOT NULL,
	[dateOrdered] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_Orders_have_Lab_Tests]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_Orders_have_Lab_Tests](
	[labOrderID] [bigint] NOT NULL,
	[labTestCode] [int] NOT NULL,
	[testPerformed] [date] NOT NULL,
	[results] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[labOrderID] ASC,
	[labTestCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_Test]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_Test](
	[code] [int] NOT NULL,
	[name] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](45) NULL,
	[password] [varchar](45) NULL,
	[firstName] [varchar](45) NOT NULL,
	[lastName] [varchar](45) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[ssn] [char](9) NULL,
	[gender] [char](1) NOT NULL,
	[addressID] [int] NOT NULL,
	[contactPhone] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialty]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialty](
	[name] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit]    Script Date: 3/9/2021 4:26:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[appointmentID] [bigint] NOT NULL,
	[nurseID] [int] NOT NULL,
	[visitDateTime] [datetime2](0) NOT NULL,
	[initialDiagnosis] [varchar](64) NOT NULL,
	[weight] [decimal](5, 2) NOT NULL,
	[systolicPressure] [int] NOT NULL,
	[diastolicPressure] [int] NOT NULL,
	[bodyTemperature] [decimal](4, 1) NOT NULL,
	[pulse] [int] NOT NULL,
	[symptoms] [varchar](255) NULL,
	[finalDiagnosis] [varchar](64) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Address] ON 

INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (1, N'1601 Maple Street', N'Carrolton', N'GA', N'30118')
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (2, N'1332 Southern Drive', N'Statesboro', N'GA', N'30458')
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (3, N'211 Johnny Mercer Blvd', N'Savannah', N'GA', N'31410')
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (4, N'334 East Bay Street #201', N'Charleston', N'SC', N'29401')
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (5, N'1003 Merry St', N'Augusta', N'GA', N'30904')
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (6, N'900 Front Ave', N'Columbus', N'GA', N'31901')
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (7, N'749 Collins Road', N'Lyons', N'GA', N'30436')
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (10, N'14 SUR 127', N'TAMAULIPAS', N'CV', N'87000')
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
SET IDENTITY_INSERT [dbo].[Appointment] ON 

INSERT [dbo].[Appointment] ([id], [patientID], [doctorID], [appointmentDateTime], [reasonForVisit]) VALUES (1, 3, 1, CAST(N'2018-01-01T00:00:00.0000000' AS DateTime2), N'Brain Tumor')
INSERT [dbo].[Appointment] ([id], [patientID], [doctorID], [appointmentDateTime], [reasonForVisit]) VALUES (4, 2, 1, CAST(N'2020-07-22T00:00:00.0000000' AS DateTime2), N'Brain Tumor')
INSERT [dbo].[Appointment] ([id], [patientID], [doctorID], [appointmentDateTime], [reasonForVisit]) VALUES (5, 1, 1, CAST(N'2021-01-11T00:00:00.0000000' AS DateTime2), N'Brain Tumor')
SET IDENTITY_INSERT [dbo].[Appointment] OFF
GO
SET IDENTITY_INSERT [dbo].[Clinical_Administrator] ON 

INSERT [dbo].[Clinical_Administrator] ([id], [personID], [active]) VALUES (1, 2, 1)
SET IDENTITY_INSERT [dbo].[Clinical_Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (1, 4, 1)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
INSERT [dbo].[Doctor_has_Specialties] ([doctorID], [specialtyName]) VALUES (1, N'Neurology')
GO
SET IDENTITY_INSERT [dbo].[Lab_Order] ON 

INSERT [dbo].[Lab_Order] ([id], [visitID], [dateOrdered]) VALUES (1, 1, CAST(N'2018-06-01' AS Date))
INSERT [dbo].[Lab_Order] ([id], [visitID], [dateOrdered]) VALUES (2, 2, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Lab_Order] ([id], [visitID], [dateOrdered]) VALUES (3, 3, CAST(N'2021-01-11' AS Date))
SET IDENTITY_INSERT [dbo].[Lab_Order] OFF
GO
INSERT [dbo].[Lab_Orders_have_Lab_Tests] ([labOrderID], [labTestCode], [testPerformed], [results]) VALUES (1, 1, CAST(N'2018-06-08' AS Date), N'normal')
INSERT [dbo].[Lab_Orders_have_Lab_Tests] ([labOrderID], [labTestCode], [testPerformed], [results]) VALUES (2, 1, CAST(N'2020-07-22' AS Date), N'abnormal')
GO
INSERT [dbo].[Lab_Test] ([code], [name]) VALUES (1, N'CT Scan')
GO
SET IDENTITY_INSERT [dbo].[Nurse] ON 

INSERT [dbo].[Nurse] ([id], [personID], [active]) VALUES (1, 3, 1)
SET IDENTITY_INSERT [dbo].[Nurse] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (1, 7, 1)
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (2, 8, 1)
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (3, 2, 0)
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (2, N'gregosaurus_rex', N'fake_password', N'Greg', N'Murrell', CAST(N'1989-06-08' AS Date), NULL, N'm', 10, N'9126608312')
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (3, N'blondie', N'passw0rd', N'Betsy', N'White', CAST(N'1993-05-08' AS Date), NULL, N'f', 7, N'9123808000')
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (4, NULL, NULL, N'Adrian', N'Metzger', CAST(N'1965-01-08' AS Date), NULL, N'm', 1, N'0301115156')
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (7, NULL, NULL, N'Oliva', N'Velásquez', CAST(N'2002-08-16' AS Date), NULL, N'm', 4, N'0903041177')
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (8, NULL, NULL, N'Carlota', N'Martín', CAST(N'1948-11-16' AS Date), NULL, N'm', 10, N'4528662819')
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
INSERT [dbo].[Specialty] ([name]) VALUES (N'Neurology')
GO
SET IDENTITY_INSERT [dbo].[Visit] ON 

INSERT [dbo].[Visit] ([id], [appointmentID], [nurseID], [visitDateTime], [initialDiagnosis], [weight], [systolicPressure], [diastolicPressure], [bodyTemperature], [pulse], [symptoms], [finalDiagnosis]) VALUES (1, 1, 1, CAST(N'2018-06-01T00:00:00.0000000' AS DateTime2), N'Brain Tumor', CAST(150.00 AS Decimal(5, 2)), 110, 70, CAST(98.6 AS Decimal(4, 1)), 70, N'being too loopy when making a database', N'Silliness')
INSERT [dbo].[Visit] ([id], [appointmentID], [nurseID], [visitDateTime], [initialDiagnosis], [weight], [systolicPressure], [diastolicPressure], [bodyTemperature], [pulse], [symptoms], [finalDiagnosis]) VALUES (2, 4, 1, CAST(N'2020-07-22T00:00:00.0000000' AS DateTime2), N'Brain Tumor', CAST(250.00 AS Decimal(5, 2)), 140, 90, CAST(98.6 AS Decimal(4, 1)), 80, N'giant bulge sticking out of their head', N'Alien Parasite')
INSERT [dbo].[Visit] ([id], [appointmentID], [nurseID], [visitDateTime], [initialDiagnosis], [weight], [systolicPressure], [diastolicPressure], [bodyTemperature], [pulse], [symptoms], [finalDiagnosis]) VALUES (3, 5, 1, CAST(N'2021-01-11T00:00:00.0000000' AS DateTime2), N'Brain Tumor', CAST(155.00 AS Decimal(5, 2)), 110, 70, CAST(98.6 AS Decimal(4, 1)), 60, N'Amnesia', NULL)
SET IDENTITY_INSERT [dbo].[Visit] OFF
GO
/****** Object:  Index [fk_Patient_has_Doctor_Doctor1_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [fk_Patient_has_Doctor_Doctor1_idx] ON [dbo].[Appointment]
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Patient_has_Doctor_Patient1_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [fk_Patient_has_Doctor_Patient1_idx] ON [dbo].[Appointment]
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Clinical_Administrator]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Doctor]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Doctor_has_Specialties_Doctor1_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [fk_Doctor_has_Specialties_Doctor1_idx] ON [dbo].[Doctor_has_Specialties]
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [fk_Doctor_has_Specialties_Specialties1_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [fk_Doctor_has_Specialties_Specialties1_idx] ON [dbo].[Doctor_has_Specialties]
(
	[specialtyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [visitID_fk_Visit_id_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [visitID_fk_Visit_id_idx] ON [dbo].[Lab_Order]
(
	[visitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1_idx] ON [dbo].[Lab_Orders_have_Lab_Tests]
(
	[labTestCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Vis_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Vis_idx] ON [dbo].[Lab_Orders_have_Lab_Tests]
(
	[labOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Nurse]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Patient]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_addressID_address_id_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [fk_addressID_address_id_idx] ON [dbo].[Person]
(
	[addressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [username_UNIQUE]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [username_UNIQUE] ON [dbo].[Person]
(
	[username] ASC
)
WHERE ([username] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [appointmentID_fk_Appointment_id_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [appointmentID_fk_Appointment_id_idx] ON [dbo].[Visit]
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [nurseID_fk_Nurse_id_idx]    Script Date: 3/9/2021 4:26:36 PM ******/
CREATE NONCLUSTERED INDEX [nurseID_fk_Nurse_id_idx] ON [dbo].[Visit]
(
	[nurseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [fk_Patient_has_Doctor_Doctor1] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [fk_Patient_has_Doctor_Doctor1]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [fk_Patient_has_Doctor_Patient1] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [fk_Patient_has_Doctor_Patient1]
GO
ALTER TABLE [dbo].[Clinical_Administrator]  WITH CHECK ADD  CONSTRAINT [Admin_personID_fk_Person_id] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[Clinical_Administrator] CHECK CONSTRAINT [Admin_personID_fk_Person_id]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [personID_fk_Person_id] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [personID_fk_Person_id]
GO
ALTER TABLE [dbo].[Doctor_has_Specialties]  WITH CHECK ADD  CONSTRAINT [fk_Doctor_has_Specialties_Doctor1] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[Doctor_has_Specialties] CHECK CONSTRAINT [fk_Doctor_has_Specialties_Doctor1]
GO
ALTER TABLE [dbo].[Doctor_has_Specialties]  WITH CHECK ADD  CONSTRAINT [fk_Doctor_has_Specialties_Specialties1] FOREIGN KEY([specialtyName])
REFERENCES [dbo].[Specialty] ([name])
GO
ALTER TABLE [dbo].[Doctor_has_Specialties] CHECK CONSTRAINT [fk_Doctor_has_Specialties_Specialties1]
GO
ALTER TABLE [dbo].[Lab_Order]  WITH CHECK ADD  CONSTRAINT [visitID_fk_Visit_id] FOREIGN KEY([visitID])
REFERENCES [dbo].[Visit] ([id])
GO
ALTER TABLE [dbo].[Lab_Order] CHECK CONSTRAINT [visitID_fk_Visit_id]
GO
ALTER TABLE [dbo].[Lab_Orders_have_Lab_Tests]  WITH CHECK ADD  CONSTRAINT [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1] FOREIGN KEY([labTestCode])
REFERENCES [dbo].[Lab_Test] ([code])
GO
ALTER TABLE [dbo].[Lab_Orders_have_Lab_Tests] CHECK CONSTRAINT [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1]
GO
ALTER TABLE [dbo].[Lab_Orders_have_Lab_Tests]  WITH CHECK ADD  CONSTRAINT [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Visit1] FOREIGN KEY([labOrderID])
REFERENCES [dbo].[Lab_Order] ([id])
GO
ALTER TABLE [dbo].[Lab_Orders_have_Lab_Tests] CHECK CONSTRAINT [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Visit1]
GO
ALTER TABLE [dbo].[Nurse]  WITH CHECK ADD  CONSTRAINT [Nurse_personID_fk_Person_id] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[Nurse] CHECK CONSTRAINT [Nurse_personID_fk_Person_id]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [fk_personID_Person_id] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([id])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [fk_personID_Person_id]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [fk_addressID_address_id] FOREIGN KEY([addressID])
REFERENCES [dbo].[Address] ([id])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [fk_addressID_address_id]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [appointmentID_fk_Appointment_id] FOREIGN KEY([appointmentID])
REFERENCES [dbo].[Appointment] ([id])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [appointmentID_fk_Appointment_id]
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD  CONSTRAINT [nurseID_fk_Nurse_id] FOREIGN KEY([nurseID])
REFERENCES [dbo].[Nurse] ([id])
GO
ALTER TABLE [dbo].[Visit] CHECK CONSTRAINT [nurseID_fk_Nurse_id]
GO
USE [master]
GO
ALTER DATABASE [cs6232-g4] SET  READ_WRITE 
GO
