USE Bank
GO

CREATE TABLE Logs
(
	LogID int PRIMARY KEY IDENTITY,
	AccountID int FOREIGN KEY REFERENCES Accounts(Id),
	OldSum money,
	NewSum money
)