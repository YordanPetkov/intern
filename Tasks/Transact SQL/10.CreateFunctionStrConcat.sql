USE TelerikAcademy
GO

CREATE TYPE string_list AS TABLE (
	string varchar(255)
);
GO

CREATE FUNCTION StrConcat(@strings string_list READONLY)
RETURNS varchar(512)
AS BEGIN
	DECLARE @newString varchar(512)

	DECLARE Strings_Cursor CURSOR
	FOR
		SELECT * FROM @strings

	OPEN Strings_Cursor

	DECLARE @currentString varchar(255)
	SET @currentString = ''

	FETCH NEXT FROM Strings_Cursor INTO @currentString
	SET @newString = @currentString

	WHILE @@FETCH_STATUS = 0
	BEGIN
		SET @newString += ',' + @currentString
		FETCH NEXT FROM Strings_Cursor INTO @currentString
	END

	RETURN @newString
END

SELECT StrConcat(FirstName + ' ' + LastName)
FROM Employees

SUM()