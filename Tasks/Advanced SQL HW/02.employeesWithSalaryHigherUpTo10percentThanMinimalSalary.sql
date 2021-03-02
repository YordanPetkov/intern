USE TelerikAcademy
GO

SELECT * FROM Employees as e
WHERE e.Salary < 1.1 * (
	SELECT MIN(Employees.Salary) 
	FROM Employees);