USE TelerikAcademy
GO

SELECT AVG(Employees.Salary) as averageSalary
FROM Employees
INNER JOIN Departments
ON Employees.DepartmentID = Departments.DepartmentID
WHERE Departments.Name = 'Sales'