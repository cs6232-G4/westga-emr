USE [master]
GO
/****** Object:  Database [cs6232-g4]    Script Date: 5/3/2021 9:48:16 PM ******/
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
/****** Object:  Table [dbo].[Address]    Script Date: 5/3/2021 9:48:17 PM ******/
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
/****** Object:  Table [dbo].[Appointment]    Script Date: 5/3/2021 9:48:17 PM ******/
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
/****** Object:  Table [dbo].[Clinical_Administrator]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinical_Administrator](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK__Clinical__3213E83F2974AFAB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK__Doctor__3213E83FABFF98E4] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor_has_Specialties]    Script Date: 5/3/2021 9:48:17 PM ******/
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
/****** Object:  Table [dbo].[Lab_Order]    Script Date: 5/3/2021 9:48:17 PM ******/
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
/****** Object:  Table [dbo].[Lab_Orders_have_Lab_Tests]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_Orders_have_Lab_Tests](
	[labOrderID] [bigint] NOT NULL,
	[labTestCode] [int] NOT NULL,
	[testPerformed] [date] NULL,
	[results] [varchar](255) NULL,
	[isNormal] [bit] NULL,
 CONSTRAINT [PK__Lab_Orde__EAA6BD2283F3A9C3] PRIMARY KEY CLUSTERED 
(
	[labOrderID] ASC,
	[labTestCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_Test]    Script Date: 5/3/2021 9:48:17 PM ******/
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
/****** Object:  Table [dbo].[Nurse]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK__Nurse__3213E83FDF2A8609] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[personID] [int] NOT NULL,
	[active] [bit] NOT NULL,
 CONSTRAINT [PK__Patient__3213E83FC85E1507] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](45) NULL,
	[password] [varchar](128) NULL,
	[firstName] [varchar](45) NOT NULL,
	[lastName] [varchar](45) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[ssn] [char](9) NULL,
	[gender] [char](1) NOT NULL,
	[addressID] [int] NOT NULL,
	[contactPhone] [char](10) NOT NULL,
 CONSTRAINT [PK__Person__3213E83F8B87F739] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specialty]    Script Date: 5/3/2021 9:48:17 PM ******/
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
/****** Object:  Table [dbo].[Visit]    Script Date: 5/3/2021 9:48:17 PM ******/
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
/****** Object:  Index [fk_Patient_has_Doctor_Doctor1_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_Patient_has_Doctor_Doctor1_idx] ON [dbo].[Appointment]
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Patient_has_Doctor_Patient1_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_Patient_has_Doctor_Patient1_idx] ON [dbo].[Appointment]
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Clinical_Administrator]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Doctor]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Doctor_has_Specialties_Doctor1_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_Doctor_has_Specialties_Doctor1_idx] ON [dbo].[Doctor_has_Specialties]
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [fk_Doctor_has_Specialties_Specialties1_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_Doctor_has_Specialties_Specialties1_idx] ON [dbo].[Doctor_has_Specialties]
(
	[specialtyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [visitID_fk_Visit_id_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [visitID_fk_Visit_id_idx] ON [dbo].[Lab_Order]
(
	[visitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1_idx] ON [dbo].[Lab_Orders_have_Lab_Tests]
(
	[labTestCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Vis_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Vis_idx] ON [dbo].[Lab_Orders_have_Lab_Tests]
(
	[labOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Nurse]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Patient]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_addressID_address_id_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [fk_addressID_address_id_idx] ON [dbo].[Person]
(
	[addressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [username_UNIQUE]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [username_UNIQUE] ON [dbo].[Person]
(
	[username] ASC
)
WHERE ([username] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [appointmentID_fk_Appointment_id_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE NONCLUSTERED INDEX [appointmentID_fk_Appointment_id_idx] ON [dbo].[Visit]
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [appointmentID_unique]    Script Date: 5/3/2021 9:48:17 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [appointmentID_unique] ON [dbo].[Visit]
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [nurseID_fk_Nurse_id_idx]    Script Date: 5/3/2021 9:48:17 PM ******/
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
/****** Object:  StoredProcedure [dbo].[getMostPerformedTestsDuringDates]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getMostPerformedTestsDuringDates] 
	@startDate DATE, 
	@endDate DATE
AS
BEGIN
	DECLARE @totalTests FLOAT;
    
    ------------	Error Check Parameters		------------
    IF (@startDate IS NULL) OR (@endDate IS NULL)
	BEGIN
		RAISERROR('startDate and endDate cannot be null', 16, 0);
		RETURN;
	END;
    
	IF (@startDate > @endDate)
	BEGIN
		RAISERROR('endDate cannot be less than startDate', 16, 0);
		RETURN;
    END;

    ------------	Create Temporary Tables to Avoid Subqueries		------------
    
	--	Total number of tests in this procedure's date range
	SET @totalTests = (
		SELECT COUNT(*)
		FROM Lab_Orders_have_Lab_Tests
		WHERE testPerformed BETWEEN @startDate AND @endDate
	)

	--	Total number of any given test in this procedure's date range
	DROP TABLE IF EXISTS #totalResultsForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #totalResultsForProcedureGetMostPerformedTestsDuringDates
    SELECT labTestCode, COUNT(*) AS numberOfTests, (COUNT(*)/@totalTests) * 100 AS percentageOfTotal
	INTO #totalResultsForProcedureGetMostPerformedTestsDuringDates
    FROM Lab_Orders_have_Lab_Tests AS labOrders
    WHERE testPerformed BETWEEN @startDate AND @endDate
    GROUP BY labTestCode;
    ALTER TABLE #totalResultsForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_temp_totalResults_getMostPerformedTestsDuringDates PRIMARY KEY (labTestCode);
    
	--	Number of "normal" results for any given test in this procedure's date range
	DROP TABLE IF EXISTS #normalResultsForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #normalResultsForProcedureGetMostPerformedTestsDuringDates
    SELECT labTestCode, COUNT(*) AS numberOfNormalResults
	INTO #normalResultsForProcedureGetMostPerformedTestsDuringDates
    FROM Lab_Orders_have_Lab_Tests AS labOrders
    WHERE (isNormal IS NOT NULL AND isNormal = 1) AND testPerformed BETWEEN @startDate AND @endDate
    GROUP BY labTestCode;
    ALTER TABLE #normalResultsForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_temp_normalResults_getMostPerformedTestsDuringDates PRIMARY KEY (labTestCode);

		--	Number of "normal" results for any given test in this procedure's date range
	DROP TABLE IF EXISTS #abnormalResultsForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #abnormalResultsForProcedureGetMostPerformedTestsDuringDates
    SELECT labTestCode, COUNT(*) AS numberOfAbnormalResults
	INTO #abnormalResultsForProcedureGetMostPerformedTestsDuringDates
    FROM Lab_Orders_have_Lab_Tests AS labOrders
    WHERE (isNormal IS NOT NULL AND isNormal = 0) AND testPerformed BETWEEN @startDate AND @endDate
    GROUP BY labTestCode;
    ALTER TABLE #abnormalResultsForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_temp_abnormalResults_getMostPerformedTestsDuringDates PRIMARY KEY (labTestCode);
        
	--	Total number of times any test was performed on someone between 18 and 29
    DROP TABLE IF EXISTS #twentiesResultForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #twentiesResultForProcedureGetMostPerformedTestsDuringDates
	SELECT DISTINCT labResults.labTestCode, COUNT(*) AS totalNumberOfTests
	INTO #twentiesResultForProcedureGetMostPerformedTestsDuringDates
    FROM Lab_Orders_have_Lab_Tests AS labResults
		JOIN Lab_Order on labResults.labOrderID = Lab_Order.id
		JOIN visit ON Lab_Order.visitID = visit.id
        JOIN appointment ON visit.appointmentID = appointment.id
        JOIN patient ON appointment.patientID = patient.id
        JOIN person ON patient.personID = person.id
	WHERE datediff(YEAR,person.dateOfBirth,labResults.testPerformed) BETWEEN 18 AND 29
    GROUP BY labResults.labTestCode, labResults.testPerformed;
    ALTER TABLE #twentiesResultForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_tempTwentiesResults_getMostPerformedTestsDuringDates PRIMARY KEY (labTestCode);
  
    --	Total number of times any test was performed on someone between 30 and 39
    DROP TABLE IF EXISTS #thirtiesResultForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #thirtiesResultForProcedureGetMostPerformedTestsDuringDates
	SELECT DISTINCT labResults.labTestCode, COUNT(*) AS totalNumberOfTests
	INTO #thirtiesResultForProcedureGetMostPerformedTestsDuringDates
    FROM Lab_Orders_have_Lab_Tests AS labResults
		JOIN Lab_Order on labResults.labOrderID = Lab_Order.id
		JOIN visit ON Lab_Order.visitID = visit.id
        JOIN appointment ON visit.appointmentID = appointment.id
        JOIN patient ON appointment.patientID = patient.id
        JOIN person ON patient.personID = person.id
	WHERE datediff(YEAR,person.dateOfBirth,labResults.testPerformed) BETWEEN 30 AND 39
    GROUP BY labResults.labTestCode, labResults.testPerformed;
    ALTER TABLE #thirtiesResultForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_tempThirtiesResults_getMostPerformedTestsDuringDates PRIMARY KEY (labTestCode);
		
    --	Total number of times any test was performed on someone not between 18 and 39
    DROP TABLE IF EXISTS #otherAgeResultForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #otherAgeResultForProcedureGetMostPerformedTestsDuringDates
	SELECT DISTINCT labResults.labTestCode, COUNT(*) AS totalNumberOfTests
	INTO #otherAgeResultForProcedureGetMostPerformedTestsDuringDates
    FROM Lab_Orders_have_Lab_Tests AS labResults
		JOIN Lab_Order on labResults.labOrderID = Lab_Order.id
		JOIN visit ON Lab_Order.visitID = visit.id
        JOIN appointment ON visit.appointmentID = appointment.id
        JOIN patient ON appointment.patientID = patient.id
        JOIN person ON patient.personID = person.id
	WHERE datediff(YEAR,person.dateOfBirth,labResults.testPerformed) NOT BETWEEN 18 AND 39
    GROUP BY labResults.labTestCode, labResults.testPerformed;
    ALTER TABLE #otherAgeResultForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_tempOtherAgeResults_getMostPerformedTestsDuringDates PRIMARY KEY (labTestCode);

	------------	Main Query		------------
	SELECT DISTINCT test.code AS labCode, test.name AS labName,
		totalResults.numberOfTests, @totalTests AS totalTests, totalResults.percentageOfTotal,
        ISNULL(normalResults.numberOfNormalResults, 0) AS numberOfNormalResults,
        ISNULL(abnormalResults.numberOfAbnormalResults, 0) AS numberOfAbnormalResults,
		(twentiesResults.totalNumberOfTests / CAST(totalResults.numberOfTests AS float)) AS percentageDoneOnTwentyYearOldsDuringThisTime,
        (thirtiesResults.totalNumberOfTests / CAST(totalResults.numberOfTests AS float)) AS percentageDoneOnThirtyYearOldsDuringThisTime,
		(otherAgeResults.totalNumberOfTests / CAST(totalResults.numberOfTests AS float)) AS percentageDoneOnOtherAgesDuringThisTime
    FROM Lab_Test AS test
		JOIN Lab_Orders_have_Lab_Tests AS labOrders
			ON test.code = labOrders.labTestCode
		LEFT JOIN #totalResultsForProcedureGetMostPerformedTestsDuringDates AS totalResults
			ON labOrders.labTestCode = totalResults.labTestCode
		LEFT JOIN #normalResultsForProcedureGetMostPerformedTestsDuringDates AS normalResults
			ON labOrders.labTestCode = normalResults.labTestCode
		LEFT JOIN #abnormalResultsForProcedureGetMostPerformedTestsDuringDates AS abnormalResults
			ON labOrders.labTestCode = abnormalResults.labTestCode
		LEFT JOIN #twentiesResultForProcedureGetMostPerformedTestsDuringDates AS twentiesResults
			ON labOrders.labTestCode = twentiesResults.labTestCode
		LEFT JOIN #thirtiesResultForProcedureGetMostPerformedTestsDuringDates AS thirtiesResults
			ON labOrders.labTestCode = thirtiesResults.labTestCode
		LEFT JOIN #otherAgeResultForProcedureGetMostPerformedTestsDuringDates AS otherAgeResults
			ON labOrders.labTestCode = otherAgeResults.labTestCode
	WHERE (totalResults.numberOfTests >= 2) AND (labOrders.testPerformed BETWEEN @startDate AND @endDate)
    ORDER BY numberOfTests DESC, labCode DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[registerPatient]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[registerPatient]
	@street varchar(45),
	@city varchar(45),
	@state char(2),
	@zip char(5),
	@firstName varchar(45),
	@lastName varchar(45),
	@dateOfBirth date,
	@ssn char(9),
	@gender char(1),
	@contactPhone char(10)
AS
BEGIN
	SET XACT_ABORT ON

	BEGIN TRY
		BEGIN TRANSACTION
			DECLARE @addressID int
			DECLARE @addressTable table (id int)
			DECLARE @personID int
			DECLARE @personTable table (id int)

			INSERT INTO Address(street, city, state, zip)
				OUTPUT inserted.id INTO @addressTable(id)
			VALUES (@street, @city, @state, @zip)

			SELECT @addressID = id FROM @addressTable

			INSERT INTO Person(username, password, firstName, lastName, dateOfBirth, ssn, gender, addressID, contactPhone)
				OUTPUT inserted.id INTO @personTable(id)
			VALUES (null, null, @firstName, @lastName, @dateOfBirth, @ssn, @gender, @addressID, @contactPhone)

			SELECT @personID = id FROM @personTable

			INSERT INTO Patient (personID, active)
			VALUES (@personID, 1)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION

		DECLARE @errormessage nvarchar(2048) = ERROR_MESSAGE()
		DECLARE @errorstate int = ERROR_STATE()

		RAISERROR(@errormessage, 16, @errorstate)
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[updatePatient]    Script Date: 5/3/2021 9:48:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[updatePatient]
	@personID int,
	@addressID int,
	@street varchar(45),
	@city varchar(45),
	@state char(2),
	@zip char(5),
	@firstName varchar(45),
	@lastName varchar(45),
	@dateOfBirth date,
	@ssn char(9),
	@gender char(1),
	@contactPhone char(10),
	@patientID int,
	@active bit
AS
BEGIN
	SET XACT_ABORT, NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION
			UPDATE Address
			SET street = @street, city = @city, state = @state, zip = @zip
			WHERE id = @addressID

			UPDATE Person
			SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth,
				ssn = @ssn, gender = @gender, addressID = @addressID, contactPhone = @contactPhone
			WHERE id = @personID

			UPDATE Patient
			SET active = @active
			WHERE id = @patientID
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION

		DECLARE @errormessage nvarchar(2048) = ERROR_MESSAGE()
		DECLARE @errorstate int = ERROR_STATE()

		RAISERROR(@errormessage, 16, @errorstate)
	END CATCH
END
GO


USE [master]
GO
ALTER DATABASE [cs6232-g4] SET  READ_WRITE 
GO

/**** INSERT DATA QUERY ****/

