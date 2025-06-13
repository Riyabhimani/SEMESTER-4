
-- Create the Customers table

CREATE TABLE Customers ( 
Customer_id INT PRIMARY KEY,                 
Customer_Name VARCHAR(250) NOT NULL,         
Email VARCHAR(50) UNIQUE                     
); 

-- Create the Orders table 

CREATE TABLE Orders ( 
Order_id INT PRIMARY KEY,                    
Customer_id INT,                             
Order_date DATE NOT NULL,                    
FOREIGN KEY (Customer_id) REFERENCES Customers(Customer_id)  
);

--Part – A 

--1. Handle Divide by Zero Error and Print message like: Error occurs that is - Divide by zero error. 
	Begin Try
		declare @num1 int , 
				@num2 int,
				@result decimal(10,2)

		set @num1=10
		set @num2=0

		set @result = @num1 / @num2
		print(@result)
	End Try

	Begin Catch
		print 'Error occurs that is - Divide by zero error.'
	End Catch

--2. Try to convert string to integer and handle the error using try…catch block.
	Begin Try
		declare @str1 varchar(10),
				@str2 varchar(10),
				@result int

		set @str1 = 'ABC'
		set @str2 = 10

		print('Str1 = '+cast(@str1 as int))
		print('Str2 = '+cast(@str2 as int))
	End Try
	Begin Catch
		print 'Error: Unable to convert into integer.'
	End Catch

--3. Create a procedure that prints the sum of two numbers: take both numbers as integer & handle 
--exception with all error functions if any one enters string value in numbers otherwise print result. 
	Create or alter procedure PR_Sum_Of_Two
		@num1 int,
		@num2 varchar(10)
	As
	Begin
		Begin Try
			Declare @result int
			set @result = cast(@num1 as int) + cast(@num2 as int)
			print cast(@result as varchar(50))
		End Try
		Begin Catch
			print (cast(Error_Number() as varchar(50)))
			print(cast(Error_State() as varchar(50)))
			print(cast(Error_Procedure() as varchar(50)))
			print(cast(Error_Severity() as varchar(50)))
			print(Error_Message())
			print(cast(Error_Line() as varchar(50)))
		End Catch
	End

	Exec PR_Sum_Of_Two 10,'a'

--4. Handle a Primary Key Violation while inserting data into customers table and print the error details 
--such as the error message, error number, severity, and state.
	Create or alter procedure PR_Primary_Key_Violation
	As
	Begin
		Begin Try
			insert into Customers 
			values (1,'abc','abc@gmail.com')
		End Try
		Begin Catch
			print (cast(Error_Number() as varchar(50)))
			print(cast(Error_State() as varchar(50)))
			print(cast(Error_Procedure() as varchar(50)))
			print(cast(Error_Severity() as varchar(50)))
			print(Error_Message())
			print(cast(Error_Line() as varchar(50)))
		End Catch
	End

	exec PR_Primary_Key_Violation  

	select * from Customers

--5. Throw custom exception using stored procedure which accepts Customer_id as input & that throws 
--Error like no Customer_id is available in database. 
	Create or alter procedure PR_Custom_Error
		@Customer_id int
	As
	Begin
		if not exists (select 1 from Customers where Customer_id = @Customer_id)
			Begin
				Throw 50001,'No Customer_id is available in database !',1;
			End
		Else
			Begin
				print 'Customer_id is exists'
			End
	End
	
	exec PR_Custom_Error 2

--Part – B 

--6. Handle a Foreign Key Violation while inserting data into Orders table and print appropriate error 
--message. 
	Begin Try
		insert into Orders 
		values (101,2,'1998-12-11')
	End Try
	Begin Catch
		print 'Foreign key is not available !'
	End Catch

--7. Throw custom exception that throws error if the data is invalid. 
	Create or alter procedure PR_Custom_Error_invalid
		@Customer_Name varchar(50)
	As
	Begin
		if not exists (select 1 from Customers where Customer_Name = @Customer_Name)
			Begin
				Throw 50001,'Invalid data !',1;
			End
		Else
			Begin
				print 'Data is valid'
			End
	End
	
	exec PR_Custom_Error_invalid 'bac'

--8. Create a Procedure to Update Customer’s Email with Error Handling 
	Create or alter procedure PR_Update_Customer_Email
		@Customer_id int
	As
	Begin
		declare @Email varchar(100)
		if not exists (select 1 from Customers where Customer_id = @Customer_id)
			Begin
				Throw 50001,'No Customer_id is available in database !',1;
			End
		Else
			Begin
				Update Customers
				set Email = @Email
				where Customer_id = @Customer_id
			End
	End

	exec PR_Update_Customer_Email 3

	Update Customers
	set Email = 'abccc@gmail.com'
	where Customer_id = 1

	select * from Customers

--Part – C  

--9. Create a procedure which prints the error message that “The Customer_id is already taken. Try another one”. 
	Create or alter procedure PR_Customer_id_exist
	As
	Begin
		Begin Try
			insert into Customers 
			values (1,'abc','abc@gmail.com')
		End Try
		Begin Catch
			print 'The Customer_id is already taken. Try another one'
		End Catch
	End

	exec PR_Customer_id_exist

--10. Handle Duplicate Email Insertion in Customers Table.
	Create or alter procedure PR_Duplicate_Email
		@Customer_id int ,
		@Customer_Name varchar(50),
		@NewEmail varchar(50)
	As
	Begin
		if exists (select 1 from Customers where Email = @NewEmail)
			Begin
				Throw 50001,'Can not insert duplicate Email please enter another Email !',1;
			End
		Else
			Begin
				insert into Customers
				values (@Customer_id,@Customer_Name,@NewEmail)
			End
	End
	
	exec PR_Duplicate_Email 2,'abc','abc@gmail.com'

	select * from Customers