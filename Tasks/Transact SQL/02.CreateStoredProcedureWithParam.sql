USE Bank
GO

CREATE PROCEDURE SelectPersons
	@Ballance float
AS
SELECT Persons.*
FROM Persons
INNER JOIN Accounts
ON Persons.Id = Accounts.PersonId
WHERE Accounts.Balance > @Ballance
GO
