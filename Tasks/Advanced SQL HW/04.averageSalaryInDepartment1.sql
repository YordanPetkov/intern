USE TelerikAcademy
GO

SELECT AVG(Employees.Salary) as averageSalary
FROM Employees
WHERE Employees.DepartmentID = 1