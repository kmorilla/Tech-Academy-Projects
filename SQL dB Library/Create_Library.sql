

CREATE DATABASE LIBRARY

USE Library


--BEGIN CREATE TABLES--

CREATE TABLE LIBRARY_BRANCH (
	BranchId INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	BranchName VARCHAR(50) NOT NULL,
	Address VARCHAR (100) NOT NULL
)


CREATE TABLE BORROWER (
	CardNo INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(100) NOT NULL,
	Phone VARCHAR(50) NOT NULL
)


CREATE TABLE PUBLISHER (
	Name VARCHAR(50) PRIMARY KEY NOT NULL,
	Address VARCHAR(100) NOT NULL,
	Phone VARCHAR(50) NOT NULL
)


CREATE TABLE BOOK (
	BookId INT PRIMARY KEY NOT NULL IDENTITY (1,1),
	Title VARCHAR(50) NOT NULL,
	PublisherName VARCHAR(50) NOT NULL CONSTRAINT fk_PublisherName FOREIGN KEY REFERENCES PUBLISHER(Name) ON UPDATE CASCADE ON DELETE CASCADE
)


CREATE TABLE BOOK_LOANS (
	BookId INT NOT NULL CONSTRAINT fk_BOOK_LOANS_BookId FOREIGN KEY REFERENCES BOOK(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchId INT NOT NULL CONSTRAINT fk_BOOK_LOANS_BranchId FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchId) ON UPDATE CASCADE ON DELETE CASCADE,
	CardNo INT NOT NULL CONSTRAINT fk_BOOK_LOANS_CardNo FOREIGN KEY REFERENCES BORROWER(CardNo) ON UPDATE CASCADE ON DELETE CASCADE,
	DateOut DATE NOT NULL,
	DueDate DATE NOT NULL
)


