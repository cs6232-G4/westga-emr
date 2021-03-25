USE [cs6232-g4]
GO

IF OBJECT_ID('registerPatient') IS NOT NULL
	DROP PROCEDURE registerPatient
GO

CREATE PROCEDURE registerPatient
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
	SET XACT_ABORT, NOCOUNT ON

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
		DECLARE @severity int = ERROR_SEVERITY()
		DECLARE @errorstate int = ERROR_STATE()

		RAISERROR(@errormessage, @severity, @errorstate)
		RETURN -1
	END CATCH
END