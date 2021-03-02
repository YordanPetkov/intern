USE TelerikAcademy
GO

SELECT MinSalary.*,Employees.FirstName,Employees.LastName
FROM Employees
INNER JOIN(
SELECT 
	Departments.Name as Department,
	Employees.JobTitle,
	MIN(Employees.Salary) as [Minimal Salary]
FROM Employees
INNER JOIN Departments
ON Employees.DepartmentID = Departments.DepartmentID
GROUP BY Departments.Name, Employees.JobTitle
) MinSalary
ON Employees.JobTitle = MinSalary.JobTitle
WHERE Employees.Salary = MinSalary.[Minimal Salary]
ORDER BY MinSalary.Department,MinSalary.JobTitle