CREATE TABLE BOOK_COPIES (
	BookId INT NOT NULL CONSTRAINT fk_BOOK_COPIES_BookId FOREIGN KEY REFERENCES BOOK(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	BranchId INT NOT NULL CONSTRAINT fk_BOOK_COPIES_BranchId FOREIGN KEY REFERENCES LIBRARY_BRANCH(BranchId) ON UPDATE CASCADE ON DELETE CASCADE,
	No_Of_Copies INT NOT NULL
)


CREATE TABLE BOOK_AUTHORS (
	BookId INT NOT NULL CONSTRAINT fk_BOOK_AUTHORS_BookId FOREIGN KEY REFERENCES BOOK(BookId) ON UPDATE CASCADE ON DELETE CASCADE,
	Authorname VARCHAR(50) NOT NULL,
)

--END CREATE TABLES--


--BEGIN INSERT TABLES--

INSERT INTO LIBRARY_BRANCH
	(BranchName,Address)
	VALUES 
	('Sharpstown','8900 Elk Grove Blvd, Elk Grove, CA 95624'),
	('Central','10055 Franklin High Rd, Elk Grove, CA 95757'),
	('Valley Hi','7400 Imagination Pkwy, Sacramento, CA 95823'),
	('Cosumnes','8401 Center Pkwy, Sacramento, CA 95823')
;

SELECT * FROM LIBRARY_BRANCH


INSERT INTO BORROWER
	(Name,Address,Phone)
	VALUES
	('Kevyn Morilla','5611 Tares Dr, Elk Grove, CA 95757','916-222-1587'),
	('Lynette Morilla','6708 Rawley Way, Elk Grove, CA 95757','916-759-2168'),
	('Alejandro Morilla','7824 Jacinto Rd, Sacramento, CA 95758','916-548-2349'),
	('Julian Hernandez','560 Ashwick LP, Sacramento, CA 95823','916-899-1231'),
	('Coua Vang','9524 Emerald Park Dr, Elk Grove, CA 95624','916-457-3166'),
	('Raquel Morilla','8826 Mountbatten Way, Elk Grove, CA 95624','916-771-4539'),
	('Andrea Cotton','9285 Trenholm Dr, Elk Grove, CA 95758','916-458-9965'),
	('Anahi Armenta','5650 Laguna Quail Way, Elk Grove, CA 95758','916-897-2589')
;

SELECT * FROM BORROWER


INSERT INTO PUBLISHER
	(Name,Address,Phone)
	VALUES
	('Pan Macmillan','20 New Wharf Road, London N1 9RR','+44 (0)20 7014 6000'),
	('Knopf Doubleday','1745 Broadway, New York, NY 10019','(212) 940-7390'),
	('Viking','845 East 219th St, Bronx, NY 10467','(212) 366-2000'),
	('Simon & Schuster','1230 Avenue of the Americas, New York, NY 10020','(212) 698-7000'),
	('Houghton Mifflin Harcourt','125 High Street, Boston, MA 02110','(617) 351-5000'),
	('Ballantine Books','6001 Shellmound St Ste 600, Emeryville, CA 94608','(978) 750-8400'),
	('Harper Perennial','195 Broadway 2, New York, NY 10007','(212) 964-0146'),
	('Scholastic Inc','875 National Dr, Sacramento, CA 95834','(916) 928-7822'),
	('Hachette Book Group','1700 4th St, Berkeley, CA 94710','(510) 559-9314'),
	('Norton','500 Fifth Avenue, New York, NY 10110','(212) 354-5500')
;

SELECT * FROM PUBLISHER


INSERT INTO BOOK
	(Title,PublisherName)
	VALUES
	('The Lost Tribe','Pan Macmillan'),
	('The Shining','Knopf Doubleday'),
	('It','Viking'),
	('Doctor Sleep','Simon & Schuster'),
	('The Plot Against America','Houghton Mifflin Harcourt'),
	('The Hitchhikers Guide to the Galaxy','Pan Macmillan'),
	('Billy Straight','Ballantine Books'),
	('Catch-22','Simon & Schuster'),
	('Blood Memory','Simon & Schuster'),
	('The Brain Trust Program','Pan Macmillan'),
	('Victims','Ballantine Books'),
	('To Kill a Mockingbird','Harper Perennial'),
	('Pride and Prejudice','Knopf Doubleday'),
	('Of Mice and Men','Pan Macmillan'),
	('The Book Thief','Knopf Doubleday'),
	('Harry Potter and the Order of the Phoenix','Scholastic Inc'),
	('Animal Farm','Pan Macmillan'),
	('Gone with the Wind','Hachette Book Group'),
	('The Giving Tree','Harper Perennial'),
	('Wuthering Heights','Norton')
;

SELECT * FROM BOOK


INSERT INTO BOOK_AUTHORS
	(BookId,Authorname)
	VALUES
	(1,'Mark Lee'),
	(2,'Stephen King'),
	(3,'Stephen King'),
	(4,'Stephen King'),
	(5,'Philip Roth'),
	(6,'Douglas Adams'),
	(7,'Jonathan Kellerman'),
	(8,'Joseph Heller'),
	(9,'Greg Iles'),
	(10,'Larry McCleary'),
	(11,'Jonathan Kellerman'),
	(12,'Harper Lee'),
	(13,'Jane Austen'),
	(14,'John Steinbeck'),
	(15,'Markus Zusak'),
	(16,'J K Rowling'),
	(17,'George Orwell'),
	(18,'Margaret Mitchell'),
	(19,'Shel Silverstein'),
	(20,'Emily Bronte')
;

SELECT * FROM BOOK_AUTHORS


INSERT INTO BOOK_COPIES
	(BookId,BranchId,No_Of_Copies)
	VALUES
	(1,1,2),
	(4,1,2),
	(9,1,4),
	(11,1,3),
	(12,1,2),
	(15,1,3),
	(16,1,2),
	(17,1,2),
	(18,1,2),
	(19,1,4),
	(2,2,3),
	(3,2,2),
	(5,2,2),
	(7,2,3),
	(11,2,3),
	(14,2,2),
	(16,2,4),
	(17,2,3),
	(19,2,2),
	(20,2,2),
	(1,3,2),
	(3,3,3),
	(5,3,3),
	(6,3,4),
	(7,3,2),
	(8,3,2),
	(13,3,4),
	(15,3,5),
	(16,3,2),
	(17,3,2),
	(4,4,2),
	(6,4,2),
	(9,4,4),
	(10,4,3),
	(13,4,3),
	(14,4,4),
	(15,4,4),
	(17,4,5),
	(19,4,2),
	(20,4,2)
;

SELECT * FROM BOOK_COPIES


INSERT INTO BOOK_LOANS
	(BookId,BranchId,CardNo,DateOut,DueDate)
	VALUES
	(1,1,5,'2018-04-12','2018-04-22'),
	(3,2,2,'2018-04-12','2018-04-22'),
	(7,2,6,'2018-04-12','2018-04-22'),
	(18,1,8,'2018-04-12','2018-04-22'),
	(10,4,3,'2018-04-12','2018-04-22'),
	(19,4,4,'2018-04-12','2018-04-22'),
	(16,1,4,'2018-04-13','2018-04-23'),
	(12,1,6,'2018-04-13','2018-04-23'),
	(5,2,3,'2018-04-13','2018-04-23'),
	(6,3,2,'2018-04-13','2018-04-23'),
	(2,2,2,'2018-04-14','2018-04-24'),
	(12,1,4,'2018-04-14','2018-04-24'),
	(11,1,3,'2018-04-14','2018-04-24'),
	(8,3,8,'2018-04-14','2018-04-24'),
	(5,3,2,'2018-04-14','2018-04-24'),
	(6,3,5,'2018-04-14','2018-04-24'),
	(20,2,3,'2018-04-14','2018-04-24'),
	(16,2,5,'2018-04-14','2018-04-24'),
	(15,3,4,'2018-04-15','2018-04-25'),
	(7,2,2,'2018-04-15','2018-04-25'),
	(4,1,3,'2018-04-15','2018-04-25'),
	(9,1,8,'2018-04-15','2018-04-25'),
	(1,1,8,'2018-04-15','2018-04-25'),
	(10,4,6,'2018-04-15','2018-04-25'),
	(13,3,8,'2018-04-15','2018-04-25'),
	(17,1,2,'2018-04-15','2018-04-25'),
	(15,3,5,'2018-04-16','2018-04-26'),
	(17,4,6,'2018-04-16','2018-04-26'),
	(19,1,3,'2018-04-16','2018-04-26'),
	(19,4,5,'2018-04-16','2018-04-26'),
	(4,4,4,'2018-04-17','2018-04-27'),
	(9,1,6,'2018-04-17','2018-04-27'),
	(13,4,6,'2018-04-17','2018-04-27'),
	(14,4,5,'2018-04-17','2018-04-27'),
	(2,2,3,'2018-04-17','2018-04-27'),
	(10,4,5,'2018-04-17','2018-04-27'),
	(16,3,8,'2018-04-18','2018-04-28'),
	(17,1,3,'2018-04-18','2018-04-28'),
	(17,2,4,'2018-04-19','2018-04-29'),
	(20,4,5,'2018-04-19','2018-04-29'),
	(19,2,1,'2018-04-19','2018-04-29'),
	(6,3,3,'2018-04-19','2018-04-29'),
	(9,4,6,'2018-04-20','2018-04-30'),
	(9,4,1,'2018-04-21','2018-05-01'),
	(11,2,8,'2018-04-21','2018-05-01'),
	(13,4,1,'2018-04-21','2018-05-01'),
	(4,1,2,'2018-04-21','2018-05-01'),
	(14,4,3,'2018-04-22','2018-05-02'),
	(17,4,5,'2018-04-22','2018-05-02'),
	(16,2,6,'2018-04-22','2018-05-02')
;

SELECT * FROM BOOK_LOANS

--END INSERT TABLES--
