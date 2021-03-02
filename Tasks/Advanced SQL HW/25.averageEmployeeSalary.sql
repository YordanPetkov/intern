USE TelerikAcademy
GO

SELECT Departments.Name as [Department Name],
	Employees.JobTitle,
	AVG(Employees.Salary) as [Average salary]
FROM Employees
INNER JOIN Departments
ON Employees.DepartmentID = Departments.DepartmentID
GROUP BY Employees.JobTitle,Departments.Name