USE Bank
GO

CREATE PROCEDURE DepositMoney(@accountId int, @money float)
AS
UPDATE Accounts
SET Accounts.Balance = Accounts.Balance + @money
Where Accounts.Id = @accountId

GO