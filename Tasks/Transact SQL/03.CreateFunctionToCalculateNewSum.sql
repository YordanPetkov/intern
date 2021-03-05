USE Bank
GO

CREATE FUNCTION dbo.CalculateBallance(@sum money, @yearlyInterestRate float, @numberOfMonths int)
RETURNS float
AS BEGIN
	DECLARE @newSum float
	SET @newSum = @sum * POWER((1 + @yearlyInterestRate / 100), @numberOfMonths / 12)
	RETURN @newSum
END

SELECT dbo.CalculateBallance(1000, 2.5, 25) as NewSum
