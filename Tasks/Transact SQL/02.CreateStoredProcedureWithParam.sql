USE Bank
GO

CREATE PROCEDURE SelectPersons
	@Ballance money
	AS
	SELECT Persons.*
	FROM Persons
	INNER JOIN Accounts
	ON Persons.Id = Accounts.PersonId
	WHERE Accounts.Balance > @Ballance
GO