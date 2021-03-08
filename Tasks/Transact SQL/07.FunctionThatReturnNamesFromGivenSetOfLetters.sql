USE TelerikAcademy
GO

CREATE FUNCTION GetNames(@set varchar(50))
RETURNS TABLE
AS 
BEGIN
	DECLARE @size int;
	SET @size = LEN(@set)

	DECLARE @letters TABLE (letter char, isUsed BIT);
	DECLARE @i int = 0;

	WHILE @i < 26
	BEGIN
	  DECLARE @letter char = CHAR(@i + ASCII('a'));
	  INSERT INTO @letters VALUES (@letter,CAST(CHARINDEX(@letter, @set) as BIT))
	  SET @i = @i + 1;
	END;

	SET @i = 0;

	DECLARE @validNames TABLE (Name varchar(50));
	INSERT INTO @validNames
		SELECT * FROM
		(
			SELECT FirstName as Name FROM Employees
			UNION
			SELECT MiddleName as Name FROM Employees
			UNION
			SELECT LastName as Name FROM Employees
			UNION
			SELECT Name FROM Towns
		) as N

	DECLARE @currentLetter char, @isLetterUsed BIT
	DECLARE Letters_Cursor CURSOR
	FOR
		SELECT * From @letters

	OPEN Letters_Cursor

	FETCH NEXT FROM Employees_Cursor INTO @currentLetter, @isLetterUsed

	WHILE @@FETCH_STATUS = 0
	BEGIN
		if(@isLetterUsed = 0)
		BEGIN
			DECLARE @pattern varchar(50)
			SET @pattern = '%' + @currentLetter + '%'
			INSERT INTO @validNames (SELECT * FROM @validNames WHERE @validNames.Name NOT LIKE @pattern)
		END

		FETCH NEXT FROM Employees_Cursor INTO @currentLetter, @isLetterUsed
	END;
END;
RETURN
	SELECT * FROM 
		(SELECT FirstName as Name FROM Employees
		UNION
		SELECT MiddleName as Name FROM Employees
		UNION
		SELECT LastName as Name FROM Employees
		UNION
		SELECT Name FROM Towns
	) as Names
	WHERE Names.Name LIKE 's% b%'