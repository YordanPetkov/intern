USE Bank
GO

CREATE PROCEDURE DepositMoney(@accountId int, @money money)
AS
UPDATE Accounts
SET Accounts.Balance = Accounts.Balance + @money
Where Accounts.Id = @accountId

GO