USE TelerikAcademy
GO

CREATE TABLE Users
(
	UserName varchar(50) UNIQUE,
	Password varchar(50),
	FullName varchar(50),
	LastLogin smalldatetime,
	CHECK (LEN(Password) >= 5)
);

INSERT INTO USERS VALUES('Ivan','ivan11','Ivan Ivanov Petkov',GETDATE())
INSERT INTO USERS VALUES('Petar','1234','Petar Georgiev Spasov',GETDATE())
INSERT INTO USERS VALUES('joris','lokolll','Georgi Todorov Todorov',GETDATE())
INSERT INTO USERS VALUES('fippol','T99Kcmms','Filip Nikolaev Ivanov',GETDATE())
INSERT INTO USERS VALUES('niko55','okil99skv','Nikolai Filipov Petrov',GETDATE())


SELECT * FROM USERS