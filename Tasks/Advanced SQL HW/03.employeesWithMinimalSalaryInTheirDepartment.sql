SELECT CONCAT(Employees.FirstName, ' ', Employees.MiddleName, ' ', Employees.LastName) as EmployeeName,
	Employees.Salary,Departments.Name
FROM Employees
INNER JOIN 
(
	SELECT Departments.DepartmentID, Min(Employees.Salary) as minSalary
	FROM Employees FULL JOIN Departments
	ON Departments.DepartmentID = Employees.DepartmentID
	GROUP BY Departments.DepartmentID
) as DepartmentMinSalary

ON Employees.DepartmentID = DepartmentMinSalary.DepartmentID
INNER JOIN Departments
ON Employees.DepartmentID = Departments.DepartmentID
WHERE (Employees.Salary = DepartmentMinSalary.minSalary)