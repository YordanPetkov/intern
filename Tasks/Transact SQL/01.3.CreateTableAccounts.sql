USE Bank
GO

Create Table Accounts
(
	Id int PRIMARY KEY,
	PersonId int FOREIGN KEY REFERENCES Persons(Id),
	Balance float
)