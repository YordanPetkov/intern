USE Bank
GO

CREATE PROCEDURE GetSumAfterMonth(@accountId int, @interestRate float)
AS
SELECT A.*, dbo.CalculateBallance(A.Balance, @interestRate, 1) as NewBallance
FROM 
(
	SELECT Persons.*, Accounts.Balance FROM Persons
	INNER JOIN Accounts
	ON Persons.Id = Accounts.PersonId
	Where Accounts.Id = @accountId
) as A

GO