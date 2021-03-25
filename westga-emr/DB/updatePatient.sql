USE [cs6232-g4]
GO

IF OBJECT_ID('updatePatient') IS NOT NULL
	DROP PROCEDURE updatePatient
GO

CREATE PROCEDURE updatePatient
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
		DECLARE @severity int = ERROR_SEVERITY()
		DECLARE @errorstate int = ERROR_STATE()

		RAISERROR(@errormessage, @severity, @errorstate)
		RETURN -1
	END CATCH
END