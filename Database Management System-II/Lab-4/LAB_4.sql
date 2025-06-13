--Note: for Table valued function use tables of Lab-2 

--Part – A 

--1. Write a function to print "hello world". 
	CREATE OR ALTER FUNCTION FN_HELLOWORLD()
	RETURNS VARCHAR(100)
	AS
	BEGIN
		RETURN 'HELLO WORLD'
	END;

	SELECT DBO.FN_HELLOWORLD();

--2. Write a function which returns addition of two numbers. 
	CREATE OR ALTER FUNCTION FN_ADDOFTWO(
		@NUM1 INT ,
		@NUM2 INT
	)
	RETURNS INT
	AS
	BEGIN
		DECLARE @ANS INT
		SET @ANS = @NUM1 + @NUM2
		RETURN @ANS
	END;

	SELECT DBO.FN_ADDOFTWO(10,20);

_--3. Write a function to check whether the given number is ODD or EVEN.
	CREATE OR ALTER FUNCTION FN_ODDOREVEN(
		@NUM INT
	)
	RETURNS VARCHAR(100)
	AS
	BEGIN
		DECLARE @MSG VARCHAR(100)
		IF @NUM%2 = 0
			SET @MSG = 'EVEN'
		IF @NUM%2 != 0
			SET @MSG = 'ODD'
		RETURN @MSG
	END;

	SELECT DBO.FN_ODDOREVEN(10);
	SELECT DBO.FN_ODDOREVEN(3);

--4. Write a function which returns a table with details of a person whose first name starts with B.
	CREATE OR ALTER FUNCTION FN_FIRSTNAMEWITHB()
	RETURNS TABLE
	AS
		RETURN (
				SELECT * 
				FROM PERSON
				WHERE FirstName LIKE 'B%'
			   )

	SELECT * FROM DBO.FN_FIRSTNAMEWITHB();

--5. Write a function which returns a table with unique first names from the person table. 
	CREATE OR ALTER FUNCTION FN_UNIQUEFIRSTNAME()
	RETURNS TABLE
	AS
		RETURN (
				SELECT DISTINCT FIRSTNAME
				FROM PERSON
			   )

	SELECT * FROM DBO.FN_UNIQUEFIRSTNAME();

--6. Write a function to print number from 1 to N. (Using while loop) 
	CREATE OR ALTER FUNCTION FN_1TON(
		@N INT
	)
	RETURNS VARCHAR(500)
	AS
	BEGIN
		DECLARE @MSG VARCHAR(500) , @COUNT INT
		SET @MSG = ' '
		SET @COUNT = 1

		WHILE (@COUNT <= @N)
		BEGIN
			SET @MSG = @MSG+' '+CAST(@COUNT AS VARCHAR)
			SET @COUNT = @COUNT + 1
		END
		RETURN @MSG
	END

	SELECT DBO.FN_1TON(5);

--7. Write a function to find the factorial of a given integer. 
	CREATE OR ALTER FUNCTION FN_FACT(
		@NUM INT
	)
	RETURNS INT
	AS
	BEGIN
		DECLARE @FACT INT
		SET @FACT = 1

		WHILE(@NUM != 0)
		BEGIN
			SET @FACT = @FACT * @NUM
			SET @NUM = @NUM - 1
		END
		RETURN @FACT
	END

	SELECT DBO.FN_FACT(5);

--Part – B 

--8. Write a function to compare two integers and return the comparison result. (Using Case statement) 
	CREATE OR ALTER FUNCTION FN_COMPARISON(
		@NUM1 INT ,
		@NUM2 INT
	)
	RETURNS VARCHAR(100)
	AS
	BEGIN
		RETURN CASE
				WHEN @NUM1 = @NUM2 THEN 'BOTH NUMBERS ARE EQUALS !'
				WHEN @NUM1 > @NUM2 THEN CAST(@NUM1 AS VARCHAR)+' IS GREATER THAN '+CAST(@NUM2 AS VARCHAR)
				WHEN @NUM1 < @NUM2 THEN CAST(@NUM1 AS VARCHAR)+' IS LESS THAN '+CAST(@NUM2 AS VARCHAR)
				ELSE 'ENTERED INPUT IS NOT A NUMBER !'
		END
	END;

	SELECT DBO.FN_COMPARISON(1,2);
	SELECT DBO.FN_COMPARISON(1,1);
	SELECT DBO.FN_COMPARISON(2,1);

