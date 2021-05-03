USE [master]
GO
/****** Object:  Database [cs6232-g4]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Address]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Appointment]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Clinical_Administrator]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Doctor]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Doctor_has_Specialties]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Lab_Order]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Lab_Orders_have_Lab_Tests]    Script Date: 4/30/2021 2:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lab_Orders_have_Lab_Tests](
	[labOrderID] [bigint] NOT NULL,
	[labTestCode] [int] NOT NULL,
	[testPerformed] [datetime2](0) NULL,
	[results] [varchar](255) NULL,
	[isNormal] [bit] NULL,
 CONSTRAINT [PK__Lab_Orde__EAA6BD2283F3A9C3] PRIMARY KEY CLUSTERED 
(
	[labOrderID] ASC,
	[labTestCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lab_Test]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Nurse]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Patient]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Person]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Specialty]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Table [dbo].[Visit]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  Index [fk_Patient_has_Doctor_Doctor1_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [fk_Patient_has_Doctor_Doctor1_idx] ON [dbo].[Appointment]
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Patient_has_Doctor_Patient1_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [fk_Patient_has_Doctor_Patient1_idx] ON [dbo].[Appointment]
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Clinical_Administrator]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Doctor]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Doctor_has_Specialties_Doctor1_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [fk_Doctor_has_Specialties_Doctor1_idx] ON [dbo].[Doctor_has_Specialties]
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [fk_Doctor_has_Specialties_Specialties1_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [fk_Doctor_has_Specialties_Specialties1_idx] ON [dbo].[Doctor_has_Specialties]
(
	[specialtyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [visitID_fk_Visit_id_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [visitID_fk_Visit_id_idx] ON [dbo].[Lab_Order]
(
	[visitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1_idx] ON [dbo].[Lab_Orders_have_Lab_Tests]
(
	[labTestCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Vis_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Vis_idx] ON [dbo].[Lab_Orders_have_Lab_Tests]
(
	[labOrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Nurse]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [personID_UNIQUE]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [personID_UNIQUE] ON [dbo].[Patient]
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [fk_addressID_address_id_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [fk_addressID_address_id_idx] ON [dbo].[Person]
(
	[addressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [username_UNIQUE]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [username_UNIQUE] ON [dbo].[Person]
(
	[username] ASC
)
WHERE ([username] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [appointmentID_fk_Appointment_id_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE NONCLUSTERED INDEX [appointmentID_fk_Appointment_id_idx] ON [dbo].[Visit]
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [appointmentID_unique]    Script Date: 4/30/2021 2:35:54 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [appointmentID_unique] ON [dbo].[Visit]
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [nurseID_fk_Nurse_id_idx]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  StoredProcedure [dbo].[getMostPerformedTestsDuringDates]    Script Date: 4/30/2021 2:35:54 PM ******/
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
		ADD CONSTRAINT PK_labCode_temp_totalResults PRIMARY KEY (labTestCode);
    
	--	Number of "normal" results for any given test in this procedure's date range
	DROP TABLE IF EXISTS #normalResultsForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #normalResultsForProcedureGetMostPerformedTestsDuringDates
    SELECT labTestCode, COUNT(*) AS numberOfNormalResults
	INTO #normalResultsForProcedureGetMostPerformedTestsDuringDates
    FROM Lab_Orders_have_Lab_Tests AS labOrders
    WHERE (isNormal IS NOT NULL AND isNormal = 1) AND testPerformed BETWEEN @startDate AND @endDate
    GROUP BY labTestCode;
    ALTER TABLE #normalResultsForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_temp_normalResults PRIMARY KEY (labTestCode);

		--	Number of "normal" results for any given test in this procedure's date range
	DROP TABLE IF EXISTS #abnormalResultsForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #normalResultsForProcedureGetMostPerformedTestsDuringDates
    SELECT labTestCode, COUNT(*) AS numberOfAbnormalResults
	INTO #abnormalResultsForProcedureGetMostPerformedTestsDuringDates
    FROM Lab_Orders_have_Lab_Tests AS labOrders
    WHERE (isNormal IS NOT NULL AND isNormal = 0) AND testPerformed BETWEEN @startDate AND @endDate
    GROUP BY labTestCode;
    ALTER TABLE #abnormalResultsForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_temp_abnormalResults PRIMARY KEY (labTestCode);
        
	--	Total number of times any test was performed on someone between 18 and 29
    DROP TABLE IF EXISTS #twentiesResultForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #twentiesResultForProcedureGetMostPerformedTestsDuringDates
	SELECT labResults.labTestCode, COUNT(*) AS totalNumberOfTests
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
		ADD CONSTRAINT PK_labCode_tempTwentiesResults PRIMARY KEY (labTestCode);
  
    --	Total number of times any test was performed on someone between 30 and 39
    DROP TABLE IF EXISTS #thirtiesResultForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #thirtiesResultForProcedureGetMostPerformedTestsDuringDates
	SELECT labResults.labTestCode, COUNT(*) AS totalNumberOfTests
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
		ADD CONSTRAINT PK_labCode_tempThirtiesResults PRIMARY KEY (labTestCode);
		
    --	Total number of times any test was performed on someone not between 18 and 39
    DROP TABLE IF EXISTS #otherAgeResultForProcedureGetMostPerformedTestsDuringDates;
    --CREATE TABLE #otherAgeResultForProcedureGetMostPerformedTestsDuringDates
	SELECT labResults.labTestCode, COUNT(*) AS totalNumberOfTests
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
		ADD CONSTRAINT PK_labCode_tempOtherAgeResults PRIMARY KEY (labTestCode);

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
/****** Object:  StoredProcedure [dbo].[registerPatient]    Script Date: 4/30/2021 2:35:54 PM ******/
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
/****** Object:  StoredProcedure [dbo].[updatePatient]    Script Date: 4/30/2021 2:35:54 PM ******/
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
