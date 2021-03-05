USE Bank
GO

CREATE PROCEDURE WithdrawMoney(@accountId int, @money money)
AS
UPDATE Accounts
SET Accounts.Balance = Accounts.Balance - @money
Where Accounts.Id = @accountId AND Accounts.Balance >= @money

GO