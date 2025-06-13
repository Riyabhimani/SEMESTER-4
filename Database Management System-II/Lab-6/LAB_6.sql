--Part - A 

SELECT * FROM PRODUCTS

--1. Create a cursor Product_Cursor to fetch all the rows from a products table.
	DECLARE 
		@PRODUCT_ID INT,
		@PRODUCT_NAME VARCHAR(250),
		@PRICE DECIMAL(10,2)

	DECLARE Product_Cursor CURSOR
	FOR 
		SELECT *
		FROM Products
	OPEN Product_Cursor
	FETCH NEXT FROM Product_Cursor INTO 
		@PRODUCT_ID,
		@PRODUCT_NAME,
		@PRICE
	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT CAST(@PRODUCT_ID AS VARCHAR) + ' ' + @PRODUCT_NAME + ' ' + CAST(@PRICE AS VARCHAR)
			FETCH NEXT FROM Product_Cursor INTO 
			@PRODUCT_ID,
			@PRODUCT_NAME,
			@PRICE
		END
	CLOSE Product_Cursor
	DEALLOCATE Product_Cursor

--2. Create a cursor Product_Cursor_Fetch to fetch the records in form of ProductID_ProductName. 
--(Example: 1_Smartphone) 
	DECLARE 
		@ProductId INT,
		@ProductName VARCHAR(250)

	DECLARE Product_Cursor_Fetch CURSOR
	FOR 
		SELECT 
			Product_Id,
			Product_Name
		FROM Products
	OPEN Product_Cursor_Fetch
	FETCH NEXT FROM Product_Cursor_Fetch INTO 
		@ProductId,
		@ProductName

	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT CAST(@ProductId AS VARCHAR) + '_' + @ProductName
			FETCH NEXT FROM Product_Cursor_Fetch INTO 
			@ProductId,
			@ProductName
		END
	CLOSE Product_Cursor_Fetch
	DEALLOCATE Product_Cursor_Fetch

--3. Create a Cursor to Find and Display Products Above Price 30,000.
	DECLARE 
		@PId INT,
		@PName varchar(250),
		@p decimal(10,2)

	DECLARE Product_Cursor_Fetch_With_Condition1 CURSOR
	FOR 
		SELECT 
			Product_Id,
			Product_Name,
			Price
		FROM Products
		where Price > 30000
	OPEN Product_Cursor_Fetch_With_Condition1
	FETCH NEXT FROM Product_Cursor_Fetch_With_Condition1 INTO 
		@PId,
		@PName,
		@p

	WHILE @@FETCH_STATUS = 0
		BEGIN
			PRINT CAST(@PId AS VARCHAR) + '_' + @PName + cast(@p as varchar)
			FETCH NEXT FROM Product_Cursor_Fetch_With_Condition1 INTO 
			@PId,
			@PName,
			@p
		END
	CLOSE Product_Cursor_Fetch_With_Condition1
	DEALLOCATE Product_Cursor_Fetch_With_Condition1

--4. Create a cursor Product_CursorDelete that deletes all the data from the Products table. 
	DECLARE 
		@prid INT

	DECLARE Product_CursorDelete CURSOR
	FOR 
		SELECT Product_Id
		FROM Products

	OPEN Product_CursorDelete

	FETCH NEXT FROM Product_CursorDelete INTO 
		@prid

	WHILE @@FETCH_STATUS = 0
		BEGIN
			DELETE 
			FROM Products
			WHERE Product_Id = @Prid
			FETCH NEXT FROM Product_CursorDelete INTO 
			@prid
		END
	CLOSE Product_CursorDelete
	DEALLOCATE Product_CursorDelete

	select * from Products

--Part – B 

--5. Create a cursor Product_CursorUpdate that retrieves all the data from the products table and increases 
--the price by 10%.
	DECLARE 
		@proid INT,
		@pricee decimal(10,2)

	DECLARE Product_CursorUpdate CURSOR
	FOR 
		SELECT Product_Id,Price
		FROM Products

	OPEN Product_CursorUpdate

	FETCH NEXT FROM Product_CursorUpdate INTO 
		@proid,
		@pricee

	WHILE @@FETCH_STATUS = 0
		BEGIN
			update Products
			set Price = Price+(Price*10/100)
			WHERE Product_Id = @proid
			FETCH NEXT FROM Product_CursorUpdate INTO 
			@proid,
			@pricee
		END
	CLOSE Product_CursorUpdate
	DEALLOCATE Product_CursorUpdate

--6. Create a Cursor to Rounds the price of each product to the nearest whole number. 
	DECLARE 
		@prodid INT,
		@priccee decimal(10,2)

	DECLARE Product_CursorRound CURSOR
	FOR 
		SELECT Product_Id,Price
		FROM Products

	OPEN Product_CursorRound

	FETCH NEXT FROM Product_CursorRound INTO 
		@prodid,
		@priccee

	WHILE @@FETCH_STATUS = 0
		BEGIN
			update Products
			set Price = Round(Price,2)
			WHERE Product_Id = @prodid
			FETCH NEXT FROM Product_CursorRound INTO 
			@prodid,
			@priccee
		END
	CLOSE Product_CursorRound
	DEALLOCATE Product_CursorRound

--Part – C 

--7. Create a cursor to insert details of Products into the NewProducts table if the product is “Laptop” 
--(Note: Create NewProducts table first with same fields as Products table) 
	DECLARE 
		@produid INT,
		@prodName varchar(250),
		@priiccee decimal(10,2)

	DECLARE Product_CursorInsert CURSOR
	FOR 
		SELECT Product_Id,Product_Name,Price
		FROM Products
		where Product_Name='Laptop'

	OPEN Product_CursorInsert

	FETCH NEXT FROM Product_CursorInsert INTO 
		@produid,
		@prodName,
		@priiccee

	WHILE @@FETCH_STATUS = 0
		BEGIN
			insert into NewProducts 
			values
				(@produid,
				@prodName,
				@priiccee)

			FETCH NEXT FROM Product_CursorInsert INTO 
			@produid,
			@prodName,
			@priiccee
		END
	CLOSE Product_CursorInsert
	DEALLOCATE Product_CursorInsert

	select * from NewProducts

--8. Create a Cursor to Archive High-Price Products in a New Table (ArchivedProducts), Moves products 
--with a price above 50000 to an archive table, removing them from the original Products table. 
	DECLARE 
		@producid INT,
		@produName varchar(250),
		@prriiccee decimal(10,2)

	DECLARE Product_CursorInsertDelete CURSOR
	FOR 
		SELECT Product_Id,Product_Name,Price
		FROM Products
		where Price > 50000

	OPEN Product_CursorInsertDelete

	FETCH NEXT FROM Product_CursorInsertDelete INTO 
		@producid,
		@produName,
		@prriiccee

	WHILE @@FETCH_STATUS = 0
		BEGIN
			insert into ArchivedProducts 
			values
				(@producid,
				@produName,
				@prriiccee)

			delete 
			from Products
			where Product_Id = @producid

			FETCH NEXT FROM Product_CursorInsertDelete INTO 
			@producid,
			@produName,
			@prriiccee
		END
	CLOSE Product_CursorInsertDelete
	DEALLOCATE Product_CursorInsertDelete

	select * from Products
	select * from ArchivedProducts