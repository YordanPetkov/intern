USE TelerikAcademy
GO

DECLARE @townName varchar(50)

DECLARE Towns_Cursor CURSOR
FOR
	SELECT Towns.Name
	FROM Towns

OPEN Towns_Cursor

FETCH NEXT FROM Towns_Cursor INTO @townName

WHILE @@FETCH_STATUS = 0
BEGIN
	DECLARE @text NVARCHAR(MAX)

	SET @text = @townName + ' ->'

	DECLARE @employeeName varchar(50)

	DECLARE Employees_Cursor CURSOR
	FOR
		SELECT (Employees.FirstName + ' ' + Employees.LastName) as Name
		FROM Employees
		INNER JOIN Addresses
		ON Employees.AddressID = Addresses.AddressID
		INNER JOIN Towns
		ON Addresses.TownID = Towns.TownID
		WHERE Towns.Name = @townName

	DECLARE @firstEmployee BIT
	SET @firstEmployee = 1

	OPEN Employees_Cursor

	FETCH NEXT FROM Employees_Cursor INTO @employeeName
	WHILE @@FETCH_STATUS = 0
	BEGIN
		if(@firstEmployee = 1) 
		BEGIN
			SET @text += ' ' + @employeeName
			SET @firstEmployee = 0
		END

		else 
		BEGIN
			SET @text += ', ' + @employeeName
		END

		FETCH NEXT FROM Employees_Cursor INTO @employeeName
	END

	CLOSE Employees_Cursor
	DEALLOCATE Employees_Cursor
	
	PRINT @text

	FETCH NEXT FROM Towns_Cursor INTO @townName
END

CLOSE Towns_Cursor
DEALLOCATE Towns_Cursor