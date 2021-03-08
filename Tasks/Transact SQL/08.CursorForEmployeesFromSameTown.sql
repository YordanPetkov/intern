USE TelerikAcademy
GO

DECLARE @employeeName varchar(50)
DECLARE @employeeTown varchar(50)
DECLARE @employeeId int

DECLARE Employees_Cursor CURSOR
FOR
	SELECT Employees.FirstName + ' ' + Employees.LastName as Name,Towns.Name as Town, Employees.EmployeeID
		FROM Employees
		INNER JOIN Addresses
		ON Employees.AddressID = Addresses.AddressID
		INNER JOIN Towns
		ON Addresses.TownID = Towns.TownID

OPEN Employees_Cursor

FETCH NEXT FROM Employees_Cursor INTO @employeeName, @employeeTown, @employeeId

WHILE @@FETCH_STATUS = 0
BEGIN

	DECLARE @neighbourName varchar(50)

	DECLARE Neighbours_Cursor CURSOR
	FOR
		SELECT Employees.FirstName + ' ' + Employees.LastName as Name
		FROM Employees
		INNER JOIN Addresses
		ON Employees.AddressID = Addresses.AddressID
		INNER JOIN Towns
		ON Addresses.TownID = Towns.TownID
		WHERE Towns.Name = @employeeTown AND Employees.EmployeeID > @employeeId

	OPEN Neighbours_Cursor
	FETCH NEXT FROM Neighbours_Cursor INTO @neighbourName

	WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT @employeeName + ' - ' + @neighbourName
		FETCH NEXT FROM Neighbours_Cursor INTO @neighbourName
	END

	CLOSE Neighbours_Cursor
	DEALLOCATE Neighbours_Cursor

	FETCH NEXT FROM Employees_Cursor INTO @employeeName, @employeeTown, @employeeId
END

CLOSE Employees_Cursor
DEALLOCATE Employees_Cursor


