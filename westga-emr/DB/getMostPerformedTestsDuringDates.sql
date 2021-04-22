USE [cs6232-g4]
GO

IF OBJECT_ID('getMostPerformedTestsDuringDates') IS NOT NULL
	DROP PROCEDURE getMostPerformedTestsDuringDates
GO

CREATE PROCEDURE getMostPerformedTestsDuringDates 
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
    WHERE results = 'normal' AND testPerformed BETWEEN @startDate AND @endDate
    GROUP BY labTestCode;
    ALTER TABLE #normalResultsForProcedureGetMostPerformedTestsDuringDates
		ADD CONSTRAINT PK_labCode_temp_normalResults PRIMARY KEY (labTestCode);
        
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
        normalResults.numberOfNormalResults,
        (totalResults.numberOfTests - ISNULL(normalResults.numberOfNormalResults, 0)) AS numberOfAbnormalResults,
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
		LEFT JOIN #twentiesResultForProcedureGetMostPerformedTestsDuringDates AS twentiesResults
			ON labOrders.labTestCode = twentiesResults.labTestCode
		LEFT JOIN #thirtiesResultForProcedureGetMostPerformedTestsDuringDates AS thirtiesResults
			ON labOrders.labTestCode = thirtiesResults.labTestCode
		LEFT JOIN #otherAgeResultForProcedureGetMostPerformedTestsDuringDates AS otherAgeResults
			ON labOrders.labTestCode = otherAgeResults.labTestCode
	WHERE (totalResults.numberOfTests >= 2) AND (labOrders.testPerformed BETWEEN @startDate AND @endDate)
    ORDER BY numberOfTests DESC, labCode DESC;
END