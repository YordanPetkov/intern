BEGIN TRANSACTION

	SAVE TRANSACTION BeforeDeleteSales

	DELETE FROM Employees
	WHERE Employees.DepartmentID = 3

	SELECT * FROM Employees

	ROLLBACK TRANSACTION BeforeDeleteSales

COMMIT

SELECT * FROM Employees