

USE LIBRARY
GO

-- Procedure to get the amount of copies in a specific branch --

CREATE PROC uspGetAmountCopiesBranch @Book nvarchar(50), @Branch nvarchar(50)
AS
SELECT a1.No_Of_Copies AS 'No. of Copies', a2.Title, a3.BranchName AS 'Branch Name'
FROM BOOK_COPIES a1
INNER JOIN BOOK a2 ON a2.BookId = a1.BookId 
INNER JOIN LIBRARY_BRANCH a3 ON a3.BranchId = a1.BranchId
WHERE Title = @Book AND BranchName = @Branch
GO



-- Procedure to get the amount of copies in all branches --

CREATE PROC uspGetAmountCopies @Book nvarchar(50)
AS
SELECT a1.No_Of_Copies AS 'No. of Copies', a2.Title, a3.BranchName AS 'Branch Name'
FROM BOOK_COPIES a1
INNER JOIN BOOK a2 ON a2.BookId = a1.BookId 
INNER JOIN LIBRARY_BRANCH a3 ON a3.BranchId = a1.BranchId
WHERE Title = @Book
GO


-- Procedure to retrieve the names of the borrowers without any books checked out --

CREATE PROC uspGetBorrowerNoCheckout
AS
SELECT Name
FROM BORROWER
WHERE CardNo NOT IN (SELECT CardNo FROM BOOK_LOANS)
GO


-- Procedure to retrieve book name, borrowers names and addresses from branch per due date --

CREATE PROC uspGetBookDuedate @Branch nvarchar(50), @Duedate nvarchar(50)
AS
SELECT a2.Title, a3.Name, a3.Address
FROM BOOK_LOANS a1
INNER JOIN BOOK a2 ON a2.BookId = a1.BookId
INNER JOIN BORROWER a3 ON a3.CardNo = a1.CardNo
INNER JOIN LIBRARY_BRANCH a4 ON a4.BranchId = a1.BranchId
WHERE BranchName = @Branch AND DueDate = @Duedate
GO


-- Procedure to retrieve total books loaned out from branch --

CREATE PROCEDURE uspGetLoanedBooksBranch
AS
SELECT a1.BranchName AS 'Branch Name', COUNT(a2.BranchId) AS 'Loaned Books'
FROM LIBRARY_BRANCH a1
INNER JOIN BOOK_LOANS a2 ON a2.BranchId = a1.BranchId
GROUP BY BranchName
GO


-- Procedure to retrieve borrower's names, addresses and books loaned per number of books loaned --

CREATE PROCEDURE uspGetLoanedBooksBorrowers @Number INT
AS
SELECT a1.Name, a1.Address, COUNT(a2.CardNo) AS 'No. of Loaned Books'
FROM BORROWER a1
INNER JOIN BOOK_LOANS a2 ON a2.CardNo = a1.CardNo
GROUP BY Name, Address
HAVING COUNT(a2.Cardno) >= @Number
GO


-- Procedure to retrieve title and number of copies owned in a branch --

CREATE PROCEDURE uspGetTitleAuthorBranch @Author nvarchar(50), @Branch nvarchar(50)
AS
SELECT a1.Title, SUM(a2.No_Of_Copies) AS 'No. of Copies', a3.BranchName AS 'Branch Name'
FROM BOOK a1
INNER JOIN BOOK_COPIES a2 ON a2.BookId = a1.BookId
INNER JOIN LIBRARY_BRANCH a3 ON a3.BranchId = a2.BranchId
INNER JOIN BOOK_AUTHORS a4 ON a4.BookId = a1.BookId
WHERE Authorname = @Author AND BranchName = @Branch
GROUP BY Title, BranchName
GO