USE [cs6232-g4]
GO
SET IDENTITY_INSERT [dbo].[Address] ON 
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (1, N'3401 Derek mill', N'Marietta', N'GA', N'30067')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (2, N'87358 Bayside Road', N'Atlanta', N'GA', N'30343')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (3, N'2 8th Trail', N'Norman', N'OK', N'73071')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (4, N'336 Scofield Parkway', N'Atlanta', N'GA', N'20005')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (5, N'4790 Caliangt Drive', N'Jefferson City', N'MO', N'65110')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (6, N'8 Rowland Junction', N'Charlotte', N'NC', N'28299')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (7, N'527 Swallow Crossing', N'Amarillo', N'TX', N'79105')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (8, N'3 Eagle Crest Center', N'New York City', N'NY', N'10155')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (9, N'7347 Nova Way', N'Aiken', N'SC', N'29805')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (10, N'21476 Ronald Regan Point', N'Colorado Springs', N'CO', N'80951')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (11, N'3 Summit Way', N'Washington', N'DC', N'20370')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (12, N'80 David Plaza', N'Charlotte', N'NC', N'28284')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (13, N'5230 2nd Park', N'Saint Louis', N'MO', N'63116')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (14, N'25197 Annamark Place', N'Austin', N'TX', N'78778')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (15, N'24 Michigan Road', N'Garden Grove', N'CA', N'92844')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (16, N'2 Tennessee Lane', N'Phoenix', N'AZ', N'85053')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (17, N'56 Manitowish Junction', N'Kansas City', N'KS', N'66160')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (18, N'1528 8th Court', N'Tucson', N'AZ', N'85715')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (19, N'8 Boyd Drive', N'Minneapolis', N'MN', N'55446')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (20, N'025 Northview Parkway', N'Alexandria', N'VA', N'22309')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (21, N'92 Forster Park', N'Fresno', N'CA', N'93715')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (22, N'6983 Rusk Street', N'Tacoma', N'WA', N'98464')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (23, N'20 Rusk Drive', N'Tyler', N'TX', N'75710')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (24, N'3 Dwight Parkway', N'Wichita Falls', N'TX', N'76305')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (25, N'207 School Avenue', N'Saint Petersburg', N'FL', N'33710')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (26, N'27383 Meadow Vale Avenue', N'Grand Rapids', N'MI', N'49518')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (27, N'490 Gerald Hill', N'Apache Junction', N'AZ', N'85219')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (28, N'46 Bunting Place', N'Terre Haute', N'IN', N'47812')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (29, N'55 Chive Lane', N'Miami', N'FL', N'33196')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (30, N'6 Warbler Terrace', N'Port Saint Lucie', N'FL', N'34985')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (31, N'454 Crowley Point', N'Lakeland', N'FL', N'33805')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (32, N'3 Stephen Way', N'Minneapolis', N'MN', N'55480')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (33, N'8957 Village Green Pass', N'Washington', N'DC', N'20508')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (34, N'99535 Basil Point', N'Houston', N'TX', N'77250')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (35, N'78 Oak Parkway', N'Honolulu', N'HI', N'96810')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (36, N'8 Anhalt Hill', N'Juneau', N'AK', N'99812')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (37, N'5586 Miller Trail', N'Madison', N'WI', N'53705')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (38, N'40992 Stuart Crossing', N'Pasadena', N'CA', N'91199')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (39, N'0099 Declaration Place', N'Lake Charles', N'LA', N'70607')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (40, N'22106 Logan Center', N'Bradenton', N'FL', N'34205')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (41, N'9055 Derek Pass', N'Aurora', N'IL', N'60505')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (42, N'1245 Berkenridge Dr', N'Atlanta', N'GA', N'30067')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (43, N'1245 Berkenridge Dr', N'Atlanta', N'GA', N'30067')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (44, N'1245 Berkenridge Dr', N'Atlanta', N'GA', N'30067')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (45, N'1234 Asanda rd', N'Atlanta', N'GA', N'30022')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (46, N'1234 Resater rd', N'Marietta', N'GA', N'30067')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (47, N'234 Falling dr', N'Kennesaw', N'GA', N'30060')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (48, N'1265 Walter rd', N'Alpharetta', N'GA', N'30054')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (49, N'2356 Windy Hill Rd', N'Smyrna', N'GA', N'30023')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (52, N'789 Walter rd', N'Austell', N'GA', N'30021')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (53, N'754 Walter Rd', N'Marietta', N'AL', N'30012')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (54, N'4401 Mackingsin dr', N'Kennesaw', N'GA', N'30008')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (58, N'jkj', N'jkjkjk', N'AL', N'99999')
GO
INSERT [dbo].[Address] ([id], [street], [city], [state], [zip]) VALUES (59, N'wert', N'Ass', N'AL', N'12345')
GO
SET IDENTITY_INSERT [dbo].[Address] OFF
GO
SET IDENTITY_INSERT [dbo].[Person] ON 
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (2, N'deyvinz', N'756d7f266ff601290c1a9b49853db2dc4223f23fe550daebd100f9e34792027a10bd8bda09d962067fd5dd2013b799a847ad2357f61f637faa8021cabf6d2042', N'David', N'Gill', CAST(N'1993-08-12' AS Date), N'123456789', N'M', 1, N'7014259965')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (3, N'lander01', N'756d7f266ff601290c1a9b49853db2dc4223f23fe550daebd100f9e34792027a10bd8bda09d962067fd5dd2013b799a847ad2357f61f637faa8021cabf6d2042', N'Landar', N'Eric', CAST(N'1993-09-09' AS Date), N'123456789', N'M', 2, N'1234567890')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (5, N'derek1', N'756d7f266ff601290c1a9b49853db2dc4223f23fe550daebd100f9e34792027a10bd8bda09d962067fd5dd2013b799a847ad2357f61f637faa8021cabf6d2042', N'Derek', N'King', CAST(N'1993-12-02' AS Date), N'789456123', N'F', 3, N'7894567891')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (6, N'vicki01', N'756d7f266ff601290c1a9b49853db2dc4223f23fe550daebd100f9e34792027a10bd8bda09d962067fd5dd2013b799a847ad2357f61f637faa8021cabf6d2042', N'Vicki', N'Nick', CAST(N'2000-03-29' AS Date), N'456123698', N'F', 4, N'7086754432')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (7, N'sally12', N'756d7f266ff601290c1a9b49853db2dc4223f23fe550daebd100f9e34792027a10bd8bda09d962067fd5dd2013b799a847ad2357f61f637faa8021cabf6d2042', N'Sally', N'Mae', CAST(N'2000-06-12' AS Date), N'123456785', N'F', 5, N'785456985 ')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (13, NULL, NULL, N'Myrvyn', N'Grinter', CAST(N'2009-04-19' AS Date), N'425874170', N'M', 6, N'9275296732')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (15, NULL, NULL, N'Tobe', N'Sapshed', CAST(N'2000-01-14' AS Date), N'656736710', N'M', 7, N'4357303412')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (18, NULL, NULL, N'Beatrice', N'Futty', CAST(N'2009-06-12' AS Date), N'471569112', N'F', 8, N'9014839183')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (19, NULL, NULL, N'Dorisa', N'Hail', CAST(N'2005-12-19' AS Date), N'270814784', N'M', 9, N'4058633315')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (20, NULL, NULL, N'Megen', N'Fones', CAST(N'2003-04-04' AS Date), N'550570999', N'F', 10, N'2886989660')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (21, NULL, NULL, N'Sid', N'Ratter', CAST(N'2010-03-24' AS Date), N'269694191', N'M', 11, N'5126877616')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (22, NULL, NULL, N'Mortimer', N'Avo', CAST(N'2007-12-02' AS Date), N'890188763', N'M', 12, N'2396212721')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (23, NULL, NULL, N'Jorge', N'Collinwood', CAST(N'2000-10-06' AS Date), N'166746123', N'M', 13, N'4514931635')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (24, NULL, NULL, N'Madelaine', N'Fyndon', CAST(N'1996-11-21' AS Date), N'330897236', N'F', 14, N'1864078371')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (25, NULL, NULL, N'Rowen', N'Mangenet', CAST(N'2005-09-24' AS Date), N'415486266', N'M', 15, N'8772989443')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (26, NULL, NULL, N'Oberon', N'Abrashkin', CAST(N'2010-04-21' AS Date), N'669343729', N'M', 16, N'4938143861')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (27, NULL, NULL, N'Gran', N'Babe', CAST(N'1996-01-04' AS Date), N'873116701', N'M', 17, N'2569958464')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (28, NULL, NULL, N'Weston', N'Adnet', CAST(N'2000-11-25' AS Date), N'558977754', N'M', 18, N'2935450367')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (29, NULL, NULL, N'Lesli', N'Mellenby', CAST(N'2003-04-06' AS Date), N'304993250', N'F', 19, N'6589784393')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (30, NULL, NULL, N'Isobel', N'Quaintance', CAST(N'2009-07-25' AS Date), N'326066547', N'F', 20, N'4788621982')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (31, NULL, NULL, N'Ax', N'Mollitt', CAST(N'2009-09-14' AS Date), N'386991430', N'M', 21, N'3731090201')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (32, NULL, NULL, N'Trina', N'Questier', CAST(N'2008-04-04' AS Date), N'656228900', N'F', 22, N'9643616834')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (33, NULL, NULL, N'Jammal', N'Vida', CAST(N'2002-08-11' AS Date), N'738520359', N'M', 23, N'5319285901')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (34, NULL, NULL, N'Binky', N'Hawler', CAST(N'2009-01-02' AS Date), N'632185071', N'M', 24, N'3143745989')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (35, NULL, NULL, N'Florian', N'Stidworthy', CAST(N'1995-11-15' AS Date), N'895019009', N'M', 25, N'3724488857')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (36, NULL, NULL, N'Romonda', N'Menary', CAST(N'2006-03-04' AS Date), N'519114925', N'F', 26, N'2122135358')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (37, NULL, NULL, N'Shay', N'Munnion', CAST(N'2006-01-23' AS Date), N'883354117', N'M', 27, N'1295780834')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (38, NULL, NULL, N'Averill', N'Furlow', CAST(N'2004-03-03' AS Date), N'557737413', N'M', 28, N'3632381086')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (39, NULL, NULL, N'Eileen', N'Bliven', CAST(N'2007-09-18' AS Date), N'880843645', N'F', 29, N'9378764134')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (40, NULL, NULL, N'Colan', N'Hollibone', CAST(N'2004-02-13' AS Date), N'105727979', N'M', 30, N'9238184115')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (41, NULL, NULL, N'Welliem', N'Andy', CAST(N'1996-03-29' AS Date), N'123456789', N'M', 42, N'6784562345')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (42, NULL, NULL, N'Welliem', N'Andy', CAST(N'1996-03-29' AS Date), N'123456789', N'M', 43, N'6784562345')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (43, NULL, NULL, N'Welliem', N'Andy', CAST(N'1996-03-29' AS Date), N'123456789', N'M', 44, N'6784562345')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (44, NULL, NULL, N'Vally', N'Darin', CAST(N'1997-09-12' AS Date), N'123456798', N'M', 45, N'7063045512')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (45, NULL, NULL, N'Winter', N'Asal', CAST(N'2021-03-29' AS Date), N'799787671', N'M', 46, N'4046789901')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (49, N'jbel01', N'756d7f266ff601290c1a9b49853db2dc4223f23fe550daebd100f9e34792027a10bd8bda09d962067fd5dd2013b799a847ad2357f61f637faa8021cabf6d2042', N'Justice', N'Bell', CAST(N'2000-06-13' AS Date), N'123455556', N'M', 52, N'4561237894')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (50, N'jane', N'2BBE0C48B91A7D1B8A6753A8B9CBE1DB16B84379F3F91FE115621284DF7A48F1CD71E9BEB90EA614C7BD924250AA9E446A866725E685A65DF5D139A5CD180DC9', N'Jane', N'Ellan', CAST(N'2000-06-13' AS Date), N'774552714', N'M', 53, N'7854562231')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (51, N'doe', N'2BBE0C48B91A7D1B8A6753A8B9CBE1DB16B84379F3F91FE115621284DF7A48F1CD71E9BEB90EA614C7BD924250AA9E446A866725E685A65DF5D139A5CD180DC9', N'John', N'Doe', CAST(N'1994-02-15' AS Date), N'885463332', N'M', 54, N'4041235520')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (52, NULL, NULL, N'Jane', N'Doe', CAST(N'2021-04-29' AS Date), N'111111111', N'M', 58, N'9999999999')
GO
INSERT [dbo].[Person] ([id], [username], [password], [firstName], [lastName], [dateOfBirth], [ssn], [gender], [addressID], [contactPhone]) VALUES (53, N'bmee', N'2BBE0C48B91A7D1B8A6753A8B9CBE1DB16B84379F3F91FE115621284DF7A48F1CD71E9BEB90EA614C7BD924250AA9E446A866725E685A65DF5D139A5CD180DC9', N'Bell', N'Mee', CAST(N'2003-04-29' AS Date), N'222222222', N'M', 59, N'9999999999')
GO
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
SET IDENTITY_INSERT [dbo].[Clinical_Administrator] ON 
GO
INSERT [dbo].[Clinical_Administrator] ([id], [personID], [active]) VALUES (1, 5, 1)
GO
INSERT [dbo].[Clinical_Administrator] ([id], [personID], [active]) VALUES (2, 51, 1)
GO
SET IDENTITY_INSERT [dbo].[Clinical_Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 
GO
INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (1, 3, 1)
GO
INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (2, 21, 1)
GO
INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (3, 22, 1)
GO
INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (4, 23, 1)
GO
INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (5, 24, 1)
GO
INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (6, 25, 1)
GO
INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (7, 26, 1)
GO
INSERT [dbo].[Doctor] ([id], [personID], [active]) VALUES (8, 27, 1)
GO
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
SET IDENTITY_INSERT [dbo].[Nurse] ON 
GO
INSERT [dbo].[Nurse] ([id], [personID], [active]) VALUES (1, 2, 1)
GO
INSERT [dbo].[Nurse] ([id], [personID], [active]) VALUES (2, 5, 1)
GO
INSERT [dbo].[Nurse] ([id], [personID], [active]) VALUES (3, 50, 1)
GO
INSERT [dbo].[Nurse] ([id], [personID], [active]) VALUES (5, 53, 1)
GO
SET IDENTITY_INSERT [dbo].[Nurse] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (1, 6, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (2, 13, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (4, 15, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (7, 18, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (8, 19, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (9, 20, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (10, 41, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (11, 42, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (12, 43, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (13, 44, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (14, 45, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (18, 49, 1)
GO
INSERT [dbo].[Patient] ([id], [personID], [active]) VALUES (19, 52, 1)
GO
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
INSERT [dbo].[Specialty] ([name]) VALUES (N'
Plastic Surgery')
GO
INSERT [dbo].[Specialty] ([name]) VALUES (N'Obstetric Anesthesiology')
GO
INSERT [dbo].[Specialty] ([name]) VALUES (N'Ophthalmology')
GO
INSERT [dbo].[Specialty] ([name]) VALUES (N'Pediatrics')
GO
INSERT [dbo].[Specialty] ([name]) VALUES (N'Psychiatry')
GO
INSERT [dbo].[Doctor_has_Specialties] ([doctorID], [specialtyName]) VALUES (1, N'
Plastic Surgery')
GO
INSERT [dbo].[Doctor_has_Specialties] ([doctorID], [specialtyName]) VALUES (2, N'Obstetric Anesthesiology')
GO
INSERT [dbo].[Doctor_has_Specialties] ([doctorID], [specialtyName]) VALUES (3, N'Ophthalmology')
GO
INSERT [dbo].[Doctor_has_Specialties] ([doctorID], [specialtyName]) VALUES (4, N'Pediatrics')
GO
INSERT [dbo].[Doctor_has_Specialties] ([doctorID], [specialtyName]) VALUES (6, N'Pediatrics')
GO
INSERT [dbo].[Doctor_has_Specialties] ([doctorID], [specialtyName]) VALUES (7, N'Pediatrics')
GO
INSERT [dbo].[Doctor_has_Specialties] ([doctorID], [specialtyName]) VALUES (5, N'Psychiatry')
GO

USE [cs6232-g4]
GO
SET IDENTITY_INSERT [dbo].[Lab_Test] ON 
GO

INSERT INTO [cs6232-g4].[dbo].[Lab_Test] VALUES 
  (1,'White blood cell'), (2,'Low-Density Lipoproteins'),(3,'Hepatitis A'),
  (4,'Hepatitis B'),(5,'Influenza Test'),(6,'Thyroid Test'),(7,'Blood Oxygen Level')
GO
SET IDENTITY_INSERT [dbo].[Lab_Test] OFF
GO