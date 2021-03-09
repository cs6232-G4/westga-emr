-- SQLINES DEMO *** rated by MySQL Workbench
-- SQLINES DEMO *** 25 2021
-- SQLINES DEMO ***    Version: 1.0
-- SQLINES DEMO *** orward Engineering

/* SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0; */
/* SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0; */
/* SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION'; */

-- SQLINES DEMO *** ------------------------------------
-- Schema cs6232-g4
-- SQLINES DEMO *** ------------------------------------
DROP SCHEMA IF EXISTS cs6232-g4 ;

-- SQLINES DEMO *** ------------------------------------
-- Schema cs6232-g4
-- SQLINES DEMO *** ------------------------------------
CREATE SCHEMA IF NOT EXISTS cs6232-g4 DEFAULT CHARACTER SET utf8 ;
USE [cs6232-g4] ;

-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ress`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Address] ;

CREATE TABLE cs6232-g4.Address (
  [id] INT NOT NULL IDENTITY,
  [street] VARCHAR(45) NOT NULL,
  [city] VARCHAR(45) NOT NULL,
  [state] CHAR(2) NOT NULL,
  [zip] CHAR(5) NOT NULL,
  PRIMARY KEY ([id]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** son`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Person] ;

CREATE TABLE cs6232-g4.Person (
  [id] INT NOT NULL IDENTITY,
  [username] VARCHAR(45) NULL,
  [password] VARCHAR(45) NULL,
  [firstName] VARCHAR(45) NOT NULL,
  [lastName] VARCHAR(45) NOT NULL,
  [dateOfBirth] DATE NOT NULL,
  [ssn] CHAR(9) NULL,
  [gender] CHAR(1) NOT NULL,
  [addressID] INT NOT NULL,
  [contactPhone] CHAR(10) NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [fk_addressID_address_id]
    FOREIGN KEY ([addressID])
    REFERENCES cs6232-g4.Address ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE UNIQUE INDEX username_UNIQUE ON cs6232-g4.Person ([username] ASC) VISIBLE;

CREATE INDEX fk_addressID_address_id_idx ON cs6232-g4.Person ([addressID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ient`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Patient] ;

CREATE TABLE cs6232-g4.Patient (
  [id] INT NOT NULL IDENTITY,
  [personID] INT NOT NULL,
  [active] SMALLINT NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [fk_personID_Person_id]
    FOREIGN KEY ([personID])
    REFERENCES cs6232-g4.Person ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE UNIQUE INDEX personID_UNIQUE ON cs6232-g4.Patient ([personID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** tor`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Doctor] ;

CREATE TABLE cs6232-g4.Doctor (
  [id] INT NOT NULL IDENTITY,
  [personID] INT NOT NULL,
  [active] SMALLINT NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [personID_fk_Person_id]
    FOREIGN KEY ([personID])
    REFERENCES cs6232-g4.Person ([username])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE UNIQUE INDEX personID_UNIQUE ON cs6232-g4.Doctor ([personID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** se`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Nurse] ;

CREATE TABLE cs6232-g4.Nurse (
  [id] INT NOT NULL IDENTITY,
  [personID] INT NOT NULL,
  [active] SMALLINT NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [personID_fk_Person_id]
    FOREIGN KEY ([personID])
    REFERENCES cs6232-g4.Person ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE UNIQUE INDEX personID_UNIQUE ON cs6232-g4.Nurse ([personID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** nical_Administrator`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Clinical_Administrator] ;

CREATE TABLE cs6232-g4.Clinical_Administrator (
  [id] INT NOT NULL IDENTITY,
  [personID] INT NOT NULL,
  [active] SMALLINT NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [personID_fk_Person_id]
    FOREIGN KEY ([personID])
    REFERENCES cs6232-g4.Person ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE UNIQUE INDEX personID_UNIQUE ON cs6232-g4.Clinical_Administrator ([personID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** cialty`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Specialty] ;

CREATE TABLE cs6232-g4.Specialty (
  [name] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([name]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** tor_has_Specialties`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Doctor_has_Specialties] ;

CREATE TABLE cs6232-g4.Doctor_has_Specialties (
  [doctorID] INT NOT NULL,
  [specialtyName] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([doctorID], [specialtyName]),
  CONSTRAINT [fk_Doctor_has_Specialties_Doctor1]
    FOREIGN KEY ([doctorID])
    REFERENCES cs6232-g4.Doctor ([id])
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Doctor_has_Specialties_Specialties1]
    FOREIGN KEY ([specialtyName])
    REFERENCES cs6232-g4.Specialty ([name])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_Doctor_has_Specialties_Specialties1_idx ON cs6232-g4.Doctor_has_Specialties ([specialtyName] ASC) VISIBLE;

CREATE INDEX fk_Doctor_has_Specialties_Doctor1_idx ON cs6232-g4.Doctor_has_Specialties ([doctorID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** ointment`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Appointment] ;

CREATE TABLE cs6232-g4.Appointment (
  [id] BIGINT NOT NULL IDENTITY,
  [patientID] INT NOT NULL,
  [doctorID] INT NOT NULL,
  [appointmentDateTime] DATETIME2(0) NOT NULL,
  [reasonForVisit] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [fk_Patient_has_Doctor_Patient1]
    FOREIGN KEY ([patientID])
    REFERENCES cs6232-g4.Patient ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Patient_has_Doctor_Doctor1]
    FOREIGN KEY ([doctorID])
    REFERENCES cs6232-g4.Doctor ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_Patient_has_Doctor_Doctor1_idx ON cs6232-g4.Appointment ([doctorID] ASC) VISIBLE;

CREATE INDEX fk_Patient_has_Doctor_Patient1_idx ON cs6232-g4.Appointment ([patientID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** it`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Visit] ;

CREATE TABLE cs6232-g4.Visit (
  [id] BIGINT NOT NULL IDENTITY,
  [appointmentID] BIGINT NOT NULL,
  [nurseID] INT NOT NULL,
  [visitDateTime] DATETIME2(0) NOT NULL,
  [initialDiagnosis] VARCHAR(64) NOT NULL,
  [weight] DECIMAL(5,2) NOT NULL,
  [systolicPressure] INT NOT NULL,
  [diastolicPressure] INT NOT NULL,
  [bodyTemperature] DECIMAL(4,1) NOT NULL,
  [pulse] INT NOT NULL,
  [symptoms] VARCHAR(255) NULL,
  [finalDiagnosis] VARCHAR(64) NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [nurseID_fk_Nurse_id]
    FOREIGN KEY ([nurseID])
    REFERENCES cs6232-g4.Nurse ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT [appointmentID_fk_Appointment_id]
    FOREIGN KEY ([appointmentID])
    REFERENCES cs6232-g4.Appointment ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE INDEX nurseID_fk_Nurse_id_idx ON cs6232-g4.Visit ([nurseID] ASC) VISIBLE;

CREATE INDEX appointmentID_fk_Appointment_id_idx ON cs6232-g4.Visit ([appointmentID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** _Test`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Lab_Test] ;

CREATE TABLE cs6232-g4.Lab_Test (
  [code] INT NOT NULL,
  [name] VARCHAR(45) NOT NULL,
  PRIMARY KEY ([code]))
;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** _Order`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Lab_Order] ;

CREATE TABLE cs6232-g4.Lab_Order (
  [id] BIGINT NOT NULL IDENTITY,
  [visitID] BIGINT NOT NULL,
  [dateOrdered] DATE NOT NULL,
  PRIMARY KEY ([id]),
  CONSTRAINT [visitID_fk_Visit_id]
    FOREIGN KEY ([visitID])
    REFERENCES cs6232-g4.Visit ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE INDEX visitID_fk_Visit_id_idx ON cs6232-g4.Lab_Order ([visitID] ASC) VISIBLE;


-- SQLINES DEMO *** ------------------------------------
-- SQLINES DEMO *** _Orders_have_Lab_Tests`
-- SQLINES DEMO *** ------------------------------------
DROP TABLE IF EXISTS [cs6232-g4`.`Lab_Orders_have_Lab_Tests] ;

CREATE TABLE cs6232-g4.Lab_Orders_have_Lab_Tests (
  [labOrderID] BIGINT NOT NULL,
  [labTestCode] INT NOT NULL,
  [testPerformed] DATE NOT NULL,
  [results] VARCHAR(255) NULL,
  PRIMARY KEY ([labOrderID], [labTestCode]),
  CONSTRAINT [fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Visit1]
    FOREIGN KEY ([labOrderID])
    REFERENCES cs6232-g4.Lab_Order ([id])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT [fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1]
    FOREIGN KEY ([labTestCode])
    REFERENCES cs6232-g4.Lab_Test ([code])
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
;

CREATE INDEX fk_Labs_Ordered_For_Visit_has_Lab_Test_Lab_Test1_idx ON cs6232-g4.Lab_Orders_have_Lab_Tests ([labTestCode] ASC) VISIBLE;

CREATE INDEX fk_Labs_Ordered_For_Visit_has_Lab_Test_Labs_Ordered_For_Vis_idx ON cs6232-g4.Lab_Orders_have_Lab_Tests ([labOrderID] ASC) VISIBLE;


/* SET SQL_MODE=@OLD_SQL_MODE; */
/* SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS; */
/* SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS; */