--9. Write a function to print the sum of even numbers between 1 to 20.
	CREATE OR ALTER FUNCTION FN_SUMOFEVEN1TO20()
	RETURNS INT
	AS
	BEGIN
		DECLARE @SUM INT ,
				@NUM INT
		SET @SUM=0
		SET @NUM=1

		WHILE @NUM <= 20
			BEGIN
				IF @NUM%2 = 0
					SET @SUM=@SUM+@NUM
					SET @NUM=@NUM+1
			END
		RETURN @SUM
	END

	SELECT DBO.FN_SUMOFEVEN1TO20();

--10. Write a function that checks if a given string is a palindrome.
	CREATE OR ALTER FUNCTION FN_PALINFROME(
		@STR VARCHAR(100)
	)
	RETURNS VARCHAR(100)
	AS
	BEGIN
		DECLARE @REV VARCHAR(100),
				@MSG VARCHAR(100)
		SET @REV = REVERSE(@STR)

		IF @STR = @REV
			SET @MSG = 'PALINDROME'
		ELSE
			SET @MSG = 'NOT PALINDROME'
		RETURN @MSG
	END

	SELECT DBO.FN_PALINFROME('ABCCBA');
	SELECT DBO.FN_PALINFROME('ABCABC');

--Part – C 

--11. Write a function to check whether a given number is prime or not. 
	CREATE OR ALTER FUNCTION FN_PRIMENUM(
		@NUM INT
	)
	RETURNS VARCHAR(100)
	AS
	BEGIN
		DECLARE @COUNT INT , @I INT
		SET @I = 2
			WHILE @I<CAST(@NUM/2 AS INT)
				BEGIN
					IF @NUM%@I = 0
						SET @COUNT = @COUNT+1
						SET @I = @I +1
				END
			IF @COUNT=0
				RETURN 'PRIME'
			
			RETURN 'NOT PRIME'
	END;

	SELECT DBO.FN_PRIMENUM(191);

--12. Write a function which accepts two parameters start date & end date, and returns a difference in days.
	CREATE OR ALTER FUNCTION FN_DATEDIFF(
		@SDATE DATE,
		@EDATE DATE
	)
	RETURNS INT
	AS
	BEGIN
		DECLARE @DIFF INT
		SET @DIFF = DATEDIFF(DAY,@SDATE,@EDATE)
		RETURN @DIFF
	END

	SELECT DBO.FN_DATEDIFF('1990-12-1','1990-12-20');

--13. Write a function which accepts two parameters year & month in integer and returns total days each year. 
	CREATE OR ALTER FUNCTION FN_TOTALDAYS(
		@YEAR INT , 
		@MONTH INT
	)
	RETURNS INT
	AS
	BEGIN
		DECLARE @DAY DATETIME , @DATE VARCHAR(100)
		SET @DATE = CAST(@YEAR AS VARCHAR)+'-'+CAST(@MONTH AS VARCHAR)+'-'+CAST(1 AS VARCHAR)
		SET @DAY = CAST(@DATE AS DATE)
		RETURN DAY(EOMONTH(@DAY))

	END

	SELECT DBO.FN_TOTALDAYS(2020,11);

--14. Write a function which accepts departmentID as a parameter & returns a detail of the persons. 
	CREATE OR ALTER FUNCTION FN_PERSONDETAILS(
		@DEPTID INT
	)
	RETURNS TABLE
	AS
		RETURN(
			SELECT *
			FROM PERSON
			WHERE DEPARTMENTID = @DEPTID
		)	
	
	SELECT * FROM DBO.FN_PERSONDETAILS(1);

--15. Write a function that returns a table with details of all persons who joined after 1-1-1991. 
	CREATE OR ALTER FUNCTION FN_RESONDETAILSBYJOININGDATE()
	RETURNS TABLE
	AS
		RETURN(
			SELECT * 
			FROM PERSON
			WHERE JOININGDATE > '1991-01-01'
		)

	SELECT * FROM DBO.FN_RESONDETAILSBYJOININGDATE();
