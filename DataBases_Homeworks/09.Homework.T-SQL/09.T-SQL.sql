---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--1. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), PersonId(FK), Balance).
--Insert few records for testing.
--Write a stored procedure that selects the full names of all persons.

USE StoredProceduresHw
GO
CREATE TABLE Persons(
Id int PRIMARY KEY IDENTITY(0,1),
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
SSN nvarchar(20)
)
GO 

CREATE TABLE Accounts(
Id int PRIMARY KEY IDENTITY(0,1),
PersonId int FOREIGN KEY REFERENCES Persons(Id),
Balance money NOT NULL
)
GO

INSERT INTO Persons (FirstName,LastName,SSN)
VALUES 
('First1','Last1','122-323-32'), 
('First2','Last2','892-383-32'),
('First3','Last3','122-323-59'),
('First4','Last4','892-983-32'),
('First5','Last5','122-329-59');
GO

INSERT INTO Accounts
VALUES
(0,100),
(1,500),
(2,1000),
(3,1500),
(4,2000);
GO

CREATE PROC usp_FullNameOfAllPersons
AS
	SELECT FirstName + ' ' + LastName FROM Persons
GO

EXEC usp_FullNameOfAllPersons
GO



---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--2. Create a stored procedure that accepts a number as a parameter and returns all persons who have more money in their accounts than the supplied number.

CREATE PROCEDURE usp_PersonsWithMoreMoneyThanInputValue(@money money=1000)
AS
SELECT p.FirstName FROM Persons p, Accounts a
WHERE p.Id=a.PersonId
AND a.Balance > @money
GO

EXEC usp_PersonsWithMoreMoneyThanInputValue 10
EXEC usp_PersonsWithMoreMoneyThanInputValue 
GO



---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--3. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--It should calculate and return the new sum.
--Write a SELECT to test whether the function works as expected.

CREATE FUNCTION dbo.ufn_CalculateMoney(@sum money,@rate real,@months int)
  RETURNS money
AS
BEGIN
  RETURN @sum*(1+@months*((@rate/100)/12))
END
GO

SELECT Balance, dbo.ufn_CalculateMoney(Balance,0.5,12) AS [InterestRate] FROM Accounts
GO



---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--4. Create a stored procedure that uses the function from the previous example to give an interest to a person's account for one month.
--It should take the AccountId and the interest rate as parameters.

ALTER PROC usp_AddInterestToPerson(@accountId int,@calculatedSumAfterInterestRate money)
AS
BEGIN
UPDATE Accounts
SET Balance=@calculatedSumAfterInterestRate
WHERE Id=@accountId
END
GO

DECLARE @sum money 
SELECT @sum = dbo.ufn_CalculateMoney(Balance,0.5,1) FROM Accounts WHERE Id=10;
print(@sum)

EXEC usp_AddInterestToPerson 10, @sum
GO



---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--5. Add two more stored procedures WithdrawMoney(AccountId, money) and DepositMoney(AccountId, money) that operate in transactions.

CREATE PROCEDURE usp_WithdrawMoney(@accountId int,@sum money) 
	AS
		UPDATE Accounts 
		SET Balance = Balance - @sum
		WHERE PersonId=@accountId 
		AND Balance > @sum
GO

EXEC usp_WithdrawMoney 1,50
GO

CREATE PROCEDURE usp_DepositMoney(@accountId int,@sum money) 
	AS
		UPDATE Accounts 
		SET Balance += @sum
		WHERE PersonId=@accountId 
GO

EXEC usp_DepositMoney 1,1000
GO



---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--6.Create another table – Logs(LogID, AccountID, OldSum, NewSum).
--Add a trigger to the Accounts table that enters a new entry into the Logs table every time the sum on an account changes.

CREATE TABLE Logs(
Id int PRIMARY KEY IDENTITY(0,1),
AccountId int FOREIGN KEY REFERENCES Accounts(Id),
OldSum money NOT NULL,
NewSum money NOT NULL
)
GO

CREATE TRIGGER trg_Accounts_Insert 
ON Accounts
FOR UPDATE 
AS
DECLARE @beforeTransactionSum money;
SELECT @beforeTransactionSum =  Balance FROM deleted

INSERT INTO Logs(AccountId,OldSum,NewSum)	
SELECT Id , @beforeTransactionSum , Balance FROM inserted
PRINT('trg_Accounts_Insert fired!')
GO

Update Accounts
set Balance=100000
WHERE Id=10

--SOME OTHER TIME. When evaluating my HW, be honest, if you have done this tasks, don't give me all points ;)
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--7. Define a function in the database TelerikAcademy that returns all Employee''s names (first or middle or last name) and all town''s names that are comprised of given set
--of letters. Example 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--8. Using database cursor write a T-SQL script that scans all employees and their addresses and prints all pairs of employees that live in the same town.

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--9. * Write a T-SQL script that shows for each town a list of all employees that live in it. Sample output:
--			Sofia -> Svetlin Nakov, Martin Kulov, George Denchev
--			Ottawa -> Jose Saraiva
			
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--10. Define a .NET aggregate function StrConcat that takes as input a sequence of strings and return a single string that consists of the input strings separated by ','. 
--For example the following SQL statement should return a single string:
--			SELECT StrConcat(FirstName + ' ' + LastName)
--			FROM Employees


