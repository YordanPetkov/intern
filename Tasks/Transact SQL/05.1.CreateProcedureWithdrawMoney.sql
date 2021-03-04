USE Bank
GO

CREATE PROCEDURE WithdrawMoney(@accountId int, @money float)
AS
UPDATE Accounts
SET Accounts.Balance = Accounts.Balance - @money
Where Accounts.Id = @accountId AND Accounts.Balance >= @money

GO