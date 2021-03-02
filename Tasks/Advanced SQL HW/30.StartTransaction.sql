USE TelerikAcademy
GO

BEGIN TRANSACTION

	SAVE TRANSACTION BeforeDeleteSales

	DELETE FROM Employees
	WHERE Employees.DepartmentID = 3

	ROLLBACK TRANSACTION BeforeDeleteSales

COMMIT