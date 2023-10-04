USE master
GO

DROP DATABASE IF EXISTS BankCReport
GO

USE master
CREATE DATABASE BankCrystalReport
GO

USE BankCrystalReport 
GO
--====Create Schema name=======-
CREATE SCHEMA csa
GO

--DROP TABLE IF Exists csa.BranchOfBank
--GO


USE BankCrystalReport
CREATE TABLE csa.BranchOfBank
(
BranchID INT PRIMARY KEY IDENTITY(100,1),
BranchName VARCHAR(30) NOT NULL,
BranchEmail NVARCHAR(50) NOT NULL CHECK (BranchEmail LIKE '%@gmail.com'),
BranchPhoneNo VARCHAR(15) NULL
);
GO

USE BankCrystalReport
CREATE TABLE csa.Clien
(
ClienID	INT PRIMARY KEY IDENTITY,
CName NVARCHAR(20) NOT NULL,
CAddress VARCHAR(40) NOT NULL,
CDOB DateTime Null,
CGender VARCHAR(15) NULL,
CPhoto VARBINARY(MAX) NULL,
BranchID INT FOREIGN KEY REFERENCES csa.BranchOfBank(BranchID)
);
Go

USE BankCrystalReport
CREATE TABLE  csa.Deposit
(
AccNumber INT PRIMARY KEY IDENTITY,
BegBalance MONEY,
DeBalance MONEY,
EndBalance MONEY,
ClienID INT FOREIGN KEY REFERENCES csa.Clien(ClienID),
BranchID INT FOREIGN KEY REFERENCES  csa.BranchOfBank(BranchID)
);
GO

USE BankCrystalReport
Create Table csa.Withdraw 
(
WithdrawID INT IDENTITY,
WitAmount MONEY,
AccNumber INT FOREIGN KEY REFERENCES csa.Deposit(AccNumber)
);
GO

SELECT * FROM csa.BranchOfBank
SELECT * FROM csa.Clien
SELECT * FROM csa.Deposit
SELECT * FROM csa.Withdraw
GO
       --======Create View======--
CREATE VIEW vw_BalanceDetail
AS
	(
	SELECT D.AccNumber, CName, BegBalance,WitAmount, EndBalance
	FROM csa.Deposit AS D
	JOIN csa.Withdraw  AS W
	ON D.AccNumber = W.AccNumber
	JOIN csa.Clien AS C
	ON C.ClienID= D.ClienID
	);
GO

SELECT * FROM vw_BalanceDetail
GO

   --===View With SCHEMABINDING====--
CREATE VIEW vw_Balance
WITH SCHEMABINDING
AS
(
	SELECT D.AccNumber, BegBalance, DeBalance, WitAmount, EndBalance
	FROM csa.Deposit AS D
	JOIN csa.Withdraw  AS W
	ON D.AccNumber = W.AccNumber
	);
GO

--=====Create Store Procedure And Sproc With Commit,Rollbac,Try,Catch=====-
--==========================================================================--

--====Create Store Procedure=====--
CREATE PROC sp_CrudOperationAA
@branchID INT,
@branchName VARCHAR(30),
@branchEmail VARCHAR(40),
@branchPhoneNo VARCHAR(15),

@clienID INT,
@cName VARCHAR(15),
@cAddress VARCHAR(40),
@cDOB DateTime,
@cgender VARCHAR(15),
@cphoto  VARBINARY(MAX) NULL,
@cbranchID INT,

@tablename varchar(25),
@operationname varchar(20)

AS
BEGIN
	IF (@tablename = 'BranchOfBank' AND @operationname = 'INSERT')
		BEGIN
			Insert INTO csa.BranchOfBank values(@branchName, @branchEmail, @branchPhoneNo)
		END
	IF (@tablename = 'BranchOfBank' AND @operationname = 'UPDATE')
		BEGIN
			UPDATE csa.BranchOfBank  SET BranchName = @branchName, BranchEmail = @branchEmail, 
									   	 BranchPhoneNo = @branchPhoneNo WHERE BranchID=@branchID    --(WHERE BranchID=BranchID)
		END
	IF (@tablename = 'BranchOfBank' AND @operationname = 'DELETE')
		BEGIN
			DELETE FROM csa.BranchOfBank WHERE BranchID=@branchID      --(WHERE BranchID=BranchID)
		END



	IF (@tablename = 'Clien' AND @operationname = 'INSERT')
		BEGIN
			Insert INTO csa.Clien values(@cName,@cAddress,@cDOB,@cgender,@cphoto,@cbranchID)
		END
	IF (@tablename = 'Clien' AND @operationname = 'UPDATE')
		BEGIN
			UPDATE csa.Clien SET CName = @cName, CAddress = @cAddress,
					 CDOB=@cDOB,CGender=@cgender, CPhoto=@cphoto, BranchID= @cbranchID WHERE ClienID=@clienID
		END
	IF (@tablename = 'Clien' AND @operationname = 'DELETE')
		BEGIN
			DELETE FROM csa.Clien WHERE ClienID=@clienID
		END
END
GO


--====Create Store Procedure for Brance=====--
CREATE PROC sp_Bramch
@brancID INT,
@brancName VARCHAR(30),
@brancEmail VARCHAR(40),
@brancPhoneNo VARCHAR(15),

@tablename varchar(25),
@operationname varchar(20)

AS
BEGIN
	IF (@tablename = 'BranchOfBank' AND @operationname = 'INSERT')
		BEGIN
			Insert INTO csa.BranchOfBank values(@brancName, @brancEmail, @brancPhoneNo)
		END
	IF (@tablename = 'BranchOfBank' AND @operationname = 'UPDATE')
		BEGIN
			UPDATE csa.BranchOfBank  SET BranchName = @brancName, BranchEmail = @brancEmail, 
									   	 BranchPhoneNo = @brancPhoneNo WHERE BranchID=@brancID    --(WHERE BranchID=BranchID)
		END
	IF (@tablename = 'BranchOfBank' AND @operationname = 'DELETE')
		BEGIN
			DELETE FROM csa.BranchOfBank WHERE BranchID=@brancID      --(WHERE BranchID=BranchID)
		END
END
GO


     --====Scalar Function=======--
CREATE FUNCTION fn_TotalBalance
 (
	 @begBalance MONEY,
	 @depobalance MONEY
 )
RETURNS MONEY
AS
BEGIN
    DECLARE @TotalBalance MONEY
    SET @TotalBalance = (@begBalance + @depobalance)
    RETURN @TotalBalance
END
GO