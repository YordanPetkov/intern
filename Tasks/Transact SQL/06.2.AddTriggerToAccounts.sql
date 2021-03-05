USE Bank
GO

CREATE TRIGGER tr_update_acc ON Accounts
AFTER UPDATE
AS

BEGIN
	DECLARE @AccountId int
	DECLARE @OldSum money
	DECLARE @NewSum money
	SELECT @AccountId = inserted.Id, @OldSum = deleted.Balance, @NewSum = inserted.Balance
	FROM inserted, deleted

	INSERT INTO Logs
	VALUES(@AccountId, @OldSum, @NewSum)
END